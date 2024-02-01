Public Class Form1
    Dim cantidad As Integer
    Dim nombres() As String
    Dim parciales() As Integer
    Dim proyectos() As Integer
    Dim semestrales() As Integer
    Dim promedioFinal() As Integer
    Dim notaFinal() As Char

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox2.Enabled = False
    End Sub


    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Verificar()
    End Sub

    Sub Verificar()
        cantidad = Val(tbCantidad.Text)
        If (cantidad <= 0) Then
            MsgBox("Favor verifique el dato cantidad")
        Else
            Capturar_Datos()
            Establecer_NotaFinal()
            GroupBox2.Enabled = True
            Resultados()
        End If

    End Sub

    Sub Capturar_Datos()
        ReDim nombres(cantidad)
        ReDim parciales(cantidad)
        ReDim proyectos(cantidad)
        ReDim semestrales(cantidad)
        ReDim promedioFinal(cantidad)
        ReDim notaFinal(cantidad)

        For i = 1 To cantidad
            MsgBox("Estudiante #" & i)
            nombres(i) = InputBox("Ingrese el nombre:")
            parciales(i) = Val(InputBox("Ingrese el promedio obtenido de parciales:"))
            proyectos(i) = Val(InputBox("Ingrese el promedio obtenido de proyectos:"))
            semestrales(i) = Val(InputBox("Ingrese el promedio obtenido del semestral:"))
            promedioFinal(i) = parciales(i) + proyectos(i) + semestrales(i)
        Next





    End Sub

    Sub Establecer_NotaFinal()
        For i = 0 To cantidad
            Select Case promedioFinal(i)
                Case 0 To 60
                    notaFinal(i) = "F"

                Case 61 To 70
                    notaFinal(i) = "D"

                Case 71 To 80
                    notaFinal(i) = "C"

                Case 81 To 90
                    notaFinal(i) = "B"

                Case Else
                    notaFinal(i) = "A"

            End Select
        Next

    End Sub

    Sub Resultados()

        Dim caaux As Integer = promedioFinal.Length - 1

        Dim indice1(caaux) As Integer

        For i = 0 To caaux
            indice1(i) = i
        Next

        Array.Sort(promedioFinal, indice1)

        Dim tempNombres(caaux) As String
        Dim tempNotasFinales(caaux) As Char

        Array.Clear(tempNombres, 0, tempNombres.Length)
        Array.Clear(tempNotasFinales, 0, tempNombres.Length)

        Dim pos As Integer

        For i = 0 To caaux
            pos = indice1(i)

            tempNombres(i) = nombres(pos)

            tempNotasFinales(i) = notaFinal(pos)

        Next

        Array.Copy(tempNombres, nombres, nombres.Length)
        Array.Copy(tempNotasFinales, notaFinal, notaFinal.Length)



        Dim r As Integer = 1

        For i = cantidad To r Step -1     'Imprimimos en orden inverso, descendente

            lbEstudiantes.Items.Add(nombres(i))
            lbNotasFinales.Items.Add(notaFinal(i))
        Next
    End Sub


End Class

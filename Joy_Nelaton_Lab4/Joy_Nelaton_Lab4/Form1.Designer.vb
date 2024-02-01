<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.tbCantidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbNotasFinales = New System.Windows.Forms.ListBox()
        Me.lbEstudiantes = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(176, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(433, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGISTRO DE ESTUDIANTES"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSiguiente)
        Me.GroupBox1.Controls.Add(Me.tbCantidad)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 289)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESO DE INFORMACION"
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(49, 118)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(123, 36)
        Me.btnSiguiente.TabIndex = 2
        Me.btnSiguiente.Text = "SIGUIENTE"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'tbCantidad
        '
        Me.tbCantidad.Location = New System.Drawing.Point(153, 46)
        Me.tbCantidad.Name = "tbCantidad"
        Me.tbCantidad.Size = New System.Drawing.Size(48, 22)
        Me.tbCantidad.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "# de Estudiantes: "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbNotasFinales)
        Me.GroupBox2.Controls.Add(Me.lbEstudiantes)
        Me.GroupBox2.Location = New System.Drawing.Point(328, 101)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(488, 279)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "RESULTADOS"
        '
        'lbNotasFinales
        '
        Me.lbNotasFinales.FormattingEnabled = True
        Me.lbNotasFinales.ItemHeight = 16
        Me.lbNotasFinales.Location = New System.Drawing.Point(284, 68)
        Me.lbNotasFinales.Name = "lbNotasFinales"
        Me.lbNotasFinales.Size = New System.Drawing.Size(171, 196)
        Me.lbNotasFinales.TabIndex = 1
        '
        'lbEstudiantes
        '
        Me.lbEstudiantes.FormattingEnabled = True
        Me.lbEstudiantes.ItemHeight = 16
        Me.lbEstudiantes.Location = New System.Drawing.Point(20, 68)
        Me.lbEstudiantes.Name = "lbEstudiantes"
        Me.lbEstudiantes.Size = New System.Drawing.Size(171, 196)
        Me.lbEstudiantes.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 392)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "LAB 4 NELATON JOY"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents tbCantidad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbNotasFinales As ListBox
    Friend WithEvents lbEstudiantes As ListBox
End Class

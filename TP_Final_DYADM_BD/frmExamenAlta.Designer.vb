<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExamenAlta
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbAlumno = New System.Windows.Forms.ComboBox()
        Me.dtpFechaInscripcion = New System.Windows.Forms.DateTimePicker()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.cmbCodTurno = New System.Windows.Forms.ComboBox()
        Me.cmbCodMat = New System.Windows.Forms.ComboBox()
        Me.txtNota = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Alumno = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(241, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Ejemplo: 10"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(241, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Ejemplo: 2019"
        '
        'cmbAlumno
        '
        Me.cmbAlumno.FormattingEnabled = True
        Me.cmbAlumno.Location = New System.Drawing.Point(132, 12)
        Me.cmbAlumno.Name = "cmbAlumno"
        Me.cmbAlumno.Size = New System.Drawing.Size(200, 21)
        Me.cmbAlumno.TabIndex = 1
        '
        'dtpFechaInscripcion
        '
        Me.dtpFechaInscripcion.Location = New System.Drawing.Point(132, 206)
        Me.dtpFechaInscripcion.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        Me.dtpFechaInscripcion.MinDate = New Date(1900, 12, 31, 0, 0, 0, 0)
        Me.dtpFechaInscripcion.Name = "dtpFechaInscripcion"
        Me.dtpFechaInscripcion.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaInscripcion.TabIndex = 6
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(132, 133)
        Me.txtAño.MaxLength = 4
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(100, 20)
        Me.txtAño.TabIndex = 4
        '
        'cmbCodTurno
        '
        Me.cmbCodTurno.FormattingEnabled = True
        Me.cmbCodTurno.Location = New System.Drawing.Point(132, 96)
        Me.cmbCodTurno.Name = "cmbCodTurno"
        Me.cmbCodTurno.Size = New System.Drawing.Size(100, 21)
        Me.cmbCodTurno.TabIndex = 3
        '
        'cmbCodMat
        '
        Me.cmbCodMat.FormattingEnabled = True
        Me.cmbCodMat.Location = New System.Drawing.Point(132, 55)
        Me.cmbCodMat.Name = "cmbCodMat"
        Me.cmbCodMat.Size = New System.Drawing.Size(200, 21)
        Me.cmbCodMat.TabIndex = 2
        '
        'txtNota
        '
        Me.txtNota.Location = New System.Drawing.Point(132, 166)
        Me.txtNota.MaxLength = 2
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(100, 20)
        Me.txtNota.TabIndex = 5
        Me.txtNota.Tag = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Fecha de inscripcion: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(85, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Nota: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(89, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Año: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Turno: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Materia: "
        '
        'Alumno
        '
        Me.Alumno.AutoSize = True
        Me.Alumno.Location = New System.Drawing.Point(78, 12)
        Me.Alumno.Name = "Alumno"
        Me.Alumno.Size = New System.Drawing.Size(48, 13)
        Me.Alumno.TabIndex = 28
        Me.Alumno.Text = "Alumno: "
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrar.Location = New System.Drawing.Point(145, 258)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrar.TabIndex = 7
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Location = New System.Drawing.Point(308, 258)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(46, 23)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmExamenAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 293)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbAlumno)
        Me.Controls.Add(Me.dtpFechaInscripcion)
        Me.Controls.Add(Me.txtAño)
        Me.Controls.Add(Me.cmbCodTurno)
        Me.Controls.Add(Me.cmbCodMat)
        Me.Controls.Add(Me.txtNota)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Alumno)
        Me.Name = "frmExamenAlta"
        Me.Text = "Alta de Examen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbAlumno As ComboBox
    Friend WithEvents dtpFechaInscripcion As DateTimePicker
    Friend WithEvents txtAño As TextBox
    Friend WithEvents cmbCodTurno As ComboBox
    Friend WithEvents cmbCodMat As ComboBox
    Friend WithEvents txtNota As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Alumno As Label
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnSalir As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAluAlta
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
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblNroDoc = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblTipoDoc = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.lblEstCivil = New System.Windows.Forms.Label()
        Me.lblContrasenia = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.cmbTipoDoc = New System.Windows.Forms.ComboBox()
        Me.txtNumDoc = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.rbMasculino = New System.Windows.Forms.RadioButton()
        Me.rbFemenino = New System.Windows.Forms.RadioButton()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.cmbEstCivil = New System.Windows.Forms.ComboBox()
        Me.txtContrasenia = New System.Windows.Forms.TextBox()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.lblContrasenia2 = New System.Windows.Forms.Label()
        Me.txtContrasenia2 = New System.Windows.Forms.TextBox()
        Me.txtNroLegajo = New System.Windows.Forms.TextBox()
        Me.lblNroLegajo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(81, 45)
        Me.lblApellido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(47, 13)
        Me.lblApellido.TabIndex = 0
        Me.lblApellido.Text = "Apellido:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(81, 68)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre:"
        '
        'lblNroDoc
        '
        Me.lblNroDoc.AutoSize = True
        Me.lblNroDoc.Location = New System.Drawing.Point(26, 119)
        Me.lblNroDoc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNroDoc.Name = "lblNroDoc"
        Me.lblNroDoc.Size = New System.Drawing.Size(103, 13)
        Me.lblNroDoc.TabIndex = 2
        Me.lblNroDoc.Text = "Nro. de Documento:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(74, 145)
        Me.lblDireccion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(55, 13)
        Me.lblDireccion.TabIndex = 3
        Me.lblDireccion.Text = "Direccion:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(89, 171)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(38, 13)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "E-mail:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(76, 199)
        Me.lblTelefono.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefono.TabIndex = 5
        Me.lblTelefono.Text = "Telefono:"
        '
        'lblTipoDoc
        '
        Me.lblTipoDoc.AutoSize = True
        Me.lblTipoDoc.Location = New System.Drawing.Point(26, 93)
        Me.lblTipoDoc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTipoDoc.Name = "lblTipoDoc"
        Me.lblTipoDoc.Size = New System.Drawing.Size(104, 13)
        Me.lblTipoDoc.TabIndex = 6
        Me.lblTipoDoc.Text = "Tipo de Documento:"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(95, 228)
        Me.lblSexo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(34, 13)
        Me.lblSexo.TabIndex = 7
        Me.lblSexo.Text = "Sexo:"
        '
        'lblFechaNac
        '
        Me.lblFechaNac.AutoSize = True
        Me.lblFechaNac.Location = New System.Drawing.Point(19, 256)
        Me.lblFechaNac.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(111, 13)
        Me.lblFechaNac.TabIndex = 8
        Me.lblFechaNac.Text = "Fecha de Nacimiento:"
        '
        'lblEstCivil
        '
        Me.lblEstCivil.AutoSize = True
        Me.lblEstCivil.Location = New System.Drawing.Point(64, 288)
        Me.lblEstCivil.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEstCivil.Name = "lblEstCivil"
        Me.lblEstCivil.Size = New System.Drawing.Size(65, 13)
        Me.lblEstCivil.TabIndex = 9
        Me.lblEstCivil.Text = "Estado Civil:"
        '
        'lblContrasenia
        '
        Me.lblContrasenia.AutoSize = True
        Me.lblContrasenia.Location = New System.Drawing.Point(64, 324)
        Me.lblContrasenia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblContrasenia.Name = "lblContrasenia"
        Me.lblContrasenia.Size = New System.Drawing.Size(64, 13)
        Me.lblContrasenia.TabIndex = 11
        Me.lblContrasenia.Text = "Contraseña:"
        '
        'txtApellido
        '
        Me.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellido.Location = New System.Drawing.Point(141, 41)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(160, 20)
        Me.txtApellido.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(141, 68)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(160, 20)
        Me.txtNombre.TabIndex = 3
        '
        'cmbTipoDoc
        '
        Me.cmbTipoDoc.FormattingEnabled = True
        Me.cmbTipoDoc.Location = New System.Drawing.Point(141, 93)
        Me.cmbTipoDoc.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbTipoDoc.Name = "cmbTipoDoc"
        Me.cmbTipoDoc.Size = New System.Drawing.Size(160, 21)
        Me.cmbTipoDoc.TabIndex = 4
        '
        'txtNumDoc
        '
        Me.txtNumDoc.Location = New System.Drawing.Point(141, 119)
        Me.txtNumDoc.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNumDoc.Name = "txtNumDoc"
        Me.txtNumDoc.Size = New System.Drawing.Size(160, 20)
        Me.txtNumDoc.TabIndex = 15
        '
        'txtDireccion
        '
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion.Location = New System.Drawing.Point(141, 145)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(160, 20)
        Me.txtDireccion.TabIndex = 6
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(141, 171)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(160, 20)
        Me.txtEmail.TabIndex = 7
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(141, 199)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(160, 20)
        Me.txtTelefono.TabIndex = 8
        '
        'rbMasculino
        '
        Me.rbMasculino.AutoSize = True
        Me.rbMasculino.Location = New System.Drawing.Point(141, 228)
        Me.rbMasculino.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbMasculino.Name = "rbMasculino"
        Me.rbMasculino.Size = New System.Drawing.Size(73, 17)
        Me.rbMasculino.TabIndex = 9
        Me.rbMasculino.TabStop = True
        Me.rbMasculino.Text = "Masculino"
        Me.rbMasculino.UseVisualStyleBackColor = True
        '
        'rbFemenino
        '
        Me.rbFemenino.AutoSize = True
        Me.rbFemenino.Location = New System.Drawing.Point(232, 228)
        Me.rbFemenino.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbFemenino.Name = "rbFemenino"
        Me.rbFemenino.Size = New System.Drawing.Size(71, 17)
        Me.rbFemenino.TabIndex = 10
        Me.rbFemenino.TabStop = True
        Me.rbFemenino.Text = "Femenino"
        Me.rbFemenino.UseVisualStyleBackColor = True
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.Location = New System.Drawing.Point(141, 256)
        Me.dtpFechaNac.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(160, 20)
        Me.dtpFechaNac.TabIndex = 11
        '
        'cmbEstCivil
        '
        Me.cmbEstCivil.FormattingEnabled = True
        Me.cmbEstCivil.Location = New System.Drawing.Point(136, 288)
        Me.cmbEstCivil.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbEstCivil.Name = "cmbEstCivil"
        Me.cmbEstCivil.Size = New System.Drawing.Size(164, 21)
        Me.cmbEstCivil.TabIndex = 12
        '
        'txtContrasenia
        '
        Me.txtContrasenia.Location = New System.Drawing.Point(136, 324)
        Me.txtContrasenia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtContrasenia.Name = "txtContrasenia"
        Me.txtContrasenia.Size = New System.Drawing.Size(164, 20)
        Me.txtContrasenia.TabIndex = 13
        '
        'btnAlta
        '
        Me.btnAlta.Location = New System.Drawing.Point(98, 381)
        Me.btnAlta.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(87, 19)
        Me.btnAlta.TabIndex = 15
        Me.btnAlta.Text = "Nueva Alta"
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'lblContrasenia2
        '
        Me.lblContrasenia2.AutoSize = True
        Me.lblContrasenia2.Location = New System.Drawing.Point(26, 352)
        Me.lblContrasenia2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblContrasenia2.Name = "lblContrasenia2"
        Me.lblContrasenia2.Size = New System.Drawing.Size(101, 13)
        Me.lblContrasenia2.TabIndex = 26
        Me.lblContrasenia2.Text = "Repetir Contraseña:"
        '
        'txtContrasenia2
        '
        Me.txtContrasenia2.Location = New System.Drawing.Point(136, 352)
        Me.txtContrasenia2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtContrasenia2.Name = "txtContrasenia2"
        Me.txtContrasenia2.Size = New System.Drawing.Size(164, 20)
        Me.txtContrasenia2.TabIndex = 14
        '
        'txtNroLegajo
        '
        Me.txtNroLegajo.Location = New System.Drawing.Point(141, 18)
        Me.txtNroLegajo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNroLegajo.Name = "txtNroLegajo"
        Me.txtNroLegajo.Size = New System.Drawing.Size(160, 20)
        Me.txtNroLegajo.TabIndex = 1
        '
        'lblNroLegajo
        '
        Me.lblNroLegajo.AutoSize = True
        Me.lblNroLegajo.Location = New System.Drawing.Point(31, 22)
        Me.lblNroLegajo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNroLegajo.Name = "lblNroLegajo"
        Me.lblNroLegajo.Size = New System.Drawing.Size(97, 13)
        Me.lblNroLegajo.TabIndex = 29
        Me.lblNroLegajo.Text = "Numero de Legajo:"
        '
        'frmAluAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 450)
        Me.Controls.Add(Me.lblNroLegajo)
        Me.Controls.Add(Me.txtNroLegajo)
        Me.Controls.Add(Me.txtContrasenia2)
        Me.Controls.Add(Me.lblContrasenia2)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.txtContrasenia)
        Me.Controls.Add(Me.cmbEstCivil)
        Me.Controls.Add(Me.dtpFechaNac)
        Me.Controls.Add(Me.rbFemenino)
        Me.Controls.Add(Me.rbMasculino)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNumDoc)
        Me.Controls.Add(Me.cmbTipoDoc)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.lblContrasenia)
        Me.Controls.Add(Me.lblEstCivil)
        Me.Controls.Add(Me.lblFechaNac)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.lblTipoDoc)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblNroDoc)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblApellido)
        Me.Name = "frmAluAlta"
        Me.Text = "Alta de Alumnos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblApellido As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblNroDoc As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblTipoDoc As Label
    Friend WithEvents lblSexo As Label
    Friend WithEvents lblFechaNac As Label
    Friend WithEvents lblEstCivil As Label
    Friend WithEvents lblContrasenia As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents cmbTipoDoc As ComboBox
    Friend WithEvents txtNumDoc As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents rbMasculino As RadioButton
    Friend WithEvents rbFemenino As RadioButton
    Friend WithEvents dtpFechaNac As DateTimePicker
    Friend WithEvents cmbEstCivil As ComboBox
    Friend WithEvents txtContrasenia As TextBox
    Friend WithEvents btnAlta As Button
    Friend WithEvents lblContrasenia2 As Label
    Friend WithEvents txtContrasenia2 As TextBox
    Friend WithEvents txtNroLegajo As TextBox
    Friend WithEvents lblNroLegajo As Label
End Class

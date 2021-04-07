<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfAlta
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
        Me.cmbEstCivil = New System.Windows.Forms.ComboBox()
        Me.cmbTipoDoc = New System.Windows.Forms.ComboBox()
        Me.txtNroLegajo = New System.Windows.Forms.TextBox()
        Me.lblNroLegajo = New System.Windows.Forms.Label()
        Me.lblCodAcceso = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblEstadoCivil = New System.Windows.Forms.Label()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.cmbTitulo = New System.Windows.Forms.ComboBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.rbMasculino = New System.Windows.Forms.RadioButton()
        Me.rbFemenino = New System.Windows.Forms.RadioButton()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNroDoc = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblNroDoc = New System.Windows.Forms.Label()
        Me.txtApyNom = New System.Windows.Forms.TextBox()
        Me.lblTipoDoc = New System.Windows.Forms.Label()
        Me.lblApeyNom = New System.Windows.Forms.Label()
        Me.btnRegistrarProfesor = New System.Windows.Forms.Button()
        Me.cmbCodAcceso = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cmbEstCivil
        '
        Me.cmbEstCivil.FormattingEnabled = True
        Me.cmbEstCivil.Location = New System.Drawing.Point(155, 279)
        Me.cmbEstCivil.Name = "cmbEstCivil"
        Me.cmbEstCivil.Size = New System.Drawing.Size(134, 21)
        Me.cmbEstCivil.TabIndex = 11
        Me.cmbEstCivil.Text = "Seleccione"
        '
        'cmbTipoDoc
        '
        Me.cmbTipoDoc.FormattingEnabled = True
        Me.cmbTipoDoc.Location = New System.Drawing.Point(155, 73)
        Me.cmbTipoDoc.Name = "cmbTipoDoc"
        Me.cmbTipoDoc.Size = New System.Drawing.Size(90, 21)
        Me.cmbTipoDoc.TabIndex = 3
        Me.cmbTipoDoc.Text = "Seleccione"
        '
        'txtNroLegajo
        '
        Me.txtNroLegajo.Enabled = False
        Me.txtNroLegajo.Location = New System.Drawing.Point(155, 22)
        Me.txtNroLegajo.Name = "txtNroLegajo"
        Me.txtNroLegajo.Size = New System.Drawing.Size(100, 20)
        Me.txtNroLegajo.TabIndex = 1
        '
        'lblNroLegajo
        '
        Me.lblNroLegajo.AutoSize = True
        Me.lblNroLegajo.Location = New System.Drawing.Point(87, 25)
        Me.lblNroLegajo.Name = "lblNroLegajo"
        Me.lblNroLegajo.Size = New System.Drawing.Size(62, 13)
        Me.lblNroLegajo.TabIndex = 55
        Me.lblNroLegajo.Text = "Nro. Legajo"
        '
        'lblCodAcceso
        '
        Me.lblCodAcceso.AutoSize = True
        Me.lblCodAcceso.Location = New System.Drawing.Point(56, 336)
        Me.lblCodAcceso.Name = "lblCodAcceso"
        Me.lblCodAcceso.Size = New System.Drawing.Size(93, 13)
        Me.lblCodAcceso.TabIndex = 54
        Me.lblCodAcceso.Text = "Codigo de acceso"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(116, 309)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(33, 13)
        Me.lblTitulo.TabIndex = 53
        Me.lblTitulo.Text = "Titulo"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(88, 362)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(61, 13)
        Me.lblPass.TabIndex = 52
        Me.lblPass.Text = "Contraseña"
        '
        'lblEstadoCivil
        '
        Me.lblEstadoCivil.AutoSize = True
        Me.lblEstadoCivil.Location = New System.Drawing.Point(88, 282)
        Me.lblEstadoCivil.Name = "lblEstadoCivil"
        Me.lblEstadoCivil.Size = New System.Drawing.Size(61, 13)
        Me.lblEstadoCivil.TabIndex = 51
        Me.lblEstadoCivil.Text = "Estado civil"
        '
        'lblFechaNac
        '
        Me.lblFechaNac.AutoSize = True
        Me.lblFechaNac.Location = New System.Drawing.Point(43, 251)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(106, 13)
        Me.lblFechaNac.TabIndex = 50
        Me.lblFechaNac.Text = "Fecha de nacimiento"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(118, 218)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(31, 13)
        Me.lblSexo.TabIndex = 49
        Me.lblSexo.Text = "Sexo"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(100, 181)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefono.TabIndex = 48
        Me.lblTelefono.Text = "Telefono"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(117, 155)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 47
        Me.lblEmail.Text = "Email"
        '
        'cmbTitulo
        '
        Me.cmbTitulo.FormattingEnabled = True
        Me.cmbTitulo.Location = New System.Drawing.Point(155, 306)
        Me.cmbTitulo.Name = "cmbTitulo"
        Me.cmbTitulo.Size = New System.Drawing.Size(134, 21)
        Me.cmbTitulo.TabIndex = 12
        Me.cmbTitulo.Text = "Seleccione"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(155, 359)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(118, 20)
        Me.txtPass.TabIndex = 14
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.Location = New System.Drawing.Point(155, 248)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaNac.TabIndex = 10
        '
        'rbMasculino
        '
        Me.rbMasculino.AutoSize = True
        Me.rbMasculino.Location = New System.Drawing.Point(211, 216)
        Me.rbMasculino.Name = "rbMasculino"
        Me.rbMasculino.Size = New System.Drawing.Size(34, 17)
        Me.rbMasculino.TabIndex = 9
        Me.rbMasculino.TabStop = True
        Me.rbMasculino.Text = "M"
        Me.rbMasculino.UseVisualStyleBackColor = True
        '
        'rbFemenino
        '
        Me.rbFemenino.AutoSize = True
        Me.rbFemenino.Location = New System.Drawing.Point(164, 216)
        Me.rbFemenino.Name = "rbFemenino"
        Me.rbFemenino.Size = New System.Drawing.Size(31, 17)
        Me.rbFemenino.TabIndex = 8
        Me.rbFemenino.TabStop = True
        Me.rbFemenino.Text = "F"
        Me.rbFemenino.UseVisualStyleBackColor = True
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(155, 178)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(118, 20)
        Me.txtTelefono.TabIndex = 7
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(155, 152)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(184, 20)
        Me.txtEmail.TabIndex = 6
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(155, 126)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(184, 20)
        Me.txtDireccion.TabIndex = 5
        '
        'txtNroDoc
        '
        Me.txtNroDoc.Location = New System.Drawing.Point(155, 100)
        Me.txtNroDoc.Name = "txtNroDoc"
        Me.txtNroDoc.Size = New System.Drawing.Size(118, 20)
        Me.txtNroDoc.TabIndex = 4
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(97, 129)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion.TabIndex = 36
        Me.lblDireccion.Text = "Direccion"
        '
        'lblNroDoc
        '
        Me.lblNroDoc.AutoSize = True
        Me.lblNroDoc.Location = New System.Drawing.Point(34, 103)
        Me.lblNroDoc.Name = "lblNroDoc"
        Me.lblNroDoc.Size = New System.Drawing.Size(115, 13)
        Me.lblNroDoc.TabIndex = 35
        Me.lblNroDoc.Text = "Numero de documento"
        '
        'txtApyNom
        '
        Me.txtApyNom.Location = New System.Drawing.Point(155, 48)
        Me.txtApyNom.Name = "txtApyNom"
        Me.txtApyNom.Size = New System.Drawing.Size(184, 20)
        Me.txtApyNom.TabIndex = 2
        '
        'lblTipoDoc
        '
        Me.lblTipoDoc.AutoSize = True
        Me.lblTipoDoc.Location = New System.Drawing.Point(50, 76)
        Me.lblTipoDoc.Name = "lblTipoDoc"
        Me.lblTipoDoc.Size = New System.Drawing.Size(99, 13)
        Me.lblTipoDoc.TabIndex = 33
        Me.lblTipoDoc.Text = "Tipo de documento"
        '
        'lblApeyNom
        '
        Me.lblApeyNom.AutoSize = True
        Me.lblApeyNom.Location = New System.Drawing.Point(59, 51)
        Me.lblApeyNom.Name = "lblApeyNom"
        Me.lblApeyNom.Size = New System.Drawing.Size(90, 13)
        Me.lblApeyNom.TabIndex = 32
        Me.lblApeyNom.Text = "Apellido y nombre"
        '
        'btnRegistrarProfesor
        '
        Me.btnRegistrarProfesor.Location = New System.Drawing.Point(155, 399)
        Me.btnRegistrarProfesor.Name = "btnRegistrarProfesor"
        Me.btnRegistrarProfesor.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrarProfesor.TabIndex = 15
        Me.btnRegistrarProfesor.Text = "Registrar"
        Me.btnRegistrarProfesor.UseVisualStyleBackColor = True
        '
        'cmbCodAcceso
        '
        Me.cmbCodAcceso.FormattingEnabled = True
        Me.cmbCodAcceso.Location = New System.Drawing.Point(155, 333)
        Me.cmbCodAcceso.Name = "cmbCodAcceso"
        Me.cmbCodAcceso.Size = New System.Drawing.Size(134, 21)
        Me.cmbCodAcceso.TabIndex = 13
        '
        'frmProfAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 434)
        Me.Controls.Add(Me.cmbCodAcceso)
        Me.Controls.Add(Me.btnRegistrarProfesor)
        Me.Controls.Add(Me.cmbEstCivil)
        Me.Controls.Add(Me.cmbTipoDoc)
        Me.Controls.Add(Me.txtNroLegajo)
        Me.Controls.Add(Me.lblNroLegajo)
        Me.Controls.Add(Me.lblCodAcceso)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblEstadoCivil)
        Me.Controls.Add(Me.lblFechaNac)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.cmbTitulo)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.dtpFechaNac)
        Me.Controls.Add(Me.rbMasculino)
        Me.Controls.Add(Me.rbFemenino)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNroDoc)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblNroDoc)
        Me.Controls.Add(Me.txtApyNom)
        Me.Controls.Add(Me.lblTipoDoc)
        Me.Controls.Add(Me.lblApeyNom)
        Me.Name = "frmProfAlta"
        Me.Text = "Agregar profesor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbEstCivil As ComboBox
    Friend WithEvents cmbTipoDoc As ComboBox
    Friend WithEvents txtNroLegajo As TextBox
    Friend WithEvents lblNroLegajo As Label
    Friend WithEvents lblCodAcceso As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents lblEstadoCivil As Label
    Friend WithEvents lblFechaNac As Label
    Friend WithEvents lblSexo As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents cmbTitulo As ComboBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents dtpFechaNac As DateTimePicker
    Friend WithEvents rbMasculino As RadioButton
    Friend WithEvents rbFemenino As RadioButton
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtNroDoc As TextBox
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblNroDoc As Label
    Friend WithEvents txtApyNom As TextBox
    Friend WithEvents lblTipoDoc As Label
    Friend WithEvents lblApeyNom As Label
    Friend WithEvents btnRegistrarProfesor As Button
    Friend WithEvents cmbCodAcceso As ComboBox
End Class

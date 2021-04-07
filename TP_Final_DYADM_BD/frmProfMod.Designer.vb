<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfMod
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
        Me.btnRegistrarProfesor = New System.Windows.Forms.Button()
        Me.cmbEstCivil = New System.Windows.Forms.ComboBox()
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
        Me.txtTipoDoc = New System.Windows.Forms.TextBox()
        Me.txtFechaNac = New System.Windows.Forms.TextBox()
        Me.cmbFiltroProf = New System.Windows.Forms.ComboBox()
        Me.cmbCodAcceso = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnRegistrarProfesor
        '
        Me.btnRegistrarProfesor.Location = New System.Drawing.Point(164, 427)
        Me.btnRegistrarProfesor.Name = "btnRegistrarProfesor"
        Me.btnRegistrarProfesor.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrarProfesor.TabIndex = 16
        Me.btnRegistrarProfesor.Text = "Registrar"
        Me.btnRegistrarProfesor.UseVisualStyleBackColor = True
        '
        'cmbEstCivil
        '
        Me.cmbEstCivil.FormattingEnabled = True
        Me.cmbEstCivil.Location = New System.Drawing.Point(164, 307)
        Me.cmbEstCivil.Name = "cmbEstCivil"
        Me.cmbEstCivil.Size = New System.Drawing.Size(100, 21)
        Me.cmbEstCivil.TabIndex = 12
        Me.cmbEstCivil.Text = "Seleccione"
        '
        'txtNroLegajo
        '
        Me.txtNroLegajo.Enabled = False
        Me.txtNroLegajo.Location = New System.Drawing.Point(164, 50)
        Me.txtNroLegajo.Name = "txtNroLegajo"
        Me.txtNroLegajo.Size = New System.Drawing.Size(100, 20)
        Me.txtNroLegajo.TabIndex = 2
        '
        'lblNroLegajo
        '
        Me.lblNroLegajo.AutoSize = True
        Me.lblNroLegajo.Location = New System.Drawing.Point(96, 53)
        Me.lblNroLegajo.Name = "lblNroLegajo"
        Me.lblNroLegajo.Size = New System.Drawing.Size(62, 13)
        Me.lblNroLegajo.TabIndex = 83
        Me.lblNroLegajo.Text = "Nro. Legajo"
        '
        'lblCodAcceso
        '
        Me.lblCodAcceso.AutoSize = True
        Me.lblCodAcceso.Location = New System.Drawing.Point(65, 364)
        Me.lblCodAcceso.Name = "lblCodAcceso"
        Me.lblCodAcceso.Size = New System.Drawing.Size(93, 13)
        Me.lblCodAcceso.TabIndex = 82
        Me.lblCodAcceso.Text = "Codigo de acceso"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(125, 337)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(33, 13)
        Me.lblTitulo.TabIndex = 81
        Me.lblTitulo.Text = "Titulo"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(97, 390)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(61, 13)
        Me.lblPass.TabIndex = 80
        Me.lblPass.Text = "Contraseña"
        '
        'lblEstadoCivil
        '
        Me.lblEstadoCivil.AutoSize = True
        Me.lblEstadoCivil.Location = New System.Drawing.Point(97, 310)
        Me.lblEstadoCivil.Name = "lblEstadoCivil"
        Me.lblEstadoCivil.Size = New System.Drawing.Size(61, 13)
        Me.lblEstadoCivil.TabIndex = 79
        Me.lblEstadoCivil.Text = "Estado civil"
        '
        'lblFechaNac
        '
        Me.lblFechaNac.AutoSize = True
        Me.lblFechaNac.Location = New System.Drawing.Point(52, 279)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(106, 13)
        Me.lblFechaNac.TabIndex = 78
        Me.lblFechaNac.Text = "Fecha de nacimiento"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(127, 246)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(31, 13)
        Me.lblSexo.TabIndex = 77
        Me.lblSexo.Text = "Sexo"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(109, 209)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefono.TabIndex = 76
        Me.lblTelefono.Text = "Telefono"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(126, 183)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 75
        Me.lblEmail.Text = "Email"
        '
        'cmbTitulo
        '
        Me.cmbTitulo.FormattingEnabled = True
        Me.cmbTitulo.Location = New System.Drawing.Point(164, 334)
        Me.cmbTitulo.Name = "cmbTitulo"
        Me.cmbTitulo.Size = New System.Drawing.Size(134, 21)
        Me.cmbTitulo.TabIndex = 13
        Me.cmbTitulo.Text = "Seleccione"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(164, 387)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(134, 20)
        Me.txtPass.TabIndex = 15
        '
        'rbMasculino
        '
        Me.rbMasculino.AutoSize = True
        Me.rbMasculino.Location = New System.Drawing.Point(220, 244)
        Me.rbMasculino.Name = "rbMasculino"
        Me.rbMasculino.Size = New System.Drawing.Size(34, 17)
        Me.rbMasculino.TabIndex = 10
        Me.rbMasculino.TabStop = True
        Me.rbMasculino.Text = "M"
        Me.rbMasculino.UseVisualStyleBackColor = True
        '
        'rbFemenino
        '
        Me.rbFemenino.AutoSize = True
        Me.rbFemenino.Location = New System.Drawing.Point(173, 244)
        Me.rbFemenino.Name = "rbFemenino"
        Me.rbFemenino.Size = New System.Drawing.Size(31, 17)
        Me.rbFemenino.TabIndex = 9
        Me.rbFemenino.TabStop = True
        Me.rbFemenino.Text = "F"
        Me.rbFemenino.UseVisualStyleBackColor = True
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(164, 206)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(118, 20)
        Me.txtTelefono.TabIndex = 8
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(164, 180)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(184, 20)
        Me.txtEmail.TabIndex = 7
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(164, 154)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(184, 20)
        Me.txtDireccion.TabIndex = 6
        '
        'txtNroDoc
        '
        Me.txtNroDoc.Location = New System.Drawing.Point(164, 128)
        Me.txtNroDoc.Name = "txtNroDoc"
        Me.txtNroDoc.Size = New System.Drawing.Size(118, 20)
        Me.txtNroDoc.TabIndex = 5
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(106, 157)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion.TabIndex = 64
        Me.lblDireccion.Text = "Direccion"
        '
        'lblNroDoc
        '
        Me.lblNroDoc.AutoSize = True
        Me.lblNroDoc.Location = New System.Drawing.Point(43, 131)
        Me.lblNroDoc.Name = "lblNroDoc"
        Me.lblNroDoc.Size = New System.Drawing.Size(115, 13)
        Me.lblNroDoc.TabIndex = 63
        Me.lblNroDoc.Text = "Numero de documento"
        '
        'txtApyNom
        '
        Me.txtApyNom.Location = New System.Drawing.Point(164, 76)
        Me.txtApyNom.Name = "txtApyNom"
        Me.txtApyNom.Size = New System.Drawing.Size(184, 20)
        Me.txtApyNom.TabIndex = 3
        '
        'lblTipoDoc
        '
        Me.lblTipoDoc.AutoSize = True
        Me.lblTipoDoc.Location = New System.Drawing.Point(59, 104)
        Me.lblTipoDoc.Name = "lblTipoDoc"
        Me.lblTipoDoc.Size = New System.Drawing.Size(99, 13)
        Me.lblTipoDoc.TabIndex = 61
        Me.lblTipoDoc.Text = "Tipo de documento"
        '
        'lblApeyNom
        '
        Me.lblApeyNom.AutoSize = True
        Me.lblApeyNom.Location = New System.Drawing.Point(68, 79)
        Me.lblApeyNom.Name = "lblApeyNom"
        Me.lblApeyNom.Size = New System.Drawing.Size(90, 13)
        Me.lblApeyNom.TabIndex = 60
        Me.lblApeyNom.Text = "Apellido y nombre"
        '
        'txtTipoDoc
        '
        Me.txtTipoDoc.Location = New System.Drawing.Point(164, 102)
        Me.txtTipoDoc.Name = "txtTipoDoc"
        Me.txtTipoDoc.Size = New System.Drawing.Size(100, 20)
        Me.txtTipoDoc.TabIndex = 4
        '
        'txtFechaNac
        '
        Me.txtFechaNac.Location = New System.Drawing.Point(164, 276)
        Me.txtFechaNac.Name = "txtFechaNac"
        Me.txtFechaNac.Size = New System.Drawing.Size(118, 20)
        Me.txtFechaNac.TabIndex = 11
        '
        'cmbFiltroProf
        '
        Me.cmbFiltroProf.FormattingEnabled = True
        Me.cmbFiltroProf.Location = New System.Drawing.Point(109, 12)
        Me.cmbFiltroProf.Name = "cmbFiltroProf"
        Me.cmbFiltroProf.Size = New System.Drawing.Size(199, 21)
        Me.cmbFiltroProf.TabIndex = 1
        '
        'cmbCodAcceso
        '
        Me.cmbCodAcceso.FormattingEnabled = True
        Me.cmbCodAcceso.Location = New System.Drawing.Point(164, 361)
        Me.cmbCodAcceso.Name = "cmbCodAcceso"
        Me.cmbCodAcceso.Size = New System.Drawing.Size(134, 21)
        Me.cmbCodAcceso.TabIndex = 14
        '
        'frmProfMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 467)
        Me.Controls.Add(Me.cmbCodAcceso)
        Me.Controls.Add(Me.cmbFiltroProf)
        Me.Controls.Add(Me.txtFechaNac)
        Me.Controls.Add(Me.txtTipoDoc)
        Me.Controls.Add(Me.btnRegistrarProfesor)
        Me.Controls.Add(Me.cmbEstCivil)
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
        Me.Name = "frmProfMod"
        Me.Text = "Modificar Profesor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRegistrarProfesor As Button
    Friend WithEvents cmbEstCivil As ComboBox
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
    Friend WithEvents txtTipoDoc As TextBox
    Friend WithEvents txtFechaNac As TextBox
    Friend WithEvents cmbFiltroProf As ComboBox
    Friend WithEvents cmbCodAcceso As ComboBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAluMod
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
        Me.DGVModAlu = New System.Windows.Forms.DataGridView()
        Me.txtBuscarNro = New System.Windows.Forms.TextBox()
        Me.lblBusNum = New System.Windows.Forms.Label()
        Me.cmbEstCivil = New System.Windows.Forms.ComboBox()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.rbFemenino = New System.Windows.Forms.RadioButton()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNumDoc = New System.Windows.Forms.TextBox()
        Me.txtApelNom = New System.Windows.Forms.TextBox()
        Me.lblEstCivil = New System.Windows.Forms.Label()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblTipoDoc = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblNroDoc = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtTipoDoc = New System.Windows.Forms.TextBox()
        Me.txtsex = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.txtContrasenia2 = New System.Windows.Forms.TextBox()
        Me.lblContrasenia2 = New System.Windows.Forms.Label()
        Me.txtContrasenia = New System.Windows.Forms.TextBox()
        Me.lblContrasenia = New System.Windows.Forms.Label()
        CType(Me.DGVModAlu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVModAlu
        '
        Me.DGVModAlu.AllowUserToAddRows = False
        Me.DGVModAlu.AllowUserToDeleteRows = False
        Me.DGVModAlu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVModAlu.Location = New System.Drawing.Point(16, 41)
        Me.DGVModAlu.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DGVModAlu.Name = "DGVModAlu"
        Me.DGVModAlu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DGVModAlu.RowTemplate.Height = 24
        Me.DGVModAlu.Size = New System.Drawing.Size(454, 303)
        Me.DGVModAlu.TabIndex = 5
        '
        'txtBuscarNro
        '
        Me.txtBuscarNro.Location = New System.Drawing.Point(137, 11)
        Me.txtBuscarNro.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBuscarNro.Name = "txtBuscarNro"
        Me.txtBuscarNro.Size = New System.Drawing.Size(160, 20)
        Me.txtBuscarNro.TabIndex = 1
        '
        'lblBusNum
        '
        Me.lblBusNum.AutoSize = True
        Me.lblBusNum.Location = New System.Drawing.Point(14, 11)
        Me.lblBusNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBusNum.Name = "lblBusNum"
        Me.lblBusNum.Size = New System.Drawing.Size(120, 13)
        Me.lblBusNum.TabIndex = 3
        Me.lblBusNum.Text = "Numero de Documento:"
        '
        'cmbEstCivil
        '
        Me.cmbEstCivil.FormattingEnabled = True
        Me.cmbEstCivil.Location = New System.Drawing.Point(614, 259)
        Me.cmbEstCivil.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbEstCivil.Name = "cmbEstCivil"
        Me.cmbEstCivil.Size = New System.Drawing.Size(160, 21)
        Me.cmbEstCivil.TabIndex = 10
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.Location = New System.Drawing.Point(614, 232)
        Me.dtpFechaNac.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(160, 20)
        Me.dtpFechaNac.TabIndex = 9
        '
        'rbFemenino
        '
        Me.rbFemenino.AutoSize = True
        Me.rbFemenino.Location = New System.Drawing.Point(704, 230)
        Me.rbFemenino.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbFemenino.Name = "rbFemenino"
        Me.rbFemenino.Size = New System.Drawing.Size(71, 17)
        Me.rbFemenino.TabIndex = 41
        Me.rbFemenino.TabStop = True
        Me.rbFemenino.Text = "Femenino"
        Me.rbFemenino.UseVisualStyleBackColor = True
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(614, 176)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(160, 20)
        Me.txtTelefono.TabIndex = 7
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(614, 147)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(160, 20)
        Me.txtEmail.TabIndex = 6
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(614, 122)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(160, 20)
        Me.txtDireccion.TabIndex = 5
        '
        'txtNumDoc
        '
        Me.txtNumDoc.Location = New System.Drawing.Point(614, 96)
        Me.txtNumDoc.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNumDoc.Name = "txtNumDoc"
        Me.txtNumDoc.Size = New System.Drawing.Size(160, 20)
        Me.txtNumDoc.TabIndex = 4
        '
        'txtApelNom
        '
        Me.txtApelNom.Location = New System.Drawing.Point(614, 41)
        Me.txtApelNom.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtApelNom.Name = "txtApelNom"
        Me.txtApelNom.Size = New System.Drawing.Size(160, 20)
        Me.txtApelNom.TabIndex = 2
        '
        'lblEstCivil
        '
        Me.lblEstCivil.AutoSize = True
        Me.lblEstCivil.Location = New System.Drawing.Point(536, 265)
        Me.lblEstCivil.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEstCivil.Name = "lblEstCivil"
        Me.lblEstCivil.Size = New System.Drawing.Size(65, 13)
        Me.lblEstCivil.TabIndex = 32
        Me.lblEstCivil.Text = "Estado Civil:"
        '
        'lblFechaNac
        '
        Me.lblFechaNac.AutoSize = True
        Me.lblFechaNac.Location = New System.Drawing.Point(491, 232)
        Me.lblFechaNac.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(111, 13)
        Me.lblFechaNac.TabIndex = 31
        Me.lblFechaNac.Text = "Fecha de Nacimiento:"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(568, 205)
        Me.lblSexo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(34, 13)
        Me.lblSexo.TabIndex = 30
        Me.lblSexo.Text = "Sexo:"
        '
        'lblTipoDoc
        '
        Me.lblTipoDoc.AutoSize = True
        Me.lblTipoDoc.Location = New System.Drawing.Point(498, 69)
        Me.lblTipoDoc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTipoDoc.Name = "lblTipoDoc"
        Me.lblTipoDoc.Size = New System.Drawing.Size(104, 13)
        Me.lblTipoDoc.TabIndex = 29
        Me.lblTipoDoc.Text = "Tipo de Documento:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(549, 176)
        Me.lblTelefono.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefono.TabIndex = 28
        Me.lblTelefono.Text = "Telefono:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(562, 147)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(38, 13)
        Me.lblEmail.TabIndex = 27
        Me.lblEmail.Text = "E-mail:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(547, 122)
        Me.lblDireccion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(55, 13)
        Me.lblDireccion.TabIndex = 26
        Me.lblDireccion.Text = "Direccion:"
        '
        'lblNroDoc
        '
        Me.lblNroDoc.AutoSize = True
        Me.lblNroDoc.Location = New System.Drawing.Point(499, 96)
        Me.lblNroDoc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNroDoc.Name = "lblNroDoc"
        Me.lblNroDoc.Size = New System.Drawing.Size(103, 13)
        Me.lblNroDoc.TabIndex = 25
        Me.lblNroDoc.Text = "Nro. de Documento:"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(505, 41)
        Me.lblApellido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(95, 13)
        Me.lblApellido.TabIndex = 23
        Me.lblApellido.Text = "Apellido y Nombre:"
        '
        'txtTipoDoc
        '
        Me.txtTipoDoc.Location = New System.Drawing.Point(614, 69)
        Me.txtTipoDoc.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTipoDoc.Name = "txtTipoDoc"
        Me.txtTipoDoc.Size = New System.Drawing.Size(160, 20)
        Me.txtTipoDoc.TabIndex = 3
        '
        'txtsex
        '
        Me.txtsex.Location = New System.Drawing.Point(614, 205)
        Me.txtsex.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtsex.Name = "txtsex"
        Me.txtsex.Size = New System.Drawing.Size(160, 20)
        Me.txtsex.TabIndex = 8
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(583, 354)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(147, 23)
        Me.btnModificar.TabIndex = 13
        Me.btnModificar.Text = "Modificar Registro"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'txtContrasenia2
        '
        Me.txtContrasenia2.Location = New System.Drawing.Point(614, 317)
        Me.txtContrasenia2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtContrasenia2.Name = "txtContrasenia2"
        Me.txtContrasenia2.Size = New System.Drawing.Size(160, 20)
        Me.txtContrasenia2.TabIndex = 12
        '
        'lblContrasenia2
        '
        Me.lblContrasenia2.AutoSize = True
        Me.lblContrasenia2.Location = New System.Drawing.Point(499, 317)
        Me.lblContrasenia2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblContrasenia2.Name = "lblContrasenia2"
        Me.lblContrasenia2.Size = New System.Drawing.Size(101, 13)
        Me.lblContrasenia2.TabIndex = 49
        Me.lblContrasenia2.Text = "Repetir Contraseña:"
        '
        'txtContrasenia
        '
        Me.txtContrasenia.Location = New System.Drawing.Point(614, 289)
        Me.txtContrasenia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtContrasenia.Name = "txtContrasenia"
        Me.txtContrasenia.Size = New System.Drawing.Size(160, 20)
        Me.txtContrasenia.TabIndex = 11
        '
        'lblContrasenia
        '
        Me.lblContrasenia.AutoSize = True
        Me.lblContrasenia.Location = New System.Drawing.Point(536, 289)
        Me.lblContrasenia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblContrasenia.Name = "lblContrasenia"
        Me.lblContrasenia.Size = New System.Drawing.Size(64, 13)
        Me.lblContrasenia.TabIndex = 47
        Me.lblContrasenia.Text = "Contraseña:"
        '
        'frmAluMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 406)
        Me.Controls.Add(Me.txtContrasenia2)
        Me.Controls.Add(Me.lblContrasenia2)
        Me.Controls.Add(Me.txtContrasenia)
        Me.Controls.Add(Me.lblContrasenia)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.txtsex)
        Me.Controls.Add(Me.txtTipoDoc)
        Me.Controls.Add(Me.cmbEstCivil)
        Me.Controls.Add(Me.dtpFechaNac)
        Me.Controls.Add(Me.rbFemenino)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNumDoc)
        Me.Controls.Add(Me.txtApelNom)
        Me.Controls.Add(Me.lblEstCivil)
        Me.Controls.Add(Me.lblFechaNac)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.lblTipoDoc)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblNroDoc)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.DGVModAlu)
        Me.Controls.Add(Me.txtBuscarNro)
        Me.Controls.Add(Me.lblBusNum)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmAluMod"
        Me.Text = "Modificar Alumno"
        CType(Me.DGVModAlu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVModAlu As DataGridView
    Friend WithEvents txtBuscarNro As TextBox
    Friend WithEvents lblBusNum As Label
    Friend WithEvents cmbEstCivil As ComboBox
    Friend WithEvents dtpFechaNac As DateTimePicker
    Friend WithEvents rbFemenino As RadioButton
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtNumDoc As TextBox
    Friend WithEvents txtApelNom As TextBox
    Friend WithEvents lblEstCivil As Label
    Friend WithEvents lblFechaNac As Label
    Friend WithEvents lblSexo As Label
    Friend WithEvents lblTipoDoc As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblNroDoc As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents txtTipoDoc As TextBox
    Friend WithEvents txtsex As TextBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents txtContrasenia2 As TextBox
    Friend WithEvents lblContrasenia2 As Label
    Friend WithEvents txtContrasenia As TextBox
    Friend WithEvents lblContrasenia As Label
End Class

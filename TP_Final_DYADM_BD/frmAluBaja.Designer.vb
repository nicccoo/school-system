<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAluBaja
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
        Me.lblBusNum = New System.Windows.Forms.Label()
        Me.txtBuscarNro = New System.Windows.Forms.TextBox()
        Me.DGVBajaAlu = New System.Windows.Forms.DataGridView()
        Me.lblEstCivil = New System.Windows.Forms.Label()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblTipoDoc = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblNroDoc = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblECivil = New System.Windows.Forms.Label()
        Me.lblFNac = New System.Windows.Forms.Label()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.lblEm = New System.Windows.Forms.Label()
        Me.lblDir = New System.Windows.Forms.Label()
        Me.lblNDoc = New System.Windows.Forms.Label()
        Me.lblTDoc = New System.Windows.Forms.Label()
        Me.lblapenom = New System.Windows.Forms.Label()
        CType(Me.DGVBajaAlu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBusNum
        '
        Me.lblBusNum.AutoSize = True
        Me.lblBusNum.Location = New System.Drawing.Point(23, 17)
        Me.lblBusNum.Name = "lblBusNum"
        Me.lblBusNum.Size = New System.Drawing.Size(158, 17)
        Me.lblBusNum.TabIndex = 0
        Me.lblBusNum.Text = "Numero de Documento:"
        '
        'txtBuscarNro
        '
        Me.txtBuscarNro.Location = New System.Drawing.Point(187, 17)
        Me.txtBuscarNro.Name = "txtBuscarNro"
        Me.txtBuscarNro.Size = New System.Drawing.Size(212, 22)
        Me.txtBuscarNro.TabIndex = 1
        '
        'DGVBajaAlu
        '
        Me.DGVBajaAlu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVBajaAlu.Location = New System.Drawing.Point(26, 54)
        Me.DGVBajaAlu.Name = "DGVBajaAlu"
        Me.DGVBajaAlu.RowHeadersWidth = 51
        Me.DGVBajaAlu.RowTemplate.Height = 24
        Me.DGVBajaAlu.Size = New System.Drawing.Size(618, 365)
        Me.DGVBajaAlu.TabIndex = 2
        '
        'lblEstCivil
        '
        Me.lblEstCivil.AutoSize = True
        Me.lblEstCivil.Location = New System.Drawing.Point(733, 356)
        Me.lblEstCivil.Name = "lblEstCivil"
        Me.lblEstCivil.Size = New System.Drawing.Size(85, 17)
        Me.lblEstCivil.TabIndex = 19
        Me.lblEstCivil.Text = "Estado Civil:"
        '
        'lblFechaNac
        '
        Me.lblFechaNac.AutoSize = True
        Me.lblFechaNac.Location = New System.Drawing.Point(673, 316)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(145, 17)
        Me.lblFechaNac.TabIndex = 18
        Me.lblFechaNac.Text = "Fecha de Nacimiento:"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(775, 282)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(43, 17)
        Me.lblSexo.TabIndex = 17
        Me.lblSexo.Text = "Sexo:"
        '
        'lblTipoDoc
        '
        Me.lblTipoDoc.AutoSize = True
        Me.lblTipoDoc.Location = New System.Drawing.Point(682, 115)
        Me.lblTipoDoc.Name = "lblTipoDoc"
        Me.lblTipoDoc.Size = New System.Drawing.Size(136, 17)
        Me.lblTipoDoc.TabIndex = 16
        Me.lblTipoDoc.Text = "Tipo de Documento:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(750, 246)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(68, 17)
        Me.lblTelefono.TabIndex = 15
        Me.lblTelefono.Text = "Telefono:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(767, 211)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(51, 17)
        Me.lblEmail.TabIndex = 14
        Me.lblEmail.Text = "E-mail:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(747, 180)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(71, 17)
        Me.lblDireccion.TabIndex = 13
        Me.lblDireccion.Text = "Direccion:"
        '
        'lblNroDoc
        '
        Me.lblNroDoc.AutoSize = True
        Me.lblNroDoc.Location = New System.Drawing.Point(683, 148)
        Me.lblNroDoc.Name = "lblNroDoc"
        Me.lblNroDoc.Size = New System.Drawing.Size(135, 17)
        Me.lblNroDoc.TabIndex = 12
        Me.lblNroDoc.Text = "Nro. de Documento:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(691, 85)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(127, 17)
        Me.lblNombre.TabIndex = 11
        Me.lblNombre.Text = "Apellido y Nombre:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(778, 398)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 31)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Eliminar Alumno"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblECivil
        '
        Me.lblECivil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblECivil.Location = New System.Drawing.Point(824, 355)
        Me.lblECivil.Name = "lblECivil"
        Me.lblECivil.Size = New System.Drawing.Size(196, 17)
        Me.lblECivil.TabIndex = 23
        '
        'lblFNac
        '
        Me.lblFNac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFNac.Location = New System.Drawing.Point(824, 316)
        Me.lblFNac.Name = "lblFNac"
        Me.lblFNac.Size = New System.Drawing.Size(196, 17)
        Me.lblFNac.TabIndex = 24
        '
        'lblSex
        '
        Me.lblSex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSex.Location = New System.Drawing.Point(824, 282)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(196, 17)
        Me.lblSex.TabIndex = 25
        '
        'lblTel
        '
        Me.lblTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTel.Location = New System.Drawing.Point(824, 246)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(196, 17)
        Me.lblTel.TabIndex = 26
        '
        'lblEm
        '
        Me.lblEm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEm.Location = New System.Drawing.Point(824, 210)
        Me.lblEm.Name = "lblEm"
        Me.lblEm.Size = New System.Drawing.Size(196, 17)
        Me.lblEm.TabIndex = 27
        '
        'lblDir
        '
        Me.lblDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDir.Location = New System.Drawing.Point(824, 180)
        Me.lblDir.Name = "lblDir"
        Me.lblDir.Size = New System.Drawing.Size(196, 17)
        Me.lblDir.TabIndex = 28
        '
        'lblNDoc
        '
        Me.lblNDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNDoc.Location = New System.Drawing.Point(824, 148)
        Me.lblNDoc.Name = "lblNDoc"
        Me.lblNDoc.Size = New System.Drawing.Size(196, 17)
        Me.lblNDoc.TabIndex = 29
        '
        'lblTDoc
        '
        Me.lblTDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTDoc.Location = New System.Drawing.Point(824, 115)
        Me.lblTDoc.Name = "lblTDoc"
        Me.lblTDoc.Size = New System.Drawing.Size(196, 17)
        Me.lblTDoc.TabIndex = 30
        '
        'lblapenom
        '
        Me.lblapenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblapenom.Location = New System.Drawing.Point(824, 85)
        Me.lblapenom.Name = "lblapenom"
        Me.lblapenom.Size = New System.Drawing.Size(196, 17)
        Me.lblapenom.TabIndex = 31
        '
        'frmAluBaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 450)
        Me.Controls.Add(Me.lblapenom)
        Me.Controls.Add(Me.lblTDoc)
        Me.Controls.Add(Me.lblNDoc)
        Me.Controls.Add(Me.lblDir)
        Me.Controls.Add(Me.lblEm)
        Me.Controls.Add(Me.lblTel)
        Me.Controls.Add(Me.lblSex)
        Me.Controls.Add(Me.lblFNac)
        Me.Controls.Add(Me.lblECivil)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblEstCivil)
        Me.Controls.Add(Me.lblFechaNac)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.lblTipoDoc)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblNroDoc)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.DGVBajaAlu)
        Me.Controls.Add(Me.txtBuscarNro)
        Me.Controls.Add(Me.lblBusNum)
        Me.Name = "frmAluBaja"
        Me.Text = "Baja Alumno"
        CType(Me.DGVBajaAlu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBusNum As Label
    Friend WithEvents txtBuscarNro As TextBox
    Friend WithEvents DGVBajaAlu As DataGridView
    Friend WithEvents lblEstCivil As Label
    Friend WithEvents lblFechaNac As Label
    Friend WithEvents lblSexo As Label
    Friend WithEvents lblTipoDoc As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblNroDoc As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblECivil As Label
    Friend WithEvents lblFNac As Label
    Friend WithEvents lblSex As Label
    Friend WithEvents lblTel As Label
    Friend WithEvents lblEm As Label
    Friend WithEvents lblDir As Label
    Friend WithEvents lblNDoc As Label
    Friend WithEvents lblTDoc As Label
    Friend WithEvents lblapenom As Label
End Class

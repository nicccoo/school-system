<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lblLegajo = New System.Windows.Forms.Label()
        Me.lblContrasenia = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContrasenia = New System.Windows.Forms.TextBox()
        Me.btnMostrarContrasenia = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.cmbUsuarioTipo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblLegajo
        '
        Me.lblLegajo.Location = New System.Drawing.Point(76, 68)
        Me.lblLegajo.Name = "lblLegajo"
        Me.lblLegajo.Size = New System.Drawing.Size(83, 20)
        Me.lblLegajo.TabIndex = 0
        Me.lblLegajo.Text = "Legajo:"
        Me.lblLegajo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblContrasenia
        '
        Me.lblContrasenia.Location = New System.Drawing.Point(76, 105)
        Me.lblContrasenia.Name = "lblContrasenia"
        Me.lblContrasenia.Size = New System.Drawing.Size(83, 20)
        Me.lblContrasenia.TabIndex = 1
        Me.lblContrasenia.Text = "Contraseña:"
        Me.lblContrasenia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(165, 68)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 2
        '
        'txtContrasenia
        '
        Me.txtContrasenia.Location = New System.Drawing.Point(165, 105)
        Me.txtContrasenia.Name = "txtContrasenia"
        Me.txtContrasenia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasenia.Size = New System.Drawing.Size(100, 20)
        Me.txtContrasenia.TabIndex = 3
        '
        'btnMostrarContrasenia
        '
        Me.btnMostrarContrasenia.BackColor = System.Drawing.Color.White
        Me.btnMostrarContrasenia.FlatAppearance.BorderSize = 0
        Me.btnMostrarContrasenia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrarContrasenia.Image = CType(resources.GetObject("btnMostrarContrasenia.Image"), System.Drawing.Image)
        Me.btnMostrarContrasenia.Location = New System.Drawing.Point(271, 105)
        Me.btnMostrarContrasenia.Name = "btnMostrarContrasenia"
        Me.btnMostrarContrasenia.Size = New System.Drawing.Size(25, 20)
        Me.btnMostrarContrasenia.TabIndex = 5
        Me.btnMostrarContrasenia.TabStop = False
        Me.btnMostrarContrasenia.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(165, 152)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "&Ingresar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'cmbUsuarioTipo
        '
        Me.cmbUsuarioTipo.FormattingEnabled = True
        Me.cmbUsuarioTipo.Items.AddRange(New Object() {"Alumno", "Profesor"})
        Me.cmbUsuarioTipo.Location = New System.Drawing.Point(165, 12)
        Me.cmbUsuarioTipo.Name = "cmbUsuarioTipo"
        Me.cmbUsuarioTipo.Size = New System.Drawing.Size(100, 21)
        Me.cmbUsuarioTipo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(73, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de Usuario:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(373, 201)
        Me.Controls.Add(Me.cmbUsuarioTipo)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnMostrarContrasenia)
        Me.Controls.Add(Me.txtContrasenia)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblContrasenia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLegajo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.ShowIcon = False
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLegajo As Label
    Friend WithEvents lblContrasenia As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContrasenia As TextBox
    Friend WithEvents btnMostrarContrasenia As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents cmbUsuarioTipo As ComboBox
    Friend WithEvents Label1 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMatBajaMod
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.cmbProfesor = New System.Windows.Forms.ComboBox()
        Me.lblCodMateria = New System.Windows.Forms.Label()
        Me.txtDescMateria = New System.Windows.Forms.TextBox()
        Me.lblDescMateria = New System.Windows.Forms.Label()
        Me.txtCarrera = New System.Windows.Forms.TextBox()
        Me.lblCarrera = New System.Windows.Forms.Label()
        Me.lblProfesor = New System.Windows.Forms.Label()
        Me.dgvMaterias = New System.Windows.Forms.DataGridView()
        Me.mtxtCodMateria = New System.Windows.Forms.MaskedTextBox()
        Me.tltMascara = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dgvMaterias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Location = New System.Drawing.Point(113, 132)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'cmbProfesor
        '
        Me.cmbProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProfesor.Enabled = False
        Me.cmbProfesor.FormattingEnabled = True
        Me.cmbProfesor.Location = New System.Drawing.Point(143, 97)
        Me.cmbProfesor.Name = "cmbProfesor"
        Me.cmbProfesor.Size = New System.Drawing.Size(186, 21)
        Me.cmbProfesor.TabIndex = 4
        '
        'lblCodMateria
        '
        Me.lblCodMateria.AutoSize = True
        Me.lblCodMateria.Location = New System.Drawing.Point(59, 22)
        Me.lblCodMateria.Name = "lblCodMateria"
        Me.lblCodMateria.Size = New System.Drawing.Size(78, 13)
        Me.lblCodMateria.TabIndex = 73
        Me.lblCodMateria.Text = "Código Materia"
        '
        'txtDescMateria
        '
        Me.txtDescMateria.Enabled = False
        Me.txtDescMateria.Location = New System.Drawing.Point(143, 45)
        Me.txtDescMateria.Name = "txtDescMateria"
        Me.txtDescMateria.Size = New System.Drawing.Size(186, 20)
        Me.txtDescMateria.TabIndex = 2
        '
        'lblDescMateria
        '
        Me.lblDescMateria.AutoSize = True
        Me.lblDescMateria.Location = New System.Drawing.Point(11, 48)
        Me.lblDescMateria.Name = "lblDescMateria"
        Me.lblDescMateria.Size = New System.Drawing.Size(126, 13)
        Me.lblDescMateria.TabIndex = 71
        Me.lblDescMateria.Text = "Descripción de la materia"
        '
        'txtCarrera
        '
        Me.txtCarrera.Enabled = False
        Me.txtCarrera.Location = New System.Drawing.Point(143, 71)
        Me.txtCarrera.Name = "txtCarrera"
        Me.txtCarrera.Size = New System.Drawing.Size(186, 20)
        Me.txtCarrera.TabIndex = 3
        '
        'lblCarrera
        '
        Me.lblCarrera.AutoSize = True
        Me.lblCarrera.Location = New System.Drawing.Point(96, 74)
        Me.lblCarrera.Name = "lblCarrera"
        Me.lblCarrera.Size = New System.Drawing.Size(41, 13)
        Me.lblCarrera.TabIndex = 69
        Me.lblCarrera.Text = "Carrera"
        '
        'lblProfesor
        '
        Me.lblProfesor.AutoSize = True
        Me.lblProfesor.Location = New System.Drawing.Point(91, 100)
        Me.lblProfesor.Name = "lblProfesor"
        Me.lblProfesor.Size = New System.Drawing.Size(46, 13)
        Me.lblProfesor.TabIndex = 68
        Me.lblProfesor.Text = "Profesor"
        '
        'dgvMaterias
        '
        Me.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMaterias.Location = New System.Drawing.Point(11, 162)
        Me.dgvMaterias.Name = "dgvMaterias"
        Me.dgvMaterias.Size = New System.Drawing.Size(699, 162)
        Me.dgvMaterias.TabIndex = 1
        '
        'mtxtCodMateria
        '
        Me.mtxtCodMateria.Enabled = False
        Me.mtxtCodMateria.Location = New System.Drawing.Point(143, 19)
        Me.mtxtCodMateria.Mask = "AA999"
        Me.mtxtCodMateria.Name = "mtxtCodMateria"
        Me.mtxtCodMateria.Size = New System.Drawing.Size(53, 20)
        Me.mtxtCodMateria.TabIndex = 1
        Me.tltMascara.SetToolTip(Me.mtxtCodMateria, "El código de materia tiene el formato AA999")
        '
        'frmMatBajaMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 336)
        Me.ControlBox = False
        Me.Controls.Add(Me.mtxtCodMateria)
        Me.Controls.Add(Me.dgvMaterias)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.cmbProfesor)
        Me.Controls.Add(Me.lblCodMateria)
        Me.Controls.Add(Me.txtDescMateria)
        Me.Controls.Add(Me.lblDescMateria)
        Me.Controls.Add(Me.txtCarrera)
        Me.Controls.Add(Me.lblCarrera)
        Me.Controls.Add(Me.lblProfesor)
        Me.Name = "frmMatBajaMod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modificación de Materia"
        CType(Me.dgvMaterias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAceptar As Button
    Friend WithEvents cmbProfesor As ComboBox
    Friend WithEvents lblCodMateria As Label
    Friend WithEvents txtDescMateria As TextBox
    Friend WithEvents lblDescMateria As Label
    Friend WithEvents txtCarrera As TextBox
    Friend WithEvents lblCarrera As Label
    Friend WithEvents lblProfesor As Label
    Friend WithEvents dgvMaterias As DataGridView
    Friend WithEvents mtxtCodMateria As MaskedTextBox
    Friend WithEvents tltMascara As ToolTip
End Class

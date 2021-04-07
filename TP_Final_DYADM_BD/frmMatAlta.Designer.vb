<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMatAlta
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
        Me.components = New System.ComponentModel.Container()
        Me.cmbProfesor = New System.Windows.Forms.ComboBox()
        Me.lblNroLegajo = New System.Windows.Forms.Label()
        Me.txtDescMateria = New System.Windows.Forms.TextBox()
        Me.lblNroDoc = New System.Windows.Forms.Label()
        Me.txtCarrera = New System.Windows.Forms.TextBox()
        Me.lblTipoDoc = New System.Windows.Forms.Label()
        Me.lblApeyNom = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.tltMascara = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtCodMateria = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmbProfesor
        '
        Me.cmbProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProfesor.FormattingEnabled = True
        Me.cmbProfesor.Location = New System.Drawing.Point(142, 104)
        Me.cmbProfesor.Name = "cmbProfesor"
        Me.cmbProfesor.Size = New System.Drawing.Size(186, 21)
        Me.cmbProfesor.TabIndex = 4
        '
        'lblNroLegajo
        '
        Me.lblNroLegajo.AutoSize = True
        Me.lblNroLegajo.Location = New System.Drawing.Point(58, 29)
        Me.lblNroLegajo.Name = "lblNroLegajo"
        Me.lblNroLegajo.Size = New System.Drawing.Size(78, 13)
        Me.lblNroLegajo.TabIndex = 63
        Me.lblNroLegajo.Text = "Código Materia"
        '
        'txtDescMateria
        '
        Me.txtDescMateria.Location = New System.Drawing.Point(142, 52)
        Me.txtDescMateria.Name = "txtDescMateria"
        Me.txtDescMateria.Size = New System.Drawing.Size(118, 20)
        Me.txtDescMateria.TabIndex = 2
        '
        'lblNroDoc
        '
        Me.lblNroDoc.AutoSize = True
        Me.lblNroDoc.Location = New System.Drawing.Point(10, 55)
        Me.lblNroDoc.Name = "lblNroDoc"
        Me.lblNroDoc.Size = New System.Drawing.Size(126, 13)
        Me.lblNroDoc.TabIndex = 61
        Me.lblNroDoc.Text = "Descripción de la materia"
        '
        'txtCarrera
        '
        Me.txtCarrera.Location = New System.Drawing.Point(142, 78)
        Me.txtCarrera.Name = "txtCarrera"
        Me.txtCarrera.Size = New System.Drawing.Size(186, 20)
        Me.txtCarrera.TabIndex = 3
        '
        'lblTipoDoc
        '
        Me.lblTipoDoc.AutoSize = True
        Me.lblTipoDoc.Location = New System.Drawing.Point(95, 81)
        Me.lblTipoDoc.Name = "lblTipoDoc"
        Me.lblTipoDoc.Size = New System.Drawing.Size(41, 13)
        Me.lblTipoDoc.TabIndex = 59
        Me.lblTipoDoc.Text = "Carrera"
        '
        'lblApeyNom
        '
        Me.lblApeyNom.AutoSize = True
        Me.lblApeyNom.Location = New System.Drawing.Point(90, 107)
        Me.lblApeyNom.Name = "lblApeyNom"
        Me.lblApeyNom.Size = New System.Drawing.Size(46, 13)
        Me.lblApeyNom.TabIndex = 58
        Me.lblApeyNom.Text = "Profesor"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(142, 141)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtCodMateria
        '
        Me.txtCodMateria.Enabled = False
        Me.txtCodMateria.Location = New System.Drawing.Point(142, 26)
        Me.txtCodMateria.Name = "txtCodMateria"
        Me.txtCodMateria.Size = New System.Drawing.Size(118, 20)
        Me.txtCodMateria.TabIndex = 1
        '
        'frmMatAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 176)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.cmbProfesor)
        Me.Controls.Add(Me.lblNroLegajo)
        Me.Controls.Add(Me.txtCodMateria)
        Me.Controls.Add(Me.txtDescMateria)
        Me.Controls.Add(Me.lblNroDoc)
        Me.Controls.Add(Me.txtCarrera)
        Me.Controls.Add(Me.lblTipoDoc)
        Me.Controls.Add(Me.lblApeyNom)
        Me.Name = "frmMatAlta"
        Me.Text = "Alta de Materia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbProfesor As ComboBox
    Friend WithEvents lblNroLegajo As Label
    Friend WithEvents txtDescMateria As TextBox
    Friend WithEvents lblNroDoc As Label
    Friend WithEvents txtCarrera As TextBox
    Friend WithEvents lblTipoDoc As Label
    Friend WithEvents lblApeyNom As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents tltMascara As ToolTip
    Friend WithEvents txtCodMateria As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMatBaja
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
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.cmbTipoDoc = New System.Windows.Forms.ComboBox()
        Me.txtNroLegajo = New System.Windows.Forms.TextBox()
        Me.lblNroLegajo = New System.Windows.Forms.Label()
        Me.txtNroDoc = New System.Windows.Forms.TextBox()
        Me.lblNroDoc = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblTipoDoc = New System.Windows.Forms.Label()
        Me.lblApeyNom = New System.Windows.Forms.Label()
        Me.dgvMaterias = New System.Windows.Forms.DataGridView()
        CType(Me.dgvMaterias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(113, 133)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 87
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'cmbTipoDoc
        '
        Me.cmbTipoDoc.Enabled = False
        Me.cmbTipoDoc.FormattingEnabled = True
        Me.cmbTipoDoc.Location = New System.Drawing.Point(143, 97)
        Me.cmbTipoDoc.Name = "cmbTipoDoc"
        Me.cmbTipoDoc.Size = New System.Drawing.Size(186, 21)
        Me.cmbTipoDoc.TabIndex = 85
        Me.cmbTipoDoc.Text = "Seleccione"
        '
        'txtNroLegajo
        '
        Me.txtNroLegajo.Enabled = False
        Me.txtNroLegajo.Location = New System.Drawing.Point(143, 19)
        Me.txtNroLegajo.Name = "txtNroLegajo"
        Me.txtNroLegajo.Size = New System.Drawing.Size(100, 20)
        Me.txtNroLegajo.TabIndex = 84
        '
        'lblNroLegajo
        '
        Me.lblNroLegajo.AutoSize = True
        Me.lblNroLegajo.Location = New System.Drawing.Point(59, 22)
        Me.lblNroLegajo.Name = "lblNroLegajo"
        Me.lblNroLegajo.Size = New System.Drawing.Size(78, 13)
        Me.lblNroLegajo.TabIndex = 83
        Me.lblNroLegajo.Text = "Código Materia"
        '
        'txtNroDoc
        '
        Me.txtNroDoc.Enabled = False
        Me.txtNroDoc.Location = New System.Drawing.Point(143, 45)
        Me.txtNroDoc.Name = "txtNroDoc"
        Me.txtNroDoc.Size = New System.Drawing.Size(118, 20)
        Me.txtNroDoc.TabIndex = 82
        '
        'lblNroDoc
        '
        Me.lblNroDoc.AutoSize = True
        Me.lblNroDoc.Location = New System.Drawing.Point(11, 48)
        Me.lblNroDoc.Name = "lblNroDoc"
        Me.lblNroDoc.Size = New System.Drawing.Size(126, 13)
        Me.lblNroDoc.TabIndex = 81
        Me.lblNroDoc.Text = "Descripción de la materia"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(143, 71)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(186, 20)
        Me.TextBox1.TabIndex = 80
        '
        'lblTipoDoc
        '
        Me.lblTipoDoc.AutoSize = True
        Me.lblTipoDoc.Location = New System.Drawing.Point(96, 74)
        Me.lblTipoDoc.Name = "lblTipoDoc"
        Me.lblTipoDoc.Size = New System.Drawing.Size(41, 13)
        Me.lblTipoDoc.TabIndex = 79
        Me.lblTipoDoc.Text = "Carrera"
        '
        'lblApeyNom
        '
        Me.lblApeyNom.AutoSize = True
        Me.lblApeyNom.Location = New System.Drawing.Point(91, 100)
        Me.lblApeyNom.Name = "lblApeyNom"
        Me.lblApeyNom.Size = New System.Drawing.Size(46, 13)
        Me.lblApeyNom.TabIndex = 78
        Me.lblApeyNom.Text = "Profesor"
        '
        'dgvMaterias
        '
        Me.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMaterias.Location = New System.Drawing.Point(12, 162)
        Me.dgvMaterias.Name = "dgvMaterias"
        Me.dgvMaterias.Size = New System.Drawing.Size(317, 162)
        Me.dgvMaterias.TabIndex = 88
        '
        'frmMatBaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 336)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvMaterias)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.cmbTipoDoc)
        Me.Controls.Add(Me.txtNroLegajo)
        Me.Controls.Add(Me.lblNroLegajo)
        Me.Controls.Add(Me.txtNroDoc)
        Me.Controls.Add(Me.lblNroDoc)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblTipoDoc)
        Me.Controls.Add(Me.lblApeyNom)
        Me.Name = "frmMatBaja"
        Me.Text = "Baja de Materia"
        CType(Me.dgvMaterias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAceptar As Button
    Friend WithEvents cmbTipoDoc As ComboBox
    Friend WithEvents txtNroLegajo As TextBox
    Friend WithEvents lblNroLegajo As Label
    Friend WithEvents txtNroDoc As TextBox
    Friend WithEvents lblNroDoc As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblTipoDoc As Label
    Friend WithEvents lblApeyNom As Label
    Friend WithEvents dgvMaterias As DataGridView
End Class

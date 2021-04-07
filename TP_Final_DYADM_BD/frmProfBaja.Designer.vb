<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProfBaja
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
        Me.lblProfesor = New System.Windows.Forms.Label()
        Me.txtProfesor = New System.Windows.Forms.TextBox()
        Me.btnFiltro = New System.Windows.Forms.Button()
        Me.dgvFiltroProf = New System.Windows.Forms.DataGridView()
        Me.mnuBajaProf = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.opEliminar = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvFiltroProf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuBajaProf.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblProfesor
        '
        Me.lblProfesor.AutoSize = True
        Me.lblProfesor.Location = New System.Drawing.Point(12, 23)
        Me.lblProfesor.Name = "lblProfesor"
        Me.lblProfesor.Size = New System.Drawing.Size(92, 13)
        Me.lblProfesor.TabIndex = 0
        Me.lblProfesor.Text = "Nombre o apellido"
        '
        'txtProfesor
        '
        Me.txtProfesor.Location = New System.Drawing.Point(110, 20)
        Me.txtProfesor.Name = "txtProfesor"
        Me.txtProfesor.Size = New System.Drawing.Size(172, 20)
        Me.txtProfesor.TabIndex = 1
        '
        'btnFiltro
        '
        Me.btnFiltro.Location = New System.Drawing.Point(288, 18)
        Me.btnFiltro.Name = "btnFiltro"
        Me.btnFiltro.Size = New System.Drawing.Size(75, 23)
        Me.btnFiltro.TabIndex = 2
        Me.btnFiltro.Text = "Buscar"
        Me.btnFiltro.UseVisualStyleBackColor = True
        '
        'dgvFiltroProf
        '
        Me.dgvFiltroProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFiltroProf.ContextMenuStrip = Me.mnuBajaProf
        Me.dgvFiltroProf.Location = New System.Drawing.Point(13, 66)
        Me.dgvFiltroProf.Name = "dgvFiltroProf"
        Me.dgvFiltroProf.Size = New System.Drawing.Size(350, 289)
        Me.dgvFiltroProf.TabIndex = 3
        '
        'mnuBajaProf
        '
        Me.mnuBajaProf.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.opEliminar})
        Me.mnuBajaProf.Name = "mnuBajaProf"
        Me.mnuBajaProf.Size = New System.Drawing.Size(165, 26)
        '
        'opEliminar
        '
        Me.opEliminar.Name = "opEliminar"
        Me.opEliminar.Size = New System.Drawing.Size(164, 22)
        Me.opEliminar.Text = "Eliminar profesor"
        '
        'frmProfBaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 367)
        Me.Controls.Add(Me.dgvFiltroProf)
        Me.Controls.Add(Me.btnFiltro)
        Me.Controls.Add(Me.txtProfesor)
        Me.Controls.Add(Me.lblProfesor)
        Me.Name = "frmProfBaja"
        Me.Text = "Eliminar profesor"
        CType(Me.dgvFiltroProf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuBajaProf.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProfesor As Label
    Friend WithEvents txtProfesor As TextBox
    Friend WithEvents btnFiltro As Button
    Friend WithEvents dgvFiltroProf As DataGridView
    Friend WithEvents mnuBajaProf As ContextMenuStrip
    Friend WithEvents opEliminar As ToolStripMenuItem
End Class

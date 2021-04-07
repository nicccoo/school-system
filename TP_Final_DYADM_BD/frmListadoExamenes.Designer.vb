<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListadoExamenes
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
        Me.DGVExamenes = New System.Windows.Forms.DataGridView()
        Me.contexmenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ctxEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtFiltrar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGVExamenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contexmenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVExamenes
        '
        Me.DGVExamenes.AllowUserToAddRows = False
        Me.DGVExamenes.AllowUserToDeleteRows = False
        Me.DGVExamenes.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DGVExamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVExamenes.ContextMenuStrip = Me.contexmenu
        Me.DGVExamenes.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGVExamenes.Location = New System.Drawing.Point(12, 54)
        Me.DGVExamenes.Name = "DGVExamenes"
        Me.DGVExamenes.Size = New System.Drawing.Size(764, 362)
        Me.DGVExamenes.TabIndex = 0
        '
        'contexmenu
        '
        Me.contexmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ctxEliminar})
        Me.contexmenu.Name = "ContextMenu"
        Me.contexmenu.Size = New System.Drawing.Size(118, 26)
        '
        'ctxEliminar
        '
        Me.ctxEliminar.Name = "ctxEliminar"
        Me.ctxEliminar.Size = New System.Drawing.Size(117, 22)
        Me.ctxEliminar.Text = "Eliminar"
        '
        'txtFiltrar
        '
        Me.txtFiltrar.BackColor = System.Drawing.SystemColors.Control
        Me.txtFiltrar.Location = New System.Drawing.Point(64, 25)
        Me.txtFiltrar.Name = "txtFiltrar"
        Me.txtFiltrar.Size = New System.Drawing.Size(251, 20)
        Me.txtFiltrar.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Buscar: "
        '
        'frmListadoExamenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(788, 428)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFiltrar)
        Me.Controls.Add(Me.DGVExamenes)
        Me.Name = "frmListadoExamenes"
        Me.Text = "Listado Examenes"
        CType(Me.DGVExamenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contexmenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVExamenes As DataGridView
    Friend WithEvents contexmenu As ContextMenuStrip
    Friend WithEvents txtFiltrar As TextBox
    Friend WithEvents ctxEliminar As ToolStripMenuItem
    Friend WithEvents Label1 As Label
End Class

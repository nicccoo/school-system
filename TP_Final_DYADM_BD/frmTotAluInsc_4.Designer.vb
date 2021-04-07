<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTotAluInsc
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
        Me.txtTurno = New System.Windows.Forms.TextBox()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Disenio_admin_BDDataSet = New dts.Disenio_admin_BDDataSet()
        Me.SpTotAluInscBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpTotAluInscTableAdapter = New TP_Final_DYADM_BD.Disenio_admin_BDDataSetTableAdapters.spTotAluInscTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Disenio_admin_BDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpTotAluInscBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTurno
        '
        Me.txtTurno.Location = New System.Drawing.Point(77, 12)
        Me.txtTurno.Name = "txtTurno"
        Me.txtTurno.Size = New System.Drawing.Size(100, 20)
        Me.txtTurno.TabIndex = 0
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(283, 12)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(100, 20)
        Me.txtAño.TabIndex = 1
        '
        'ReportViewer1
        '
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "TP_Final_DYADM_BD.rdlcTotAluInsc.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 38)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer1.TabIndex = 2
        '
        'Disenio_admin_BDDataSet
        '
        Me.Disenio_admin_BDDataSet.DataSetName = "Disenio_admin_BDDataSet"
        Me.Disenio_admin_BDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpTotAluInscBindingSource
        '
        Me.SpTotAluInscBindingSource.DataMember = "spTotAluInsc"
        Me.SpTotAluInscBindingSource.DataSource = Me.Disenio_admin_BDDataSet
        '
        'SpTotAluInscTableAdapter
        '
        Me.SpTotAluInscTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(436, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmTotAluInsc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 307)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.txtAño)
        Me.Controls.Add(Me.txtTurno)
        Me.Name = "frmTotAluInsc"
        Me.Text = "frmTotAluInsc"
        CType(Me.Disenio_admin_BDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpTotAluInscBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTurno As TextBox
    Friend WithEvents txtAño As TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Disenio_admin_BDDataSet As dtsTotAluInsc
    Friend WithEvents SpTotAluInscBindingSource As BindingSource
    Friend WithEvents SpTotAluInscTableAdapter As dtsTotAluInscTableAdapters.spTotAluInscTableAdapter
    Friend WithEvents Button1 As Button
End Class

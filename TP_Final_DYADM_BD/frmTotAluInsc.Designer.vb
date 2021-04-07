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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.spTotAluInscBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtsTotAluInsc = New TP_Final_DYADM_BD.dtsTotAluInsc()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txtTurno = New System.Windows.Forms.TextBox()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.spTotAluInscTableAdapter = New TP_Final_DYADM_BD.dtsTotAluInscTableAdapters.spTotAluInscTableAdapter()
        CType(Me.spTotAluInscBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtsTotAluInsc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spTotAluInscBindingSource
        '
        Me.spTotAluInscBindingSource.DataMember = "spTotAluInsc"
        Me.spTotAluInscBindingSource.DataSource = Me.dtsTotAluInsc
        '
        'dtsTotAluInsc
        '
        Me.dtsTotAluInsc.DataSetName = "dtsTotAluInsc"
        Me.dtsTotAluInsc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "dtsTotAluInsc"
        ReportDataSource1.Value = Me.spTotAluInscBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "TP_Final_DYADM_BD.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 50)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(647, 312)
        Me.ReportViewer1.TabIndex = 0
        '
        'txtTurno
        '
        Me.txtTurno.Location = New System.Drawing.Point(149, 8)
        Me.txtTurno.Name = "txtTurno"
        Me.txtTurno.Size = New System.Drawing.Size(100, 20)
        Me.txtTurno.TabIndex = 1
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(366, 8)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(100, 20)
        Me.txtAño.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(108, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Turno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(334, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Año"
        '
        'btnReporte
        '
        Me.btnReporte.Location = New System.Drawing.Point(551, 6)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(108, 23)
        Me.btnReporte.TabIndex = 5
        Me.btnReporte.Text = "Generar Reporte"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'spTotAluInscTableAdapter
        '
        Me.spTotAluInscTableAdapter.ClearBeforeFill = True
        '
        'frmTotAluInsc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 374)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAño)
        Me.Controls.Add(Me.txtTurno)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmTotAluInsc"
        Me.Text = "Total de Alumnos Inscriptos"
        CType(Me.spTotAluInscBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtsTotAluInsc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txtTurno As TextBox
    Friend WithEvents txtAño As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnReporte As Button
    Friend WithEvents spTotAluInscBindingSource As BindingSource
    Friend WithEvents dtsTotAluInsc As dtsTotAluInsc
    Friend WithEvents spTotAluInscTableAdapter As dtsTotAluInscTableAdapters.spTotAluInscTableAdapter
End Class

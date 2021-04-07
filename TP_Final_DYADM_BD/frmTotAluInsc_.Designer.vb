<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTotAluInsc_
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SpTotAluInscTableAdapter1 = New TP_Final_DYADM_BD.dtsTotAluInscTableAdapters.spTotAluInscTableAdapter()
        Me.DtsTotAluInsc1 = New TP_Final_DYADM_BD.dtsTotAluInsc()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DtsTotAluInsc1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTurno
        '
        Me.txtTurno.Location = New System.Drawing.Point(79, 30)
        Me.txtTurno.Name = "txtTurno"
        Me.txtTurno.Size = New System.Drawing.Size(100, 20)
        Me.txtTurno.TabIndex = 0
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(274, 12)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(100, 20)
        Me.txtAño.TabIndex = 1
        '
        'ReportViewer1
        '
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "TP_Final_DYADM_BD.rdlcTotAluInsc_.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(37, 116)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(504, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SpTotAluInscTableAdapter1
        '
        Me.SpTotAluInscTableAdapter1.ClearBeforeFill = True
        '
        'DtsTotAluInsc1
        '
        Me.DtsTotAluInsc1.DataSetName = "dtsTotAluInsc"
        Me.DtsTotAluInsc1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "spTotAluInsc"
        Me.BindingSource1.DataSource = Me.DtsTotAluInsc1
        '
        'frmTotAluInsc_
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.txtAño)
        Me.Controls.Add(Me.txtTurno)
        Me.Name = "frmTotAluInsc_"
        Me.Text = "frmTotAluInsc_"
        CType(Me.DtsTotAluInsc1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTurno As TextBox
    Friend WithEvents txtAño As TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Button1 As Button
    Friend WithEvents SpTotAluInscTableAdapter1 As dtsTotAluInscTableAdapters.spTotAluInscTableAdapter
    Friend WithEvents DtsTotAluInsc1 As dtsTotAluInsc
    Friend WithEvents BindingSource1 As BindingSource
End Class

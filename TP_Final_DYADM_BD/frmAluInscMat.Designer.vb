<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAluInscMat
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlumnosInsc = New TP_Final_DYADM_BD.AlumnosInsc()
        Me.lblMateria = New System.Windows.Forms.Label()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.cmbMateria = New System.Windows.Forms.ComboBox()
        Me.cmbTurno = New System.Windows.Forms.ComboBox()
        Me.ReporteAlumInsc = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.DataTable1TableAdapter = New TP_Final_DYADM_BD.AlumnosInscTableAdapters.DataTable1TableAdapter()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosInsc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.AlumnosInsc
        '
        'AlumnosInsc
        '
        Me.AlumnosInsc.DataSetName = "AlumnosInsc"
        Me.AlumnosInsc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblMateria
        '
        Me.lblMateria.AutoSize = True
        Me.lblMateria.Location = New System.Drawing.Point(9, 7)
        Me.lblMateria.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMateria.Name = "lblMateria"
        Me.lblMateria.Size = New System.Drawing.Size(45, 13)
        Me.lblMateria.TabIndex = 0
        Me.lblMateria.Text = "Materia:"
        '
        'lblTurno
        '
        Me.lblTurno.AutoSize = True
        Me.lblTurno.Location = New System.Drawing.Point(160, 7)
        Me.lblTurno.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(38, 13)
        Me.lblTurno.TabIndex = 1
        Me.lblTurno.Text = "Turno:"
        '
        'cmbMateria
        '
        Me.cmbMateria.FormattingEnabled = True
        Me.cmbMateria.Location = New System.Drawing.Point(58, 7)
        Me.cmbMateria.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbMateria.Name = "cmbMateria"
        Me.cmbMateria.Size = New System.Drawing.Size(92, 21)
        Me.cmbMateria.TabIndex = 1
        '
        'cmbTurno
        '
        Me.cmbTurno.FormattingEnabled = True
        Me.cmbTurno.Location = New System.Drawing.Point(202, 7)
        Me.cmbTurno.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbTurno.Name = "cmbTurno"
        Me.cmbTurno.Size = New System.Drawing.Size(92, 21)
        Me.cmbTurno.TabIndex = 2
        '
        'ReporteAlumInsc
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DataTable1BindingSource
        Me.ReporteAlumInsc.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReporteAlumInsc.LocalReport.ReportEmbeddedResource = "TP_Final_DYADM_BD.Reporte_AlumnInsc.rdlc"
        Me.ReporteAlumInsc.Location = New System.Drawing.Point(9, 32)
        Me.ReporteAlumInsc.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ReporteAlumInsc.Name = "ReporteAlumInsc"
        Me.ReporteAlumInsc.ServerReport.BearerToken = Nothing
        Me.ReporteAlumInsc.Size = New System.Drawing.Size(580, 312)
        Me.ReporteAlumInsc.TabIndex = 5
        '
        'btnVer
        '
        Me.btnVer.Location = New System.Drawing.Point(313, 7)
        Me.btnVer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(56, 19)
        Me.btnVer.TabIndex = 3
        Me.btnVer.Text = "Ver"
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'frmAluInscMat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.ReporteAlumInsc)
        Me.Controls.Add(Me.cmbTurno)
        Me.Controls.Add(Me.cmbMateria)
        Me.Controls.Add(Me.lblTurno)
        Me.Controls.Add(Me.lblMateria)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmAluInscMat"
        Me.Text = "Listado de Alumnos Inscriptos"
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosInsc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMateria As Label
    Friend WithEvents lblTurno As Label
    Friend WithEvents cmbMateria As ComboBox
    Friend WithEvents cmbTurno As ComboBox
    Friend WithEvents ReporteAlumInsc As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnVer As Button
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents AlumnosInsc As AlumnosInsc
    Friend WithEvents DataTable1TableAdapter As AlumnosInscTableAdapters.DataTable1TableAdapter
End Class

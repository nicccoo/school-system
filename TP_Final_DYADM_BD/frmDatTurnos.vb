Public Class frmDatTurnos
    Private Sub Informe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim Conexion As SqlClient.SqlConnection
        Dim DA As SqlClient.SqlDataAdapter
        Dim DT As DataTable

        Conexion = New SqlClient.SqlConnection
        Conexion.ConnectionString = "Data Source=localhost\SQLEXPRESS;Initial Catalog=Disenio_admin_BD;Integrated Security=True"
        Conexion.Open()

        DA = New SqlClient.SqlDataAdapter(InformeSQL, Conexion)
        DT = New DataTable
        DA.Fill(DT)


        ReportViewer1.LocalReport.ReportPath = "C:\Users\Fausto\Desktop\Facultad\TSP\Segundo 2C\Admin BD\zzNicolas\tp-final\tpfinal\tpfinal\rdlcExamenesPorTurnos.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", DT))

        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Dim preg = MessageBox.Show("¿Seguro desea salir?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If preg = DialogResult.Yes Then

            Me.Close()

        End If

    End Sub

End Class
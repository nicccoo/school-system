Imports Microsoft.Reporting.WinForms

Public Class frmTotAluInsc
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtTurno.TextChanged

    End Sub

    Private Sub frmTotAluInsc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.SpTotAluInscTableAdapter.Fill(Me.Disenio_admin_BDDataSet.spTotAluInsc, txtTurno.Text, txtAño.Text)
        Dim parameters(1) As ReportParameter
        parameters(0) = New ReportParameter("Turno", Me.txtTurno.Text)
        parameters(1) = New ReportParameter("Anio", Me.txtAño.Text)
        Me.ReportViewer1.LocalReport.SetParameters(parameters)
        Me.ReportViewer1.RefreshReport()


    End Sub
End Class
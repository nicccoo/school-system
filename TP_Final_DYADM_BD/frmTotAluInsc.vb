Imports Microsoft.Reporting.WinForms
Public Class frmTotAluInsc
    Private Sub frmTotAluInsc_3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Me.spTotAluInscTableAdapter.Fill(Me.dtsTotAluInsc.spTotAluInsc, txtTurno.Text, txtAño.Text)
        Dim parameters(1) As ReportParameter
        parameters(0) = New ReportParameter("Turno", Me.txtTurno.Text)
        parameters(1) = New ReportParameter("Anio", Me.txtAño.Text)
        Me.ReportViewer1.LocalReport.SetParameters(parameters)
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class
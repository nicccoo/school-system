

Imports System.Runtime.CompilerServices
Imports Microsoft.Reporting.WinForms



Public Class frmAluInscMat
    Private Sub frmDatTurnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        cargarMaterias()
        cargarTurnos()

    End Sub
    Private Sub cargarMaterias()
        Dim cadenaSQL As String
        Dim tabla As DataTable
        tabla = New DataTable

        'CARGAR COMBOBOX DE MATERIAS
        cadenaSQL = "select * from Materias"
        tabla = New DataTable

        Recuperar(cadenaSQL, tabla)
        cmbMateria.DataSource = tabla
        cmbMateria.ValueMember = "cod_materia"
        cmbMateria.DisplayMember = "desc_mat"
        cmbMateria.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMateria.SelectedIndex = 0
    End Sub
    Private Sub cargarTurnos()
        Dim cadenaSQL As String
        Dim tabla As DataTable
        tabla = New DataTable

        'CARGAR COMBOBOX DE TURNOS
        cadenaSQL = "select * from Turnos"
        tabla = New DataTable

        Recuperar(cadenaSQL, tabla)
        cmbTurno.DataSource = tabla
        cmbTurno.ValueMember = "cod_turno"
        cmbTurno.DisplayMember = "desc_turno"
        cmbTurno.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTurno.SelectedIndex = 0
    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        Dim materia As String
        materia = cmbMateria.SelectedValue
        Dim turno As String
        turno = cmbTurno.SelectedValue

        Me.DataTable1TableAdapter.Fill(Me.AlumnosInsc.DataTable1, materia, turno)
        Dim parameters(1) As ReportParameter

        parameters(0) = New ReportParameter("x", materia)

        parameters(1) = New ReportParameter("y", turno)

        Me.ReporteAlumInsc.LocalReport.SetParameters(parameters)
        Me.ReporteAlumInsc.RefreshReport()

    End Sub
End Class
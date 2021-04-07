Public Class frmPrincipal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Select Case AccesoLog
            Case "Profesor"
                mnuModificacion.Visible = False
                mnuBaja.Visible = False
                mnuMatAlta.Visible = False
                mnuProfAlta.Visible = False
                mnuAluAlta.Visible = False
            Case "Alumno"
                mnuTotAluApro.Visible = False
                mnuTotAluInsc.Visible = False
                mnuAluInscMat.Visible = False
                mnuABM.Visible = False
            Case "Administrador"
            Case Else
                MsgBox("Error de loggeo, por favor intente nuevamente", vbOKOnly + vbCritical)
                Me.Dispose()
                frmLogin.Show()
        End Select
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub mnuAluAlta_Click(sender As Object, e As EventArgs) Handles mnuAluAlta.Click
        frmAluAlta.Show()
        frmAluBaja.Dispose()
        frmAluMod.Dispose()
        frmMatAlta.Dispose()
        'frmMatBaja.Dispose()
        frmMatBajaMod.Dispose()
        frmProfAlta.Dispose()
        frmProfBaja.Dispose()
        frmProfMod.Dispose()
        frmExamenAlta.Dispose()
        frmListadoExamenes.Dispose()
        frmModificarExamen.Dispose()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Dispose()
        frmDatTurnos.Dispose()
        frmCambiarPass.Dispose()
    End Sub

    Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        Me.Dispose()
        frmLogin.ShowDialog()
    End Sub

    Private Sub mnuSalir_Click(sender As Object, e As EventArgs) Handles mnuSalir.Click
        Application.Exit()
    End Sub

    Private Sub mnuAluBaja_Click(sender As Object, e As EventArgs) Handles mnuAluBaja.Click
        frmAluAlta.Dispose()
        frmAluBaja.Show()
        frmAluMod.Dispose()
        frmMatAlta.Dispose()
        'frmMatBaja.Dispose()
        frmMatBajaMod.Dispose()
        frmProfAlta.Dispose()
        frmProfBaja.Dispose()
        frmProfMod.Dispose()
        frmExamenAlta.Dispose()
        frmListadoExamenes.Dispose()
        frmModificarExamen.Dispose()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Dispose()
        frmDatTurnos.Dispose()
        frmCambiarPass.Dispose()
    End Sub

    Private Sub mnuAluMod_Click(sender As Object, e As EventArgs) Handles mnuAluMod.Click
        frmAluAlta.Dispose()
        frmAluBaja.Dispose()
        frmAluMod.Show()
        frmMatAlta.Dispose()
        'frmMatBaja.Dispose()
        frmMatBajaMod.Dispose()
        frmProfAlta.Dispose()
        frmProfBaja.Dispose()
        frmProfMod.Dispose()
        frmExamenAlta.Dispose()
        frmListadoExamenes.Dispose()
        frmModificarExamen.Dispose()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Dispose()
        frmDatTurnos.Dispose()
        frmCambiarPass.Dispose()
    End Sub

    Private Sub mnuMatAlta_Click(sender As Object, e As EventArgs) Handles mnuMatAlta.Click
        frmAluAlta.Dispose()
        frmAluBaja.Dispose()
        frmAluMod.Dispose()
        frmMatAlta.Show()
        'frmMatBaja.Dispose()
        frmMatBajaMod.Dispose()
        frmProfAlta.Dispose()
        frmProfBaja.Dispose()
        frmProfMod.Dispose()
        frmExamenAlta.Dispose()
        frmListadoExamenes.Dispose()
        frmModificarExamen.Dispose()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Dispose()
        frmDatTurnos.Dispose()
        frmCambiarPass.Dispose()

    End Sub

    Private Sub mnuMatBaja_Click(sender As Object, e As EventArgs) Handles mnuMatBaja.Click
        Operacion = "MatBaja"

        frmMatBajaMod.Dispose()
        frmAluAlta.Dispose()
        frmAluBaja.Dispose()
        frmAluMod.Dispose()
        frmMatAlta.Dispose()
        'frmMatBaja.Show()
        frmMatBajaMod.Show()
        frmProfAlta.Dispose()
        frmProfBaja.Dispose()
        frmProfMod.Dispose()
        frmExamenAlta.Dispose()
        frmListadoExamenes.Dispose()
        frmModificarExamen.Dispose()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Dispose()
        frmDatTurnos.Dispose()
        frmCambiarPass.Dispose()

    End Sub

    Private Sub mnuMatMod_Click(sender As Object, e As EventArgs) Handles mnuMatMod.Click
        Operacion = "MatModificacion"
        frmMatBajaMod.Dispose()
        frmAluAlta.Dispose()
        frmAluBaja.Dispose()
        frmAluMod.Dispose()
        frmMatAlta.Dispose()
        'frmMatBaja.Dispose()
        frmMatBajaMod.Show()
        frmProfAlta.Dispose()
        frmProfBaja.Dispose()
        frmProfMod.Dispose()
        frmExamenAlta.Dispose()
        frmListadoExamenes.Dispose()
        frmModificarExamen.Dispose()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Dispose()
        frmDatTurnos.Dispose()
        frmCambiarPass.Dispose()

    End Sub

    Private Sub mnuProfAlta_Click(sender As Object, e As EventArgs) Handles mnuProfAlta.Click
        frmAluAlta.Dispose()
        frmAluBaja.Dispose()
        frmAluMod.Dispose()
        frmMatAlta.Dispose()
        'frmMatBaja.Dispose()
        frmMatBajaMod.Dispose()
        frmProfAlta.Show()
        frmProfBaja.Dispose()
        frmProfMod.Dispose()
        frmExamenAlta.Dispose()
        frmListadoExamenes.Dispose()
        frmModificarExamen.Dispose()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Dispose()
        frmDatTurnos.Dispose()
        frmCambiarPass.Dispose()

    End Sub

    Private Sub mnuProfBaja_Click(sender As Object, e As EventArgs) Handles mnuProfBaja.Click
        frmAluAlta.Dispose()
        frmAluBaja.Dispose()
        frmAluMod.Dispose()
        frmMatAlta.Dispose()
        'frmMatBaja.Dispose()
        frmMatBajaMod.Dispose()
        frmProfAlta.Dispose()
        frmProfBaja.Show()
        frmProfMod.Dispose()
        frmExamenAlta.Dispose()
        frmListadoExamenes.Dispose()
        frmModificarExamen.Dispose()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Dispose()
        frmDatTurnos.Dispose()
        frmCambiarPass.Dispose()

    End Sub

    Private Sub mnuProfMod_Click(sender As Object, e As EventArgs) Handles mnuProfMod.Click
        frmAluAlta.Dispose()
        frmAluBaja.Dispose()
        frmAluMod.Dispose()
        frmMatAlta.Dispose()
        'frmMatBaja.Dispose()
        frmMatBajaMod.Dispose()
        frmProfAlta.Dispose()
        frmProfBaja.Dispose()
        frmProfMod.Show()
        frmExamenAlta.Dispose()
        frmListadoExamenes.Dispose()
        frmModificarExamen.Dispose()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Dispose()
        frmDatTurnos.Dispose()
        frmCambiarPass.Dispose()

    End Sub

    Private Sub mnuExamenAlta_Click(sender As Object, e As EventArgs) Handles mnuExamenAlta.Click
        frmAluAlta.Dispose()
        frmAluBaja.Dispose()
        frmAluMod.Dispose()
        frmMatAlta.Dispose()
        'frmMatBaja.Dispose()
        frmMatBajaMod.Dispose()
        frmProfAlta.Dispose()
        frmProfBaja.Dispose()
        frmProfMod.Dispose()
        frmExamenAlta.Show()
        frmListadoExamenes.Dispose()
        frmModificarExamen.Dispose()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Dispose()
        frmDatTurnos.Dispose()
        frmCambiarPass.Dispose()

    End Sub

    Private Sub mnuExamenBaja_Click(sender As Object, e As EventArgs) Handles mnuExamenBaja.Click
        frmAluAlta.Dispose()
        frmAluBaja.Dispose()
        frmAluMod.Dispose()
        frmMatAlta.Dispose()
        'frmMatBaja.Dispose()
        frmMatBajaMod.Dispose()
        frmProfAlta.Dispose()
        frmProfBaja.Dispose()
        frmProfMod.Dispose()
        frmExamenAlta.Dispose()
        frmListadoExamenes.Show()
        frmModificarExamen.Dispose()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Dispose()
        frmDatTurnos.Dispose()
        frmCambiarPass.Dispose()

    End Sub

    Private Sub mnuExamenMod_Click(sender As Object, e As EventArgs) Handles mnuExamenMod.Click
        frmAluAlta.Dispose()
        frmAluBaja.Dispose()
        frmAluMod.Dispose()
        frmMatAlta.Dispose()
        'frmMatBaja.Dispose()
        frmMatBajaMod.Dispose()
        frmProfAlta.Dispose()
        frmProfBaja.Dispose()
        frmProfMod.Dispose()
        frmExamenAlta.Dispose()
        frmListadoExamenes.Dispose()
        frmModificarExamen.Show()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Dispose()
        frmDatTurnos.Dispose()
        frmCambiarPass.Dispose()

    End Sub

    Private Sub mnuTotAluInsc_Click(sender As Object, e As EventArgs) Handles mnuTotAluInsc.Click
        frmAluAlta.Dispose()
        frmAluBaja.Dispose()
        frmAluMod.Dispose()
        frmMatAlta.Dispose()
        'frmMatBaja.Dispose()
        frmMatBajaMod.Dispose()
        frmProfAlta.Dispose()
        frmProfBaja.Dispose()
        frmProfMod.Dispose()
        frmExamenAlta.Dispose()
        frmListadoExamenes.Dispose()
        frmModificarExamen.Dispose()
        frmTotAluInsc.Show()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Dispose()
        frmDatTurnos.Dispose()
        frmCambiarPass.Dispose()

    End Sub

    Private Sub mnuTotAluApro_Click(sender As Object, e As EventArgs) Handles mnuTotAluApro.Click

        Dim cadenaSql As String

        cadenaSql = "select tur.cod_turno, (select count(exa.nota) from Examenes exa where exa.nota >= 7 and exa.cod_turno = tur.cod_turno) * 100 / count(exa.nota) as 'PercAprobados' from Turnos tur, Examenes exa where exa.cod_turno = tur.cod_turno group by tur.cod_turno"

        ModuloGeneral.Informe = cadenaSql
        frmAluAlta.Dispose()
        frmAluBaja.Dispose()
        frmAluMod.Dispose()
        frmMatAlta.Dispose()
        'frmMatBaja.Dispose()
        frmMatBajaMod.Dispose()
        frmProfAlta.Dispose()
        frmProfBaja.Dispose()
        frmProfMod.Dispose()
        frmExamenAlta.Dispose()
        frmListadoExamenes.Dispose()
        frmModificarExamen.Dispose()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Show()
        frmAluInscMat.Dispose()
        frmDatTurnos.Dispose()

    End Sub

    Private Sub mnuAluInscMat_Click(sender As Object, e As EventArgs) Handles mnuAluInscMat.Click
        frmAluAlta.Dispose()
        frmAluBaja.Dispose()
        frmAluMod.Dispose()
        frmMatAlta.Dispose()
        'frmMatBaja.Dispose()
        frmMatBajaMod.Dispose()
        frmProfAlta.Dispose()
        frmProfBaja.Dispose()
        frmProfMod.Dispose()
        frmExamenAlta.Dispose()
        frmListadoExamenes.Dispose()
        frmModificarExamen.Dispose()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Show()
        frmDatTurnos.Dispose()
        frmCambiarPass.Dispose()

    End Sub

    Private Sub mnuDatTurnos_Click(sender As Object, e As EventArgs) Handles mnuDatTurnos.Click

        Dim CadenaSQL As String

        CadenaSQL = "select pro.nro_legajo_p, pro.ape_nomb, m.cod_materia, m.desc_mat, Turnos.cod_turno, pla.fecha_examen
                    from profesores pro, materias m, PLANIFICACION pla, Turnos
                    where pro.nro_legajo_p = m.nro_legajo_p and m.cod_materia = pla.cod_mat and Turnos.cod_turno = pla.cod_turno"


        InformeSQL = CadenaSQL
        frmExamenAlta.Dispose()
        frmListadoExamenes.Dispose()
        frmModificarExamen.Dispose()
        frmAluAlta.Dispose()
        frmAluBaja.Dispose()
        frmAluMod.Dispose()
        frmMatAlta.Dispose()
        'frmMatBaja.Dispose()
        frmMatBajaMod.Dispose()
        frmProfAlta.Dispose()
        frmProfBaja.Dispose()
        frmProfMod.Dispose()
        frmExamenAlta.Dispose()
        frmListadoExamenes.Dispose()
        frmModificarExamen.Dispose()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Dispose()
        frmDatTurnos.Show()
        frmCambiarPass.Dispose()

    End Sub

    Private Sub mnuCambiarPass_Click(sender As Object, e As EventArgs) Handles mnuCambiarPass.Click
        frmAluAlta.Dispose()
        frmAluBaja.Dispose()
        frmAluMod.Dispose()
        frmMatAlta.Dispose()
        'frmMatBaja.Dispose()
        frmMatBajaMod.Dispose()
        frmProfAlta.Dispose()
        frmProfBaja.Dispose()
        frmProfMod.Dispose()
        frmExamenAlta.Dispose()
        frmListadoExamenes.Dispose()
        frmModificarExamen.Dispose()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Dispose()
        frmDatTurnos.Dispose()
        frmCambiarPass.Show()
    End Sub

End Class
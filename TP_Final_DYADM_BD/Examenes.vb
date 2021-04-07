Public Class Examenes

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()

    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        frmExamenAlta.Show()
        frmListadoExamenes.Dispose()

    End Sub
    Private Sub BajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaToolStripMenuItem.Click

        frmListadoExamenes.Show()
        frmExamenAlta.Dispose()

    End Sub


    Private Sub ModificarToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click

        frmModificarExamen.Show()
        frmListadoExamenes.Dispose()
        frmExamenAlta.Dispose()

    End Sub


    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click

        Dim CadenaSQL As String

        CadenaSQL = "select pro.nro_legajo_p, pro.ape_nomb, m.cod_materia, m.desc_mat, Turnos.cod_turno, pla.fecha_examen
                    from profesores pro, materias m, PLANIFICACION pla, Turnos
                    where pro.nro_legajo_p = m.nro_legajo_p and m.cod_materia = pla.cod_mat and Turnos.cod_turno = pla.cod_turno"


        InformeSQL = CadenaSQL

        Informe.ShowDialog()
        frmExamenAlta.Dispose()
        frmListadoExamenes.Dispose()
        frmModificarExamen.Dispose()

    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim preg = MessageBox.Show("¿Seguro desea salir?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If preg = DialogResult.Yes Then

            Me.Close()

        End If

    End Sub


End Class

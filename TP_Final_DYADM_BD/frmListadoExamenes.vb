Public Class frmListadoExamenes
    Private Sub frmExamenBaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        CargarGrilla()

    End Sub

    Public Sub CargarGrilla()
        Dim CadenaSQL As String
        Dim Tabla As DataTable

        If txtFiltrar.Text = String.Empty Then
            CadenaSQL = " select a.nro_legajo_a, a.ape_nomb, e.* from examenes e, alumnos a where e.nro_legajo_a = a.nro_legajo_a order by ape_nomb asc"
        Else
            CadenaSQL = " select a.nro_legajo_a, a.ape_nomb, e.* from examenes e, alumnos a where e.nro_legajo_a = a.nro_legajo_a  and a.ape_nomb like '%" & txtFiltrar.Text.Trim & "%' order by ape_nomb asc"
        End If

        Tabla = New DataTable
        Recuperar(CadenaSQL, Tabla)

        DGVExamenes.DataSource = Tabla
        DGVExamenes.Columns("nro_legajo_a1").Visible = False
        DGVExamenes.AllowUserToAddRows = False
        DGVExamenes.AllowUserToDeleteRows = False
        DGVExamenes.ReadOnly = True
        DGVExamenes.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub txtFiltrar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltrar.KeyPress
        CargarGrilla()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ctxEliminar.Click
        Dim CadenaSQL As String



        If DGVExamenes.CurrentRow Is Nothing Then

                MessageBox.Show("No hay registro para eliminar!", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Else

                CadenaSQL = "Delete from Examenes where nro_legajo_a  = " & DGVExamenes.CurrentRow.Cells("nro_legajo_a").Value & "AND cod_mat = '" & DGVExamenes.CurrentRow.Cells("cod_mat").Value & "' AND cod_turno = '" & DGVExamenes.CurrentRow.Cells("cod_turno").Value & "'"

                Try

                    Ejecutar(CadenaSQL)
                    MessageBox.Show("¡Examen eliminado con exito!", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargarGrilla()

                Catch ex As Exception

                    MessageBox.Show("Operacion fallida: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End Try


            End If


    End Sub


End Class
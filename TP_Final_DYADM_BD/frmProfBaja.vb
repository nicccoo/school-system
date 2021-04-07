Public Class frmProfBaja

    Private Sub frmProfBaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        CargarGrilla()

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltro.Click

        CargarGrilla()

    End Sub

    Private Sub opEliminar_Click(sender As Object, e As EventArgs) Handles opEliminar.Click

        If MessageBox.Show("¿Seguro que desea eliminar al profesor?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            EliminarProf()
        Else
            txtProfesor.Text = String.Empty
            CargarGrilla()
        End If

    End Sub

    Private Sub CargarGrilla()

        Dim cadenaSQL As String
        Dim tabla As DataTable
        tabla = New DataTable

        If txtProfesor.Text.Trim = String.Empty Then

            cadenaSQL = "select nro_legajo_p as 'Num. Legajo', ape_nomb as 'Apellido y nombre', nro_doc as 'Num. Doc' from Profesores"

        Else

            cadenaSQL = "select nro_legajo_p as 'Num. Legajo', ape_nomb as 'Apellido y nombre', nro_doc as 'Num. Doc' from Profesores where ape_nomb like '%" & txtProfesor.Text & "%' order by ape_nomb"

        End If

        Recuperar(cadenaSQL, tabla)
        dgvFiltroProf.DataSource = tabla
        dgvFiltroProf.AllowUserToAddRows = False
        dgvFiltroProf.AllowUserToDeleteRows = False
        dgvFiltroProf.ReadOnly = True
        dgvFiltroProf.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub EliminarProf()

        Dim cadenaSQL As String

        cadenaSQL = "delete from Profesores where nro_legajo_p = " & dgvFiltroProf.Item(0, dgvFiltroProf.CurrentRow.Index).Value

        Try
            Ejecutar(cadenaSQL)
            MessageBox.Show("¡Profesor eliminado con éxito!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarGrilla()
        Catch ex As Exception
            MessageBox.Show("La operación fallida: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class
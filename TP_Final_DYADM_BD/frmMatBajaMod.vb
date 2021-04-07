Public Class frmMatBajaMod
    Private Sub frmMatBajaMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strCadenaSQL As String
        Dim dttTabla As New DataTable

        Me.CenterToScreen()
        Select Case Operacion
            Case "MatBaja"
                Me.Text = "Baja de Materia"
            Case "MatModificacion"
                Me.Text = "Modificación de Materia"
        End Select
        CargarGrilla()

        dttTabla = New DataTable
        strCadenaSQL = "select * from Profesores order by ape_nomb"
        Recuperar(strCadenaSQL, dttTabla)
        cmbProfesor.DataSource = dttTabla
        cmbProfesor.DisplayMember = "ape_nomb"
        cmbProfesor.ValueMember = "nro_legajo_p"
        cmbProfesor.SelectedValue = 1

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Select Case Operacion
            Case "MatBaja"
                If MessageBox.Show("Va a eliminar la materia " & mtxtCodMateria.Text & Environment.NewLine & "¿Está seguro de querer hacerlo?", "Eliminar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    Eliminar()
                End If
            Case "MatModificacion"
                If ValidarMateria() Then
                    Modificar()
                    'hacer un mensaje de modificado OK
                End If
        End Select
        CargarGrilla()
    End Sub

    Private Sub Eliminar()
        Dim strCadenaSQL As String
        Try
            strCadenaSQL = "delete Materias where cod_materia = '" & mtxtCodMateria.Text & "'"
            Ejecutar(strCadenaSQL)
            MessageBox.Show("Materia eliminada", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error durante el proceso de borrado " & Environment.NewLine & "Error: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Modificar()
        Dim strCadenaSQL As String
        Try
            strCadenaSQL = "update materias set cod_materia = '" & mtxtCodMateria.Text & "', desc_mat = '" & txtDescMateria.Text & "', desc_carrera = '" & txtCarrera.Text.Trim & "', nro_legajo_p = " & cmbProfesor.SelectedValue & "where cod_materia = '" & mtxtCodMateria.Text & "'"
            Ejecutar(strCadenaSQL)
            MessageBox.Show("Datos modificados correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error durante el proceso de borrado " & Environment.NewLine & "Error: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub dgvMaterias_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMaterias.CellClick
        If Operacion = "MatModificacion" Then
            txtDescMateria.Enabled = True
            txtCarrera.Enabled = True
            cmbProfesor.Enabled = True
        End If
        mtxtCodMateria.Text = dgvMaterias.Rows(e.RowIndex).Cells(0).Value.ToString
        txtDescMateria.Text = dgvMaterias.Rows(e.RowIndex).Cells(1).Value.ToString
        txtCarrera.Text = dgvMaterias.Rows(e.RowIndex).Cells(2).Value.ToString
        cmbProfesor.SelectedValue = dgvMaterias.Item(3, dgvMaterias.CurrentRow.Index).Value
        btnAceptar.Enabled = True
    End Sub

    Public Function ValidarMateria() As Boolean
        If mtxtCodMateria.MaskFull = False Then
            MessageBox.Show("Por favor complete el código de materia con el formato AA9990")
            Return False
        End If
        If txtDescMateria.Text = String.Empty Then
            MsgBox("Por favor complete la materia", vbOKOnly + vbCritical)
            Return False
        End If
        If txtCarrera.Text = String.Empty Then
            MsgBox("Por favor complete a qué carrera pertenece", vbOKOnly + vbCritical)
            Return False
        End If
        Return True
    End Function
    Private Sub CargarGrilla()
        Dim strCadenaSQL As String
        Dim dttTabla As New DataTable
        strCadenaSQL = "select m.*, p.ape_nomb from Materias m inner join profesores p on m.nro_legajo_p = p.nro_legajo_p"
        Recuperar(strCadenaSQL, dttTabla)
        dgvMaterias.DataSource = dttTabla
        dgvMaterias.Columns("nro_legajo_p").Visible = False
        dgvMaterias.Columns("cod_materia").HeaderText = "Código Materia"
        dgvMaterias.Columns("desc_mat").HeaderText = "Materia"
        dgvMaterias.Columns("desc_carrera").HeaderText = "Carrera"
        dgvMaterias.Columns("ape_nomb").HeaderText = "Profesor"
        dgvMaterias.Columns("cod_materia").Width = 60
        dgvMaterias.Columns("desc_mat").Width = 180
        dgvMaterias.Columns("desc_carrera").Width = 150
        dgvMaterias.Columns("ape_nomb").Width = 170
        dgvMaterias.AllowUserToAddRows = False
        dgvMaterias.AllowUserToDeleteRows = False
        dgvMaterias.AllowUserToResizeRows = False
        dgvMaterias.AllowUserToResizeColumns = False
        dgvMaterias.AllowUserToOrderColumns = False
        dgvMaterias.ReadOnly = True
        dgvMaterias.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        mtxtCodMateria.Text = dttTabla.Rows(0).Item("cod_materia")
        txtDescMateria.Text = dttTabla.Rows(0).Item("desc_mat")
        txtCarrera.Text = dttTabla.Rows(0).Item("desc_carrera")

    End Sub

End Class


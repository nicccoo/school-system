Public Class frmModificarExamen
    Private Sub frmModificarExamen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CadenaSQL As String
        Dim Table As DataTable

        Me.CenterToScreen()
        CargarGrilla()

        cmbAlumno.Enabled = False
        cmbCodMat.Enabled = False
        cmbCodTurno.Enabled = False
        txtAño.Enabled = False
        txtNota.Enabled = False
        txtFiltrar.Enabled = True
        dtpFechaInscripcion.Enabled = False
        btnModificar.Enabled = False
        cmbNroLegajo.Enabled = False

        CadenaSQL = "select * from alumnos order by ape_nomb asc"
        Table = New DataTable
        Recuperar(CadenaSQL, Table)

        cmbAlumno.DataSource = Table
        cmbAlumno.DisplayMember = "ape_nomb"
        cmbAlumno.ValueMember = "ape_nomb"
        cmbAlumno.DropDownStyle = ComboBoxStyle.DropDownList
        cmbAlumno.SelectedIndex = 0

        CadenaSQL = "Select * from examenes order by nro_legajo_a asc"
        Table = New DataTable
        Recuperar(CadenaSQL, Table)

        cmbNroLegajo.DataSource = Table
        cmbNroLegajo.DisplayMember = "nro_legajo_a"
        cmbNroLegajo.ValueMember = "nro_legajo_a"
        cmbNroLegajo.DropDownStyle = ComboBoxStyle.DropDownList
        cmbNroLegajo.SelectedIndex = 0

        CadenaSQL = "Select * from examenes order by cod_mat asc"
        Table = New DataTable
        Recuperar(CadenaSQL, Table)

        cmbCodMat.DataSource = Table
        cmbCodMat.DisplayMember = "cod_mat"
        cmbCodMat.ValueMember = "cod_mat"
        cmbCodMat.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCodMat.SelectedIndex = 0

        CadenaSQL = "Select * from turnos order by cod_turno asc"
        Table = New DataTable
        Recuperar(CadenaSQL, Table)

        cmbCodTurno.DataSource = Table
        cmbCodTurno.DisplayMember = "cod_turno"
        cmbCodTurno.ValueMember = "cod_turno"
        cmbCodTurno.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCodTurno.SelectedIndex = 0


    End Sub

    Public Sub CargarGrilla()
        Dim CadenaSQL As String
        Dim Tabla As DataTable

        If txtFiltrar.Text = String.Empty Then
            CadenaSQL = " select a.ape_nomb, e.* from examenes e, alumnos a where e.nro_legajo_a = a.nro_legajo_a order by ape_nomb asc"
        Else
            CadenaSQL = " select a.ape_nomb, e.* from examenes e, alumnos a where e.nro_legajo_a = a.nro_legajo_a  and a.ape_nomb like '%" & txtFiltrar.Text.Trim & "%' order by ape_nomb asc"
        End If

        Tabla = New DataTable
        Recuperar(CadenaSQL, Tabla)

        DGVExamenes.DataSource = Tabla
        DGVExamenes.Columns("nro_legajo_a").Visible = False
        DGVExamenes.AllowUserToAddRows = False
        DGVExamenes.AllowUserToDeleteRows = False
        DGVExamenes.ReadOnly = True
        DGVExamenes.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub DGVExamenes_SelectionChanged(sender As Object, e As EventArgs) Handles DGVExamenes.SelectionChanged

        Dim CadenaSQL As String
        Dim Table As DataTable

        CadenaSQL = "select a.ape_nomb, e.* from alumnos a, examenes e where a.nro_legajo_a = e.nro_legajo_a"
        Table = New DataTable
        Recuperar(CadenaSQL, Table)

        cmbAlumno.Text = (DGVExamenes.Rows(DGVExamenes.CurrentRow.Index).Cells(0).Value)
        cmbNroLegajo.SelectedValue = (DGVExamenes.Rows(DGVExamenes.CurrentRow.Index).Cells(1).Value).ToString()
        cmbCodMat.SelectedValue = (DGVExamenes.Rows(DGVExamenes.CurrentRow.Index).Cells(2).Value)
        cmbCodTurno.SelectedValue = (DGVExamenes.Rows(DGVExamenes.CurrentRow.Index).Cells(3).Value)
        txtAño.Text = (DGVExamenes.Rows(DGVExamenes.CurrentRow.Index).Cells(4).Value)
        txtNota.Text = (DGVExamenes.Rows(DGVExamenes.CurrentRow.Index).Cells(5).Value)
        dtpFechaInscripcion.Value = (DGVExamenes.Rows(DGVExamenes.CurrentRow.Index).Cells(6).Value)


    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Dim CadenaSQL As String

        If Validar() Then

            CadenaSQL = "Update examenes set nro_legajo_a =" & cmbNroLegajo.SelectedValue & ", cod_mat ='" & cmbCodMat.SelectedValue & "',cod_turno = '" & cmbCodTurno.SelectedValue & "'," & "año ='" & txtAño.Text.Trim & "', nota =" & txtNota.Text.Trim & ", fecha_inscripcion = '" & dtpFechaInscripcion.Value & "'"
            CadenaSQL = CadenaSQL & "where nro_legajo_a =" & DGVExamenes.CurrentRow.Cells("nro_legajo_a").Value & " and cod_mat ='" & DGVExamenes.CurrentRow.Cells("cod_mat").Value & "' and cod_turno ='" & DGVExamenes.CurrentRow.Cells("cod_turno").Value & "'"

            Try
                Ejecutar(CadenaSQL)
                MessageBox.Show("¡Examen modificado con exito!", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbAlumno.SelectedIndex = 0
                cmbCodMat.SelectedIndex = 0
                cmbCodTurno.SelectedIndex = 0
                txtAño.Text = String.Empty
                txtNota.Text = String.Empty
                txtFiltrar.Text = String.Empty
                txtFiltrar.Enabled = True
                DGVExamenes.Enabled = True
                cmbAlumno.Enabled = False
                cmbCodMat.Enabled = False
                cmbCodTurno.Enabled = False
                txtAño.Enabled = False
                txtNota.Enabled = False
                dtpFechaInscripcion.Enabled = False
                dtpFechaInscripcion.Value = Today()
                btnModificar.Enabled = False
                CargarGrilla()

            Catch ex As Exception

                MessageBox.Show("Operacion fallida: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End Try

        End If

    End Sub

    Private Function Validar() As Boolean

        Dim Num1, Num2 As Integer
        Dim TodoOk As Boolean

        TodoOk = False

        If txtAño.Text <> String.Empty Then
            If txtAño.Text >= 2000 Then
                If txtAño.Text <= Year(Today) Then
                    If Integer.TryParse(txtAño.Text, Num1) Then
                        If txtNota.Text <> String.Empty Then
                            If txtNota.Text <= 10 And txtNota.Text >= 1 Then
                                If Integer.TryParse(txtNota.Text, Num2) Then
                                    TodoOk = True
                                Else
                                    MessageBox.Show("La nota debe ser numerica y no contener mas de dos caracteres", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                            Else
                                MessageBox.Show("La nota debe ser menor o igual a 10", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If

                        Else
                            MessageBox.Show("Debe completar el campo Nota", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Else
                        MessageBox.Show("El año debe ser numero y no contener mas de cuatro caracteres", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("El año no debe ser mayor al corriente", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("El año no puede ser menor a 2000", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Else
            MessageBox.Show("Debe completar el campo Año", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Return TodoOk

    End Function


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Dim preg = MessageBox.Show("¿Seguro desea salir?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If preg = DialogResult.Yes Then

            Me.Close()

        End If
    End Sub

    Private Sub txtFiltrar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltrar.KeyPress
        CargarGrilla()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click

        cmbCodTurno.Enabled = True
        txtAño.Enabled = True
        txtNota.Enabled = True
        dtpFechaInscripcion.Enabled = True
        DGVExamenes.Enabled = False
        txtFiltrar.Enabled = False
        btnModificar.Enabled = True
        cmbNroLegajo.Enabled = False

    End Sub

End Class
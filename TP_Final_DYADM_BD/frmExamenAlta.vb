Public Class frmExamenAlta
    Private Sub frmExamenAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()

        Dim CadenaSQL As String
        Dim Tabla As DataTable

        CadenaSQL = "select * from Alumnos order by ape_nomb asc"
        Tabla = New DataTable
        Recuperar(CadenaSQL, Tabla)

        cmbAlumno.DataSource = Tabla
        cmbAlumno.DisplayMember = "ape_nomb"
        cmbAlumno.ValueMember = "nro_legajo_a"
        cmbAlumno.DropDownStyle = ComboBoxStyle.DropDownList
        cmbAlumno.SelectedIndex = 0


        CadenaSQL = "select * from Materias order by cod_materia asc"
        Tabla = New DataTable
        Recuperar(CadenaSQL, Tabla)

        cmbCodMat.DataSource = Tabla
        cmbCodMat.DisplayMember = "desc_mat"
        cmbCodMat.ValueMember = "cod_materia"
        cmbCodMat.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCodMat.SelectedIndex = 0


        CadenaSQL = "select * from Turnos order by cod_turno asc"
        Tabla = New DataTable
        Recuperar(CadenaSQL, Tabla)

        cmbCodTurno.DataSource = Tabla
        cmbCodTurno.DisplayMember = "desc_turno"
        cmbCodTurno.ValueMember = "cod_turno"
        cmbCodTurno.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCodTurno.SelectedIndex = 0

        dtpFechaInscripcion.Format = DateTimePickerFormat.Short

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

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim CadenaSQL As String

        If Validar() Then

            CadenaSQL = "INSERT into Examenes (nro_legajo_a, cod_mat, cod_turno, año, nota, fecha_inscripcion)"
            CadenaSQL = CadenaSQL & "VALUES (" & cmbAlumno.SelectedValue & ",'" & cmbCodMat.SelectedValue & "','" & cmbCodTurno.SelectedValue
            CadenaSQL = CadenaSQL & "','" & txtAño.Text.Trim & "','" & txtNota.Text.Trim & "','" & dtpFechaInscripcion.Value.ToShortDateString & "')"

            Try
                Ejecutar(CadenaSQL)
                MessageBox.Show("¡Examen registrado con exito!", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbAlumno.SelectedIndex = 0
                cmbCodMat.SelectedIndex = 0
                cmbCodTurno.SelectedIndex = 0
                txtAño.Text = String.Empty
                txtNota.Text = String.Empty


            Catch ex As Exception
                MessageBox.Show("Operacion fallida: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Dim preg = MessageBox.Show("¿Seguro desea salir?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If preg = DialogResult.Yes Then

            Me.Close()

        End If

    End Sub
End Class
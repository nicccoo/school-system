Public Class frmMatAlta
    Private Sub frmMatAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strCadenaSQL, strCodMateria As String
        Dim dttTabla As New DataTable
        Dim intMateria As Integer
        Me.CenterToScreen()

        strCadenaSQL = "select * from Profesores order by ape_nomb"
        Recuperar(strCadenaSQL, dttTabla)
        cmbProfesor.DataSource = dttTabla
        cmbProfesor.DisplayMember = "ape_nomb"
        cmbProfesor.ValueMember = "nro_legajo_p"

        strCadenaSQL = "SELECT right(cod_materia,3) as 'cod_materia' FROM Materias WHERE cod_materia= (SELECT MAX(cod_materia) from Materias)"
        dttTabla = New DataTable
        Recuperar(strCadenaSQL, dttTabla)
        intMateria = CInt(dttTabla.Rows(0).Item("cod_materia")) + 1
        Select Case intMateria
            Case Is < 100
                strCodMateria = "MA0" & intMateria
            Case Is >= 100
                strCodMateria = "MA" & intMateria
        End Select

        txtCodMateria.Text = strCodMateria

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim strCadenaSQL, strCodMateria As String
        Dim dttTabla As New DataTable
        Dim intMateria As Integer
        If ValidarMateria() Then
            If MsgBox("Los datos ingresados son: " + vbNewLine + "Materia: " + txtDescMateria.Text + vbNewLine + "Carrera: " + txtCarrera.Text + vbNewLine + "Profesor: " + cmbProfesor.Text + vbNewLine + "¿Los datos son correctos?", vbYesNo) = vbYes Then
                Alta()
                strCadenaSQL = "SELECT right(cod_materia,3) as 'cod_materia' FROM Materias WHERE cod_materia= (SELECT MAX(cod_materia) from Materias)"
                dttTabla = New DataTable
                Recuperar(strCadenaSQL, dttTabla)
                intMateria = CInt(dttTabla.Rows(0).Item("cod_materia")) + 1
                Select Case intMateria
                    Case Is < 100
                        strCodMateria = "MA0" & intMateria
                    Case Is >= 100
                        strCodMateria = "MA" & intMateria
                End Select
                txtCodMateria.Text = strCodMateria
            Else
                txtDescMateria.Focus()
            End If
        End If
    End Sub


    Private Sub Alta()
        Dim strCadenaSQL As String
        Try
            strCadenaSQL = "insert into Materias (cod_materia,desc_mat,desc_carrera,nro_legajo_p) values('" & txtCodMateria.Text & "','" & txtDescMateria.Text & "','" & txtCarrera.Text & "'," & cmbProfesor.SelectedValue & ")"
            Ejecutar(strCadenaSQL)
            MessageBox.Show("Materia cargada", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error durante el proceso de borrado " & Environment.NewLine & "Error: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function ValidarMateria() As Boolean
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
End Class
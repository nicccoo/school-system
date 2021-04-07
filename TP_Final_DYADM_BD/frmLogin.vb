Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmAluAlta.Dispose()
        frmAluBaja.Dispose()
        frmAluMod.Dispose()
        frmMatAlta.Dispose()
        'frmMatBaja.Dispose()
        frmMatBajaMod.Dispose()
        frmProfAlta.Dispose()
        frmProfBaja.Dispose()
        frmExamenAlta.Dispose()
        frmListadoExamenes.Dispose()
        frmModificarExamen.Dispose()
        frmTotAluInsc.Dispose()
        frmTotalAprobados.Dispose()
        frmAluInscMat.Dispose()
        frmDatTurnos.Dispose()
        frmCambiarPass.Dispose()

        Me.CenterToScreen()

        cmbUsuarioTipo.DropDownStyle = ComboBoxStyle.DropDownList
        cmbUsuarioTipo.SelectedIndex = 0
    End Sub

    Private Sub btnMostrarContrasenia_MouseDown(sender As Object, e As MouseEventArgs) Handles btnMostrarContrasenia.MouseDown
        txtContrasenia.PasswordChar = ""
    End Sub

    Private Sub btnMostrarContrasenia_MouseUp(sender As Object, e As MouseEventArgs) Handles btnMostrarContrasenia.MouseUp
        txtContrasenia.PasswordChar = "*"
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Ingresar()
    End Sub

    Private Sub txtContrasenia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContrasenia.KeyPress

        If Microsoft.VisualBasic.Val(e.KeyChar) = CInt(Keys.Enter) Then
            Ingresar()
        End If

    End Sub

    Private Sub Ingresar()

        Dim cadenaSQL As String
        Dim tabla As DataTable
        Dim HassPass As String

        'en la base de datos, poner un campo Tipo_Usuario (Profesor y Administrador con su 
        '"Acceso Log" para mostrar distintos menúes según usuario. Por hora solucionado 
        'con un combo box.


        'por ahora lo dejo para no tener que ingresar las contraseñas cada vez que pruebo algo.
        Select Case cmbUsuarioTipo.SelectedIndex
            Case 0 'Alumno
                cadenaSQL = "select * from Alumnos where nro_legajo_a = " & txtUsuario.Text.Trim
                tabla = New DataTable
                Recuperar(cadenaSQL, tabla)
                If tabla.Rows.Count = 1 Then
                    HassPass = GenerarHash256(txtContrasenia.Text)
                    If HassPass = tabla.Rows(0)("contrasenia").ToString() Then
                        Legajo = txtUsuario.Text
                        AccesoLog = "Alumno"
                        Me.Dispose()
                        frmPrincipal.Show()
                    End If
                End If
            Case 1 'Profesor o Admin
                cadenaSQL = "select p.*, acc.desc_Acceso from Profesores p, Tipo_Acceso acc where p.cod_Acceso=acc.cod_Acceso and nro_legajo_p = " & txtUsuario.Text.Trim
                tabla = New DataTable
                Recuperar(cadenaSQL, tabla)
                If tabla.Rows.Count = 1 Then
                    HassPass = GenerarHash256(txtContrasenia.Text)
                    If HassPass = tabla.Rows(0)("contrasenia").ToString() Then
                        Legajo = txtUsuario.Text
                        'MsgBox("|" & tabla.Rows(0)("desc_acceso") & "|")
                        If tabla.Rows(0)("desc_acceso").ToString.Trim() = "Administrador" Then
                            AccesoLog = "Administrador"
                        Else
                            AccesoLog = "Profesor"
                        End If
                        Me.Dispose()
                        frmPrincipal.Show()
                    Else
                        MsgBox("Número de legajo, contraseña o rol incorrectos, intente nuevamente", vbOKOnly + vbCritical)
                        txtUsuario.Focus()
                    End If
                End If
        End Select
    End Sub

End Class

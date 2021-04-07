Public Class frmCambiarPass
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim strCadenaSQL As String

        If txtNuevaCont.Text = txtNuevaContRep.Text Then
            Select Case AccesoLog
                Case "Alumno"
                    strCadenaSQL = "update alumnos set contrasenia = '" & GenerarHash256(txtNuevaCont.Text.Trim) & "' where nro_legajo_a = " & Legajo
                Case "Profesor", "Administrador"
                    strCadenaSQL = "update profesores set contrasenia = '" & GenerarHash256(txtNuevaCont.Text.Trim) & "' where nro_legajo_p = " & Legajo
            End Select
            Try
                Ejecutar(strCadenaSQL)
                MessageBox.Show("Contraseña modificada correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Ocurrió un error durante el proceso de cambio de contraseña " & Environment.NewLine & "Error: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MsgBox("Las contraseñas no coinciden, por favor repita", vbOKOnly + vbInformation, "")
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        frmPrincipal.Show()
        Me.Dispose()
    End Sub

    Private Sub frmCambiarPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class
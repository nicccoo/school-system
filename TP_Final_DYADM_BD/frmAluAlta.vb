Public Class frmAluAlta
    Private Sub frmAluAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim cadenaSQL As String
        Dim tabla As DataTable
        tabla = New DataTable

        'CALCULAR NUMERO DE LEGAJO
        CalcularLegajo()

        'CARGAR COMBOBOX DE TIPO DE DOCUMENTO
        cadenaSQL = "select * from Tipo_Doc"
        tabla = New DataTable

        Recuperar(cadenaSQL, tabla)
        cmbTipoDoc.DataSource = tabla
        cmbTipoDoc.ValueMember = "cod_doc"
        cmbTipoDoc.DisplayMember = "desc_doc"
        cmbTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTipoDoc.SelectedIndex = 0

        'CARGAR COMBOBOX DE ESTADO CIVIL
        cmbEstCivil.Items.Add("SOLTERO/A")
        cmbEstCivil.Items.Add("CASADO/A")
        cmbEstCivil.Items.Add("DIVORCIADO/A")
        cmbEstCivil.Items.Add("VIUDO/A")

        cmbEstCivil.DropDownStyle = ComboBoxStyle.DropDownList
        cmbEstCivil.SelectedIndex = 0

        'SELECCION DE SEXO POR DEFECTO
        rbMasculino.Checked = True

        'RESTRICCIONES EN TXT
        txtNroLegajo.Enabled = False
        txtApellido.MaxLength = 15
        txtNombre.MaxLength = 15
        txtNumDoc.MaxLength = 8
        txtDireccion.MaxLength = 50
        txtEmail.MaxLength = 30
        txtTelefono.MaxLength = 13
        dtpFechaNac.MaxDate = Date.Today
        txtContrasenia.UseSystemPasswordChar = True
        txtContrasenia2.UseSystemPasswordChar = True


    End Sub

    Private Function Validar() As Boolean
        Dim todoOk As Boolean

        todoOk = False

        If txtApellido.Text.Trim <> String.Empty Then
            If txtNombre.Text.Trim <> String.Empty Then
                If txtNumDoc.Text.Trim <> String.Empty Then
                    If txtDireccion.Text.Trim <> String.Empty Then
                        If txtEmail.Text.Trim <> String.Empty Then
                            If txtTelefono.Text.Trim <> String.Empty Then
                                If txtContrasenia.Text.Trim <> String.Empty Then
                                    If txtContrasenia2.Text.Trim <> String.Empty Then
                                        If txtContrasenia.Text.Trim = txtContrasenia2.Text.Trim Then
                                            todoOk = True
                                        Else
                                            MessageBox.Show("La contraseña ingresada con coincide con la verificacion, por favor, vuelve a ingresarla", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                            txtContrasenia.Text = String.Empty
                                            txtContrasenia2.Text = String.Empty
                                        End If
                                    Else
                                        MessageBox.Show("Por favor, ingrese la contraseña de verificacion", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    End If
                                Else
                                    MessageBox.Show("Por favor, ingrese la contraseña", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            Else
                                MessageBox.Show("Por favor, ingrese el numero de telefono", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        Else
                            MessageBox.Show("Por favor, ingrese el E-mail", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("Por favor, ingrese la Direccion", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Por favor, ingrese el Numero de Documento", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Por favor, ingrese el Nombre", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Por favor, ingrese el Apellido", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return todoOk
    End Function

    Private Sub SoloLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub
    Private Sub SoloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub txtNumDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumDoc.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        Dim pregunta As DialogResult

        pregunta = MessageBox.Show("Desea dar de alta a este Alumno/a?", "Atencion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

        If (pregunta = DialogResult.Yes) Then
            If Validar() Then
                Dim cadenaSQL As String
                Dim strFecha As String

                strFecha = FormatoFechaYMD(dtpFechaNac.Value)

                'CADENA PARA INGRESAR UN NUEVO REGISTRO
                cadenaSQL = "INSERT INTO Alumnos (nro_legajo_a,ape_nomb,nro_doc,direccion,email,telefono,cod_doc,sexo,fec_nac,est_civil,cod_acceso,contrasenia) "
                cadenaSQL = cadenaSQL & "VALUES (" & txtNroLegajo.Text.Trim & ","
                cadenaSQL = cadenaSQL & "'" & txtApellido.Text.Trim & " " & txtNombre.Text.Trim & "',"
                cadenaSQL = cadenaSQL & txtNumDoc.Text.Trim & ","
                cadenaSQL = cadenaSQL & "'" & txtDireccion.Text.Trim & "',"
                cadenaSQL = cadenaSQL & "'" & txtEmail.Text.Trim & "',"
                cadenaSQL = cadenaSQL & "'" & txtTelefono.Text.Trim & "',"
                cadenaSQL = cadenaSQL & "'" & cmbTipoDoc.SelectedValue & "',"
                If rbMasculino.Checked Then
                    cadenaSQL = cadenaSQL & "'M',"
                Else
                    cadenaSQL = cadenaSQL & "'F',"
                End If
                cadenaSQL = cadenaSQL & "'" & strFecha & "',"
                cadenaSQL = cadenaSQL & "'" & cmbEstCivil.Text & "',"
                cadenaSQL = cadenaSQL & "'TA002',"
                cadenaSQL = cadenaSQL & "'" & GenerarHash256(txtContrasenia.Text) & "')"

                'EN CASO DE QUE LA CADENA SQL ESTE MAL
                Try
                    Ejecutar(cadenaSQL)
                    MessageBox.Show("Se ha registrado un nuevo Alumno/a", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception
                    MessageBox.Show("La operacion fallida: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                CalcularLegajo()
                txtApellido.Text = String.Empty
                txtNombre.Text = String.Empty
                txtNumDoc.Text = String.Empty
                txtDireccion.Text = String.Empty
                txtEmail.Text = String.Empty
                txtTelefono.Text = String.Empty
                dtpFechaNac.Value = DateTime.Today
                txtContrasenia.Text = String.Empty
                txtContrasenia2.Text = String.Empty

            Else

            End If
        End If

    End Sub
    Private Sub CalcularLegajo()
        Dim cadenaSQL As String
        Dim tabla As DataTable
        tabla = New DataTable

        'CALCULAR NUMERO DE LEGAJO
        cadenaSQL = "select * from Alumnos order by nro_legajo_a asc"
        Dim legajo As Integer

        Recuperar(cadenaSQL, tabla)
        legajo = tabla.Rows.Count + 1
        txtNroLegajo.Text = legajo

    End Sub
End Class
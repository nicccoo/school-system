Public Class frmProfAlta

    Dim strCodTitulo As String

    Private Sub frmProfAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cadenaSQL As String
        Dim table As DataTable
        Dim legajo As Integer
        Me.CenterToScreen()
        rbFemenino.Checked = True

        dtpFechaNac.MaxDate = DateTime.Today
        dtpFechaNac.Format = DateTimePickerFormat.Short

        cadenaSQL = "select * from Tipo_Doc order by cod_doc asc"
        table = New DataTable
        Recuperar(cadenaSQL, table)
        cmbTipoDoc.DataSource = table
        cmbTipoDoc.DisplayMember = "desc_doc"
        cmbTipoDoc.ValueMember = "cod_doc"
        cmbTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTipoDoc.SelectedIndex = 0

        cadenaSQL = "select * from TITULOS order by COD_TITULOS asc"
        table = New DataTable
        Recuperar(cadenaSQL, table)
        cmbTitulo.DataSource = table
        cmbTitulo.DisplayMember = "DESC_TITULO"
        cmbTitulo.ValueMember = "COD_TITULOS"
        cmbTitulo.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTitulo.SelectedIndex = 0

        cadenaSQL = "select * from Tipo_Acceso order by desc_Acceso asc"
        table = New DataTable
        Recuperar(cadenaSQL, table)
        cmbCodAcceso.DataSource = table
        cmbCodAcceso.DisplayMember = "desc_Acceso"
        cmbCodAcceso.ValueMember = "cod_Acceso"
        cmbCodAcceso.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCodAcceso.SelectedIndex = 0

        cmbEstCivil.Items.Add("SOLTERO/A")
        cmbEstCivil.Items.Add("CASADO/A")
        cmbEstCivil.Items.Add("DIVORCIADO/A")
        cmbEstCivil.Items.Add("VIUDO/A")
        cmbEstCivil.SelectedIndex = 0
        cmbEstCivil.DropDownStyle = ComboBoxStyle.DropDownList

        cadenaSQL = "select max(nro_legajo_p) as 'ult_legajo' from Profesores"
        table = New DataTable
        Recuperar(cadenaSQL, table)
        legajo = table.Rows(0)("ult_legajo") + 1
        txtNroLegajo.Text = legajo.ToString()

    End Sub

    Private Sub btnRegistrarProfesor_Click(sender As Object, e As EventArgs) Handles btnRegistrarProfesor.Click

        If Validar() = 1 Then

            Dim cadenaSQL As String
            Dim chSexo As Char
            Dim strFecha As String
            Dim table As DataTable
            Dim legajo As Integer

            If rbFemenino.Checked Then
                chSexo = "F"
            Else
                chSexo = "M"
            End If

            strFecha = FormatoFechaYMD(dtpFechaNac.Value)

            cadenaSQL = "insert into Profesores values (" & txtNroLegajo.Text.Trim & ", '" & txtApyNom.Text.Trim & "', " & txtNroDoc.Text.Trim & ", (select cod_doc from Tipo_Doc where desc_doc = '" & cmbTipoDoc.Text & "'), '" & txtDireccion.Text.Trim & "', '" & txtEmail.Text.Trim & "', '" & txtTelefono.Text.Trim & "', '" & chSexo & "', " & strFecha & ", '" & cmbEstCivil.Text & "', (select COD_TITULOS from TITULOS where DESC_TITULO = '" & cmbTitulo.Text & "'), '" & cmbCodAcceso.SelectedValue & "', '" & GenerarHash256(txtPass.Text.Trim) & "')"

            Try
                Ejecutar(cadenaSQL)
                MessageBox.Show("¡Profesor guardado con éxito!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("La operación fallida: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            cadenaSQL = "select max(nro_legajo_p) as 'ult_legajo' from Profesores"
            table = New DataTable
            Recuperar(cadenaSQL, table)
            legajo = table.Rows(0)("ult_legajo") + 1

            txtNroLegajo.Text = legajo.ToString()
            txtApyNom.Text = String.Empty
            cmbTipoDoc.SelectedIndex = 0
            txtNroDoc.Text = String.Empty
            txtDireccion.Text = String.Empty
            txtEmail.Text = String.Empty
            txtTelefono.Text = String.Empty
            rbFemenino.Checked = True
            dtpFechaNac.Value = Today
            cmbEstCivil.SelectedIndex = 0
            cmbTitulo.SelectedIndex = 0
            cmbCodAcceso.SelectedIndex = 0
            txtPass.Text = String.Empty

        End If
    End Sub

    Private Function Validar()

        If txtApyNom.Text = String.Empty Then
            MessageBox.Show("El campo APELLIDO Y NOMBRE está vacío", "¡Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End If

        If txtNroDoc.Text = String.Empty Then
            MessageBox.Show("El campo NRO. DOCUMENTO está vacio", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End If

        If txtDireccion.Text = String.Empty Then
            MessageBox.Show("El campo DIRECCION está vacio", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End If

        If txtEmail.Text = String.Empty Then
            MessageBox.Show("El campo EMAIL está vacio", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End If

        If txtTelefono.Text = String.Empty Then
            MessageBox.Show("El campo TELEFONO esta vacio", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End If

        If txtPass.Text = String.Empty Then
            MessageBox.Show("El campo CONTRASEÑA está vacio", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End If

        Return 1

    End Function

    
End Class
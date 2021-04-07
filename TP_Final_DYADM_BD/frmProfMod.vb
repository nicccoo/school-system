Public Class frmProfMod
    Private Sub frmProfMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cadenaSQL As String
        Dim table As DataTable
        Dim cadenaSQL2 As String
        Dim table2 As DataTable
        Dim cadenaSQL3 As String
        Dim table3 As DataTable
        Me.CenterToScreen()
        txtNroLegajo.Enabled = False
        txtApyNom.Enabled = False
        txtTipoDoc.Enabled = False
        txtNroDoc.Enabled = False
        rbFemenino.Enabled = False
        rbMasculino.Enabled = False
        txtFechaNac.Enabled = False

        cadenaSQL = "select pro.*, doc.desc_doc, tit.DESC_TITULO from Profesores pro, Tipo_Doc doc, TITULOS tit where pro.cod_doc = doc.cod_doc and pro.cod_titulo = tit.COD_TITULOS"
        table = New DataTable
        Recuperar(cadenaSQL, table)
        cmbFiltroProf.DataSource = table
        cmbFiltroProf.DisplayMember = "ape_nomb"
        cmbFiltroProf.ValueMember = "ape_nomb"
        cmbFiltroProf.DropDownStyle = ComboBoxStyle.DropDownList
        cmbFiltroProf.SelectedIndex = 0

        cadenaSQL2 = "select * from TITULOS order by COD_TITULOS asc"
        table2 = New DataTable
        Recuperar(cadenaSQL2, table2)
        cmbTitulo.DataSource = table2
        cmbTitulo.DisplayMember = "DESC_TITULO"
        cmbTitulo.ValueMember = "COD_TITULOS"
        cmbTitulo.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTitulo.SelectedIndex = 0

        cmbEstCivil.Items.Add("SOLTERO/A")
        cmbEstCivil.Items.Add("CASADO/A")
        'cmbEstCivil.Items.Add("DIVORCIADO/A")
        cmbEstCivil.Items.Add("VIUDO/A")
        cmbEstCivil.DropDownStyle = ComboBoxStyle.DropDownList
        cmbEstCivil.SelectedIndex = 0

        cadenaSQL3 = "select * from Tipo_Acceso order by desc_Acceso asc"
        table3 = New DataTable
        Recuperar(cadenaSQL3, table3)
        cmbCodAcceso.DataSource = table3
        cmbCodAcceso.DisplayMember = "desc_Acceso"
        cmbCodAcceso.ValueMember = "cod_Acceso"
        cmbCodAcceso.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCodAcceso.SelectedIndex = 0

        txtNroLegajo.Text = table.Rows(cmbFiltroProf.SelectedIndex)("nro_legajo_p").ToString()
        txtApyNom.Text = table.Rows(cmbFiltroProf.SelectedIndex)("ape_nomb").ToString()
        txtTipoDoc.Text = table.Rows(cmbFiltroProf.SelectedIndex)("desc_doc").ToString()
        txtNroDoc.Text = table.Rows(cmbFiltroProf.SelectedIndex)("nro_doc").ToString()
        txtDireccion.Text = table.Rows(cmbFiltroProf.SelectedIndex)("direccion").ToString().Trim
        txtEmail.Text = table.Rows(cmbFiltroProf.SelectedIndex)("email").ToString().Trim
        txtTelefono.Text = table.Rows(cmbFiltroProf.SelectedIndex)("telefono").ToString().Trim
        If table.Rows(cmbFiltroProf.SelectedIndex)("sexo").ToString() = "F" Then
            rbFemenino.Checked = True
        Else
            rbMasculino.Checked = True
        End If
        txtFechaNac.Text = table.Rows(cmbFiltroProf.SelectedIndex)("fec_nac").ToString()
        cmbEstCivil.Text = table.Rows(cmbFiltroProf.SelectedIndex)("est_civil").ToString()
        cmbTitulo.Text = table.Rows(cmbFiltroProf.SelectedIndex)("DESC_TITULO").ToString()
        cmbCodAcceso.Text = table.Rows(cmbFiltroProf.SelectedIndex)("cod_Acceso").ToString().Trim
        'txtPass.Text = table.Rows(cmbFiltroProf.SelectedIndex)("contrasenia").ToString().Trim

    End Sub

    Private Sub cmbFiltroProf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltroProf.SelectedIndexChanged

        Dim cadenaSQL As String
        Dim table As DataTable

        cadenaSQL = "select pro.*, doc.desc_doc, tit.DESC_TITULO from Profesores pro, Tipo_Doc doc, TITULOS tit where pro.cod_doc = doc.cod_doc and pro.cod_titulo = tit.COD_TITULOS"
        table = New DataTable
        Recuperar(cadenaSQL, table)

        txtNroLegajo.Text = table.Rows(cmbFiltroProf.SelectedIndex)("nro_legajo_p").ToString()
        txtApyNom.Text = table.Rows(cmbFiltroProf.SelectedIndex)("ape_nomb").ToString()
        txtTipoDoc.Text = table.Rows(cmbFiltroProf.SelectedIndex)("desc_doc").ToString()
        txtNroDoc.Text = table.Rows(cmbFiltroProf.SelectedIndex)("nro_doc").ToString()
        txtDireccion.Text = table.Rows(cmbFiltroProf.SelectedIndex)("direccion").ToString().Trim
        txtEmail.Text = table.Rows(cmbFiltroProf.SelectedIndex)("email").ToString().Trim
        txtTelefono.Text = table.Rows(cmbFiltroProf.SelectedIndex)("telefono").ToString().Trim
        If table.Rows(cmbFiltroProf.SelectedIndex)("sexo").ToString() = "F" Then
            rbFemenino.Checked = True
        Else
            rbMasculino.Checked = True
        End If
        txtFechaNac.Text = table.Rows(cmbFiltroProf.SelectedIndex)("fec_nac").ToString()
        cmbEstCivil.Text = table.Rows(cmbFiltroProf.SelectedIndex)("est_civil").ToString()
        cmbTitulo.Text = table.Rows(cmbFiltroProf.SelectedIndex)("DESC_TITULO").ToString()
        cmbCodAcceso.Text = table.Rows(cmbFiltroProf.SelectedIndex)("cod_Acceso").ToString().Trim
        'txtPass.Text = table.Rows(cmbFiltroProf.SelectedIndex)("contrasenia").ToString().Trim

    End Sub

    Private Sub btnRegistrarProfesor_Click(sender As Object, e As EventArgs) Handles btnRegistrarProfesor.Click

        Dim cadenaSQL As String

        If Validar() = 1 Then

            cadenaSQL = "Update Profesores set direccion = '" & txtDireccion.Text & "', email = '" & txtEmail.Text & "', telefono = '" & txtTelefono.Text & "', est_civil = '" & cmbEstCivil.SelectedItem & "', cod_titulo = '" & cmbTitulo.SelectedValue & "', cod_Acceso = '" & cmbCodAcceso.SelectedValue
            If txtPass.Text.Trim = String.Empty Then
                cadenaSQL = cadenaSQL & "' where nro_legajo_p = " & txtNroLegajo.Text
            Else
                cadenaSQL = cadenaSQL & "', contrasenia = '" & GenerarHash256(txtPass.Text.Trim) & "' where nro_legajo_p = " & txtNroLegajo.Text
            End If


            Try
                Ejecutar(cadenaSQL)
                MessageBox.Show("¡Cambios efectuados con éxito!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)

                cmbFiltroProf.SelectedIndex = 0

            Catch ex As Exception
                MessageBox.Show("La operación fallida: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Private Function Validar()

        If txtDireccion.Text = String.Empty Then
            MessageBox.Show("El campo DIRECCION está vacío", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End If

        If txtEmail.Text = String.Empty Then
            MessageBox.Show("El campo EMAIL está vacío", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End If

        If txtTelefono.Text = String.Empty Then
            MessageBox.Show("El campo TELEFONO está vacío", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End If

        'If txtPass.Text = String.Empty Then
        '    MessageBox.Show("El campo CONTRASEÑA está vacío", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return 0
        'End If

        Return 1

    End Function

End Class
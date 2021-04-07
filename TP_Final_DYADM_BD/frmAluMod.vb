Public Class frmAluMod
    Private Sub txtBuscarNro_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarNro.TextChanged
        cargarGrilla()

    End Sub
    Private Sub cargarGrilla()
        Dim cadenaSQL As String
        Dim tabla As DataTable

        tabla = New DataTable
        'CONSULTA DEPENDIENDO SI HAY ALGO ESCRITO EN EL TXT DE BUSQUEDA
        If txtBuscarNro.Text.Trim = String.Empty Then
            cadenaSQL = "SELECT Alumnos.*, desc_doc FROM Alumnos INNER JOIN Tipo_Doc ON Alumnos.cod_doc = Tipo_doc.cod_doc ORDER BY Alumnos.nro_legajo_a"
        Else
            cadenaSQL = "SELECT Alumnos.*, desc_doc FROM Alumnos INNER JOIN Tipo_Doc ON Alumnos.cod_doc = Tipo_doc.cod_doc  WHERE Alumnos.nro_doc LIKE '" & txtBuscarNro.Text.Trim & "%' ORDER BY Alumnos.nro_legajo_a"
        End If

        'CONSULTA DE BUSQUEDA
        Recuperar(cadenaSQL, tabla)
        'CONFIGUARCION DE DGV
        DGVModAlu.DataSource = tabla
        'OCULTAR COLUMNAS DE DGV
        DGVModAlu.Columns("direccion").Visible = False
        DGVModAlu.Columns("email").Visible = False
        DGVModAlu.Columns("telefono").Visible = False
        DGVModAlu.Columns("cod_doc").Visible = False
        DGVModAlu.Columns("sexo").Visible = False
        DGVModAlu.Columns("fec_nac").Visible = False
        DGVModAlu.Columns("est_civil").Visible = False
        DGVModAlu.Columns("cod_acceso").Visible = False
        DGVModAlu.Columns("contrasenia").Visible = False
        'CAMBIAR TITULO DE COLUMNAS DE DGV
        DGVModAlu.Columns("nro_legajo_a").HeaderText = "Nro. de Legajo"
        DGVModAlu.Columns("ape_nomb").HeaderText = "Apellido y Nombre"
        DGVModAlu.Columns("desc_doc").HeaderText = "Tipo de Doc."
        DGVModAlu.Columns("nro_doc").HeaderText = "Nro. de Doc."
        'CONFIGURACION DGV
        DGVModAlu.ReadOnly = True
        DGVModAlu.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub frmAluMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        cargarGrilla()
        'CARGAR COMBOBOX DE ESTADO CIVIL
        cmbEstCivil.Items.Add("SOLTERO/A")
        cmbEstCivil.Items.Add("CASADO/A")
        cmbEstCivil.Items.Add("VIUDO/A")

        cmbEstCivil.DropDownStyle = ComboBoxStyle.DropDownList
        cmbEstCivil.SelectedIndex = 0
        cmbEstCivil.Enabled = False

        'INHABILITAR LOS TXT
        txtApelNom.Enabled = False
        txtTipoDoc.Enabled = False
        txtNumDoc.Enabled = False
        txtDireccion.Enabled = False
        txtEmail.Enabled = False
        txtTelefono.Enabled = False
        txtsex.Enabled = False
        dtpFechaNac.Enabled = False
        txtContrasenia.Enabled = False
        txtContrasenia2.Enabled = False
        'PROPIEDADES TXT
        txtDireccion.MaxLength = 50
        txtEmail.MaxLength = 30
        txtTelefono.MaxLength = 13
        txtContrasenia.UseSystemPasswordChar = True
        txtContrasenia2.UseSystemPasswordChar = True

    End Sub

    Private Sub DGVModAlu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVModAlu.CellContentClick
        If Not DGVModAlu.CurrentRow Is Nothing Then
            txtApelNom.Text = DGVModAlu.CurrentRow.Cells("ape_nomb").Value
            txtTipoDoc.Text = DGVModAlu.CurrentRow.Cells("desc_doc").Value
            txtNumDoc.Text = DGVModAlu.CurrentRow.Cells("nro_doc").Value
            txtDireccion.Text = DGVModAlu.CurrentRow.Cells("direccion").Value
            txtDireccion.Enabled = True
            txtEmail.Text = DGVModAlu.CurrentRow.Cells("email").Value
            txtEmail.Enabled = True
            txtTelefono.Text = DGVModAlu.CurrentRow.Cells("telefono").Value
            txtTelefono.Enabled = True
            txtsex.Text = DGVModAlu.CurrentRow.Cells("sexo").Value
            dtpFechaNac.Value = DGVModAlu.CurrentRow.Cells("fec_nac").Value
            cmbEstCivil.Text = DGVModAlu.CurrentRow.Cells("est_civil").Value
            cmbEstCivil.Enabled = True
            txtContrasenia.Text = DGVModAlu.CurrentRow.Cells("contrasenia").Value
            txtContrasenia.Enabled = True
            txtContrasenia2.Text = DGVModAlu.CurrentRow.Cells("contrasenia").Value
            txtContrasenia2.Enabled = True

        End If

        'ME TIRA ERROR SI LA CELDA ESTA VACIA EN LA BASE DE DATOS
    End Sub

    Private Sub lblApellido_Click(sender As Object, e As EventArgs) Handles lblApellido.Click

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim pregunta As DialogResult

        pregunta = MessageBox.Show("Desea confirmar las modificacion?", "Atencion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

        If (pregunta = DialogResult.Yes) Then
            If Validar() Then
                Dim cadenaSQL As String

                cadenaSQL = "UPDATE Alumnos SET "
                cadenaSQL = cadenaSQL & "direccion = '" & txtDireccion.Text.Trim & "',"
                cadenaSQL = cadenaSQL & " email = '" & txtEmail.Text.Trim & "',"
                cadenaSQL = cadenaSQL & " telefono = '" & txtTelefono.Text.Trim & "',"
                cadenaSQL = cadenaSQL & " est_civil = '" & cmbEstCivil.Text.Trim & "',"
                cadenaSQL = cadenaSQL & " contrasenia = '" & GenerarHash256(txtContrasenia.Text) & "' "
                cadenaSQL = cadenaSQL & " WHERE nro_legajo_A = " & DGVModAlu.CurrentRow.Cells("nro_legajo_a").Value

                'EN CASO DE QUE LA CADENA SQL ESTE MAL
                Try
                    Ejecutar(cadenaSQL)
                    MessageBox.Show("Se ha modificado el Alumno/a", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtBuscarNro.Text = String.Empty
                    cargarGrilla()

                Catch ex As Exception
                    MessageBox.Show("La operacion fallida: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End If
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

    Private Function Validar() As Boolean
        Dim TodoOk As Boolean

        TodoOk = False
        'DIRECCION/TELEFONO/EMAIL/ESTADO CIVIL/CONTRASEÑAS
        If txtDireccion.Text.Trim <> String.Empty Then
            If txtTelefono.Text.Trim <> String.Empty Then
                If txtEmail.Text.Trim <> String.Empty Then
                    If txtContrasenia.Text.Trim <> String.Empty Then
                        If txtContrasenia2.Text.Trim <> String.Empty Then
                            If txtContrasenia.Text.Trim = txtContrasenia2.Text.Trim Then
                                TodoOk = True
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
                    MessageBox.Show("Por favor, ingrese el E-mail", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Por favor, ingrese el numero de telefono", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Por favor, ingrese la Direccion", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return TodoOk

    End Function

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        SoloNumeros(e)
    End Sub
End Class
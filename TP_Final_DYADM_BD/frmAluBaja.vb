Public Class frmAluBaja
    Private Sub frmAluBaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        cargarGrilla()

    End Sub

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
        DGVBajaAlu.DataSource = tabla
        'OCULTAR COLUMNAS DE DGV
        DGVBajaAlu.Columns("direccion").Visible = False
        DGVBajaAlu.Columns("email").Visible = False
        DGVBajaAlu.Columns("telefono").Visible = False
        DGVBajaAlu.Columns("cod_doc").Visible = False
        DGVBajaAlu.Columns("sexo").Visible = False
        DGVBajaAlu.Columns("fec_nac").Visible = False
        DGVBajaAlu.Columns("est_civil").Visible = False
        DGVBajaAlu.Columns("cod_acceso").Visible = False
        DGVBajaAlu.Columns("contrasenia").Visible = False
        'CAMBIAR TITULO DE COLUMNAS DE DGV
        DGVBajaAlu.Columns("nro_legajo_a").HeaderText = "Nro. de Legajo"
        DGVBajaAlu.Columns("ape_nomb").HeaderText = "Apellido y Nombre"
        DGVBajaAlu.Columns("desc_doc").HeaderText = "Tipo de Doc."
        DGVBajaAlu.Columns("nro_doc").HeaderText = "Nro. de Doc."
        'CONFIGURACION DGV
        DGVBajaAlu.ReadOnly = True
        DGVBajaAlu.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub DGVBajaAlu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVBajaAlu.CellContentClick
        If Not DGVBajaAlu.CurrentRow Is Nothing Then
            lblapenom.Text = DGVBajaAlu.CurrentRow.Cells("ape_nomb").Value
            lblTDoc.Text = DGVBajaAlu.CurrentRow.Cells("desc_doc").Value
            lblNDoc.Text = DGVBajaAlu.CurrentRow.Cells("nro_doc").Value
            lblDir.Text = DGVBajaAlu.CurrentRow.Cells("direccion").Value
            lblEm.Text = DGVBajaAlu.CurrentRow.Cells("email").Value
            lblTel.Text = DGVBajaAlu.CurrentRow.Cells("telefono").Value
            lblSex.Text = DGVBajaAlu.CurrentRow.Cells("sexo").Value
            lblFNac.Text = DGVBajaAlu.CurrentRow.Cells("fec_nac").Value
            lblECivil.Text = DGVBajaAlu.CurrentRow.Cells("est_civil").Value
        End If

        'ME TIRA ERROR SI LA CELDA ESTA VACIA EN LA BASE DE DATOS

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not DGVBajaAlu.CurrentRow Is Nothing Then
            Dim cadenaSQL As String
            Dim tabla As DataTable
            tabla = New DataTable

            cadenaSQL = "DELETE FROM Alumnos WHERE nro_legajo_A = " & DGVBajaAlu.CurrentRow.Cells("nro_legajo_a").Value

            Try
                Ejecutar(cadenaSQL)
                MessageBox.Show("Alumno eliminado con éxito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cargarGrilla()

            Catch ex As Exception
                MessageBox.Show("La operación fallida: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Debe seleccionar un Alumno en la tabla", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
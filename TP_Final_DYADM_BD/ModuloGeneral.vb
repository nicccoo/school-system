Imports System.Data.SqlClient
Module ModuloGeneral
    Public Const CadenaConexion As String = "Data Source=localhost\sqlexpress;Initial Catalog=Disenio_admin_BD;Integrated Security=True"
    Public Operacion As String
    Public AccesoLog As String
    Public Informe As String
    Public Legajo As String
    Public InformeSQL As String
    Public Sub Ejecutar(ByVal sql As String)
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        conexion = New SqlConnection()
        conexion.ConnectionString = CadenaConexion
        conexion.Open()
        comando = New SqlCommand()
        comando.Connection = conexion
        comando.CommandType = CommandType.Text
        comando.CommandText = sql
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub
    Public Sub Recuperar(ByVal sql As String, ByRef tabla As DataTable)
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        tabla = New DataTable
        conexion = New SqlConnection()
        conexion.ConnectionString = CadenaConexion
        conexion.Open()
        comando = New SqlCommand()
        comando.Connection = conexion
        comando.CommandType = CommandType.Text
        comando.CommandText = sql
        tabla.Load(comando.ExecuteReader)
        conexion.Close()
    End Sub

    Public Function GenerarHash256(cadena As String) As String
        Dim AlgoritmoHash As New System.Security.Cryptography.SHA256CryptoServiceProvider
        Dim InputBytes() As Byte
        Dim HashBytes() As Byte
        Dim Salida As String

        InputBytes = System.Text.Encoding.UTF8.GetBytes(cadena)
        HashBytes = AlgoritmoHash.ComputeHash(InputBytes)

        Salida = String.Empty

        For Each b In HashBytes
            Salida &= b.ToString("x2")
        Next
        Return Salida

    End Function

    Public Function FormatoFechaYMD(ByVal fecha As DateTime) As String

        Dim NuevaFecha As String

        NuevaFecha = fecha.Year.ToString & "/" & fecha.Month.ToString & "/" & fecha.Day.ToString

        Return NuevaFecha

    End Function
End Module

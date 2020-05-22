Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration


Public Class clsDatos

    Private conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("dbConexion").ConnectionString)




    Public Function ListaDatos(gasto, iva, periodo) As DataTable
        Dim cmd As SqlCommand = New SqlCommand("sp_test_prorrateo", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@gasto", gasto)
        cmd.Parameters.AddWithValue("@iva", iva)
        cmd.Parameters.AddWithValue("@periodo", periodo)

        Dim connection As New SqlConnection(conexion.ConnectionString)
        cmd.Connection = connection
        cmd.CommandType = CommandType.StoredProcedure

        Dim da As New SqlDataAdapter(cmd)
        da.SelectCommand.CommandTimeout = 300

        Dim dt As New DataTable()
        da.Fill(dt)
        conexion.Close()
        Return dt

    End Function
End Class

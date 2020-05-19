Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Prorrateo.Entidades



Public Class clsDatos

    Private conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("dbConexion").ConnectionString)


    Public Function ListaDatos() As DataTable
        Dim cmd As New SqlCommand("select * from tbl_Datos_Prorrateo", conexion)
        conexion.Open()
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        conexion.Close()
        Return dt
    End Function
End Class

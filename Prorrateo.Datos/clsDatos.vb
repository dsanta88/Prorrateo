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

    Public Function PeridosObtener() As DataTable
        Dim cmd As SqlCommand = New SqlCommand("sp_Periodos", conexion)
        cmd.CommandType = CommandType.StoredProcedure

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

    Public Function sp_documentos_contables() As DataSet

        Dim sqlConexion As New SqlConnection(conexion.ConnectionString)
        Dim sqlComando As SqlCommand = New SqlCommand
        Dim sqlAdaptador As SqlDataAdapter = New SqlDataAdapter
        Dim ds As New DataSet

        Try

            sqlComando.Connection = sqlConexion
            sqlComando.CommandType = CommandType.StoredProcedure
            sqlComando.CommandText = "sp_Docto_Contable"
            sqlAdaptador.SelectCommand = sqlComando

            sqlAdaptador.Fill(ds)

        Catch ex As Exception
            Throw ex
        Finally
            sqlComando.Parameters.Clear()
            sqlComando.Connection.Close()
        End Try

        Return ds

    End Function


    Public Function sp_movimientos_contables() As DataSet

        Dim sqlConexion As New SqlConnection(conexion.ConnectionString)
        Dim sqlComando As SqlCommand = New SqlCommand
        Dim sqlAdaptador As SqlDataAdapter = New SqlDataAdapter
        Dim ds As New DataSet

        Try

            sqlComando.Connection = sqlConexion
            sqlComando.CommandType = CommandType.StoredProcedure
            sqlComando.CommandText = "sp_Movto_Contable"
            sqlAdaptador.SelectCommand = sqlComando

            sqlAdaptador.Fill(ds)

        Catch ex As Exception
            Throw ex
        Finally
            sqlComando.Parameters.Clear()
            sqlComando.Connection.Close()
        End Try

        Return ds

    End Function
#Region "EQUIVALENCIAS"

    Public Function EquivalenciasCuentasObtener(id) As DataTable
        Dim cmd As SqlCommand = New SqlCommand("sp_equivalencia_cuenta_obtener", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Id", id)

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

    Public Function EquivalenciasCuentasInsert(auxiliar, contrapartida) As Boolean
        'Dim sqlConexion As New SqlConnection()
        Dim sqlComando As SqlCommand = New SqlCommand("sp_equivalencia_cuenta_insertar", conexion)
        Dim sqlAdaptador As SqlDataAdapter = New SqlDataAdapter
        Try
            'sqlComando.Connection = sqlConexion
            sqlComando.CommandType = CommandType.StoredProcedure
            sqlComando.Parameters.AddWithValue("@Auxiliar", auxiliar)
            sqlComando.Parameters.AddWithValue("@Contrapartida", contrapartida)
            sqlAdaptador.SelectCommand = sqlComando
            sqlComando.Connection.Open()
            sqlComando.ExecuteNonQuery()
        Catch ex As Exception
            'sp_guardar_log_eventos("", "", "", "", DateTime.Now, DateTime.Now, "", "", "", "", "", "", ex.Message, ex.Source, ex.StackTrace, False)
            Return False
        Finally
            sqlComando.Parameters.Clear()
            sqlComando.Connection.Close()
        End Try
        Return True
    End Function

    Public Function EquivalenciasCuentasEditar(id, auxiliar, contrapartida) As Boolean

        Dim sqlConexion As New SqlConnection()
        Dim sqlComando As SqlCommand = New SqlCommand("sp_equivalencia_cuenta_editar", conexion)
        Dim sqlAdaptador As SqlDataAdapter = New SqlDataAdapter
        Try
            sqlComando.Connection = sqlConexion
            sqlComando.CommandType = CommandType.StoredProcedure
            sqlComando.Parameters.AddWithValue("@Id", id)
            sqlComando.Parameters.AddWithValue("@Auxiliar", auxiliar)
            sqlComando.Parameters.AddWithValue("@Contrapartida", contrapartida)
            sqlAdaptador.SelectCommand = sqlComando
            sqlConexion.Open()
            sqlComando.ExecuteNonQuery()
        Catch ex As Exception
            'sp_guardar_log_eventos("", "", "", "", DateTime.Now, DateTime.Now, "", "", "", "", "", "", ex.Message, ex.Source, ex.StackTrace, False)
            Return False
        Finally
            sqlComando.Parameters.Clear()
            sqlComando.Connection.Close()
        End Try
        Return True
    End Function

    Public Function EquivalenciasCuentasEliminar(id) As Boolean

        Dim sqlConexion As New SqlConnection()
        Dim sqlComando As SqlCommand = New SqlCommand("sp_equivalencia_cuenta_eliminar", conexion)
        Dim sqlAdaptador As SqlDataAdapter = New SqlDataAdapter
        Try
            sqlComando.Connection = sqlConexion
            sqlComando.CommandType = CommandType.StoredProcedure
            sqlComando.Parameters.AddWithValue("@Id", id)
            sqlAdaptador.SelectCommand = sqlComando
            sqlConexion.Open()
            sqlComando.ExecuteNonQuery()
        Catch ex As Exception
            'sp_guardar_log_eventos("", "", "", "", DateTime.Now, DateTime.Now, "", "", "", "", "", "", ex.Message, ex.Source, ex.StackTrace, False)
            Return False
        Finally
            sqlComando.Parameters.Clear()
            sqlComando.Connection.Close()
        End Try
        Return True
    End Function
#End Region

End Class

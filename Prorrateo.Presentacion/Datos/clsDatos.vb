
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class clsDatos
    Private conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("dbConexion").ConnectionString)

    Public Function CargarDatos(gasto, iva, periodo) As DataTable

        Dim sqlConexion As New SqlConnection(conexion.ConnectionString)
        Dim sqlComando As SqlCommand = New SqlCommand
        Dim sqlAdaptador As SqlDataAdapter = New SqlDataAdapter
        Dim dt As New DataTable

        Try

            sqlComando.Connection = sqlConexion
            sqlComando.CommandType = CommandType.StoredProcedure
            sqlComando.CommandText = "sp_Cargar_Datos"
            sqlComando.Parameters.AddWithValue("@gasto", gasto)
            sqlComando.Parameters.AddWithValue("@iva", iva)
            sqlComando.Parameters.AddWithValue("@periodo", periodo)
            sqlAdaptador.SelectCommand = sqlComando

            sqlAdaptador.Fill(dt)

        Catch ex As Exception
            LogEventosInsertar("", "", "", "", DateTime.Now, DateTime.Now, "", "", "", "", "", "", ex.Message, ex.Source, ex.StackTrace, False)
            Throw ex
        Finally
            sqlComando.Parameters.Clear()
            sqlComando.Connection.Close()
        End Try

        Return dt
    End Function

    Public Function PeridosObtener() As DataTable

        Dim sqlConexion As New SqlConnection(conexion.ConnectionString)
        Dim sqlComando As SqlCommand = New SqlCommand
        Dim sqlAdaptador As SqlDataAdapter = New SqlDataAdapter
        Dim dt As New DataTable

        Try

            sqlComando.Connection = sqlConexion
            sqlComando.CommandType = CommandType.StoredProcedure
            sqlComando.CommandText = "sp_Periodos"
            sqlAdaptador.SelectCommand = sqlComando
            sqlAdaptador.Fill(dt)

        Catch ex As Exception
            Throw ex
        Finally
            sqlComando.Parameters.Clear()
            sqlComando.Connection.Close()
        End Try

        Return dt
    End Function

    Public Function sp_documentos_contables() As DataSet
        Try
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
                LogEventosInsertar("", "", "", "", DateTime.Now, DateTime.Now, "", "", "", "", "", "", ex.Message, ex.Source, ex.StackTrace, False)
                Throw ex
            Finally
                sqlComando.Parameters.Clear()
                sqlComando.Connection.Close()
            End Try

            Return ds
        Catch ex As Exception
            LogEventosInsertar("", "", "", "", DateTime.Now, DateTime.Now, "", "", "", "", "", "", ex.Message, ex.Source, ex.StackTrace, False)
            Throw ex
        End Try
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
            LogEventosInsertar("", "", "", "", DateTime.Now, DateTime.Now, "", "", "", "", "", "", ex.Message, ex.Source, ex.StackTrace, False)
            Throw ex
        Finally
            sqlComando.Parameters.Clear()
            sqlComando.Connection.Close()
        End Try

        Return ds

    End Function
#Region "EQUIVALENCIAS"

    Public Function EquivalenciasCuentasObtener(id) As DataTable
        Dim sqlConexion As New SqlConnection(conexion.ConnectionString)
        Dim sqlComando As SqlCommand = New SqlCommand
        Dim sqlAdaptador As SqlDataAdapter = New SqlDataAdapter
        Dim dt As New DataTable

        Try

            sqlComando.Connection = sqlConexion
            sqlComando.CommandType = CommandType.StoredProcedure
            sqlComando.CommandText = "sp_equivalencia_cuenta_obtener"
            sqlComando.Parameters.AddWithValue("@Id", id)
            sqlAdaptador.SelectCommand = sqlComando

            sqlAdaptador.Fill(dt)

        Catch ex As Exception
            LogEventosInsertar("", "", "", "", DateTime.Now, DateTime.Now, "", "", "", "", "", "", ex.Message, ex.Source, ex.StackTrace, False)
            Throw ex
        Finally
            sqlComando.Parameters.Clear()
            sqlComando.Connection.Close()
        End Try

        Return dt
    End Function

    Public Function EquivalenciasCuentasInsert(auxiliar, contrapartida) As Boolean

        Dim sqlComando As SqlCommand = New SqlCommand("sp_equivalencia_cuenta_insertar", conexion)
        Dim sqlAdaptador As SqlDataAdapter = New SqlDataAdapter
        Try
            sqlComando.CommandType = CommandType.StoredProcedure
            sqlComando.Parameters.AddWithValue("@Auxiliar", auxiliar)
            sqlComando.Parameters.AddWithValue("@Contrapartida", contrapartida)
            sqlAdaptador.SelectCommand = sqlComando
            sqlComando.Connection.Open()
            sqlComando.ExecuteNonQuery()
        Catch ex As Exception
            LogEventosInsertar("", "", "", "", DateTime.Now, DateTime.Now, "", "", "", "", "", "", ex.Message, ex.Source, ex.StackTrace, False)
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
            LogEventosInsertar("", "", "", "", DateTime.Now, DateTime.Now, "", "", "", "", "", "", ex.Message, ex.Source, ex.StackTrace, False)
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
            LogEventosInsertar("", "", "", "", DateTime.Now, DateTime.Now, "", "", "", "", "", "", ex.Message, ex.Source, ex.StackTrace, False)
            Return False
        Finally
            sqlComando.Parameters.Clear()
            sqlComando.Connection.Close()
        End Try
        Return True
    End Function
#End Region


    Public Function LogEventosInsertar(compania, centroOper, TipoDto, consecutivo, fechaInicio, fechaFin, numeroLinea, tipoRegistro, subTipoRegistro, version, nivel, valor, mensaje, fuente, seguimiento, estado) As String
        Dim sqlComando As SqlCommand = New SqlCommand("sp_log_eventos_insertar", conexion)
        Dim sqlAdaptador As SqlDataAdapter = New SqlDataAdapter
        Try
            sqlComando.CommandType = CommandType.StoredProcedure
            sqlComando.CommandText = "sp_log_eventos_insertar"
            sqlComando.Parameters.AddWithValue("@Compania", compania)
            sqlComando.Parameters.AddWithValue("@CentroOperacion", centroOper)
            sqlComando.Parameters.AddWithValue("@TipoDocumento", TipoDto)
            sqlComando.Parameters.AddWithValue("@Consecutivo", consecutivo)
            sqlComando.Parameters.AddWithValue("@FechaInicio", fechaInicio)
            sqlComando.Parameters.AddWithValue("@FechaFin", fechaFin)
            sqlComando.Parameters.AddWithValue("@NumeroLinea", numeroLinea)
            sqlComando.Parameters.AddWithValue("@TipoRegistro", tipoRegistro)
            sqlComando.Parameters.AddWithValue("@SubTipoRegistro", subTipoRegistro)
            sqlComando.Parameters.AddWithValue("@Version", version)
            sqlComando.Parameters.AddWithValue("@Nivel", nivel)
            sqlComando.Parameters.AddWithValue("@Valor", valor)
            sqlComando.Parameters.AddWithValue("@Mensaje", mensaje)
            sqlComando.Parameters.AddWithValue("@Fuente", fuente)
            sqlComando.Parameters.AddWithValue("@Seguimiento", seguimiento)
            sqlComando.Parameters.AddWithValue("@Estado", estado)
            sqlAdaptador.SelectCommand = sqlComando
            sqlComando.Connection.Open()
            sqlComando.ExecuteNonQuery()
        Catch ex As Exception
            LogEventosInsertar("", "", "", "", DateTime.Now, DateTime.Now, "", "", "", "", "", "", ex.Message, ex.Source, ex.StackTrace, False)
            Throw ex
        Finally
            sqlComando.Parameters.Clear()
            sqlComando.Connection.Close()
        End Try

        Return "ok"

    End Function

    Public Function LogEventosObtener() As DataTable


        Dim sqlConexion As New SqlConnection(conexion.ConnectionString)
        Dim sqlComando As SqlCommand = New SqlCommand
        Dim sqlAdaptador As SqlDataAdapter = New SqlDataAdapter
        Dim dt As New DataTable

        Try

            sqlComando.Connection = sqlConexion
            sqlComando.CommandType = CommandType.StoredProcedure
            sqlComando.CommandText = "sp_log_eventos_obtener"
            sqlAdaptador.SelectCommand = sqlComando

            sqlAdaptador.Fill(dt)

        Catch ex As Exception
            LogEventosInsertar("", "", "", "", DateTime.Now, DateTime.Now, "", "", "", "", "", "", ex.Message, ex.Source, ex.StackTrace, False)
            Throw ex
        Finally
            sqlComando.Parameters.Clear()
            sqlComando.Connection.Close()
        End Try

        Return dt
    End Function

End Class

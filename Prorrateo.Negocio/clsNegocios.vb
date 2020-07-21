Imports System.Data
Imports Prorrateo.Datos

Public Class clsNegocios

    Private objDatos As New clsDatos

    Public Function ListaDatos(gasto, iva, periodo) As DataTable
        Return objDatos.ListaDatos(gasto, iva, periodo)
    End Function

    Public Function PeriodosObtener() As DataTable
        Return objDatos.PeridosObtener()
    End Function




    Public Function EquivalenciaCuentaObtener(id) As DataTable
        Return objDatos.EquivalenciasCuentasObtener(id)
    End Function

    Public Function EquivalenciasCuentasInser(auxiliar, compartida) As Boolean
        Return objDatos.EquivalenciasCuentasInser(auxiliar, compartida)
    End Function

    Public Function EquivalenciasCuentasEditar(id, auxiliar, compartida) As Boolean
        Return objDatos.EquivalenciasCuentasEditar(id, auxiliar, compartida)
    End Function


    Public Function EquivalenciasCuentasEliminar(id) As Boolean
        Return objDatos.EquivalenciasCuentasEliminar(id)
    End Function


    'Public Function EjecutarProrrateo(gasto, iva, periodo) As String
    '    Dim proceso = "Prorrateo"
    '    Dim centroOper = ""
    '    Dim tipoDto = ""
    '    Dim consecutivo = ""

    '    Dim dtData As New DataTable
    '    dtData = objDatos.ListaDatos(gasto, iva, periodo)

    '    Dim strXML As String = ""
    '    If (dtData.Rows.Count > 0) Then
    '        strXML &= "<MyDataSet>" + Environment.NewLine
    '        For Each item As DataRow In dtData.Rows

    '            centroOper = item("CO").ToString()
    '            tipoDto = item("DOCTO").ToString()
    '            consecutivo = item("CONSECUTIVO").ToString()


    '            strXML &= "<Remision>" + Environment.NewLine
    '            strXML &= "<CO>" + item("CO").ToString() + "</CO>" + Environment.NewLine
    '            strXML &= "<DOCTO>" + item("DOCTO").ToString() + "</DOCTO>" + Environment.NewLine
    '            strXML &= "<CONSECUTIVO>" + item("CONSECUTIVO").ToString() + "</CONSECUTIVO>" + Environment.NewLine
    '            strXML &= "<FECHA>" + item("FECHA").ToString() + "</FECHA>" + Environment.NewLine
    '            strXML &= "<DOCTO_POB>" + item("DOCTO_POB").ToString() + "</DOCTO_POB>" + Environment.NewLine
    '            strXML &= "<CONSECUTIVO_POB>" + item("CONSECUTIVO_POB").ToString() + "</CONSECUTIVO_POB>" + Environment.NewLine
    '            strXML &= "</Remision>" + Environment.NewLine
    '        Next
    '        strXML &= "</MyDataSet>" + Environment.NewLine

    '        'convertir xml a dataset para generar plano
    '        Dim dsPlano As New DataSet
    '        Dim txtReader1 As TextReader = New StringReader(strXML)
    '        Dim reader As XmlReader = New XmlTextReader(txtReader1)
    '        dsPlano.ReadXml(reader)


    '        'Generar Plano
    '        Dim objGT As New WSGT.wsGenerarPlano
    '        Dim resultado As String = ""
    '        Dim plano As String = ""

    '        Try
    '            plano = objGT.GenerarPlanoXML(94623, proceso, My.Settings.IdCia, "2", My.Settings.UsuarioGT, My.Settings.ClaveGT, dsPlano, My.Settings.rutaPlanos, resultado)
    '        Catch ex As Exception
    '            email.EnviarEmailError("Error Integración WMS", ex.Message)
    '            Datos.sp_guardar_log_eventos("", "", "", "", DateTime.Now, DateTime.Now, "", "", "", "", "", "", ex.Message, ex.Source, ex.StackTrace, False)
    '        End Try

    '        'Cargar Datos a Siesa
    '        Dim strXMLUNOEE As String = ""
    '        Dim resultSiesa As Short = 123
    '        Dim dsUNOEE As New DataSet()
    '        Dim strMensaLog As String = ""

    '        strXMLUNOEE &= "<Importar>" + Environment.NewLine
    '        strXMLUNOEE &= "<NombreConexion>" + My.Settings.ConexionSiesa + "</NombreConexion>" + Environment.NewLine
    '        strXMLUNOEE += "<IdCia>" + My.Settings.IdCia + "</IdCia>" + Environment.NewLine
    '        strXMLUNOEE += "<Usuario>" + My.Settings.UsuarioSiesa + "</Usuario>" + Environment.NewLine
    '        strXMLUNOEE += "<Clave>" + My.Settings.ClaveSiesa + "</Clave>" + Environment.NewLine
    '        strXMLUNOEE += plano
    '        strXMLUNOEE += "</Importar>" + Environment.NewLine

    '        ''Campos Log cia-co-tipoDoc-Consecutivo 'Identificador Systech

    '        Dim WSUNOEE As New WSUNOEE.WSUNOEE 'objeto siesa
    '        WSUNOEE.Timeout = 180000

    '        Try
    '            dsUNOEE = WSUNOEE.ImportarXML(strXMLUNOEE, resultSiesa)
    '        Catch ex As Exception
    '            email.EnviarEmailError("Error Integración WMS", ex.Message)
    '            Datos.sp_guardar_log_eventos("", "", "", "", DateTime.Now, DateTime.Now, "", "", "", "", "", "", ex.Message, ex.Source, ex.StackTrace, False)
    '        End Try

    '        Dim strMensaje = GetMensajeError(resultSiesa, dsUNOEE, proceso, strXML)

    '        If resultSiesa = 0 Then
    '            Datos.sp_guardar_log_eventos("1", centroOper, tipoDto, consecutivo, DateTime.Now, DateTime.Now, "", "", "", "", "", "", strMensaje, "", "", True)
    '        Else
    '            email.EnviarEmailError("Error Integración WMS", strMensaje)
    '            Datos.sp_guardar_log_eventos("1", centroOper, tipoDto, consecutivo, DateTime.Now, DateTime.Now, "", "", "", "", "", "", strMensaje, "", "", False)
    '        End If
    '    Else
    '        Datos.sp_guardar_log_eventos("1", centroOper, tipoDto, consecutivo, DateTime.Now, DateTime.Now, "", "", "", "", "", "", "El procedimiento almacenado sp_IN_Remision_POB no retorno datos.", "", "", True)
    '        End If


    '        Return "ok"
    'End Function



End Class

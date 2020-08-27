Imports System.IO
Imports System.Xml

Public Class clsNegocios
    Private objDatos As New clsDatos

    Public Function CargarDatos(gasto, iva, periodo) As DataTable
        Return objDatos.CargarDatos(gasto, iva, periodo)
    End Function

    Public Function PeriodosObtener() As DataTable
        Return objDatos.PeridosObtener()
    End Function


    Public Function EquivalenciaCuentaObtener(id) As DataTable
        Return objDatos.EquivalenciasCuentasObtener(id)
    End Function

    Public Function EquivalenciasCuentasInsert(auxiliar, compartida) As Boolean
        Return objDatos.EquivalenciasCuentasInsert(auxiliar, compartida)
    End Function

    Public Function EquivalenciasCuentasEditar(id, auxiliar, compartida) As Boolean
        Return objDatos.EquivalenciasCuentasEditar(id, auxiliar, compartida)
    End Function


    Public Function EquivalenciasCuentasEliminar(id) As Boolean
        Return objDatos.EquivalenciasCuentasEliminar(id)
    End Function




    Public Function TipoDatosObtener(id) As DataTable
        Return objDatos.TipoDatosObtener(id)
    End Function

    Public Function TipoDatosInsert(tipoDato) As Boolean
        Return objDatos.TipoDatosInsert(tipoDato)
    End Function

    Public Function TipoDatosEditar(id, tipoDato) As Boolean
        Return objDatos.TipoDatosEditar(id, tipoDato)
    End Function


    Public Function TipoDatosEliminar(id) As Boolean
        Return objDatos.TipoDatosEliminar(id)
    End Function




    Public Function LogEventosObtener() As DataTable
        Return objDatos.LogEventosObtener()
    End Function


    Public Function EjecutarProrrateo() As String
        Dim proceso = "PRORRATEO"
        Dim dsDocumentos As New DataSet
        Dim dsMovimientos As New DataSet
        dsDocumentos = objDatos.sp_documentos_contables()
        dsMovimientos = objDatos.sp_movimientos_contables()


        Dim centroOper = ""
        Dim tipoDto = ""
        Dim consecutivo = ""

        Dim strXML As String = ""
        strXML &= "<MyDataSet>" + Environment.NewLine

        If (dsDocumentos.Tables.Count > 0) Then
            If (dsDocumentos.Tables(0).Rows.Count > 0) Then
                If (dsMovimientos.Tables(0).Rows.Count > 0) Then

                    'SECCION DOCUMENTO CONTABLE
                    For Each item As DataRow In dsDocumentos.Tables(0).Rows
                        strXML &= "<DocumentoContable>" + Environment.NewLine
                        strXML &= "<F350_FECHA>" + item("F350_FECHA").ToString() + "</F350_FECHA>" + Environment.NewLine
                        strXML &= "<F350_NOTAS>" + item("F350_NOTAS").ToString() + "</F350_NOTAS>" + Environment.NewLine
                        strXML &= "</DocumentoContable>" + Environment.NewLine
                    Next

                    'SECCION MOVIMIENTO CONTABLE
                    For Each item As DataRow In dsMovimientos.Tables(0).Rows
                        strXML &= "<MovimientoContable>" + Environment.NewLine
                        strXML &= "<f351_id_auxiliar>" + item("f351_id_auxiliar").ToString() + "</f351_id_auxiliar>" + Environment.NewLine
                        strXML &= "<f351_id_tercero>" + item("f351_id_tercero").ToString() + "</f351_id_tercero>" + Environment.NewLine
                        strXML &= "<f351_id_un>" + item("f351_id_un").ToString() + "</f351_id_un>" + Environment.NewLine
                        strXML &= "<f351_id_ccosto>" + item("f351_id_ccosto").ToString() + "</f351_id_ccosto>" + Environment.NewLine
                        strXML &= "<f351_valor_db>" + item("f351_valor_db").ToString() + "</f351_valor_db>" + Environment.NewLine
                        strXML &= "<f351_valor_cr>" + item("f351_valor_cr").ToString() + "</f351_valor_cr>" + Environment.NewLine
                        strXML &= "<f351_valor_cr_alt>" + item("f351_valor_cr_alt").ToString() + "</f351_valor_cr_alt>" + Environment.NewLine
                        strXML &= "<f351_base_gravable>" + item("f351_base_gravable").ToString() + "</f351_base_gravable>" + Environment.NewLine
                        strXML &= "<f351_valor_db2>" + item("f351_valor_db2").ToString() + "</f351_valor_db2>" + Environment.NewLine
                        strXML &= "<f351_valor_cr2>" + item("f351_valor_cr2").ToString() + "</f351_valor_cr2>" + Environment.NewLine
                        strXML &= "<f351_valor_db_alt2>" + item("f351_valor_db_alt2").ToString() + "</f351_valor_db_alt2>" + Environment.NewLine
                        strXML &= "<f351_valor_cr_alt2>" + item("f351_valor_cr_alt2").ToString() + "</f351_valor_cr_alt2>" + Environment.NewLine
                        strXML &= "<f351_base_gravable2>" + item("f351_base_gravable2").ToString() + "</f351_base_gravable2>" + Environment.NewLine
                        strXML &= "<f351_valor_db3>" + item("f351_valor_db3").ToString() + "</f351_valor_db3>" + Environment.NewLine
                        strXML &= "<f351_valor_cr3>" + item("f351_valor_cr3").ToString() + "</f351_valor_cr3>" + Environment.NewLine
                        strXML &= "<f351_valor_db_alt3>" + item("f351_valor_db_alt3").ToString() + "</f351_valor_db_alt3>" + Environment.NewLine
                        strXML &= "<f351_valor_cr_alt3>" + item("f351_valor_cr_alt3").ToString() + "</f351_valor_cr_alt3>" + Environment.NewLine
                        strXML &= "<f351_base_gravable3>" + item("f351_base_gravable3").ToString() + "</f351_base_gravable3>" + Environment.NewLine
                        strXML &= "<f351_notas>" + item("f351_notas").ToString() + "</f351_notas>" + Environment.NewLine
                        strXML &= "</MovimientoContable>" + Environment.NewLine
                    Next


                    strXML &= "</MyDataSet>" + Environment.NewLine

                    'convertir xml a dataset para generar plano
                    Dim dsPlano As New DataSet
                    Dim txtReader1 As IO.TextReader = New StringReader(strXML)
                    Dim reader As XmlReader = New XmlTextReader(txtReader1)
                    dsPlano.ReadXml(reader)


                    'Generar Plano
                    Dim objGT As New WSGT.wsGenerarPlano
                    Dim resultado As String = ""
                    Dim plano As String = ""
                    Dim rutaPlanos As String = My.Settings.rutaPlanos

                    Try
                        plano = objGT.GenerarPlanoXML(91491, proceso, My.Settings.IdCia, "2", My.Settings.UsuarioGT, My.Settings.ClaveGT, dsPlano, rutaPlanos, resultado)
                    Catch ex As Exception
                        'email.EnviarEmailError("Error Integración WMS", ex.Message)
                        objDatos.LogEventosInsertar("", "", "", "", DateTime.Now, DateTime.Now, "", "", "", "", "", "", ex.Message, ex.Source, ex.StackTrace, False)
                    End Try


                    'Cargar Datos a Siesa
                    Dim strXMLUNOEE As String = ""
                    Dim resultSiesa As Short = 123
                    Dim dsUNOEE As New DataSet()
                    Dim strMensaLog As String = ""

                    strXMLUNOEE &= "<Importar>" + Environment.NewLine
                    strXMLUNOEE &= "<NombreConexion>" + My.Settings.ConexionSiesa + "</NombreConexion>" + Environment.NewLine
                    strXMLUNOEE += "<IdCia>" + My.Settings.IdCia + "</IdCia>" + Environment.NewLine
                    strXMLUNOEE += "<Usuario>" + My.Settings.UsuarioSiesa + "</Usuario>" + Environment.NewLine
                    strXMLUNOEE += "<Clave>" + My.Settings.ClaveSiesa + "</Clave>" + Environment.NewLine
                    strXMLUNOEE += plano
                    strXMLUNOEE += "</Importar>" + Environment.NewLine

                    ''Campos Log cia-co-tipoDoc-Consecutivo 'Identificador Systech
                    Dim WSUNOEE As New WSUNOEE.WSUNOEE 'objeto siesa
                    WSUNOEE.Timeout = 180000 '3 Minutos mmedida en milisegundos

                    Try
                        dsUNOEE = WSUNOEE.ImportarXML(strXMLUNOEE, resultSiesa)
                    Catch ex As Exception
                        'email.EnviarEmailError("Error Integración WMS", ex.Message)
                        objDatos.LogEventosInsertar("", "", "", "", DateTime.Now, DateTime.Now, "", "", "", "", "", "", ex.Message, ex.Source, ex.StackTrace, False)
                    End Try


                    Dim strMensaje = GetMensajeError(resultSiesa, dsUNOEE, proceso, strXML)

                    If resultSiesa = 0 Then
                        objDatos.LogEventosInsertar("1", centroOper, tipoDto, consecutivo, DateTime.Now, DateTime.Now, "", "", "", "", "", "", strMensaje, "", "", True)
                    Else
                        'email.EnviarEmailError("Error Integración WMS", strMensaje)
                        objDatos.LogEventosInsertar("1", centroOper, tipoDto, consecutivo, DateTime.Now, DateTime.Now, "", "", "", "", "", "", strMensaje, "", "", False)
                        GuardarLogSiesaDataSet(dsUNOEE, centroOper, tipoDto, consecutivo)
                    End If
                Else
                    objDatos.LogEventosInsertar("1", centroOper, tipoDto, consecutivo, DateTime.Now, DateTime.Now, "", "", "", "", "", "", "El procedimiento almacenado sp_movimientos_contables no retorno datos.", "", "", True)
                End If
            Else
                objDatos.LogEventosInsertar("1", centroOper, tipoDto, consecutivo, DateTime.Now, DateTime.Now, "", "", "", "", "", "", "El procedimiento almacenado sp_documentos_contables no retorno datos.", "", "", True)
            End If
        End If

        Return "ok"
    End Function

    Public Function GetMensajeError(resultSiesa As Integer, dsUNOEE As DataSet, proceso As String, strXML As String) As String
        Dim strMensaje = ""
        Select Case resultSiesa
            Case 0
                strMensaje = proceso + " : Importacion Exitosa "
            Case 1
                strMensaje = proceso + " : Error : 1 - Error de datos al cargar la informacion a Siesa "
            Case 2
                strMensaje = proceso + " : Error : 2 - El impodatos no envio algun parametro " + dsUNOEE.GetXml() + Environment.NewLine + strXML
            Case 3
                strMensaje = proceso + " : Error : 3 - El usuario o la contraseña que ingreso no son validos " + dsUNOEE.GetXml() + Environment.NewLine + strXML
            Case 4
                strMensaje = proceso + " : Error : 4 - La version del impodatos no se corresponde con la version del ERP o el impodatos esta en una maquina que no tiene cliente Siesa " + dsUNOEE.GetXml() + Environment.NewLine + strXML
            Case 5
                strMensaje = proceso + " : Error : 5 - La base de datos no existe o están ingresándole un parámetro erróneo a la hora de especificar la conexión. " + dsUNOEE.GetXml() + Environment.NewLine + strXML
            Case 6
                strMensaje = proceso + " : Error : 6 - El archivo que se está especificando en la ruta de los parámetros del .BAT no existe " + dsUNOEE.GetXml() + Environment.NewLine + strXML
            Case 7
                strMensaje = proceso + "  Error :  7 - El archivo que se está especificando en la ruta de los parámetros del .BAT no es valido " + dsUNOEE.GetXml() + Environment.NewLine + strXML
            Case 8
                strMensaje = proceso + " : Error : 8 - Hay un problema con la tabla en la base de datos donde se ingresaran los archivos " + dsUNOEE.GetXml() + Environment.NewLine + strXML
            Case 9
                strMensaje = proceso + " : Error :  9 - La compañía que se ingresó en los parámetros del .BAT no es valida " + dsUNOEE.GetXml() + Environment.NewLine + strXML
            Case 10
                strMensaje = proceso + " : Error : 10 - Error desconocido " + dsUNOEE.GetXml() + Environment.NewLine + strXML
            Case 99
                strMensaje = proceso + "Error : 99 - Error de tipo diferente a los anteriores, normalmente de permisos a nivel del ERP " + dsUNOEE.GetXml() + Environment.NewLine + strXML

        End Select

        Return strMensaje
    End Function



    Public Function GuardarLogSiesaDataSet(dsUNOEE As DataSet, centroOper As String, tipoDto As String, consecutivo As String) As Boolean

        Dim numeroLinea = ""
        Dim tipoRegistro = ""
        Dim subTipoRegistro = ""
        Dim version = ""
        Dim nivel = ""
        Dim valor = ""
        Dim mensaje = ""


        If (dsUNOEE.Tables.Count > 0) Then
            If (dsUNOEE.Tables(0).Rows.Count > 0) Then
                For Each item As DataRow In dsUNOEE.Tables(0).Rows
                    numeroLinea = item("f_nro_linea").ToString()
                    tipoRegistro = item("f_tipo_reg").ToString()
                    subTipoRegistro = item("f_subtipo_reg").ToString()
                    version = item("f_version").ToString()
                    nivel = item("f_nivel").ToString()
                    valor = item("f_valor").ToString()
                    mensaje = item("f_detalle").ToString()

                    objDatos.LogEventosInsertar("1", centroOper, tipoDto, consecutivo, DateTime.Now, DateTime.Now, numeroLinea, tipoRegistro, subTipoRegistro, version, nivel, valor, mensaje, "", "", False)
                Next
            End If
        End If
        Return True
    End Function


End Class

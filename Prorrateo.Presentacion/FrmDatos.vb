
'Imports Microsoft.Office.Interop.Excel

Imports OfficeOpenXml

Public Class FrmDatos
    Dim objNegocios As New clsNegocios
    Private Sub FrmDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMensaje.Text = ""
        Dim dt As New DataTable()
        dt = objNegocios.PeriodosObtener()

        If (dt.Rows.Count > 0) Then
            For Each item As DataRow In dt.Rows
                lstPeriodos.Items.Add(item("Periodo").ToString())
            Next
        End If
        btnExportar.Visible = False
        btnEjecutar.Visible = False
    End Sub

    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        lblMensaje.Visible = True
        lblMensaje.Text = "! Procesando infomación, Por favor espere."
        objNegocios.EjecutarProrrateo()
        lblMensaje.Text = "! Proceso de prorrateo finalizado."

        Dim dtLog As DataTable = objNegocios.LogEventosObtener()
        dtgLog.DataSource = dtLog
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        lblMensaje.Text = ""
        Dim gasto = txtGasto.Text
        Dim iva = txtIva.Text
        Dim periodos = ""
        For x = 0 To lstPeriodos.SelectedItems.Count() - 1
            If lstPeriodos.SelectedItems.Count() > 0 Then

                periodos += lstPeriodos.SelectedItems(x) + ","

            End If
        Next x

        CargarDatos(gasto, iva, periodos)
    End Sub

    Sub CargarDatos(gasto, iva, periodo)
        Dim dt As DataTable = objNegocios.CargarDatos(gasto, iva, periodo)
        dtgDatos.DataSource = dt

        If (dt.Rows.Count > 0) Then
            btnExportar.Visible = True
            btnEjecutar.Visible = True

        End If
    End Sub

    Function ExportarExcel(ByVal ElGrid As DataGridView) As Boolean

        Dim strLinea As String = ""
        Dim gasto = txtGasto.Text
        Dim iva = txtIva.Text
        Dim periodos = ""
        For x = 0 To lstPeriodos.SelectedItems.Count() - 1
            If lstPeriodos.SelectedItems.Count() > 0 Then

                periodos += lstPeriodos.SelectedItems(x) + ","

            End If
        Next x

        Try
            Dim dt As DataTable = objNegocios.CargarDatos(gasto, iva, periodos)

            For Each columna As DataColumn In dt.Columns
                strLinea &= columna.ColumnName.ToString & ";"
            Next

            strLinea &= vbNewLine
            For Each Registro As DataRow In dt.Rows

                'strLinea &= Registro.Item("f350_rowid").ToString & ";"
                strLinea &= Registro.Item("TIPO_DOCUMENTO").ToString & ";"
                strLinea &= Registro.Item("DOCTO").ToString & ";"
                strLinea &= Registro.Item("CUENTA").ToString & ";"
                strLinea &= Registro.Item("TERCERO_DOCTO").ToString & ";"
                strLinea &= Registro.Item("RAZON_SOCIAL_DOCTO").ToString & ";"
                strLinea &= Registro.Item("CENTRO_COSTOS").ToString & ";"
                strLinea &= Registro.Item("DEBITOS").ToString & ";"
                strLinea &= Registro.Item("UNIDAD_NEGOCIO").ToString & ";"
                strLinea &= Registro.Item("CONS_24082005").ToString & ";"
                strLinea &= Registro.Item("CONS_24082010").ToString & ";"
                strLinea &= Registro.Item("CONS_24081025").ToString & ";"
                strLinea &= Registro.Item("TOTAL_24").ToString & ";"
                strLinea &= Registro.Item("CONS_5_7").ToString & ";"
                strLinea &= Registro.Item("PORC_PART").ToString & ";"
                strLinea &= Registro.Item("IVA_X_CTA").ToString & ";"
                strLinea &= Registro.Item("GASTO").ToString & ";"
                strLinea &= Registro.Item("IVA").ToString & ";"
                strLinea &= vbNewLine
            Next

            Dim ruta As String = "C:\ExcelProrrateo\" & Date.Now.Day.ToString & "-" & Date.Now.Month.ToString & "-" & Date.Now.Year.ToString & "-Prorrateo.xls"

            'My.Computer.FileSystem.WriteAllText("C:\ExcelProrrateo\archivo.xls", strLinea, True)
            My.Computer.FileSystem.WriteAllText(ruta, strLinea, True)

            MessageBox.Show("El arcvhivo se genero de forma correcta en la siguiente ruta: " & ruta)
        Catch ex As Exception

            Throw ex

        End Try


    End Function

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        lblMensaje.Text = "! Exportando archivo, Por favor espere."
        ExportarExcel(dtgDatos)
        lblMensaje.Text = ""
    End Sub


End Class
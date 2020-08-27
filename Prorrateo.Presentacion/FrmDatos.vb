
'Imports Microsoft.Office.Interop.Excel

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
        lblMensaje.Text = "!Procesando infomación, Por favor espere."
        objNegocios.EjecutarProrrateo()
        lblMensaje.Text = "!Proceso de prorrateo finalizado."
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

        'Creamos las variables

        Dim exApp As New Microsoft.Office.Interop.Excel.Application

        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook

        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try

            'Añadimos el Libro al programa, y la hoja al libro

            exLibro = exApp.Workbooks.Add

            exHoja = exLibro.Worksheets.Add()

            ' ¿Cuantas columnas y cuantas filas?

            Dim NCol As Integer = ElGrid.ColumnCount

            Dim NRow As Integer = ElGrid.RowCount

            'Aqui recorremos todas las filas, y por cada fila todas las columnas

            'y vamos escribiendo.

            For i As Integer = 1 To NCol

                exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).Name.ToString

            Next

            For Fila As Integer = 0 To NRow - 1

                For Col As Integer = 0 To NCol - 1

                    exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Item(Col, Fila).Value

                Next

            Next

            'Titulo en negrita, Alineado al centro y que el tamaño de la columna

            'se ajuste al texto

            exHoja.Rows.Item(1).Font.Bold = 1

            exHoja.Rows.Item(1).HorizontalAlignment = 3

            exHoja.Columns.AutoFit()

            'Aplicación visible

            exApp.Application.Visible = True

            exHoja = Nothing

            exLibro = Nothing

            exApp = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")

            Return False

        End Try

        Return True

    End Function

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        lblMensaje.Text = "!Exportando archivo, Por favor espere."
        ExportarExcel(dtgDatos)
        lblMensaje.Text = ""
    End Sub


End Class
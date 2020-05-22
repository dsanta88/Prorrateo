Imports Prorrateo.Negocio



Public Class FrmDatos
    Dim objNegocios As New clsNegocios

    Private Sub FrmDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstPeriodo.Items.Add("201308")
        lstPeriodo.Items.Add("201307")
        lstPeriodo.Items.Add("201308")
        lstPeriodo.Items.Add("201309")
        lstPeriodo.Items.Add("201310")
        lstPeriodo.Items.Add("201311")
        btnExcel.Visible = False
        btnEjecutar.Visible = False
    End Sub



    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim gasto = txtGasto.Text
        Dim iva = txtIva.Text
        Dim periodos = ""
        For x = 0 To lstPeriodo.SelectedItems.Count() - 1
            If lstPeriodo.SelectedItems.Count() > 0 Then

                periodos += lstPeriodo.SelectedItems(x) + ","

            End If
        Next x

        ListarDatos(gasto, iva, periodos)

    End Sub

    Sub ListarDatos(gasto, iva, periodo)
        Dim dt As DataTable = objNegocios.ListaDatos(gasto, iva, periodo)
        DataGrid.DataSource = dt

        If (dt.Rows.Count > 0) Then
            btnExcel.Visible = True
            btnEjecutar.Visible = True

        End If
    End Sub

    Function Exportar(ByVal ElGrid As DataGridView) As Boolean
        ElGrid.Columns(0).Name = "TipoDocumento"
        ElGrid.Columns(1).Name = "Documento"
        ElGrid.Columns(2).Name = "Cuenta"
        ElGrid.Columns(3).Name = "TerceroDocumento"
        ElGrid.Columns(4).Name = "RazonSocial"
        ElGrid.Columns(5).Name = "CentroCostos"
        ElGrid.Columns(6).Name = "Debitos"
        ElGrid.Columns(7).Name = "UnidadNegocio"
        ElGrid.Columns(8).Name = "Cons24082005"
        ElGrid.Columns(9).Name = "Cons24082010"
        ElGrid.Columns(10).Name = "Cons24081025"
        ElGrid.Columns(11).Name = "Total24"
        ElGrid.Columns(12).Name = "Cons-5-7"
        ElGrid.Columns(13).Name = "PorcPart"
        ElGrid.Columns(14).Name = "IvaXCuanta"
        ElGrid.Columns(15).Name = "Gasto"
        ElGrid.Columns(16).Name = "Iva"

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

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Exportar(DataGrid)
    End Sub


End Class

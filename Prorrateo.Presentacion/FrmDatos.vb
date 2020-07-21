Imports Prorrateo.Negocio

Public Class FrmDatos
    Dim objNegocios As New clsNegocios
    Private Sub FrmDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
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
        Dim dt As DataTable = objNegocios.ListaDatos(gasto, iva, periodo)
        dtgDatos.DataSource = dt

        If (dt.Rows.Count > 0) Then
            btnExportar.Visible = True
            btnEjecutar.Visible = True

        End If
    End Sub
End Class
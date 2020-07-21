Imports Prorrateo.Negocio

Public Class FrmConfiguraciones
    Dim objNegocios As New clsNegocios

    Private Sub FrmConfiguraciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtEqu As New DataTable()
        dtEqu = objNegocios.EquivalenciaCuentaObtener(-1)
        dtgEquivalencias.DataSource = dtEqu

    End Sub
End Class
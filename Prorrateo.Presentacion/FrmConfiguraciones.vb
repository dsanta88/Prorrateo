Imports Prorrateo.Negocio

Public Class FrmConfiguraciones
    Dim objNegocios As New clsNegocios
    Private Sub FrmConfiguraciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarDatos()
    End Sub

    Public Sub CargarDatos()
        Dim dtEqu As New DataTable()
        dtEqu = objNegocios.EquivalenciaCuentaObtener(-1)
        dtgEquivalencias.DataSource = dtEqu
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtAuxiliar.Text = ""
        txtContrapartida.Text = ""
    End Sub
End Class


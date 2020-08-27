Imports Prorrateo.Negocio

Public Class FrmConfiguraciones
    Dim objNegocios As New clsNegocios
    Dim IdEquiv = 0
    Dim IdTipoDato = 0
    Private Sub FrmConfiguraciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarDatos()
    End Sub

    Public Sub CargarDatos()
        IdEquiv = 0
        IdTipoDato = 0
        txtAuxiliar.Text = ""
        txtContrapartida.Text = ""
        txtTipodato.Text = ""
        Dim dtEqu As New DataTable()
        dtEqu = objNegocios.EquivalenciaCuentaObtener(-1)
        dtgEquivalencias.DataSource = dtEqu

        Dim dtgTipoDato As New DataTable()
        dtgTipoDato = objNegocios.TipoDatosObtener(-1)
        dtgTipoDatos.DataSource = dtgTipoDato
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtAuxiliar.Text = ""
        txtContrapartida.Text = ""
    End Sub

    Private Sub btnGuardarEquiv_Click(sender As Object, e As EventArgs) Handles btnGuardarEquiv.Click
        If txtAuxiliar.Text = "" Then
            MessageBox.Show("Debe seleccionar el campo Auxiliar.")
        Else
            If (IdEquiv = 0) Then
                objNegocios.EquivalenciasCuentasInsert(txtAuxiliar.Text, txtContrapartida.Text)
            Else
                objNegocios.EquivalenciasCuentasEditar(IdEquiv, txtAuxiliar.Text, txtContrapartida.Text)
            End If
            CargarDatos()
        End If

    End Sub

    Private Sub dtgEquivalencias_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgEquivalencias.CellMouseClick
        IdEquiv = dtgEquivalencias.Rows(e.RowIndex).Cells(0).Value
        txtAuxiliar.Text = dtgEquivalencias.Rows(e.RowIndex).Cells(1).Value
        txtContrapartida.Text = dtgEquivalencias.Rows(e.RowIndex).Cells(2).Value
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        txtAuxiliar.Text = ""
        txtContrapartida.Text = ""
    End Sub

    Private Sub btnEliminarEquiv_Click(sender As Object, e As EventArgs) Handles btnEliminarEquiv.Click

        If MessageBox.Show("Esta seguro de eliminar el registro?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If (IdEquiv > 0) Then
                objNegocios.EquivalenciasCuentasEliminar(IdEquiv)
                MessageBox.Show("Regisro eliminado")
            End If
        End If

        CargarDatos()
    End Sub

    Private Sub btnGuardarTiipoDato_Click(sender As Object, e As EventArgs) Handles btnGuardarTiipoDato.Click
        If txtTipodato.Text = "" Then
            MessageBox.Show("Debe seleccionar el campo Tipo de dato.")
        Else
            If (IdTipoDato = 0) Then
                objNegocios.TipoDatosInsert(txtTipodato.Text)
            Else
                objNegocios.TipoDatosEditar(IdTipoDato, txtTipodato.Text)
            End If
            CargarDatos()
        End If
    End Sub

    Private Sub dtgTipoDatos_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgTipoDatos.CellMouseClick
        IdTipoDato = dtgTipoDatos.Rows(e.RowIndex).Cells(0).Value
        txtTipodato.Text = dtgTipoDatos.Rows(e.RowIndex).Cells(1).Value
    End Sub

    Private Sub btnEliminarTipoDato_Click(sender As Object, e As EventArgs) Handles btnEliminarTipoDato.Click

        If MessageBox.Show("Esta seguro de eliminar el registro?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If (IdTipoDato > 0) Then
                objNegocios.TipoDatosEliminar(IdTipoDato)
                MessageBox.Show("Regisro eliminado")
            End If
        End If

        CargarDatos()
    End Sub

    Private Sub btnNuevoTipoDato_Click(sender As Object, e As EventArgs) Handles btnNuevoTipoDato.Click
        txtTipodato.Text = ""
    End Sub
End Class


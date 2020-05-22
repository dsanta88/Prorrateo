Imports System.Data
Imports Prorrateo.Datos

Public Class clsNegocios

    Private objDatos As New clsDatos

    Public Function ListaDatos(gasto, iva, periodo) As DataTable
        Return objDatos.ListaDatos(gasto, iva, periodo)
    End Function


End Class

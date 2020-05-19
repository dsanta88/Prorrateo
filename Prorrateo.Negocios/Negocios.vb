Imports System.Data
Imports Prorrateo.Datos

Public Class clsNegocios

    Private objDatos As New clsDatos


    Public Function ListaDatos() As DataTable
        Return objDatos.ListaDatos()
    End Function

End Class

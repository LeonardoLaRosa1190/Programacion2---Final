Public Class frmImprimirVentasFecha
    Private Sub frmImprimirVentasFecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Agencia_2023DataSet.spu_ventas_fechas' Puede moverla o quitarla según sea necesario.
        Me.Spu_ventas_fechasTableAdapter.Fill(Me.Agencia_2023DataSet.spu_ventas_fechas, fhDesde, fhHasta)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
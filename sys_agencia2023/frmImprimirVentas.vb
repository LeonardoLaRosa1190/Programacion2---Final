Public Class frmImprimirVentas
    Private Sub frmImprimirVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Agencia_2023DataSet.ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.Agencia_2023DataSet.ventas)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
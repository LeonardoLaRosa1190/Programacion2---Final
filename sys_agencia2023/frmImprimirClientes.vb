Public Class frmImprimirClientes
    Private Sub frmImprimirClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Agencia_2023DataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.Agencia_2023DataSet.clientes)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
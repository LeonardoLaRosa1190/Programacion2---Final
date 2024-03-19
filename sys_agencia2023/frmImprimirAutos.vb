Public Class frmImprimirAutos
    Private Sub frmImprimirAutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Agencia_2023DataSet.autos' Puede moverla o quitarla según sea necesario.
        Me.AutosTableAdapter.Fill(Me.Agencia_2023DataSet.autos)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
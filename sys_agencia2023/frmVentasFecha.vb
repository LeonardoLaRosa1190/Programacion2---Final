Public Class frmVentasFecha


    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpickDesde.ValueChanged
        txtboxDesde.Text = dtpickDesde.Value.Date

    End Sub

    Private Sub dtpickHasta_ValueChanged(sender As Object, e As EventArgs) Handles dtpickHasta.ValueChanged
        txtboxHasta.Text = dtpickHasta.Value.Date

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        fhDesde = txtboxDesde.Text
        fhHasta = txtboxHasta.Text

        Dim frm As New frmImprimirVentasFecha
        frm.ShowDialog()
    End Sub
End Class
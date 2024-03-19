Public Class frmMenu
    Private Sub MENÜToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CLIENTESToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New frmClientes
        frm.ShowDialog()
    End Sub

    Private Sub EMPRESAToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LocalidadesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New frmLocalidades
        frm.ShowDialog()
    End Sub

    Private Sub VendedoresToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New frmVendedores
        frm.ShowDialog()
    End Sub

    Private Sub EmpresaToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        Dim frm As New frmEmpresa
        frm.ShowDialog()
    End Sub

    Private Sub AutosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New frmAutos
        frm.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        Dim frm As New frmClientes
        frm.ShowDialog()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New frmVentas
        frm.ShowDialog()
    End Sub

    Private Sub VentasPorFechaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New frmVentasFecha
        frm.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        Dim frm As New frmVentas
        frm.ShowDialog()
    End Sub

    Private Sub AutosToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        Dim frm As New frmImprimirAutos
        frm.ShowDialog()
    End Sub

    Private Sub SdfsdfsdfToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New frmImprimirVentasFecha
        frm.ShowDialog()
    End Sub

    Private Sub AsfsdfdToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New frmImprimirClientes
        frm.ShowDialog()
    End Sub

    Private Sub SdfsdfToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New frmImprimirVentas
        frm.ShowDialog()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim frm As New frmClientes
        frm.ShowDialog()
    End Sub

    Private Sub btnAutos_Click(sender As Object, e As EventArgs) Handles btnAutos.Click
        Dim frm As New frmAutos
        frm.ShowDialog()
    End Sub

    Private Sub btnLocalidades_Click(sender As Object, e As EventArgs) Handles btnLocalidades.Click
        Dim frm As New frmLocalidades
        frm.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim frm As New frmVentasFecha
        frm.ShowDialog()
    End Sub

    Private Sub btnVendedores_Click(sender As Object, e As EventArgs) Handles btnVendedores.Click
        Dim frm As New frmVendedores
        frm.ShowDialog()
    End Sub

    Private Sub btnEmpresa_Click(sender As Object, e As EventArgs) Handles btnEmpresa.Click
        Dim frm As New frmEmpresa
        frm.ShowDialog()
    End Sub
End Class
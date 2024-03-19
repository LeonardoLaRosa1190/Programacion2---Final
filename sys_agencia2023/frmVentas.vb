Public Class frmVentas
    Private Sub VentasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VentasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VentasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Agencia_2023DataSet)

    End Sub

    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Agencia_2023DataSet.ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.Agencia_2023DataSet.ventas)

    End Sub

    Private Sub btnVendedor_Click(sender As Object, e As EventArgs) Handles btnVendedor.Click
        flag_where = 1
        Dim frm As New frmVendedores
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub





    Private Sub Id_ventaTextBox_TextChanged(sender As Object, e As EventArgs) Handles Id_ventaTextBox.TextChanged

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub btnCliente_Click_1(sender As Object, e As EventArgs) Handles btnCliente.Click
        flag_where = 1
        Dim frm As New frmClientes
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub btnAutos_Click(sender As Object, e As EventArgs) Handles btnAutos.Click
        flag_where = 1
        Dim frm As New frmAutos
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub btnImprimirInforme_autos_Click(sender As Object, e As EventArgs) Handles btnImprimirInforme_autos.Click
        Dim frm As New frmImprimirVentas
        frm.ShowDialog()
    End Sub

    Private Sub btnImprimirventas_fecha_Click(sender As Object, e As EventArgs) Handles btnImprimirventas_fecha.Click
        Dim frm As New frmVentasFecha
        frm.ShowDialog()
    End Sub
End Class
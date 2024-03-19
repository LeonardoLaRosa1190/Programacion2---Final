Public Class frmVendedores
    Private Sub VendedoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VendedoresBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VendedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Agencia_2023DataSet)

    End Sub

    Private Sub frmVendedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Agencia_2023DataSet.vendedores' Puede moverla o quitarla según sea necesario.
        Me.VendedoresTableAdapter.Fill(Me.Agencia_2023DataSet.vendedores)

    End Sub

    Private Sub VendedoresDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles VendedoresDataGridView.KeyDown

        If flag_where = 1 Then
            If e.KeyData = Keys.Enter Then
                Dim frm As frmVentas = CType(Owner, frmVentas)
                frm.Id_vendedorTextBox.Text = Me.VendedoresDataGridView.CurrentRow.Cells(0).Value
                flag_where = 0
                frm.Id_clienteTextBox.Focus()
                Me.Close()
            End If
        End If


    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.Height = 500
        Id_vendedorTextBox.Focus()

    End Sub

    Private Sub Id_vendedorLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class
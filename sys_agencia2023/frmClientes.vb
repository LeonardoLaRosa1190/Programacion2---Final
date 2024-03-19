Public Class frmClientes
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Agencia_2023DataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.Agencia_2023DataSet.clientes)
        'TODO: esta línea de código carga datos en la tabla 'Agencia_2023DataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.Agencia_2023DataSet.clientes)


    End Sub

    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClientesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Agencia_2023DataSet)

    End Sub

    Private Sub Apellido_nombreLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLocalidades_Click(sender As Object, e As EventArgs) Handles btnLocalidades.Click
        flag_where = 1
        Dim frm As New frmLocalidades
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub ClientesDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles ClientesDataGridView.KeyDown
        If flag_where = 1 Then
            If e.KeyData = Keys.Enter Then
                Dim frm As frmVentas = CType(Owner, frmVentas)
                frm.Id_clienteTextBox.Text = Me.ClientesDataGridView.CurrentRow.Cells(0).Value
                flag_where = 0
                frm.Id_autoTextBox.Focus()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        Id_clienteTextBox.Focus()
    End Sub

    Private Sub btnImprimirInformes_autos_Click(sender As Object, e As EventArgs) Handles btnImprimirInformes_autos.Click
        Dim frm As New frmImprimirClientes
        frm.ShowDialog()
    End Sub
End Class
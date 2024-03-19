Public Class frmLocalidades
    Private Sub LocalidadesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles LocalidadesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LocalidadesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Agencia_2023DataSet)

    End Sub

    Private Sub frmLocalidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Agencia_2023DataSet.localidades' Puede moverla o quitarla según sea necesario.
        Me.LocalidadesTableAdapter.Fill(Me.Agencia_2023DataSet.localidades)

    End Sub

    Private Sub LocalidadesDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles LocalidadesDataGridView.KeyDown
        If flag_where = 1 Then
            If e.KeyData = Keys.Enter Then
                Dim frm As frmClientes = CType(Owner, frmClientes)
                frm.CpTextBox.Text = Me.LocalidadesDataGridView.CurrentRow.Cells(0).Value
                flag_where = 0
                Me.Close()
            End If
        End If
        If flag_where = 2 Then
            If e.KeyData = Keys.Enter Then
                Dim frm As frmEmpresa = CType(Owner, frmEmpresa)
                frm.CpTextBox.Text = Me.LocalidadesDataGridView.CurrentRow.Cells(0).Value
                flag_where = 0
                Me.Close()
            End If
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.Height = 350
    End Sub

    Private Sub LocalidadesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles LocalidadesDataGridView.CellContentClick

    End Sub
End Class
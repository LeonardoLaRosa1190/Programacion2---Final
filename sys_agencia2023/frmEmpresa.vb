Public Class frmEmpresa
    Private Sub EmpresaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmpresaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmpresaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Agencia_2023DataSet)

    End Sub

    Private Sub frmEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Agencia_2023DataSet.empresa' Puede moverla o quitarla según sea necesario.
        Me.EmpresaTableAdapter.Fill(Me.Agencia_2023DataSet.empresa)

    End Sub

    Private Sub EmpresaDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpresaDataGridView.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLocalidades.Click
        flag_where = 2
        Dim frm As New frmLocalidades
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.Height = 370
    End Sub
End Class
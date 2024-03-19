Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmAutos
    Private Sub AutosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AutosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AutosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Agencia_2023DataSet)

    End Sub

    Private Sub frmAutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Agencia_2023DataSet.autos' Puede moverla o quitarla según sea necesario.
        Me.AutosTableAdapter.Fill(Me.Agencia_2023DataSet.autos)

    End Sub

    Private Sub AutosDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles AutosDataGridView.KeyDown


        If flag_where = 1 Then
            If e.KeyData = Keys.Enter Then
                Dim frm As frmVentas = CType(Owner, frmVentas)
                frm.Id_autoTextBox.Text = Me.AutosDataGridView.CurrentRow.Cells(0).Value
                flag_where = 0
                Id_autoTextBox.Focus()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub rdbtnFoto_CheckedChanged(sender As Object, e As EventArgs)
        'pickboxAuto.ImageLocation = FotoTextBox.Text
        'pickboxAuto.Load()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnImprimirInforme_autos.Click
        Dim frm As New frmImprimirAutos
        frm.ShowDialog()
    End Sub

    Private Sub Id_autoLabel_Click(sender As Object, e As EventArgs)

    End Sub






    Private Sub AutosDataGridView_Click(sender As Object, e As EventArgs) Handles AutosDataGridView.Click
        pickboxAuto.ImageLocation = FotoTextBox.Text
        pickboxAuto.Load()
    End Sub
End Class
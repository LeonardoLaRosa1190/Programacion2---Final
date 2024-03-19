Public Class frmLogin
    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Agencia_2023DataSet)

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Agencia_2023DataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.Agencia_2023DataSet.usuarios)
        txtboxPass.Focus()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If Me.txtboxPass.Text = UsuariosDataGridView.CurrentRow.Cells(1).Value.ToString Then
            frmMenu.Show()
            Me.Close()
        Else
            MsgBox("PASSWORD INCORRECTA", MsgBoxStyle.Critical, "ALERTA")
            txtboxPass.Clear()
            txtboxPass.Focus()
        End If
    End Sub

    Private Sub UsuariosDataGridView_Click(sender As Object, e As EventArgs) Handles UsuariosDataGridView.Click
        txtboxPass.Focus()
    End Sub
End Class
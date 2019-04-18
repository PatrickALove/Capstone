Public Class InvItemForm
    Private Sub ItemsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ItemsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ItemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LarrySartorialCapstoneDataSet)

    End Sub

    Private Sub InvItemForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LarrySartorialCapstoneDataSet.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter.Fill(Me.LarrySartorialCapstoneDataSet.Items)

    End Sub
End Class
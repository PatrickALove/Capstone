Public Class InvForm
    Private Sub InventoryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.InventoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LarrySartorialCapstoneDataSet)

    End Sub

    Private Sub InventoryBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles InventoryBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InventoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LarrySartorialCapstoneDataSet)

    End Sub

    Private Sub InvForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LarrySartorialCapstoneDataSet.Inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.LarrySartorialCapstoneDataSet.Inventory)

    End Sub
End Class
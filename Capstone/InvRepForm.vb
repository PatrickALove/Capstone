Public Class InvRepForm
    Private Sub Inventory_ReportsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Inventory_ReportsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Inventory_ReportsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LarrySartorialCapstoneDataSet)

    End Sub

    Private Sub InvRepForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LarrySartorialCapstoneDataSet.Inventory_Reports' table. You can move, or remove it, as needed.
        Me.Inventory_ReportsTableAdapter.Fill(Me.LarrySartorialCapstoneDataSet.Inventory_Reports)

    End Sub
End Class
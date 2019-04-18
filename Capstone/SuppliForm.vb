Public Class SuppliForm
    Private Sub SuppliersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SuppliersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SuppliersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LarrySartorialCapstoneDataSet)

    End Sub

    Private Sub SuppliForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LarrySartorialCapstoneDataSet.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.LarrySartorialCapstoneDataSet.Suppliers)

    End Sub
End Class
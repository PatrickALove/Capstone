Public Class VenDatCaForm
    Private Sub VendorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VendorsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VendorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LarrySartorialCapstoneDataSet)

    End Sub

    Private Sub VenDatCaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LarrySartorialCapstoneDataSet.Vendors' table. You can move, or remove it, as needed.
        Me.VendorsTableAdapter.Fill(Me.LarrySartorialCapstoneDataSet.Vendors)

    End Sub
End Class
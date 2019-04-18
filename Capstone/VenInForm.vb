Public Class VenInForm
    Private Sub Vendor_InvoicesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Vendor_InvoicesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Vendor_InvoicesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LarrySartorialCapstoneDataSet)

    End Sub

    Private Sub VenInForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LarrySartorialCapstoneDataSet.Vendor_Invoices' table. You can move, or remove it, as needed.
        Me.Vendor_InvoicesTableAdapter.Fill(Me.LarrySartorialCapstoneDataSet.Vendor_Invoices)

    End Sub
End Class
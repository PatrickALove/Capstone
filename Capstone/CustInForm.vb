Public Class CustInForm
    Private Sub Customer_InvoiceBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Customer_InvoiceBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Customer_InvoiceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LarrySartorialCapstoneDataSet)

    End Sub

    Private Sub CustInForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LarrySartorialCapstoneDataSet.Customer_Invoice' table. You can move, or remove it, as needed.
        Me.Customer_InvoiceTableAdapter.Fill(Me.LarrySartorialCapstoneDataSet.Customer_Invoice)

    End Sub
End Class
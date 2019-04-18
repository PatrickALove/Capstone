Public Class TransactionForm
    Private Sub TransactionsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TransactionsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TransactionsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LarrySartorialCapstoneDataSet)

    End Sub

    Private Sub TransactionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LarrySartorialCapstoneDataSet.Transactions' table. You can move, or remove it, as needed.
        Me.TransactionsTableAdapter.Fill(Me.LarrySartorialCapstoneDataSet.Transactions)

    End Sub
End Class
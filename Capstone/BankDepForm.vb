Public Class BankDepForm
    Private Sub Bank_DepositsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Bank_DepositsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Bank_DepositsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LarrySartorialCapstoneDataSet)

    End Sub

    Private Sub BankDepForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LarrySartorialCapstoneDataSet.Bank_Deposits' table. You can move, or remove it, as needed.
        Me.Bank_DepositsTableAdapter.Fill(Me.LarrySartorialCapstoneDataSet.Bank_Deposits)

    End Sub
End Class
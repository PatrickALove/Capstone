Public Class ComStForm
    Private Sub Commission_StatementsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Commission_StatementsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Commission_StatementsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LarrySartorialCapstoneDataSet)

    End Sub

    Private Sub ComStForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LarrySartorialCapstoneDataSet.Commission_Statements' table. You can move, or remove it, as needed.
        Me.Commission_StatementsTableAdapter.Fill(Me.LarrySartorialCapstoneDataSet.Commission_Statements)

    End Sub
End Class
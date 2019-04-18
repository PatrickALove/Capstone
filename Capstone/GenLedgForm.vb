Public Class GenLedgForm
    Private Sub General_LedgersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles General_LedgersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.General_LedgersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LarrySartorialCapstoneDataSet)

    End Sub

    Private Sub GenLedgForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LarrySartorialCapstoneDataSet.General_Ledgers' table. You can move, or remove it, as needed.
        Me.General_LedgersTableAdapter.Fill(Me.LarrySartorialCapstoneDataSet.General_Ledgers)

    End Sub
End Class
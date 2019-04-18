Public Class TicketsForm
    Private Sub Register_TicketsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Register_TicketsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Register_TicketsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LarrySartorialCapstoneDataSet)

    End Sub

    Private Sub TicketsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LarrySartorialCapstoneDataSet.Register_Tickets' table. You can move, or remove it, as needed.
        Me.Register_TicketsTableAdapter.Fill(Me.LarrySartorialCapstoneDataSet.Register_Tickets)

    End Sub
End Class
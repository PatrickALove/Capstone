Public Class PayForm
    Private Sub PayrollBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PayrollBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PayrollBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LarrySartorialCapstoneDataSet)

    End Sub

    Private Sub PayForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LarrySartorialCapstoneDataSet.Payroll' table. You can move, or remove it, as needed.
        Me.PayrollTableAdapter.Fill(Me.LarrySartorialCapstoneDataSet.Payroll)

    End Sub
End Class
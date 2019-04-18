Public Class EmpForm
    Private Sub Employee_InformationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Employee_InformationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Employee_InformationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LarrySartorialCapstoneDataSet)

    End Sub

    Private Sub EmpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LarrySartorialCapstoneDataSet.Employee_Information' table. You can move, or remove it, as needed.
        Me.Employee_InformationTableAdapter.Fill(Me.LarrySartorialCapstoneDataSet.Employee_Information)

    End Sub
End Class
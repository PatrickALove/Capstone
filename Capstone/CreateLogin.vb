Public Class CreateLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        My.Settings.Username = txtCreatePassword.Text
        My.Settings.Password = txtCreatePassword.Text
        My.Settings.Save()
        MsgBox("Your Account was created Successfully", MsgBoxStyle.Information, "Account Created")
        Me.Hide()
        LoginForm1.Show()
    End Sub


    Private Sub BtnBackToLogin_Click(sender As Object, e As EventArgs) Handles btnBackToLogin.Click
        Me.Hide()
        LoginForm1.Show()
    End Sub
End Class

Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = My.Settings.Username And
                PasswordTextBox.Text = My.Settings.Password Then
            Application.DoEvents()
            Me.Hide()
            MainScreen.Show()
        Else
            MsgBox("Incorrect Username or Password", MsgBoxStyle.Information, "Error")

        End If
        'Me.Close()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub CreateLL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CreateLL.LinkClicked
        Me.Hide()
        CreateLogin.Show()
    End Sub
End Class

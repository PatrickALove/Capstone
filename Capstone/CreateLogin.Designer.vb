<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class CreateLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateLogin))
        Me.btnBackToLogin = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.txtCreatePassword = New System.Windows.Forms.TextBox()
        Me.txtCreateUsername = New System.Windows.Forms.TextBox()
        Me.lblCreatePassword = New System.Windows.Forms.Label()
        Me.lblCreateUsername = New System.Windows.Forms.Label()
        Me.lblCreateAcctPrompt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBackToLogin
        '
        Me.btnBackToLogin.BackColor = System.Drawing.Color.DimGray
        Me.btnBackToLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBackToLogin.Location = New System.Drawing.Point(857, 243)
        Me.btnBackToLogin.Name = "btnBackToLogin"
        Me.btnBackToLogin.Size = New System.Drawing.Size(94, 23)
        Me.btnBackToLogin.TabIndex = 11
        Me.btnBackToLogin.Text = "&Cancel"
        Me.btnBackToLogin.UseVisualStyleBackColor = False
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.DimGray
        Me.btnCreate.Location = New System.Drawing.Point(754, 243)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(94, 23)
        Me.btnCreate.TabIndex = 10
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'txtCreatePassword
        '
        Me.txtCreatePassword.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCreatePassword.Location = New System.Drawing.Point(747, 208)
        Me.txtCreatePassword.Name = "txtCreatePassword"
        Me.txtCreatePassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCreatePassword.Size = New System.Drawing.Size(220, 20)
        Me.txtCreatePassword.TabIndex = 9
        '
        'txtCreateUsername
        '
        Me.txtCreateUsername.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCreateUsername.Location = New System.Drawing.Point(747, 151)
        Me.txtCreateUsername.Name = "txtCreateUsername"
        Me.txtCreateUsername.Size = New System.Drawing.Size(220, 20)
        Me.txtCreateUsername.TabIndex = 7
        '
        'lblCreatePassword
        '
        Me.lblCreatePassword.BackColor = System.Drawing.Color.Transparent
        Me.lblCreatePassword.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreatePassword.Location = New System.Drawing.Point(745, 188)
        Me.lblCreatePassword.Name = "lblCreatePassword"
        Me.lblCreatePassword.Size = New System.Drawing.Size(220, 23)
        Me.lblCreatePassword.TabIndex = 8
        Me.lblCreatePassword.Text = "&Password"
        Me.lblCreatePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCreateUsername
        '
        Me.lblCreateUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblCreateUsername.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateUsername.Location = New System.Drawing.Point(745, 131)
        Me.lblCreateUsername.Name = "lblCreateUsername"
        Me.lblCreateUsername.Size = New System.Drawing.Size(220, 23)
        Me.lblCreateUsername.TabIndex = 6
        Me.lblCreateUsername.Text = "&User name"
        Me.lblCreateUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCreateAcctPrompt
        '
        Me.lblCreateAcctPrompt.AutoSize = True
        Me.lblCreateAcctPrompt.BackColor = System.Drawing.Color.Transparent
        Me.lblCreateAcctPrompt.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateAcctPrompt.Location = New System.Drawing.Point(671, 46)
        Me.lblCreateAcctPrompt.Name = "lblCreateAcctPrompt"
        Me.lblCreateAcctPrompt.Size = New System.Drawing.Size(366, 31)
        Me.lblCreateAcctPrompt.TabIndex = 12
        Me.lblCreateAcctPrompt.Text = "CREATE NEW ACCOUNT:"
        '
        'CreateLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1074, 549)
        Me.Controls.Add(Me.lblCreateAcctPrompt)
        Me.Controls.Add(Me.btnBackToLogin)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.txtCreatePassword)
        Me.Controls.Add(Me.txtCreateUsername)
        Me.Controls.Add(Me.lblCreatePassword)
        Me.Controls.Add(Me.lblCreateUsername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreateLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CreateLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBackToLogin As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents txtCreatePassword As TextBox
    Friend WithEvents txtCreateUsername As TextBox
    Friend WithEvents lblCreatePassword As Label
    Friend WithEvents lblCreateUsername As Label
    Friend WithEvents lblCreateAcctPrompt As Label
End Class

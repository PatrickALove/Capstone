<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainScreen
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainScreen))
        Me.cmbTableChoice = New System.Windows.Forms.ComboBox()
        Me.lblChooseTable = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbTableChoice
        '
        Me.cmbTableChoice.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbTableChoice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbTableChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTableChoice.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTableChoice.ForeColor = System.Drawing.Color.Black
        Me.cmbTableChoice.FormattingEnabled = True
        Me.cmbTableChoice.Items.AddRange(New Object() {"Bank Deposits", "Commission Statements", "Customer Invoice", "Customers", "Employee Information", "General Ledgers", "Inventory", "Inventory Report", "Inventory Items", "Payroll", "Suppliers", "Tickets from Register", "Transactions", "Vendor Invoice", "Vendor Data Card"})
        Me.cmbTableChoice.Location = New System.Drawing.Point(441, 193)
        Me.cmbTableChoice.Name = "cmbTableChoice"
        Me.cmbTableChoice.Size = New System.Drawing.Size(234, 29)
        Me.cmbTableChoice.TabIndex = 1
        '
        'lblChooseTable
        '
        Me.lblChooseTable.AutoSize = True
        Me.lblChooseTable.BackColor = System.Drawing.Color.Transparent
        Me.lblChooseTable.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChooseTable.ForeColor = System.Drawing.Color.Black
        Me.lblChooseTable.Location = New System.Drawing.Point(437, 169)
        Me.lblChooseTable.Name = "lblChooseTable"
        Me.lblChooseTable.Size = New System.Drawing.Size(244, 21)
        Me.lblChooseTable.TabIndex = 2
        Me.lblChooseTable.Text = "Choose the table to display"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DimGray
        Me.btnExit.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(504, 270)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(109, 45)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'MainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1136, 619)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblChooseTable)
        Me.Controls.Add(Me.cmbTableChoice)
        Me.Name = "MainScreen"
        Me.Text = "MainScreen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbTableChoice As ComboBox
    Friend WithEvents lblChooseTable As Label
    Friend WithEvents btnExit As Button
End Class

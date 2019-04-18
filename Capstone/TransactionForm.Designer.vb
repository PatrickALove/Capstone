<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransactionForm))
        Dim IDLabel As System.Windows.Forms.Label
        Dim CustomerLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim Employee_IDLabel As System.Windows.Forms.Label
        Dim Paid_with_CashLabel As System.Windows.Forms.Label
        Dim Item_IDLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim SubTotalLabel As System.Windows.Forms.Label
        Dim Sales_TaxLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Me.LarrySartorialCapstoneDataSet = New Capstone.LarrySartorialCapstoneDataSet()
        Me.TransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransactionsTableAdapter = New Capstone.LarrySartorialCapstoneDataSetTableAdapters.TransactionsTableAdapter()
        Me.TableAdapterManager = New Capstone.LarrySartorialCapstoneDataSetTableAdapters.TableAdapterManager()
        Me.TransactionsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.TransactionsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Employee_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Paid_with_CashCheckBox = New System.Windows.Forms.CheckBox()
        Me.Item_IDTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.SubTotalTextBox = New System.Windows.Forms.TextBox()
        Me.Sales_TaxTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        CustomerLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        Employee_IDLabel = New System.Windows.Forms.Label()
        Paid_with_CashLabel = New System.Windows.Forms.Label()
        Item_IDLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        SubTotalLabel = New System.Windows.Forms.Label()
        Sales_TaxLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        CType(Me.LarrySartorialCapstoneDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TransactionsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'LarrySartorialCapstoneDataSet
        '
        Me.LarrySartorialCapstoneDataSet.DataSetName = "LarrySartorialCapstoneDataSet"
        Me.LarrySartorialCapstoneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TransactionsBindingSource
        '
        Me.TransactionsBindingSource.DataMember = "Transactions"
        Me.TransactionsBindingSource.DataSource = Me.LarrySartorialCapstoneDataSet
        '
        'TransactionsTableAdapter
        '
        Me.TransactionsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Bank_DepositsTableAdapter = Nothing
        Me.TableAdapterManager.Commission_StatementsTableAdapter = Nothing
        Me.TableAdapterManager.Customer_InvoiceTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.Employee_InformationTableAdapter = Nothing
        Me.TableAdapterManager.General_LedgersTableAdapter = Nothing
        Me.TableAdapterManager.Inventory_ReportsTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableAdapter = Nothing
        Me.TableAdapterManager.ItemsTableAdapter = Nothing
        Me.TableAdapterManager.PayrollTableAdapter = Nothing
        Me.TableAdapterManager.Register_TicketsTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.TransactionsTableAdapter = Me.TransactionsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Capstone.LarrySartorialCapstoneDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Vendor_InvoicesTableAdapter = Nothing
        Me.TableAdapterManager.VendorsTableAdapter = Nothing
        '
        'TransactionsBindingNavigator
        '
        Me.TransactionsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TransactionsBindingNavigator.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TransactionsBindingNavigator.BackgroundImage = CType(resources.GetObject("TransactionsBindingNavigator.BackgroundImage"), System.Drawing.Image)
        Me.TransactionsBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TransactionsBindingNavigator.BindingSource = Me.TransactionsBindingSource
        Me.TransactionsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TransactionsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TransactionsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TransactionsBindingNavigatorSaveItem})
        Me.TransactionsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TransactionsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TransactionsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TransactionsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TransactionsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TransactionsBindingNavigator.Name = "TransactionsBindingNavigator"
        Me.TransactionsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TransactionsBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.TransactionsBindingNavigator.TabIndex = 0
        Me.TransactionsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'TransactionsBindingNavigatorSaveItem
        '
        Me.TransactionsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TransactionsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TransactionsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TransactionsBindingNavigatorSaveItem.Name = "TransactionsBindingNavigatorSaveItem"
        Me.TransactionsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.TransactionsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(89, 79)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionsBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(175, 76)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'CustomerLabel
        '
        CustomerLabel.AutoSize = True
        CustomerLabel.Location = New System.Drawing.Point(89, 105)
        CustomerLabel.Name = "CustomerLabel"
        CustomerLabel.Size = New System.Drawing.Size(54, 13)
        CustomerLabel.TabIndex = 3
        CustomerLabel.Text = "Customer:"
        '
        'CustomerTextBox
        '
        Me.CustomerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionsBindingSource, "Customer", True))
        Me.CustomerTextBox.Location = New System.Drawing.Point(175, 102)
        Me.CustomerTextBox.Name = "CustomerTextBox"
        Me.CustomerTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CustomerTextBox.TabIndex = 4
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(89, 132)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(33, 13)
        DateLabel.TabIndex = 5
        DateLabel.Text = "Date:"
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TransactionsBindingSource, "Date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(175, 128)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateDateTimePicker.TabIndex = 6
        '
        'Employee_IDLabel
        '
        Employee_IDLabel.AutoSize = True
        Employee_IDLabel.Location = New System.Drawing.Point(89, 157)
        Employee_IDLabel.Name = "Employee_IDLabel"
        Employee_IDLabel.Size = New System.Drawing.Size(70, 13)
        Employee_IDLabel.TabIndex = 7
        Employee_IDLabel.Text = "Employee ID:"
        '
        'Employee_IDTextBox
        '
        Me.Employee_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionsBindingSource, "Employee_ID", True))
        Me.Employee_IDTextBox.Location = New System.Drawing.Point(175, 154)
        Me.Employee_IDTextBox.Name = "Employee_IDTextBox"
        Me.Employee_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Employee_IDTextBox.TabIndex = 8
        '
        'Paid_with_CashLabel
        '
        Paid_with_CashLabel.AutoSize = True
        Paid_with_CashLabel.Location = New System.Drawing.Point(89, 185)
        Paid_with_CashLabel.Name = "Paid_with_CashLabel"
        Paid_with_CashLabel.Size = New System.Drawing.Size(80, 13)
        Paid_with_CashLabel.TabIndex = 9
        Paid_with_CashLabel.Text = "Paid with Cash:"
        '
        'Paid_with_CashCheckBox
        '
        Me.Paid_with_CashCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TransactionsBindingSource, "Paid with Cash", True))
        Me.Paid_with_CashCheckBox.Location = New System.Drawing.Point(175, 180)
        Me.Paid_with_CashCheckBox.Name = "Paid_with_CashCheckBox"
        Me.Paid_with_CashCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.Paid_with_CashCheckBox.TabIndex = 10
        Me.Paid_with_CashCheckBox.Text = "CheckBox1"
        Me.Paid_with_CashCheckBox.UseVisualStyleBackColor = True
        '
        'Item_IDLabel
        '
        Item_IDLabel.AutoSize = True
        Item_IDLabel.Location = New System.Drawing.Point(89, 213)
        Item_IDLabel.Name = "Item_IDLabel"
        Item_IDLabel.Size = New System.Drawing.Size(44, 13)
        Item_IDLabel.TabIndex = 11
        Item_IDLabel.Text = "Item ID:"
        '
        'Item_IDTextBox
        '
        Me.Item_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionsBindingSource, "Item_ID", True))
        Me.Item_IDTextBox.Location = New System.Drawing.Point(175, 210)
        Me.Item_IDTextBox.Name = "Item_IDTextBox"
        Me.Item_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Item_IDTextBox.TabIndex = 12
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Location = New System.Drawing.Point(89, 239)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(49, 13)
        QuantityLabel.TabIndex = 13
        QuantityLabel.Text = "Quantity:"
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionsBindingSource, "Quantity", True))
        Me.QuantityTextBox.Location = New System.Drawing.Point(175, 236)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(200, 20)
        Me.QuantityTextBox.TabIndex = 14
        '
        'SubTotalLabel
        '
        SubTotalLabel.AutoSize = True
        SubTotalLabel.Location = New System.Drawing.Point(89, 265)
        SubTotalLabel.Name = "SubTotalLabel"
        SubTotalLabel.Size = New System.Drawing.Size(56, 13)
        SubTotalLabel.TabIndex = 15
        SubTotalLabel.Text = "Sub Total:"
        '
        'SubTotalTextBox
        '
        Me.SubTotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionsBindingSource, "SubTotal", True))
        Me.SubTotalTextBox.Location = New System.Drawing.Point(175, 262)
        Me.SubTotalTextBox.Name = "SubTotalTextBox"
        Me.SubTotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SubTotalTextBox.TabIndex = 16
        '
        'Sales_TaxLabel
        '
        Sales_TaxLabel.AutoSize = True
        Sales_TaxLabel.Location = New System.Drawing.Point(89, 291)
        Sales_TaxLabel.Name = "Sales_TaxLabel"
        Sales_TaxLabel.Size = New System.Drawing.Size(57, 13)
        Sales_TaxLabel.TabIndex = 17
        Sales_TaxLabel.Text = "Sales Tax:"
        '
        'Sales_TaxTextBox
        '
        Me.Sales_TaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionsBindingSource, "Sales Tax", True))
        Me.Sales_TaxTextBox.Location = New System.Drawing.Point(175, 288)
        Me.Sales_TaxTextBox.Name = "Sales_TaxTextBox"
        Me.Sales_TaxTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Sales_TaxTextBox.TabIndex = 18
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(89, 317)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(34, 13)
        TotalLabel.TabIndex = 19
        TotalLabel.Text = "Total:"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionsBindingSource, "Total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(175, 314)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TotalTextBox.TabIndex = 20
        '
        'TransactionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(CustomerLabel)
        Me.Controls.Add(Me.CustomerTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(Employee_IDLabel)
        Me.Controls.Add(Me.Employee_IDTextBox)
        Me.Controls.Add(Paid_with_CashLabel)
        Me.Controls.Add(Me.Paid_with_CashCheckBox)
        Me.Controls.Add(Item_IDLabel)
        Me.Controls.Add(Me.Item_IDTextBox)
        Me.Controls.Add(QuantityLabel)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(SubTotalLabel)
        Me.Controls.Add(Me.SubTotalTextBox)
        Me.Controls.Add(Sales_TaxLabel)
        Me.Controls.Add(Me.Sales_TaxTextBox)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.TransactionsBindingNavigator)
        Me.Name = "TransactionForm"
        Me.Text = "TransactionForm"
        CType(Me.LarrySartorialCapstoneDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TransactionsBindingNavigator.ResumeLayout(False)
        Me.TransactionsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LarrySartorialCapstoneDataSet As LarrySartorialCapstoneDataSet
    Friend WithEvents TransactionsBindingSource As BindingSource
    Friend WithEvents TransactionsTableAdapter As LarrySartorialCapstoneDataSetTableAdapters.TransactionsTableAdapter
    Friend WithEvents TableAdapterManager As LarrySartorialCapstoneDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TransactionsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TransactionsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents CustomerTextBox As TextBox
    Friend WithEvents DateDateTimePicker As DateTimePicker
    Friend WithEvents Employee_IDTextBox As TextBox
    Friend WithEvents Paid_with_CashCheckBox As CheckBox
    Friend WithEvents Item_IDTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents SubTotalTextBox As TextBox
    Friend WithEvents Sales_TaxTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
End Class

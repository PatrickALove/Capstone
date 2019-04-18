<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicketsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TicketsForm))
        Me.LarrySartorialCapstoneDataSet = New Capstone.LarrySartorialCapstoneDataSet()
        Me.Register_TicketsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Register_TicketsTableAdapter = New Capstone.LarrySartorialCapstoneDataSetTableAdapters.Register_TicketsTableAdapter()
        Me.TableAdapterManager = New Capstone.LarrySartorialCapstoneDataSetTableAdapters.TableAdapterManager()
        Me.Register_TicketsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Register_TicketsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Register_TicketsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.LarrySartorialCapstoneDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Register_TicketsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Register_TicketsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Register_TicketsBindingNavigator.SuspendLayout()
        CType(Me.Register_TicketsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LarrySartorialCapstoneDataSet
        '
        Me.LarrySartorialCapstoneDataSet.DataSetName = "LarrySartorialCapstoneDataSet"
        Me.LarrySartorialCapstoneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Register_TicketsBindingSource
        '
        Me.Register_TicketsBindingSource.DataMember = "Register Tickets"
        Me.Register_TicketsBindingSource.DataSource = Me.LarrySartorialCapstoneDataSet
        '
        'Register_TicketsTableAdapter
        '
        Me.Register_TicketsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Register_TicketsTableAdapter = Me.Register_TicketsTableAdapter
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.TransactionsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Capstone.LarrySartorialCapstoneDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Vendor_InvoicesTableAdapter = Nothing
        Me.TableAdapterManager.VendorsTableAdapter = Nothing
        '
        'Register_TicketsBindingNavigator
        '
        Me.Register_TicketsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Register_TicketsBindingNavigator.BindingSource = Me.Register_TicketsBindingSource
        Me.Register_TicketsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Register_TicketsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Register_TicketsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Register_TicketsBindingNavigatorSaveItem})
        Me.Register_TicketsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Register_TicketsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Register_TicketsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Register_TicketsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Register_TicketsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Register_TicketsBindingNavigator.Name = "Register_TicketsBindingNavigator"
        Me.Register_TicketsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Register_TicketsBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.Register_TicketsBindingNavigator.TabIndex = 0
        Me.Register_TicketsBindingNavigator.Text = "BindingNavigator1"
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
        'Register_TicketsBindingNavigatorSaveItem
        '
        Me.Register_TicketsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Register_TicketsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Register_TicketsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Register_TicketsBindingNavigatorSaveItem.Name = "Register_TicketsBindingNavigatorSaveItem"
        Me.Register_TicketsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Register_TicketsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Register_TicketsDataGridView
        '
        Me.Register_TicketsDataGridView.AutoGenerateColumns = False
        Me.Register_TicketsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Register_TicketsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Register_TicketsDataGridView.DataSource = Me.Register_TicketsBindingSource
        Me.Register_TicketsDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.Register_TicketsDataGridView.Name = "Register_TicketsDataGridView"
        Me.Register_TicketsDataGridView.Size = New System.Drawing.Size(776, 440)
        Me.Register_TicketsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Receipt_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Receipt_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Register Number"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Register Number"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Transaction"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Transaction"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'TicketsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 480)
        Me.Controls.Add(Me.Register_TicketsDataGridView)
        Me.Controls.Add(Me.Register_TicketsBindingNavigator)
        Me.Name = "TicketsForm"
        Me.Text = "TicketsForm"
        CType(Me.LarrySartorialCapstoneDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Register_TicketsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Register_TicketsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Register_TicketsBindingNavigator.ResumeLayout(False)
        Me.Register_TicketsBindingNavigator.PerformLayout()
        CType(Me.Register_TicketsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LarrySartorialCapstoneDataSet As LarrySartorialCapstoneDataSet
    Friend WithEvents Register_TicketsBindingSource As BindingSource
    Friend WithEvents Register_TicketsTableAdapter As LarrySartorialCapstoneDataSetTableAdapters.Register_TicketsTableAdapter
    Friend WithEvents TableAdapterManager As LarrySartorialCapstoneDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Register_TicketsBindingNavigator As BindingNavigator
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
    Friend WithEvents Register_TicketsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Register_TicketsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class

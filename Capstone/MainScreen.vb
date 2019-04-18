Public Class MainScreen


    Dim EmployeesInformationForm As New EmpForm
    Dim CustomersForm As New CustForm
    Dim ItemsForm As New InvItemForm
    Dim SuppliersForm As New SuppliForm
    Dim VendorsInvoiceForm As New VenInForm
    Dim BankDepositsForm As New BankDepForm
    Dim CommisionStatementsForm As New ComStForm
    Dim CustomerInvoiceForm As New CustInForm
    Dim CustomersExtendedForm As New CustExForm
    Dim InventoryReportForm As New InvRepForm
    Dim PayrollForm As New PayForm
    Dim Transaction As New TransactionForm
    Dim TimeCardForm As New TimeCarForm
    Dim VendorDataCard As New VenDatCaForm
    Dim GetHoursWOrked As New GetHourForm
    Dim GenLedg As New GenLedgForm
    Dim Inv As New InvForm
    Dim Tickets As New TicketsForm
    Private Sub CmbTableChoice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTableChoice.SelectedIndexChanged
        '* If the user selects a table...based on what they choose, display the corresponding table


        If cmbTableChoice.SelectedItem = "Bank Deposits" Then
            BankDepositsForm = New BankDepForm

            BankDepositsForm.Show()
            BankDepositsForm.Activate()
        End If
        If cmbTableChoice.SelectedItem = "Commission Statements" Then
            CommisionStatementsForm.Show()
            CommisionStatementsForm.Activate()
        End If
        If cmbTableChoice.SelectedItem = "Customer Invoice" Then
            CustomerInvoiceForm.Show()
            CustomerInvoiceForm.Activate()
        End If
        If cmbTableChoice.SelectedItem = "Customers" Then
            CustomersForm.Show()
            CustomersForm.Activate()
        End If
        If cmbTableChoice.SelectedItem = "Customers Extended" Then
            CustomersExtendedForm.Show()
            CustomersExtendedForm.Activate()
        End If
        If cmbTableChoice.SelectedItem = "Employee Information" Then
            EmployeesInformationForm.Show()
            EmployeesInformationForm.Activate()
        End If
        If cmbTableChoice.SelectedItem = "Get Hours Worked" Then
            GetHoursWOrked.Show()
            GetHoursWOrked.Activate()
        End If
        If cmbTableChoice.SelectedItem = "Inventory Items" Then
            ItemsForm.Show()
            ItemsForm.Activate()
        End If
        If cmbTableChoice.SelectedItem = "Inventory Report" Then
            InventoryReportForm.Show()
            InventoryReportForm.Activate()
        End If
        If cmbTableChoice.SelectedItem = "Payroll" Then
            PayrollForm.Show()
            PayrollForm.Activate()
        End If
        If cmbTableChoice.SelectedItem = "Transactions" Then
            TransactionForm.Show()
            TransactionForm.Activate()
        End If
        If cmbTableChoice.SelectedItem = "Suppliers" Then
            SuppliersForm.Show()
            SuppliersForm.Activate()
        End If
        If cmbTableChoice.SelectedItem = "Time Cards" Then
            TimeCardForm.Show()
            TimeCardForm.Activate()
        End If
        If cmbTableChoice.SelectedItem = "Vendor Data Card" Then
            VendorDataCard.Show()
            VendorDataCard.Activate()
        End If
        If cmbTableChoice.SelectedItem = "Vendor Invoice" Then
            VendorsInvoiceForm.Show()
            VendorsInvoiceForm.Activate()
        End If
        If cmbTableChoice.SelectedItem = "General Ledgers" Then
            GenLedgForm.Show()
            GenLedgForm.Activate()
        End If
        If cmbTableChoice.SelectedItem = "Inventory" Then
            InvForm.Show()
            InvForm.Activate()
        End If
        If cmbTableChoice.SelectedItem = "Tickets from Register" Then
            TicketsForm.Show()
            TicketsForm.Activate()
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.DoEvents()
        MsgBox("The Application will now close", MsgBoxStyle.Exclamation, "Goodbye")
        Close()
    End Sub
End Class
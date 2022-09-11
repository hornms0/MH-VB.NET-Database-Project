Imports System.Data.SqlClient

Public Class frmCustomers
    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomersBindingNavigatorSaveItem.Click

        'Validation
        Me.Validate()
        If Me.runValidatorVB() = False Then
            Exit Sub
        End If

        'Try block from 14-2
        Try
            'Tries to update database file
            Me.CustomersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MMABooksDataSet)
            'Confirmation window on success
            MessageBox.Show("Update successful", "Info", MessageBoxButtons.OK)
        Catch ex As DataException
            'Cancels edit if data is of the wrong datatype (?)
            MessageBox.Show(ex.Message, ex.GetType.ToString)
            CustomersBindingSource.CancelEdit()
        Catch ex As SqlException
            'Throws generic message for general exceptions
            MessageBox.Show("Database error # " & ex.Number & ": " & ex.Message, ex.GetType.ToString)
        End Try

    End Sub

    Private Sub frmCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Fill state combo box
        Me.StatesTableAdapter.Fill(Me.MMABooksDataSet.States)
        cboState.SelectedIndex = -1
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles btnGetCustomer.Click
        'Runs query to get customer by customerID
        Try
            Me.CustomersTableAdapter.FillBy(Me.MMABooksDataSet.Customers, CType(CustomerIDToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnInvoices_Click(sender As Object, e As EventArgs) Handles btnInvoices.Click
        'If the name textbox is empty assume a customer hasnt been selected and leave sub
        If txtName.Text = "" Then
            MessageBox.Show("Load a customer to view invoices", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'Create a new invoice form with customer ID and name
        Dim newInvoiceForm As New frmInvoices
        newInvoiceForm.selectedCustomerID = txtID.Text
        newInvoiceForm.selectedCustomerName = txtName.Text
        newInvoiceForm.MdiParent = frmMain
        newInvoiceForm.Show()
    End Sub

    ''' <summary>
    ''' Returns false if any field is blank
    ''' </summary>
    Private Function runValidatorVB() As Boolean
        'Used the code from 16-1 to run validator statements
        'Validator is also from 16-1 because it accepts a combo box as an argument
        Return _
    Validator.IsPresent(txtName) AndAlso
    Validator.IsPresent(txtAddress) AndAlso
    Validator.IsPresent(txtCity) AndAlso
    Validator.IsPresent(cboState) AndAlso
    Validator.IsPresent(txtZip)

    End Function

    Private Sub frmCustomers_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Empties status bar when closing
        frmMain.sbInfo.Text = ""
    End Sub

    Private Sub frmCustomers_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'Fills status bar when active
        frmMain.sbInfo.Text = "Customer Maintenance"
    End Sub
End Class
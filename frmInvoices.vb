Imports System.Data.SqlClient

Public Class frmInvoices

    'Variables sent from customer form
    Public selectedCustomerID As String
    Public selectedCustomerName As String


    Private Sub frmInvoices_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Sets label based on customer name
        lblCustomer.Text = "Invoices for " & selectedCustomerName

        'Load invoice records for customer
        'Runs query based on customer ID
        Try
            Me.InvoicesTableAdapter.FillBy(Me.MMABooksDataSet.Invoices, CType(selectedCustomerID, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmInvoices_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Empties status bar when closing
        frmMain.sbInfo.Text = ""
    End Sub

    Private Sub frmInvoices_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'Fills status bar when active
        frmMain.sbInfo.Text = "Invoices for " & selectedCustomerName

    End Sub
End Class
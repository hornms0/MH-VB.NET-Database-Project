Imports System.Data.SqlClient

Public Class frmProducts
    Private Sub ProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductsBindingNavigatorSaveItem.Click

        'Validation
        Me.Validate()

        'Try block from 14-2
        Try
            'Tries to update database file
            Me.ProductsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MMABooksDataSet)
            'Confirmation window on success
            MessageBox.Show("Update successful", "Info", MessageBoxButtons.OK)
        Catch ex As DataException
            'Cancels edit if data is of the wrong datatype (?)
            MessageBox.Show(ex.Message, ex.GetType.ToString)
            ProductsBindingSource.CancelEdit()
        Catch ex As SqlException
            'Throws generic message for general exceptions
            MessageBox.Show("Database error # " & ex.Number & ": " & ex.Message, ex.GetType.ToString)
        End Try

    End Sub

    Private Sub frmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMABooksDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.MMABooksDataSet.Products)
    End Sub

    Private Sub ProductsDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles ProductsDataGridView.DataError
        'From 14-1
        'page 501
        'Create messagebox that reports the exception type and row 
        Dim row As Integer = e.RowIndex + 1
        Dim errorMessage As String = "A data error occured. " & vbCrLf &
                                        "Row: " & row & vbCrLf &
                                        "Error: " & e.Exception.Message
        MessageBox.Show(errorMessage, "Data Error")
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Reload the database to cancel edits
        Me.ProductsTableAdapter.Fill(Me.MMABooksDataSet.Products)
    End Sub

    Private Sub frmProducts_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Empties status bar when closing
        frmMain.sbInfo.Text = ""
    End Sub

    Private Sub frmProducts_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'Fills status bar when active
        frmMain.sbInfo.Text = "Product Maintenance"
    End Sub


End Class
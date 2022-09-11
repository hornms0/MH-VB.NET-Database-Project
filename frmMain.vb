Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Loads status bar info as blank
        sbInfo.Text = ""
    End Sub

    Private Sub btnCustomerForm_Click(sender As Object, e As EventArgs) Handles btnCustomerForm.Click, mnuNewCustomerForm.Click
        'Create a new customer form from the menu or toolbar button
        Dim newCustomerForm As New frmCustomers
        newCustomerForm.MdiParent = Me
        newCustomerForm.Show()
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click, mnuNewProductForm.Click
        'Create a new product form from the menu or toolbar button
        Dim newProductForm As New frmProducts
        newProductForm.MdiParent = Me
        newProductForm.Show()
    End Sub

    Private Sub ToolbarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuToolbar.Click
        'Toggle toolbar visibility based on checked status of toolbar menu item
        tsMain.Visible = mnuToolbar.Checked
    End Sub

    Private Sub mnuCloseForm_Click(sender As Object, e As EventArgs) Handles mnuCloseForm.Click
        'Close active form window
        Dim activeChild As Form = Me.ActiveMdiChild
        If activeChild IsNot Nothing Then
            activeChild.Close()
        End If
    End Sub
    Private Sub mainTimer_Tick(sender As Object, e As EventArgs) Handles mainTimer.Tick
        'Set date and time labels when timer ticks
        sbMain.Items("sbDate").Text = Today.ToShortDateString
        sbMain.Items("sbTime").Text = Now.ToLongTimeString
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        'Create about form
        Dim newAboutForm As New frmAbout
        newAboutForm.MdiParent = Me
        newAboutForm.Show()
    End Sub

    'MDI layout options 
    Private Sub mnuWindowCascade_Click(sender As Object, e As EventArgs) Handles mnuWindowCascade.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub
    Private Sub mnuWindowVertical_Click(sender As Object, e As EventArgs) Handles mnuWindowVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub
    Private Sub mnuWindowHorizontal_Click(sender As Object, e As EventArgs) Handles mnuWindowHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub



End Class

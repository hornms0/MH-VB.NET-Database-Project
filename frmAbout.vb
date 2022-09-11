Public Class frmAbout

    Private Sub frmAbout_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Empties status bar when closing
        frmMain.sbInfo.Text = ""
    End Sub

    Private Sub frmAbout_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'Fills status bar when active
        frmMain.sbInfo.Text = "About"
    End Sub

End Class
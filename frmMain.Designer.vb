<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.btnCustomerForm = New System.Windows.Forms.ToolStripButton()
        Me.btnProducts = New System.Windows.Forms.ToolStripButton()
        Me.msMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNewCustomerForm = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNewProductForm = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCloseForm = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuToolbar = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.sbMain = New System.Windows.Forms.StatusStrip()
        Me.sbDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sbInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sbTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mainTimer = New System.Windows.Forms.Timer(Me.components)
        Me.tsMain.SuspendLayout()
        Me.msMain.SuspendLayout()
        Me.sbMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsMain
        '
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCustomerForm, Me.btnProducts})
        Me.tsMain.Location = New System.Drawing.Point(0, 24)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(1058, 25)
        Me.tsMain.TabIndex = 1
        Me.tsMain.Text = "ToolStrip1"
        '
        'btnCustomerForm
        '
        Me.btnCustomerForm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnCustomerForm.Image = CType(resources.GetObject("btnCustomerForm.Image"), System.Drawing.Image)
        Me.btnCustomerForm.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCustomerForm.Name = "btnCustomerForm"
        Me.btnCustomerForm.Size = New System.Drawing.Size(68, 22)
        Me.btnCustomerForm.Text = "Customers"
        '
        'btnProducts
        '
        Me.btnProducts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnProducts.Image = CType(resources.GetObject("btnProducts.Image"), System.Drawing.Image)
        Me.btnProducts.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Size = New System.Drawing.Size(58, 22)
        Me.btnProducts.Text = "Products"
        '
        'msMain
        '
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.WindowsToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.msMain.Location = New System.Drawing.Point(0, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.Size = New System.Drawing.Size(1058, 24)
        Me.msMain.TabIndex = 2
        Me.msMain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewCustomerForm, Me.mnuNewProductForm, Me.mnuCloseForm, Me.ToolStripMenuItem1, Me.mnuExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'mnuNewCustomerForm
        '
        Me.mnuNewCustomerForm.Name = "mnuNewCustomerForm"
        Me.mnuNewCustomerForm.Size = New System.Drawing.Size(184, 22)
        Me.mnuNewCustomerForm.Text = "New Customer Form"
        '
        'mnuNewProductForm
        '
        Me.mnuNewProductForm.Name = "mnuNewProductForm"
        Me.mnuNewProductForm.Size = New System.Drawing.Size(184, 22)
        Me.mnuNewProductForm.Text = "New Product Form"
        '
        'mnuCloseForm
        '
        Me.mnuCloseForm.Name = "mnuCloseForm"
        Me.mnuCloseForm.Size = New System.Drawing.Size(184, 22)
        Me.mnuCloseForm.Text = "Close Form"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(181, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(184, 22)
        Me.mnuExit.Text = "Exit"
        '
        'WindowsToolStripMenuItem
        '
        Me.WindowsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuWindowCascade, Me.mnuWindowVertical, Me.mnuWindowHorizontal})
        Me.WindowsToolStripMenuItem.Name = "WindowsToolStripMenuItem"
        Me.WindowsToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.WindowsToolStripMenuItem.Text = "Windows"
        '
        'mnuWindowCascade
        '
        Me.mnuWindowCascade.Name = "mnuWindowCascade"
        Me.mnuWindowCascade.Size = New System.Drawing.Size(150, 22)
        Me.mnuWindowCascade.Text = "Cascade"
        '
        'mnuWindowVertical
        '
        Me.mnuWindowVertical.Name = "mnuWindowVertical"
        Me.mnuWindowVertical.Size = New System.Drawing.Size(150, 22)
        Me.mnuWindowVertical.Text = "Tile Vertical"
        '
        'mnuWindowHorizontal
        '
        Me.mnuWindowHorizontal.Name = "mnuWindowHorizontal"
        Me.mnuWindowHorizontal.Size = New System.Drawing.Size(150, 22)
        Me.mnuWindowHorizontal.Text = "Tile Horizontal"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuToolbar})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'mnuToolbar
        '
        Me.mnuToolbar.Checked = True
        Me.mnuToolbar.CheckOnClick = True
        Me.mnuToolbar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuToolbar.Name = "mnuToolbar"
        Me.mnuToolbar.Size = New System.Drawing.Size(113, 22)
        Me.mnuToolbar.Text = "Toolbar"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(180, 22)
        Me.mnuAbout.Text = "About"
        '
        'sbMain
        '
        Me.sbMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sbDate, Me.sbInfo, Me.sbTime})
        Me.sbMain.Location = New System.Drawing.Point(0, 635)
        Me.sbMain.Name = "sbMain"
        Me.sbMain.Size = New System.Drawing.Size(1058, 24)
        Me.sbMain.TabIndex = 3
        Me.sbMain.Text = "StatusStrip1"
        '
        'sbDate
        '
        Me.sbDate.AutoSize = False
        Me.sbDate.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.sbDate.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.sbDate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.sbDate.Name = "sbDate"
        Me.sbDate.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.sbDate.Size = New System.Drawing.Size(75, 19)
        Me.sbDate.Text = " Date"
        '
        'sbInfo
        '
        Me.sbInfo.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.sbInfo.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.sbInfo.Name = "sbInfo"
        Me.sbInfo.Size = New System.Drawing.Size(893, 19)
        Me.sbInfo.Spring = True
        Me.sbInfo.Text = "Info"
        '
        'sbTime
        '
        Me.sbTime.AutoSize = False
        Me.sbTime.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.sbTime.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.sbTime.Name = "sbTime"
        Me.sbTime.Size = New System.Drawing.Size(75, 19)
        Me.sbTime.Text = " Time"
        '
        'mainTimer
        '
        Me.mainTimer.Enabled = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 659)
        Me.Controls.Add(Me.sbMain)
        Me.Controls.Add(Me.tsMain)
        Me.Controls.Add(Me.msMain)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.msMain
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buffalo State Bookstore"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        Me.msMain.ResumeLayout(False)
        Me.msMain.PerformLayout()
        Me.sbMain.ResumeLayout(False)
        Me.sbMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsMain As ToolStrip
    Friend WithEvents msMain As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents sbMain As StatusStrip
    Friend WithEvents btnCustomerForm As ToolStripButton
    Friend WithEvents mnuNewCustomerForm As ToolStripMenuItem
    Friend WithEvents mnuToolbar As ToolStripMenuItem
    Friend WithEvents mnuCloseForm As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuWindowCascade As ToolStripMenuItem
    Friend WithEvents mnuWindowVertical As ToolStripMenuItem
    Friend WithEvents mnuWindowHorizontal As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents sbDate As ToolStripStatusLabel
    Friend WithEvents sbInfo As ToolStripStatusLabel
    Friend WithEvents sbTime As ToolStripStatusLabel
    Friend WithEvents mainTimer As Timer
    Friend WithEvents btnProducts As ToolStripButton
    Friend WithEvents mnuNewProductForm As ToolStripMenuItem
End Class

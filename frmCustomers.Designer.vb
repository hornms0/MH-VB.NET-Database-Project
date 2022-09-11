<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomers
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
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim ZipCodeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomers))
        Me.MMABooksDataSet = New horn_final.MMABooksDataSet()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New horn_final.MMABooksDataSetTableAdapters.CustomersTableAdapter()
        Me.TableAdapterManager = New horn_final.MMABooksDataSetTableAdapters.TableAdapterManager()
        Me.StatesTableAdapter = New horn_final.MMABooksDataSetTableAdapters.StatesTableAdapter()
        Me.CustomersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CustomersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnInvoices = New System.Windows.Forms.ToolStripButton()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.StatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CustomerIDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CustomerIDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.btnGetCustomer = New System.Windows.Forms.ToolStripButton()
        CustomerIDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        ZipCodeLabel = New System.Windows.Forms.Label()
        CType(Me.MMABooksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomersBindingNavigator.SuspendLayout()
        CType(Me.StatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(18, 70)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(21, 13)
        CustomerIDLabel.TabIndex = 1
        CustomerIDLabel.Text = "ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(18, 105)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(18, 140)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 5
        AddressLabel.Text = "Address:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(18, 175)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 7
        CityLabel.Text = "City:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(18, 215)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(35, 13)
        StateLabel.TabIndex = 9
        StateLabel.Text = "State:"
        '
        'ZipCodeLabel
        '
        ZipCodeLabel.AutoSize = True
        ZipCodeLabel.Location = New System.Drawing.Point(181, 215)
        ZipCodeLabel.Name = "ZipCodeLabel"
        ZipCodeLabel.Size = New System.Drawing.Size(53, 13)
        ZipCodeLabel.TabIndex = 11
        ZipCodeLabel.Text = "Zip Code:"
        '
        'MMABooksDataSet
        '
        Me.MMABooksDataSet.DataSetName = "MMABooksDataSet"
        Me.MMABooksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.MMABooksDataSet
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.InvoiceLineItemsTableAdapter = Nothing
        Me.TableAdapterManager.InvoicesTableAdapter = Nothing
        Me.TableAdapterManager.OrderOptionsTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.StatesTableAdapter = Me.StatesTableAdapter
        Me.TableAdapterManager.UpdateOrder = horn_final.MMABooksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StatesTableAdapter
        '
        Me.StatesTableAdapter.ClearBeforeFill = True
        '
        'CustomersBindingNavigator
        '
        Me.CustomersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustomersBindingNavigator.BindingSource = Me.CustomersBindingSource
        Me.CustomersBindingNavigator.CountItem = Nothing
        Me.CustomersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustomersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSeparator1, Me.CustomersBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.btnInvoices})
        Me.CustomersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustomersBindingNavigator.MoveFirstItem = Nothing
        Me.CustomersBindingNavigator.MoveLastItem = Nothing
        Me.CustomersBindingNavigator.MoveNextItem = Nothing
        Me.CustomersBindingNavigator.MovePreviousItem = Nothing
        Me.CustomersBindingNavigator.Name = "CustomersBindingNavigator"
        Me.CustomersBindingNavigator.PositionItem = Nothing
        Me.CustomersBindingNavigator.Size = New System.Drawing.Size(346, 25)
        Me.CustomersBindingNavigator.TabIndex = 0
        Me.CustomersBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(60, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add New"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(44, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'CustomersBindingNavigatorSaveItem
        '
        Me.CustomersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CustomersBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomersBindingNavigatorSaveItem.Name = "CustomersBindingNavigatorSaveItem"
        Me.CustomersBindingNavigatorSaveItem.Size = New System.Drawing.Size(62, 22)
        Me.CustomersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnInvoices
        '
        Me.btnInvoices.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnInvoices.Image = CType(resources.GetObject("btnInvoices.Image"), System.Drawing.Image)
        Me.btnInvoices.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInvoices.Name = "btnInvoices"
        Me.btnInvoices.Size = New System.Drawing.Size(137, 22)
        Me.btnInvoices.Text = "View Customer Invoices"
        '
        'txtID
        '
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "CustomerID", True))
        Me.txtID.Location = New System.Drawing.Point(74, 67)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(35, 20)
        Me.txtID.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Name", True))
        Me.txtName.Location = New System.Drawing.Point(74, 102)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(250, 20)
        Me.txtName.TabIndex = 4
        Me.txtName.Tag = "Name"
        '
        'txtAddress
        '
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Address", True))
        Me.txtAddress.Location = New System.Drawing.Point(74, 137)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(250, 20)
        Me.txtAddress.TabIndex = 6
        Me.txtAddress.Tag = "Address"
        '
        'txtCity
        '
        Me.txtCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "City", True))
        Me.txtCity.Location = New System.Drawing.Point(74, 172)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(250, 20)
        Me.txtCity.TabIndex = 8
        Me.txtCity.Tag = "City"
        '
        'cboState
        '
        Me.cboState.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CustomersBindingSource, "State", True))
        Me.cboState.DataSource = Me.StatesBindingSource
        Me.cboState.DisplayMember = "StateName"
        Me.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboState.FormattingEnabled = True
        Me.cboState.Location = New System.Drawing.Point(74, 211)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(95, 21)
        Me.cboState.TabIndex = 10
        Me.cboState.Tag = "State"
        Me.cboState.ValueMember = "StateCode"
        '
        'StatesBindingSource
        '
        Me.StatesBindingSource.DataMember = "States"
        Me.StatesBindingSource.DataSource = Me.MMABooksDataSet
        '
        'txtZip
        '
        Me.txtZip.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "ZipCode", True))
        Me.txtZip.Location = New System.Drawing.Point(241, 212)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(83, 20)
        Me.txtZip.TabIndex = 12
        Me.txtZip.Tag = "Zip code"
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerIDToolStripLabel, Me.CustomerIDToolStripTextBox, Me.btnGetCustomer})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(346, 25)
        Me.FillByToolStrip.TabIndex = 13
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'CustomerIDToolStripLabel
        '
        Me.CustomerIDToolStripLabel.Name = "CustomerIDToolStripLabel"
        Me.CustomerIDToolStripLabel.Size = New System.Drawing.Size(76, 22)
        Me.CustomerIDToolStripLabel.Text = "Customer ID:"
        '
        'CustomerIDToolStripTextBox
        '
        Me.CustomerIDToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CustomerIDToolStripTextBox.Name = "CustomerIDToolStripTextBox"
        Me.CustomerIDToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'btnGetCustomer
        '
        Me.btnGetCustomer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnGetCustomer.Name = "btnGetCustomer"
        Me.btnGetCustomer.Size = New System.Drawing.Size(84, 22)
        Me.btnGetCustomer.Text = "Get Customer"
        '
        'frmCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 250)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(CustomerIDLabel)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(StateLabel)
        Me.Controls.Add(Me.cboState)
        Me.Controls.Add(ZipCodeLabel)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.CustomersBindingNavigator)
        Me.Name = "frmCustomers"
        Me.Text = "Customers"
        CType(Me.MMABooksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomersBindingNavigator.ResumeLayout(False)
        Me.CustomersBindingNavigator.PerformLayout()
        CType(Me.StatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MMABooksDataSet As MMABooksDataSet
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As MMABooksDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents TableAdapterManager As MMABooksDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomersBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CustomersBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents cboState As ComboBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents StatesTableAdapter As MMABooksDataSetTableAdapters.StatesTableAdapter
    Friend WithEvents StatesBindingSource As BindingSource
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents CustomerIDToolStripLabel As ToolStripLabel
    Friend WithEvents CustomerIDToolStripTextBox As ToolStripTextBox
    Friend WithEvents btnGetCustomer As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnInvoices As ToolStripButton
End Class

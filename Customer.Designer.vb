<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TextBoxLastUpdate = New System.Windows.Forms.TextBox()
        Me.TextBoxActive = New System.Windows.Forms.TextBox()
        Me.TextBoxCreateDate = New System.Windows.Forms.TextBox()
        Me.TextBoxActiveBool = New System.Windows.Forms.TextBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.TextBoxLastName = New System.Windows.Forms.TextBox()
        Me.TextBoxFirstName = New System.Windows.Forms.TextBox()
        Me.TextBoxStore = New System.Windows.Forms.TextBox()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ComboBoxActiveBool = New System.Windows.Forms.ComboBox()
        Me.ComboBoxBranch = New System.Windows.Forms.ComboBox()
        Me.TextBoxAddress = New System.Windows.Forms.TextBox()
        Me.TextBoxCustomerID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.dvgCustomers = New System.Windows.Forms.DataGridView()
        Me.id_customer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_store = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.first_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.last_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.active_bool = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.create_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Active = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.last_update = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelNumberOfCustomer = New System.Windows.Forms.Label()
        Me.ButtonRefeshCustomer = New System.Windows.Forms.Button()
        Me.Panel4.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.dvgCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxLastUpdate
        '
        Me.TextBoxLastUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLastUpdate.Location = New System.Drawing.Point(524, 64)
        Me.TextBoxLastUpdate.Name = "TextBoxLastUpdate"
        Me.TextBoxLastUpdate.ReadOnly = True
        Me.TextBoxLastUpdate.Size = New System.Drawing.Size(208, 26)
        Me.TextBoxLastUpdate.TabIndex = 21
        '
        'TextBoxActive
        '
        Me.TextBoxActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxActive.Location = New System.Drawing.Point(524, 18)
        Me.TextBoxActive.Name = "TextBoxActive"
        Me.TextBoxActive.ReadOnly = True
        Me.TextBoxActive.Size = New System.Drawing.Size(208, 26)
        Me.TextBoxActive.TabIndex = 19
        '
        'TextBoxCreateDate
        '
        Me.TextBoxCreateDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCreateDate.Location = New System.Drawing.Point(152, 284)
        Me.TextBoxCreateDate.Name = "TextBoxCreateDate"
        Me.TextBoxCreateDate.ReadOnly = True
        Me.TextBoxCreateDate.Size = New System.Drawing.Size(208, 26)
        Me.TextBoxCreateDate.TabIndex = 18
        '
        'TextBoxActiveBool
        '
        Me.TextBoxActiveBool.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxActiveBool.Location = New System.Drawing.Point(152, 245)
        Me.TextBoxActiveBool.Name = "TextBoxActiveBool"
        Me.TextBoxActiveBool.ReadOnly = True
        Me.TextBoxActiveBool.Size = New System.Drawing.Size(208, 26)
        Me.TextBoxActiveBool.TabIndex = 17
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEmail.Location = New System.Drawing.Point(152, 198)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.ReadOnly = True
        Me.TextBoxEmail.Size = New System.Drawing.Size(208, 26)
        Me.TextBoxEmail.TabIndex = 15
        '
        'TextBoxLastName
        '
        Me.TextBoxLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLastName.Location = New System.Drawing.Point(152, 150)
        Me.TextBoxLastName.Name = "TextBoxLastName"
        Me.TextBoxLastName.ReadOnly = True
        Me.TextBoxLastName.Size = New System.Drawing.Size(208, 26)
        Me.TextBoxLastName.TabIndex = 14
        '
        'TextBoxFirstName
        '
        Me.TextBoxFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxFirstName.Location = New System.Drawing.Point(152, 110)
        Me.TextBoxFirstName.Name = "TextBoxFirstName"
        Me.TextBoxFirstName.ReadOnly = True
        Me.TextBoxFirstName.Size = New System.Drawing.Size(208, 26)
        Me.TextBoxFirstName.TabIndex = 13
        '
        'TextBoxStore
        '
        Me.TextBoxStore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxStore.Location = New System.Drawing.Point(152, 64)
        Me.TextBoxStore.Name = "TextBoxStore"
        Me.TextBoxStore.ReadOnly = True
        Me.TextBoxStore.Size = New System.Drawing.Size(208, 26)
        Me.TextBoxStore.TabIndex = 12
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.Silver
        Me.ButtonCancel.Enabled = False
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.ForeColor = System.Drawing.Color.White
        Me.ButtonCancel.Image = CType(resources.GetObject("ButtonCancel.Image"), System.Drawing.Image)
        Me.ButtonCancel.Location = New System.Drawing.Point(1098, 406)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(154, 102)
        Me.ButtonCancel.TabIndex = 39
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.Silver
        Me.ButtonDelete.Enabled = False
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.ForeColor = System.Drawing.Color.White
        Me.ButtonDelete.Image = CType(resources.GetObject("ButtonDelete.Image"), System.Drawing.Image)
        Me.ButtonDelete.Location = New System.Drawing.Point(1098, 296)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(154, 102)
        Me.ButtonDelete.TabIndex = 38
        Me.ButtonDelete.UseVisualStyleBackColor = False
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackColor = System.Drawing.Color.Silver
        Me.ButtonEdit.Enabled = False
        Me.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEdit.ForeColor = System.Drawing.Color.White
        Me.ButtonEdit.Image = CType(resources.GetObject("ButtonEdit.Image"), System.Drawing.Image)
        Me.ButtonEdit.Location = New System.Drawing.Point(1098, 187)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(154, 102)
        Me.ButtonEdit.TabIndex = 37
        Me.ButtonEdit.UseVisualStyleBackColor = False
        '
        'ButtonAdd
        '
        Me.ButtonAdd.BackColor = System.Drawing.Color.Silver
        Me.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.ForeColor = System.Drawing.Color.White
        Me.ButtonAdd.Image = CType(resources.GetObject("ButtonAdd.Image"), System.Drawing.Image)
        Me.ButtonAdd.Location = New System.Drawing.Point(1098, 79)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(154, 102)
        Me.ButtonAdd.TabIndex = 36
        Me.ButtonAdd.UseVisualStyleBackColor = False
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.Location = New System.Drawing.Point(1098, 523)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(154, 135)
        Me.ButtonSave.TabIndex = 34
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(389, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 20)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Active :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(389, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 20)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Last Update :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 284)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 20)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Create Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 243)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 20)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Active Bool : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(389, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 20)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Address :"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Controls.Add(Me.ComboBoxActiveBool)
        Me.Panel4.Controls.Add(Me.ComboBoxBranch)
        Me.Panel4.Controls.Add(Me.TextBoxLastUpdate)
        Me.Panel4.Controls.Add(Me.TextBoxActive)
        Me.Panel4.Controls.Add(Me.TextBoxCreateDate)
        Me.Panel4.Controls.Add(Me.TextBoxActiveBool)
        Me.Panel4.Controls.Add(Me.TextBoxAddress)
        Me.Panel4.Controls.Add(Me.TextBoxEmail)
        Me.Panel4.Controls.Add(Me.TextBoxLastName)
        Me.Panel4.Controls.Add(Me.TextBoxFirstName)
        Me.Panel4.Controls.Add(Me.TextBoxStore)
        Me.Panel4.Controls.Add(Me.TextBoxCustomerID)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(22, 127)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1061, 329)
        Me.Panel4.TabIndex = 33
        '
        'ComboBoxActiveBool
        '
        Me.ComboBoxActiveBool.FormattingEnabled = True
        Me.ComboBoxActiveBool.Items.AddRange(New Object() {"True", "False"})
        Me.ComboBoxActiveBool.Location = New System.Drawing.Point(152, 243)
        Me.ComboBoxActiveBool.Name = "ComboBoxActiveBool"
        Me.ComboBoxActiveBool.Size = New System.Drawing.Size(208, 28)
        Me.ComboBoxActiveBool.TabIndex = 23
        '
        'ComboBoxBranch
        '
        Me.ComboBoxBranch.FormattingEnabled = True
        Me.ComboBoxBranch.Items.AddRange(New Object() {"Branch A", "Branch B"})
        Me.ComboBoxBranch.Location = New System.Drawing.Point(152, 64)
        Me.ComboBoxBranch.Name = "ComboBoxBranch"
        Me.ComboBoxBranch.Size = New System.Drawing.Size(208, 28)
        Me.ComboBoxBranch.TabIndex = 22
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAddress.Location = New System.Drawing.Point(393, 150)
        Me.TextBoxAddress.Multiline = True
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.ReadOnly = True
        Me.TextBoxAddress.Size = New System.Drawing.Size(339, 160)
        Me.TextBoxAddress.TabIndex = 16
        '
        'TextBoxCustomerID
        '
        Me.TextBoxCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCustomerID.Location = New System.Drawing.Point(152, 18)
        Me.TextBoxCustomerID.Name = "TextBoxCustomerID"
        Me.TextBoxCustomerID.ReadOnly = True
        Me.TextBoxCustomerID.Size = New System.Drawing.Size(208, 26)
        Me.TextBoxCustomerID.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Email :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Last Name :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "First Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Store :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Customer ID : "
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel10.Controls.Add(Me.Label41)
        Me.Panel10.Location = New System.Drawing.Point(22, 79)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1061, 51)
        Me.Panel10.TabIndex = 30
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(477, 14)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(141, 31)
        Me.Label41.TabIndex = 0
        Me.Label41.Text = "Infomation"
        '
        'ButtonSearch
        '
        Me.ButtonSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSearch.ForeColor = System.Drawing.Color.White
        Me.ButtonSearch.Image = CType(resources.GetObject("ButtonSearch.Image"), System.Drawing.Image)
        Me.ButtonSearch.Location = New System.Drawing.Point(1098, 20)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(154, 29)
        Me.ButtonSearch.TabIndex = 41
        Me.ButtonSearch.UseVisualStyleBackColor = False
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.ForeColor = System.Drawing.Color.Silver
        Me.TextBoxSearch.Location = New System.Drawing.Point(22, 20)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(1070, 29)
        Me.TextBoxSearch.TabIndex = 40
        '
        'dvgCustomers
        '
        Me.dvgCustomers.BackgroundColor = System.Drawing.Color.White
        Me.dvgCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dvgCustomers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dvgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgCustomers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_customer, Me.id_store, Me.first_name, Me.last_name, Me.email, Me.active_bool, Me.create_date, Me.Active, Me.last_update, Me.address})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dvgCustomers.DefaultCellStyle = DataGridViewCellStyle4
        Me.dvgCustomers.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dvgCustomers.Location = New System.Drawing.Point(22, 462)
        Me.dvgCustomers.Name = "dvgCustomers"
        Me.dvgCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgCustomers.Size = New System.Drawing.Size(1061, 180)
        Me.dvgCustomers.TabIndex = 102
        '
        'id_customer
        '
        Me.id_customer.HeaderText = "ID"
        Me.id_customer.Name = "id_customer"
        Me.id_customer.Width = 50
        '
        'id_store
        '
        Me.id_store.HeaderText = "Store"
        Me.id_store.Name = "id_store"
        '
        'first_name
        '
        Me.first_name.HeaderText = "First Name"
        Me.first_name.Name = "first_name"
        Me.first_name.Width = 150
        '
        'last_name
        '
        Me.last_name.HeaderText = "Last Name"
        Me.last_name.Name = "last_name"
        Me.last_name.Width = 150
        '
        'email
        '
        Me.email.HeaderText = "Email"
        Me.email.Name = "email"
        Me.email.Width = 200
        '
        'active_bool
        '
        Me.active_bool.HeaderText = "Active Bool"
        Me.active_bool.Name = "active_bool"
        Me.active_bool.Width = 150
        '
        'create_date
        '
        Me.create_date.HeaderText = "Create Date"
        Me.create_date.Name = "create_date"
        Me.create_date.Width = 150
        '
        'Active
        '
        Me.Active.HeaderText = "active"
        Me.Active.Name = "Active"
        '
        'last_update
        '
        Me.last_update.HeaderText = "Last Update"
        Me.last_update.Name = "last_update"
        Me.last_update.Width = 150
        '
        'address
        '
        Me.address.HeaderText = "address"
        Me.address.Name = "address"
        Me.address.Width = 300
        '
        'LabelNumberOfCustomer
        '
        Me.LabelNumberOfCustomer.AutoSize = True
        Me.LabelNumberOfCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNumberOfCustomer.Location = New System.Drawing.Point(22, 645)
        Me.LabelNumberOfCustomer.Name = "LabelNumberOfCustomer"
        Me.LabelNumberOfCustomer.Size = New System.Drawing.Size(0, 20)
        Me.LabelNumberOfCustomer.TabIndex = 24
        '
        'ButtonRefeshCustomer
        '
        Me.ButtonRefeshCustomer.BackColor = System.Drawing.Color.White
        Me.ButtonRefeshCustomer.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonRefeshCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRefeshCustomer.ForeColor = System.Drawing.Color.White
        Me.ButtonRefeshCustomer.Image = CType(resources.GetObject("ButtonRefeshCustomer.Image"), System.Drawing.Image)
        Me.ButtonRefeshCustomer.Location = New System.Drawing.Point(22, 462)
        Me.ButtonRefeshCustomer.Name = "ButtonRefeshCustomer"
        Me.ButtonRefeshCustomer.Size = New System.Drawing.Size(40, 27)
        Me.ButtonRefeshCustomer.TabIndex = 103
        Me.ButtonRefeshCustomer.UseVisualStyleBackColor = False
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ButtonRefeshCustomer)
        Me.Controls.Add(Me.LabelNumberOfCustomer)
        Me.Controls.Add(Me.dvgCustomers)
        Me.Controls.Add(Me.ButtonSearch)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel10)
        Me.Name = "Customer"
        Me.Size = New System.Drawing.Size(1275, 675)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        CType(Me.dvgCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxLastUpdate As TextBox
    Friend WithEvents TextBoxActive As TextBox
    Friend WithEvents TextBoxCreateDate As TextBox
    Friend WithEvents TextBoxActiveBool As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxLastName As TextBox
    Friend WithEvents TextBoxFirstName As TextBox
    Friend WithEvents TextBoxStore As TextBox
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label41 As Label
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents TextBoxCustomerID As TextBox
    Friend WithEvents ComboBoxActiveBool As ComboBox
    Friend WithEvents ComboBoxBranch As ComboBox
    Friend WithEvents TextBoxAddress As TextBox
    Friend WithEvents dvgCustomers As DataGridView
    Friend WithEvents id_customer As DataGridViewTextBoxColumn
    Friend WithEvents id_store As DataGridViewTextBoxColumn
    Friend WithEvents first_name As DataGridViewTextBoxColumn
    Friend WithEvents last_name As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents active_bool As DataGridViewTextBoxColumn
    Friend WithEvents create_date As DataGridViewTextBoxColumn
    Friend WithEvents Active As DataGridViewTextBoxColumn
    Friend WithEvents last_update As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents LabelNumberOfCustomer As Label
    Friend WithEvents ButtonRefeshCustomer As Button
End Class

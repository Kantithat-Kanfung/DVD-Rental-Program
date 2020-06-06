<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inventory
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventory))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ComboBoxActive = New System.Windows.Forms.ComboBox()
        Me.ComboBoxStoreID = New System.Windows.Forms.ComboBox()
        Me.TextBoxLastUpdate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxStoreID = New System.Windows.Forms.TextBox()
        Me.TextBoxTitle = New System.Windows.Forms.TextBox()
        Me.TextBoxFilmID = New System.Windows.Forms.TextBox()
        Me.TextBoxActive = New System.Windows.Forms.TextBox()
        Me.TextBoxInventoryID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.ButtonRefeshInventory = New System.Windows.Forms.Button()
        Me.dvgInventory = New System.Windows.Forms.DataGridView()
        Me.LabelNumberOfInventory = New System.Windows.Forms.Label()
        Me.inventory_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.film_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.store_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.active = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.last_update = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.dvgInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.Silver
        Me.ButtonDelete.Enabled = False
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.ForeColor = System.Drawing.Color.White
        Me.ButtonDelete.Image = CType(resources.GetObject("ButtonDelete.Image"), System.Drawing.Image)
        Me.ButtonDelete.Location = New System.Drawing.Point(1098, 291)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(154, 102)
        Me.ButtonDelete.TabIndex = 70
        Me.ButtonDelete.UseVisualStyleBackColor = False
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.ForeColor = System.Drawing.Color.Silver
        Me.TextBoxSearch.Location = New System.Drawing.Point(22, 18)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(1070, 29)
        Me.TextBoxSearch.TabIndex = 73
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.Silver
        Me.ButtonCancel.Enabled = False
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.ForeColor = System.Drawing.Color.White
        Me.ButtonCancel.Image = CType(resources.GetObject("ButtonCancel.Image"), System.Drawing.Image)
        Me.ButtonCancel.Location = New System.Drawing.Point(1098, 401)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(154, 102)
        Me.ButtonCancel.TabIndex = 71
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackColor = System.Drawing.Color.Silver
        Me.ButtonEdit.Enabled = False
        Me.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEdit.ForeColor = System.Drawing.Color.White
        Me.ButtonEdit.Image = CType(resources.GetObject("ButtonEdit.Image"), System.Drawing.Image)
        Me.ButtonEdit.Location = New System.Drawing.Point(1098, 182)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(154, 102)
        Me.ButtonEdit.TabIndex = 69
        Me.ButtonEdit.UseVisualStyleBackColor = False
        '
        'ButtonAdd
        '
        Me.ButtonAdd.BackColor = System.Drawing.Color.Silver
        Me.ButtonAdd.Enabled = False
        Me.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.ForeColor = System.Drawing.Color.White
        Me.ButtonAdd.Image = CType(resources.GetObject("ButtonAdd.Image"), System.Drawing.Image)
        Me.ButtonAdd.Location = New System.Drawing.Point(1098, 74)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(154, 102)
        Me.ButtonAdd.TabIndex = 68
        Me.ButtonAdd.UseVisualStyleBackColor = False
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonSave.Enabled = False
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.Location = New System.Drawing.Point(1098, 518)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(154, 140)
        Me.ButtonSave.TabIndex = 67
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'ButtonSearch
        '
        Me.ButtonSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSearch.ForeColor = System.Drawing.Color.White
        Me.ButtonSearch.Image = CType(resources.GetObject("ButtonSearch.Image"), System.Drawing.Image)
        Me.ButtonSearch.Location = New System.Drawing.Point(1098, 18)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(154, 29)
        Me.ButtonSearch.TabIndex = 74
        Me.ButtonSearch.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Controls.Add(Me.ComboBoxActive)
        Me.Panel4.Controls.Add(Me.ComboBoxStoreID)
        Me.Panel4.Controls.Add(Me.TextBoxLastUpdate)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.TextBoxStoreID)
        Me.Panel4.Controls.Add(Me.TextBoxTitle)
        Me.Panel4.Controls.Add(Me.TextBoxFilmID)
        Me.Panel4.Controls.Add(Me.TextBoxActive)
        Me.Panel4.Controls.Add(Me.TextBoxInventoryID)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(521, 122)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(553, 381)
        Me.Panel4.TabIndex = 76
        '
        'ComboBoxActive
        '
        Me.ComboBoxActive.FormattingEnabled = True
        Me.ComboBoxActive.Items.AddRange(New Object() {"True", "False"})
        Me.ComboBoxActive.Location = New System.Drawing.Point(156, 198)
        Me.ComboBoxActive.Name = "ComboBoxActive"
        Me.ComboBoxActive.Size = New System.Drawing.Size(208, 28)
        Me.ComboBoxActive.TabIndex = 18
        '
        'ComboBoxStoreID
        '
        Me.ComboBoxStoreID.FormattingEnabled = True
        Me.ComboBoxStoreID.Items.AddRange(New Object() {"Branch A", "Balance B"})
        Me.ComboBoxStoreID.Location = New System.Drawing.Point(156, 158)
        Me.ComboBoxStoreID.Name = "ComboBoxStoreID"
        Me.ComboBoxStoreID.Size = New System.Drawing.Size(208, 28)
        Me.ComboBoxStoreID.TabIndex = 17
        '
        'TextBoxLastUpdate
        '
        Me.TextBoxLastUpdate.Enabled = False
        Me.TextBoxLastUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLastUpdate.Location = New System.Drawing.Point(156, 240)
        Me.TextBoxLastUpdate.Name = "TextBoxLastUpdate"
        Me.TextBoxLastUpdate.ReadOnly = True
        Me.TextBoxLastUpdate.Size = New System.Drawing.Size(208, 26)
        Me.TextBoxLastUpdate.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Last Update :"
        '
        'TextBoxStoreID
        '
        Me.TextBoxStoreID.Enabled = False
        Me.TextBoxStoreID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxStoreID.Location = New System.Drawing.Point(156, 158)
        Me.TextBoxStoreID.Name = "TextBoxStoreID"
        Me.TextBoxStoreID.ReadOnly = True
        Me.TextBoxStoreID.Size = New System.Drawing.Size(208, 26)
        Me.TextBoxStoreID.TabIndex = 14
        '
        'TextBoxTitle
        '
        Me.TextBoxTitle.Enabled = False
        Me.TextBoxTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTitle.Location = New System.Drawing.Point(156, 119)
        Me.TextBoxTitle.Name = "TextBoxTitle"
        Me.TextBoxTitle.ReadOnly = True
        Me.TextBoxTitle.Size = New System.Drawing.Size(208, 26)
        Me.TextBoxTitle.TabIndex = 13
        '
        'TextBoxFilmID
        '
        Me.TextBoxFilmID.Enabled = False
        Me.TextBoxFilmID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxFilmID.Location = New System.Drawing.Point(156, 78)
        Me.TextBoxFilmID.Name = "TextBoxFilmID"
        Me.TextBoxFilmID.ReadOnly = True
        Me.TextBoxFilmID.Size = New System.Drawing.Size(208, 26)
        Me.TextBoxFilmID.TabIndex = 13
        '
        'TextBoxActive
        '
        Me.TextBoxActive.Enabled = False
        Me.TextBoxActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxActive.Location = New System.Drawing.Point(156, 198)
        Me.TextBoxActive.Name = "TextBoxActive"
        Me.TextBoxActive.ReadOnly = True
        Me.TextBoxActive.Size = New System.Drawing.Size(208, 26)
        Me.TextBoxActive.TabIndex = 12
        '
        'TextBoxInventoryID
        '
        Me.TextBoxInventoryID.Enabled = False
        Me.TextBoxInventoryID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxInventoryID.Location = New System.Drawing.Point(156, 34)
        Me.TextBoxInventoryID.Name = "TextBoxInventoryID"
        Me.TextBoxInventoryID.ReadOnly = True
        Me.TextBoxInventoryID.Size = New System.Drawing.Size(208, 26)
        Me.TextBoxInventoryID.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Title :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Store ID :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Film ID :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Active :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Inventory ID : "
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel10.Controls.Add(Me.Label41)
        Me.Panel10.Location = New System.Drawing.Point(521, 74)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(553, 51)
        Me.Panel10.TabIndex = 75
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(212, 14)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(141, 31)
        Me.Label41.TabIndex = 0
        Me.Label41.Text = "Infomation"
        '
        'ButtonRefeshInventory
        '
        Me.ButtonRefeshInventory.BackColor = System.Drawing.Color.White
        Me.ButtonRefeshInventory.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonRefeshInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRefeshInventory.ForeColor = System.Drawing.Color.White
        Me.ButtonRefeshInventory.Image = CType(resources.GetObject("ButtonRefeshInventory.Image"), System.Drawing.Image)
        Me.ButtonRefeshInventory.Location = New System.Drawing.Point(22, 74)
        Me.ButtonRefeshInventory.Name = "ButtonRefeshInventory"
        Me.ButtonRefeshInventory.Size = New System.Drawing.Size(42, 27)
        Me.ButtonRefeshInventory.TabIndex = 107
        Me.ButtonRefeshInventory.UseVisualStyleBackColor = False
        '
        'dvgInventory
        '
        Me.dvgInventory.BackgroundColor = System.Drawing.Color.White
        Me.dvgInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dvgInventory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dvgInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgInventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.inventory_id, Me.film_id, Me.title, Me.store_id, Me.active, Me.last_update})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dvgInventory.DefaultCellStyle = DataGridViewCellStyle2
        Me.dvgInventory.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dvgInventory.Location = New System.Drawing.Point(22, 74)
        Me.dvgInventory.Name = "dvgInventory"
        Me.dvgInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgInventory.Size = New System.Drawing.Size(476, 429)
        Me.dvgInventory.TabIndex = 106
        '
        'LabelNumberOfInventory
        '
        Me.LabelNumberOfInventory.AutoSize = True
        Me.LabelNumberOfInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNumberOfInventory.Location = New System.Drawing.Point(18, 518)
        Me.LabelNumberOfInventory.Name = "LabelNumberOfInventory"
        Me.LabelNumberOfInventory.Size = New System.Drawing.Size(217, 20)
        Me.LabelNumberOfInventory.TabIndex = 107
        Me.LabelNumberOfInventory.Text = "Number of Inventory : 0 Items"
        '
        'inventory_id
        '
        Me.inventory_id.HeaderText = "Inv ID"
        Me.inventory_id.Name = "inventory_id"
        '
        'film_id
        '
        Me.film_id.HeaderText = "Film ID"
        Me.film_id.Name = "film_id"
        '
        'title
        '
        Me.title.HeaderText = "Title"
        Me.title.Name = "title"
        Me.title.Width = 200
        '
        'store_id
        '
        Me.store_id.HeaderText = "Store ID"
        Me.store_id.Name = "store_id"
        '
        'active
        '
        Me.active.HeaderText = "Active"
        Me.active.Name = "active"
        '
        'last_update
        '
        Me.last_update.HeaderText = "Last Update"
        Me.last_update.Name = "last_update"
        Me.last_update.Width = 200
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ButtonRefeshInventory)
        Me.Controls.Add(Me.LabelNumberOfInventory)
        Me.Controls.Add(Me.dvgInventory)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonSearch)
        Me.Name = "Inventory"
        Me.Size = New System.Drawing.Size(1275, 675)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        CType(Me.dvgInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBoxStoreID As TextBox
    Friend WithEvents TextBoxFilmID As TextBox
    Friend WithEvents TextBoxActive As TextBox
    Friend WithEvents TextBoxInventoryID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label41 As Label
    Friend WithEvents TextBoxLastUpdate As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxStoreID As ComboBox
    Friend WithEvents TextBoxTitle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxActive As ComboBox
    Friend WithEvents ButtonRefeshInventory As Button
    Friend WithEvents dvgInventory As DataGridView
    Friend WithEvents LabelNumberOfInventory As Label
    Friend WithEvents inventory_id As DataGridViewTextBoxColumn
    Friend WithEvents film_id As DataGridViewTextBoxColumn
    Friend WithEvents title As DataGridViewTextBoxColumn
    Friend WithEvents store_id As DataGridViewTextBoxColumn
    Friend WithEvents active As DataGridViewTextBoxColumn
    Friend WithEvents last_update As DataGridViewTextBoxColumn
End Class

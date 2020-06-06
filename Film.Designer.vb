<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Film
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Film))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.TextBoxRating = New System.Windows.Forms.TextBox()
        Me.TextBoxReplacementCost = New System.Windows.Forms.TextBox()
        Me.TextBoxLength = New System.Windows.Forms.TextBox()
        Me.TextBoxRentalRate = New System.Windows.Forms.TextBox()
        Me.TextBoxRentalDuration = New System.Windows.Forms.TextBox()
        Me.TextBoxLanguage = New System.Windows.Forms.TextBox()
        Me.TextBoxReleaseYear = New System.Windows.Forms.TextBox()
        Me.TextBoxTitle = New System.Windows.Forms.TextBox()
        Me.TextBoxFilmID = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ComboBoxRating = New System.Windows.Forms.ComboBox()
        Me.ComboBoxLanguage = New System.Windows.Forms.ComboBox()
        Me.TextBoxLastUpdate = New System.Windows.Forms.TextBox()
        Me.TextBoxDescription = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.ButtonRefeshCustomer = New System.Windows.Forms.Button()
        Me.dvgFilm = New System.Windows.Forms.DataGridView()
        Me.LabelNumberOfFilm = New System.Windows.Forms.Label()
        Me.film_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.release_year = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.language = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rental_duration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rental_rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.length = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.replacement_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rating = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.last_update = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel10.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dvgFilm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel10.Controls.Add(Me.Label41)
        Me.Panel10.Location = New System.Drawing.Point(22, 79)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1061, 51)
        Me.Panel10.TabIndex = 29
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(478, 14)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(141, 31)
        Me.Label41.TabIndex = 0
        Me.Label41.Text = "Infomation"
        '
        'TextBoxRating
        '
        Me.TextBoxRating.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxRating.Location = New System.Drawing.Point(524, 18)
        Me.TextBoxRating.Multiline = True
        Me.TextBoxRating.Name = "TextBoxRating"
        Me.TextBoxRating.ReadOnly = True
        Me.TextBoxRating.Size = New System.Drawing.Size(208, 75)
        Me.TextBoxRating.TabIndex = 19
        '
        'TextBoxReplacementCost
        '
        Me.TextBoxReplacementCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxReplacementCost.Location = New System.Drawing.Point(178, 321)
        Me.TextBoxReplacementCost.Name = "TextBoxReplacementCost"
        Me.TextBoxReplacementCost.ReadOnly = True
        Me.TextBoxReplacementCost.Size = New System.Drawing.Size(208, 26)
        Me.TextBoxReplacementCost.TabIndex = 18
        '
        'TextBoxLength
        '
        Me.TextBoxLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLength.Location = New System.Drawing.Point(178, 280)
        Me.TextBoxLength.Name = "TextBoxLength"
        Me.TextBoxLength.ReadOnly = True
        Me.TextBoxLength.Size = New System.Drawing.Size(208, 26)
        Me.TextBoxLength.TabIndex = 17
        '
        'TextBoxRentalRate
        '
        Me.TextBoxRentalRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxRentalRate.Location = New System.Drawing.Point(178, 245)
        Me.TextBoxRentalRate.Name = "TextBoxRentalRate"
        Me.TextBoxRentalRate.ReadOnly = True
        Me.TextBoxRentalRate.Size = New System.Drawing.Size(208, 26)
        Me.TextBoxRentalRate.TabIndex = 16
        '
        'TextBoxRentalDuration
        '
        Me.TextBoxRentalDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxRentalDuration.Location = New System.Drawing.Point(178, 201)
        Me.TextBoxRentalDuration.Name = "TextBoxRentalDuration"
        Me.TextBoxRentalDuration.ReadOnly = True
        Me.TextBoxRentalDuration.Size = New System.Drawing.Size(208, 26)
        Me.TextBoxRentalDuration.TabIndex = 15
        '
        'TextBoxLanguage
        '
        Me.TextBoxLanguage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLanguage.Location = New System.Drawing.Point(178, 153)
        Me.TextBoxLanguage.Name = "TextBoxLanguage"
        Me.TextBoxLanguage.ReadOnly = True
        Me.TextBoxLanguage.Size = New System.Drawing.Size(208, 26)
        Me.TextBoxLanguage.TabIndex = 14
        '
        'TextBoxReleaseYear
        '
        Me.TextBoxReleaseYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxReleaseYear.Location = New System.Drawing.Point(178, 113)
        Me.TextBoxReleaseYear.Name = "TextBoxReleaseYear"
        Me.TextBoxReleaseYear.ReadOnly = True
        Me.TextBoxReleaseYear.Size = New System.Drawing.Size(208, 26)
        Me.TextBoxReleaseYear.TabIndex = 13
        '
        'TextBoxTitle
        '
        Me.TextBoxTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTitle.Location = New System.Drawing.Point(178, 67)
        Me.TextBoxTitle.Name = "TextBoxTitle"
        Me.TextBoxTitle.ReadOnly = True
        Me.TextBoxTitle.Size = New System.Drawing.Size(208, 26)
        Me.TextBoxTitle.TabIndex = 12
        '
        'TextBoxFilmID
        '
        Me.TextBoxFilmID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxFilmID.Location = New System.Drawing.Point(178, 21)
        Me.TextBoxFilmID.Name = "TextBoxFilmID"
        Me.TextBoxFilmID.ReadOnly = True
        Me.TextBoxFilmID.Size = New System.Drawing.Size(208, 26)
        Me.TextBoxFilmID.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(413, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 20)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Rating :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(413, 108)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 20)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Last Update :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 324)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(149, 20)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Replacement Cost :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 20)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Rental Rate :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Rental Duration :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Language :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = " Release Year :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Title :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Film ID : "
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Controls.Add(Me.ComboBoxRating)
        Me.Panel4.Controls.Add(Me.ComboBoxLanguage)
        Me.Panel4.Controls.Add(Me.TextBoxLastUpdate)
        Me.Panel4.Controls.Add(Me.TextBoxDescription)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.TextBoxRating)
        Me.Panel4.Controls.Add(Me.TextBoxReplacementCost)
        Me.Panel4.Controls.Add(Me.TextBoxLength)
        Me.Panel4.Controls.Add(Me.TextBoxRentalRate)
        Me.Panel4.Controls.Add(Me.TextBoxRentalDuration)
        Me.Panel4.Controls.Add(Me.TextBoxLanguage)
        Me.Panel4.Controls.Add(Me.TextBoxReleaseYear)
        Me.Panel4.Controls.Add(Me.TextBoxTitle)
        Me.Panel4.Controls.Add(Me.TextBoxFilmID)
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
        Me.Panel4.Size = New System.Drawing.Size(1061, 360)
        Me.Panel4.TabIndex = 33
        '
        'ComboBoxRating
        '
        Me.ComboBoxRating.FormattingEnabled = True
        Me.ComboBoxRating.Location = New System.Drawing.Point(524, 18)
        Me.ComboBoxRating.Name = "ComboBoxRating"
        Me.ComboBoxRating.Size = New System.Drawing.Size(208, 28)
        Me.ComboBoxRating.TabIndex = 26
        '
        'ComboBoxLanguage
        '
        Me.ComboBoxLanguage.FormattingEnabled = True
        Me.ComboBoxLanguage.Location = New System.Drawing.Point(178, 153)
        Me.ComboBoxLanguage.Name = "ComboBoxLanguage"
        Me.ComboBoxLanguage.Size = New System.Drawing.Size(208, 28)
        Me.ComboBoxLanguage.TabIndex = 25
        '
        'TextBoxLastUpdate
        '
        Me.TextBoxLastUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLastUpdate.Location = New System.Drawing.Point(524, 108)
        Me.TextBoxLastUpdate.Name = "TextBoxLastUpdate"
        Me.TextBoxLastUpdate.ReadOnly = True
        Me.TextBoxLastUpdate.Size = New System.Drawing.Size(208, 26)
        Me.TextBoxLastUpdate.TabIndex = 24
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDescription.Location = New System.Drawing.Point(417, 196)
        Me.TextBoxDescription.Multiline = True
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.ReadOnly = True
        Me.TextBoxDescription.Size = New System.Drawing.Size(315, 148)
        Me.TextBoxDescription.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(413, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 20)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Description :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 280)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 20)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Length : "
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
        Me.ButtonCancel.TabIndex = 47
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
        Me.ButtonDelete.TabIndex = 46
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
        Me.ButtonEdit.TabIndex = 45
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
        Me.ButtonAdd.TabIndex = 44
        Me.ButtonAdd.UseVisualStyleBackColor = False
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonSave.Enabled = False
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.Location = New System.Drawing.Point(1098, 523)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(154, 133)
        Me.ButtonSave.TabIndex = 43
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
        Me.ButtonSearch.Location = New System.Drawing.Point(1098, 23)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(154, 29)
        Me.ButtonSearch.TabIndex = 50
        Me.ButtonSearch.UseVisualStyleBackColor = False
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.ForeColor = System.Drawing.Color.Silver
        Me.TextBoxSearch.Location = New System.Drawing.Point(22, 23)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(1070, 29)
        Me.TextBoxSearch.TabIndex = 49
        '
        'ButtonRefeshCustomer
        '
        Me.ButtonRefeshCustomer.BackColor = System.Drawing.Color.White
        Me.ButtonRefeshCustomer.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonRefeshCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRefeshCustomer.ForeColor = System.Drawing.Color.White
        Me.ButtonRefeshCustomer.Image = CType(resources.GetObject("ButtonRefeshCustomer.Image"), System.Drawing.Image)
        Me.ButtonRefeshCustomer.Location = New System.Drawing.Point(22, 493)
        Me.ButtonRefeshCustomer.Name = "ButtonRefeshCustomer"
        Me.ButtonRefeshCustomer.Size = New System.Drawing.Size(40, 27)
        Me.ButtonRefeshCustomer.TabIndex = 105
        Me.ButtonRefeshCustomer.UseVisualStyleBackColor = False
        '
        'dvgFilm
        '
        Me.dvgFilm.BackgroundColor = System.Drawing.Color.White
        Me.dvgFilm.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dvgFilm.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dvgFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgFilm.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.film_id, Me.title, Me.release_year, Me.language, Me.rental_duration, Me.rental_rate, Me.length, Me.replacement_cost, Me.rating, Me.last_update, Me.description})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dvgFilm.DefaultCellStyle = DataGridViewCellStyle2
        Me.dvgFilm.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dvgFilm.Location = New System.Drawing.Point(22, 493)
        Me.dvgFilm.Name = "dvgFilm"
        Me.dvgFilm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgFilm.Size = New System.Drawing.Size(1061, 152)
        Me.dvgFilm.TabIndex = 104
        '
        'LabelNumberOfFilm
        '
        Me.LabelNumberOfFilm.AutoSize = True
        Me.LabelNumberOfFilm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNumberOfFilm.Location = New System.Drawing.Point(18, 648)
        Me.LabelNumberOfFilm.Name = "LabelNumberOfFilm"
        Me.LabelNumberOfFilm.Size = New System.Drawing.Size(181, 20)
        Me.LabelNumberOfFilm.TabIndex = 27
        Me.LabelNumberOfFilm.Text = "Number of Film : 0 Items"
        '
        'film_id
        '
        Me.film_id.HeaderText = "ID"
        Me.film_id.Name = "film_id"
        Me.film_id.Width = 70
        '
        'title
        '
        Me.title.HeaderText = "Title"
        Me.title.Name = "title"
        Me.title.Width = 200
        '
        'release_year
        '
        Me.release_year.HeaderText = "Release_Year"
        Me.release_year.Name = "release_year"
        Me.release_year.Width = 150
        '
        'language
        '
        Me.language.HeaderText = "Language"
        Me.language.Name = "language"
        Me.language.Width = 150
        '
        'rental_duration
        '
        Me.rental_duration.HeaderText = "Rental_Duration"
        Me.rental_duration.Name = "rental_duration"
        Me.rental_duration.Width = 150
        '
        'rental_rate
        '
        Me.rental_rate.HeaderText = "Rental Rate"
        Me.rental_rate.Name = "rental_rate"
        Me.rental_rate.Width = 150
        '
        'length
        '
        Me.length.HeaderText = "Length"
        Me.length.Name = "length"
        Me.length.Width = 150
        '
        'replacement_cost
        '
        Me.replacement_cost.HeaderText = "Replacement Cost"
        Me.replacement_cost.Name = "replacement_cost"
        Me.replacement_cost.Width = 150
        '
        'rating
        '
        Me.rating.HeaderText = "Rating"
        Me.rating.Name = "rating"
        Me.rating.Width = 300
        '
        'last_update
        '
        Me.last_update.HeaderText = "Last Update"
        Me.last_update.Name = "last_update"
        Me.last_update.Width = 200
        '
        'description
        '
        Me.description.HeaderText = "Description"
        Me.description.Name = "description"
        Me.description.Width = 500
        '
        'Film
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.LabelNumberOfFilm)
        Me.Controls.Add(Me.ButtonRefeshCustomer)
        Me.Controls.Add(Me.dvgFilm)
        Me.Controls.Add(Me.ButtonSearch)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "Film"
        Me.Size = New System.Drawing.Size(1275, 675)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dvgFilm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label41 As Label
    Friend WithEvents TextBoxRating As TextBox
    Friend WithEvents TextBoxReplacementCost As TextBox
    Friend WithEvents TextBoxLength As TextBox
    Friend WithEvents TextBoxRentalRate As TextBox
    Friend WithEvents TextBoxRentalDuration As TextBox
    Friend WithEvents TextBoxLanguage As TextBox
    Friend WithEvents TextBoxReleaseYear As TextBox
    Friend WithEvents TextBoxTitle As TextBox
    Friend WithEvents TextBoxFilmID As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxDescription As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents TextBoxLastUpdate As TextBox
    Friend WithEvents ComboBoxLanguage As ComboBox
    Friend WithEvents ComboBoxRating As ComboBox
    Friend WithEvents ButtonRefeshCustomer As Button
    Friend WithEvents dvgFilm As DataGridView
    Friend WithEvents LabelNumberOfFilm As Label
    Friend WithEvents film_id As DataGridViewTextBoxColumn
    Friend WithEvents title As DataGridViewTextBoxColumn
    Friend WithEvents release_year As DataGridViewTextBoxColumn
    Friend WithEvents language As DataGridViewTextBoxColumn
    Friend WithEvents rental_duration As DataGridViewTextBoxColumn
    Friend WithEvents rental_rate As DataGridViewTextBoxColumn
    Friend WithEvents length As DataGridViewTextBoxColumn
    Friend WithEvents replacement_cost As DataGridViewTextBoxColumn
    Friend WithEvents rating As DataGridViewTextBoxColumn
    Friend WithEvents last_update As DataGridViewTextBoxColumn
    Friend WithEvents description As DataGridViewTextBoxColumn
End Class

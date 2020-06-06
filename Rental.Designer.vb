<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RentalPage
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RentalPage))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TextBoxSearchFilm = New System.Windows.Forms.TextBox()
        Me.dvgFilm = New System.Windows.Forms.DataGridView()
        Me.id_film = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rental_duration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rental_rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonPaymentNow = New System.Windows.Forms.Button()
        Me.ButtonSearchFilm = New System.Windows.Forms.Button()
        Me.LabelNumberOfMovies = New System.Windows.Forms.Label()
        Me.ButtonRefeshFilm = New System.Windows.Forms.Button()
        Me.dvgCustomer = New System.Windows.Forms.DataGridView()
        Me.id_customer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cutomer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelNumerOfCustomer = New System.Windows.Forms.Label()
        Me.TextBoxSearchCustomer = New System.Windows.Forms.TextBox()
        Me.ButtonSearchCustomer = New System.Windows.Forms.Button()
        Me.ButtonRefeshCustomer = New System.Windows.Forms.Button()
        Me.PanelDemo = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxStore = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelError = New System.Windows.Forms.Label()
        Me.ComboBoxStaff = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxReturnDate = New System.Windows.Forms.TextBox()
        Me.TextBoxRentalDate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxRentalDuration = New System.Windows.Forms.TextBox()
        Me.TextBoxDVDRental = New System.Windows.Forms.TextBox()
        Me.TextBoxCustomer = New System.Windows.Forms.TextBox()
        Me.LabelAmount = New System.Windows.Forms.Label()
        Me.TextBoxRentalRate = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dvgPayment = New System.Windows.Forms.DataGridView()
        Me.customer_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staff_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rental_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dvgFilm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvgCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDemo.SuspendLayout()
        CType(Me.dvgPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxSearchFilm
        '
        Me.TextBoxSearchFilm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearchFilm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBoxSearchFilm.Location = New System.Drawing.Point(25, 28)
        Me.TextBoxSearchFilm.Name = "TextBoxSearchFilm"
        Me.TextBoxSearchFilm.Size = New System.Drawing.Size(367, 29)
        Me.TextBoxSearchFilm.TabIndex = 2
        '
        'dvgFilm
        '
        Me.dvgFilm.BackgroundColor = System.Drawing.Color.White
        Me.dvgFilm.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dvgFilm.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dvgFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgFilm.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_film, Me.title, Me.rental_duration, Me.rental_rate})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dvgFilm.DefaultCellStyle = DataGridViewCellStyle8
        Me.dvgFilm.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dvgFilm.Location = New System.Drawing.Point(25, 79)
        Me.dvgFilm.Name = "dvgFilm"
        Me.dvgFilm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgFilm.Size = New System.Drawing.Size(454, 337)
        Me.dvgFilm.TabIndex = 4
        '
        'id_film
        '
        Me.id_film.HeaderText = "ID"
        Me.id_film.Name = "id_film"
        Me.id_film.Width = 80
        '
        'title
        '
        Me.title.HeaderText = "Film"
        Me.title.Name = "title"
        Me.title.Width = 190
        '
        'rental_duration
        '
        Me.rental_duration.HeaderText = "D"
        Me.rental_duration.Name = "rental_duration"
        Me.rental_duration.Width = 40
        '
        'rental_rate
        '
        Me.rental_rate.HeaderText = "R_rate"
        Me.rental_rate.Name = "rental_rate"
        '
        'ButtonPaymentNow
        '
        Me.ButtonPaymentNow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonPaymentNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPaymentNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPaymentNow.ForeColor = System.Drawing.Color.White
        Me.ButtonPaymentNow.Location = New System.Drawing.Point(852, 595)
        Me.ButtonPaymentNow.Name = "ButtonPaymentNow"
        Me.ButtonPaymentNow.Size = New System.Drawing.Size(383, 62)
        Me.ButtonPaymentNow.TabIndex = 21
        Me.ButtonPaymentNow.Text = "Payment Now"
        Me.ButtonPaymentNow.UseVisualStyleBackColor = False
        '
        'ButtonSearchFilm
        '
        Me.ButtonSearchFilm.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonSearchFilm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonSearchFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSearchFilm.ForeColor = System.Drawing.Color.White
        Me.ButtonSearchFilm.Image = CType(resources.GetObject("ButtonSearchFilm.Image"), System.Drawing.Image)
        Me.ButtonSearchFilm.Location = New System.Drawing.Point(398, 28)
        Me.ButtonSearchFilm.Name = "ButtonSearchFilm"
        Me.ButtonSearchFilm.Size = New System.Drawing.Size(81, 29)
        Me.ButtonSearchFilm.TabIndex = 3
        Me.ButtonSearchFilm.UseVisualStyleBackColor = False
        '
        'LabelNumberOfMovies
        '
        Me.LabelNumberOfMovies.AutoSize = True
        Me.LabelNumberOfMovies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNumberOfMovies.Location = New System.Drawing.Point(21, 432)
        Me.LabelNumberOfMovies.Name = "LabelNumberOfMovies"
        Me.LabelNumberOfMovies.Size = New System.Drawing.Size(144, 20)
        Me.LabelNumberOfMovies.TabIndex = 22
        Me.LabelNumberOfMovies.Text = "Number of Movies :"
        '
        'ButtonRefeshFilm
        '
        Me.ButtonRefeshFilm.BackColor = System.Drawing.Color.White
        Me.ButtonRefeshFilm.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonRefeshFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRefeshFilm.ForeColor = System.Drawing.Color.White
        Me.ButtonRefeshFilm.Image = CType(resources.GetObject("ButtonRefeshFilm.Image"), System.Drawing.Image)
        Me.ButtonRefeshFilm.Location = New System.Drawing.Point(25, 79)
        Me.ButtonRefeshFilm.Name = "ButtonRefeshFilm"
        Me.ButtonRefeshFilm.Size = New System.Drawing.Size(43, 33)
        Me.ButtonRefeshFilm.TabIndex = 23
        Me.ButtonRefeshFilm.UseVisualStyleBackColor = False
        '
        'dvgCustomer
        '
        Me.dvgCustomer.BackgroundColor = System.Drawing.Color.White
        Me.dvgCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dvgCustomer.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dvgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgCustomer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_customer, Me.cutomer})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dvgCustomer.DefaultCellStyle = DataGridViewCellStyle10
        Me.dvgCustomer.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dvgCustomer.Location = New System.Drawing.Point(531, 79)
        Me.dvgCustomer.Name = "dvgCustomer"
        Me.dvgCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgCustomer.Size = New System.Drawing.Size(264, 331)
        Me.dvgCustomer.TabIndex = 24
        '
        'id_customer
        '
        Me.id_customer.HeaderText = "ID"
        Me.id_customer.Name = "id_customer"
        Me.id_customer.Width = 60
        '
        'cutomer
        '
        Me.cutomer.HeaderText = "Full Name"
        Me.cutomer.Name = "cutomer"
        Me.cutomer.Width = 160
        '
        'LabelNumerOfCustomer
        '
        Me.LabelNumerOfCustomer.AutoSize = True
        Me.LabelNumerOfCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNumerOfCustomer.Location = New System.Drawing.Point(527, 432)
        Me.LabelNumerOfCustomer.Name = "LabelNumerOfCustomer"
        Me.LabelNumerOfCustomer.Size = New System.Drawing.Size(172, 20)
        Me.LabelNumerOfCustomer.TabIndex = 25
        Me.LabelNumerOfCustomer.Text = "Number of Customers :"
        '
        'TextBoxSearchCustomer
        '
        Me.TextBoxSearchCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearchCustomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBoxSearchCustomer.Location = New System.Drawing.Point(531, 28)
        Me.TextBoxSearchCustomer.Name = "TextBoxSearchCustomer"
        Me.TextBoxSearchCustomer.Size = New System.Drawing.Size(177, 29)
        Me.TextBoxSearchCustomer.TabIndex = 26
        '
        'ButtonSearchCustomer
        '
        Me.ButtonSearchCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonSearchCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSearchCustomer.ForeColor = System.Drawing.Color.White
        Me.ButtonSearchCustomer.Image = CType(resources.GetObject("ButtonSearchCustomer.Image"), System.Drawing.Image)
        Me.ButtonSearchCustomer.Location = New System.Drawing.Point(714, 28)
        Me.ButtonSearchCustomer.Name = "ButtonSearchCustomer"
        Me.ButtonSearchCustomer.Size = New System.Drawing.Size(81, 29)
        Me.ButtonSearchCustomer.TabIndex = 27
        Me.ButtonSearchCustomer.UseVisualStyleBackColor = False
        '
        'ButtonRefeshCustomer
        '
        Me.ButtonRefeshCustomer.BackColor = System.Drawing.Color.White
        Me.ButtonRefeshCustomer.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonRefeshCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRefeshCustomer.ForeColor = System.Drawing.Color.White
        Me.ButtonRefeshCustomer.Image = CType(resources.GetObject("ButtonRefeshCustomer.Image"), System.Drawing.Image)
        Me.ButtonRefeshCustomer.Location = New System.Drawing.Point(531, 79)
        Me.ButtonRefeshCustomer.Name = "ButtonRefeshCustomer"
        Me.ButtonRefeshCustomer.Size = New System.Drawing.Size(43, 33)
        Me.ButtonRefeshCustomer.TabIndex = 28
        Me.ButtonRefeshCustomer.UseVisualStyleBackColor = False
        '
        'PanelDemo
        '
        Me.PanelDemo.BackColor = System.Drawing.SystemColors.Control
        Me.PanelDemo.Controls.Add(Me.Label7)
        Me.PanelDemo.Controls.Add(Me.ComboBoxStore)
        Me.PanelDemo.Controls.Add(Me.Label6)
        Me.PanelDemo.Controls.Add(Me.LabelError)
        Me.PanelDemo.Controls.Add(Me.ComboBoxStaff)
        Me.PanelDemo.Controls.Add(Me.Label8)
        Me.PanelDemo.Controls.Add(Me.TextBoxReturnDate)
        Me.PanelDemo.Controls.Add(Me.TextBoxRentalDate)
        Me.PanelDemo.Controls.Add(Me.Label5)
        Me.PanelDemo.Controls.Add(Me.Label4)
        Me.PanelDemo.Controls.Add(Me.Label3)
        Me.PanelDemo.Controls.Add(Me.Label2)
        Me.PanelDemo.Controls.Add(Me.Label1)
        Me.PanelDemo.Controls.Add(Me.TextBoxRentalDuration)
        Me.PanelDemo.Controls.Add(Me.TextBoxDVDRental)
        Me.PanelDemo.Controls.Add(Me.TextBoxCustomer)
        Me.PanelDemo.Location = New System.Drawing.Point(852, 79)
        Me.PanelDemo.Name = "PanelDemo"
        Me.PanelDemo.Size = New System.Drawing.Size(383, 413)
        Me.PanelDemo.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(466, 353)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 16)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "*"
        '
        'ComboBoxStore
        '
        Me.ComboBoxStore.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxStore.FormattingEnabled = True
        Me.ComboBoxStore.Location = New System.Drawing.Point(180, 358)
        Me.ComboBoxStore.Name = "ComboBoxStore"
        Me.ComboBoxStore.Size = New System.Drawing.Size(177, 26)
        Me.ComboBoxStore.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 358)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 20)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Store :"
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelError.ForeColor = System.Drawing.Color.Red
        Me.LabelError.Location = New System.Drawing.Point(466, 308)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(13, 16)
        Me.LabelError.TabIndex = 45
        Me.LabelError.Text = "*"
        '
        'ComboBoxStaff
        '
        Me.ComboBoxStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxStaff.FormattingEnabled = True
        Me.ComboBoxStaff.Location = New System.Drawing.Point(180, 311)
        Me.ComboBoxStaff.Name = "ComboBoxStaff"
        Me.ComboBoxStaff.Size = New System.Drawing.Size(177, 26)
        Me.ComboBoxStaff.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(28, 311)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 20)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Staff :"
        '
        'TextBoxReturnDate
        '
        Me.TextBoxReturnDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxReturnDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBoxReturnDate.Location = New System.Drawing.Point(180, 260)
        Me.TextBoxReturnDate.Name = "TextBoxReturnDate"
        Me.TextBoxReturnDate.ReadOnly = True
        Me.TextBoxReturnDate.Size = New System.Drawing.Size(177, 26)
        Me.TextBoxReturnDate.TabIndex = 40
        '
        'TextBoxRentalDate
        '
        Me.TextBoxRentalDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxRentalDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBoxRentalDate.Location = New System.Drawing.Point(180, 206)
        Me.TextBoxRentalDate.Name = "TextBoxRentalDate"
        Me.TextBoxRentalDate.ReadOnly = True
        Me.TextBoxRentalDate.Size = New System.Drawing.Size(177, 26)
        Me.TextBoxRentalDate.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 20)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Return Date :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 20)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Rental Date :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 20)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Rental Duration :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "DVD Rental :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 20)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Customers Name :"
        '
        'TextBoxRentalDuration
        '
        Me.TextBoxRentalDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxRentalDuration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBoxRentalDuration.Location = New System.Drawing.Point(180, 157)
        Me.TextBoxRentalDuration.Name = "TextBoxRentalDuration"
        Me.TextBoxRentalDuration.Size = New System.Drawing.Size(177, 26)
        Me.TextBoxRentalDuration.TabIndex = 32
        '
        'TextBoxDVDRental
        '
        Me.TextBoxDVDRental.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDVDRental.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBoxDVDRental.Location = New System.Drawing.Point(180, 47)
        Me.TextBoxDVDRental.Name = "TextBoxDVDRental"
        Me.TextBoxDVDRental.Size = New System.Drawing.Size(177, 26)
        Me.TextBoxDVDRental.TabIndex = 31
        '
        'TextBoxCustomer
        '
        Me.TextBoxCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCustomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBoxCustomer.Location = New System.Drawing.Point(180, 104)
        Me.TextBoxCustomer.Name = "TextBoxCustomer"
        Me.TextBoxCustomer.Size = New System.Drawing.Size(177, 26)
        Me.TextBoxCustomer.TabIndex = 30
        '
        'LabelAmount
        '
        Me.LabelAmount.BackColor = System.Drawing.SystemColors.Control
        Me.LabelAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAmount.Location = New System.Drawing.Point(855, 516)
        Me.LabelAmount.Name = "LabelAmount"
        Me.LabelAmount.Size = New System.Drawing.Size(165, 62)
        Me.LabelAmount.TabIndex = 30
        Me.LabelAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxRentalRate
        '
        Me.TextBoxRentalRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxRentalRate.ForeColor = System.Drawing.Color.Green
        Me.TextBoxRentalRate.Location = New System.Drawing.Point(873, 529)
        Me.TextBoxRentalRate.Name = "TextBoxRentalRate"
        Me.TextBoxRentalRate.Size = New System.Drawing.Size(125, 38)
        Me.TextBoxRentalRate.TabIndex = 49
        Me.TextBoxRentalRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(849, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(386, 37)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Detail"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dvgPayment
        '
        Me.dvgPayment.BackgroundColor = System.Drawing.Color.White
        Me.dvgPayment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dvgPayment.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dvgPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgPayment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.customer_id, Me.staff_id, Me.rental_id, Me.amount})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dvgPayment.DefaultCellStyle = DataGridViewCellStyle12
        Me.dvgPayment.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dvgPayment.Location = New System.Drawing.Point(25, 477)
        Me.dvgPayment.Name = "dvgPayment"
        Me.dvgPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgPayment.Size = New System.Drawing.Size(770, 180)
        Me.dvgPayment.TabIndex = 51
        '
        'customer_id
        '
        Me.customer_id.HeaderText = "Customer ID"
        Me.customer_id.Name = "customer_id"
        Me.customer_id.Width = 190
        '
        'staff_id
        '
        Me.staff_id.HeaderText = "Staff ID"
        Me.staff_id.Name = "staff_id"
        Me.staff_id.Width = 160
        '
        'rental_id
        '
        Me.rental_id.HeaderText = "Rental ID"
        Me.rental_id.Name = "rental_id"
        Me.rental_id.Width = 200
        '
        'amount
        '
        Me.amount.HeaderText = "Amount"
        Me.amount.Name = "amount"
        Me.amount.Width = 175
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.Silver
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.Image = CType(resources.GetObject("ButtonSave.Image"), System.Drawing.Image)
        Me.ButtonSave.Location = New System.Drawing.Point(1032, 516)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(97, 62)
        Me.ButtonSave.TabIndex = 52
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.Silver
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.ForeColor = System.Drawing.Color.White
        Me.ButtonCancel.Image = CType(resources.GetObject("ButtonCancel.Image"), System.Drawing.Image)
        Me.ButtonCancel.Location = New System.Drawing.Point(1138, 516)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(97, 62)
        Me.ButtonCancel.TabIndex = 53
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'RentalPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.dvgPayment)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBoxRentalRate)
        Me.Controls.Add(Me.LabelAmount)
        Me.Controls.Add(Me.PanelDemo)
        Me.Controls.Add(Me.ButtonRefeshCustomer)
        Me.Controls.Add(Me.ButtonSearchCustomer)
        Me.Controls.Add(Me.TextBoxSearchCustomer)
        Me.Controls.Add(Me.LabelNumerOfCustomer)
        Me.Controls.Add(Me.dvgCustomer)
        Me.Controls.Add(Me.ButtonRefeshFilm)
        Me.Controls.Add(Me.LabelNumberOfMovies)
        Me.Controls.Add(Me.ButtonPaymentNow)
        Me.Controls.Add(Me.dvgFilm)
        Me.Controls.Add(Me.ButtonSearchFilm)
        Me.Controls.Add(Me.TextBoxSearchFilm)
        Me.Name = "RentalPage"
        Me.Size = New System.Drawing.Size(1275, 675)
        CType(Me.dvgFilm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvgCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDemo.ResumeLayout(False)
        Me.PanelDemo.PerformLayout()
        CType(Me.dvgPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxSearchFilm As TextBox
    Friend WithEvents dvgFilm As DataGridView
    Friend WithEvents ButtonPaymentNow As Button
    Friend WithEvents ButtonSearchFilm As Button
    Friend WithEvents LabelNumberOfMovies As Label
    Friend WithEvents ButtonRefeshFilm As Button
    Friend WithEvents dvgCustomer As DataGridView
    Friend WithEvents LabelNumerOfCustomer As Label
    Friend WithEvents TextBoxSearchCustomer As TextBox
    Friend WithEvents ButtonSearchCustomer As Button
    Friend WithEvents ButtonRefeshCustomer As Button
    Friend WithEvents PanelDemo As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxRentalDuration As TextBox
    Friend WithEvents TextBoxDVDRental As TextBox
    Friend WithEvents TextBoxCustomer As TextBox
    Friend WithEvents id_customer As DataGridViewTextBoxColumn
    Friend WithEvents cutomer As DataGridViewTextBoxColumn
    Friend WithEvents LabelError As Label
    Friend WithEvents ComboBoxStaff As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxReturnDate As TextBox
    Friend WithEvents TextBoxRentalDate As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBoxStore As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelAmount As Label
    Friend WithEvents id_film As DataGridViewTextBoxColumn
    Friend WithEvents title As DataGridViewTextBoxColumn
    Friend WithEvents rental_duration As DataGridViewTextBoxColumn
    Friend WithEvents rental_rate As DataGridViewTextBoxColumn
    Friend WithEvents TextBoxRentalRate As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dvgPayment As DataGridView
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents customer_id As DataGridViewTextBoxColumn
    Friend WithEvents staff_id As DataGridViewTextBoxColumn
    Friend WithEvents rental_id As DataGridViewTextBoxColumn
    Friend WithEvents amount As DataGridViewTextBoxColumn
    Friend WithEvents Timer As Timer
End Class

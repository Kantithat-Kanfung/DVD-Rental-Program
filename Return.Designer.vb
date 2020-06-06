<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCtrlReturn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCtrlReturn))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ButtonReturn = New System.Windows.Forms.Button()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonRefesh = New System.Windows.Forms.Button()
        Me.dvgCustomer = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.movie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rental_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.return_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.replacement_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.overdue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.day_difference = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dvgCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonReturn
        '
        Me.ButtonReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReturn.ForeColor = System.Drawing.Color.White
        Me.ButtonReturn.Location = New System.Drawing.Point(800, 585)
        Me.ButtonReturn.Name = "ButtonReturn"
        Me.ButtonReturn.Size = New System.Drawing.Size(206, 62)
        Me.ButtonReturn.TabIndex = 35
        Me.ButtonReturn.Text = "Return"
        Me.ButtonReturn.UseVisualStyleBackColor = False
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.ForeColor = System.Drawing.Color.Silver
        Me.TextBoxSearch.Location = New System.Drawing.Point(31, 24)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(1070, 29)
        Me.TextBoxSearch.TabIndex = 87
        '
        'ButtonSearch
        '
        Me.ButtonSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSearch.ForeColor = System.Drawing.Color.White
        Me.ButtonSearch.Image = CType(resources.GetObject("ButtonSearch.Image"), System.Drawing.Image)
        Me.ButtonSearch.Location = New System.Drawing.Point(1107, 24)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(128, 29)
        Me.ButtonSearch.TabIndex = 88
        Me.ButtonSearch.UseVisualStyleBackColor = False
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonCancel.Location = New System.Drawing.Point(1029, 585)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(206, 62)
        Me.ButtonCancel.TabIndex = 97
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'ButtonRefesh
        '
        Me.ButtonRefesh.BackColor = System.Drawing.Color.White
        Me.ButtonRefesh.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonRefesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRefesh.ForeColor = System.Drawing.Color.White
        Me.ButtonRefesh.Image = CType(resources.GetObject("ButtonRefesh.Image"), System.Drawing.Image)
        Me.ButtonRefesh.Location = New System.Drawing.Point(31, 88)
        Me.ButtonRefesh.Name = "ButtonRefesh"
        Me.ButtonRefesh.Size = New System.Drawing.Size(42, 34)
        Me.ButtonRefesh.TabIndex = 99
        Me.ButtonRefesh.UseVisualStyleBackColor = False
        '
        'dvgCustomer
        '
        Me.dvgCustomer.BackgroundColor = System.Drawing.Color.White
        Me.dvgCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dvgCustomer.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dvgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgCustomer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.customer_name, Me.movie, Me.rental_date, Me.return_date, Me.replacement_cost, Me.overdue, Me.day_difference})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dvgCustomer.DefaultCellStyle = DataGridViewCellStyle2
        Me.dvgCustomer.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dvgCustomer.Location = New System.Drawing.Point(31, 88)
        Me.dvgCustomer.Name = "dvgCustomer"
        Me.dvgCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgCustomer.Size = New System.Drawing.Size(1204, 460)
        Me.dvgCustomer.TabIndex = 98
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.Width = 50
        '
        'customer_name
        '
        Me.customer_name.HeaderText = "Customer Name"
        Me.customer_name.Name = "customer_name"
        Me.customer_name.Width = 200
        '
        'movie
        '
        Me.movie.HeaderText = "Movie"
        Me.movie.Name = "movie"
        Me.movie.Width = 200
        '
        'rental_date
        '
        Me.rental_date.HeaderText = "Rental Date"
        Me.rental_date.Name = "rental_date"
        Me.rental_date.Width = 200
        '
        'return_date
        '
        Me.return_date.HeaderText = "Return Date"
        Me.return_date.Name = "return_date"
        Me.return_date.Width = 200
        '
        'replacement_cost
        '
        Me.replacement_cost.HeaderText = "Rep_C"
        Me.replacement_cost.Name = "replacement_cost"
        '
        'overdue
        '
        Me.overdue.HeaderText = "Overdue"
        Me.overdue.Name = "overdue"
        Me.overdue.Width = 110
        '
        'day_difference
        '
        Me.day_difference.HeaderText = "D_dfr"
        Me.day_difference.Name = "day_difference"
        '
        'usrCtrlReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ButtonRefesh)
        Me.Controls.Add(Me.dvgCustomer)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.ButtonSearch)
        Me.Controls.Add(Me.ButtonReturn)
        Me.Name = "usrCtrlReturn"
        Me.Size = New System.Drawing.Size(1275, 675)
        CType(Me.dvgCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonReturn As Button
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonRefesh As Button
    Friend WithEvents dvgCustomer As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents customer_name As DataGridViewTextBoxColumn
    Friend WithEvents movie As DataGridViewTextBoxColumn
    Friend WithEvents rental_date As DataGridViewTextBoxColumn
    Friend WithEvents return_date As DataGridViewTextBoxColumn
    Friend WithEvents replacement_cost As DataGridViewTextBoxColumn
    Friend WithEvents overdue As DataGridViewTextBoxColumn
    Friend WithEvents day_difference As DataGridViewTextBoxColumn
End Class

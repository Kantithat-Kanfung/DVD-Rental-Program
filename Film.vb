Imports System.Data
Imports System.Globalization
Imports System.Data.SqlClient

Public Class Film

    Private getFilmID As String
    Private getTitle As String
    Private getReleaseYear As String
    Private getLanguage As String
    Private getRentalDuration As String
    Private getRentalRate As String
    Private getLength As String
    Private getReplacementCost As String
    Private getRating As String
    Private getLastUpdate As String
    Private getDescription As String

    Private CheckEventButtonAddClicked As Boolean = False
    Private CheckEventButtonEditClicked As Boolean = False
    Private CheckEventButtonDeleteClicked As Boolean = False

    Private info As TextInfo = CultureInfo.InvariantCulture.TextInfo

    Private Sub Film_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDatabase()

        LoadDataFilm()

        TextBoxSearch.Focus()

        ComboBoxLanguage.Hide()
        ComboBoxRating.Hide()
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        If TextBoxSearch.Text = "" Then
            TextBoxSearch.Text = "Please input a name actor!"

            ButtonAdd.Enabled = False
            ButtonEdit.Enabled = False
            ButtonDelete.Enabled = False
            ButtonCancel.Enabled = False
            ButtonSave.Enabled = False
        Else
            SearchFilm(TextBoxSearch.Text)

            TextBoxFilmID.Text = getFilmID
            TextBoxTitle.Text = getTitle
            TextBoxReleaseYear.Text = getReleaseYear
            TextBoxLanguage.Text = getLanguage
            TextBoxRentalDuration.Text = getRentalDuration
            TextBoxRentalRate.Text = getRentalRate
            TextBoxLength.Text = getLength
            TextBoxReplacementCost.Text = getReplacementCost
            TextBoxRating.Text = getRating
            TextBoxLastUpdate.Text = getLastUpdate
            TextBoxDescription.Text = getDescription

            ButtonAdd.Enabled = True
            ButtonEdit.Enabled = True
            ButtonDelete.Enabled = False
            ButtonCancel.Enabled = True

            TextBoxSearch.Clear()
        End If
        ButtonSave.Enabled = False
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        ButtonEdit.Enabled = False
        ButtonDelete.Enabled = False
        ButtonCancel.Enabled = True
        ButtonSave.Enabled = True

        TextBoxTitle.Text = ""
        TextBoxReleaseYear.Text = ""
        TextBoxLanguage.Text = ""
        TextBoxRentalDuration.Text = ""
        TextBoxRentalRate.Text = ""
        TextBoxLength.Text = ""
        TextBoxReplacementCost.Text = ""
        TextBoxRating.Text = ""
        TextBoxDescription.Text = ""

        TextBoxLanguage.Hide()
        TextBoxRating.Hide()

        TextBoxFilmID.ReadOnly = True
        TextBoxTitle.ReadOnly = False
        TextBoxReleaseYear.ReadOnly = False
        TextBoxLanguage.ReadOnly = False
        TextBoxRentalDuration.ReadOnly = False
        TextBoxRentalRate.ReadOnly = False
        TextBoxLength.ReadOnly = False
        TextBoxReplacementCost.ReadOnly = False
        TextBoxRating.ReadOnly = False
        TextBoxLastUpdate.ReadOnly = True
        TextBoxDescription.ReadOnly = False

        ComboBoxLanguage.Items.Add("English")
        ComboBoxLanguage.Items.Add("Italian")
        ComboBoxLanguage.Items.Add("Japanese")
        ComboBoxLanguage.Items.Add("Mandarin")
        ComboBoxLanguage.Items.Add("French")
        ComboBoxLanguage.Items.Add("German")

        ComboBoxLanguage.Show()

        ComboBoxRating.Items.Add("G")
        ComboBoxRating.Items.Add("PG")
        ComboBoxRating.Items.Add("PG-13")
        ComboBoxRating.Items.Add("R")
        ComboBoxRating.Items.Add("NC-17")

        ComboBoxRating.Show()

        CheckEventButtonAddClicked = True
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        ButtonAdd.Enabled = False
        ButtonDelete.Enabled = False
        ButtonCancel.Enabled = True
        ButtonSave.Enabled = True

        TextBoxLanguage.Hide()
        TextBoxRating.Hide()

        TextBoxFilmID.ReadOnly = True
        TextBoxTitle.ReadOnly = False
        TextBoxReleaseYear.ReadOnly = False
        TextBoxLanguage.ReadOnly = False
        TextBoxRentalDuration.ReadOnly = False
        TextBoxRentalRate.ReadOnly = False
        TextBoxLength.ReadOnly = False
        TextBoxReplacementCost.ReadOnly = False
        TextBoxRating.ReadOnly = False
        TextBoxLastUpdate.ReadOnly = True
        TextBoxDescription.ReadOnly = False

        ComboBoxLanguage.Items.Add("English")
        ComboBoxLanguage.Items.Add("Italian")
        ComboBoxLanguage.Items.Add("Japanese")
        ComboBoxLanguage.Items.Add("Mandarin")
        ComboBoxLanguage.Items.Add("French")
        ComboBoxLanguage.Items.Add("German")

        ComboBoxLanguage.Show()

        ComboBoxRating.Items.Add("G")
        ComboBoxRating.Items.Add("PG")
        ComboBoxRating.Items.Add("PG-13")
        ComboBoxRating.Items.Add("R")
        ComboBoxRating.Items.Add("NC-17")

        ComboBoxRating.Show()

        CheckEventButtonEditClicked = True
    End Sub

#Region "forDev"
    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        ' ... Something ...
    End Sub
#End Region

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        TextBoxSearch.Clear()

        TextBoxLanguage.Show()
        TextBoxRating.Show()

        ClearElement()

        ComboBoxLanguage.Hide()
        ComboBoxRating.Hide()

        ButtonAdd.Enabled = True
        ButtonEdit.Enabled = False
        ButtonDelete.Enabled = False
        ButtonCancel.Enabled = False
        ButtonSave.Enabled = False
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If CheckEventButtonAddClicked = True Then
            FormMsgProcessWarning.Msg("Do you want to add the data?")
            FormMsgProcessWarning.ShowDialog()
            If FormMsgProcessWarning.Result = True Then
                If TextBoxReleaseYear.Text = "" OrElse TextBoxTitle.Text = "" Then
                    FormMsgProcessError.ShowDialog()
                    FormMsgProcessError.Msg("Please input your data!")
                Else
                    AddFilm()
                    FormMsgProcessComplete.Msg("Save data completed.")
                    FormMsgProcessComplete.ShowDialog()

                    TextBoxSearch.Clear()

                    ButtonAdd.Enabled = True
                    ButtonEdit.Enabled = False
                    ButtonDelete.Enabled = False
                    ButtonCancel.Enabled = False
                    ButtonSave.Enabled = False

                    ClearElement()

                    ComboBoxLanguage.Hide()
                    ComboBoxRating.Hide()

                    TextBoxLanguage.Show()
                    TextBoxRating.Show()
                End If
            Else
                TextBoxSearch.Clear()

                ButtonAdd.Enabled = True
                ButtonEdit.Enabled = False
                ButtonDelete.Enabled = False
                ButtonCancel.Enabled = False
                ButtonSave.Enabled = False

                ButtonAdd.Enabled = True
                ButtonEdit.Enabled = False
                ButtonDelete.Enabled = False
                ButtonCancel.Enabled = False
                ButtonSave.Enabled = False

                ClearElement()

                ComboBoxLanguage.Hide()
                ComboBoxRating.Hide()

                TextBoxLanguage.Show()
                TextBoxRating.Show()

                CheckEventButtonAddClicked = False
            End If
        ElseIf CheckEventButtonEditClicked = True Then
            FormMsgProcessWarning.Msg("Do you want to edit the data?")
            FormMsgProcessWarning.ShowDialog()
            If FormMsgProcessWarning.Result = True Then
                If TextBoxFilmID.Text = "" OrElse TextBoxTitle.Text = "" Then
                    FormMsgProcessError.ShowDialog()
                    FormMsgProcessError.Msg("Please input your data!")
                Else
                    EditFilm()
                    FormMsgProcessComplete.Msg("Edit data completed.")
                    FormMsgProcessComplete.ShowDialog()

                    TextBoxSearch.Clear()

                    ButtonAdd.Enabled = True
                    ButtonEdit.Enabled = False
                    ButtonDelete.Enabled = False
                    ButtonCancel.Enabled = False
                    ButtonSave.Enabled = False

                    ButtonAdd.Enabled = True
                    ButtonEdit.Enabled = False
                    ButtonDelete.Enabled = False
                    ButtonCancel.Enabled = False
                    ButtonSave.Enabled = False

                    ClearElement()

                    ComboBoxLanguage.Hide()
                    ComboBoxRating.Hide()

                    TextBoxLanguage.Show()
                    TextBoxRating.Show()
                End If
            Else
                TextBoxSearch.Clear()

                ButtonAdd.Enabled = True
                ButtonEdit.Enabled = False
                ButtonDelete.Enabled = False
                ButtonCancel.Enabled = False
                ButtonSave.Enabled = False

                ClearElement()

                ComboBoxLanguage.Hide()
                ComboBoxRating.Hide()

                TextBoxLanguage.Show()
                TextBoxRating.Show()

                CheckEventButtonEditClicked = False
            End If
        ElseIf CheckEventButtonDeleteClicked = True Then
            FormMsgProcessWarning.Msg("Do you want to delete the data?")
            FormMsgProcessWarning.ShowDialog()
            If FormMsgProcessWarning.Result = True Then
                If TextBoxFilmID.Text = "" OrElse TextBoxTitle.Text = "" Then
                    FormMsgProcessError.ShowDialog()
                    FormMsgProcessError.Msg("Please input your data!")
                Else
                    DeleteFilm()
                    FormMsgProcessComplete.Msg("Delte data completed.")
                    FormMsgProcessComplete.ShowDialog()

                    TextBoxSearch.Clear()

                    ButtonAdd.Enabled = True
                    ButtonEdit.Enabled = False
                    ButtonDelete.Enabled = False
                    ButtonCancel.Enabled = False
                    ButtonSave.Enabled = False

                    ClearElement()

                    ComboBoxLanguage.Hide()
                    ComboBoxRating.Hide()

                    TextBoxLanguage.Show()
                    TextBoxRating.Show()
                End If
            Else
                TextBoxSearch.Clear()

                ButtonAdd.Enabled = True
                ButtonEdit.Enabled = False
                ButtonDelete.Enabled = False
                ButtonCancel.Enabled = False
                ButtonSave.Enabled = False

                ClearElement()

                ComboBoxLanguage.Hide()
                ComboBoxRating.Hide()

                TextBoxLanguage.Show()
                TextBoxRating.Show()

                CheckEventButtonDeleteClicked = False
            End If
        End If
    End Sub

    Private Sub ClearElement()
        For Each tbx In
                            {
                              TextBoxFilmID,
                              TextBoxTitle,
                              TextBoxReleaseYear,
                              TextBoxLanguage,
                              TextBoxRentalDuration,
                              TextBoxRentalRate,
                              TextBoxLength,
                              TextBoxReplacementCost,
                              TextBoxRating,
                              TextBoxLastUpdate,
                              TextBoxDescription
                            }
            tbx.Clear()
            tbx.ReadOnly = True
        Next
    End Sub

    Private Sub ButtonRefeshCustomer_Click(sender As Object, e As EventArgs) Handles ButtonRefeshCustomer.Click
        dvgFilm.Rows.Clear()
        LoadDataFilm()
    End Sub

    Private Sub dvgFilm_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgFilm.CellClick
        If IsNothing(dvgFilm.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
            Exit Sub
        Else
            TextBoxFilmID.Text = dvgFilm.Rows(e.RowIndex).Cells("film_id").Value.ToString()
            TextBoxTitle.Text = dvgFilm.Rows(e.RowIndex).Cells("title").Value.ToString()
            TextBoxReleaseYear.Text = dvgFilm.Rows(e.RowIndex).Cells("release_year").Value.ToString()
            TextBoxLanguage.Text = dvgFilm.Rows(e.RowIndex).Cells("language").Value.ToString()
            TextBoxRentalDuration.Text = dvgFilm.Rows(e.RowIndex).Cells("rental_duration").Value.ToString()
            TextBoxRentalRate.Text = dvgFilm.Rows(e.RowIndex).Cells("rental_rate").Value.ToString()
            TextBoxLength.Text = dvgFilm.Rows(e.RowIndex).Cells("length").Value.ToString()
            TextBoxReplacementCost.Text = dvgFilm.Rows(e.RowIndex).Cells("replacement_cost").Value.ToString()
            TextBoxRating.Text = dvgFilm.Rows(e.RowIndex).Cells("rating").Value.ToString()
            TextBoxLastUpdate.Text = dvgFilm.Rows(e.RowIndex).Cells("last_update").Value.ToString()
            TextBoxDescription.Text = dvgFilm.Rows(e.RowIndex).Cells("description").Value.ToString()
        End If

        ButtonAdd.Enabled = True
        ButtonEdit.Enabled = True
        ButtonDelete.Enabled = True
        ButtonCancel.Enabled = True
    End Sub

    Private Sub LoadDataFilm()
        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"
                                    SELECT
                                        f.film_id,
	                                    f.title,
	                                    f.release_year,
	                                    l.name AS language,
	                                    f.rental_duration,
	                                    f.rental_rate,
	                                    f.length,
	                                    f.replacement_cost,
                                    CASE
                                        WHEN
	                                    	f.rating = 'G' THEN 'G - General audiences'
	                                    WHEN
	                                    	f.rating = 'PG' THEN 'PG - Parental guidance suggested'
	                                    WHEN
	                                    	f.rating = 'PG-13' THEN '[PG-13] - Parents strongly cautioned'
	                                    WHEN
	                                    	f.rating = 'R' THEN 'R - Restricted'
	                                    WHEN
	                                    	f.rating = 'NC-17' THEN '[NC-17] - Adults Only'
	                                    ELSE ''
                                    END AS rating,
                                        f.last_update,
	                                    f.description
                                    FROM
                                        film AS f
                                    RIGHT JOIN
                                    	language AS l ON l.language_id = f.language_id;
                                "

            Dim Cmd As New SqlCommand(Sql, Connection)

            Dim Reader As SqlDataReader = Cmd.ExecuteReader()

            While Reader.Read()
                dvgFilm.Rows.Add(
                                Reader("film_id"),
                                Reader("title"),
                                Reader("release_year"),
                                Reader("language"),
                                Reader("rental_duration"),
                                Reader("rental_rate"),
                                Reader("length"),
                                Reader("replacement_cost"),
                                Reader("rating"),
                                Reader("last_update"),
                                Reader("description")
                                )
            End While

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try

        LabelNumberOfFilm.Text = $"Number of Actor : {dvgFilm.Rows.Count - 1} Items"
    End Sub

    Private Sub SearchFilm(ByVal title As String)
        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"
                                    SELECT
                                        f.film_id,
	                                    f.title,
	                                    f.release_year,
	                                    l.name AS language,
	                                    f.rental_duration,
	                                    f.rental_rate,
	                                    f.length,
	                                    f.replacement_cost,
                                    CASE
                                        WHEN
	                                    	f.rating = 'G' THEN 'G - General audiences'
	                                    WHEN
	                                    	f.rating = 'PG' THEN 'PG - Parental guidance suggested'
	                                    WHEN
	                                    	f.rating = 'PG-13' THEN '[PG-13] - Parents strongly cautioned'
	                                    WHEN
	                                    	f.rating = 'R' THEN 'R - Restricted'
	                                    WHEN
	                                    	f.rating = 'NC-17' THEN '[NC-17] - Adults Only'
	                                    ELSE ''
                                    END AS rating,
                                        f.last_update,
	                                    f.description
                                    FROM
                                        film AS f
                                    RIGHT JOIN
                                    	language AS l ON l.language_id = f.language_id
                                    WHERE
                                    	f.title LIKE '%{title}%';
                                            
                                "

            Dim Cmd As New SqlCommand(Sql, Connection)

            Dim Reader As SqlDataReader = Cmd.ExecuteReader()

            If Reader.Read() Then
                getFilmID = Reader("film_id")
                getTitle = Reader("title")
                getReleaseYear = Reader("release_year")
                getLanguage = Reader("language")
                getRentalDuration = Reader("rental_duration")
                getRentalRate = Reader("rental_rate")
                getLength = Reader("length")
                getReplacementCost = Reader("replacement_cost")
                getRating = Reader("rating")
                getLastUpdate = Reader("last_update")
                getDescription = Reader("description")
            End If

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try

        LabelNumberOfFilm.Text = $"Number of Actor : {dvgFilm.Rows.Count.ToString() - 1} Items"
    End Sub

    Public Sub AddFilm()
        Dim TbxTitle As String = info.ToTitleCase(TextBoxTitle.Text)

        Dim CbxLanguage As String = ""
        Dim CbxRating As String = ""

        Select Case ComboBoxLanguage.SelectedItem
            Case "English"
                CbxRating = "English"
            Case "Italian"
                CbxRating = "Italian"
            Case "Japanese"
                CbxRating = "Japanese"
            Case "Mandarin"
                CbxRating = "Mandarin"
            Case "French"
                CbxRating = "French"
            Case "German"
                CbxRating = "German"
        End Select

        Select Case ComboBoxRating.SelectedItem
            Case "G"
                CbxRating = "G"
            Case "PG"
                CbxRating = "PG"
            Case "PG-13"
                CbxRating = "PG-13"
            Case "R"
                CbxRating = "R"
            Case "NC-17"
                CbxRating = "NC-17"
        End Select

        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"
                                    INSERT INTO
                                        film
                                            (
                                                title,
                                                description,
                                                release_year,
                                                language_id,
                                                rental_duration,
                                                rental_rate,
                                                length,
                                                replacement_cost,
                                                rating,
                                                last_update
                                            )
                                        VALUES
                                            (
                                               '{TbxTitle}',
                                               '{TextBoxDescription.Text}',
                                               '{TextBoxReleaseYear.Text}',
                                               '{CbxLanguage}',
                                               '{TextBoxRentalDuration.Text}',
                                               '{TextBoxRentalRate.Text}',
                                               '{TextBoxLength.Text}',
                                               '{TextBoxReplacementCost.Text}',
                                               '{CbxRating}',
                                               GETDATE()
                                            );
                                "

            Dim Cmd As New SqlCommand(Sql, Connection)

            Cmd.ExecuteNonQuery()

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try
    End Sub

    Public Sub EditFilm()
        Dim TbxTitle As String = info.ToTitleCase(TextBoxTitle.Text)

        Dim CbxLanguage As String = ""
        Dim CbxRating As String = ""

        Select Case ComboBoxLanguage.SelectedItem
            Case "English"
                CbxRating = "English"
            Case "Italian"
                CbxRating = "Italian"
            Case "Japanese"
                CbxRating = "Japanese"
            Case "Mandarin"
                CbxRating = "Mandarin"
            Case "French"
                CbxRating = "French"
            Case "German"
                CbxRating = "German"
        End Select

        Select Case ComboBoxRating.SelectedItem
            Case "G"
                CbxRating = "G"
            Case "PG"
                CbxRating = "PG"
            Case "PG-13"
                CbxRating = "PG-13"
            Case "R"
                CbxRating = "R"
            Case "NC-17"
                CbxRating = "NC-17"
        End Select

        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"
                                   UPDATE
                                        Film
                                    SET
                                        title = '{TbxTitle}',
                                        description = '{TextBoxDescription.Text}',
                                        release_year = CONVERT(INT, '{TextBoxReleaseYear.Text}'),
                                        language_id = CONVERT(INT, '{CbxLanguage}'),
                                        rental_duration = CONVERT(INT, '{TextBoxRentalDuration.Text}'),
                                        rental_rate = CONVERT(DECIMAL, '{TextBoxRentalRate.Text}'),
                                        length = '{TextBoxLength.Text}',
                                        replacement_cost = CONVERT(DECIMAL, '{TextBoxReplacementCost.Text}'),
                                        rating = '{CbxRating}',
                                        last_update =  GETDATE()
                                    WHERE
                                        film_id = CONVERT(INT, {getFilmID});
                                "

            Dim Cmd As New SqlCommand(Sql, Connection)

            Cmd.ExecuteNonQuery()

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try
    End Sub

#Region "forDev"
    Public Sub DeleteFilm()
        Try
            Dim Connection As New SqlConnection(ConStr)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim Sql As String = $"
                                    DELETE TABLE
                                        film
                                    WHERE
                                        film_id = CONVERT(INT, {getFilmID});
                                "

            Dim Cmd As New SqlCommand(Sql, Connection)

            Cmd.ExecuteNonQuery()

            Connection.Close()
        Catch ex As Exception
            WriteLogMistakeQuery(ex.Message.ToString())
        End Try
    End Sub
#End Region

End Class

Imports System.Data
Imports System.Data.SqlClient

Public Class FormMainScreen

    Private Sub FormMainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer.Start()
        LabelFormMainScreen.Text = "FormMainScreen"
        LabelUsername.Text = FormLogin.GetFirstName & " " & FormLogin.GetLastName
    End Sub

    Private Sub FormMainScreen_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                ButtonFilm_Click(sender, e)
            Case Keys.F2
                ButtonRental_Click(sender, e)
            Case Keys.F3
                ButtonReturn_Click_1(sender, e)
            Case Keys.F4
                ButtonMembership_Click(sender, e)
            Case Keys.F5
                ButtonCustomer_Click(sender, e)
            Case Keys.F6
                ButtonStaff_Click(sender, e)
            Case Keys.F7
                ButtonActor_Click(sender, e)
            Case Keys.F8
                ButtonInventory_Click(sender, e)
            Case Keys.F9
                ButtonStore_Click(sender, e)
            Case Keys.F10
                ButtonReport_Click(sender, e)
            Case Keys.Alt And Keys.F4
                Application.Exit()
        End Select
    End Sub

    Private Sub ButtonFilm_Click(sender As Object, e As EventArgs) Handles ButtonFilm.Click
        PanelMainScreen.Controls.Clear()
        Dim CtrlFilm = New Film
        PanelMainScreen.Controls.Add(CtrlFilm)
    End Sub

    Public Sub ButtonRental_Click(sender As Object, e As EventArgs) Handles ButtonRental.Click
        PanelMainScreen.Controls.Clear()
        Dim CtrlRental = New RentalPage
        PanelMainScreen.Controls.Add(CtrlRental)
    End Sub

    Private Sub ButtonReturn_Click_1(sender As Object, e As EventArgs) Handles ButtonReturn.Click
        PanelMainScreen.Controls.Clear()
        Dim CtrlReturn = New usrCtrlReturn
        PanelMainScreen.Controls.Add(CtrlReturn)
    End Sub

    Private Sub ButtonMembership_Click(sender As Object, e As EventArgs) Handles ButtonMembership.Click
        PanelMainScreen.Controls.Clear()
        Dim CtrlMembership = New Membership
        PanelMainScreen.Controls.Add(CtrlMembership)
    End Sub

    Private Sub ButtonReport_Click(sender As Object, e As EventArgs) Handles ButtonReport.Click
        PanelMainScreen.Controls.Clear()
        Dim CtrlReport = New Report
        PanelMainScreen.Controls.Add(CtrlReport)
    End Sub

    Private Sub ButtonCustomer_Click(sender As Object, e As EventArgs) Handles ButtonCustomer.Click
        PanelMainScreen.Controls.Clear()
        Dim CtrlCustomer = New Customer
        PanelMainScreen.Controls.Add(CtrlCustomer)
    End Sub

    Private Sub ButtonStaff_Click(sender As Object, e As EventArgs) Handles ButtonStaff.Click
        PanelMainScreen.Controls.Clear()
        Dim CtrlStaff = New Staff
        PanelMainScreen.Controls.Add(CtrlStaff)
    End Sub

    Private Sub ButtonActor_Click(sender As Object, e As EventArgs) Handles ButtonActor.Click
        PanelMainScreen.Controls.Clear()
        Dim CtrlActor = New Actor
        PanelMainScreen.Controls.Add(CtrlActor)
    End Sub

    Private Sub ButtonInventory_Click(sender As Object, e As EventArgs) Handles ButtonInventory.Click
        PanelMainScreen.Controls.Clear()
        Dim CtrlInventory = New Inventory
        PanelMainScreen.Controls.Add(CtrlInventory)
    End Sub

    Private Sub ButtonStore_Click(sender As Object, e As EventArgs) Handles ButtonStore.Click
        PanelMainScreen.Controls.Clear()
        Dim CtrlStore = New Store
        PanelMainScreen.Controls.Add(CtrlStore)
    End Sub

    Private Sub ButtonGoToMainPage_Click(sender As Object, e As EventArgs) Handles ButtonGoToMainPage.Click
        Dim MainScreen = New FormMainScreen
        Me.Close()
        MainScreen.Show()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        LabelDateTime.Text = $"{DateAndTime.DateString} {DateAndTime.TimeString}"
    End Sub

    ' About Applicaion
    Private Sub ButtonAboutApplication_Click(sender As Object, e As EventArgs) Handles ButtonAboutApplication.Click
        AboutApplication.ShowDialog()
    End Sub

    ' Exit Application
    Private Sub PictureBoxExitApplication_Click(sender As Object, e As EventArgs) Handles PictureBoxExitApplication.Click
        Application.Exit()
    End Sub

End Class


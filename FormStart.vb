Public Class FormStart

    Private Sub FormStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer.Interval = 5000
        Timer.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Timer.Stop()
        Me.Hide()
        FormLogin.ShowDialog()
    End Sub

End Class
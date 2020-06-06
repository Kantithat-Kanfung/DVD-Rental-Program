Public Class FormMsgProcessComplete

    Public Result As Boolean

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Result = True
        Me.Close()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Result = False
        Me.Close()
    End Sub

    Public Sub Msg(ByVal Detail As String)
        LabelMassage.Text = Detail
    End Sub

End Class
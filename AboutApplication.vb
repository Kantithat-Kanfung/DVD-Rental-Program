Public Class AboutApplication

    Private Sub AboutApplication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelProductName.Text = ProductName
        LabelVersion.Text = Version
        LabelCopyright.Text = Copyright
        LabelCompany.Text = Company
        LabelDescription.Text = Description
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Me.Close()
    End Sub

End Class
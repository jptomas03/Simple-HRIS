Public Class MotherForm

    Private Sub LogoutBT_Click(sender As Object, e As EventArgs) Handles LogoutBT.Click
        LoginForm.Show()
        Me.Hide()
    End Sub
End Class
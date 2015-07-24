Public Class MotherForm
    Private Sub LogoutBT_Click(sender As Object, e As EventArgs) Handles LogoutBT.Click
        LoginForm.StaffIDTB.Text = ""
        LoginForm.PasswordTB.Text = ""
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub InsertEmployeeButton_Click(sender As Object, e As EventArgs) Handles InsertEmployeeButton.Click
        InsertEmployeeForm.Show()
    End Sub
End Class
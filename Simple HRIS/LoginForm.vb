﻿Public Class LoginForm
  
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        MotherForm.Show()
        Me.Hide()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        StaffIDTB.Text = ""
        PasswordTB.Text = ""
    End Sub
End Class

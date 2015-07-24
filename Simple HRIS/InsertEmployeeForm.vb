Imports System.Data.OleDb
Imports System.Data

Public Class InsertEmployeeForm
    Dim cnn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim strConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\db_hris.accdb;"
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        cmd.CommandText = "INSERT INTO tb_employee (employee_id,first_name,last_name,address,`email`,`password`) VALUES ('" & EmployeeIDTB.Text & "','" & FirstNameTB.Text & "','" & LastNameTB.Text & "','" & AddressTB.Text & "','" & EmailTB.Text & "','" & PasswordTB.Text & "')"
        cmd.Connection = cnn
        cmd.ExecuteNonQuery()
        MsgBox("Recorded Successfully")
        EmployeeIDTB.Text = ""
        FirstNameTB.Text = ""
        LastNameTB.Text = ""
        AddressTB.Text = ""
        EmailTB.Text = ""
        PasswordTB.Text = ""
        cnn.Close()
        Me.Close()
    End Sub

    Private Sub InsertEmployeeForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        cnn.ConnectionString = strConnectionString
        cnn.Open()
    End Sub
End Class
Imports System.Data.OleDb
Imports System.Data

Public Class LoginForm
    Dim cnn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand

    Dim strConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\db_hris.accdb;"
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        cmd.CommandText = "Select last_name,first_name,job_id,department_id FROM tb_employee WHERE employee_id='" & StaffIDTB.Text & "' AND password='" & PasswordTB.Text & "'"

        cmd.Connection = cnn
        Dim row As OleDbDataReader = cmd.ExecuteReader
        
        If row.Read = True Then
            MotherForm.NameLabel.Text = row.Item(1) & " " & row.Item(0)
            Dim job As String = row.Item(2)
            Dim department As String = row.Item(3)
            cmd.CommandText = "Select job_title FROM tb_jobs WHERE job_id='" & job & "'"
            row.Close()
            row = cmd.ExecuteReader
            If row.Read = True Then
                MotherForm.JobLabel.Text = row.Item(0)
            End If
            cmd.CommandText = "Select department_name FROM tb_department WHERE department_id='" & department & "'"
            row.Close()
            row = cmd.ExecuteReader
            If row.Read = True Then
                MotherForm.DepartmentLabel.Text = row.Item(0)
            End If
            row.Close()
            cnn.Close()
        End If

        MotherForm.Show()
        Me.Hide()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        StaffIDTB.Text = ""
        PasswordTB.Text = ""
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = strConnectionString
        cnn.Open()
    End Sub
End Class

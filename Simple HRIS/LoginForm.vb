'Imports System.Data.OleDb
'Imports System.Data

Imports MySql.Data.MySqlClient
Public Class LoginForm

    'Dim cnn As New OleDb.OleDbConnection
    'Dim cmd As New OleDb.OleDbCommand

    'Dim strConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\db_hris.accdb;"
    Dim conn As New MySqlConnection
    Dim stm As String = "SELECT VERSION()"
    Dim connString As String
    Dim cmd As MySqlCommand

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click

        cmd = New MySqlCommand(stm, conn)
        cmd.Connection = conn
        cmd.CommandText = "select employee.employee_id, employee.hired_date, department.department_name, job.job_title from tb_employee employee inner join tb_department department on employee.department_id = department.department_id inner join tb_jobs job on employee.job_id = job.job_id WHERE employee_id = @employee_id AND password = @password"
        cmd.Prepare()
        cmd.Parameters.AddWithValue("@employee_id", StaffIDTB.Text)
        cmd.Parameters.AddWithValue("@password", PasswordTB.Text)

        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        While reader.Read()
            MotherForm.employee_id = reader("employee_id").ToString()
            MotherForm.department_name = reader("department_name").ToString()
            MotherForm.job_title = reader("job_title").ToString()
            MotherForm.hired_date = reader("hired_date").ToString()
        End While
        If Not MotherForm.employee_id = "" Then
            MotherForm.Show()
            Me.Close()
        Else
            MsgBox("Incorrect ID/Password")
        End If


        StaffIDTB.Text = ""
        PasswordTB.Text = ""
        conn.Close()
        conn.Open()

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        StaffIDTB.Text = ""
        PasswordTB.Text = ""
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ConnectToMySql()
    End Sub

    Private Sub ConnectToMySql()
                
        connString = "server=localhost;" _
                   & "uid=root;" _
                   & "pwd=a7ulbxvinh8e;" _
                   & "database=db_hris"

        Try
            conn.ConnectionString = connString
            conn.Open()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            Select Case ex.Number
                Case 0
                    MessageBox.Show("Cannot connect to server. Contact administrator")
                Case 1045
                    MessageBox.Show("Invalid username/password, please try again")
                Case Else
                    MessageBox.Show(ex.Message)
            End Select
        End Try
    End Sub
End Class

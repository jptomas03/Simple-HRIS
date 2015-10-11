Imports MySql.Data.MySqlClient

Public Class InsertEmployeeForm
    Dim conn As New MySqlConnection
    Dim stm As String = "SELECT VERSION()"
    Dim connString As String
    Dim cmd As MySqlCommand
    Dim read As MySqlDataReader
    Dim employee_id As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FirstNameTB.Text = ""
        LastNameTB.Text = ""
        MiddleNameTB.Text = ""
        EmailTB.Text = ""
        ContactTB.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not AdminForm.employee_id = "" Then
            AdminForm.Show()
        Else
            LoginForm.Show()
        End If
        Me.Close()

    End Sub


    Private Sub ConnectToMySql()

        connString = "server=localhost;" _
                   & "uid=hris;" _
                   & "pwd=dbms;" _
                   & "database=db_hris"

        Try
            conn.ConnectionString = connString
            conn.Open()
            conn.Close()

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

    Private Sub InsertEmployeeForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ConnectToMySql()
        conn.Open()
        cmd = New MySqlCommand(stm, conn)
        cmd.Connection = conn
        cmd.CommandText = "select count(*) from tb_employee;"
        employee_id = cmd.ExecuteScalar() + 1
        EmployeeLabel.Text = employee_id
        cmd.CommandText = "Select job_title from tb_jobs;"

        read = cmd.ExecuteReader()

        While read.Read()
            JobCB.Items.Add(read("job_title").ToString())
        End While

        conn.Close()
        conn.Open()
        cmd.CommandText = "Select department_name from tb_department;"

        read = cmd.ExecuteReader()

        While read.Read()
            DeptCB.Items.Add(read("department_name").ToString())
        End While
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.Open()
        cmd.CommandText = "insert into tb_employee(employee_id, department_id, job_id, password) values(@employee_id, (select department_id from tb_department where department_name = @department_name), (select job_id from tb_jobs where job_title = @job_title), @password);"
        cmd.Parameters.AddWithValue("@employee_id", employee_id)
        cmd.Parameters.AddWithValue("@department_name", DeptCB.SelectedItem)
        cmd.Parameters.AddWithValue("@job_title", JobCB.SelectedItem)
        cmd.Parameters.AddWithValue("@password", PasswordTB.Text)

        cmd.ExecuteNonQuery()

        conn.Close()
        conn.Open()

        cmd.CommandText = "insert into tb_personal_info(employee_id, last_name, first_name, middle_name, email, contacts) values(@employee_id, @last_name, @first_name, @middle_name, @email, @contacts);"

        'cmd.Parameters.AddWithValue("@personal_id", employee_id)
        cmd.Parameters.AddWithValue("@last_name", LastNameTB.Text)
        cmd.Parameters.AddWithValue("@first_name", FirstNameTB.Text)
        cmd.Parameters.AddWithValue("@middle_name", MiddleNameTB.Text)
        cmd.Parameters.AddWithValue("@email", EmailTB.Text)
        cmd.Parameters.AddWithValue("@contacts", ContactTB.Text)

        cmd.ExecuteNonQuery()

        MsgBox("Welcome " + LastNameTB.Text + ", " + FirstNameTB.Text + " " + MiddleNameTB.Text + "" & vbCrLf & "Your Staff ID is " + employee_id)

        If Not AdminForm.employee_id = "" Then
            AdminForm.Show()
        Else
            LoginForm.Show()
        End If
        Me.Close()
    End Sub
End Class
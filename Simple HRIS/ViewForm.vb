Imports MySql.Data.MySqlClient

Public Class ViewForm
    

    Dim employee_id As String = SearchFor.employee_id
    Dim department_name As String
    Dim job_title As String
    Dim hired_date As String

    Dim last_name As String
    Dim first_name As String
    Dim middle_name As String
    Dim gender As String
    Dim zip_code As String
    Dim state As String
    Dim city As String
    Dim email As String
    Dim contacts As String

    Dim department As String
    Dim job As String

    Dim school As String
    Dim school_zip As String
    Dim school_state As String
    Dim school_city As String
    Dim year_graduated As String

    Dim conn As New MySqlConnection
    Dim stm As String = "SELECT VERSION()"
    Dim connString As String
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader

  

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SearchFor.Show()
        Me.Close()
    End Sub

    Private Sub MotherForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        ConnectToMySql()

        cmd = New MySqlCommand(stm, conn)
        cmd.Connection = conn
        cmd.CommandText = "select employee.employee_id, employee.hired_date, department.department_name, job.job_title from tb_employee employee inner join tb_department department on employee.department_id = department.department_id inner join tb_jobs job on employee.job_id = job.job_id WHERE employee_id = @employee_id;"
        cmd.Prepare()

        cmd.Parameters.AddWithValue("@employee_id", employee_id)

        reader = cmd.ExecuteReader()

        While reader.Read()
            department_name = reader("department_name").ToString()
            job_title = reader("job_title").ToString()
            hired_date = reader("hired_date").ToString()
        End While

        DeptTB.Text = department_name
        JobTB.Text = job_title
        HiredLabel.Text = hired_date
        conn.Close()
        conn.Open()

        cmd = New MySqlCommand(stm, conn)
        cmd.Connection = conn
        cmd.CommandText = "select personal.last_name, personal.first_name, personal.middle_name, gender.gender_class, zip.zip_code, zip.state, city.city_name, personal.email, personal.contacts from tb_personal_info personal inner join tb_gender gender on personal.gender_id = gender.gender_id inner join tb_zip zip on personal.zip_id = zip.zip_id inner join tb_city city on zip.city_id = city.city_id where personal.employee_id = @employee_id;"
        cmd.Prepare()

        cmd.Parameters.AddWithValue("@employee_id", employee_id)
        reader = cmd.ExecuteReader()
        While reader.Read()
            last_name = reader("last_name").ToString()
            first_name = reader("first_name").ToString()
            middle_name = reader("middle_name").ToString()
            gender = reader("gender_class").ToString()
            zip_code = reader("zip_code")
            state = reader("state")
            city = reader("city_name")
            email = reader("email")
            contacts = reader("contacts")
        End While
        conn.Close()
        conn.Open()

        cmd = New MySqlCommand(stm, conn)
        cmd.Connection = conn
        cmd.CommandText = "select school.school_name, zip.zip_code, zip.state, city.city_name, education.year_graduated from tb_education education inner join tb_school school on education.school_id = school.school_id inner join tb_zip zip on school.zip_id = zip.zip_id inner join tb_city city on zip.city_id = city.city_id where education.employee_id = @employee_id;"
        cmd.Prepare()
        cmd.Parameters.AddWithValue("@employee_id", employee_id)
        reader = cmd.ExecuteReader()

        While reader.Read()
            school = reader("school_name").ToString()
            school_city = reader("city_name").ToString()
            school_state = reader("state").ToString()
            school_zip = reader("zip_code").ToString()
            year_graduated = reader("year_graduated").ToString()
        End While
        conn.Close()
        conn.Open()

        NameTB.Text = last_name + ", " + first_name + " " + middle_name
        DeptTB.Text = department_name
        JobTB.Text = job_title
        HiredLabel.Text = hired_date

        AddressTB.Text = state + ", " + city + " " + zip_code
        EmailTB.Text = email
        ContactTB.Text = contacts

        SchoolTB.Text = school
        SchoolAddressTB.Text = school_state + ", " + school_city + " " + school_zip
        YearTB.Text = year_graduated


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
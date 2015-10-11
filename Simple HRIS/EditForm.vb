Imports MySql.Data.MySqlClient
Public Class EditForm

    Dim conn As New MySqlConnection
    Dim stm As String = "SELECT VERSION()"
    Dim connString As String
    Dim cmd As MySqlCommand

    Private Sub CancelBT_Click(sender As Object, e As EventArgs) Handles CancelBT.Click
        Me.Close()
        MotherForm.Show()
    End Sub

    Private Sub fillCombo()
        ConnectToMySql()

        cmd = New MySqlCommand(stm, conn)
        cmd.Connection = conn
        cmd.CommandText = "select zip_code, state from tb_zip;"
        cmd.Prepare()

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            StateCB.Items.Add(reader("state").ToString())
            ZipCB.Items.Add(reader("zip_code").ToString())
            StateCB2.Items.Add(reader("state").ToString())
            ZipCB2.Items.Add(reader("zip_code").ToString())
        End While
        conn.Close()
        conn.Open()

        cmd = New MySqlCommand(stm, conn)
        cmd.Connection = conn
        cmd.CommandText = "select city_name from tb_city;"

        reader = cmd.ExecuteReader()

        While reader.Read()
            CityCB.Items.Add(reader("city_name").ToString())
            CityCB2.Items.Add(reader("city_name").ToString())
        End While
        conn.Close()

        conn.Open()

        cmd = New MySqlCommand(stm, conn)
        cmd.Connection = conn
        cmd.CommandText = "select school_name from tb_school;"

        reader = cmd.ExecuteReader()

        While reader.Read()
            SchoolCB.Items.Add(reader("school_name").ToString())
        End While
        conn.Close()
    End Sub

    Private Sub EditForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        fillCombo()
        FirstNameTB.Text = MotherForm.first_name
        MiddleNameTB.Text = MotherForm.middle_name
        LastNameTB.Text = MotherForm.last_name
        StateCB.Text = MotherForm.state
        CityCB.Text = MotherForm.city
        ZipCB.Text = MotherForm.zip_code
        EmailTB.Text = MotherForm.email
        ContactTB.Text = MotherForm.contacts

        SchoolCB.Text = MotherForm.school
        StateCB2.Text = MotherForm.school_state
        CityCB2.Text = MotherForm.school_city
        ZipCB2.Text = MotherForm.school_zip
        YearTB.Text = MotherForm.year_graduated
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

    Private Sub SaveBT_Click(sender As Object, e As EventArgs) Handles SaveBT.Click
        conn.Open()


        cmd = New MySqlCommand(stm, conn)
        cmd.Connection = conn
        cmd.CommandText = "update tb_personal_info set last_name = @last_name, first_name = @first_name, middle_name = @middle_name, zip_id = (select zip_id from tb_zip where zip_code = @zip_code), email = @email, contacts = @contacts where employee_id = @employee_id;"
        cmd.Prepare()

        cmd.Parameters.AddWithValue("@last_name", LastNameTB.Text)
        cmd.Parameters.AddWithValue("@first_name", FirstNameTB.Text)
        cmd.Parameters.AddWithValue("@middle_name", MiddleNameTB.Text)
        cmd.Parameters.AddWithValue("@zip_code", ZipCB.SelectedItem)
        cmd.Parameters.AddWithValue("@email", EmailTB.Text)
        cmd.Parameters.AddWithValue("@contacts", ContactTB.Text)
        cmd.Parameters.AddWithValue("@employee_id", MotherForm.employee_id)
        cmd.ExecuteNonQuery()

        conn.Close()
        conn.Open()

        cmd = New MySqlCommand(stm, conn)
        cmd.Connection = conn
        cmd.CommandText = "update tb_education set school_id = (select school_id from tb_school where school_name = @school_name) where employee_id = @employee_id;"
        cmd.Prepare()

        cmd.Parameters.AddWithValue("@school_name", SchoolCB.SelectedItem)
        cmd.Parameters.AddWithValue("@employee_id", MotherForm.employee_id)
        cmd.ExecuteNonQuery()

        Dim employee_id As String = MotherForm.employee_id
        Dim department_name As String = MotherForm.department_name
        Dim job_title As String = MotherForm.job_title
        Dim hired_date As String = MotherForm.hired_date
        MotherForm.Close()
        MotherForm.employee_id = employee_id
        MotherForm.department_name = department_name
        MotherForm.job_title = job_title
        MotherForm.hired_date = hired_date
        MotherForm.Show()
        Me.Close()

        'Dim reader As MySqlDataReader = cmd.ExecuteReader()
    End Sub
End Class
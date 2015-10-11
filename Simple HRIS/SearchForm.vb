Imports MySql.Data.MySqlClient

Public Class SearchFor
    Dim conn As New MySqlConnection
    Dim stm As String = "SELECT VERSION()"
    Dim connString As String
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim employee_id_index As New Collection
    Public employee_id As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EmployeeList.Items.Clear()

        Dim search() As String = Split(SearchTB.Text)

        
        conn.Close()

        For i As Integer = 0 To search.Count - 1
            Dim temp As String
            Dim notExist As Boolean = True

            conn.Open()
            cmd = New MySqlCommand(stm, conn)
            cmd.Connection = conn
            cmd.CommandText = "select employee_id, last_name, first_name from tb_personal_info where (last_name like @name or first_name like @name) and employee_id > 1;"
            cmd.Prepare()

            cmd.Parameters.AddWithValue("@name", "%" + search(i).ToString() + "%")

            reader = cmd.ExecuteReader()

            While reader.Read()
                temp = reader("last_name").ToString() + " " + reader("first_name").ToString()
                For j As Integer = 0 To EmployeeList.Items.Count - 1
                    If temp = EmployeeList.Items.Item(j) Then
                        notExist = False
                        Exit For
                    End If
                Next

                If notExist = True Then
                    EmployeeList.Items.Add(temp)
                    employee_id_index.Add(reader("employee_id").ToString())
                End If
            End While
            conn.Close()
        Next


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AdminForm.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        employee_id = employee_id_index(EmployeeList.SelectedIndex + 1)
        ViewForm.Show()
        Me.Hide()
    End Sub
    Private Sub ConnectToMySql()

        connString = "server=localhost;" _
                   & "uid=hris;" _
                   & "pwd=dbms;" _
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

    Private Sub SearchFor_Load(sender As Object, e As EventArgs) Handles Me.Load
        ConnectToMySql()
    End Sub
End Class
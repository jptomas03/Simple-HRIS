
Imports MySql.Data.MySqlClient

Imports Microsoft.Reporting.WinForms
Public Class EmployeeReportForm
    Dim conn As New MySqlConnection
    Dim stm As String = "SELECT VERSION()"
    Dim connString As String
    Dim cmd As MySqlCommand

    Private Sub EmployeeReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectToMySql()
        Me.ReportViewer1.RefreshReport()
        Dim ds As New DataSet
        Dim adapter As New MySqlDataAdapter

        adapter.SelectCommand = New MySqlCommand("select employee_id, last_name, first_name, middle_name from tb_personal_info where employee_id > 1;", conn)
        adapter.Fill(ds.Tables(0))

        ReportViewer1.ProcessingMode = ProcessingMode.Local
        ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report2.rdlc"

        ReportViewer1.LocalReport.DataSources.Clear()

        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet", ds.Tables(0)))

        ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()
        conn.Close()
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
End Class
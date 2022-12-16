Imports MySql.Data.MySqlClient

Public Class AttendanceFrm
    Dim eventID As New Integer
    Dim eventName As New String("")
    Dim eventDate As New String("")

    Private Sub AttendanceFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshAll()
        DeleteBtn.Enabled = False
        StartBtn.Enabled = False
        eventNameLabel.Text = ""
        EventDateLabel.Text = ""

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        MainWindow.Show()
        Me.Close()
    End Sub

    Private Sub CreateBtn_Click(sender As Object, e As EventArgs) Handles CreateBtn.Click
        AddEventFrm.ShowDialog()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles StartBtn.Click
        AttendanceSheetFrm.Show()
    End Sub

    Public Sub RefreshAll()
        Try
            Dim cmd As New MySqlCommand("SELECT * FROM attendance", frmLogin.connection.con)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            EventDataGrid.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EventDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles EventDataGrid.CellClick
        Try
            eventID = Convert.ToInt32(EventDataGrid.SelectedCells(0).Value.ToString)
            eventDate = EventDataGrid.SelectedCells(1).Value.ToString
            eventName = EventDataGrid.SelectedCells(2).Value.ToString

            EventDateLabel.Text = EventDataGrid.SelectedCells(1).Value.ToString
            eventNameLabel.Text = EventDataGrid.SelectedCells(2).Value.ToString

            AttendanceSheetFrm.eventID = eventID
            AttendanceSheetFrm.EventLabel.Text = eventName
            AttendanceSheetFrm.DateAndTimeLabel.Text = eventDate

            DeleteBtn.Enabled = True
            StartBtn.Enabled = True
            Try
                If eventID Then
                    Dim cmd2 As New MySqlCommand("SELECT ID, StudentID AS REGISTRATION_NO, Firstname AS FIRSTNAME, Lastname AS LASTNAME, Department AS DEPARTMENT, Gender AS GENDER FROM student WHERE ID IN (SELECT studentID FROM attendanceref WHERE attendanceID=@eventid)", frmLogin.connection.con)
                    cmd2.Parameters.AddWithValue("eventid", eventID)
                    Dim da2 As New MySqlDataAdapter(cmd2)
                    Dim dt2 As New DataTable
                    da2.Fill(dt2)
                    AttendanceDataGrid.DataSource = dt2

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Try
            If eventID Then
                Dim cmd4 As New MySqlCommand("DELETE FROM attendance WHERE ID=@eventid", frmLogin.connection.con)
                cmd4.Parameters.AddWithValue("eventid", eventID)
                cmd4.ExecuteNonQuery()
                DeleteBtn.Enabled = False
                StartBtn.Enabled = False
                AttendanceFrm_Load("", EventArgs.Empty)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
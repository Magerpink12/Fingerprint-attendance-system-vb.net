Imports MySql.Data.MySqlClient
Imports System.IO

Public Class MainWindow
    Dim cmd As MySqlCommand
    Dim dt As DataTable
    Dim da As MySqlDataAdapter
    Dim id As New Integer

    Public Sub refreshgridview(cmd As MySqlCommand, gridView As DataGridView)
        dt = New DataTable
        da = New MySqlDataAdapter(cmd)
        da.Fill(dt)

        gridView.DataSource = dt
    End Sub

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'UsersName.Text.ToString.ToUpper()
        cmd = New MySqlCommand("SELECT ID, StudentID AS REGISTRATION_NO, Firstname AS FIRSTNAME, Lastname AS LASTNAME, Department AS DEPARTMENT, Gender AS GENDER, Address AS ADDRESS FROM student", frmLogin.connection.con)
        refreshgridview(cmd, studentGridView)
        'dt = New DataTable
        'da = New MySqlDataAdapter(cmd)
        'da.Fill(dt)
        'studentGridView.DataSource = dt
        DeleteBtn.Enabled = False

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        theModule = Thumb.Enrol
        Form1.ShowDialog()

    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        End
    End Sub

    Private Sub VerifyBtn_Click(sender As Object, e As EventArgs) Handles VerifyBtn.Click
        theModule = Thumb.Verify
        Form1.ShowDialog()
    End Sub

    Private Sub studentGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles studentGridView.CellClick

        Try
            id = Convert.ToInt32(studentGridView.SelectedCells.Item(0).Value.ToString)
            If id Then
                'MsgBox(id)
                Dim cmd3 As New MySqlCommand("SELECT * FROM student WHERE ID=@id LIMIT 1", frmLogin.connection.con)
                cmd3.Parameters.AddWithValue("id", id)

                Dim dt3 As New DataTable
                Dim da3 As New MySqlDataAdapter(cmd3)
                da3.Fill(dt3)
                With dt3.Rows(0)
                    RegNoTxb.Text = .Item("StudentId")
                    FirstNameTxb.Text = .Item("Firstname")
                    LastNameTxb.Text = .Item("Lastname")
                    GenderTxb.Text = .Item("Gender")
                    DeptTxb.Text = .Item("Department")
                    AddressTxb.Text = .Item("Address")

                    Dim ms1 As New MemoryStream(CType(.Item("image"), Byte()))

                    Dim returnAsImage As Image = Image.FromStream(ms1)

                    StudentProfilePic.Image = returnAsImage
                    DeleteBtn.Enabled = True
                End With

            End If

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Try
            cmd = New MySqlCommand("SELECT ID, StudentID AS REGISTRATION_NO, Firstname AS FIRSTNAME, Lastname AS LASTNAME, Department AS DEPARTMENT, Gender AS GENDER, Address AS ADDRESS FROM student WHERE (StudentID LIKE @search OR Firstname LIKE @search OR Lastname LIKE @search OR Department LIKE @search)", frmLogin.connection.con)
            cmd.Parameters.AddWithValue("search", "%" & searchTxb.Text & "%")
            refreshgridview(cmd, studentGridView)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Try
            If id Then
                cmd = New MySqlCommand("DELETE FROM student WHERE ID=@id", frmLogin.connection.con)
                cmd.Parameters.AddWithValue("id", id)

                cmd.ExecuteNonQuery()
                DeleteBtn.Enabled = False
                Dim cmd4 = New MySqlCommand("SELECT ID, StudentID AS REGISTRATION_NO, Firstname AS FIRSTNAME, Lastname AS LASTNAME, Department AS DEPARTMENT, Gender AS GENDER, Address AS ADDRESS FROM student", frmLogin.connection.con)
                refreshgridview(cmd4, studentGridView)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Guna2ImageButton3_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton3.Click
        DepartmentFrm.ShowDialog()

    End Sub

    Private Sub Guna2ImageButton5_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton5.Click
        UsersFrm.ShowDialog()
    End Sub

    Private Sub Guna2ImageButton4_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton4.Click
        AttendanceFrm.Show()
        Me.Hide()

    End Sub
End Class
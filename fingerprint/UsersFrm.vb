Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing.Imaging


Public Class UsersFrm

    Dim cmd As MySqlCommand
    Dim userId As Integer

    Private Sub UsersFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DeleteBtn.Enabled = False
        Try
            cmd = New MySqlCommand("SELECT id AS ID, fullname AS FULLNAME, username AS USERNAME, password AS PASSWORD FROM users", frmLogin.connection.con)
            'Dim da As New MySqlDataAdapter(cmd)
            'Dim dt As New DataTable
            'da.Fill(dt)
            '
            '
            'Dim pic As New DataGridViewImageColumn
            'usersGridView.AllowUserToAddRows = False
            'usersGridView.DataSource = dt
            'Dim stream As New MemoryStream(CType(, Byte))
            'pic = usersGridView.Columns(4)
            'pic.ImageLayout = DataGridViewImageCellLayout.Stretch

            MainWindow.refreshgridview(cmd, usersGridView)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Guna2Transition1.HideSync(ListPanel)
        Guna2Transition1.ShowSync(AddPaned)
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Try
            If userId Then
                cmd = New MySqlCommand("DELETE FROM users WHERE id=@id", frmLogin.connection.con)
                cmd.Parameters.AddWithValue("id", userId)
                cmd.ExecuteNonQuery()

                Dim cmd2 As New MySqlCommand("SELECT * FROM users", frmLogin.connection.con)
                MainWindow.refreshgridview(cmd2, usersGridView)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub usersGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles usersGridView.CellClick

        Try
            userId = Convert.ToInt32(usersGridView.SelectedCells(0).Value.ToString)
            DeleteBtn.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddPaned_Paint(sender As Object, e As PaintEventArgs) Handles AddPaned.Paint

    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click

        If Not FullName.Text = String.Empty Then
            Dim memoryStr As New MemoryStream
            profilePicBox.Image.Save(memoryStr, profilePicBox.Image.RawFormat)

            cmd = New MySqlCommand("INSERT INTO users (fullname, username, password, image) VALUES (@fullname, @username, @password, @image)", frmLogin.connection.con)
            With cmd.Parameters
                .AddWithValue("fullname", FullName.Text)
                .AddWithValue("username", usernameTbx.Text)
                .AddWithValue("password", passwordTbx.Text)
                .AddWithValue("image", memoryStr.ToArray)

            End With

            cmd.ExecuteNonQuery()
            CancelBtn_Click("", EventArgs.Empty)
            UsersFrm_Load("", EventArgs.Empty)
            FullName.Text = ""
        End If
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Guna2Transition1.HideSync(AddPaned)
        Guna2Transition1.ShowSync(ListPanel)
    End Sub

    Private Sub browseBtn_Click(sender As Object, e As EventArgs) Handles browseBtn.Click
        Dim openFileDialog1 As New OpenFileDialog
        openFileDialog1.Filter = "images|*.jpg;*.png;*.bmp;*.gif;"

        If openFileDialog1.ShowDialog = DialogResult.OK Then
            profilePicBox.Image = Image.FromFile(openFileDialog1.FileName)
        End If
    End Sub
End Class
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmLogin
    Public connection As Db
    Dim cmd As MySqlCommand
    Dim dt As DataTable
    Dim da As MySqlDataAdapter


    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        noticeLabel.Text = ""
        connection = New Db
        connection.Connect()
        If (connection.con.State = ConnectionState.Open) Then
            'MsgBox("Connected Successfully !") ------------------------------------------------------------------------------

            'Me.Hide()
            'MainWindow.Show()
            '-------------------------------------------------------------------------------------
        Else
            MsgBox("Connection Error !")

        End If
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        End
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Try
            cmd = New MySqlCommand("SELECT * FROM users WHERE username=@username AND password=@password LIMIT 1", connection.con)

            If (usernameTxb.Text = String.Empty) Then
                noticeLabel.Text = "Username Field Can't be Empty"
            Else

                If (passwordTxb.Text = String.Empty) Then
                    noticeLabel.Text = "Password Field Can't be Empty"
                End If
            End If


            With cmd.Parameters
                .AddWithValue("username", usernameTxb.Text)
                .AddWithValue("password", passwordTxb.Text)
            End With

            dt = New DataTable
            da = New MySqlDataAdapter(cmd)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                MainWindow.UsersName.Text = dt.Rows(0).Item("fullname").ToString.ToUpper()
                Dim memstr As New MemoryStream(CType(dt.Rows(0).Item("image"), Byte()))

                MainWindow.userProfilePic.Image = Image.FromStream(memstr)
                Me.Hide()
                MainWindow.Show()

            Else
                MessageBox.Show("Invalid User Credentials.", "USER NOT FOUND!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
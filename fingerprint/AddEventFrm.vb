Imports MySql.Data.MySqlClient

Public Class AddEventFrm

    Private Sub AddEventFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Try
            If Not EventNameTxb.Text = String.Empty Then
                Dim cmd As New MySqlCommand("INSERT INTO attendance (eventname) VALUES (@name)", frmLogin.connection.con)
                cmd.Parameters.AddWithValue("name", EventNameTxb.Text)
                cmd.ExecuteNonQuery()
                EventNameTxb.Text = ""
                AttendanceFrm.RefreshAll()

            Else
                MsgBox("Event Name Cannot be Empty")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class
Imports MySql.Data.MySqlClient

Public Class DepartmentFrm

    Dim cmd As MySqlCommand
    Dim deptId As Integer

    Private Sub DepartmentFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DeleteBtn.Enabled = False
        Try
            cmd = New MySqlCommand("SELECT * FROM department", frmLogin.connection.con)
            MainWindow.refreshgridview(cmd, departmentGridView)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Guna2Transition1.HideSync(ListPanel)
        Guna2Transition1.ShowSync(AddPaned)

    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub


    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Guna2Transition1.HideSync(AddPaned)
        Guna2Transition1.ShowSync(ListPanel)
    End Sub

    Private Sub departmentGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles departmentGridView.CellClick

        Try
            deptId = Convert.ToInt32(departmentGridView.SelectedCells(0).Value.ToString)
            DeleteBtn.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Try
            If deptId Then
                cmd = New MySqlCommand("DELETE FROM department WHERE ID=@id", frmLogin.connection.con)
                cmd.Parameters.AddWithValue("id", deptId)
                cmd.ExecuteNonQuery()

                Dim cmd2 As New MySqlCommand("SELECT * FROM department", frmLogin.connection.con)
                MainWindow.refreshgridview(cmd2, departmentGridView)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If Not DeptTxb.Text = String.Empty Then
            cmd = New MySqlCommand("INSERT INTO department (name) VALUES (@name)", frmLogin.connection.con)
            cmd.Parameters.AddWithValue("name", DeptTxb.Text)
            cmd.ExecuteNonQuery()
            CancelBtn_Click("", EventArgs.Empty)
            DepartmentFrm_Load("", EventArgs.Empty)
            DeptTxb.Text = ""
        End If
    End Sub
End Class
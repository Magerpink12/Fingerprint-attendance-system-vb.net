Public Class frmFingerprintMenu
    Private Sub frmFingerprintMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        theModule = Thumb.Enrol
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        theModule = Thumb.Verify
        Form1.Show()
        Me.Hide()
    End Sub
End Class
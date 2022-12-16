Imports MySql.Data.MySqlClient
Imports DPFP
Imports System.Data.Common
Imports DPFP.Gui
Imports System.IO
Imports DPFP.Capture

Public Class AttendanceSheetFrm
    Implements DPFP.Capture.EventHandler

    Dim connection As Db
    Dim cmd As MySqlCommand


    'Public eventHandlerComplete As DPFP.Capture.EventHandler
    Private Capturer As DPFP.Capture.Capture
    Delegate Sub FunctionCall(ByVal param)

    Private Event OnTemplete(ByVal template)

    Private Enroller As DPFP.Processing.Enrollment
    Public Sel_UsrID As String
    Public eventID As New Integer

    Private Sub AttendanceSheetFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New Db
        connection.Connect()
        If (connection.con.State = ConnectionState.Open) Then

            Dim cmd2 As New MySqlCommand("SELECT ID, StudentID AS REGISTRATION_NO, Firstname AS FIRSTNAME, Lastname AS LASTNAME, Department AS DEPARTMENT, Gender AS GENDER FROM student WHERE ID IN (SELECT studentID FROM attendanceref WHERE attendanceID=@eventid)", frmLogin.connection.con)
            cmd2.Parameters.AddWithValue("eventid", eventID)
            Dim da2 As New MySqlDataAdapter(cmd2)
            Dim dt2 As New DataTable
            da2.Fill(dt2)
            attendanceSheetDataGrid.DataSource = dt2
            'MsgBox("Connected Successfully !")
        Else
            MsgBox("Connection Error !")

        End If
        Try
            notificationPanel.Hide()
            Me.txtStatus.Clear()
            Me.PBoxThumb.Image = Nothing

            Init()
            StartCapture()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Overridable Sub Init()
        Try
            Capturer = New DPFP.Capture.Capture() 'creat a capture operation
            Enroller = New DPFP.Processing.Enrollment

            If (Not Capturer Is Nothing) Then
                Capturer.EventHandler = Me 'capturing events.
            Else
                MakeReport("Can't initiate Capture Operation!.")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub StartCapture()
        Try
            If (Not Capturer Is Nothing) Then
                Capturer.StartCapture()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub StopCapture()
        Try
            If (Not Capturer Is Nothing) Then
                Capturer.StopCapture()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '------------------------------------------------------------------------------------------------------------------------------------
    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As Sample) Implements EventHandler.OnComplete

        Try

            Process_Verify(Sample)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub OnFingerGone(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerGone
        Try
            MakeReport("The finger was removed from the fingerprint reader.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub OnFingerTouch(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerTouch
        Try
            MakeReport("The fingerprint reader was touched.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderConnect
        Try
            MakeReport("The fingerprint reader was connected.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub OnReaderDisconnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderDisconnect

        Try
            MakeReport("The fingerprint reader was disconnected")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, CaptureFeedback As CaptureFeedback) Implements EventHandler.OnSampleQuality
        Throw New NotImplementedException()
    End Sub

    Protected Sub DrawPicture(ByVal bmp)
        Invoke(New FunctionCall(AddressOf _DrawPicture), bmp)
    End Sub

    Private Sub _DrawPicture(ByVal bmp)
        Me.PBoxThumb.Image = New Bitmap(bmp, Me.PBoxThumb.Size)
    End Sub

    Private Function ConvertSampleToBitmap(ByVal Sample As DPFP.Sample) As Bitmap
        Dim bitmap As Bitmap = Nothing
        Try
            Dim convertor As New DPFP.Capture.SampleConversion
            convertor.ConvertToPicture(Sample, bitmap)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return bitmap
    End Function

    Private Function Extract_Features(ByVal Sample As DPFP.Sample, ByVal Purpose As DPFP.Processing.DataPurpose) As FeatureSet
        Try
            Dim extractor As New DPFP.Processing.FeatureExtraction()
            Dim feedback As DPFP.Capture.CaptureFeedback = DPFP.Capture.CaptureFeedback.None
            Dim features As New DPFP.FeatureSet()

            extractor.CreateFeatureSet(Sample, Purpose, feedback, features)
            If (feedback = DPFP.Capture.CaptureFeedback.Good) Then
                Return features
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function



    Private Sub Process_Verify(ByVal Sample As DPFP.Sample)
        Dim fullname As New String("")
        Dim verifyy As Boolean
        Try
            verifyy = False
            DrawPicture(ConvertSampleToBitmap(Sample))
            Dim Feature_Verify As DPFP.FeatureSet = Extract_Features(Sample, DPFP.Processing.DataPurpose.Verification)
            Dim Verificator As New DPFP.Verification.Verification
            Dim result As New DPFP.Verification.Verification.Result()

            If (Not Feature_Verify Is Nothing) Then ' Check quality of the sample
                Dim sda As New MySqlDataAdapter("SELECT * FROM student", connection.con)
                Dim dt As New DataTable
                sda.Fill(dt)
                For Each dr As DataRow In dt.Rows
                    Dim bytes As Byte() = Nothing
                    bytes = dr.Item("FPTemp")


                    Dim saved_temp As New DPFP.Template
                    saved_temp.DeSerialize(bytes)
                    Verificator.Verify(Feature_Verify, saved_temp, result)
                    If result.Verified Then
                        fullname = dr.Item("Firstname")
                        addAttender(dr.Item("ID"))
                        verifyy = True
                    End If
                Next
                If verifyy Then
                    MakeReport("The fingerprint was VERIFIED.")
                    notification(Color.LimeGreen, "TAKEN!")
                    'MsgBox(fullname)
                Else
                    MakeReport("The fingerprint was NOT VERIFIED.")
                    notification(Color.Red, "INVALID")

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub MakeReport(ByVal status)
        Try
            Invoke(New FunctionCall(AddressOf _MakeReport), status)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub _MakeReport(ByVal status)
        Try
            Me.txtStatus.AppendText(status + Chr(13) + Chr(10))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Try
            StopCapture()
            'AttendanceSheetFrm.AttendanceSheetFrm_Load("", EventArgs.Empty)
            'frmFingerprintMenu.Show()
            Me.Close()
            'frmFingerprintMenu.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click

    End Sub


    Protected Sub addAttender(ByVal studentID)
        Try
            Invoke(New FunctionCall(AddressOf _addAttender), studentID)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub _addAttender(ByVal studentID)
        Try
            Try
                Dim cmd1 As New MySqlCommand("INSERT INTO attendanceref (attendanceID, studentID) VALUES (@attendanceid,@studentid)", frmLogin.connection.con)

                With cmd1.Parameters
                    .AddWithValue("attendanceid", eventID)
                    .AddWithValue("studentid", studentID)

                End With
                cmd1.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Dim cmd2 As New MySqlCommand("SELECT ID, StudentID AS REGISTRATION_NO, Firstname AS FIRSTNAME, Lastname AS LASTNAME, Department AS DEPARTMENT, Gender AS GENDER FROM student WHERE ID IN (SELECT studentID FROM attendanceref WHERE attendanceID=@eventid)", frmLogin.connection.con)
            cmd2.Parameters.AddWithValue("eventid", eventID)
            Dim da2 As New MySqlDataAdapter(cmd2)
            Dim dt2 As New DataTable
            da2.Fill(dt2)
            attendanceSheetDataGrid.DataSource = dt2
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub notification(ByVal color, ByVal message)
        noiceLabel.Text = message
        notificationPanel.FillColor = color
        Guna2Transition1.Show(notificationPanel)
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Guna2Transition1.Hide(notificationPanel)
        Timer1.Stop()
        Timer1.Enabled = False
    End Sub
End Class
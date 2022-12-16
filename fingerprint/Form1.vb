Imports MySql.Data.MySqlClient
Imports DPFP
Imports System.Data.Common
Imports DPFP.Gui
Imports System.IO
Imports DPFP.Capture

Public Class Form1
    Implements DPFP.Capture.EventHandler

    Dim connection As Db
    Dim cmd As MySqlCommand


    'Public eventHandlerComplete As DPFP.Capture.EventHandler
    Private Capturer As DPFP.Capture.Capture
    Delegate Sub FunctionCall(ByVal param)

    Private Event OnTemplete(ByVal template)

    Private Enroller As DPFP.Processing.Enrollment
    Public Sel_UsrID As String

    '-------------------------------------------------------------------------------------------------------------------------------------
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connection = New Db
        connection.Connect()
        If (connection.con.State = ConnectionState.Open) Then
            'MsgBox("Connected Successfully !")
        Else
            MsgBox("Connection Error !")

        End If
        txtCount.ForeColor = Color.Red
        profilePicBox.Image = profilePicBox.InitialImage
        clearBtn_Click("", EventArgs.Empty)
        Try
            If theModule = Thumb.Enrol Then

                cmd = New MySqlCommand("SELECT * FROM department", frmLogin.connection.con)
                Dim da As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                DeptCombo.Items.Clear()
                DeptCombo.Items.Add("")
                For Each Item In dt.Rows
                    DeptCombo.Items.Add(Item.Item("name"))
                Next Item



                Me.Text = "[ Thumb Impress - Enrol ]"
                Me.btnSave.Visible = True
                Me.btnClose.Text = "Cancel"
                Sel_UsrID = 2

                Me.RegTxb.ReadOnly = False
                Me.LastNameTxb.ReadOnly = False
                Me.FirstNameTxb.ReadOnly = False
                Me.AddressTxb.ReadOnly = False
                Me.GenderCombo.Enabled = True
                Me.DeptCombo.Enabled = True
                Me.browseBtn.Enabled = True
                Me.verificationLabel.Visible = False
            Else
                Me.Text = "[ Thumb Impress - Verify ]"
                Me.btnSave.Visible = False
                Me.btnClose.Text = "Close"

                Me.RegTxb.ReadOnly = True
                Me.LastNameTxb.ReadOnly = True
                Me.FirstNameTxb.ReadOnly = True
                Me.AddressTxb.ReadOnly = True
                Me.GenderCombo.Enabled = False
                Me.DeptCombo.Enabled = False
                Me.browseBtn.Enabled = False
                Me.verificationLabel.Visible = True


            End If
            Me.txtStatus.Clear()
            Me.PBoxThumb.Image = Nothing
            Me.txtCount.Text = ""

            Init()
            StartCapture()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try







        'Try
        '    cmd = New MySqlCommand("SELECT image FROM student WHERE ID=17", connection.con)
        '    Dim dt As New DataTable
        '    Dim da As New MySqlDataAdapter(cmd)
        '    da.Fill(dt)
        '
        '    Dim ms As New MemoryStream(CType(dt.Rows(0).Item("image"), Byte()))
        '
        '    Dim returnAsImage As Image = Image.FromStream(ms)
        '
        '    profilePicBox.Image = returnAsImage
        '
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try






    End Sub
    '---------------------------------------------------------------------------------------------------------------------------------------------
    Public Overridable Sub Init()
        Try
            Capturer = New DPFP.Capture.Capture() 'creat a capture operation
            Enroller = New DPFP.Processing.Enrollment

            Me.txtCount.Text = IIf(theModule = Thumb.Enrol, "Fingerprint Samples Needed: " & Enroller.FeaturesNeeded.ToString, "")

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
            MakeReport("The fingerprint sample was captured.")
            If theModule = Thumb.Enrol Then
                Process_Enrol(Sample)
            Else
                Process_Verify(Sample)
            End If

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

    Protected Sub SetStudentVal(dr As DataRow)
        Invoke(New FunctionCall(AddressOf _SetStudentVal), dr)

    End Sub
    Private Sub _SetStudentVal(dr As DataRow)

        Me.RegTxb.Text = dr.Item("StudentID")
        Me.LastNameTxb.Text = dr.Item("Lastname")
        Me.FirstNameTxb.Text = dr.Item("Firstname")

        Me.AddressTxb.Text = dr.Item("Address")
        Me.GenderCombo.SelectedItem = dr.Item("Gender")
        Me.DeptCombo.SelectedItem = dr.Item("Department")

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

    Protected Sub setStatus(ByVal status)
        Try
            Invoke(New FunctionCall(AddressOf _SetStatus), status)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub _SetStatus(ByVal status)
        Try

            Me.txtCount.Text = status
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Template Enrol
    Private Sub Process_Enrol(ByVal Sample As DPFP.Sample)
        Try
            DrawPicture(ConvertSampleToBitmap(Sample))
            Dim Features_Enrol As DPFP.FeatureSet = Extract_Features(Sample, DPFP.Processing.DataPurpose.Enrollment)

            If Not Features_Enrol Is Nothing Then 'Check quality of the sample if its Good
                Try
                    MakeReport("The fingerprint feature set was created.")
                    Enroller.AddFeatures(Features_Enrol)

                Finally
                    setStatus("Fingerprint Template Remaining: " & Enroller.FeaturesNeeded.ToString)

                    Select Case Enroller.TemplateStatus
                        Case DPFP.Processing.Enrollment.Status.Ready 'Report Success and stop capturing
                            RaiseEvent OnTemplete(Enroller.Template)
                            StopCapture()
                            Me.txtCount.ForeColor = Color.Green
                            setStatus("Fingerprint Template Completed. Save Now......")
                        Case DPFP.Processing.Enrollment.Status.Failed 'Report Failure and restart capturing
                            Enroller.Clear()
                            StopCapture()
                            RaiseEvent OnTemplete(Nothing)
                            StartCapture()
                    End Select
                End Try

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Process_Verify(ByVal Sample As DPFP.Sample)
        'connection.open()

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

                    'Dim bytes As String() = Nothing
                    'bytes = dr.Item("FPTemp")

                    Dim saved_temp As New DPFP.Template
                    saved_temp.DeSerialize(bytes)
                    Verificator.Verify(Feature_Verify, saved_temp, result)


                    If result.Verified Then
                        Try
                            Dim ms1 As New MemoryStream(CType(dr.Item("image"), Byte()))

                            Dim returnAsImage As Image = Image.FromStream(ms1)

                            profilePicBox.Image = returnAsImage
                            SetStudentVal(dr)

                        Catch ex As Exception
                            MsgBox("eeeeeeeeeeeeeeerrrrrrrrrrrrrr" & ex.Message)
                        End Try

                        verifyy = True
                    End If
                Next
                If verifyy Then
                    MakeReport("The fingerprint was VERIFIED.")
                    verificationLabel.FillColor = Color.LimeGreen
                    'MsgBox(fullname)
                Else
                    MakeReport("The fingerprint was NOT VERIFIED.")

                    verificationLabel.FillColor = Color.Red

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

    Private Sub browseBtn_Click(sender As Object, e As EventArgs) Handles browseBtn.Click
        Dim openFileDialog1 As New OpenFileDialog
        openFileDialog1.Filter = "images|*.jpg;*.png;*.gif;*.bmp"
        If openFileDialog1.ShowDialog = DialogResult.OK Then
            profilePicBox.Image = Image.FromFile(openFileDialog1.FileName)

        End If
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        Me.DeptCombo.SelectedItem = ""
        Me.GenderCombo.SelectedItem = ""
        Me.RegTxb.Text = ""
        Me.FirstNameTxb.Text = ""
        Me.LastNameTxb.Text = ""
        Me.AddressTxb.Text = ""

    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Try
            StopCapture()
            'frmFingerprintMenu.Show()
            Me.Close()
            'frmFingerprintMenu.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If Enroller.FeaturesNeeded > 0 Then
                MsgBox("'Insufficient Templates'." & vbCrLf & Enroller.FeaturesNeeded.ToString & " more 'Fingerprint' scan needed.", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End If
            Dim fs As MemoryStream = New MemoryStream
            Enroller.Template.Serialize(fs)

            fs.Position = 0
            Dim br As BinaryReader = New BinaryReader(fs)
            Dim fs_bytes() As Byte = br.ReadBytes(CType(fs.Length, Int32))

            Dim memoryStr As New MemoryStream
            profilePicBox.Image.Save(memoryStr, profilePicBox.Image.RawFormat)

            Dim cmd As New MySqlCommand("INSERT INTO student (Firstname, Lastname,StudentID,FPTemp,Address,Gender, Department,image) VALUES (@1,@2,@3,@4,@5,@6,@7,@image)", connection.con)
            With cmd.Parameters
                .AddWithValue("1", FirstNameTxb.Text)
                .AddWithValue("2", LastNameTxb.Text)
                .AddWithValue("3", RegTxb.Text)
                .AddWithValue("4", fs_bytes)
                .AddWithValue("5", AddressTxb.Text)
                .AddWithValue("6", GenderCombo.SelectedItem.ToString)
                .AddWithValue("7", DeptCombo.SelectedItem.ToString)
                .AddWithValue("image", memoryStr.ToArray)

            End With
            cmd.ExecuteNonQuery()

            MsgBox("'Fingferprint' Templates Saved Successfully.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'frmFingerprintMenu.Show()
            Dim cmd2 As New MySqlCommand("SELECT ID, StudentID AS REGISTRATION_NO, Firstname AS FIRSTNAME, Lastname AS LASTNAME, Department AS DEPARTMENT, Gender AS GENDER, Address AS ADDRESS FROM student", frmLogin.connection.con)
            MainWindow.refreshgridview(cmd2, MainWindow.studentGridView)
            btnClose_Click("", EventArgs.Empty)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub profilePicBox_Click(sender As Object, e As EventArgs) Handles profilePicBox.Click

    End Sub






    'Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
    '
    '    Dim memoryStr As New MemoryStream
    '    profilePicBox.Image.Save(memoryStr, profilePicBox.Image.RawFormat)
    '    cmd = New MySqlCommand("INSERT INTO student (image) VALUES (@image)", connection.con)
    '
    '    With cmd.Parameters
    '        .AddWithValue("image", memoryStr.ToArray)
    '    End With
    '    cmd.ExecuteNonQuery()
    '
    'End Sub









    'Private Sub EnrollmentControl1_OnEnroll(Control As Object, FingerMask As Integer, Template As Template, ByRef EventHandlerStatus As EventHandlerStatus)
    '
    '    If TextBox1.Text = String.Empty Then
    '        MsgBox("Suply Student ID!", MsgBoxStyle.Exclamation)
    '    Else
    '        Try
    '            Dim Bytes As Byte() = Nothing
    '
    '            Template.Serialize(Bytes)
    '            cmd = New MySqlCommand("INSERT INTO tb_fp (StudentID,FPTemp) VALUES (@ID,@FP)", connection.con)
    '            With cmd.Parameters
    '                .AddWithValue("ID", TextBox1.Text)
    '                .AddWithValue("FP", Bytes)
    '
    '            End With
    '            cmd.ExecuteNonQuery()
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message)
    '        End Try
    '
    '    End If
    '
    '
    'End Sub

    'Private Sub EnrollmentControl1_OnStartEnroll(Control As Object, ReaderSerialNumber As String, Finger As Integer)
    '    If TextBox1.Text = String.Empty Then
    '        MsgBox("Suply Student ID!", MsgBoxStyle.Exclamation)
    '    End If
    '
    '
    'End Sub
End Class

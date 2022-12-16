<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttendanceSheetFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AttendanceSheetFrm))
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2HtmlLabel13 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.EventLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.DateAndTimeLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.attendanceSheetDataGrid = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.PBoxThumb = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtStatus = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SaveBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.CancelBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.notificationPanel = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.noiceLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.attendanceSheetDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBoxThumb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.notificationPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2PictureBox1
        '
        Me.Guna2Transition1.SetDecoration(Me.Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 64)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(117, 112)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2HtmlLabel13
        '
        Me.Guna2HtmlLabel13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel13, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel13.Font = New System.Drawing.Font("Poppins Light", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2HtmlLabel13.Location = New System.Drawing.Point(265, 109)
        Me.Guna2HtmlLabel13.Name = "Guna2HtmlLabel13"
        Me.Guna2HtmlLabel13.Size = New System.Drawing.Size(240, 44)
        Me.Guna2HtmlLabel13.TabIndex = 7
        Me.Guna2HtmlLabel13.TabStop = False
        Me.Guna2HtmlLabel13.Text = "ATTENDANCE SHEET"
        Me.Guna2HtmlLabel13.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EventLabel
        '
        Me.EventLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EventLabel.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.EventLabel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.EventLabel.Font = New System.Drawing.Font("Poppins Light", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EventLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EventLabel.Location = New System.Drawing.Point(123, 155)
        Me.EventLabel.Name = "EventLabel"
        Me.EventLabel.Size = New System.Drawing.Size(192, 36)
        Me.EventLabel.TabIndex = 7
        Me.EventLabel.TabStop = False
        Me.EventLabel.Text = "CSC3600 Lectures"
        Me.EventLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateAndTimeLabel
        '
        Me.DateAndTimeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateAndTimeLabel.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.DateAndTimeLabel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DateAndTimeLabel.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateAndTimeLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DateAndTimeLabel.Location = New System.Drawing.Point(507, 161)
        Me.DateAndTimeLabel.Name = "DateAndTimeLabel"
        Me.DateAndTimeLabel.Size = New System.Drawing.Size(100, 30)
        Me.DateAndTimeLabel.TabIndex = 7
        Me.DateAndTimeLabel.TabStop = False
        Me.DateAndTimeLabel.Text = "08/08/2021"
        Me.DateAndTimeLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'attendanceSheetDataGrid
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.attendanceSheetDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.attendanceSheetDataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.attendanceSheetDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.attendanceSheetDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.attendanceSheetDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.attendanceSheetDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.attendanceSheetDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.attendanceSheetDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.attendanceSheetDataGrid.ColumnHeadersHeight = 40
        Me.attendanceSheetDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Guna2Transition1.SetDecoration(Me.attendanceSheetDataGrid, Guna.UI2.AnimatorNS.DecorationType.None)
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.attendanceSheetDataGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.attendanceSheetDataGrid.EnableHeadersVisualStyles = False
        Me.attendanceSheetDataGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.attendanceSheetDataGrid.Location = New System.Drawing.Point(12, 187)
        Me.attendanceSheetDataGrid.Name = "attendanceSheetDataGrid"
        Me.attendanceSheetDataGrid.ReadOnly = True
        Me.attendanceSheetDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.attendanceSheetDataGrid.ShowEditingIcon = False
        Me.attendanceSheetDataGrid.Size = New System.Drawing.Size(714, 472)
        Me.attendanceSheetDataGrid.TabIndex = 8
        Me.attendanceSheetDataGrid.TabStop = False
        Me.attendanceSheetDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.attendanceSheetDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.attendanceSheetDataGrid.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.attendanceSheetDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.attendanceSheetDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.attendanceSheetDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.attendanceSheetDataGrid.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.attendanceSheetDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.attendanceSheetDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.attendanceSheetDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.attendanceSheetDataGrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.attendanceSheetDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.attendanceSheetDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.attendanceSheetDataGrid.ThemeStyle.HeaderStyle.Height = 40
        Me.attendanceSheetDataGrid.ThemeStyle.ReadOnly = True
        Me.attendanceSheetDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.attendanceSheetDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.attendanceSheetDataGrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.attendanceSheetDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.attendanceSheetDataGrid.ThemeStyle.RowsStyle.Height = 22
        Me.attendanceSheetDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.attendanceSheetDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'PBoxThumb
        '
        Me.PBoxThumb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBoxThumb.BorderRadius = 5
        Me.Guna2Transition1.SetDecoration(Me.PBoxThumb, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PBoxThumb.FillColor = System.Drawing.Color.Black
        Me.PBoxThumb.Location = New System.Drawing.Point(622, 9)
        Me.PBoxThumb.Name = "PBoxThumb"
        Me.PBoxThumb.ShadowDecoration.Parent = Me.PBoxThumb
        Me.PBoxThumb.Size = New System.Drawing.Size(106, 96)
        Me.PBoxThumb.TabIndex = 16
        Me.PBoxThumb.TabStop = False
        '
        'txtStatus
        '
        Me.txtStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStatus.Animated = True
        Me.txtStatus.BorderRadius = 5
        Me.txtStatus.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.txtStatus, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtStatus.DefaultText = ""
        Me.txtStatus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStatus.DisabledState.Parent = Me.txtStatus
        Me.txtStatus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStatus.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStatus.FocusedState.Parent = Me.txtStatus
        Me.txtStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStatus.HoverState.Parent = Me.txtStatus
        Me.txtStatus.Location = New System.Drawing.Point(311, 9)
        Me.txtStatus.Multiline = True
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStatus.PlaceholderText = ""
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.SelectedText = ""
        Me.txtStatus.ShadowDecoration.Parent = Me.txtStatus
        Me.txtStatus.Size = New System.Drawing.Size(305, 94)
        Me.txtStatus.TabIndex = 15
        '
        'SaveBtn
        '
        Me.SaveBtn.BorderRadius = 5
        Me.SaveBtn.CheckedState.Parent = Me.SaveBtn
        Me.SaveBtn.CustomImages.Parent = Me.SaveBtn
        Me.Guna2Transition1.SetDecoration(Me.SaveBtn, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.SaveBtn.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.ForeColor = System.Drawing.Color.White
        Me.SaveBtn.HoverState.Parent = Me.SaveBtn
        Me.SaveBtn.Location = New System.Drawing.Point(9, 6)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.ShadowDecoration.Parent = Me.SaveBtn
        Me.SaveBtn.Size = New System.Drawing.Size(84, 45)
        Me.SaveBtn.TabIndex = 17
        Me.SaveBtn.Text = "Save"
        '
        'CancelBtn
        '
        Me.CancelBtn.BorderRadius = 5
        Me.CancelBtn.CheckedState.Parent = Me.CancelBtn
        Me.CancelBtn.CustomImages.Parent = Me.CancelBtn
        Me.Guna2Transition1.SetDecoration(Me.CancelBtn, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.CancelBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CancelBtn.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.ForeColor = System.Drawing.Color.White
        Me.CancelBtn.HoverState.Parent = Me.CancelBtn
        Me.CancelBtn.Location = New System.Drawing.Point(99, 6)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.ShadowDecoration.Parent = Me.CancelBtn
        Me.CancelBtn.Size = New System.Drawing.Size(84, 45)
        Me.CancelBtn.TabIndex = 17
        Me.CancelBtn.Text = "Cancel"
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        '
        'notificationPanel
        '
        Me.notificationPanel.BackColor = System.Drawing.Color.Transparent
        Me.notificationPanel.Controls.Add(Me.noiceLabel)
        Me.Guna2Transition1.SetDecoration(Me.notificationPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.notificationPanel.FillColor = System.Drawing.Color.White
        Me.notificationPanel.Location = New System.Drawing.Point(-5, 187)
        Me.notificationPanel.Name = "notificationPanel"
        Me.notificationPanel.ShadowColor = System.Drawing.Color.Black
        Me.notificationPanel.Size = New System.Drawing.Size(236, 74)
        Me.notificationPanel.TabIndex = 18
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide
        Me.Guna2Transition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.Guna2Transition1.DefaultAnimation = Animation1
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'noiceLabel
        '
        Me.noiceLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.noiceLabel.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.noiceLabel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.noiceLabel.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noiceLabel.ForeColor = System.Drawing.Color.White
        Me.noiceLabel.Location = New System.Drawing.Point(104, 22)
        Me.noiceLabel.Name = "noiceLabel"
        Me.noiceLabel.Size = New System.Drawing.Size(100, 30)
        Me.noiceLabel.TabIndex = 7
        Me.noiceLabel.TabStop = False
        Me.noiceLabel.Text = "08/08/2021"
        Me.noiceLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'AttendanceSheetFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(738, 671)
        Me.Controls.Add(Me.notificationPanel)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.PBoxThumb)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.attendanceSheetDataGrid)
        Me.Controls.Add(Me.DateAndTimeLabel)
        Me.Controls.Add(Me.EventLabel)
        Me.Controls.Add(Me.Guna2HtmlLabel13)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AttendanceSheetFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AttendanceSheetFrm"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.attendanceSheetDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBoxThumb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.notificationPanel.ResumeLayout(False)
        Me.notificationPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel13 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents EventLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents DateAndTimeLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents attendanceSheetDataGrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents PBoxThumb As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtStatus As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SaveBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CancelBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents notificationPanel As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Timer1 As Timer
    Friend WithEvents noiceLabel As Guna.UI2.WinForms.Guna2HtmlLabel
End Class

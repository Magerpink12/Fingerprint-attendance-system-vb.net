<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AttendanceFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AttendanceFrm))
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.CloseBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.DeleteBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.CreateBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel13 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.StartBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.EventDataGrid = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.AttendanceDataGrid = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.eventNameLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.EventDateLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.EventDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel13)
        Me.Guna2Panel1.Controls.Add(Me.CreateBtn)
        Me.Guna2Panel1.Controls.Add(Me.DeleteBtn)
        Me.Guna2Panel1.Controls.Add(Me.CloseBtn)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(944, 111)
        Me.Guna2Panel1.TabIndex = 0
        '
        'CloseBtn
        '
        Me.CloseBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseBtn.Animated = True
        Me.CloseBtn.BorderRadius = 5
        Me.CloseBtn.CheckedState.Parent = Me.CloseBtn
        Me.CloseBtn.CustomImages.Parent = Me.CloseBtn
        Me.CloseBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CloseBtn.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CloseBtn.ForeColor = System.Drawing.Color.White
        Me.CloseBtn.HoverState.Parent = Me.CloseBtn
        Me.CloseBtn.IndicateFocus = True
        Me.CloseBtn.Location = New System.Drawing.Point(819, 61)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.ShadowDecoration.Parent = Me.CloseBtn
        Me.CloseBtn.Size = New System.Drawing.Size(116, 45)
        Me.CloseBtn.TabIndex = 0
        Me.CloseBtn.Text = "Close"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.BorderRadius = 20
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(10, 4)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(149, 143)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(167, 155)
        Me.Guna2ShadowPanel1.TabIndex = 2
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteBtn.Animated = True
        Me.DeleteBtn.BorderRadius = 5
        Me.DeleteBtn.CheckedState.Parent = Me.DeleteBtn
        Me.DeleteBtn.CustomImages.Parent = Me.DeleteBtn
        Me.DeleteBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DeleteBtn.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DeleteBtn.ForeColor = System.Drawing.Color.White
        Me.DeleteBtn.HoverState.Parent = Me.DeleteBtn
        Me.DeleteBtn.IndicateFocus = True
        Me.DeleteBtn.Location = New System.Drawing.Point(697, 61)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.ShadowDecoration.Parent = Me.DeleteBtn
        Me.DeleteBtn.Size = New System.Drawing.Size(116, 45)
        Me.DeleteBtn.TabIndex = 0
        Me.DeleteBtn.Text = "Delete"
        '
        'CreateBtn
        '
        Me.CreateBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CreateBtn.Animated = True
        Me.CreateBtn.BorderRadius = 5
        Me.CreateBtn.CheckedState.Parent = Me.CreateBtn
        Me.CreateBtn.CustomImages.Parent = Me.CreateBtn
        Me.CreateBtn.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CreateBtn.ForeColor = System.Drawing.Color.White
        Me.CreateBtn.HoverState.Parent = Me.CreateBtn
        Me.CreateBtn.IndicateFocus = True
        Me.CreateBtn.Location = New System.Drawing.Point(575, 61)
        Me.CreateBtn.Name = "CreateBtn"
        Me.CreateBtn.ShadowDecoration.Parent = Me.CreateBtn
        Me.CreateBtn.Size = New System.Drawing.Size(116, 45)
        Me.CreateBtn.TabIndex = 0
        Me.CreateBtn.Text = "Create Event"
        '
        'Guna2HtmlLabel13
        '
        Me.Guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel13.Font = New System.Drawing.Font("Poppins Light", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2HtmlLabel13.Location = New System.Drawing.Point(173, 67)
        Me.Guna2HtmlLabel13.Name = "Guna2HtmlLabel13"
        Me.Guna2HtmlLabel13.Size = New System.Drawing.Size(161, 44)
        Me.Guna2HtmlLabel13.TabIndex = 6
        Me.Guna2HtmlLabel13.TabStop = False
        Me.Guna2HtmlLabel13.Text = "ATTENDANCE"
        '
        'StartBtn
        '
        Me.StartBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartBtn.CheckedState.Parent = Me.StartBtn
        Me.StartBtn.CustomImages.Parent = Me.StartBtn
        Me.StartBtn.FillColor = System.Drawing.Color.Green
        Me.StartBtn.Font = New System.Drawing.Font("Poppins Light", 10.0!, System.Drawing.FontStyle.Bold)
        Me.StartBtn.ForeColor = System.Drawing.Color.White
        Me.StartBtn.HoverState.Parent = Me.StartBtn
        Me.StartBtn.Location = New System.Drawing.Point(746, 166)
        Me.StartBtn.Name = "StartBtn"
        Me.StartBtn.ShadowDecoration.Parent = Me.StartBtn
        Me.StartBtn.Size = New System.Drawing.Size(180, 45)
        Me.StartBtn.TabIndex = 4
        Me.StartBtn.Text = "Start / Continue"
        '
        'EventDataGrid
        '
        Me.EventDataGrid.AllowUserToAddRows = False
        Me.EventDataGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        Me.EventDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.EventDataGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EventDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.EventDataGrid.BackgroundColor = System.Drawing.Color.LightGray
        Me.EventDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.EventDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.EventDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EventDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.EventDataGrid.ColumnHeadersHeight = 40
        Me.EventDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EventDataGrid.DefaultCellStyle = DataGridViewCellStyle15
        Me.EventDataGrid.EnableHeadersVisualStyles = False
        Me.EventDataGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EventDataGrid.Location = New System.Drawing.Point(10, 217)
        Me.EventDataGrid.MultiSelect = False
        Me.EventDataGrid.Name = "EventDataGrid"
        Me.EventDataGrid.ReadOnly = True
        Me.EventDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EventDataGrid.ShowEditingIcon = False
        Me.EventDataGrid.Size = New System.Drawing.Size(342, 315)
        Me.EventDataGrid.TabIndex = 5
        Me.EventDataGrid.TabStop = False
        Me.EventDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.EventDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.EventDataGrid.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.EventDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.EventDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.EventDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.EventDataGrid.ThemeStyle.BackColor = System.Drawing.Color.LightGray
        Me.EventDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EventDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EventDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.EventDataGrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.EventDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.EventDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.EventDataGrid.ThemeStyle.HeaderStyle.Height = 40
        Me.EventDataGrid.ThemeStyle.ReadOnly = True
        Me.EventDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.EventDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.EventDataGrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.EventDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.EventDataGrid.ThemeStyle.RowsStyle.Height = 22
        Me.EventDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EventDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'AttendanceDataGrid
        '
        Me.AttendanceDataGrid.AllowUserToAddRows = False
        Me.AttendanceDataGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        Me.AttendanceDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.AttendanceDataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AttendanceDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AttendanceDataGrid.BackgroundColor = System.Drawing.Color.DarkGray
        Me.AttendanceDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AttendanceDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.AttendanceDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AttendanceDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.AttendanceDataGrid.ColumnHeadersHeight = 40
        Me.AttendanceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AttendanceDataGrid.DefaultCellStyle = DataGridViewCellStyle18
        Me.AttendanceDataGrid.EnableHeadersVisualStyles = False
        Me.AttendanceDataGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AttendanceDataGrid.Location = New System.Drawing.Point(358, 217)
        Me.AttendanceDataGrid.MultiSelect = False
        Me.AttendanceDataGrid.Name = "AttendanceDataGrid"
        Me.AttendanceDataGrid.ReadOnly = True
        Me.AttendanceDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AttendanceDataGrid.ShowEditingIcon = False
        Me.AttendanceDataGrid.Size = New System.Drawing.Size(568, 315)
        Me.AttendanceDataGrid.TabIndex = 5
        Me.AttendanceDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.AttendanceDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.AttendanceDataGrid.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.AttendanceDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.AttendanceDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.AttendanceDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.AttendanceDataGrid.ThemeStyle.BackColor = System.Drawing.Color.DarkGray
        Me.AttendanceDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AttendanceDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AttendanceDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.AttendanceDataGrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.AttendanceDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.AttendanceDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.AttendanceDataGrid.ThemeStyle.HeaderStyle.Height = 40
        Me.AttendanceDataGrid.ThemeStyle.ReadOnly = True
        Me.AttendanceDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.AttendanceDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.AttendanceDataGrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.AttendanceDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.AttendanceDataGrid.ThemeStyle.RowsStyle.Height = 22
        Me.AttendanceDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AttendanceDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Poppins Light", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(12, 180)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(70, 36)
        Me.Guna2HtmlLabel1.TabIndex = 6
        Me.Guna2HtmlLabel1.TabStop = False
        Me.Guna2HtmlLabel1.Text = "Events"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Poppins Light", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(358, 180)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(125, 36)
        Me.Guna2HtmlLabel2.TabIndex = 6
        Me.Guna2HtmlLabel2.TabStop = False
        Me.Guna2HtmlLabel2.Text = "Attendance"
        '
        'eventNameLabel
        '
        Me.eventNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.eventNameLabel.Font = New System.Drawing.Font("Poppins Light", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eventNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.eventNameLabel.Location = New System.Drawing.Point(492, 180)
        Me.eventNameLabel.Name = "eventNameLabel"
        Me.eventNameLabel.Size = New System.Drawing.Size(70, 36)
        Me.eventNameLabel.TabIndex = 6
        Me.eventNameLabel.TabStop = False
        Me.eventNameLabel.Text = "Events"
        '
        'EventDateLabel
        '
        Me.EventDateLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EventDateLabel.BackColor = System.Drawing.Color.Transparent
        Me.EventDateLabel.Font = New System.Drawing.Font("Poppins Light", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EventDateLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EventDateLabel.Location = New System.Drawing.Point(653, 180)
        Me.EventDateLabel.Name = "EventDateLabel"
        Me.EventDateLabel.Size = New System.Drawing.Size(52, 36)
        Me.EventDateLabel.TabIndex = 6
        Me.EventDateLabel.TabStop = False
        Me.EventDateLabel.Text = "Date"
        '
        'AttendanceFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(944, 544)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.EventDateLabel)
        Me.Controls.Add(Me.eventNameLabel)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.AttendanceDataGrid)
        Me.Controls.Add(Me.EventDataGrid)
        Me.Controls.Add(Me.StartBtn)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.HelpButton = True
        Me.Name = "AttendanceFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ATTENDANCE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        CType(Me.EventDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents CloseBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CreateBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DeleteBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel13 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents StartBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents EventDataGrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents AttendanceDataGrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents eventNameLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents EventDateLabel As Guna.UI2.WinForms.Guna2HtmlLabel
End Class

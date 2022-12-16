<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsersFrm
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Animation4 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsersFrm))
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.ListPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.CloseBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.DeleteBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.AddBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.usersGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.AddPaned = New Guna.UI2.WinForms.Guna2Panel()
        Me.FullName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CancelBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.SaveBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.browseBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.profilePicBox = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.usernameTbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.passwordTbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ListPanel.SuspendLayout()
        CType(Me.usersGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddPaned.SuspendLayout()
        CType(Me.profilePicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2Transition1.SetDecoration(Me.Guna2ShadowPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(599, 150)
        Me.Guna2ShadowPanel1.TabIndex = 22
        '
        'Guna2PictureBox1
        '
        Me.Guna2Transition1.SetDecoration(Me.Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.White
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(13, 12)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(141, 123)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 13
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Poppins Light", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(160, 97)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(65, 38)
        Me.Guna2HtmlLabel3.TabIndex = 12
        Me.Guna2HtmlLabel3.Text = "USERS"
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        '
        'ListPanel
        '
        Me.ListPanel.Controls.Add(Me.CloseBtn)
        Me.ListPanel.Controls.Add(Me.DeleteBtn)
        Me.ListPanel.Controls.Add(Me.AddBtn)
        Me.ListPanel.Controls.Add(Me.usersGridView)
        Me.Guna2Transition1.SetDecoration(Me.ListPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ListPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListPanel.Location = New System.Drawing.Point(0, 0)
        Me.ListPanel.Name = "ListPanel"
        Me.ListPanel.ShadowDecoration.Parent = Me.ListPanel
        Me.ListPanel.Size = New System.Drawing.Size(599, 605)
        Me.ListPanel.TabIndex = 23
        '
        'CloseBtn
        '
        Me.CloseBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseBtn.BorderRadius = 5
        Me.CloseBtn.CheckedState.Parent = Me.CloseBtn
        Me.CloseBtn.CustomImages.Parent = Me.CloseBtn
        Me.Guna2Transition1.SetDecoration(Me.CloseBtn, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.CloseBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CloseBtn.Font = New System.Drawing.Font("Poppins Light", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.ForeColor = System.Drawing.Color.White
        Me.CloseBtn.HoverState.Parent = Me.CloseBtn
        Me.CloseBtn.Location = New System.Drawing.Point(486, 560)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.ShadowDecoration.Parent = Me.CloseBtn
        Me.CloseBtn.Size = New System.Drawing.Size(101, 36)
        Me.CloseBtn.TabIndex = 28
        Me.CloseBtn.Text = "Close"
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteBtn.BorderRadius = 5
        Me.DeleteBtn.CheckedState.Parent = Me.DeleteBtn
        Me.DeleteBtn.CustomImages.Parent = Me.DeleteBtn
        Me.Guna2Transition1.SetDecoration(Me.DeleteBtn, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DeleteBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DeleteBtn.Font = New System.Drawing.Font("Poppins Light", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.ForeColor = System.Drawing.Color.White
        Me.DeleteBtn.HoverState.Parent = Me.DeleteBtn
        Me.DeleteBtn.Location = New System.Drawing.Point(379, 560)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.ShadowDecoration.Parent = Me.DeleteBtn
        Me.DeleteBtn.Size = New System.Drawing.Size(101, 36)
        Me.DeleteBtn.TabIndex = 27
        Me.DeleteBtn.Text = "Delete"
        '
        'AddBtn
        '
        Me.AddBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddBtn.BorderRadius = 5
        Me.AddBtn.CheckedState.Parent = Me.AddBtn
        Me.AddBtn.CustomImages.Parent = Me.AddBtn
        Me.Guna2Transition1.SetDecoration(Me.AddBtn, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.AddBtn.FillColor = System.Drawing.Color.DodgerBlue
        Me.AddBtn.Font = New System.Drawing.Font("Poppins Light", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.ForeColor = System.Drawing.Color.White
        Me.AddBtn.HoverState.Parent = Me.AddBtn
        Me.AddBtn.Location = New System.Drawing.Point(276, 560)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.ShadowDecoration.Parent = Me.AddBtn
        Me.AddBtn.Size = New System.Drawing.Size(97, 36)
        Me.AddBtn.TabIndex = 26
        Me.AddBtn.Text = "Add New"
        '
        'usersGridView
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.usersGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.usersGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.usersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.usersGridView.BackgroundColor = System.Drawing.Color.White
        Me.usersGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.usersGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.usersGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.usersGridView.ColumnHeadersHeight = 35
        Me.usersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Guna2Transition1.SetDecoration(Me.usersGridView, Guna.UI2.AnimatorNS.DecorationType.None)
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.usersGridView.DefaultCellStyle = DataGridViewCellStyle12
        Me.usersGridView.EnableHeadersVisualStyles = False
        Me.usersGridView.GridColor = System.Drawing.Color.White
        Me.usersGridView.Location = New System.Drawing.Point(4, 154)
        Me.usersGridView.MultiSelect = False
        Me.usersGridView.Name = "usersGridView"
        Me.usersGridView.ReadOnly = True
        Me.usersGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.usersGridView.RowHeadersVisible = False
        Me.usersGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.usersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.usersGridView.ShowEditingIcon = False
        Me.usersGridView.Size = New System.Drawing.Size(592, 397)
        Me.usersGridView.TabIndex = 25
        Me.usersGridView.TabStop = False
        Me.usersGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.usersGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.usersGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.usersGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.usersGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.usersGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.usersGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.usersGridView.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.usersGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usersGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.usersGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.usersGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.usersGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.usersGridView.ThemeStyle.HeaderStyle.Height = 35
        Me.usersGridView.ThemeStyle.ReadOnly = True
        Me.usersGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.usersGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.usersGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.usersGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.usersGridView.ThemeStyle.RowsStyle.Height = 22
        Me.usersGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usersGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'AddPaned
        '
        Me.AddPaned.Controls.Add(Me.browseBtn)
        Me.AddPaned.Controls.Add(Me.profilePicBox)
        Me.AddPaned.Controls.Add(Me.passwordTbx)
        Me.AddPaned.Controls.Add(Me.usernameTbx)
        Me.AddPaned.Controls.Add(Me.FullName)
        Me.AddPaned.Controls.Add(Me.CancelBtn)
        Me.AddPaned.Controls.Add(Me.SaveBtn)
        Me.Guna2Transition1.SetDecoration(Me.AddPaned, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.AddPaned.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddPaned.Location = New System.Drawing.Point(0, 0)
        Me.AddPaned.Name = "AddPaned"
        Me.AddPaned.ShadowDecoration.Parent = Me.AddPaned
        Me.AddPaned.Size = New System.Drawing.Size(599, 605)
        Me.AddPaned.TabIndex = 24
        '
        'FullName
        '
        Me.FullName.BorderColor = System.Drawing.Color.Gray
        Me.FullName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.FullName, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FullName.DefaultText = ""
        Me.FullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FullName.DisabledState.Parent = Me.FullName
        Me.FullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FullName.FocusedState.Parent = Me.FullName
        Me.FullName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FullName.HoverState.Parent = Me.FullName
        Me.FullName.Location = New System.Drawing.Point(31, 373)
        Me.FullName.Name = "FullName"
        Me.FullName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FullName.PlaceholderText = "Insert Full Name"
        Me.FullName.SelectedText = ""
        Me.FullName.ShadowDecoration.Parent = Me.FullName
        Me.FullName.Size = New System.Drawing.Size(531, 36)
        Me.FullName.TabIndex = 31
        '
        'CancelBtn
        '
        Me.CancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBtn.BorderRadius = 5
        Me.CancelBtn.CheckedState.Parent = Me.CancelBtn
        Me.CancelBtn.CustomImages.Parent = Me.CancelBtn
        Me.Guna2Transition1.SetDecoration(Me.CancelBtn, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.CancelBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CancelBtn.Font = New System.Drawing.Font("Poppins Light", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.ForeColor = System.Drawing.Color.White
        Me.CancelBtn.HoverState.Parent = Me.CancelBtn
        Me.CancelBtn.Location = New System.Drawing.Point(486, 557)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.ShadowDecoration.Parent = Me.CancelBtn
        Me.CancelBtn.Size = New System.Drawing.Size(101, 36)
        Me.CancelBtn.TabIndex = 30
        Me.CancelBtn.Text = "Cancel"
        '
        'SaveBtn
        '
        Me.SaveBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveBtn.BorderRadius = 5
        Me.SaveBtn.CheckedState.Parent = Me.SaveBtn
        Me.SaveBtn.CustomImages.Parent = Me.SaveBtn
        Me.Guna2Transition1.SetDecoration(Me.SaveBtn, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.SaveBtn.FillColor = System.Drawing.Color.DodgerBlue
        Me.SaveBtn.Font = New System.Drawing.Font("Poppins Light", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.ForeColor = System.Drawing.Color.White
        Me.SaveBtn.HoverState.Parent = Me.SaveBtn
        Me.SaveBtn.Location = New System.Drawing.Point(383, 557)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.ShadowDecoration.Parent = Me.SaveBtn
        Me.SaveBtn.Size = New System.Drawing.Size(97, 36)
        Me.SaveBtn.TabIndex = 29
        Me.SaveBtn.Text = "Save"
        '
        'browseBtn
        '
        Me.browseBtn.BorderRadius = 5
        Me.browseBtn.CheckedState.Parent = Me.browseBtn
        Me.browseBtn.CustomImages.Parent = Me.browseBtn
        Me.Guna2Transition1.SetDecoration(Me.browseBtn, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.browseBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.browseBtn.ForeColor = System.Drawing.Color.White
        Me.browseBtn.HoverState.Parent = Me.browseBtn
        Me.browseBtn.Location = New System.Drawing.Point(234, 330)
        Me.browseBtn.Name = "browseBtn"
        Me.browseBtn.ShadowDecoration.Parent = Me.browseBtn
        Me.browseBtn.Size = New System.Drawing.Size(126, 25)
        Me.browseBtn.TabIndex = 33
        Me.browseBtn.Text = "Browse Image"
        '
        'profilePicBox
        '
        Me.Guna2Transition1.SetDecoration(Me.profilePicBox, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.profilePicBox.Image = CType(resources.GetObject("profilePicBox.Image"), System.Drawing.Image)
        Me.profilePicBox.Location = New System.Drawing.Point(215, 161)
        Me.profilePicBox.Name = "profilePicBox"
        Me.profilePicBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.profilePicBox.ShadowDecoration.Parent = Me.profilePicBox
        Me.profilePicBox.Size = New System.Drawing.Size(165, 163)
        Me.profilePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.profilePicBox.TabIndex = 32
        Me.profilePicBox.TabStop = False
        Me.profilePicBox.UseTransparentBackground = True
        '
        'usernameTbx
        '
        Me.usernameTbx.BorderColor = System.Drawing.Color.Gray
        Me.usernameTbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.usernameTbx, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.usernameTbx.DefaultText = ""
        Me.usernameTbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.usernameTbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.usernameTbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.usernameTbx.DisabledState.Parent = Me.usernameTbx
        Me.usernameTbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.usernameTbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usernameTbx.FocusedState.Parent = Me.usernameTbx
        Me.usernameTbx.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.usernameTbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usernameTbx.HoverState.Parent = Me.usernameTbx
        Me.usernameTbx.Location = New System.Drawing.Point(31, 415)
        Me.usernameTbx.Name = "usernameTbx"
        Me.usernameTbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.usernameTbx.PlaceholderText = "Insert Username"
        Me.usernameTbx.SelectedText = ""
        Me.usernameTbx.ShadowDecoration.Parent = Me.usernameTbx
        Me.usernameTbx.Size = New System.Drawing.Size(531, 36)
        Me.usernameTbx.TabIndex = 31
        '
        'passwordTbx
        '
        Me.passwordTbx.BorderColor = System.Drawing.Color.Gray
        Me.passwordTbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.passwordTbx, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.passwordTbx.DefaultText = ""
        Me.passwordTbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.passwordTbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.passwordTbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwordTbx.DisabledState.Parent = Me.passwordTbx
        Me.passwordTbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwordTbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passwordTbx.FocusedState.Parent = Me.passwordTbx
        Me.passwordTbx.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.passwordTbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passwordTbx.HoverState.Parent = Me.passwordTbx
        Me.passwordTbx.Location = New System.Drawing.Point(31, 457)
        Me.passwordTbx.Name = "passwordTbx"
        Me.passwordTbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.passwordTbx.PlaceholderText = "Insert Password"
        Me.passwordTbx.SelectedText = ""
        Me.passwordTbx.ShadowDecoration.Parent = Me.passwordTbx
        Me.passwordTbx.Size = New System.Drawing.Size(531, 36)
        Me.passwordTbx.TabIndex = 31
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide
        Me.Guna2Transition1.Cursor = Nothing
        Animation4.AnimateOnlyDifferences = True
        Animation4.BlindCoeff = CType(resources.GetObject("Animation4.BlindCoeff"), System.Drawing.PointF)
        Animation4.LeafCoeff = 0!
        Animation4.MaxTime = 1.0!
        Animation4.MinTime = 0!
        Animation4.MosaicCoeff = CType(resources.GetObject("Animation4.MosaicCoeff"), System.Drawing.PointF)
        Animation4.MosaicShift = CType(resources.GetObject("Animation4.MosaicShift"), System.Drawing.PointF)
        Animation4.MosaicSize = 0
        Animation4.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Animation4.RotateCoeff = 0!
        Animation4.RotateLimit = 0!
        Animation4.ScaleCoeff = CType(resources.GetObject("Animation4.ScaleCoeff"), System.Drawing.PointF)
        Animation4.SlideCoeff = CType(resources.GetObject("Animation4.SlideCoeff"), System.Drawing.PointF)
        Animation4.TimeCoeff = 0!
        Animation4.TransparencyCoeff = 0!
        Me.Guna2Transition1.DefaultAnimation = Animation4
        '
        'UsersFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(599, 605)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.ListPanel)
        Me.Controls.Add(Me.AddPaned)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UsersFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "UsersFrm"
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ListPanel.ResumeLayout(False)
        CType(Me.usersGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddPaned.ResumeLayout(False)
        CType(Me.profilePicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents ListPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CloseBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DeleteBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AddBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents usersGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents AddPaned As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents FullName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CancelBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SaveBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents browseBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents profilePicBox As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents passwordTbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents usernameTbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
End Class

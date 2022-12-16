<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DepartmentFrm
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Animation3 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DepartmentFrm))
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.ListPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.CloseBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.DeleteBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.AddBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.departmentGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.AddPaned = New Guna.UI2.WinForms.Guna2Panel()
        Me.DeptTxb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CancelBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.SaveBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ListPanel.SuspendLayout()
        CType(Me.departmentGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddPaned.SuspendLayout()
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
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(598, 150)
        Me.Guna2ShadowPanel1.TabIndex = 20
        '
        'Guna2PictureBox1
        '
        Me.Guna2Transition1.SetDecoration(Me.Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(146, 38)
        Me.Guna2HtmlLabel3.TabIndex = 12
        Me.Guna2HtmlLabel3.Text = "DEPARTMENTS"
        '
        'Guna2ShadowForm1
        '
        Me.Guna2ShadowForm1.TargetForm = Me
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
        Me.ListPanel.Controls.Add(Me.departmentGridView)
        Me.Guna2Transition1.SetDecoration(Me.ListPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ListPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListPanel.Location = New System.Drawing.Point(0, 0)
        Me.ListPanel.Name = "ListPanel"
        Me.ListPanel.ShadowDecoration.Parent = Me.ListPanel
        Me.ListPanel.Size = New System.Drawing.Size(598, 605)
        Me.ListPanel.TabIndex = 21
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
        Me.CloseBtn.Location = New System.Drawing.Point(485, 560)
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
        Me.DeleteBtn.Location = New System.Drawing.Point(378, 560)
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
        Me.AddBtn.Location = New System.Drawing.Point(275, 560)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.ShadowDecoration.Parent = Me.AddBtn
        Me.AddBtn.Size = New System.Drawing.Size(97, 36)
        Me.AddBtn.TabIndex = 26
        Me.AddBtn.Text = "Add New"
        '
        'departmentGridView
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.departmentGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.departmentGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.departmentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.departmentGridView.BackgroundColor = System.Drawing.Color.White
        Me.departmentGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.departmentGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.departmentGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.departmentGridView.ColumnHeadersHeight = 35
        Me.departmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Guna2Transition1.SetDecoration(Me.departmentGridView, Guna.UI2.AnimatorNS.DecorationType.None)
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.departmentGridView.DefaultCellStyle = DataGridViewCellStyle9
        Me.departmentGridView.EnableHeadersVisualStyles = False
        Me.departmentGridView.GridColor = System.Drawing.Color.White
        Me.departmentGridView.Location = New System.Drawing.Point(1, 156)
        Me.departmentGridView.MultiSelect = False
        Me.departmentGridView.Name = "departmentGridView"
        Me.departmentGridView.ReadOnly = True
        Me.departmentGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.departmentGridView.RowHeadersVisible = False
        Me.departmentGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.departmentGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.departmentGridView.ShowEditingIcon = False
        Me.departmentGridView.Size = New System.Drawing.Size(595, 393)
        Me.departmentGridView.TabIndex = 25
        Me.departmentGridView.TabStop = False
        Me.departmentGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.departmentGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.departmentGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.departmentGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.departmentGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.departmentGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.departmentGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.departmentGridView.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.departmentGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.departmentGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.departmentGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.departmentGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.departmentGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.departmentGridView.ThemeStyle.HeaderStyle.Height = 35
        Me.departmentGridView.ThemeStyle.ReadOnly = True
        Me.departmentGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.departmentGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.departmentGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.departmentGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.departmentGridView.ThemeStyle.RowsStyle.Height = 22
        Me.departmentGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.departmentGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'AddPaned
        '
        Me.AddPaned.Controls.Add(Me.DeptTxb)
        Me.AddPaned.Controls.Add(Me.CancelBtn)
        Me.AddPaned.Controls.Add(Me.SaveBtn)
        Me.Guna2Transition1.SetDecoration(Me.AddPaned, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.AddPaned.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddPaned.Location = New System.Drawing.Point(0, 0)
        Me.AddPaned.Name = "AddPaned"
        Me.AddPaned.ShadowDecoration.Parent = Me.AddPaned
        Me.AddPaned.Size = New System.Drawing.Size(598, 605)
        Me.AddPaned.TabIndex = 21
        '
        'DeptTxb
        '
        Me.DeptTxb.BorderColor = System.Drawing.Color.Gray
        Me.DeptTxb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.DeptTxb, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DeptTxb.DefaultText = ""
        Me.DeptTxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.DeptTxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.DeptTxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DeptTxb.DisabledState.Parent = Me.DeptTxb
        Me.DeptTxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DeptTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DeptTxb.FocusedState.Parent = Me.DeptTxb
        Me.DeptTxb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DeptTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DeptTxb.HoverState.Parent = Me.DeptTxb
        Me.DeptTxb.Location = New System.Drawing.Point(19, 172)
        Me.DeptTxb.Name = "DeptTxb"
        Me.DeptTxb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DeptTxb.PlaceholderText = "Insert Department Name"
        Me.DeptTxb.SelectedText = ""
        Me.DeptTxb.ShadowDecoration.Parent = Me.DeptTxb
        Me.DeptTxb.Size = New System.Drawing.Size(566, 36)
        Me.DeptTxb.TabIndex = 31
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
        Me.CancelBtn.Location = New System.Drawing.Point(485, 557)
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
        Me.SaveBtn.Location = New System.Drawing.Point(382, 557)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.ShadowDecoration.Parent = Me.SaveBtn
        Me.SaveBtn.Size = New System.Drawing.Size(97, 36)
        Me.SaveBtn.TabIndex = 29
        Me.SaveBtn.Text = "Save"
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide
        Me.Guna2Transition1.Cursor = Nothing
        Animation3.AnimateOnlyDifferences = True
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"), System.Drawing.PointF)
        Animation3.LeafCoeff = 0!
        Animation3.MaxTime = 1.0!
        Animation3.MinTime = 0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"), System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"), System.Drawing.PointF)
        Animation3.MosaicSize = 0
        Animation3.Padding = New System.Windows.Forms.Padding(0)
        Animation3.RotateCoeff = 0!
        Animation3.RotateLimit = 0!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"), System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"), System.Drawing.PointF)
        Animation3.TimeCoeff = 0!
        Animation3.TransparencyCoeff = 0!
        Me.Guna2Transition1.DefaultAnimation = Animation3
        '
        'DepartmentFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(598, 605)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.ListPanel)
        Me.Controls.Add(Me.AddPaned)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DepartmentFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DepartmentFrm"
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ListPanel.ResumeLayout(False)
        CType(Me.departmentGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddPaned.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents AddPaned As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ListPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CloseBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DeleteBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AddBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents departmentGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents CancelBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SaveBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents DeptTxb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class

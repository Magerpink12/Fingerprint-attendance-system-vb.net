<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.RegTxb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DeptCombo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GenderCombo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.profilePicBox = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.clearBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.browseBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.FirstNameTxb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LastNameTxb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.AddressTxb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtStatus = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PBoxThumb = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtCount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.verificationLabel = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(Me.profilePicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBoxThumb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RegTxb
        '
        Me.RegTxb.Animated = True
        Me.RegTxb.AutoRoundedCorners = True
        Me.RegTxb.BorderRadius = 14
        Me.RegTxb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RegTxb.DefaultText = ""
        Me.RegTxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.RegTxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.RegTxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.RegTxb.DisabledState.Parent = Me.RegTxb
        Me.RegTxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.RegTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RegTxb.FocusedState.Parent = Me.RegTxb
        Me.RegTxb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RegTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RegTxb.HoverState.Parent = Me.RegTxb
        Me.RegTxb.Location = New System.Drawing.Point(50, 164)
        Me.RegTxb.Name = "RegTxb"
        Me.RegTxb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.RegTxb.PlaceholderText = "Registration No."
        Me.RegTxb.SelectedText = ""
        Me.RegTxb.ShadowDecoration.Parent = Me.RegTxb
        Me.RegTxb.Size = New System.Drawing.Size(409, 30)
        Me.RegTxb.TabIndex = 6
        '
        'DeptCombo
        '
        Me.DeptCombo.Animated = True
        Me.DeptCombo.AutoRoundedCorners = True
        Me.DeptCombo.BackColor = System.Drawing.Color.Transparent
        Me.DeptCombo.BorderRadius = 17
        Me.DeptCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.DeptCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DeptCombo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DeptCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DeptCombo.FocusedState.Parent = Me.DeptCombo
        Me.DeptCombo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DeptCombo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.DeptCombo.HoverState.Parent = Me.DeptCombo
        Me.DeptCombo.ItemHeight = 30
        Me.DeptCombo.ItemsAppearance.Parent = Me.DeptCombo
        Me.DeptCombo.Location = New System.Drawing.Point(195, 112)
        Me.DeptCombo.Name = "DeptCombo"
        Me.DeptCombo.ShadowDecoration.Parent = Me.DeptCombo
        Me.DeptCombo.Size = New System.Drawing.Size(264, 36)
        Me.DeptCombo.TabIndex = 7
        '
        'GenderCombo
        '
        Me.GenderCombo.Animated = True
        Me.GenderCombo.AutoRoundedCorners = True
        Me.GenderCombo.BackColor = System.Drawing.Color.Transparent
        Me.GenderCombo.BorderRadius = 17
        Me.GenderCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.GenderCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenderCombo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GenderCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GenderCombo.FocusedState.Parent = Me.GenderCombo
        Me.GenderCombo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GenderCombo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.GenderCombo.HoverState.Parent = Me.GenderCombo
        Me.GenderCombo.ItemHeight = 30
        Me.GenderCombo.Items.AddRange(New Object() {"", "Male", "Female", "Other"})
        Me.GenderCombo.ItemsAppearance.Parent = Me.GenderCombo
        Me.GenderCombo.Location = New System.Drawing.Point(145, 336)
        Me.GenderCombo.Name = "GenderCombo"
        Me.GenderCombo.ShadowDecoration.Parent = Me.GenderCombo
        Me.GenderCombo.Size = New System.Drawing.Size(314, 36)
        Me.GenderCombo.TabIndex = 7
        '
        'profilePicBox
        '
        Me.profilePicBox.ErrorImage = CType(resources.GetObject("profilePicBox.ErrorImage"), System.Drawing.Image)
        Me.profilePicBox.Image = CType(resources.GetObject("profilePicBox.Image"), System.Drawing.Image)
        Me.profilePicBox.InitialImage = CType(resources.GetObject("profilePicBox.InitialImage"), System.Drawing.Image)
        Me.profilePicBox.Location = New System.Drawing.Point(576, 132)
        Me.profilePicBox.Name = "profilePicBox"
        Me.profilePicBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.profilePicBox.ShadowDecoration.Parent = Me.profilePicBox
        Me.profilePicBox.Size = New System.Drawing.Size(209, 205)
        Me.profilePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.profilePicBox.TabIndex = 8
        Me.profilePicBox.TabStop = False
        Me.profilePicBox.UseTransparentBackground = True
        '
        'clearBtn
        '
        Me.clearBtn.BorderRadius = 5
        Me.clearBtn.CheckedState.Parent = Me.clearBtn
        Me.clearBtn.CustomImages.Parent = Me.clearBtn
        Me.clearBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.clearBtn.ForeColor = System.Drawing.Color.White
        Me.clearBtn.HoverState.Parent = Me.clearBtn
        Me.clearBtn.Location = New System.Drawing.Point(683, 376)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.ShadowDecoration.Parent = Me.clearBtn
        Me.clearBtn.Size = New System.Drawing.Size(180, 45)
        Me.clearBtn.TabIndex = 9
        Me.clearBtn.Text = "Clear"
        '
        'browseBtn
        '
        Me.browseBtn.BorderRadius = 5
        Me.browseBtn.CheckedState.Parent = Me.browseBtn
        Me.browseBtn.CustomImages.Parent = Me.browseBtn
        Me.browseBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.browseBtn.ForeColor = System.Drawing.Color.White
        Me.browseBtn.HoverState.Parent = Me.browseBtn
        Me.browseBtn.Location = New System.Drawing.Point(601, 330)
        Me.browseBtn.Name = "browseBtn"
        Me.browseBtn.ShadowDecoration.Parent = Me.browseBtn
        Me.browseBtn.Size = New System.Drawing.Size(159, 25)
        Me.browseBtn.TabIndex = 10
        Me.browseBtn.Text = "Browse Image"
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        '
        'FirstNameTxb
        '
        Me.FirstNameTxb.Animated = True
        Me.FirstNameTxb.AutoRoundedCorners = True
        Me.FirstNameTxb.BorderRadius = 14
        Me.FirstNameTxb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FirstNameTxb.DefaultText = ""
        Me.FirstNameTxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FirstNameTxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FirstNameTxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FirstNameTxb.DisabledState.Parent = Me.FirstNameTxb
        Me.FirstNameTxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FirstNameTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FirstNameTxb.FocusedState.Parent = Me.FirstNameTxb
        Me.FirstNameTxb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FirstNameTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FirstNameTxb.HoverState.Parent = Me.FirstNameTxb
        Me.FirstNameTxb.Location = New System.Drawing.Point(50, 208)
        Me.FirstNameTxb.Name = "FirstNameTxb"
        Me.FirstNameTxb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FirstNameTxb.PlaceholderText = "First Name"
        Me.FirstNameTxb.SelectedText = ""
        Me.FirstNameTxb.ShadowDecoration.Parent = Me.FirstNameTxb
        Me.FirstNameTxb.Size = New System.Drawing.Size(409, 30)
        Me.FirstNameTxb.TabIndex = 6
        '
        'LastNameTxb
        '
        Me.LastNameTxb.Animated = True
        Me.LastNameTxb.AutoRoundedCorners = True
        Me.LastNameTxb.BorderRadius = 14
        Me.LastNameTxb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LastNameTxb.DefaultText = ""
        Me.LastNameTxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.LastNameTxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.LastNameTxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LastNameTxb.DisabledState.Parent = Me.LastNameTxb
        Me.LastNameTxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LastNameTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LastNameTxb.FocusedState.Parent = Me.LastNameTxb
        Me.LastNameTxb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LastNameTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LastNameTxb.HoverState.Parent = Me.LastNameTxb
        Me.LastNameTxb.Location = New System.Drawing.Point(50, 255)
        Me.LastNameTxb.Name = "LastNameTxb"
        Me.LastNameTxb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LastNameTxb.PlaceholderText = "Last Name"
        Me.LastNameTxb.SelectedText = ""
        Me.LastNameTxb.ShadowDecoration.Parent = Me.LastNameTxb
        Me.LastNameTxb.Size = New System.Drawing.Size(409, 30)
        Me.LastNameTxb.TabIndex = 6
        '
        'AddressTxb
        '
        Me.AddressTxb.Animated = True
        Me.AddressTxb.AutoRoundedCorners = True
        Me.AddressTxb.BorderRadius = 14
        Me.AddressTxb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AddressTxb.DefaultText = ""
        Me.AddressTxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.AddressTxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.AddressTxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AddressTxb.DisabledState.Parent = Me.AddressTxb
        Me.AddressTxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AddressTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AddressTxb.FocusedState.Parent = Me.AddressTxb
        Me.AddressTxb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddressTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AddressTxb.HoverState.Parent = Me.AddressTxb
        Me.AddressTxb.Location = New System.Drawing.Point(50, 302)
        Me.AddressTxb.Name = "AddressTxb"
        Me.AddressTxb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AddressTxb.PlaceholderText = "Address"
        Me.AddressTxb.SelectedText = ""
        Me.AddressTxb.ShadowDecoration.Parent = Me.AddressTxb
        Me.AddressTxb.Size = New System.Drawing.Size(409, 30)
        Me.AddressTxb.TabIndex = 6
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Poppins Light", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(51, 111)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(138, 38)
        Me.Guna2HtmlLabel1.TabIndex = 11
        Me.Guna2HtmlLabel1.Text = "Department:"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Poppins Light", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(51, 335)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(88, 38)
        Me.Guna2HtmlLabel2.TabIndex = 11
        Me.Guna2HtmlLabel2.Text = "Gender:"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Poppins Light", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(158, 63)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(176, 38)
        Me.Guna2HtmlLabel3.TabIndex = 12
        Me.Guna2HtmlLabel3.Text = "STUDENT DIALOG"
        '
        'txtStatus
        '
        Me.txtStatus.Animated = True
        Me.txtStatus.BorderRadius = 5
        Me.txtStatus.Cursor = System.Windows.Forms.Cursors.IBeam
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
        Me.txtStatus.Location = New System.Drawing.Point(50, 407)
        Me.txtStatus.Multiline = True
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStatus.PlaceholderText = ""
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.SelectedText = ""
        Me.txtStatus.ShadowDecoration.Parent = Me.txtStatus
        Me.txtStatus.Size = New System.Drawing.Size(410, 137)
        Me.txtStatus.TabIndex = 13
        '
        'PBoxThumb
        '
        Me.PBoxThumb.BorderRadius = 5
        Me.PBoxThumb.FillColor = System.Drawing.Color.Black
        Me.PBoxThumb.Location = New System.Drawing.Point(473, 376)
        Me.PBoxThumb.Name = "PBoxThumb"
        Me.PBoxThumb.ShadowDecoration.Parent = Me.PBoxThumb
        Me.PBoxThumb.Size = New System.Drawing.Size(199, 168)
        Me.PBoxThumb.TabIndex = 14
        Me.PBoxThumb.TabStop = False
        '
        'txtCount
        '
        Me.txtCount.Animated = True
        Me.txtCount.BorderRadius = 5
        Me.txtCount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCount.DefaultText = ""
        Me.txtCount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCount.DisabledState.Parent = Me.txtCount
        Me.txtCount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCount.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCount.FocusedState.Parent = Me.txtCount
        Me.txtCount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCount.HoverState.Parent = Me.txtCount
        Me.txtCount.Location = New System.Drawing.Point(49, 376)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCount.PlaceholderText = ""
        Me.txtCount.ReadOnly = True
        Me.txtCount.SelectedText = ""
        Me.txtCount.ShadowDecoration.Parent = Me.txtCount
        Me.txtCount.Size = New System.Drawing.Size(411, 26)
        Me.txtCount.TabIndex = 15
        '
        'btnSave
        '
        Me.btnSave.BorderRadius = 5
        Me.btnSave.CheckedState.Parent = Me.btnSave
        Me.btnSave.CustomImages.Parent = Me.btnSave
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.HoverState.Parent = Me.btnSave
        Me.btnSave.Location = New System.Drawing.Point(683, 437)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(180, 45)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        '
        'btnClose
        '
        Me.btnClose.Animated = True
        Me.btnClose.BorderRadius = 5
        Me.btnClose.CheckedState.Parent = Me.btnClose
        Me.btnClose.CustomImages.Parent = Me.btnClose
        Me.btnClose.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.Parent = Me.btnClose
        Me.btnClose.Location = New System.Drawing.Point(683, 498)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(180, 45)
        Me.btnClose.TabIndex = 17
        Me.btnClose.Text = "Close"
        '
        'verificationLabel
        '
        Me.verificationLabel.Animated = True
        Me.verificationLabel.BackColor = System.Drawing.Color.Transparent
        Me.verificationLabel.BorderColor = System.Drawing.Color.DarkGray
        Me.verificationLabel.CheckedState.Parent = Me.verificationLabel
        Me.verificationLabel.CustomImages.Parent = Me.verificationLabel
        Me.verificationLabel.FillColor = System.Drawing.Color.Silver
        Me.verificationLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.verificationLabel.ForeColor = System.Drawing.Color.White
        Me.verificationLabel.HoverState.Parent = Me.verificationLabel
        Me.verificationLabel.Location = New System.Drawing.Point(567, 151)
        Me.verificationLabel.Name = "verificationLabel"
        Me.verificationLabel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.verificationLabel.ShadowDecoration.Parent = Me.verificationLabel
        Me.verificationLabel.Size = New System.Drawing.Size(56, 53)
        Me.verificationLabel.TabIndex = 18
        Me.verificationLabel.Text = "STATUS"
        Me.verificationLabel.UseTransparentBackground = True
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(912, 104)
        Me.Guna2ShadowPanel1.TabIndex = 19
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(128, 75)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 13
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Poppins Light", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(364, 284)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(54, 21)
        Me.Guna2HtmlLabel4.TabIndex = 11
        Me.Guna2HtmlLabel4.Text = "Address"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Poppins Light", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(314, 146)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(104, 21)
        Me.Guna2HtmlLabel5.TabIndex = 11
        Me.Guna2HtmlLabel5.Text = "Registration No."
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Poppins Light", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(348, 237)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(70, 21)
        Me.Guna2HtmlLabel6.TabIndex = 11
        Me.Guna2HtmlLabel6.Text = "Last Name"
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Poppins Light", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(347, 192)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(71, 21)
        Me.Guna2HtmlLabel7.TabIndex = 11
        Me.Guna2HtmlLabel7.Text = "First Name"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(912, 562)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.verificationLabel)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtCount)
        Me.Controls.Add(Me.PBoxThumb)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.browseBtn)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.profilePicBox)
        Me.Controls.Add(Me.GenderCombo)
        Me.Controls.Add(Me.DeptCombo)
        Me.Controls.Add(Me.AddressTxb)
        Me.Controls.Add(Me.LastNameTxb)
        Me.Controls.Add(Me.FirstNameTxb)
        Me.Controls.Add(Me.RegTxb)
        Me.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ADD STUDENT DIALOG"
        CType(Me.profilePicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBoxThumb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RegTxb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DeptCombo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GenderCombo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents profilePicBox As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents clearBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents browseBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents AddressTxb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LastNameTxb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents FirstNameTxb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtStatus As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PBoxThumb As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtCount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents verificationLabel As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class

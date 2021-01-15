<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminArea
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EditSenbtn = New System.Windows.Forms.Button()
        Me.EditCapBtn = New System.Windows.Forms.Button()
        Me.EditPresBtn = New System.Windows.Forms.Button()
        Me.resltsbtn = New System.Windows.Forms.Button()
        Me.Infobtn = New System.Windows.Forms.Button()
        Me.PresidentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VotingProjectDataSet = New WindowsApplication10.VotingProjectDataSet()
        Me.PresidentTableAdapter = New WindowsApplication10.VotingProjectDataSetTableAdapters.presidentTableAdapter()
        Me.ImgOpnFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.CaptainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdminUsersTableAdapter1 = New WindowsApplication10.VotingProjectDataSetTableAdapters.adminUsersTableAdapter()
        Me.CaptainTableAdapter = New WindowsApplication10.VotingProjectDataSetTableAdapters.captainTableAdapter()
        Me.PaneleditSenator = New System.Windows.Forms.Panel()
        Me.savesenbtn = New System.Windows.Forms.Button()
        Me.loadsenPicbtn = New System.Windows.Forms.Button()
        Me.senpicbox = New System.Windows.Forms.PictureBox()
        Me.SenatorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.delSenBtn = New System.Windows.Forms.Button()
        Me.nxtSenbtn = New System.Windows.Forms.Button()
        Me.prevsenbtn = New System.Windows.Forms.Button()
        Me.addnewSenbtn = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.senatortxtbx = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SenatorTableAdapter = New WindowsApplication10.VotingProjectDataSetTableAdapters.SenatorTableAdapter()
        Me.PaneleditCaptain = New System.Windows.Forms.Panel()
        Me.savecapbtn = New System.Windows.Forms.Button()
        Me.loadcappicbtn = New System.Windows.Forms.Button()
        Me.cappicbx = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.delcptnbtn = New System.Windows.Forms.Button()
        Me.nxtbtncptn = New System.Windows.Forms.Button()
        Me.prevbtncaptn = New System.Windows.Forms.Button()
        Me.addnewcapbtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.captainNametxtbx = New System.Windows.Forms.TextBox()
        Me.LoadpicBtn = New System.Windows.Forms.Button()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.AddnewBtn = New System.Windows.Forms.Button()
        Me.prevbtn = New System.Windows.Forms.Button()
        Me.nxtbtn = New System.Windows.Forms.Button()
        Me.deltbtn = New System.Windows.Forms.Button()
        Me.presNmtxtbx = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PaneleditPresident = New System.Windows.Forms.Panel()
        Me.CandPictureBox = New System.Windows.Forms.PictureBox()
        Me.PanelResults = New System.Windows.Forms.Panel()
        Me.LoadResltsBtn = New System.Windows.Forms.Button()
        Me.sen3prgsBr = New System.Windows.Forms.ProgressBar()
        Me.sen2prgsBr = New System.Windows.Forms.ProgressBar()
        Me.laabel = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.sen1prgsBr = New System.Windows.Forms.ProgressBar()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cap2prgrsbar = New System.Windows.Forms.ProgressBar()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cap3prgrsbar = New System.Windows.Forms.ProgressBar()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cap1prgrsbar = New System.Windows.Forms.ProgressBar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pres3prgrssbr = New System.Windows.Forms.ProgressBar()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.auba = New System.Windows.Forms.Label()
        Me.pres1prgrssbr = New System.Windows.Forms.ProgressBar()
        Me.Sammir = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PanelPresidentResults = New System.Windows.Forms.Panel()
        Me.leovoteslabel = New System.Windows.Forms.Label()
        Me.aubavoteslabel = New System.Windows.Forms.Label()
        Me.sammirvoteslabel = New System.Windows.Forms.Label()
        Me.pres2prgrssbr = New System.Windows.Forms.ProgressBar()
        Me.PanelCaptainResults = New System.Windows.Forms.Panel()
        Me.theovoteslabel = New System.Windows.Forms.Label()
        Me.joyvoteslabel = New System.Windows.Forms.Label()
        Me.mariamvoteslabel = New System.Windows.Forms.Label()
        Me.PanelSenatorResults = New System.Windows.Forms.Panel()
        Me.adenvoteslabel = New System.Windows.Forms.Label()
        Me.fatmavoteslabel = New System.Windows.Forms.Label()
        Me.katvoteslabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PresidentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VotingProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaptainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaneleditSenator.SuspendLayout()
        CType(Me.senpicbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SenatorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaneleditCaptain.SuspendLayout()
        CType(Me.cappicbx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaneleditPresident.SuspendLayout()
        CType(Me.CandPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelResults.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelPresidentResults.SuspendLayout()
        Me.PanelCaptainResults.SuspendLayout()
        Me.PanelSenatorResults.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.Controls.Add(Me.EditSenbtn)
        Me.Panel1.Controls.Add(Me.EditCapBtn)
        Me.Panel1.Controls.Add(Me.EditPresBtn)
        Me.Panel1.Controls.Add(Me.resltsbtn)
        Me.Panel1.Controls.Add(Me.Infobtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 434)
        Me.Panel1.TabIndex = 4
        '
        'EditSenbtn
        '
        Me.EditSenbtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.EditSenbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.EditSenbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EditSenbtn.ForeColor = System.Drawing.Color.DarkGreen
        Me.EditSenbtn.Image = Global.WindowsApplication10.My.Resources.Resources.Add_User_Male_50px1
        Me.EditSenbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditSenbtn.Location = New System.Drawing.Point(0, 145)
        Me.EditSenbtn.Name = "EditSenbtn"
        Me.EditSenbtn.Size = New System.Drawing.Size(194, 69)
        Me.EditSenbtn.TabIndex = 8
        Me.EditSenbtn.Text = "EditSenator"
        Me.EditSenbtn.UseVisualStyleBackColor = False
        '
        'EditCapBtn
        '
        Me.EditCapBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.EditCapBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.EditCapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EditCapBtn.ForeColor = System.Drawing.Color.DarkGreen
        Me.EditCapBtn.Image = Global.WindowsApplication10.My.Resources.Resources.Add_User_Male_50px1
        Me.EditCapBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditCapBtn.Location = New System.Drawing.Point(0, 72)
        Me.EditCapBtn.Name = "EditCapBtn"
        Me.EditCapBtn.Size = New System.Drawing.Size(194, 69)
        Me.EditCapBtn.TabIndex = 7
        Me.EditCapBtn.Text = "Edit Captain"
        Me.EditCapBtn.UseVisualStyleBackColor = False
        '
        'EditPresBtn
        '
        Me.EditPresBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.EditPresBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.EditPresBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EditPresBtn.ForeColor = System.Drawing.Color.DarkGreen
        Me.EditPresBtn.Image = Global.WindowsApplication10.My.Resources.Resources.Add_User_Male_50px1
        Me.EditPresBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditPresBtn.Location = New System.Drawing.Point(3, 1)
        Me.EditPresBtn.Name = "EditPresBtn"
        Me.EditPresBtn.Size = New System.Drawing.Size(194, 69)
        Me.EditPresBtn.TabIndex = 6
        Me.EditPresBtn.Text = "Edit President"
        Me.EditPresBtn.UseVisualStyleBackColor = False
        '
        'resltsbtn
        '
        Me.resltsbtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.resltsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.resltsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.resltsbtn.ForeColor = System.Drawing.Color.DarkGreen
        Me.resltsbtn.Image = Global.WindowsApplication10.My.Resources.Resources.account_50px
        Me.resltsbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.resltsbtn.Location = New System.Drawing.Point(0, 243)
        Me.resltsbtn.Name = "resltsbtn"
        Me.resltsbtn.Size = New System.Drawing.Size(194, 69)
        Me.resltsbtn.TabIndex = 5
        Me.resltsbtn.Text = "RESULTS"
        Me.resltsbtn.UseVisualStyleBackColor = False
        '
        'Infobtn
        '
        Me.Infobtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Infobtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Infobtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Infobtn.ForeColor = System.Drawing.Color.DarkGreen
        Me.Infobtn.Image = Global.WindowsApplication10.My.Resources.Resources.Add_User_Male_50px
        Me.Infobtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Infobtn.Location = New System.Drawing.Point(0, 334)
        Me.Infobtn.Name = "Infobtn"
        Me.Infobtn.Size = New System.Drawing.Size(194, 69)
        Me.Infobtn.TabIndex = 4
        Me.Infobtn.Text = "Information"
        Me.Infobtn.UseVisualStyleBackColor = False
        '
        'PresidentBindingSource
        '
        Me.PresidentBindingSource.DataMember = "president"
        Me.PresidentBindingSource.DataSource = Me.VotingProjectDataSet
        '
        'VotingProjectDataSet
        '
        Me.VotingProjectDataSet.DataSetName = "VotingProjectDataSet"
        Me.VotingProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PresidentTableAdapter
        '
        Me.PresidentTableAdapter.ClearBeforeFill = True
        '
        'ImgOpnFileDialog
        '
        Me.ImgOpnFileDialog.FileName = "ImgOpnFileDialog"
        '
        'CaptainBindingSource
        '
        Me.CaptainBindingSource.DataMember = "captain"
        Me.CaptainBindingSource.DataSource = Me.VotingProjectDataSet
        '
        'AdminUsersTableAdapter1
        '
        Me.AdminUsersTableAdapter1.ClearBeforeFill = True
        '
        'CaptainTableAdapter
        '
        Me.CaptainTableAdapter.ClearBeforeFill = True
        '
        'PaneleditSenator
        '
        Me.PaneleditSenator.BackColor = System.Drawing.SystemColors.Desktop
        Me.PaneleditSenator.Controls.Add(Me.savesenbtn)
        Me.PaneleditSenator.Controls.Add(Me.loadsenPicbtn)
        Me.PaneleditSenator.Controls.Add(Me.senpicbox)
        Me.PaneleditSenator.Controls.Add(Me.delSenBtn)
        Me.PaneleditSenator.Controls.Add(Me.nxtSenbtn)
        Me.PaneleditSenator.Controls.Add(Me.prevsenbtn)
        Me.PaneleditSenator.Controls.Add(Me.addnewSenbtn)
        Me.PaneleditSenator.Controls.Add(Me.Label10)
        Me.PaneleditSenator.Controls.Add(Me.senatortxtbx)
        Me.PaneleditSenator.Controls.Add(Me.Label9)
        Me.PaneleditSenator.Location = New System.Drawing.Point(206, 285)
        Me.PaneleditSenator.Name = "PaneleditSenator"
        Me.PaneleditSenator.Size = New System.Drawing.Size(677, 149)
        Me.PaneleditSenator.TabIndex = 10
        '
        'savesenbtn
        '
        Me.savesenbtn.Location = New System.Drawing.Point(527, 96)
        Me.savesenbtn.Name = "savesenbtn"
        Me.savesenbtn.Size = New System.Drawing.Size(75, 23)
        Me.savesenbtn.TabIndex = 38
        Me.savesenbtn.Text = "Save"
        Me.savesenbtn.UseVisualStyleBackColor = True
        '
        'loadsenPicbtn
        '
        Me.loadsenPicbtn.Location = New System.Drawing.Point(527, 11)
        Me.loadsenPicbtn.Name = "loadsenPicbtn"
        Me.loadsenPicbtn.Size = New System.Drawing.Size(75, 23)
        Me.loadsenPicbtn.TabIndex = 37
        Me.loadsenPicbtn.Text = "loadpic"
        Me.loadsenPicbtn.UseVisualStyleBackColor = True
        '
        'senpicbox
        '
        Me.senpicbox.BackColor = System.Drawing.Color.Snow
        Me.senpicbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.senpicbox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.SenatorBindingSource, "senPic", True))
        Me.senpicbox.Image = Global.WindowsApplication10.My.Resources.Resources.admin
        Me.senpicbox.Location = New System.Drawing.Point(306, 5)
        Me.senpicbox.Name = "senpicbox"
        Me.senpicbox.Size = New System.Drawing.Size(157, 140)
        Me.senpicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.senpicbox.TabIndex = 35
        Me.senpicbox.TabStop = False
        '
        'SenatorBindingSource
        '
        Me.SenatorBindingSource.DataMember = "Senator"
        Me.SenatorBindingSource.DataSource = Me.VotingProjectDataSet
        '
        'delSenBtn
        '
        Me.delSenBtn.Location = New System.Drawing.Point(28, 95)
        Me.delSenBtn.Name = "delSenBtn"
        Me.delSenBtn.Size = New System.Drawing.Size(46, 23)
        Me.delSenBtn.TabIndex = 34
        Me.delSenBtn.Text = "del"
        Me.delSenBtn.UseVisualStyleBackColor = True
        '
        'nxtSenbtn
        '
        Me.nxtSenbtn.Location = New System.Drawing.Point(161, 66)
        Me.nxtSenbtn.Name = "nxtSenbtn"
        Me.nxtSenbtn.Size = New System.Drawing.Size(38, 23)
        Me.nxtSenbtn.TabIndex = 33
        Me.nxtSenbtn.Text = "nxt"
        Me.nxtSenbtn.UseVisualStyleBackColor = True
        '
        'prevsenbtn
        '
        Me.prevsenbtn.Location = New System.Drawing.Point(97, 66)
        Me.prevsenbtn.Name = "prevsenbtn"
        Me.prevsenbtn.Size = New System.Drawing.Size(58, 23)
        Me.prevsenbtn.TabIndex = 32
        Me.prevsenbtn.Text = "prev"
        Me.prevsenbtn.UseVisualStyleBackColor = True
        '
        'addnewSenbtn
        '
        Me.addnewSenbtn.Location = New System.Drawing.Point(28, 66)
        Me.addnewSenbtn.Name = "addnewSenbtn"
        Me.addnewSenbtn.Size = New System.Drawing.Size(63, 23)
        Me.addnewSenbtn.TabIndex = 31
        Me.addnewSenbtn.Text = "Addnew"
        Me.addnewSenbtn.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.Location = New System.Drawing.Point(16, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Name"
        '
        'senatortxtbx
        '
        Me.senatortxtbx.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SenatorBindingSource, "senName", True))
        Me.senatortxtbx.Location = New System.Drawing.Point(65, 30)
        Me.senatortxtbx.Name = "senatortxtbx"
        Me.senatortxtbx.Size = New System.Drawing.Size(169, 20)
        Me.senatortxtbx.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Lime
        Me.Label9.Location = New System.Drawing.Point(3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Edit Senator"
        '
        'SenatorTableAdapter
        '
        Me.SenatorTableAdapter.ClearBeforeFill = True
        '
        'PaneleditCaptain
        '
        Me.PaneleditCaptain.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PaneleditCaptain.Controls.Add(Me.savecapbtn)
        Me.PaneleditCaptain.Controls.Add(Me.loadcappicbtn)
        Me.PaneleditCaptain.Controls.Add(Me.cappicbx)
        Me.PaneleditCaptain.Controls.Add(Me.Label4)
        Me.PaneleditCaptain.Controls.Add(Me.delcptnbtn)
        Me.PaneleditCaptain.Controls.Add(Me.nxtbtncptn)
        Me.PaneleditCaptain.Controls.Add(Me.prevbtncaptn)
        Me.PaneleditCaptain.Controls.Add(Me.addnewcapbtn)
        Me.PaneleditCaptain.Controls.Add(Me.Label3)
        Me.PaneleditCaptain.Controls.Add(Me.captainNametxtbx)
        Me.PaneleditCaptain.Location = New System.Drawing.Point(206, 145)
        Me.PaneleditCaptain.Name = "PaneleditCaptain"
        Me.PaneleditCaptain.Size = New System.Drawing.Size(680, 134)
        Me.PaneleditCaptain.TabIndex = 12
        '
        'savecapbtn
        '
        Me.savecapbtn.Location = New System.Drawing.Point(528, 94)
        Me.savecapbtn.Name = "savecapbtn"
        Me.savecapbtn.Size = New System.Drawing.Size(75, 23)
        Me.savecapbtn.TabIndex = 30
        Me.savecapbtn.Text = "Save"
        Me.savecapbtn.UseVisualStyleBackColor = True
        '
        'loadcappicbtn
        '
        Me.loadcappicbtn.Location = New System.Drawing.Point(528, 9)
        Me.loadcappicbtn.Name = "loadcappicbtn"
        Me.loadcappicbtn.Size = New System.Drawing.Size(75, 23)
        Me.loadcappicbtn.TabIndex = 29
        Me.loadcappicbtn.Text = "loadpic"
        Me.loadcappicbtn.UseVisualStyleBackColor = True
        '
        'cappicbx
        '
        Me.cappicbx.BackColor = System.Drawing.Color.Snow
        Me.cappicbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cappicbx.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.CaptainBindingSource, "cappicture", True))
        Me.cappicbx.Image = Global.WindowsApplication10.My.Resources.Resources.admin
        Me.cappicbx.Location = New System.Drawing.Point(307, 3)
        Me.cappicbx.Name = "cappicbx"
        Me.cappicbx.Size = New System.Drawing.Size(157, 140)
        Me.cappicbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cappicbx.TabIndex = 28
        Me.cappicbx.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Edit Captain"
        '
        'delcptnbtn
        '
        Me.delcptnbtn.Location = New System.Drawing.Point(15, 98)
        Me.delcptnbtn.Name = "delcptnbtn"
        Me.delcptnbtn.Size = New System.Drawing.Size(46, 23)
        Me.delcptnbtn.TabIndex = 26
        Me.delcptnbtn.Text = "del"
        Me.delcptnbtn.UseVisualStyleBackColor = True
        '
        'nxtbtncptn
        '
        Me.nxtbtncptn.Location = New System.Drawing.Point(148, 69)
        Me.nxtbtncptn.Name = "nxtbtncptn"
        Me.nxtbtncptn.Size = New System.Drawing.Size(38, 23)
        Me.nxtbtncptn.TabIndex = 25
        Me.nxtbtncptn.Text = "nxt"
        Me.nxtbtncptn.UseVisualStyleBackColor = True
        '
        'prevbtncaptn
        '
        Me.prevbtncaptn.Location = New System.Drawing.Point(84, 69)
        Me.prevbtncaptn.Name = "prevbtncaptn"
        Me.prevbtncaptn.Size = New System.Drawing.Size(58, 23)
        Me.prevbtncaptn.TabIndex = 24
        Me.prevbtncaptn.Text = "prev"
        Me.prevbtncaptn.UseVisualStyleBackColor = True
        '
        'addnewcapbtn
        '
        Me.addnewcapbtn.Location = New System.Drawing.Point(15, 69)
        Me.addnewcapbtn.Name = "addnewcapbtn"
        Me.addnewcapbtn.Size = New System.Drawing.Size(63, 23)
        Me.addnewcapbtn.TabIndex = 23
        Me.addnewcapbtn.Text = "Addnew"
        Me.addnewcapbtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Name"
        '
        'captainNametxtbx
        '
        Me.captainNametxtbx.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CaptainBindingSource, "capName", True))
        Me.captainNametxtbx.Location = New System.Drawing.Point(52, 33)
        Me.captainNametxtbx.Name = "captainNametxtbx"
        Me.captainNametxtbx.Size = New System.Drawing.Size(169, 20)
        Me.captainNametxtbx.TabIndex = 21
        '
        'LoadpicBtn
        '
        Me.LoadpicBtn.Location = New System.Drawing.Point(528, 18)
        Me.LoadpicBtn.Name = "LoadpicBtn"
        Me.LoadpicBtn.Size = New System.Drawing.Size(75, 23)
        Me.LoadpicBtn.TabIndex = 3
        Me.LoadpicBtn.Text = "loadpic"
        Me.LoadpicBtn.UseVisualStyleBackColor = True
        '
        'saveBtn
        '
        Me.saveBtn.Location = New System.Drawing.Point(528, 103)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(75, 23)
        Me.saveBtn.TabIndex = 4
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'AddnewBtn
        '
        Me.AddnewBtn.Location = New System.Drawing.Point(32, 74)
        Me.AddnewBtn.Name = "AddnewBtn"
        Me.AddnewBtn.Size = New System.Drawing.Size(63, 23)
        Me.AddnewBtn.TabIndex = 5
        Me.AddnewBtn.Text = "Addnew"
        Me.AddnewBtn.UseVisualStyleBackColor = True
        '
        'prevbtn
        '
        Me.prevbtn.Location = New System.Drawing.Point(101, 74)
        Me.prevbtn.Name = "prevbtn"
        Me.prevbtn.Size = New System.Drawing.Size(58, 23)
        Me.prevbtn.TabIndex = 6
        Me.prevbtn.Text = "prev"
        Me.prevbtn.UseVisualStyleBackColor = True
        '
        'nxtbtn
        '
        Me.nxtbtn.Location = New System.Drawing.Point(165, 74)
        Me.nxtbtn.Name = "nxtbtn"
        Me.nxtbtn.Size = New System.Drawing.Size(38, 23)
        Me.nxtbtn.TabIndex = 7
        Me.nxtbtn.Text = "nxt"
        Me.nxtbtn.UseVisualStyleBackColor = True
        '
        'deltbtn
        '
        Me.deltbtn.Location = New System.Drawing.Point(32, 103)
        Me.deltbtn.Name = "deltbtn"
        Me.deltbtn.Size = New System.Drawing.Size(46, 23)
        Me.deltbtn.TabIndex = 8
        Me.deltbtn.Text = "del"
        Me.deltbtn.UseVisualStyleBackColor = True
        '
        'presNmtxtbx
        '
        Me.presNmtxtbx.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresidentBindingSource, "presidentName", True))
        Me.presNmtxtbx.Location = New System.Drawing.Point(110, 28)
        Me.presNmtxtbx.Name = "presNmtxtbx"
        Me.presNmtxtbx.Size = New System.Drawing.Size(169, 20)
        Me.presNmtxtbx.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(-3, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Edit president"
        '
        'PaneleditPresident
        '
        Me.PaneleditPresident.BackColor = System.Drawing.Color.LightCoral
        Me.PaneleditPresident.Controls.Add(Me.Label2)
        Me.PaneleditPresident.Controls.Add(Me.Label1)
        Me.PaneleditPresident.Controls.Add(Me.presNmtxtbx)
        Me.PaneleditPresident.Controls.Add(Me.deltbtn)
        Me.PaneleditPresident.Controls.Add(Me.nxtbtn)
        Me.PaneleditPresident.Controls.Add(Me.prevbtn)
        Me.PaneleditPresident.Controls.Add(Me.AddnewBtn)
        Me.PaneleditPresident.Controls.Add(Me.saveBtn)
        Me.PaneleditPresident.Controls.Add(Me.LoadpicBtn)
        Me.PaneleditPresident.Controls.Add(Me.CandPictureBox)
        Me.PaneleditPresident.Location = New System.Drawing.Point(209, 0)
        Me.PaneleditPresident.Name = "PaneleditPresident"
        Me.PaneleditPresident.Size = New System.Drawing.Size(674, 145)
        Me.PaneleditPresident.TabIndex = 8
        '
        'CandPictureBox
        '
        Me.CandPictureBox.BackColor = System.Drawing.Color.Snow
        Me.CandPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CandPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.PresidentBindingSource, "Picture", True))
        Me.CandPictureBox.Image = Global.WindowsApplication10.My.Resources.Resources.admin
        Me.CandPictureBox.Location = New System.Drawing.Point(307, 12)
        Me.CandPictureBox.Name = "CandPictureBox"
        Me.CandPictureBox.Size = New System.Drawing.Size(157, 132)
        Me.CandPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CandPictureBox.TabIndex = 2
        Me.CandPictureBox.TabStop = False
        '
        'PanelResults
        '
        Me.PanelResults.BackColor = System.Drawing.Color.DimGray
        Me.PanelResults.BackgroundImage = Global.WindowsApplication10.My.Resources.Resources.kisspng_voting_ballot_election_clip_art_vote_png_hd_5aa1fb8008aad81
        Me.PanelResults.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelResults.Controls.Add(Me.LoadResltsBtn)
        Me.PanelResults.Controls.Add(Me.sen3prgsBr)
        Me.PanelResults.Controls.Add(Me.sen2prgsBr)
        Me.PanelResults.Controls.Add(Me.laabel)
        Me.PanelResults.Controls.Add(Me.Label17)
        Me.PanelResults.Controls.Add(Me.sen1prgsBr)
        Me.PanelResults.Controls.Add(Me.Label18)
        Me.PanelResults.Controls.Add(Me.Label16)
        Me.PanelResults.Controls.Add(Me.cap2prgrsbar)
        Me.PanelResults.Controls.Add(Me.Label14)
        Me.PanelResults.Controls.Add(Me.cap3prgrsbar)
        Me.PanelResults.Controls.Add(Me.Label15)
        Me.PanelResults.Controls.Add(Me.Label7)
        Me.PanelResults.Controls.Add(Me.cap1prgrsbar)
        Me.PanelResults.Controls.Add(Me.Label8)
        Me.PanelResults.Controls.Add(Me.Label13)
        Me.PanelResults.Controls.Add(Me.pres3prgrssbr)
        Me.PanelResults.Controls.Add(Me.Label12)
        Me.PanelResults.Controls.Add(Me.auba)
        Me.PanelResults.Controls.Add(Me.pres1prgrssbr)
        Me.PanelResults.Controls.Add(Me.Sammir)
        Me.PanelResults.Controls.Add(Me.Panel2)
        Me.PanelResults.Controls.Add(Me.PanelPresidentResults)
        Me.PanelResults.Controls.Add(Me.PanelCaptainResults)
        Me.PanelResults.Controls.Add(Me.PanelSenatorResults)
        Me.PanelResults.Location = New System.Drawing.Point(212, 0)
        Me.PanelResults.Name = "PanelResults"
        Me.PanelResults.Size = New System.Drawing.Size(668, 431)
        Me.PanelResults.TabIndex = 22
        '
        'LoadResltsBtn
        '
        Me.LoadResltsBtn.Location = New System.Drawing.Point(237, 357)
        Me.LoadResltsBtn.Name = "LoadResltsBtn"
        Me.LoadResltsBtn.Size = New System.Drawing.Size(270, 23)
        Me.LoadResltsBtn.TabIndex = 30
        Me.LoadResltsBtn.Text = "Refresh Results"
        Me.LoadResltsBtn.UseVisualStyleBackColor = True
        '
        'sen3prgsBr
        '
        Me.sen3prgsBr.Location = New System.Drawing.Point(521, 271)
        Me.sen3prgsBr.Name = "sen3prgsBr"
        Me.sen3prgsBr.Size = New System.Drawing.Size(152, 20)
        Me.sen3prgsBr.TabIndex = 26
        '
        'sen2prgsBr
        '
        Me.sen2prgsBr.Location = New System.Drawing.Point(521, 227)
        Me.sen2prgsBr.Name = "sen2prgsBr"
        Me.sen2prgsBr.Size = New System.Drawing.Size(152, 20)
        Me.sen2prgsBr.TabIndex = 25
        '
        'laabel
        '
        Me.laabel.AutoSize = True
        Me.laabel.Location = New System.Drawing.Point(474, 278)
        Me.laabel.Name = "laabel"
        Me.laabel.Size = New System.Drawing.Size(33, 13)
        Me.laabel.TabIndex = 24
        Me.laabel.Text = "fatma"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(474, 230)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(23, 13)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Kat"
        '
        'sen1prgsBr
        '
        Me.sen1prgsBr.Location = New System.Drawing.Point(521, 178)
        Me.sen1prgsBr.Name = "sen1prgsBr"
        Me.sen1prgsBr.Size = New System.Drawing.Size(152, 20)
        Me.sen1prgsBr.TabIndex = 21
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(470, 181)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(32, 13)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Aden"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Location = New System.Drawing.Point(483, 136)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(165, 25)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Senator Results"
        '
        'cap2prgrsbar
        '
        Me.cap2prgrsbar.Location = New System.Drawing.Point(294, 225)
        Me.cap2prgrsbar.Name = "cap2prgrsbar"
        Me.cap2prgrsbar.Size = New System.Drawing.Size(152, 23)
        Me.cap2prgrsbar.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(243, 230)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "mariam"
        '
        'cap3prgrsbar
        '
        Me.cap3prgrsbar.Location = New System.Drawing.Point(294, 270)
        Me.cap3prgrsbar.Name = "cap3prgrsbar"
        Me.cap3prgrsbar.Size = New System.Drawing.Size(150, 20)
        Me.cap3prgrsbar.TabIndex = 16
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(245, 278)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(23, 13)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Joy"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(243, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 25)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Captain Results"
        '
        'cap1prgrsbar
        '
        Me.cap1prgrsbar.Location = New System.Drawing.Point(294, 178)
        Me.cap1prgrsbar.Name = "cap1prgrsbar"
        Me.cap1prgrsbar.Size = New System.Drawing.Size(152, 20)
        Me.cap1prgrsbar.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(243, 178)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Theo"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(8, 136)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(181, 25)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "President Results"
        '
        'pres3prgrssbr
        '
        Me.pres3prgrssbr.Location = New System.Drawing.Point(65, 275)
        Me.pres3prgrssbr.Name = "pres3prgrssbr"
        Me.pres3prgrssbr.Size = New System.Drawing.Size(134, 23)
        Me.pres3prgrssbr.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 278)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Leo"
        '
        'auba
        '
        Me.auba.AutoSize = True
        Me.auba.Location = New System.Drawing.Point(16, 230)
        Me.auba.Name = "auba"
        Me.auba.Size = New System.Drawing.Size(31, 13)
        Me.auba.TabIndex = 7
        Me.auba.Text = "auba"
        '
        'pres1prgrssbr
        '
        Me.pres1prgrssbr.Location = New System.Drawing.Point(65, 178)
        Me.pres1prgrssbr.Name = "pres1prgrssbr"
        Me.pres1prgrssbr.Size = New System.Drawing.Size(134, 23)
        Me.pres1prgrssbr.TabIndex = 6
        '
        'Sammir
        '
        Me.Sammir.AutoSize = True
        Me.Sammir.Location = New System.Drawing.Point(16, 181)
        Me.Sammir.Name = "Sammir"
        Me.Sammir.Size = New System.Drawing.Size(41, 13)
        Me.Sammir.TabIndex = 5
        Me.Sammir.Text = "Sammir"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.WindowsApplication10.My.Resources.Resources._86
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(6, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(667, 100)
        Me.Panel2.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(237, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 29)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Live Results"
        '
        'PanelPresidentResults
        '
        Me.PanelPresidentResults.Controls.Add(Me.leovoteslabel)
        Me.PanelPresidentResults.Controls.Add(Me.aubavoteslabel)
        Me.PanelPresidentResults.Controls.Add(Me.sammirvoteslabel)
        Me.PanelPresidentResults.Controls.Add(Me.pres2prgrssbr)
        Me.PanelPresidentResults.Location = New System.Drawing.Point(9, 127)
        Me.PanelPresidentResults.Name = "PanelPresidentResults"
        Me.PanelPresidentResults.Size = New System.Drawing.Size(200, 218)
        Me.PanelPresidentResults.TabIndex = 27
        '
        'leovoteslabel
        '
        Me.leovoteslabel.AutoSize = True
        Me.leovoteslabel.Location = New System.Drawing.Point(62, 180)
        Me.leovoteslabel.Name = "leovoteslabel"
        Me.leovoteslabel.Size = New System.Drawing.Size(21, 13)
        Me.leovoteslabel.TabIndex = 9
        Me.leovoteslabel.Text = "0%"
        '
        'aubavoteslabel
        '
        Me.aubavoteslabel.AutoSize = True
        Me.aubavoteslabel.Location = New System.Drawing.Point(58, 127)
        Me.aubavoteslabel.Name = "aubavoteslabel"
        Me.aubavoteslabel.Size = New System.Drawing.Size(27, 13)
        Me.aubavoteslabel.TabIndex = 2
        Me.aubavoteslabel.Text = "10%"
        '
        'sammirvoteslabel
        '
        Me.sammirvoteslabel.AutoSize = True
        Me.sammirvoteslabel.Location = New System.Drawing.Point(64, 78)
        Me.sammirvoteslabel.Name = "sammirvoteslabel"
        Me.sammirvoteslabel.Size = New System.Drawing.Size(24, 13)
        Me.sammirvoteslabel.TabIndex = 1
        Me.sammirvoteslabel.Text = "0 %"
        '
        'pres2prgrssbr
        '
        Me.pres2prgrssbr.Location = New System.Drawing.Point(54, 96)
        Me.pres2prgrssbr.Name = "pres2prgrssbr"
        Me.pres2prgrssbr.Size = New System.Drawing.Size(134, 23)
        Me.pres2prgrssbr.TabIndex = 8
        '
        'PanelCaptainResults
        '
        Me.PanelCaptainResults.Controls.Add(Me.theovoteslabel)
        Me.PanelCaptainResults.Controls.Add(Me.joyvoteslabel)
        Me.PanelCaptainResults.Controls.Add(Me.mariamvoteslabel)
        Me.PanelCaptainResults.Location = New System.Drawing.Point(241, 127)
        Me.PanelCaptainResults.Name = "PanelCaptainResults"
        Me.PanelCaptainResults.Size = New System.Drawing.Size(216, 218)
        Me.PanelCaptainResults.TabIndex = 28
        '
        'theovoteslabel
        '
        Me.theovoteslabel.AutoSize = True
        Me.theovoteslabel.Location = New System.Drawing.Point(57, 78)
        Me.theovoteslabel.Name = "theovoteslabel"
        Me.theovoteslabel.Size = New System.Drawing.Size(21, 13)
        Me.theovoteslabel.TabIndex = 12
        Me.theovoteslabel.Text = "0%"
        '
        'joyvoteslabel
        '
        Me.joyvoteslabel.AutoSize = True
        Me.joyvoteslabel.Location = New System.Drawing.Point(60, 177)
        Me.joyvoteslabel.Name = "joyvoteslabel"
        Me.joyvoteslabel.Size = New System.Drawing.Size(21, 13)
        Me.joyvoteslabel.TabIndex = 11
        Me.joyvoteslabel.Text = "0%"
        '
        'mariamvoteslabel
        '
        Me.mariamvoteslabel.AutoSize = True
        Me.mariamvoteslabel.Location = New System.Drawing.Point(60, 127)
        Me.mariamvoteslabel.Name = "mariamvoteslabel"
        Me.mariamvoteslabel.Size = New System.Drawing.Size(21, 13)
        Me.mariamvoteslabel.TabIndex = 10
        Me.mariamvoteslabel.Text = "0%"
        '
        'PanelSenatorResults
        '
        Me.PanelSenatorResults.Controls.Add(Me.adenvoteslabel)
        Me.PanelSenatorResults.Controls.Add(Me.fatmavoteslabel)
        Me.PanelSenatorResults.Controls.Add(Me.katvoteslabel)
        Me.PanelSenatorResults.Location = New System.Drawing.Point(468, 127)
        Me.PanelSenatorResults.Name = "PanelSenatorResults"
        Me.PanelSenatorResults.Size = New System.Drawing.Size(200, 218)
        Me.PanelSenatorResults.TabIndex = 29
        '
        'adenvoteslabel
        '
        Me.adenvoteslabel.AutoSize = True
        Me.adenvoteslabel.Location = New System.Drawing.Point(54, 76)
        Me.adenvoteslabel.Name = "adenvoteslabel"
        Me.adenvoteslabel.Size = New System.Drawing.Size(21, 13)
        Me.adenvoteslabel.TabIndex = 12
        Me.adenvoteslabel.Text = "0%"
        '
        'fatmavoteslabel
        '
        Me.fatmavoteslabel.AutoSize = True
        Me.fatmavoteslabel.Location = New System.Drawing.Point(61, 175)
        Me.fatmavoteslabel.Name = "fatmavoteslabel"
        Me.fatmavoteslabel.Size = New System.Drawing.Size(21, 13)
        Me.fatmavoteslabel.TabIndex = 11
        Me.fatmavoteslabel.Text = "0%"
        '
        'katvoteslabel
        '
        Me.katvoteslabel.AutoSize = True
        Me.katvoteslabel.Location = New System.Drawing.Point(56, 123)
        Me.katvoteslabel.Name = "katvoteslabel"
        Me.katvoteslabel.Size = New System.Drawing.Size(21, 13)
        Me.katvoteslabel.TabIndex = 10
        Me.katvoteslabel.Text = "0%"
        '
        'adminArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(882, 434)
        Me.Controls.Add(Me.PaneleditCaptain)
        Me.Controls.Add(Me.PaneleditPresident)
        Me.Controls.Add(Me.PaneleditSenator)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelResults)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adminArea"
        Me.Text = "adminArea"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PresidentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VotingProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaptainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaneleditSenator.ResumeLayout(False)
        Me.PaneleditSenator.PerformLayout()
        CType(Me.senpicbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SenatorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaneleditCaptain.ResumeLayout(False)
        Me.PaneleditCaptain.PerformLayout()
        CType(Me.cappicbx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaneleditPresident.ResumeLayout(False)
        Me.PaneleditPresident.PerformLayout()
        CType(Me.CandPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelResults.ResumeLayout(False)
        Me.PanelResults.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelPresidentResults.ResumeLayout(False)
        Me.PanelPresidentResults.PerformLayout()
        Me.PanelCaptainResults.ResumeLayout(False)
        Me.PanelCaptainResults.PerformLayout()
        Me.PanelSenatorResults.ResumeLayout(False)
        Me.PanelSenatorResults.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents EditPresBtn As System.Windows.Forms.Button
    Friend WithEvents resltsbtn As System.Windows.Forms.Button
    Friend WithEvents Infobtn As System.Windows.Forms.Button
    Friend WithEvents VotingProjectDataSet As WindowsApplication10.VotingProjectDataSet
    Friend WithEvents PresidentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresidentTableAdapter As WindowsApplication10.VotingProjectDataSetTableAdapters.presidentTableAdapter
    Friend WithEvents ImgOpnFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents AdminUsersTableAdapter1 As WindowsApplication10.VotingProjectDataSetTableAdapters.adminUsersTableAdapter
    Friend WithEvents CaptainBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CaptainTableAdapter As WindowsApplication10.VotingProjectDataSetTableAdapters.captainTableAdapter
    Friend WithEvents PaneleditSenator As System.Windows.Forms.Panel
    Friend WithEvents savesenbtn As System.Windows.Forms.Button
    Friend WithEvents loadsenPicbtn As System.Windows.Forms.Button
    Friend WithEvents senpicbox As System.Windows.Forms.PictureBox
    Friend WithEvents delSenBtn As System.Windows.Forms.Button
    Friend WithEvents nxtSenbtn As System.Windows.Forms.Button
    Friend WithEvents prevsenbtn As System.Windows.Forms.Button
    Friend WithEvents addnewSenbtn As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents senatortxtbx As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SenatorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SenatorTableAdapter As WindowsApplication10.VotingProjectDataSetTableAdapters.SenatorTableAdapter
    Friend WithEvents EditSenbtn As System.Windows.Forms.Button
    Friend WithEvents EditCapBtn As System.Windows.Forms.Button
    Friend WithEvents PaneleditCaptain As System.Windows.Forms.Panel
    Friend WithEvents savecapbtn As System.Windows.Forms.Button
    Friend WithEvents loadcappicbtn As System.Windows.Forms.Button
    Friend WithEvents cappicbx As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents delcptnbtn As System.Windows.Forms.Button
    Friend WithEvents nxtbtncptn As System.Windows.Forms.Button
    Friend WithEvents prevbtncaptn As System.Windows.Forms.Button
    Friend WithEvents addnewcapbtn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents captainNametxtbx As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Sammir As System.Windows.Forms.Label
    Friend WithEvents pres1prgrssbr As System.Windows.Forms.ProgressBar
    Friend WithEvents auba As System.Windows.Forms.Label
    Friend WithEvents pres2prgrssbr As System.Windows.Forms.ProgressBar
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents pres3prgrssbr As System.Windows.Forms.ProgressBar
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cap1prgrsbar As System.Windows.Forms.ProgressBar
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cap3prgrsbar As System.Windows.Forms.ProgressBar
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cap2prgrsbar As System.Windows.Forms.ProgressBar
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents sen1prgsBr As System.Windows.Forms.ProgressBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents laabel As System.Windows.Forms.Label
    Friend WithEvents PanelResults As System.Windows.Forms.Panel
    Friend WithEvents sen3prgsBr As System.Windows.Forms.ProgressBar
    Friend WithEvents sen2prgsBr As System.Windows.Forms.ProgressBar
    Friend WithEvents CandPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents LoadpicBtn As System.Windows.Forms.Button
    Friend WithEvents saveBtn As System.Windows.Forms.Button
    Friend WithEvents AddnewBtn As System.Windows.Forms.Button
    Friend WithEvents prevbtn As System.Windows.Forms.Button
    Friend WithEvents nxtbtn As System.Windows.Forms.Button
    Friend WithEvents deltbtn As System.Windows.Forms.Button
    Friend WithEvents presNmtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PaneleditPresident As System.Windows.Forms.Panel
    Friend WithEvents LoadResltsBtn As System.Windows.Forms.Button
    Friend WithEvents PanelPresidentResults As System.Windows.Forms.Panel
    Friend WithEvents PanelCaptainResults As System.Windows.Forms.Panel
    Friend WithEvents PanelSenatorResults As System.Windows.Forms.Panel
    Friend WithEvents leovoteslabel As System.Windows.Forms.Label
    Friend WithEvents aubavoteslabel As System.Windows.Forms.Label
    Friend WithEvents sammirvoteslabel As System.Windows.Forms.Label
    Friend WithEvents theovoteslabel As System.Windows.Forms.Label
    Friend WithEvents joyvoteslabel As System.Windows.Forms.Label
    Friend WithEvents mariamvoteslabel As System.Windows.Forms.Label
    Friend WithEvents adenvoteslabel As System.Windows.Forms.Label
    Friend WithEvents fatmavoteslabel As System.Windows.Forms.Label
    Friend WithEvents katvoteslabel As System.Windows.Forms.Label
End Class

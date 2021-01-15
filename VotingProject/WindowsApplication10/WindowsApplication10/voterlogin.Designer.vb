<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class voterlogin
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
        Me.VotersDbDataSet = New WindowsApplication10.VotersDbDataSet()
        Me.VotingusersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VotingusersTableAdapter = New WindowsApplication10.VotersDbDataSetTableAdapters.VotingusersTableAdapter()
        Me.VotingPanel = New System.Windows.Forms.Panel()
        Me.GoAdmin = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.CaptainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VotingProjectDataSet = New WindowsApplication10.VotingProjectDataSet()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PresidentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Votebtn = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.SenatorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.PresidentTableAdapter = New WindowsApplication10.VotingProjectDataSetTableAdapters.presidentTableAdapter()
        Me.CaptainTableAdapter = New WindowsApplication10.VotingProjectDataSetTableAdapters.captainTableAdapter()
        Me.SenatorTableAdapter = New WindowsApplication10.VotingProjectDataSetTableAdapters.SenatorTableAdapter()
        Me.VoterLoginPanel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VoterLoginBtn = New System.Windows.Forms.Button()
        Me.votpswdtxbx = New System.Windows.Forms.TextBox()
        Me.votusrnmetxtbx = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.VotersDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VotingusersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VotingPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaptainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VotingProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresidentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SenatorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VoterLoginPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'VotersDbDataSet
        '
        Me.VotersDbDataSet.DataSetName = "VotersDbDataSet"
        Me.VotersDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VotingusersBindingSource
        '
        Me.VotingusersBindingSource.DataMember = "Votingusers"
        Me.VotingusersBindingSource.DataSource = Me.VotersDbDataSet
        '
        'VotingusersTableAdapter
        '
        Me.VotingusersTableAdapter.ClearBeforeFill = True
        '
        'VotingPanel
        '
        Me.VotingPanel.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.VotingPanel.Controls.Add(Me.GoAdmin)
        Me.VotingPanel.Controls.Add(Me.Panel2)
        Me.VotingPanel.Controls.Add(Me.Panel1)
        Me.VotingPanel.Controls.Add(Me.Votebtn)
        Me.VotingPanel.Controls.Add(Me.Panel3)
        Me.VotingPanel.Location = New System.Drawing.Point(0, 1)
        Me.VotingPanel.Name = "VotingPanel"
        Me.VotingPanel.Size = New System.Drawing.Size(833, 409)
        Me.VotingPanel.TabIndex = 14
        '
        'GoAdmin
        '
        Me.GoAdmin.Location = New System.Drawing.Point(710, 331)
        Me.GoAdmin.Name = "GoAdmin"
        Me.GoAdmin.Size = New System.Drawing.Size(75, 23)
        Me.GoAdmin.TabIndex = 12
        Me.GoAdmin.Text = "Go to results"
        Me.GoAdmin.UseVisualStyleBackColor = True
        Me.GoAdmin.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.ComboBox2)
        Me.Panel2.Location = New System.Drawing.Point(331, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 231)
        Me.Panel2.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(26, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "School Captain"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.WindowsApplication10.My.Resources.Resources.Reading_100px
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.CaptainBindingSource, "cappicture", True))
        Me.PictureBox3.Location = New System.Drawing.Point(20, 35)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(136, 133)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'CaptainBindingSource
        '
        Me.CaptainBindingSource.DataMember = "captain"
        Me.CaptainBindingSource.DataSource = Me.VotingProjectDataSet
        '
        'VotingProjectDataSet
        '
        Me.VotingProjectDataSet.DataSetName = "VotingProjectDataSet"
        Me.VotingProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.CaptainBindingSource
        Me.ComboBox2.DisplayMember = "capName"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(30, 187)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Location = New System.Drawing.Point(44, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 231)
        Me.Panel1.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(26, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Student President"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.WindowsApplication10.My.Resources.Resources.Reading_100px
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.PresidentBindingSource, "Picture", True))
        Me.PictureBox2.Location = New System.Drawing.Point(20, 35)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(136, 133)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PresidentBindingSource
        '
        Me.PresidentBindingSource.DataMember = "president"
        Me.PresidentBindingSource.DataSource = Me.VotingProjectDataSet
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.PresidentBindingSource
        Me.ComboBox1.DisplayMember = "presidentName"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(35, 187)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'Votebtn
        '
        Me.Votebtn.BackColor = System.Drawing.Color.LimeGreen
        Me.Votebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Votebtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Votebtn.Location = New System.Drawing.Point(341, 303)
        Me.Votebtn.Name = "Votebtn"
        Me.Votebtn.Size = New System.Drawing.Size(141, 34)
        Me.Votebtn.TabIndex = 8
        Me.Votebtn.Text = "Vote Now"
        Me.Votebtn.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.PictureBox4)
        Me.Panel3.Controls.Add(Me.ComboBox3)
        Me.Panel3.Location = New System.Drawing.Point(588, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 231)
        Me.Panel3.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(26, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Senator Leader"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.WindowsApplication10.My.Resources.Resources.Reading_100px
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.SenatorBindingSource, "senPic", True))
        Me.PictureBox4.Location = New System.Drawing.Point(20, 35)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(136, 133)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'SenatorBindingSource
        '
        Me.SenatorBindingSource.DataMember = "Senator"
        Me.SenatorBindingSource.DataSource = Me.VotingProjectDataSet
        '
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.SenatorBindingSource
        Me.ComboBox3.DisplayMember = "senName"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(35, 187)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 2
        '
        'PresidentTableAdapter
        '
        Me.PresidentTableAdapter.ClearBeforeFill = True
        '
        'CaptainTableAdapter
        '
        Me.CaptainTableAdapter.ClearBeforeFill = True
        '
        'SenatorTableAdapter
        '
        Me.SenatorTableAdapter.ClearBeforeFill = True
        '
        'VoterLoginPanel
        '
        Me.VoterLoginPanel.Controls.Add(Me.Label3)
        Me.VoterLoginPanel.Controls.Add(Me.Label2)
        Me.VoterLoginPanel.Controls.Add(Me.VoterLoginBtn)
        Me.VoterLoginPanel.Controls.Add(Me.votpswdtxbx)
        Me.VoterLoginPanel.Controls.Add(Me.votusrnmetxtbx)
        Me.VoterLoginPanel.Controls.Add(Me.Label7)
        Me.VoterLoginPanel.Location = New System.Drawing.Point(0, 1)
        Me.VoterLoginPanel.Name = "VoterLoginPanel"
        Me.VoterLoginPanel.Size = New System.Drawing.Size(788, 409)
        Me.VoterLoginPanel.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Label3.Location = New System.Drawing.Point(80, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(73, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "ID /Passport"
        '
        'VoterLoginBtn
        '
        Me.VoterLoginBtn.BackColor = System.Drawing.Color.LimeGreen
        Me.VoterLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.VoterLoginBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.VoterLoginBtn.Location = New System.Drawing.Point(259, 197)
        Me.VoterLoginBtn.Name = "VoterLoginBtn"
        Me.VoterLoginBtn.Size = New System.Drawing.Size(198, 38)
        Me.VoterLoginBtn.TabIndex = 16
        Me.VoterLoginBtn.Text = "Log In"
        Me.VoterLoginBtn.UseVisualStyleBackColor = False
        '
        'votpswdtxbx
        '
        Me.votpswdtxbx.Location = New System.Drawing.Point(259, 151)
        Me.votpswdtxbx.Name = "votpswdtxbx"
        Me.votpswdtxbx.Size = New System.Drawing.Size(198, 20)
        Me.votpswdtxbx.TabIndex = 15
        Me.votpswdtxbx.UseSystemPasswordChar = True
        '
        'votusrnmetxtbx
        '
        Me.votusrnmetxtbx.Location = New System.Drawing.Point(259, 110)
        Me.votusrnmetxtbx.Name = "votusrnmetxtbx"
        Me.votusrnmetxtbx.Size = New System.Drawing.Size(198, 20)
        Me.votusrnmetxtbx.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(275, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Voter Login Area"
        '
        'voterlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(835, 411)
        Me.Controls.Add(Me.VotingPanel)
        Me.Controls.Add(Me.VoterLoginPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "voterlogin"
        Me.Text = "voterlogin"
        CType(Me.VotersDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VotingusersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VotingPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaptainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VotingProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresidentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SenatorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VoterLoginPanel.ResumeLayout(False)
        Me.VoterLoginPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VotersDbDataSet As WindowsApplication10.VotersDbDataSet
    Friend WithEvents VotingusersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VotingusersTableAdapter As WindowsApplication10.VotersDbDataSetTableAdapters.VotingusersTableAdapter
    Friend WithEvents VotingPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Votebtn As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents VotingProjectDataSet As WindowsApplication10.VotingProjectDataSet
    Friend WithEvents PresidentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresidentTableAdapter As WindowsApplication10.VotingProjectDataSetTableAdapters.presidentTableAdapter
    Friend WithEvents CaptainBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CaptainTableAdapter As WindowsApplication10.VotingProjectDataSetTableAdapters.captainTableAdapter
    Friend WithEvents SenatorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SenatorTableAdapter As WindowsApplication10.VotingProjectDataSetTableAdapters.SenatorTableAdapter
    Friend WithEvents VoterLoginPanel As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents VoterLoginBtn As System.Windows.Forms.Button
    Friend WithEvents votpswdtxbx As System.Windows.Forms.TextBox
    Friend WithEvents votusrnmetxtbx As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GoAdmin As System.Windows.Forms.Button
End Class

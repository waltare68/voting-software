<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class votingArea
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
        Me.Votebtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PresidentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VotingProjectDataSet = New WindowsApplication10.VotingProjectDataSet()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CaptainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.SenatorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.PresidentTableAdapter = New WindowsApplication10.VotingProjectDataSetTableAdapters.presidentTableAdapter()
        Me.CaptainTableAdapter = New WindowsApplication10.VotingProjectDataSetTableAdapters.captainTableAdapter()
        Me.SenatorTableAdapter = New WindowsApplication10.VotingProjectDataSetTableAdapters.SenatorTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresidentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VotingProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaptainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SenatorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Votebtn
        '
        Me.Votebtn.BackColor = System.Drawing.Color.LimeGreen
        Me.Votebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Votebtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Votebtn.Location = New System.Drawing.Point(386, 331)
        Me.Votebtn.Name = "Votebtn"
        Me.Votebtn.Size = New System.Drawing.Size(141, 34)
        Me.Votebtn.TabIndex = 3
        Me.Votebtn.Text = "Vote Now"
        Me.Votebtn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Location = New System.Drawing.Point(89, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 231)
        Me.Panel1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(26, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Student President"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication10.My.Resources.Resources.Reading_100px
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.PresidentBindingSource, "Picture", True))
        Me.PictureBox1.Location = New System.Drawing.Point(20, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.ComboBox2)
        Me.Panel2.Location = New System.Drawing.Point(376, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 231)
        Me.Panel2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(26, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "School Captain"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.WindowsApplication10.My.Resources.Resources.Reading_100px
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.CaptainBindingSource, "cappicture", True))
        Me.PictureBox2.Location = New System.Drawing.Point(20, 35)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(136, 133)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'CaptainBindingSource
        '
        Me.CaptainBindingSource.DataMember = "captain"
        Me.CaptainBindingSource.DataSource = Me.VotingProjectDataSet
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
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.ComboBox3)
        Me.Panel3.Location = New System.Drawing.Point(633, 58)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 231)
        Me.Panel3.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(26, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Senator Leader"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.WindowsApplication10.My.Resources.Resources.Reading_100px
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.SenatorBindingSource, "senPic", True))
        Me.PictureBox3.Location = New System.Drawing.Point(20, 35)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(136, 133)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
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
        'votingArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(869, 408)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Votebtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "votingArea"
        Me.Text = "votingArea"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresidentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VotingProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaptainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SenatorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Votebtn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents VotingProjectDataSet As WindowsApplication10.VotingProjectDataSet
    Friend WithEvents PresidentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresidentTableAdapter As WindowsApplication10.VotingProjectDataSetTableAdapters.presidentTableAdapter
    Friend WithEvents CaptainBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CaptainTableAdapter As WindowsApplication10.VotingProjectDataSetTableAdapters.captainTableAdapter
    Friend WithEvents SenatorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SenatorTableAdapter As WindowsApplication10.VotingProjectDataSetTableAdapters.SenatorTableAdapter
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminLognArea
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Adminidtxtbx = New System.Windows.Forms.TextBox()
        Me.adminpswdtxtbx = New System.Windows.Forms.TextBox()
        Me.AdminLoginBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.VotingProjectDataSet = New WindowsApplication10.VotingProjectDataSet()
        Me.AdminUsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdminUsersTableAdapter = New WindowsApplication10.VotingProjectDataSetTableAdapters.adminUsersTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VotingProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminUsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(347, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Admin Login Area"
        '
        'Adminidtxtbx
        '
        Me.Adminidtxtbx.Location = New System.Drawing.Point(324, 180)
        Me.Adminidtxtbx.Name = "Adminidtxtbx"
        Me.Adminidtxtbx.Size = New System.Drawing.Size(198, 20)
        Me.Adminidtxtbx.TabIndex = 1
        '
        'adminpswdtxtbx
        '
        Me.adminpswdtxtbx.Location = New System.Drawing.Point(324, 221)
        Me.adminpswdtxtbx.Name = "adminpswdtxtbx"
        Me.adminpswdtxtbx.Size = New System.Drawing.Size(198, 20)
        Me.adminpswdtxtbx.TabIndex = 2
        Me.adminpswdtxtbx.UseSystemPasswordChar = True
        '
        'AdminLoginBtn
        '
        Me.AdminLoginBtn.BackColor = System.Drawing.Color.LimeGreen
        Me.AdminLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AdminLoginBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AdminLoginBtn.Location = New System.Drawing.Point(324, 267)
        Me.AdminLoginBtn.Name = "AdminLoginBtn"
        Me.AdminLoginBtn.Size = New System.Drawing.Size(198, 38)
        Me.AdminLoginBtn.TabIndex = 3
        Me.AdminLoginBtn.Text = "Log In"
        Me.AdminLoginBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(138, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ID /Passport"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Label3.Location = New System.Drawing.Point(164, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication10.My.Resources.Resources.Work_50px
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(402, 332)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 35)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'VotingProjectDataSet
        '
        Me.VotingProjectDataSet.DataSetName = "VotingProjectDataSet"
        Me.VotingProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdminUsersBindingSource
        '
        Me.AdminUsersBindingSource.DataMember = "adminUsers"
        Me.AdminUsersBindingSource.DataSource = Me.VotingProjectDataSet
        '
        'AdminUsersTableAdapter
        '
        Me.AdminUsersTableAdapter.ClearBeforeFill = True
        '
        'adminLognArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(901, 470)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AdminLoginBtn)
        Me.Controls.Add(Me.adminpswdtxtbx)
        Me.Controls.Add(Me.Adminidtxtbx)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adminLognArea"
        Me.Text = "adminLognArea"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VotingProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminUsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Adminidtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents adminpswdtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents AdminLoginBtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents VotingProjectDataSet As WindowsApplication10.VotingProjectDataSet
    Friend WithEvents AdminUsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AdminUsersTableAdapter As WindowsApplication10.VotingProjectDataSetTableAdapters.adminUsersTableAdapter
End Class

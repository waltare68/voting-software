Imports System.Data.OleDb
Public Class adminArea
    Dim imgName As String
    Dim message As String = "Sorry ,This field cannot be deleted"

    Private Sub adminArea_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dialog As DialogResult

        dialog = MessageBox.Show("would you like to go to Vote", "VotingProject", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = Windows.Forms.DialogResult.Yes Then
            voterlogin.Show()
        Else
            Me.Close()
            End
        End If
    End Sub

    Private Sub adminArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VotingProjectDataSet.Senator' table. You can move, or remove it, as needed.
        Me.SenatorTableAdapter.Fill(Me.VotingProjectDataSet.Senator)
        'TODO: This line of code loads data into the 'VotingProjectDataSet.captain' table. You can move, or remove it, as needed.
        Me.CaptainTableAdapter.Fill(Me.VotingProjectDataSet.captain)
        'TODO: This line of code loads data into the 'VotingProjectDataSet.president' table. You can move, or remove it, as needed.
        Me.PresidentTableAdapter.Fill(Me.VotingProjectDataSet.president)

    End Sub

    Private Sub AddnewBtn_Click(sender As Object, e As EventArgs)
        PresidentBindingSource.AddNew()
    End Sub

    Private Sub prevbtn_Click(sender As Object, e As EventArgs)
        PresidentBindingSource.MovePrevious()
    End Sub

    Private Sub nxtbtn_Click(sender As Object, e As EventArgs)
        PresidentBindingSource.MoveNext()
    End Sub

    Private Sub deltbtn_Click(sender As Object, e As EventArgs)
        MsgBox(message)
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs)
        PresidentBindingSource.EndEdit()
        PresidentTableAdapter.Update(VotingProjectDataSet)
        MessageBox.Show("saved", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub LoadpicBtn_Click(sender As Object, e As EventArgs)
        Try
            ImgOpnFileDialog.Filter = "Image File(*.jpg;*.bmp;*.gif)|*jpg;*.bmp;*.gif"
            If ImgOpnFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                imgName = ImgOpnFileDialog.FileName
                Dim newing As New Bitmap(imgName)

                CandPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                CandPictureBox.Image = DirectCast(newing, Image)

            End If
            ImgOpnFileDialog = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub


    Private Sub addnewcapbtn_Click(sender As Object, e As EventArgs)
        CaptainBindingSource.AddNew()
    End Sub

    Private Sub prevbtncaptn_Click(sender As Object, e As EventArgs)
        CaptainBindingSource.MovePrevious()
    End Sub

    Private Sub nxtbtncptn_Click(sender As Object, e As EventArgs)
        CaptainBindingSource.MoveNext()
    End Sub

    Private Sub delcptnbtn_Click(sender As Object, e As EventArgs)
        MessageBox.Show(message, "Voting project Developers", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub loadcappicbtn_Click(sender As Object, e As EventArgs)
        Try
            ImgOpnFileDialog.Filter = "Image File(*.jpg;*.bmp;*.gif)|*jpg;*.bmp;*.gif"
            If ImgOpnFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                imgName = ImgOpnFileDialog.FileName
                Dim newing As New Bitmap(imgName)

                cappicbx.SizeMode = PictureBoxSizeMode.StretchImage
                cappicbx.Image = DirectCast(newing, Image)

            End If
            ImgOpnFileDialog = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub savecapbtn_Click(sender As Object, e As EventArgs)
        CaptainBindingSource.EndEdit()
        CaptainTableAdapter.Update(VotingProjectDataSet)
        MessageBox.Show("saved", "Voting project", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Application.Restart()

    End Sub

    Private Sub AddnewBtn_Click_1(sender As Object, e As EventArgs) Handles AddnewBtn.Click
        PresidentBindingSource.AddNew()
    End Sub

    Private Sub prevbtn_Click_1(sender As Object, e As EventArgs) Handles prevbtn.Click
        PresidentBindingSource.MovePrevious()
    End Sub

    Private Sub deltbtn_Click_1(sender As Object, e As EventArgs) Handles deltbtn.Click
        MsgBox("not eligible")
    End Sub

    Private Sub nxtbtn_Click_1(sender As Object, e As EventArgs) Handles nxtbtn.Click
        PresidentBindingSource.MoveNext()
    End Sub

    Private Sub addnewSenbtn_Click(sender As Object, e As EventArgs) Handles addnewSenbtn.Click
        SenatorBindingSource.AddNew()
    End Sub

    Private Sub prevsenbtn_Click(sender As Object, e As EventArgs) Handles prevsenbtn.Click
        SenatorBindingSource.MovePrevious()
    End Sub

    Private Sub nxtSenbtn_Click(sender As Object, e As EventArgs) Handles nxtSenbtn.Click
        SenatorBindingSource.MoveNext()
    End Sub

    Private Sub delSenBtn_Click(sender As Object, e As EventArgs) Handles delSenBtn.Click
        MessageBox.Show(message, "VotingProject dev", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub loadsenPicbtn_Click(sender As Object, e As EventArgs) Handles loadsenPicbtn.Click
        Try
            ImgOpnFileDialog.Filter = "Image File(*.jpg;*.bmp;*.gif)|*jpg;*.bmp;*.gif"
            If ImgOpnFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                imgName = ImgOpnFileDialog.FileName
                Dim newing As New Bitmap(imgName)

                senpicbox.SizeMode = PictureBoxSizeMode.StretchImage
                senpicbox.Image = DirectCast(newing, Image)

            End If
            ImgOpnFileDialog = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub savesenbtn_Click(sender As Object, e As EventArgs) Handles savesenbtn.Click
        SenatorBindingSource.EndEdit()
        SenatorTableAdapter.Update(VotingProjectDataSet)
        MessageBox.Show("saved", "VotingProjectDev's", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub EditPresBtn_Click(sender As Object, e As EventArgs) Handles EditPresBtn.Click
        PaneleditPresident.Visible = True
        PaneleditCaptain.Visible = False
        PaneleditSenator.Visible = False
        PaneleditPresident.Height = 1400
        PanelResults.Visible = False

    End Sub

    Private Sub EditCapBtn_Click(sender As Object, e As EventArgs) Handles EditCapBtn.Click
        PaneleditPresident.Visible = False
        PaneleditCaptain.Visible = True
        PaneleditSenator.Visible = False
        PanelResults.Visible = False
        PaneleditCaptain.Height = 1400
        ' PaneleditCaptain.ForeColor


    End Sub

    Private Sub EditSenbtn_Click(sender As Object, e As EventArgs) Handles EditSenbtn.Click
        PaneleditPresident.Visible = False
        PaneleditCaptain.Visible = False
        PaneleditSenator.Visible = True
        PanelResults.Visible = False
        PaneleditSenator.Height = 1400
    End Sub

    Private Sub resltsbtn_Click(sender As Object, e As EventArgs) Handles resltsbtn.Click
        PaneleditPresident.Visible = False
        PaneleditCaptain.Visible = False
        PaneleditSenator.Visible = False
        PanelResults.Visible = True
        PanelResults.Height = 1400
    End Sub

    Private Sub LoadpicBtn_Click_1(sender As Object, e As EventArgs) Handles LoadpicBtn.Click
        Try
            Dim imgOpenFileDialog As New OpenFileDialog
            ImgOpnFileDialog.Filter = "Image File(*.jpg;*.bmp;*.gif)|*jpg;*.bmp;*.gif"
            If ImgOpnFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                imgName = ImgOpnFileDialog.FileName
                Dim newing As New Bitmap(imgName)

                CandPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                CandPictureBox.Image = DirectCast(newing, Image)

            End If
            ImgOpnFileDialog = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub saveBtn_Click_1(sender As Object, e As EventArgs) Handles saveBtn.Click
        PresidentBindingSource.EndEdit()
        PresidentTableAdapter.Update(VotingProjectDataSet)
        MessageBox.Show("saved", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub addnewcapbtn_Click_1(sender As Object, e As EventArgs) Handles addnewcapbtn.Click
        CaptainBindingSource.AddNew()
    End Sub

    Private Sub prevbtncaptn_Click_1(sender As Object, e As EventArgs) Handles prevbtncaptn.Click
        CaptainBindingSource.MovePrevious()
    End Sub

    Private Sub nxtbtncptn_Click_1(sender As Object, e As EventArgs) Handles nxtbtncptn.Click
        CaptainBindingSource.MoveNext()
    End Sub

    Private Sub loadcappicbtn_Click_1(sender As Object, e As EventArgs) Handles loadcappicbtn.Click
        Try
            ImgOpnFileDialog.Filter = "Image File(*.jpg;*.bmp;*.gif)|*jpg;*.bmp;*.gif"
            If ImgOpnFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                imgName = ImgOpnFileDialog.FileName
                Dim newing As New Bitmap(imgName)

                cappicbx.SizeMode = PictureBoxSizeMode.StretchImage
                cappicbx.Image = DirectCast(newing, Image)

            End If
            ImgOpnFileDialog = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub savecapbtn_Click_1(sender As Object, e As EventArgs) Handles savecapbtn.Click
        CaptainBindingSource.EndEdit()
        CaptainTableAdapter.Update(VotingProjectDataSet)
        MessageBox.Show("saved", "Voting project", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Application.Restart()
    End Sub

    Private Sub Infobtn_Click(sender As Object, e As EventArgs) Handles Infobtn.Click

    End Sub

    Private Sub LoadResltsBtn_Click(sender As Object, e As EventArgs) Handles LoadResltsBtn.Click
        Dim data As Integer

        Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=F:\WALTER\Libya\VotingProject\VotingProject.accdb")

        Dim sqlstring As String = "select votes from results where id=1"
        Dim sql2 As String = "select votes from results where id=2"
        Dim sql3 As String = "select votes from results where id=3"
        Dim sql4 As String = "select votes from results where id=4"
        Dim sql5 As String = "select votes from results where id=5"
        Dim sql6 As String = "select votes from results where id=6"
        Dim sql7 As String = "select votes from results where id=7"
        Dim sql8 As String = "select votes from results where id=8"
        Dim sql9 As String = "select votes from results where id=9"

        Dim cmd As New OleDb.OleDbCommand(sqlstring, con)
        Dim cmd1 As New OleDb.OleDbCommand(sql2, con)
        Dim cmd2 As New OleDb.OleDbCommand(sql3, con)
        Dim cmd3 As New OleDb.OleDbCommand(sql4, con)
        Dim cmd4 As New OleDb.OleDbCommand(sql5, con)
        Dim cmd5 As New OleDb.OleDbCommand(sql6, con)
        Dim cmd6 As New OleDb.OleDbCommand(sql7, con)
        Dim cmd7 As New OleDb.OleDbCommand(sql8, con)
        Dim cmd8 As New OleDb.OleDbCommand(sql9, con)

        Dim myReader As OleDbDataReader

        con.Open()
        'first reading of column value -i strugggled to use a loop
        myReader = cmd.ExecuteReader
        myReader.Read()
        data = myReader.Item(0)
        myReader.Close()
        'second reading
        myReader = cmd1.ExecuteReader
        myReader.Read()
        Dim data2 = myReader.Item(0)
        myReader.Close()
        '3rd reading
        myReader = cmd2.ExecuteReader
        myReader.Read()
        Dim data3 = myReader.Item(0)
        myReader.Close()

        '4th reading
        myReader = cmd3.ExecuteReader
        myReader.Read()
        Dim data4 = myReader.Item(0)
        myReader.Close()
        '5th reading
        myReader = cmd4.ExecuteReader
        myReader.Read()
        Dim data5 = myReader.Item(0)
        myReader.Close()
        '6th reading
        myReader = cmd5.ExecuteReader
        myReader.Read()
        Dim data6 = myReader.Item(0)
        myReader.Close()
        '7th reading
        myReader = cmd6.ExecuteReader
        myReader.Read()
        Dim data7 = myReader.Item(0)
        myReader.Close()

        '8th reading
        myReader = cmd7.ExecuteReader
        myReader.Read()
        Dim data8 = myReader.Item(0)
        myReader.Close()

        '9th reading
        myReader = cmd8.ExecuteReader
        myReader.Read()
        Dim data9 = myReader.Item(0)
        myReader.Close()


        pres1prgrssbr.Value = data
        sammirvoteslabel.Text = data & "%"

        pres2prgrssbr.Value = data2
        aubavoteslabel.Text = data2 & "%"
        pres3prgrssbr.Value = data3
        leovoteslabel.Text = data3 & "%"

        cap1prgrsbar.Value = data4
        theovoteslabel.Text = data4 & "%"
        cap2prgrsbar.Value = data5
        mariamvoteslabel.Text = data5 & "%"
        cap3prgrsbar.Value = data6
        joyvoteslabel.Text = data6 & "%"

        sen1prgsBr.Value = data7
        adenvoteslabel.Text = data7 & "%"
        sen2prgsBr.Value = data8
        katvoteslabel.Text = data8 & "%"
        sen3prgsBr.Value = data9
        fatmavoteslabel.Text = data9 & "%"

        con.Close()

        '' Do While myReader.Read
        '      Dim Data As String = myReader.Item(1) 'Select second column        
        '       DisplayListBox.Items.Add(Data)
        ' Loop
    End Sub
End Class
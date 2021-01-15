Imports System.Data.OleDb
Public Class voterlogin
    Dim voterusername As String

    Private Sub VoterLoginBtn_Click(sender As Object, e As EventArgs)
        'votingArea.Show()
        'Me.Hide()
        Dim voterusername As String

        Dim loginmessageunsuccessful = "Wrong user credentials"

        Dim voterpswd As String

        voterusername = votusrnmetxtbx.Text
        voterpswd = votpswdtxbx.Text
        Dim loginmessage As String = "Welcome " & voterusername & " Vote wisely"
        If VotingusersTableAdapter.ScalarQueryVoterLogin(voterusername, voterpswd) Then
            votingArea.Show()
            Me.Hide()
            MessageBox.Show(loginmessage, "VotingProjectJkuat version 1.0.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
            votusrnmetxtbx.Clear()
            votpswdtxbx.Clear()
        Else
            MessageBox.Show(loginmessageunsuccessful, "VotingProjectJkuat version 1.0.0", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub voterlogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dialog As DialogResult

        dialog = MessageBox.Show("would you like to go to admininstrator panel", "VotingProject", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = Windows.Forms.DialogResult.Yes Then
            adminLognArea.Show()
        Else
            Me.Close()
            End
        End If
    End Sub

    Private Sub voterlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VotingPanel.Hide()
        'TODO: This line of code loads data into the 'VotingProjectDataSet.Senator' table. You can move, or remove it, as needed.
        Me.SenatorTableAdapter.Fill(Me.VotingProjectDataSet.Senator)
        'TODO: This line of code loads data into the 'VotingProjectDataSet.captain' table. You can move, or remove it, as needed.
        Me.CaptainTableAdapter.Fill(Me.VotingProjectDataSet.captain)
        'TODO: This line of code loads data into the 'VotingProjectDataSet.president' table. You can move, or remove it, as needed.
        Me.PresidentTableAdapter.Fill(Me.VotingProjectDataSet.president)
        'TODO: This line of code loads data into the 'VotersDbDataSet.Votingusers' table. You can move, or remove it, as needed.
        Me.VotingusersTableAdapter.Fill(Me.VotersDbDataSet.Votingusers)

    End Sub

    Private Sub VoterLoginBtn_Click_1(sender As Object, e As EventArgs) Handles VoterLoginBtn.Click
        'Dim voterusername As String

        Dim loginmessageunsuccessful = "ALREADY VOTED OR WRONG USERNAME/PASSWORD THANK YOU!"

        Dim voterpswd As String

        voterusername = votusrnmetxtbx.Text
        voterpswd = votpswdtxbx.Text
        Dim loginmessage As String = "Welcome " & voterusername & " Vote wisely"
        If VotingusersTableAdapter.ScalarQueryVoterLogin(voterusername, voterpswd) Then
            VotingPanel.Show()
            'Me.Hide()
            VoterLoginPanel.Hide()
            MessageBox.Show(loginmessage, "VotingProjectJkuat version 1.0.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
            votusrnmetxtbx.Clear()
            votpswdtxbx.Clear()
        Else
            MessageBox.Show(loginmessageunsuccessful, "VotingProjectJkuat version 1.0.0", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub Votebtn_Click(sender As Object, e As EventArgs) Handles Votebtn.Click
        'conn string
        'Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mnjala\Desktop\projects\VotingProject\VotingProject.accdb
        Dim cast1, cast2, cast3 As String
        cast1 = ComboBox1.Text.ToString
        cast2 = ComboBox2.Text.ToString
        cast3 = ComboBox3.Text.ToString
        Dim msg = "Confirm your Selections" & vbNewLine & cast1 & vbNewLine & cast2 & vbNewLine & cast3 + "."
        'open connection
        Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\WALTER\Libya\VotingProject\VotingProject.accdb")
        con.Open()
        'begin my counting
        Dim count = con.BeginTransaction
        'check if their is a key on the voter reg details
        Dim result As DialogResult

        result = MessageBox.Show(msg, "voting project version 0.1", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = Windows.Forms.DialogResult.Yes Then
            'e.Cancel = False
            Dim CMD As New OleDb.OleDbCommand("update Results set Votes=Votes+1 where candidateName='" & cast1 & "'", con, count)
            'execute the command
            CMD.ExecuteNonQuery()

            Dim cmd2 As New OleDb.OleDbCommand("update Results set Votes=Votes+1 where candidateName='" & cast2 & "'", con, count)
            'execute the command
            cmd2.ExecuteNonQuery()
            'update results set votes=votes+1 where name='"&combobox1.text"',con,count
            Dim cmd3 As New OleDb.OleDbCommand("update Results set Votes=Votes+1 where candidateName='" & cast3 & "'", con, count)
            'execute the command
            cmd3.ExecuteNonQuery()
            'save the count
            count.Commit()
            MessageBox.Show("Thanks for voting", "VotingProjectJKuat", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'close connection
            VoterLoginPanel.Show()
            VotingPanel.Hide()

        Else
            'e.Cancel = True

            MsgBox("Choose your candidates")

        End If


        'define commands'Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\WALTER\Libya\VotingProject\VotingProject.accdb


        con.Close()
        'DELETING USER PASSWORD NOT TO LOGIN AGAIN
        Dim conDelete As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\WALTER\Libya\VotingProject\VotersDb.accdb")
        conDelete.Open()

        Dim CMDDelete As New OleDb.OleDbCommand("Delete From Votingusers where votUsername='" & voterusername & "'", conDelete)
        'execute the command
        CMDDelete.ExecuteNonQuery()
        conDelete.Close()
    End Sub

    Private Sub GoAdmin_Click(sender As Object, e As EventArgs) Handles GoAdmin.Click
        adminLognArea.Show()
    End Sub

   
    Private Sub VotingPanel_Paint(sender As Object, e As PaintEventArgs) Handles VotingPanel.Paint

    End Sub
End Class
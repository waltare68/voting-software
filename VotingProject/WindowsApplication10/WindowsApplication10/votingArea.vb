Public Class votingArea


    Private Sub votingArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VotingProjectDataSet.Senator' table. You can move, or remove it, as needed.
        Me.SenatorTableAdapter.Fill(Me.VotingProjectDataSet.Senator)
        'TODO: This line of code loads data into the 'VotingProjectDataSet.captain' table. You can move, or remove it, as needed.
        Me.CaptainTableAdapter.Fill(Me.VotingProjectDataSet.captain)
        'TODO: This line of code loads data into the 'VotingProjectDataSet.president' table. You can move, or remove it, as needed.
        Me.PresidentTableAdapter.Fill(Me.VotingProjectDataSet.president)

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
        Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mnjala\Desktop\projects\VotingProject\VotingProject.accdb")
        con.Open()
        'begin my counting
        Dim count = con.BeginTransaction
        'check if their is a key on the voter reg details



        'define commands

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
        'close connection
        con.Close()
        MessageBox.Show("Thanks for voting", "VotingProjectJKuat", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub
End Class
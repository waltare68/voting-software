Public Class adminLognArea


    Private Sub AdminLoginBtn_Click(sender As Object, e As EventArgs) Handles AdminLoginBtn.Click
        'adminArea.Show()
        ' Me.Hide()
        Dim id As String
        Dim pswd As String

        id = Adminidtxtbx.Text
        pswd = adminpswdtxtbx.Text
        Dim loginmessage As String = "Welcome " & id & " Great To see You today"
        Dim loginmessageunsuccessful = "Wrong user credentials"
        If AdminUsersTableAdapter.ScalarQueryLogin(id, pswd) Then
            MessageBox.Show(loginmessage, "VotingProjectJkuat version 1.0.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Adminidtxtbx.Clear()
            adminpswdtxtbx.Clear()
            adminArea.Show()
            Me.Hide()
        Else
            MessageBox.Show(loginmessageunsuccessful, "VotingProjectJkuat version 1.0.0", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub adminLognArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VotingProjectDataSet.adminUsers' table. You can move, or remove it, as needed.
        Me.AdminUsersTableAdapter.Fill(Me.VotingProjectDataSet.adminUsers)

    End Sub
End Class
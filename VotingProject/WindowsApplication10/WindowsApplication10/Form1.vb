Public Class MainFrm

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        adminLognArea.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        voterlogin.Show()
        Me.Hide()
    End Sub

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

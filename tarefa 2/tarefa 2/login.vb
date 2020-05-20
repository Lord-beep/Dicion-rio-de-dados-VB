Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If user.Text = "admin" And pass.Text = "admin" Then
            Form1.Show()
            Me.Hide()
        Else
            user.Clear()
            pass.Clear()
        End If
    End Sub
End Class
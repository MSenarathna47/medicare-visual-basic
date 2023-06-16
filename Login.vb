Public Class Login
    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles PassTxt.TextChanged

    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If UsernameTxt.Text = "" Or PassTxt.Text = "" Then
            MsgBox("Enter UserName And Password")
        ElseIf UsernameTxt.Text = "admin" And PassTxt.Text = "123" Then

            Dim home = New Home
            home.Show()
            Me.Hide()

        Else
            MsgBox("Wrong UserName Or Password")
            UsernameTxt.Text = ""
            PassTxt.Text = ""
        End If
    End Sub
End Class
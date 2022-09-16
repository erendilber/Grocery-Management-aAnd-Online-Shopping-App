Public Class Login
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim Obj = New Billing
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UnameTb.Text = "" Or PasswordTb.Text = "" Then
            MsgBox("Kullanıcı adı ve şifre giriniz")
        ElseIf UnameTb.Text = "Admin" And PasswordTb.Text = "1234" Then
            Dim Obj = New Items
            Obj.Show()
            Me.Hide()
        Else
            MsgBox("Kullanıcı adı ve ya şifre hatalı!")
            UnameTb.Text = ""
            PasswordTb.Text = ""
        End If

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
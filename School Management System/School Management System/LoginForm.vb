Public Class LoginForm


    Private Sub btnSignUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignUp.Click

        Register.Show()
        Me.Hide()

    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnSignUp.Cursor = Cursors.Hand 'make the cursor a hand when it hovers
        btnLogin.Cursor = Cursors.Hand
        picOpenEye.Cursor = Cursors.Hand
        picClosedEye.Cursor = Cursors.Hand



        ToolTip1.SetToolTip(btnMinimize, "Minimize")
        ToolTip1.SetToolTip(btnClose, "Close")
        btnMinimize.Cursor = Cursors.Hand
        btnClose.Cursor = Cursors.Hand



    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        MainMenu.Show()
        Me.Close()

    End Sub


    Private Sub picClosedEye_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picClosedEye.Click
        'closed
        picClosedEye.Visible = False
        picOpenEye.Visible = True
        txtPassw.PasswordChar = ControlChars.NullChar ' Show password

    End Sub

    Private Sub picOpenEye_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picOpenEye.Click
        'open
        picOpenEye.Visible = False
        picClosedEye.Visible = True
        txtPassw.PasswordChar = "*"c ' Hide password

    End Sub
End Class

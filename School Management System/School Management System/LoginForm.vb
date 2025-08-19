Public Class LoginForm

    Private openEyeImage As Image
    Private crossedEyeImage As Image

    Private Sub btnSignUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignUp.Click

        Register.Show()
        Me.Hide()

    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnSignUp.Cursor = Cursors.Hand 'make the cursor a hand when it hovers
        btnLogin.Cursor = Cursors.Hand
        openEyeImage = Image.FromFile("images\visible.png")
        crossedEyeImage = Image.FromFile("images\hidden.png")
        PictureBox4.Image = crossedEyeImage ' Set initial image
        'tootips whn you hover on the close and minimize options
        ToolTip1.SetToolTip(btnMinimize, "Minimize")
        ToolTip1.SetToolTip(btnClose, "Close")



    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        
        If txtPassw.PasswordChar = "*"c Then
            txtPassw.PasswordChar = ControlChars.NullChar ' Show password
            PictureBox4.Image = openEyeImage ' Change to open eye image
        Else
            txtPassw.PasswordChar = "*"c ' Hide password
            PictureBox4.Image = crossedEyeImage ' Change to crossed eye image
        End If


    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub
End Class

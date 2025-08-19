Public Class Register

    Private Sub Register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnRegister.Cursor = Cursors.Hand
        btnLogIn.Cursor = Cursors.Hand

        ToolTip1.SetToolTip(btnMinimize, "Minimize")
        ToolTip1.SetToolTip(btnClose, "Close")



    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
End Class
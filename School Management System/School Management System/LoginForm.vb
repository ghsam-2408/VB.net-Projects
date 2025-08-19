Public Class LoginForm



    Private Sub btnSignUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignUp.Click

        Register.Show()
    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnSignUp.Cursor = Cursors.Hand
        btnLogin.Cursor = Cursors.Hand

    End Sub
End Class

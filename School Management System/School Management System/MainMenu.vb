Public Class MainMenu

    Private Sub MainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnDashboard.Cursor = Cursors.Hand 'make the cursor a hand when it hovers
        btnFees.Cursor = Cursors.Hand
        btnStudents.Cursor = Cursors.Hand
        btnTeachers.Cursor = Cursors.Hand
        btnLogout.Cursor = Cursors.Hand
        btnMinimize.Cursor = Cursors.Hand
        btnDepartm.Cursor = Cursors.Hand
        btnFullscreen.Cursor = Cursors.Hand
        btnClose.Cursor = Cursors.Hand
        btnClose.Cursor = Cursors.Hand
        btnClose.Cursor = Cursors.Hand




    End Sub

    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Dim result As MsgBoxResult = MsgBox("Are you sure to Logout", MsgBoxStyle.YesNo, "Logout")
        If result = MsgBoxResult.Yes Then
            MsgBox("Logged out Successfully", MsgBoxStyle.Information)
            ' Add your logout logic here
            LoginForm.Show()
            Me.Close()

        End If

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudentsb.Click
        Students.Show()

    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFullscreen.Click
        If Me.FormBorderStyle = FormBorderStyle.Sizable Then
            Me.FormBorderStyle = FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.FormBorderStyle = FormBorderStyle.Sizable
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class
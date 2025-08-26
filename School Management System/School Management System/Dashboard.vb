Public Class Dashboard

    
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFullscreen.Click
        If Me.FormBorderStyle = FormBorderStyle.Sizable Then
            Me.FormBorderStyle = FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.FormBorderStyle = FormBorderStyle.Sizable
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        MainMenu.Show()
        Me.Close()

    End Sub

    Private Sub Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(btnHome, "Main Menu")
        btnDashboard.Cursor = Cursors.Hand
        btnFullscreen.Cursor = Cursors.Hand
        btnHome.Cursor = Cursors.Hand
        panelAnalytics.Cursor = Cursors.Hand
        panelDepartments.Cursor = Cursors.Hand
        panelFees.Cursor = Cursors.Hand
        panelReports.Cursor = Cursors.Hand
        panelStaff.Cursor = Cursors.Hand
        panelStudents.Cursor = Cursors.Hand
        btnLoggout.Cursor = Cursors.Hand

        btnMinimize.Cursor = Cursors.Hand
        btnHome.Cursor = Cursors.Hand
        btnClose.Cursor = Cursors.Hand
    End Sub

    Private Sub btnLoggout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoggout.Click
        Dim result As MsgBoxResult = MsgBox("Are you sure to Logout", MsgBoxStyle.YesNo, "Logout")
        If result = MsgBoxResult.Yes Then
            MsgBox("Logged out Successfully", MsgBoxStyle.Information)
            ' Add your logout logic here
            LoginForm.Show()
            Me.Close()

        End If

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        MainMenu.Show()
        Me.Close()

    End Sub
End Class
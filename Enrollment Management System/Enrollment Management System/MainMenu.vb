Public Class MainMenu
    Private Sub btnEnroll_Click(sender As Object, e As EventArgs) Handles btnEnroll.Click
        Me.Close()
        StudentsEnrollment.Show()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.Close()
        Dashboard.Show()
    End Sub

    Private Sub btnFeePayment_Click(sender As Object, e As EventArgs) Handles btnFeePayment.Click
        Me.Close()
        FeesPayments.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        MsgBox("You have been logged out.", MsgBoxStyle.Information, "Logged Out")
        Me.Close()
        LoginForm.Show()
    End Sub
End Class
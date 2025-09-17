Public Class SplashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        Label2.Text = ProgressBar1.Value & "%"
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Me.Visible = False
            LoginForm.Show()
        End If
    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
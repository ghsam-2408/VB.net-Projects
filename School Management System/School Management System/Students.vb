Public Class Students

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUploadImg.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                profilepic.Image = Image.FromFile(OpenFileDialog1.FileName)
            Catch ex As Exception
                MsgBox("Error loading image: " & ex.Message)
            End Try
        End If

    End Sub

    

    
    
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub Students_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnMinimize.Cursor = Cursors.Hand
        btnClose.Cursor = Cursors.Hand
        btnClose.Cursor = Cursors.Hand
        btnClose.Cursor = Cursors.Hand
        btnClose.Cursor = Cursors.Hand
        btnClose.Cursor = Cursors.Hand

        ToolTip1.SetToolTip(btnHome, "Main Menu")

    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        MainMenu.Show()

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        If Me.FormBorderStyle = FormBorderStyle.Sizable Then
            Me.FormBorderStyle = FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.FormBorderStyle = FormBorderStyle.Sizable
            Me.WindowState = FormWindowState.Normal
        End If

    End Sub
End Class
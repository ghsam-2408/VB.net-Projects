Imports System.Data.OleDb

Public Class LoginForm
    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\School_Management.accdb")


    Private Sub btnSignUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignUp.Click

        Register.Show()
        Me.Hide()

    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnSignUp.Cursor = Cursors.Hand 'make the cursor a hand when it hovers
        btnLogin.Cursor = Cursors.Hand
        picOpenEye.Cursor = Cursors.Hand
        picClosedEye.Cursor = Cursors.Hand
        btnFullscreen.Cursor = Cursors.Hand
        btnMinimize.Cursor = Cursors.Hand
        btnClose.Cursor = Cursors.Hand





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

        Try
            mycon.Open()

            Dim mycmd As New OleDbCommand("SELECT COUNT(*) FROM Register WHERE Username = ? AND [Password] = ?", mycon)
            mycmd.Parameters.AddWithValue("?", txtUsername.Text)
            mycmd.Parameters.AddWithValue("?", txtPassw.Text)

            ' Use ExecuteScalar to return a single value (count)
            Dim count As Integer = Convert.ToInt32(mycmd.ExecuteScalar())

            If count > 0 Then
                MsgBox("Login successful!", MsgBoxStyle.Information, "Success")
                MainMenu.Show()
                Me.Hide()
            Else
                MsgBox("Invalid Username or Password!", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            mycon.Close()
        End Try


        txtPassw.Clear()
        txtUsername.Clear()
        txtUsername.Focus()
        MainMenu.Show()


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

    Private Sub PictureBox5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFullscreen.Click
        If Me.FormBorderStyle = FormBorderStyle.Sizable Then
            Me.FormBorderStyle = FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.FormBorderStyle = FormBorderStyle.Sizable
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class

Imports System.Data.OleDb
Imports System.Data
Imports System.Text.RegularExpressions

Public Class LoginForm
    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EnrollmentManagement.accdb")

    ' Login attempt tracking for security
    Private loginAttempts As Integer = 0
    Private Const MAX_LOGIN_ATTEMPTS As Integer = 5
    Private lockoutEndTime As DateTime = DateTime.MinValue

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize form settings
        InitializeForm()
    End Sub

    Private Sub InitializeForm()
        Try
            ' Set password field to mask input
            txtPassword.UseSystemPasswordChar = True

            ' Add tooltips for better user experience
            Dim toolTip As New ToolTip()
            toolTip.SetToolTip(txtUsername, "Enter your username")
            toolTip.SetToolTip(txtPassword, "Enter your password")
            toolTip.SetToolTip(btnLogin, "Click to login to the system")
            toolTip.SetToolTip(btnSignUp, "Create a new account")

            ' Set focus to username field
            txtUsername.Focus()

            ' Allow Enter key to trigger login
            Me.AcceptButton = btnLogin

        Catch ex As Exception
            MessageBox.Show($"Error initializing login form: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Function ValidateInput() As Boolean
        Dim isValid As Boolean = True
        Dim errorMessages As New List(Of String)

        ' Reset field colors
        txtUsername.BackColor = Color.White
        txtPassword.BackColor = Color.White

        ' Validate Username
        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            txtUsername.BackColor = Color.LightCoral
            errorMessages.Add("• Username is required")
            isValid = False
        ElseIf txtUsername.Text.Trim().Length < 3 Then
            txtUsername.BackColor = Color.LightCoral
            errorMessages.Add("• Username must be at least 3 characters")
            isValid = False
        End If

        ' Validate Password
        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            txtPassword.BackColor = Color.LightCoral
            errorMessages.Add("• Password is required")
            isValid = False
        ElseIf txtPassword.Text.Length < 6 Then
            txtPassword.BackColor = Color.LightCoral
            errorMessages.Add("• Password must be at least 6 characters")
            isValid = False
        End If

        ' Show validation errors if any
        If Not isValid Then
            Dim errorMessage As String = "Please correct the following:" & vbCrLf & vbCrLf & String.Join(vbCrLf, errorMessages)
            MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        Return isValid
    End Function

    Private Function IsAccountLocked() As Boolean
        If lockoutEndTime > DateTime.Now Then
            Dim remainingTime As TimeSpan = lockoutEndTime.Subtract(DateTime.Now)
            MessageBox.Show($"Account is temporarily locked due to multiple failed login attempts." & vbCrLf &
                          $"Please try again in {Math.Ceiling(remainingTime.TotalMinutes)} minute(s).",
                          "Account Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        End If
        Return False
    End Function

    Private Sub HandleFailedLogin()
        loginAttempts += 1

        If loginAttempts >= MAX_LOGIN_ATTEMPTS Then
            ' Lock account for 15 minutes
            lockoutEndTime = DateTime.Now.AddMinutes(15)
            MessageBox.Show($"Too many failed login attempts ({loginAttempts})." & vbCrLf &
                          $"Account locked for 15 minutes for security.",
                          "Account Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim remainingAttempts As Integer = MAX_LOGIN_ATTEMPTS - loginAttempts
            MessageBox.Show($"Invalid username or password!" & vbCrLf &
                          $"Remaining attempts: {remainingAttempts}",
                          "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Function AuthenticateUser(username As String, password As String) As Boolean
        Try
            ' First check if it's the default admin account
            If username.ToLower() = "joshua" AndAlso password = "mushawatu" Then
                Return True
            End If

            ' Then check the database for registered users
            Using connection As New OleDbConnection(mycon.ConnectionString)
                connection.Open()

                ' Check UserRegistration table for login credentials
                Dim query As String = "SELECT COUNT(*) FROM UserRegistration WHERE Username = ? AND [Password] = ?"
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("?", username.Trim())
                    command.Parameters.AddWithValue("?", password)

                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    Return count > 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show($"Database error during authentication: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Check if account is locked
        If IsAccountLocked() Then
            Return
        End If

        ' Validate input fields
        If Not ValidateInput() Then
            txtUsername.Focus()
            Return
        End If

        Try
            ' Show loading cursor
            Me.Cursor = Cursors.WaitCursor

            ' Authenticate user
            If AuthenticateUser(txtUsername.Text, txtPassword.Text) Then
                ' Successful login
                loginAttempts = 0 ' Reset failed attempts
                lockoutEndTime = DateTime.MinValue ' Clear lockout

                ' Determine if it's admin or regular user
                Dim isAdmin As Boolean = (txtUsername.Text.ToLower() = "joshua")
                Dim userType As String = If(isAdmin, "Administrator", "User")

                ' Show success message
                MessageBox.Show($"Login successful!" & vbCrLf &
                              $"Welcome, {txtUsername.Text}!" & vbCrLf &
                              $"Account Type: {userType}",
                              "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Clear sensitive data
                ClearFields()

                ' Navigate to main menu
                MainMenu.Show()
                Me.Hide()

            Else
                ' Failed login
                HandleFailedLogin()

                ' Clear password field for security
                txtPassword.Clear()
                txtUsername.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show($"An unexpected error occurred during login: {ex.Message}",
                          "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Restore normal cursor
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Try
            ' Clear any sensitive data before navigating
            ClearFields()

            ' Navigate to registration form
            RegistrationForm.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show($"Error opening registration form: {ex.Message}", "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearFields()
        ' Clear all input fields
        txtUsername.Clear()
        txtPassword.Clear()

        ' Reset field colors
        txtUsername.BackColor = Color.White
        txtPassword.BackColor = Color.White

        ' Set focus to username
        txtUsername.Focus()
    End Sub

    ' Handle Enter key press in text fields
    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            btnLogin.PerformClick()
        End If
    End Sub

    ' Real-time validation feedback
    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        If Not String.IsNullOrWhiteSpace(txtUsername.Text) Then
            If txtUsername.Text.Trim().Length >= 3 Then
                txtUsername.BackColor = Color.LightGreen
            Else
                txtUsername.BackColor = Color.LightCoral
            End If
        Else
            txtUsername.BackColor = Color.White
        End If
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If Not String.IsNullOrWhiteSpace(txtPassword.Text) Then
            If txtPassword.Text.Length >= 6 Then
                txtPassword.BackColor = Color.LightGreen
            Else
                txtPassword.BackColor = Color.LightCoral
            End If
        Else
            txtPassword.BackColor = Color.White
        End If
    End Sub

    ' Handle form closing
    Private Sub LoginForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Clear sensitive data when form closes
        ClearFields()

        ' Ensure database connection is closed
        Try
            If mycon IsNot Nothing AndAlso mycon.State = ConnectionState.Open Then
                mycon.Close()
            End If
        Catch
            ' Ignore errors when closing
        End Try
    End Sub

    ' Show/Hide password functionality (if you want to add a checkbox later)
    Private Sub TogglePasswordVisibility()
        txtPassword.UseSystemPasswordChar = Not txtPassword.UseSystemPasswordChar
    End Sub

End Class

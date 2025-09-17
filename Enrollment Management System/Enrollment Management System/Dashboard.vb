Imports System.Data.OleDb
Imports System.Data

Public Class Dashboard
    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EnrollmentManagement.accdb")

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize dashboard
        InitializeDashboard()

        ' Load all statistics
        LoadDashboardStatistics()
    End Sub

    Private Sub InitializeDashboard()
        Try
            ' Set up the dashboard appearance
            Me.Text = "Dashboard - Enrollment Management System"

            ' Add tooltips for better user experience
            Dim toolTip As New ToolTip()
            toolTip.SetToolTip(Panel1, "Total number of enrolled students")
            toolTip.SetToolTip(Panel2, "Total fees collected and statistics")
            toolTip.SetToolTip(Panel3, "Total number of registered users")
            toolTip.SetToolTip(Panel4, "System reports and analytics")
            toolTip.SetToolTip(btnLogOut, "Click to logout from the system")

            ' Set initial loading state
            Label2.Text = "Loading..."
            Label3.Text = "Loading..."
            Label5.Text = "Loading..."
            Label7.Text = "Loading..."

        Catch ex As Exception
            MessageBox.Show($"Error initializing dashboard: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub LoadDashboardStatistics()
        Try
            ' Load all statistics
            LoadStudentStatistics()
            LoadFeesStatistics()
            LoadUserStatistics()
            LoadReportStatistics()

        Catch ex As Exception
            MessageBox.Show($"Error loading dashboard statistics: {ex.Message}", "Dashboard Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadStudentStatistics()
        Try
            Using connection As New OleDbConnection(mycon.ConnectionString)
                connection.Open()

                ' Get total number of enrolled students
                Dim studentQuery As String = "SELECT COUNT(*) FROM StudentsEnrollment"
                Using command As New OleDbCommand(studentQuery, connection)
                    Dim totalStudents As Integer = Convert.ToInt32(command.ExecuteScalar())

                    ' Update the label with total count
                    Label2.Text = $"Total: {totalStudents:N0}"

                    ' Add color coding based on student count
                    If totalStudents = 0 Then
                        Panel1.BackColor = Color.LightCoral
                    ElseIf totalStudents < 50 Then
                        Panel1.BackColor = Color.LightYellow
                    Else
                        Panel1.BackColor = Color.LightGreen
                    End If
                End Using
            End Using

        Catch ex As Exception
            Label2.Text = "Error"
            Panel1.BackColor = Color.LightCoral
            ' Don't show error message here to avoid multiple popups
        End Try
    End Sub

    Private Sub LoadFeesStatistics()
        Try
            Using connection As New OleDbConnection(mycon.ConnectionString)
                connection.Open()

                ' Get total fees collected and payment statistics
                Dim feesQuery As String = "SELECT COUNT(*) as PaymentCount, SUM(AmountPaid) as TotalCollected, SUM(Balance) as TotalBalance FROM FeesPayments"
                Using command As New OleDbCommand(feesQuery, connection)
                    Using reader As OleDbDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            Dim paymentCount As Integer = If(IsDBNull(reader("PaymentCount")), 0, Convert.ToInt32(reader("PaymentCount")))
                            Dim totalCollected As Decimal = If(IsDBNull(reader("TotalCollected")), 0, Convert.ToDecimal(reader("TotalCollected")))
                            Dim totalBalance As Decimal = If(IsDBNull(reader("TotalBalance")), 0, Convert.ToDecimal(reader("TotalBalance")))

                            ' Display comprehensive fees information
                            Label3.Text = $"Payments: {paymentCount:N0}" & vbCrLf & $"Collected: {totalCollected:C}" & vbCrLf & $"Balance: {totalBalance:C}"

                            ' Color coding based on collection ratio
                            If paymentCount = 0 Then
                                Panel2.BackColor = Color.LightCoral
                            ElseIf totalBalance > totalCollected Then
                                Panel2.BackColor = Color.LightYellow
                            Else
                                Panel2.BackColor = Color.LightGreen
                            End If
                        Else
                            Label3.Text = "No Data"
                            Panel2.BackColor = Color.LightGray
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            Label3.Text = "Error"
            Panel2.BackColor = Color.LightCoral
        End Try
    End Sub

    Private Sub LoadUserStatistics()
        Try
            Using connection As New OleDbConnection(mycon.ConnectionString)
                connection.Open()

                ' Get total number of registered users
                Dim userQuery As String = "SELECT COUNT(*) FROM UserRegistration"
                Using command As New OleDbCommand(userQuery, connection)
                    Dim totalUsers As Integer = Convert.ToInt32(command.ExecuteScalar())

                    ' Update the label with total count
                    Label5.Text = $"Total: {totalUsers:N0}"

                    ' Add color coding based on user count
                    If totalUsers = 0 Then
                        Panel3.BackColor = Color.LightCoral
                    ElseIf totalUsers < 10 Then
                        Panel3.BackColor = Color.LightYellow
                    Else
                        Panel3.BackColor = Color.LightGreen
                    End If
                End Using
            End Using

        Catch ex As Exception
            Label5.Text = "Error"
            Panel3.BackColor = Color.LightCoral
        End Try
    End Sub

    Private Sub LoadReportStatistics()
        Try
            Using connection As New OleDbConnection(mycon.ConnectionString)
                connection.Open()

                ' Calculate various report statistics
                Dim reportData As String = ""

                ' Get today's registrations
                Dim todayRegistrations As Integer = 0
                Dim todayQuery As String = "SELECT COUNT(*) FROM UserRegistration WHERE DateValue(RegistrationDate) = DateValue(Date())"
                Try
                    Using command As New OleDbCommand(todayQuery, connection)
                        todayRegistrations = Convert.ToInt32(command.ExecuteScalar())
                    End Using
                Catch
                    ' If RegistrationDate column doesn't exist, skip this stat
                End Try

                ' Get today's payments
                Dim todayPayments As Integer = 0
                Dim todayPaymentQuery As String = "SELECT COUNT(*) FROM FeesPayments WHERE DateValue(PaymentDate) = DateValue(Date())"
                Try
                    Using command As New OleDbCommand(todayPaymentQuery, connection)
                        todayPayments = Convert.ToInt32(command.ExecuteScalar())
                    End Using
                Catch
                    ' If no payments today or table doesn't exist
                End Try

                ' Create summary report
                reportData = $"Today:" & vbCrLf & $"Registrations: {todayRegistrations}" & vbCrLf & $"Payments: {todayPayments}"

                Label7.Text = reportData

                ' Color coding based on daily activity
                If todayRegistrations + todayPayments = 0 Then
                    Panel4.BackColor = Color.LightGray
                ElseIf todayRegistrations + todayPayments < 5 Then
                    Panel4.BackColor = Color.LightYellow
                Else
                    Panel4.BackColor = Color.LightGreen
                End If

            End Using

        Catch ex As Exception
            Label7.Text = "Reports" & vbCrLf & "Available"
            Panel4.BackColor = Color.LightBlue
        End Try
    End Sub

    ' Refresh button functionality
    Private Sub RefreshDashboard()
        ' Show loading state
        Label2.Text = "Refreshing..."
        Label3.Text = "Refreshing..."
        Label5.Text = "Refreshing..."
        Label7.Text = "Refreshing..."

        ' Reset colors
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel3.BackColor = SystemColors.ActiveCaption
        Panel4.BackColor = SystemColors.ActiveCaption

        ' Reload statistics
        LoadDashboardStatistics()

        MessageBox.Show("Dashboard refreshed successfully!", "Refresh Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Event handlers for panel clicks to show more details
    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        ShowStudentDetails()
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        ShowFeesDetails()
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        ShowUserDetails()
    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        ShowReportDetails()
    End Sub

    Private Sub ShowStudentDetails()
        Try
            Using connection As New OleDbConnection(mycon.ConnectionString)
                connection.Open()

                ' Get detailed student statistics
                Dim detailQuery As String = "SELECT Department, COUNT(*) as Count FROM StudentsEnrollment GROUP BY Department"
                Dim details As String = "STUDENT ENROLLMENT DETAILS" & vbCrLf & vbCrLf

                Using command As New OleDbCommand(detailQuery, connection)
                    Using reader As OleDbDataReader = command.ExecuteReader()
                        While reader.Read()
                            details += $"{reader("Department")}: {reader("Count")} students" & vbCrLf
                        End While
                    End Using
                End Using

                MessageBox.Show(details, "Student Statistics", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("No detailed student data available.", "Student Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub ShowFeesDetails()
        Try
            Using connection As New OleDbConnection(mycon.ConnectionString)
                connection.Open()

                ' Get detailed fees statistics
                Dim detailQuery As String = "SELECT PaymentMethod, COUNT(*) as Count, SUM(AmountPaid) as Total FROM FeesPayments GROUP BY PaymentMethod"
                Dim details As String = "FEES PAYMENT DETAILS" & vbCrLf & vbCrLf

                Using command As New OleDbCommand(detailQuery, connection)
                    Using reader As OleDbDataReader = command.ExecuteReader()
                        While reader.Read()
                            details += $"{reader("PaymentMethod")}: {reader("Count")} payments ({Convert.ToDecimal(reader("Total")):C})" & vbCrLf
                        End While
                    End Using
                End Using

                MessageBox.Show(details, "Fees Statistics", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("No detailed fees data available.", "Fees Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub ShowUserDetails()
        Try
            Using connection As New OleDbConnection(mycon.ConnectionString)
                connection.Open()

                ' Get recent user registrations
                Dim detailQuery As String = "SELECT TOP 5 Name, Surname, Username FROM UserRegistration ORDER BY ID DESC"
                Dim details As String = "RECENT USER REGISTRATIONS" & vbCrLf & vbCrLf

                Using command As New OleDbCommand(detailQuery, connection)
                    Using reader As OleDbDataReader = command.ExecuteReader()
                        While reader.Read()
                            details += $"{reader("Name")} {reader("Surname")} ({reader("Username")})" & vbCrLf
                        End While
                    End Using
                End Using

                MessageBox.Show(details, "User Statistics", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("No detailed user data available.", "User Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub ShowReportDetails()
        Try
            Dim reportDetails As String = "SYSTEM REPORTS" & vbCrLf & vbCrLf &
                                        "Available Reports:" & vbCrLf &
                                        "• Student Enrollment Report" & vbCrLf &
                                        "• Fees Collection Report" & vbCrLf &
                                        "• User Registration Report" & vbCrLf &
                                        "• Daily Activity Report" & vbCrLf & vbCrLf &
                                        "Click on specific panels for detailed statistics."

            MessageBox.Show(reportDetails, "Report Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Report details unavailable.", "Report Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    ' Logout functionality
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs)
        Dim result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Close dashboard and show login form
            Hide
            LoginForm.Show
        End If
    End Sub

    ' Form closing event
    Private Sub Dashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Ensure database connection is closed
        Try
            If mycon IsNot Nothing AndAlso mycon.State = ConnectionState.Open Then
                mycon.Close()
            End If
        Catch
            ' Ignore errors when closing
        End Try
    End Sub

    ' Timer for auto-refresh (optional)
    Private Sub SetupAutoRefresh()
        Dim refreshTimer As New Timer()
        refreshTimer.Interval = 300000 ' 5 minutes
        AddHandler refreshTimer.Tick, AddressOf Timer_Tick
        refreshTimer.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        ' Auto-refresh dashboard every 5 minutes
        LoadDashboardStatistics()
    End Sub

    ' Key press event for manual refresh (F5)
    Private Sub Dashboard_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            RefreshDashboard()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        StudentsEnrollment.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        StudentsEnrollment.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        StudentsEnrollment.Show()
    End Sub
End Class
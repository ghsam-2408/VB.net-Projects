Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Windows.Forms

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.

    ' **NEW** ApplyApplicationDefaults: Raised when the application queries default values to be set for the application.

    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            ' Ensure clean startup - removed problematic line
        End Sub

        Private Sub MyApplication_Shutdown(sender As Object, e As EventArgs) Handles Me.Shutdown
            ' Force cleanup of all resources
            Try
                ' Close all open forms
                For Each form As Form In Application.OpenForms.Cast(Of Form).ToArray()
                    If form IsNot Nothing AndAlso Not form.IsDisposed Then
                        form.Close()
                        form.Dispose()
                    End If
                Next

                ' Force garbage collection
                GC.Collect()
                GC.WaitForPendingFinalizers()
                GC.Collect()

                ' Ensure application exits completely
                Application.DoEvents()
                
            Catch ex As Exception
                ' Ignore errors during shutdown cleanup
            End Try
        End Sub

        Private Sub MyApplication_StartupNextInstance(sender As Object, e As StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            ' Handle when user tries to start another instance
            ' Bring the existing instance to front
            If My.Application.OpenForms.Count > 0 Then
                Dim mainForm = My.Application.OpenForms.Cast(Of Form).FirstOrDefault()
                If mainForm IsNot Nothing Then
                    If mainForm.WindowState = FormWindowState.Minimized Then
                        mainForm.WindowState = FormWindowState.Normal
                    End If
                    mainForm.BringToFront()
                    mainForm.Activate()
                End If
            End If
        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            ' Handle unhandled exceptions to prevent application hanging
            Try
                MessageBox.Show($"An unexpected error occurred: {e.Exception.Message}", 
                              "Application Error", 
                              MessageBoxButtons.OK, 
                              MessageBoxIcon.Error)
            Finally
                ' Force application to exit
                Environment.Exit(1)
            End Try
        End Sub

        Private Sub MyApplication_ApplyApplicationDefaults(sender As Object, e As ApplyApplicationDefaultsEventArgs) Handles Me.ApplyApplicationDefaults
            ' Setting the HighDpiMode for the Application:
            e.HighDpiMode = HighDpiMode.SystemAware
            
            ' If a splash dialog is used, this sets the minimum display time:
            e.MinimumSplashScreenDisplayTime = 2000
        End Sub

    End Class
End Namespace

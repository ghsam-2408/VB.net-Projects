<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnLogin = New Button()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnSignUp = New Button()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        btnLogin.Location = New Point(717, 342)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(133, 49)
        btnLogin.TabIndex = 0
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtUsername.Location = New Point(692, 136)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(395, 45)
        txtUsername.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtPassword.Location = New Point(692, 232)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(395, 45)
        txtPassword.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label1.Location = New Point(483, 136)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 38)
        Label1.TabIndex = 3
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label2.Location = New Point(483, 232)
        Label2.Name = "Label2"
        Label2.Size = New Size(136, 38)
        Label2.TabIndex = 4
        Label2.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label3.Location = New Point(483, 439)
        Label3.Name = "Label3"
        Label3.Size = New Size(319, 38)
        Label3.TabIndex = 5
        Label3.Text = "Dont Have An Account?"
        ' 
        ' btnSignUp
        ' 
        btnSignUp.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        btnSignUp.Location = New Point(808, 439)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(257, 47)
        btnSignUp.TabIndex = 6
        btnSignUp.Text = "Create Account"
        btnSignUp.UseVisualStyleBackColor = True
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(1247, 576)
        Controls.Add(btnSignUp)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(btnLogin)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSignUp As Button

End Class

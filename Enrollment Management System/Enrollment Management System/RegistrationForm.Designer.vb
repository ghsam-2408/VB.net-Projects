<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtName = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txtUsername = New TextBox()
        Label3 = New Label()
        txtSurname = New TextBox()
        Label4 = New Label()
        txtIdNumber = New TextBox()
        Label5 = New Label()
        txtEmail = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        txtPassword = New TextBox()
        Label8 = New Label()
        txtRetypePassword = New TextBox()
        DataGridView1 = New DataGridView()
        Panel1 = New Panel()
        txtGender = New ComboBox()
        Button1 = New Button()
        Label9 = New Label()
        Label10 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtName.Location = New Point(32, 272)
        txtName.Name = "txtName"
        txtName.Size = New Size(379, 45)
        txtName.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label1.Location = New Point(65, 231)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 38)
        Label1.TabIndex = 1
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label2.Location = New Point(65, 346)
        Label2.Name = "Label2"
        Label2.Size = New Size(145, 38)
        Label2.TabIndex = 3
        Label2.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtUsername.Location = New Point(32, 387)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(379, 45)
        txtUsername.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label3.Location = New Point(650, 231)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 38)
        Label3.TabIndex = 5
        Label3.Text = "Surname"
        ' 
        ' txtSurname
        ' 
        txtSurname.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtSurname.Location = New Point(617, 272)
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(379, 45)
        txtSurname.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label4.Location = New Point(663, 346)
        Label4.Name = "Label4"
        Label4.Size = New Size(157, 38)
        Label4.TabIndex = 7
        Label4.Text = "ID Number"
        ' 
        ' txtIdNumber
        ' 
        txtIdNumber.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtIdNumber.Location = New Point(630, 387)
        txtIdNumber.Name = "txtIdNumber"
        txtIdNumber.Size = New Size(379, 45)
        txtIdNumber.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label5.Location = New Point(65, 485)
        Label5.Name = "Label5"
        Label5.Size = New Size(86, 38)
        Label5.TabIndex = 9
        Label5.Text = "Email"
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtEmail.Location = New Point(32, 526)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(379, 45)
        txtEmail.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label6.Location = New Point(663, 485)
        Label6.Name = "Label6"
        Label6.Size = New Size(110, 38)
        Label6.TabIndex = 11
        Label6.Text = "Gender"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label7.Location = New Point(65, 598)
        Label7.Name = "Label7"
        Label7.Size = New Size(136, 38)
        Label7.TabIndex = 13
        Label7.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtPassword.Location = New Point(32, 639)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(379, 45)
        txtPassword.TabIndex = 12
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label8.Location = New Point(663, 598)
        Label8.Name = "Label8"
        Label8.Size = New Size(231, 38)
        Label8.TabIndex = 15
        Label8.Text = "Retype Password"
        ' 
        ' txtRetypePassword
        ' 
        txtRetypePassword.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtRetypePassword.Location = New Point(630, 639)
        txtRetypePassword.Name = "txtRetypePassword"
        txtRetypePassword.Size = New Size(379, 45)
        txtRetypePassword.TabIndex = 14
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 970)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(1087, 127)
        DataGridView1.TabIndex = 16
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Panel1.Location = New Point(1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1111, 177)
        Panel1.TabIndex = 17
        ' 
        ' txtGender
        ' 
        txtGender.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtGender.FormattingEnabled = True
        txtGender.Items.AddRange(New Object() {"Male", "Female"})
        txtGender.Location = New Point(617, 525)
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(392, 46)
        txtGender.TabIndex = 18
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Microsoft Sans Serif", 16F)
        Button1.Location = New Point(450, 745)
        Button1.Name = "Button1"
        Button1.Size = New Size(198, 64)
        Button1.TabIndex = 19
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 16F)
        Label9.Location = New Point(263, 868)
        Label9.Name = "Label9"
        Label9.Size = New Size(395, 37)
        Label9.TabIndex = 20
        Label9.Text = "Already Have an Account?"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Red
        Label10.Font = New Font("Microsoft Sans Serif", 16F)
        Label10.ForeColor = Color.White
        Label10.Location = New Point(650, 868)
        Label10.Name = "Label10"
        Label10.Size = New Size(96, 37)
        Label10.TabIndex = 21
        Label10.Text = "Login"
        ' 
        ' RegistrationForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(1111, 1122)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Button1)
        Controls.Add(txtGender)
        Controls.Add(Panel1)
        Controls.Add(DataGridView1)
        Controls.Add(Label8)
        Controls.Add(txtRetypePassword)
        Controls.Add(Label7)
        Controls.Add(txtPassword)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(txtEmail)
        Controls.Add(Label4)
        Controls.Add(txtIdNumber)
        Controls.Add(Label3)
        Controls.Add(txtSurname)
        Controls.Add(Label2)
        Controls.Add(txtUsername)
        Controls.Add(Label1)
        Controls.Add(txtName)
        Name = "RegistrationForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RegistrationForm"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIdNumber As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtRetypePassword As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtGender As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class

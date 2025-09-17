<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Panel2 = New Panel()
        btnEnroll = New Button()
        btnDashboard = New Button()
        btnFeePayment = New Button()
        Panel1 = New Panel()
        btnLogout = New Button()
        Label1 = New Label()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(12, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1139, 67)
        Panel2.TabIndex = 35
        ' 
        ' btnEnroll
        ' 
        btnEnroll.BackColor = Color.Lime
        btnEnroll.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEnroll.Location = New Point(201, 85)
        btnEnroll.Name = "btnEnroll"
        btnEnroll.Size = New Size(162, 84)
        btnEnroll.TabIndex = 0
        btnEnroll.Text = "Enroll Student"
        btnEnroll.UseVisualStyleBackColor = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.Lime
        btnDashboard.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDashboard.Location = New Point(201, 291)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(173, 94)
        btnDashboard.TabIndex = 1
        btnDashboard.Text = "Dashboard"
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' btnFeePayment
        ' 
        btnFeePayment.BackColor = Color.Lime
        btnFeePayment.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFeePayment.Location = New Point(618, 85)
        btnFeePayment.Name = "btnFeePayment"
        btnFeePayment.Size = New Size(151, 103)
        btnFeePayment.TabIndex = 3
        btnFeePayment.Text = "Make Payment"
        btnFeePayment.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.AppWorkspace
        Panel1.Controls.Add(btnFeePayment)
        Panel1.Controls.Add(btnDashboard)
        Panel1.Controls.Add(btnEnroll)
        Panel1.Location = New Point(168, 121)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(846, 491)
        Panel1.TabIndex = 0
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnLogout.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = SystemColors.ActiveCaptionText
        btnLogout.Location = New Point(12, 771)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(222, 53)
        btnLogout.TabIndex = 36
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(458, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(187, 38)
        Label1.TabIndex = 0
        Label1.Text = "MAIN MENU"
        ' 
        ' MainMenu
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1235, 836)
        Controls.Add(btnLogout)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "MainMenu"
        Text = "MainMenu"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnEnroll As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnFeePayment As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label1 As Label
End Class

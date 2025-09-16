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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Panel2 = New Panel()
        btn = New Label()
        btnEnroll = New Button()
        btnDashboard = New Button()
        btnFeePayment = New Button()
        Panel1 = New Panel()
        btnLogOut = New Panel()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        btnLogOut.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Panel2.Location = New Point(12, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1139, 67)
        Panel2.TabIndex = 35
        ' 
        ' btn
        ' 
        btn.AutoSize = True
        btn.Location = New Point(95, 15)
        btn.Name = "btn"
        btn.Size = New Size(108, 38)
        btn.TabIndex = 36
        btn.Text = "Logout"
        ' 
        ' btnEnroll
        ' 
        btnEnroll.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEnroll.Location = New Point(201, 85)
        btnEnroll.Name = "btnEnroll"
        btnEnroll.Size = New Size(162, 84)
        btnEnroll.TabIndex = 0
        btnEnroll.Text = "Enroll Student"
        btnEnroll.UseVisualStyleBackColor = True
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDashboard.Location = New Point(201, 291)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(173, 94)
        btnDashboard.TabIndex = 1
        btnDashboard.Text = "Dashboard"
        btnDashboard.UseVisualStyleBackColor = True
        ' 
        ' btnFeePayment
        ' 
        btnFeePayment.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFeePayment.Location = New Point(618, 85)
        btnFeePayment.Name = "btnFeePayment"
        btnFeePayment.Size = New Size(151, 103)
        btnFeePayment.TabIndex = 3
        btnFeePayment.Text = "Make Payment"
        btnFeePayment.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnFeePayment)
        Panel1.Controls.Add(btnDashboard)
        Panel1.Controls.Add(btnEnroll)
        Panel1.Location = New Point(168, 121)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(846, 491)
        Panel1.TabIndex = 0
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Controls.Add(PictureBox1)
        btnLogOut.Controls.Add(btn)
        btnLogOut.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogOut.Location = New Point(12, 755)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(209, 69)
        btnLogOut.TabIndex = 37
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(11, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(78, 60)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 37
        PictureBox1.TabStop = False
        ' 
        ' MainMenu
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1235, 836)
        Controls.Add(btnLogOut)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "MainMenu"
        Text = "MainMenu"
        Panel1.ResumeLayout(False)
        btnLogOut.ResumeLayout(False)
        btnLogOut.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn As Label
    Friend WithEvents btnEnroll As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnFeePayment As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogOut As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class

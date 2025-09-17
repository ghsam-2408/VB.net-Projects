<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Panel1 = New Panel()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Panel2 = New Panel()
        Label3 = New Label()
        PictureBox3 = New PictureBox()
        Label4 = New Label()
        Panel3 = New Panel()
        Label5 = New Label()
        PictureBox4 = New PictureBox()
        Label6 = New Label()
        Panel4 = New Panel()
        Label7 = New Label()
        PictureBox5 = New PictureBox()
        Label8 = New Label()
        Panel6 = New Panel()
        btnLogOut = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Label1)
        Panel1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel1.Location = New Point(388, 138)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(224, 176)
        Panel1.TabIndex = 39
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 133)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 32)
        Label2.TabIndex = 2
        Label2.Text = "Total:"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(64, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(72, 75)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(44, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 32)
        Label1.TabIndex = 0
        Label1.Text = "Students"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Controls.Add(Label4)
        Panel2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel2.Location = New Point(758, 141)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(224, 176)
        Panel2.TabIndex = 40
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(17, 133)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 32)
        Label3.TabIndex = 2
        Label3.Text = "Total:"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(64, 3)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(72, 75)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 1
        PictureBox3.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(44, 81)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 32)
        Label4.TabIndex = 0
        Label4.Text = "Fees"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ActiveCaption
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(PictureBox4)
        Panel3.Controls.Add(Label6)
        Panel3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel3.Location = New Point(388, 402)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(224, 176)
        Panel3.TabIndex = 40
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(17, 133)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 32)
        Label5.TabIndex = 2
        Label5.Text = "Total:"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(64, 3)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(72, 75)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 1
        PictureBox4.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(44, 81)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 32)
        Label6.TabIndex = 0
        Label6.Text = "Users"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ActiveCaption
        Panel4.Controls.Add(Label7)
        Panel4.Controls.Add(PictureBox5)
        Panel4.Controls.Add(Label8)
        Panel4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel4.Location = New Point(758, 402)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(420, 378)
        Panel4.TabIndex = 41
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(17, 133)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 32)
        Label7.TabIndex = 2
        Label7.Text = "Total:"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(64, 3)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(72, 75)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 1
        PictureBox5.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(44, 81)
        Label8.Name = "Label8"
        Label8.Size = New Size(98, 32)
        Label8.TabIndex = 0
        Label8.Text = "Reports"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Panel6.Controls.Add(btnLogOut)
        Panel6.Controls.Add(Button3)
        Panel6.Controls.Add(Button2)
        Panel6.Controls.Add(Button1)
        Panel6.Location = New Point(12, 12)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(1139, 67)
        Panel6.TabIndex = 43
        ' 
        ' btnLogOut
        ' 
        btnLogOut.BackColor = Color.Red
        btnLogOut.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogOut.Location = New Point(567, 3)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(176, 50)
        btnLogOut.TabIndex = 5
        btnLogOut.Text = "Logout"
        btnLogOut.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Red
        Button3.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(290, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(176, 50)
        Button3.TabIndex = 4
        Button3.Text = "Enroll"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(889, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(204, 50)
        Button2.TabIndex = 3
        Button2.Text = "Fees Payment"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(39, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(180, 50)
        Button1.TabIndex = 2
        Button1.Text = "MainMenu"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateGray
        ClientSize = New Size(1393, 792)
        Controls.Add(Panel6)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Dashboard"
        Text = "Dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnLogOut As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        ProgressBar1 = New ProgressBar()
        Label2 = New Label()
        Timer1 = New Timer(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(194, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(836, 565)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Blue
        Label1.Location = New Point(194, 683)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 38)
        Label1.TabIndex = 1
        Label1.Text = "Loading..."
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(194, 646)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(836, 34)
        ProgressBar1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Blue
        Label2.Location = New Point(965, 683)
        Label2.Name = "Label2"
        Label2.Size = New Size(33, 38)
        Label2.TabIndex = 3
        Label2.Text = "0"
        ' 
        ' Timer1
        ' 
        ' 
        ' SplashScreen
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1248, 758)
        Controls.Add(Label2)
        Controls.Add(ProgressBar1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "SplashScreen"
        Text = "SplashScreen"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home_page
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
        PictureBox3 = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Panel1 = New Panel()
        Button5 = New Button()
        Button6 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImageLayout = ImageLayout.Center
        PictureBox3.Image = My.Resources.Resources.agriculture_farming_logo_vector_260392992
        PictureBox3.Location = New Point(12, 12)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(131, 106)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 11
        PictureBox3.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(32, 124)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 12
        Button1.Text = "Hire"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(32, 174)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 13
        Button2.Text = "Education"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(32, 226)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 14
        Button3.Text = "Marketing"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(20, 498)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 15
        Button4.Text = "Sign Out "
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Button3)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(159, 655)
        Panel1.TabIndex = 13
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(32, 354)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 29)
        Button5.TabIndex = 18
        Button5.Text = "Profile"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(32, 285)
        Button6.Name = "Button6"
        Button6.Size = New Size(94, 29)
        Button6.TabIndex = 17
        Button6.Text = "Why Us ?"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        Label1.Font = New Font("Tempus Sans ITC", 48F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(192, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(370, 104)
        Label1.TabIndex = 14
        Label1.Text = "welcome."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        Label2.Font = New Font("Segoe UI", 28.2F, FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(192, 141)
        Label2.Name = "Label2"
        Label2.Size = New Size(789, 62)
        Label2.TabIndex = 15
        Label2.Text = """Making farming better for everyone."""
        ' 
        ' home_page
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._642057f39a0100e7ecc84daa_640f877a2868a2e6ac8d6749_farm_equipment
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1426, 655)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Cursor = Cursors.IBeam
        Name = "home_page"
        Text = "home_page"
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class

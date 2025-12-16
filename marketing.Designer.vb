<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class marketing
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(marketing))
        Button1 = New Button()
        Label1 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Button2 = New Button()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label4 = New Label()
        Label5 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Panel3 = New Panel()
        Button3 = New Button()
        Label12 = New Label()
        Button4 = New Button()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        PictureBox3 = New PictureBox()
        Panel4 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(769, 783)
        Button1.Name = "Button1"
        Button1.Size = New Size(169, 55)
        Button1.TabIndex = 0
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(542, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(223, 41)
        Label1.TabIndex = 1
        Label1.Text = " Marketing"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1924, 125)
        Panel1.TabIndex = 21
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(40, 185)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(487, 465)
        Panel2.TabIndex = 22
        ' 
        ' Button2
        ' 
        Button2.Cursor = Cursors.Hand
        Button2.Location = New Point(308, 367)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 6
        Button2.Text = "Contact"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(26, 305)
        Label8.Name = "Label8"
        Label8.Size = New Size(141, 20)
        Label8.TabIndex = 5
        Label8.Text = "Phone : 0719220813"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(26, 269)
        Label7.Name = "Label7"
        Label7.Size = New Size(260, 20)
        Label7.TabIndex = 4
        Label7.Text = "Email:  Thulifreshproduce@gmail.com"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(26, 243)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 46)
        Label6.TabIndex = 3
        Label6.Text = "Contacts" & vbCrLf & vbCrLf
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(213, 92)
        Label3.Name = "Label3"
        Label3.Size = New Size(199, 112)
        Label3.TabIndex = 2
        Label3.Text = "Produces" & vbCrLf & ">Fruits" & vbCrLf & ">Vegetables" & vbCrLf & ">packaged  products" & vbCrLf
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(213, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(242, 31)
        Label2.TabIndex = 1
        Label2.Text = "Thuli's Fresh Produce"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(26, 44)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(164, 176)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(42, 59)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(164, 176)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(212, 59)
        Label4.Name = "Label4"
        Label4.Size = New Size(208, 31)
        Label4.TabIndex = 2
        Label4.Text = "Mpho's fruits & Veg"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(221, 123)
        Label5.Name = "Label5"
        Label5.Size = New Size(207, 112)
        Label5.TabIndex = 3
        Label5.Text = "Produces" & vbCrLf & ">Pure Organic Carrots" & vbCrLf & ">Cabbage" & vbCrLf & ">Onions" & vbCrLf
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(42, 258)
        Label9.Name = "Label9"
        Label9.Size = New Size(79, 46)
        Label9.TabIndex = 4
        Label9.Text = "Contacts" & vbCrLf & vbCrLf
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(42, 284)
        Label10.Name = "Label10"
        Label10.Size = New Size(260, 20)
        Label10.TabIndex = 5
        Label10.Text = "Email:  Thulifreshproduce@gmail.com"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(42, 320)
        Label11.Name = "Label11"
        Label11.Size = New Size(141, 20)
        Label11.TabIndex = 6
        Label11.Text = "Phone : 0185654258"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Silver
        Panel3.Controls.Add(Button3)
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(PictureBox2)
        Panel3.Location = New Point(674, 185)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(487, 465)
        Panel3.TabIndex = 23
        ' 
        ' Button3
        ' 
        Button3.Cursor = Cursors.Hand
        Button3.Location = New Point(346, 382)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 7
        Button3.Text = "Contact"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(646, 128)
        Label12.Name = "Label12"
        Label12.Size = New Size(73, 23)
        Label12.TabIndex = 24
        Label12.Text = "Farmers"
        ' 
        ' Button4
        ' 
        Button4.Cursor = Cursors.Hand
        Button4.Location = New Point(346, 382)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 7
        Button4.Text = "Contact"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(42, 320)
        Label13.Name = "Label13"
        Label13.Size = New Size(141, 20)
        Label13.TabIndex = 6
        Label13.Text = "Phone : 0875698524"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(42, 284)
        Label14.Name = "Label14"
        Label14.Size = New Size(262, 20)
        Label14.TabIndex = 5
        Label14.Text = "Email:  johnfreshpveggies@gmail.com"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(42, 258)
        Label15.Name = "Label15"
        Label15.Size = New Size(79, 46)
        Label15.TabIndex = 4
        Label15.Text = "Contacts" & vbCrLf & vbCrLf
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label16.Location = New Point(221, 123)
        Label16.Name = "Label16"
        Label16.Size = New Size(207, 112)
        Label16.TabIndex = 3
        Label16.Text = "Produces" & vbCrLf & ">Pure Organic Carrots" & vbCrLf & "Vegetables" & vbCrLf & ">packaged  products" & vbCrLf
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.Location = New Point(212, 59)
        Label17.Name = "Label17"
        Label17.Size = New Size(143, 31)
        Label17.TabIndex = 2
        Label17.Text = "John's  Vegs"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(18, 59)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(197, 176)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Silver
        Panel4.Controls.Add(Button4)
        Panel4.Controls.Add(Label13)
        Panel4.Controls.Add(Label14)
        Panel4.Controls.Add(Label15)
        Panel4.Controls.Add(Label16)
        Panel4.Controls.Add(Label17)
        Panel4.Controls.Add(PictureBox3)
        Panel4.Location = New Point(1319, 185)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(487, 465)
        Panel4.TabIndex = 25
        ' 
        ' marketing
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        ClientSize = New Size(1924, 994)
        Controls.Add(Panel4)
        Controls.Add(Label12)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Name = "marketing"
        SizeGripStyle = SizeGripStyle.Show
        Text = "marketing"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel4 As Panel
End Class

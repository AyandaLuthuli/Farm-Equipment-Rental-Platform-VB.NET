<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        btnLOGIN = New Button()
        register = New Label()
        forgotpassword = New Label()
        txtPassword = New TextBox()
        txtName = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(btnLOGIN)
        Panel1.Controls.Add(register)
        Panel1.Controls.Add(forgotpassword)
        Panel1.Controls.Add(txtPassword)
        Panel1.Controls.Add(txtName)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label10)
        Panel1.Location = New Point(67, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1598, 761)
        Panel1.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Image = My.Resources.Resources.agriculture_farming_logo_vector_260392992
        PictureBox1.Location = New Point(504, 29)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(323, 193)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' btnLOGIN
        ' 
        btnLOGIN.BackColor = SystemColors.InactiveCaption
        btnLOGIN.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        btnLOGIN.Location = New Point(468, 446)
        btnLOGIN.Name = "btnLOGIN"
        btnLOGIN.Size = New Size(154, 49)
        btnLOGIN.TabIndex = 15
        btnLOGIN.Text = "Log In"
        btnLOGIN.UseVisualStyleBackColor = False
        ' 
        ' register
        ' 
        register.AutoSize = True
        register.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        register.Location = New Point(496, 556)
        register.Name = "register"
        register.Size = New Size(152, 39)
        register.TabIndex = 14
        register.Text = "Register"
        ' 
        ' forgotpassword
        ' 
        forgotpassword.AutoSize = True
        forgotpassword.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        forgotpassword.Location = New Point(410, 517)
        forgotpassword.Name = "forgotpassword"
        forgotpassword.Size = New Size(315, 39)
        forgotpassword.TabIndex = 13
        forgotpassword.Text = "Forgot password ?"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        txtPassword.Location = New Point(540, 367)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(287, 45)
        txtPassword.TabIndex = 12
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        txtName.Location = New Point(540, 315)
        txtName.Name = "txtName"
        txtName.Size = New Size(287, 45)
        txtName.TabIndex = 11
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(344, 367)
        Label8.Name = "Label8"
        Label8.Size = New Size(175, 39)
        Label8.TabIndex = 10
        Label8.Text = "Password"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(344, 315)
        Label9.Name = "Label9"
        Label9.Size = New Size(108, 39)
        Label9.TabIndex = 9
        Label9.Text = "Email"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(532, 260)
        Label10.Name = "Label10"
        Label10.Size = New Size(116, 39)
        Label10.TabIndex = 8
        Label10.Text = "Log in"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1426, 655)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLOGIN As Button
    Friend WithEvents register As Label
    Friend WithEvents forgotpassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

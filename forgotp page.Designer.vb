<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forgotp_page
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
        Label1 = New Label()
        txtemail = New TextBox()
        txtpass = New TextBox()
        Label2 = New Label()
        txtpassw = New TextBox()
        Label3 = New Label()
        btnBack = New Button()
        btnSubmit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label1.Location = New Point(185, 105)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 20)
        Label1.TabIndex = 0
        Label1.Text = "Email"
        ' 
        ' txtemail
        ' 
        txtemail.Location = New Point(351, 105)
        txtemail.Name = "txtemail"
        txtemail.Size = New Size(125, 27)
        txtemail.TabIndex = 1
        ' 
        ' txtpass
        ' 
        txtpass.Location = New Point(351, 165)
        txtpass.Name = "txtpass"
        txtpass.Size = New Size(125, 27)
        txtpass.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label2.Location = New Point(185, 172)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 20)
        Label2.TabIndex = 2
        Label2.Text = "New Password"
        ' 
        ' txtpassw
        ' 
        txtpassw.Location = New Point(351, 233)
        txtpassw.Name = "txtpassw"
        txtpassw.Size = New Size(125, 27)
        txtpassw.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label3.Location = New Point(185, 240)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 20)
        Label3.TabIndex = 4
        Label3.Text = "Comfrm Pawword"
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnBack.Location = New Point(171, 341)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(141, 49)
        btnBack.TabIndex = 6
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnSubmit.Location = New Point(424, 341)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(134, 49)
        btnSubmit.TabIndex = 7
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' forgotp_page
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._642057f39a0100e7ecc84daa_640f877a2868a2e6ac8d6749_farm_equipment
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1162, 504)
        Controls.Add(btnSubmit)
        Controls.Add(btnBack)
        Controls.Add(txtpassw)
        Controls.Add(Label3)
        Controls.Add(txtpass)
        Controls.Add(Label2)
        Controls.Add(txtemail)
        Controls.Add(Label1)
        Name = "forgotp_page"
        Text = "forgotp_page"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpassw As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnSubmit As Button
End Class

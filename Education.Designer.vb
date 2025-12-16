<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Education
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Education))
        Label1 = New Label()
        RichTextBox1 = New RichTextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(415, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(773, 26)
        Label1.TabIndex = 0
        Label1.Text = "The Lifecycle of a Crop: 7 Steps in the Modern Farming Ecosystem"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(23, 61)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(1776, 806)
        RichTextBox1.TabIndex = 2
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(690, 903)
        Button1.Name = "Button1"
        Button1.Size = New Size(188, 64)
        Button1.TabIndex = 3
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Education
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._642057f39a0100e7ecc84daa_640f877a2868a2e6ac8d6749_farm_equipment
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1821, 979)
        Controls.Add(Button1)
        Controls.Add(RichTextBox1)
        Controls.Add(Label1)
        Name = "Education"
        Text = "Education"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class

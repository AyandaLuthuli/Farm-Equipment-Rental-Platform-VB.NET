Public Class hirepage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        home_page.Show()
    End Sub

    Private Sub hirepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = 3
        TextBox2.Text = 7500
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

    End Sub
End Class
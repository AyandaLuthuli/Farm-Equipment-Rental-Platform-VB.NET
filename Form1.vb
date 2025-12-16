Public Class Form1


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLOGIN.Click
        If txtName.Text.Trim = "" Then
            MsgBox("Enter your email")
            txtName.Focus()
            Exit Sub

        End If

        If txtPassword.Text.Trim = "" Then
            MsgBox("Enter your password")
            txtPassword.Focus()
            Exit Sub

        Else
            Me.Hide()
            home_page.Show()
        End If


    End Sub



    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles register.Click
        Me.Hide()
        registration.Show()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles forgotpassword.Click
        Me.Hide()
        forgotp_page.Show()
    End Sub


    Public Function isNumber(textbox As String) As Boolean

        If IsNumeric(textbox) = True Then
            Return True
        Else
            Return False

        End If
    End Function

    Public Function beginWith(textbox As String) As Boolean

        If textbox.StartsWith(0) = True Then
            Return True
        Else
            Return False

        End If
    End Function


    Public Function isLength(textbox As String) As Boolean

        If textbox.Length <> 10 Then
            Return True
        Else
            Return False

        End If
    End Function

    Public Function isAlpha(textbox As String) As Boolean

        For i = 0 To textbox.Length - 1
            Select Case textbox.Substring(1, i)
                Case "a" To "z", "A" To "Z", ""
                    Return True
                Case Else
                    Return False
            End Select
        Next
        Return True
    End Function


    Private Function Isempty(textbox As String) As Boolean
        Dim results As Boolean
        If textbox.Trim = " " Then
            results = True
        Else
            results = False


        End If
        Return results

    End Function


    Private Function isnotempty(value As String) As Boolean
        Return False
        String.IsNullOrEmpty(value)


    End Function

End Class




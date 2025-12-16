Public Class forgotp_page
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If Isempty(txtemail.Text) = True Then
            MsgBox("please enter your email ")
            txtemail.Focus()
            Exit Sub
        End If
        If Isempty(txtpass.Text) = True Then
            MsgBox("please enter new password")
            txtpass.Focus()
            Exit Sub
        End If
        If Isempty(txtpassw.Text) = True Then
            MsgBox("please enter Comfrm Pawword")
            txtpassw.Focus()
            Exit Sub
        End If



        If txtpass.Text = txtpassw.Text Then
            MsgBox("you have successfully changed your password")
            Me.Hide()
            Form1.Show()

        Else

            MsgBox("passwords do not match")

        End If



    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Form1.Show()
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
        If textbox.Trim = "" Then
            results = True
        Else
            results = False


        End If
        Return results
    End Function
End Class
Public Class registration





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnsub.Click

        If isAlpha(txtName.Text) = False Then
            MsgBox("Name should be alphabetic only")
            txtName.Focus()
            Exit Sub
        End If

        If noSpace(txtName.Text) = True Then
            MsgBox("Enter name")
            txtName.Focus()
            Exit Sub
        End If

        If noSpace(txtemail.Text) = True Then
            MsgBox("email address is left empty")
            txtemail.Focus()
            Exit Sub
        End If

        If txtcell.Text.Trim = "" Then
            MsgBox("Enter Cell Number")
            txtcell.Focus()
            Exit Sub
        End If



        Dim cell As String = txtcell.Text
        If IsNumeric(cell) Then

        Else
            MsgBox("cellphone should be numberic")
        End If

        If beginWith(txtcell.Text) = False Then
            MsgBox("Cell Number should start with zero")
            txtcell.Focus()
            Exit Sub
        End If





        If noSpace(txtadd.Text) = True Then
            MsgBox("Address is left empty")
            txtadd.Focus()
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

            MsgBox("you have successfully registed")
            Me.Hide()
            Form1.Show()
        Else

            MsgBox("passwords do not match")

        End If








    End Sub

    Private Function Isempty(textbox As String) As Boolean
        Dim results As Boolean
        If textbox.Trim = "" Then
            results = True
        Else
            results = False


        End If
        Return results
    End Function

    Private Sub btnLOGIN_Click(sender As Object, e As EventArgs) Handles btnLOGIN.Click
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

    Public Function noSpace(textbox As String) As Boolean

        If textbox.Trim = "" Then
            Return True
        Else
            Return False

        End If
    End Function


End Class
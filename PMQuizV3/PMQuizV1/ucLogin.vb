Public Class ucLogin

    Dim ucLoad As MainForm

    'Does a check to see if a key has been pressed when the user is in the password textbox
    Private Sub PassTxt_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles PassTxt.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            Call LoginBtn_Click(sender, e)
        End If 'When the user presses enter button in the password textbox it runs the login button

    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click

        Dim dtAdmin, dtStudent As New DataTable 'Creates 2 datatable variables
        dtAdmin = runSQL("Select * from AdminData where TUserN = '" & UsrNmeTxt.Text & "' and TPass = '" & PassTxt.Text & "'")
        dtStudent = runSQL("Select * from StudentData where SUserN = '" & UsrNmeTxt.Text & "' and SPass = '" & PassTxt.Text & "'")
        'Extracts all the Usernames and Passwords from the Admin and Student Tables

        If dtStudent.Rows.Count = 1 Then
            ucLoad = Me.Parent 'Sets ucLoad to the parent of main form which allows ucLoad to access AddUC
            ucLoad.addUC("ucMainMenu") 'Puts this string into the subroutine AddUC which determines which user control to load
            Me.Dispose() 'Gets rid of the user control
            GC.Collect() 'Gather all the remaining data left after closing the user control
            Details.LoginUser = dtStudent.Rows(0)(0) 'Saves the SUserN on the student row to be used later
            Details.UserTID = dtStudent.Rows(0)(2) 'Saves the TID on the student row to be used later
        ElseIf dtAdmin.Rows.Count = 1 Then
            ucLoad = Me.Parent 'Sets ucLoad to the parent of main form which allows ucLoad to access AddUC
            ucLoad.addUC("ucAdminMainMenu") 'Puts this string into the subroutine AddUC which determines which user control to load
            Me.Dispose() 'Gets rid of the user control
            GC.Collect() 'Gather all the remaining data left after closing the user control
            Details.LoginUser = dtAdmin.Rows(0)(1) 'Saves the TUserN on the admin row to be used later
            Details.UserTID = dtAdmin.Rows(0)(0) 'Saves the TID on the admin row to be used later
        Else
            MsgBox("Your details have been entered incorrectly, please try again")
        End If

    End Sub

    Private Sub NewAccBtn_Click(sender As Object, e As EventArgs) Handles NewAccBtn.Click
        ucLoad = Me.Parent 'Sets ucLoad to the parent of main form which allows ucLoad to access AddUC
        ucLoad.addUC("ucCreateAcc") 'Puts this string into the subroutine AddUC which determines which user control to load
        Me.Dispose() 'Gets rid of the user control
        GC.Collect() 'Gather all the remaining data left after closing the user control
    End Sub
End Class

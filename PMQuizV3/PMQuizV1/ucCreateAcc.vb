Public Class CreateAccBtn
    Private Sub NewAccBtn_Click(sender As Object, e As EventArgs) Handles NewAccBtn.Click
        'All the if statements in this sub routine are forms of validation which stop the user from creating a new account

        Dim dtCreateAcc As DataTable 'Creates the table dtCreateAcc, a copy of the student table in the database

        If NPassTxt.Text <> NPass2Txt.Text Then
            MsgBox("Password do not match")
            Exit Sub
        End If
        'If the text in the NPass textbox and NPass2 textbox do not match then it exits the sub routine

        dtCreateAcc = runSQL("Select * from AdminData where TID = '" & TIDTxt.Text & "'")
        If dtCreateAcc.Rows.Count <> 1 Then
            MsgBox("Incorrect Teacher ID")
            Exit Sub
        End If
        'If the text in the TID textbox is not in the DataTable then it exits the sub routine 

        dtCreateAcc = runSQL("Select * from StudentData where SUserN = '" & NUsrNmeTxt.Text & "'")
        If dtCreateAcc.Rows.Count > 0 Then
            MsgBox("Account name already in use, please use another")
            Exit Sub
            'If the text in the NUsrNme textbox is already in the SUserN column of the DataTable then it exits the sub routine
        Else
            dtCreateAcc = runSQL("Insert into StudentData (SUserN, SPass, TID) values ('" & NUsrNmeTxt.Text &
                                 "','" & NPassTxt.Text & "','" & TIDTxt.Text & "')")
            MsgBox("New Account Added, you can now login")
        End If
        'If it is not already in that column then it adds the text from the three text boxes into the student table in the database

        Dim ucLoad As MainForm

        ucLoad = Me.Parent 'Sets ucLoad to the parent of main form which allows ucLoad to access AddUC
        ucLoad.addUC("ucLogin") 'Puts this string into the subroutine AddUC which determines which user control to load
        Me.Dispose() 'Gets rid of the user control
        GC.Collect() 'Gather all the remaining data left after closing the user control

    End Sub

    'Does a check to see if a key has been pressed when the user is in the password textbox
    Private Sub TIDTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles TIDTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call NewAccBtn_Click(sender, e)
        End If 'When the user presses enter button in the password textbox it runs the login button

    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Dim ucLoad As MainForm

        ucLoad = Me.Parent 'Sets ucLoad to the parent of main form which allows ucLoad to access AddUC
        ucLoad.addUC("ucLogin") 'Puts this string into the subroutine AddUC which determines which user control to load
        Me.Dispose() 'Gets rid of the user control
        GC.Collect() 'Gather all the remaining data left after closing the user control

    End Sub

End Class

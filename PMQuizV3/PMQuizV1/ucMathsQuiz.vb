Public Class ucMathsQuiz

    Dim ucLoad As MainForm

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click

        If MsgBox("Are you sure you want to leave, your quiz score won't be saved? ", MsgBoxStyle.YesNo, "Maths Quiz") = MsgBoxResult.Yes Then

            ucLoad = Me.Parent 'Sets ucLoad to the parent of main form which allows ucLoad to access AddUC
            ucLoad.addUC("ucMainMenu") 'Puts this string into the subroutine AddUC which determines which user control to load
            Me.Dispose() 'Gets rid of the user control
            GC.Collect() 'Gather all the remaining data left after closing the user control

        End If
    End Sub

    Private Sub ucMathsQuiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dtLdQtn As DataTable 'Assigns the datatable to a variable
        Dim RowAmount, ranNum As Integer 'Creates 2 integer variables

        dtLdQtn = runSQL("Select * from MQuestions") 'Loads the MQuestion field from the MQuestions table in the access database
        RowAmount = dtLdQtn.Rows.Count 'Counts the amount of rows in the table and assigns the integer to RowAmount
        Randomize()
        ranNum = Rnd() * (RowAmount - 1) 'This generates a random number from how many rows there was
        QtnLbl.Text = dtLdQtn.Rows(ranNum)(0) 'The question label prints off a random question from the table

        Dim ARanArray() As Integer = {1, 2, 3, 4} 'Creates an Array full of integers between 1 and 4
        Dim tempAns As String 'Creates the tempory string variable
        Dim ARnd1, ARnd2 As Integer 'Creates 2 integer variables

        For x = 0 To 9 'Loops 10 times

            Randomize()
            ARnd1 = CInt(Rnd() * 3) 'Chooses a random number between 0 and 3 and assigns it to the first integer variable
            Randomize()
            ARnd2 = CInt(Rnd() * 3) 'Chooses a random number between 0 and 3 and assagns it to the second integer variable

            tempAns = ARanArray(ARnd1) 'The string variable now contains the a part of the array thats a value of rnd1 along
            ARanArray(ARnd1) = ARanArray(ARnd2) 'The value that was contained in that part of the array is now equal to the value that was in the array rnd2 along
            ARanArray(ARnd2) = tempAns 'Now the value of the original rn1 is now placed into the array rnd2 along
            'It has now swapped the two numbers around within the array
        Next
        'This loop therefore swaps different numbers 10 times essentially a shuffling the array

        Rbtn1.Text = dtLdQtn.Rows(ranNum)(ARanArray(0))
        RBtn2.Text = dtLdQtn.Rows(ranNum)(ARanArray(1))
        RBtn3.Text = dtLdQtn.Rows(ranNum)(ARanArray(2))
        RBtn4.Text = dtLdQtn.Rows(ranNum)(ARanArray(3))
        'Loads all the answers within the array and equals them to the radio button text's
        Details.QtnTotal += 1
        QNumLbl.Text = CStr(Details.QtnTotal)
        FeedBackLd()

    End Sub

    Public Sub AnsBtn_Click(sender As Object, e As EventArgs) Handles AnsBtn.Click

        Dim dtLdAns As New DataTable

        If Rbtn1.Checked Then 'If the 1st radio button is ticked then
            dtLdAns = runSQL("Select * from MQuestions where MA1 = '" & Rbtn1.Text & "'") 'Loads from the database the rows which have the MA1 value equal to the radiobutton text
            If dtLdAns.Rows.Count > 0 Then 'If there is more than 0 rows left then it outputs a message saying they are correct
                MsgBox("                         CORRECT! 
            
                Onto The Next Question  ")
                Details.QtnRight += 1 'If this message box is displayed then the question right variable increments
            Else
                MsgBox("                        INCORRECT!
                
                Onto The Next Question   ")
            End If
        End If

        If RBtn2.Checked Then 'Same but with the 2nd radio button
            dtLdAns = runSQL("Select * from MQuestions where MA1 = '" & RBtn2.Text & "'")
            If dtLdAns.Rows.Count > 0 Then
                MsgBox("                         CORRECT! 
            
                Onto The Next Question  ")
                Details.QtnRight += 1
            Else
                MsgBox("                        INCORRECT!
                
                Onto The Next Question   ")
            End If
        End If

        If RBtn3.Checked Then 'Same but with the 3rd radio button
            dtLdAns = runSQL("Select * from MQuestions where MA1 = '" & RBtn3.Text & "'")
            If dtLdAns.Rows.Count > 0 Then
                MsgBox("                         CORRECT! 
            
                Onto The Next Question  ")
                Details.QtnRight += 1
            Else
                MsgBox("                        INCORRECT!
                
                Onto The Next Question   ")
            End If
        End If

        If RBtn4.Checked Then 'Same but with the 4th radio button
            dtLdAns = runSQL("Select * from MQuestions where MA1 = '" & RBtn4.Text & "'")
            If dtLdAns.Rows.Count > 0 Then
                MsgBox("                         CORRECT! 
            
                Onto The Next Question  ")
                Details.QtnRight += 1
            Else
                MsgBox("                        INCORRECT!
                
                Onto The Next Question   ")
            End If
        End If

        ucLoad = Me.Parent 'Sets ucLoad to the parent of main form which allows ucLoad to access AddUC
        ucLoad.addUC("ucMathsQuiz") 'Puts this string into the subroutine AddUC which determines which user control to load
        Me.Dispose() 'Gets rid of the user control
        GC.Collect() 'Gather all the remaining data left after closing the user control

    End Sub

    Private Sub FeedBackLd()
        If Details.QtnTotal = 21 Then
            ucLoad = Me.Parent 'Sets ucLoad to the parent of main form which allows ucLoad to access AddUC
            ucLoad.addUC("ucMathsFeedback") 'Puts this string into the subroutine AddUC which determines which user control to load
            Me.Dispose() 'Gets rid of the user control
            GC.Collect() 'Gather all the remaining data left after closing the user control
        End If
    End Sub

End Class
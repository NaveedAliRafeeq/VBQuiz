Public Class ucEditQuestions

    Dim ucLoad As MainForm
    Dim DeleteUser As String 'The Username of the account the admin wishes to delete

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click

        ucLoad = Me.Parent 'Sets ucLoad to the parent of main form which allows ucLoad to access AddUC
        ucLoad.addUC("ucAdminMainMenu") 'Puts this string into the subroutine AddUC which determines which user control to load
        Me.Dispose() 'Gets rid of the user control
        GC.Collect() 'Gather all the remaining data left after closing the user control                               

    End Sub

    Private Sub UserList() 'Sub that loads all students in with matching TID's as the admin

        Dim dt As New DataTable 'Copies a table within the database into vb to be edited and then updated

        dt = runSQL("SELECT SUserN, SPass from StudentData where TID = '" & Details.UserTID & "' ORDER BY SUserN ASC;")
        'Loads all the users with their usernames and passwords into the DataTable

        For x = 0 To dt.Rows.Count - 1
            Dim items(1) As String '1 dimensional array with 2 values
            items(0) = dt.Rows(x)(0) 'Username
            items(1) = dt.Rows(x)(1) 'Password
            'Adds the username and password into the row

            Dim LineNew As New ListViewItem(items) 'Assigns the contents of the items array into the LineNew
            UserLst.Items.Add(LineNew) 'Adds the new line into the List View
        Next 'Loop repeats for each row of the table
    End Sub

    Private Sub MQuestionsList() 'Sub that loads all the questions and answers from the MQuestions table into the List View

        Dim dt As New DataTable 'Copies a table within the database into vb to be edited and then updated
        dt = runSQL("SELECT * FROM MQuestions ORDER BY MQuestion ASC;")
        'Loads everything from the MQuestions table in ascending order

        For x = 0 To dt.Rows.Count - 1
            Dim items(4) As String '1 dimensional array with 5 values
            items(0) = dt.Rows(x)(0) 'Question
            items(1) = dt.Rows(x)(1) 'Correct Answer
            items(2) = dt.Rows(x)(2) 'Answer 2
            items(3) = dt.Rows(x)(3) 'Answer 3
            items(4) = dt.Rows(x)(4) 'Answer 4

            Dim LineNew As New ListViewItem(items) 'Assigns the contents of the items array into the LineNew
            MQtnLst.Items.Add(LineNew) 'Adds the new line into the List View
        Next 'Loop repeats for each row of the table
    End Sub

    Private Sub PQuestionsList() 'Sub that loads all the questions and answers from the PQuestions table into the List View

        Dim dt As New DataTable 'Copies a table within the database into vb to be edited and then updated
        dt = runSQL("SELECT * FROM PQuestions ORDER BY PQuestion ASC;")
        'Loads everything from the PQuestions table in ascending order

        For x = 0 To dt.Rows.Count - 1
            Dim items(4) As String '1 dimensional array with 5 values
            items(0) = dt.Rows(x)(0) 'Question
            items(1) = dt.Rows(x)(1) 'Correct Answer
            items(2) = dt.Rows(x)(2) 'Answer 2
            items(3) = dt.Rows(x)(3) 'Answer 3
            items(4) = dt.Rows(x)(4) 'Answer 4

            Dim LineNew As New ListViewItem(items) 'Assigns the contents of the items array into the LineNew
            PQtnLst.Items.Add(LineNew) 'Adds the new line into the List View
        Next 'Loop repeats for each row of the table
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles DeleteUserBtn.Click
        'Button that deletes everything of the user selected

        runSQL("DELETE * FROM StudentData WHERE SUserN = '" & DeleteUser & "'") 'Deletes whole row from StudentData table
        runSQL("DELETE * FROM MResults WHERE SUserN = '" & DeleteUser & "'") 'Deletes whole row from MResults table
        runSQL("DELETE * FROM PResults WHERE SUserN = '" & DeleteUser & "'") 'Deletes whole row from PResult table
        MsgBox("User has been deleted")

        'Updates the List View
        UserLst.Items.Clear() 'Clear all the items from the List View
        UserList() 'Loads all the items again
    End Sub

    Private Sub MRefreshBtn_Click(sender As Object, e As EventArgs) Handles MRefreshBtn.Click
        'This sub updates the Maths question by deleting it from the Maths Question table then adding it again

        Try
            runSQL("DELETE * FROM MQuestions WHERE MQuestion = '" & MQtnLst.SelectedItems(0).SubItems(0).Text & "'")
            runSQL("INSERT into MQuestions (MQuestion, MA1, MA2, MA3, MA4) values ('" & Qtntxt.Text & "','" &
                   A1txt.Text & "','" & A2txt.Text & "','" & A3txt.Text & "','" & A4txt.Text & "')")
            'Deletes the whole row in the Maths Question table that contains the question selected
            'Adds the question and the 4 answers within the textboxes into the same table

            'Updates the listview
            MQtnLst.Items.Clear() 'Deletes all the items from the listview
            MQuestionsList() 'Runs the sub routine to load the new MQuestion table
            MsgBox("Question Edited!") 'Message box informing the user that the question has been updated

        Catch ex As Exception
            'The try statement allows the program not to crash when an item in the listview is not selected
            'It works by the program trying to perform the the sql instructions but if it can't then it just makes the button do nothing
        End Try
    End Sub

    Private Sub PRefreshBtn_Click(sender As Object, e As EventArgs) Handles PRefreshBtn.Click
        'This sub updates the Physics question by deleting it from the Physics Question table then adding it again

        Try
            runSQL("DELETE * FROM PQuestions WHERE PQuestion = '" & PQtnLst.SelectedItems(0).SubItems(0).Text & "'")
            runSQL("INSERT into PQuestions (PQuestion, PA1, PA2, PA3, PA4) values ('" & Qtntxt.Text & "','" &
                       A1txt.Text & "','" & A2txt.Text & "','" & A3txt.Text & "','" & A4txt.Text & "')")
            'Deletes the whole row in the Physics Question table that contains the question selected
            'Adds the question and the 4 answers within the textboxes into the same table

            'Updates the listview
            PQtnLst.Items.Clear() 'Deletes all the items from the listview
            PQuestionsList() 'Runs the sub routine to load the new PQuestion table
            MsgBox("Question Edited!") 'Message box informing the user that the question has been edited

        Catch ex As Exception
            'The try statement allows the program not to crash when an item in the listview is not selected
            'It works by the program trying to perform the the sql instructions but if it can't then it just makes the button do nothing
        End Try
    End Sub

    Private Sub MQtnAddBtn_Click(sender As Object, e As EventArgs) Handles MQtnAddBtn.Click
        'Sub that adds the Maths Question to the Maths Questions table when they click the Add button

        Try
            runSQL("INSERT into MQuestions (MQuestion, MA1, MA2, MA3, MA4) values ('" & Qtntxt.Text & "','" &
                   A1txt.Text & "','" & A2txt.Text & "','" & A3txt.Text & "','" & A4txt.Text & "')")
            'Adds the question and the 4 answers within the textboxes into the Maths Question table

            'Updates the listview
            MQtnLst.Items.Clear() 'Deletes all the items from the listview
            MQuestionsList() 'Runs the sub routine to load the new MQuestion table
            MsgBox("Question Added!") 'Message box informing the user that the question has been added

        Catch ex As Exception
            'The try statement allows the program not to crash when an item in the listview is not selected
            'It works by the program trying to perform the the sql instructions but if it can't then it just makes the button do nothing
        End Try
    End Sub

    Private Sub PQtnAddBtn_Click(sender As Object, e As EventArgs) Handles PQtnAddBtn.Click
        'Sub does the same as the one above but with the Physics questions table

        Try
            runSQL("INSERT into PQuestions (PQuestion, PA1, PA2, PA3, PA4) values ('" & Qtntxt.Text & "','" &
           A1txt.Text & "','" & A2txt.Text & "','" & A3txt.Text & "','" & A4txt.Text & "')")

            PQtnLst.Items.Clear()
            PQuestionsList()
            MsgBox("Question Added!")

        Catch ex As Exception
        End Try
    End Sub

    Private Sub MQtnDeleteBtn_Click(sender As Object, e As EventArgs) Handles MQtnDeleteBtn.Click
        'Sub that deletes the Maths question from the Maths Question Table

        Dim DeletedCheck As Boolean = False 'Creates the false boolean value that will be used to with deleting the user

        Try
            If MsgBox("Are you sure you want to delete this question? ", MsgBoxStyle.YesNo, "Delete Question") = MsgBoxResult.Yes Then
                runSQL("DELETE * FROM MQuestions WHERE MQuestion = '" & MQtnLst.SelectedItems(0).SubItems(0).Text & "'")
                'If the user chooses the yes option in the message box then 
                'It deletes the whole row from the Maths Question table that contains the question selected in the list view
                DeletedCheck = True 'Turns the boolean variable into true

                'Updates the listview
                MQtnLst.Items.Clear() 'Deletes all the items from the listview
                MQuestionsList() 'Runs the sub routine to load the new MQuestion table
            End If
            'If they choose No then the question would not be deleted and the message box will close

            If DeletedCheck = True Then
                MsgBox("Question Deleted!")
            End If
            'If the user choose yes in the user box it shows this message box afterwards informing the user that the question has been deleted

        Catch ex As Exception
            'The try statement allows the program not to crash when an item in the listview is not selected
            'It works by the program trying to perform the the sql instructions but if it can't then it just makes the button do nothing
        End Try
    End Sub

    Private Sub PQtnDeleteBtn_Click(sender As Object, e As EventArgs) Handles PQtnDeleteBtn.Click
        'Same sub as above but deletes from the Physics Question table
        Dim DeletedCheck As Boolean = False

        Try
            If MsgBox("Are you sure you want to delete this question? ", MsgBoxStyle.YesNo, "Delete Question") = MsgBoxResult.Yes Then
                runSQL("DELETE * FROM PQuestions WHERE PQuestion = '" & PQtnLst.SelectedItems(0).SubItems(0).Text & "'")
                DeletedCheck = True
                PQtnLst.Items.Clear()
                PQuestionsList()
            End If

            If DeletedCheck = True Then
                MsgBox("Question Deleted!")
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub MQtnLst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MQtnLst.Click
        'Sub that fills the textboxes with the row clicked in the Maths List View

        Qtntxt.Text = MQtnLst.SelectedItems(0).SubItems(0).Text 'Fills textbox with the Question
        A1txt.Text = MQtnLst.SelectedItems(0).SubItems(1).Text 'Fills textbox with the Right Answer
        A2txt.Text = MQtnLst.SelectedItems(0).SubItems(2).Text 'Fills textbox with Answer 2
        A3txt.Text = MQtnLst.SelectedItems(0).SubItems(3).Text 'Fills textbox with Answer 3
        A4txt.Text = MQtnLst.SelectedItems(0).SubItems(4).Text 'Fills textbox with Answer 4

    End Sub

    Private Sub PQtnLst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PQtnLst.Click
        'Sub that fills the textboxes with the row clicked in the Physics List View

        Qtntxt.Text = PQtnLst.SelectedItems(0).SubItems(0).Text 'Fills textbox with the Question
        A1txt.Text = PQtnLst.SelectedItems(0).SubItems(1).Text 'Fills textbox with the Right Answer
        A2txt.Text = PQtnLst.SelectedItems(0).SubItems(2).Text 'Fills textbox with Answer 2
        A3txt.Text = PQtnLst.SelectedItems(0).SubItems(3).Text 'Fills textbox with Answer 3
        A4txt.Text = PQtnLst.SelectedItems(0).SubItems(4).Text 'Fills textbox with Answer 4

    End Sub

    Private Sub UsrLst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UserLst.Click
        DeleteUser = UserLst.SelectedItems(0).SubItems(0).Text 'The selected users username is now equal to the variable
    End Sub

    Private Sub UsrLstBtn_MouseEnter(sender As Object, e As EventArgs) Handles UsrLstBtn.MouseEnter
        UsrLstBtn.BackgroundImage = My.Resources.BgBlurSmall
        'This sub loads a different image when the mouse hovers over the Delete User button
    End Sub

    Private Sub MQtnBtn_MouseEnter(sender As Object, e As EventArgs) Handles MQtnbtn.MouseEnter
        MQtnbtn.BackgroundImage = My.Resources.BgBlurSmall
        'Same as the above but with the Edit Maths Questions button
    End Sub

    Private Sub PQtnBtn_MouseEnter(sender As Object, e As EventArgs) Handles PQtnbtn.MouseEnter
        PQtnbtn.BackgroundImage = My.Resources.BgBlurSmall
        'Same as the above but with the Edit Physics Questions button
    End Sub

    Private Sub ucEditQuestions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When the UC loads it hides the List Views and the Back to Edit Page button

        UsrLstHide() 'Sub that hides the User List View and its delete button
        MQtnHide() 'Sub that hides the Maths Question List View, the text boxes and its buttons
        PQtnHide() 'Sub that hides the Physics Question List View, the text boxes and its buttons
        EditBtn.Visible = False 'Edit button is hidden
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        'Sub that hides all the list views and makes the menu buttons visible when the Edit button is clicked

        BtnsShow() 'Sub that makes the menu buttons visible
        UsrLstHide() 'Sub that hides the User List View and its delete button
        MQtnHide() 'Sub that hides the Maths Question List View, the text boxes and its buttons
        PQtnHide() 'Sub that hides the Physics Question List View, the text boxes and its buttons
        BackBtn.Visible = True 'Back button is visible
        EditBtn.Visible = False 'Edit button is hidden
        TitleLbl.Location = New Point(263, 27) 'Moves the Title back to its original position
    End Sub

    Private Sub UsrLstBtn_Click(sender As Object, e As EventArgs) Handles UsrLstBtn.Click
        'Sub that loads the User List when the Delete User button is clicked

        UsrLstShow() 'Sub that loads the User List View and its delete button
        BtnsHide() 'Sub that hides the menu buttons
        EditBtn.Visible = True 'Edit button is visible
        BackBtn.Visible = False 'Back button is hidden
    End Sub

    Private Sub MQtnbtn_Click(sender As Object, e As EventArgs) Handles MQtnbtn.Click
        'Sub that loads the Maths Question List View, the text boxes and its buttons when the 
        'Edit Maths Questions button is clicked

        MQtnShow() 'Sub that loads the Maths User List View and its delete button
        BtnsHide() 'Sub that hides the menu buttons
        EditBtn.Visible = True 'Edit button is visible
        BackBtn.Visible = False 'Back button is hidden
        TitleLbl.Location = New Point(15, 35) 'Moves the title to a new position
    End Sub

    Private Sub PQtnbtn_Click(sender As Object, e As EventArgs) Handles PQtnbtn.Click
        'Sub that does the same as above but with the Physics counterpart
        PQtnShow()
        BtnsHide()
        EditBtn.Visible = True
        BackBtn.Visible = False
        TitleLbl.Location = New Point(15, 35)
    End Sub

    Private Sub BtnsShow() 'Sub that loads the menu buttons
        UsrLstBtn.Visible = True
        MQtnbtn.Visible = True
        PQtnbtn.Visible = True
    End Sub

    Private Sub BtnsHide() 'Sub that hides the menu buttons
        UsrLstBtn.Visible = False
        MQtnbtn.Visible = False
        PQtnbtn.Visible = False
    End Sub

    Private Sub UsrLstHide() 'Sub that hides the User List and its delete user button
        UserLst.Visible = False
        DeleteUserBtn.Visible = False
        UserLst.Items.Clear()
    End Sub

    Private Sub UsrLstShow() 'Sub that loads the User List and its delete user button
        UserLst.Visible = True
        DeleteUserBtn.Visible = True
        UserList()
    End Sub

    Private Sub MQtnHide() 'Sub that hides the Maths Question List View, the text boxes and its buttons
        MQtnLst.Visible = False
        Qtntxt.Visible = False
        A1txt.Visible = False
        A2txt.Visible = False
        A3txt.Visible = False
        A4txt.Visible = False
        QtnLbl.Visible = False
        A1Lbl.Visible = False
        A2Lbl.Visible = False
        A3Lbl.Visible = False
        A4Lbl.Visible = False
        MRefreshBtn.Visible = False
        MQtnAddBtn.Visible = False
        MQtnDeleteBtn.Visible = False
        MQtnLst.Items.Clear() 'Clears all the items from the List View so that duplicate values will not 
        'be there when it is next loaded
    End Sub

    Private Sub MQtnShow() 'Sub that loads the Maths Question List View, the text boxes and its buttons
        MQtnLst.Visible = True
        Qtntxt.Visible = True
        A1txt.Visible = True
        A2txt.Visible = True
        A3txt.Visible = True
        A4txt.Visible = True
        QtnLbl.Visible = True
        A1Lbl.Visible = True
        A2Lbl.Visible = True
        A3Lbl.Visible = True
        A4Lbl.Visible = True
        MRefreshBtn.Visible = True
        MQtnAddBtn.Visible = True
        MQtnDeleteBtn.Visible = True
        MQuestionsList() 'Sub that fills the List View with the Maths Questions
    End Sub

    Private Sub PQtnHide() 'Sub that hides the Physics Question List View, the text boxes and its buttons
        PQtnLst.Visible = False
        Qtntxt.Visible = False
        A1txt.Visible = False
        A2txt.Visible = False
        A3txt.Visible = False
        A4txt.Visible = False
        QtnLbl.Visible = False
        A1Lbl.Visible = False
        A2Lbl.Visible = False
        A3Lbl.Visible = False
        A4Lbl.Visible = False
        PRefreshBtn.Visible = False
        PQtnAddBtn.Visible = False
        PQtnDeleteBtn.Visible = False
        PQtnLst.Items.Clear() 'Clears all the items from the List View so that duplicate values will not 
        'be there when it is next loaded
    End Sub

    Private Sub PQtnShow() 'Sub that loads the Physics Question List View, the text boxes and its buttons
        PQtnLst.Visible = True
        Qtntxt.Visible = True
        A1txt.Visible = True
        A2txt.Visible = True
        A3txt.Visible = True
        A4txt.Visible = True
        QtnLbl.Visible = True
        A1Lbl.Visible = True
        A2Lbl.Visible = True
        A3Lbl.Visible = True
        A4Lbl.Visible = True
        PRefreshBtn.Visible = True
        PQtnAddBtn.Visible = True
        PQtnDeleteBtn.Visible = True
        PQuestionsList() 'Sub that fills the List View with the Physics Questions
    End Sub
End Class

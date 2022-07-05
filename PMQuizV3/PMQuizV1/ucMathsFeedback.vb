Public Class ucMathsFeedback

    Dim ucLoad As MainForm

    Private Sub ucMathsFeedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        QtnRLbl.Text = Details.QtnRight 'The total questions the user got correct is assigned to the label

        Select Case Details.QtnRight 'The select case assigns a grade and a message to each value of QtnRight global variable
            Case Is > 17
                GrdLbl.Text = "A*"
                FBackLbl.Text = "You're A Genius"
            Case Is = 16 Or 17
                GrdLbl.Text = "A"
                FBackLbl.Text = "Pretty Good"
            Case Is = 14 Or 15
                GrdLbl.Text = "B"
                FBackLbl.Text = "Decent"
            Case Is = 12 Or 13
                GrdLbl.Text = "C"
                FBackLbl.Text = "You Passed"
            Case Is = 10 Or 11
                GrdLbl.Text = "D"
                FBackLbl.Text = "You Can Do Better"
            Case Is = 8 Or 9
                GrdLbl.Text = "E"
                FBackLbl.Text = "Unlucky"
            Case Is < 8
                GrdLbl.Text = "U"
                FBackLbl.Text = "Do the test again"
        End Select

        LstScore.Visible = False 'The list view is hidden
        FeedBtn.Visible = False 'The button to send you back to the feedback is hidden

        Dim dtScore As New DataTable 'Copies a table within the database into vb to be edited and then updated

        dtScore = runSQL("SELECT * from MResults where SUserN = '" & Details.LoginUser & "'")
        'Loads the query, which is the row equal to the username used when logging in, into the Data Table 
        If dtScore.Rows.Count > 0 Then 'If there is atleeast a row in the datatable
            runSQL("DELETE * FROM MResults where SUserN = '" & Details.LoginUser & "'")
            'Delete the row
            runSQL("INSERT into MResults (SUserN, Results, TID) values ('" & Details.LoginUser & "','" &
                   Details.QtnRight & "','" & Details.UserTID & "')")
            'Add the new row with the same username, TID but the updated score
        Else 'If there is no rows then
            runSQL("INSERT into MResults (SUserN, Results, TID) values ('" & Details.LoginUser & "','" &
                   Details.QtnRight & "','" & Details.UserTID & "')")
            'Add the new row with the username, TID and score
        End If

        ScoreLoad() 'Places the items into the List View

    End Sub

    Private Sub ScoreLoad() 'Sub that loads the items (Username and Physics score) into the List View

        Dim dt As New DataTable 'Copies a table within the database into vb to be edited and then updated
        dt = runSQL("SELECT * from MResults where TID = '" & Details.UserTID & "' ORDER BY Results DESC;")
        'Loads all the rows from the Physics Results table that are in a certain class into the Data Table
        'Orders them from highest to lowest, therefore making it a leader board

        For x = 0 To dt.Rows.Count - 1
            Dim items(1) As String '1 dimensional array with 2 values
            items(0) = dt.Rows(x)(0) 'Username
            items(1) = dt.Rows(x)(1) 'Score
            'Adds the username and score into the row

            Dim LineNew As New ListViewItem(items) 'Assigns the contents of the items array into the LineNew
            LstScore.Items.Add(LineNew) 'Adds the new line into the List View
        Next 'Loop repeats for each row of the table

    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click

        ucLoad = Me.Parent 'Sets ucLoad to the parent of main form which allows ucLoad to access AddUC
        ucLoad.addUC("ucMainMenu") 'Puts this string into the subroutine AddUC which determines which user control to load
        Me.Dispose() 'Gets rid of the user control
        GC.Collect() 'Gather all the remaining data left after closing the user control

    End Sub

    Private Sub LeadBtn_Click(sender As Object, e As EventArgs) Handles LeadBtn.Click

        'When the Leader Boards button is clicked the sub hides all the feeback text and the Leader board
        'button, then makes the listview and the Feedback button visible 
        LstScore.Visible = True
        FBackLbl.Visible = False
        Label2.Visible = False
        GrdLbl.Visible = False
        QtnRLbl.Visible = False
        Label3.Visible = False
        FeedBtn.Visible = True
        LeadBtn.Visible = False

    End Sub

    Private Sub FeedBtn_Click(sender As Object, e As EventArgs) Handles FeedBtn.Click

        'When the Leader Boards button is clicked the sub hides the listview and the Feedback button,' 
        'then makes the Feedback text and the Leader Board button visible 
        LstScore.Visible = False
        FBackLbl.Visible = True
        Label2.Visible = True
        GrdLbl.Visible = True
        QtnRLbl.Visible = True
        Label3.Visible = True
        FeedBtn.Visible = False
        LeadBtn.Visible = True

    End Sub
End Class

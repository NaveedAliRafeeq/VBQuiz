Public Class ucLeaderBoards

    Dim ucLoad As MainForm

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click

        ucLoad = Me.Parent 'Sets ucLoad to the parent of main form which allows ucLoad to access AddUC
        ucLoad.addUC("ucAdminMainMenu") 'Puts this string into the subroutine AddUC which determines which user control to load
        Me.Dispose() 'Gets rid of the user control
        GC.Collect() 'Gather all the remaining data left after closing the user control

    End Sub

    Private Sub MathsScoreLoad() 'Sub that places all of the Usernames and their adjacent Maths scores into the List View

        Dim dt As New DataTable 'Copies a table within the database into vb to be edited and then updated
        dt = runSQL("SELECT * from MResults where TID = '" & Details.UserTID & "' ORDER BY Results DESC;")
        'Loads all the rows that have the same TID as the one used to log in and places them into the Data Table

        For x = 0 To dt.Rows.Count - 1
            Dim items(1) As String '1 dimensional array with 2 values
            items(0) = dt.Rows(x)(0) 'Username
            items(1) = dt.Rows(x)(1) 'Score
            'Adds the username and password into the row

            Dim LineNew As New ListViewItem(items) 'Assigns the contents of the items array into the LineNew
            MLstScore.Items.Add(LineNew) 'Adds the new line into the List View
        Next 'Loop repeats for each row of the table
    End Sub

    Private Sub PhysicsScoreLoad() 'Sub that places all of the Usernames and their adjacent Physics scores into the List View

        Dim dt As New DataTable
        dt = runSQL("SELECT * from PResults where TID = '" & Details.UserTID & "' ORDER BY Results DESC;")
        'Loads all the rows that have the same TID as the one used to log in and places them into the Data Table

        For x = 0 To dt.Rows.Count - 1
            Dim items(1) As String '1 dimensional array with 2 values
            items(0) = dt.Rows(x)(0) 'Username
            items(1) = dt.Rows(x)(1) 'Score
            'Adds the username and password into the row

            Dim LineNew As New ListViewItem(items) 'Assigns the contents of the items array into the LineNew
            PLstScore.Items.Add(LineNew) 'Adds the new line into the List View
        Next 'Loop repeats for each row of the table
    End Sub

    Private Sub ucLeaderBoards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When the UC loads it runs the two subs that places the items within the leaderboards

        MathsScoreLoad()
        PhysicsScoreLoad()

    End Sub
End Class

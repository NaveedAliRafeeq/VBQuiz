Public Class ucAdminMainMenu

    Dim ucLoad As MainForm

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click

        ucLoad = Me.Parent 'Sets ucLoad to the parent of main form which allows ucLoad to access AddUC
        ucLoad.addUC("ucLogin") 'Puts this string into the subroutine AddUC which determines which user control to load
        Me.Dispose() 'Gets rid of the user control
        GC.Collect() 'Gather all the remaining data left after closing the user control

    End Sub

    Private Sub LeadBtn_MouseEnter(sender As Object, e As EventArgs) Handles Leadbtn.MouseEnter
        Leadbtn.BackgroundImage = My.Resources.BgBlurSmall
        'This sub loads a different image when the mouse hovers over the Maths Quiz button
    End Sub

    Private Sub EditBtn_MouseEnter(sender As Object, e As EventArgs) Handles EditBtn.MouseEnter
        EditBtn.BackgroundImage = My.Resources.BgBlurSmall
        'Same as the above but with the Edit Questions button Quiz button
    End Sub

    Private Sub Leadbtn_Click(sender As Object, e As EventArgs) Handles Leadbtn.Click

        ucLoad = Me.Parent 'Sets ucLoad to the parent of main form which allows ucLoad to access AddUC
        ucLoad.addUC("ucLeaderBoards") 'Puts this string into the subroutine AddUC which determines which user control to load
        Me.Dispose() 'Gets rid of the user control
        GC.Collect() 'Gather all the remaining data left after closing the user control

    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click

        ucLoad = Me.Parent 'Sets ucLoad to the parent of main form which allows ucLoad to access AddUC
        ucLoad.addUC("ucEditQuestions") 'Puts this string into the subroutine AddUC which determines which user control to load
        Me.Dispose() 'Gets rid of the user control
        GC.Collect() 'Gather all the remaining data left after closing the user control

    End Sub
End Class

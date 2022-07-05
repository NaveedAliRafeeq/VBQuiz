Public Class ucMainMenu

    Dim ucLoad As MainForm

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click

        ucLoad = Me.Parent 'Sets ucLoad to the parent of main form which allows ucLoad to access AddUC
        ucLoad.addUC("ucLogin") 'Puts this string into the subroutine AddUC which determines which user control to load
        Me.Dispose() 'Gets rid of the user control
        GC.Collect() 'Gather all the remaining data left after closing the user control

    End Sub

    Private Sub MQuizbtn_MouseEnter(sender As Object, e As EventArgs) Handles MQuizbtn.MouseEnter
        MQuizbtn.BackgroundImage = My.Resources.BgBlurSmall
        'This sub loads a different image when the mouse hovers over the Maths Quiz button
    End Sub

    Private Sub PQuizbtn_MouseEnter(sender As Object, e As EventArgs) Handles PQuizbtn.MouseEnter
        PQuizbtn.BackgroundImage = My.Resources.BgBlurSmall
        'Same as the above but with the Physics Quiz button
    End Sub

    Private Sub Aboutbtn_MouseEnter(sender As Object, e As EventArgs) Handles Aboutbtn.MouseEnter
        Aboutbtn.BackgroundImage = My.Resources.BgBlurSmall
        'Same as the above two but with the About button
    End Sub

    Private Sub MQuizbtn_Click(sender As Object, e As EventArgs) Handles MQuizbtn.Click

        ucLoad = Me.Parent 'Sets ucLoad to the parent of main form which allows ucLoad to access AddUC
        ucLoad.addUC("ucMathsQuiz") 'Puts this string into the subroutine AddUC which determines which user control to load
        Me.Dispose() 'Gets rid of the user control
        GC.Collect() 'Gather all the remaining data left after closing the user control

    End Sub

    Private Sub Aboutbtn_Click(sender As Object, e As EventArgs) Handles Aboutbtn.Click

        ucLoad = Me.Parent 'Sets ucLoad to the parent of main form which allows ucLoad to access AddUC
        ucLoad.addUC("ucAbout") 'Puts this string into the subroutine AddUC which determines which user control to load
        Me.Dispose() 'Gets rid of the user control
        GC.Collect() 'Gather all the remaining data left after closing the user control

    End Sub

    Private Sub ucMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Details.QtnTotal = 0 'This resets the variable question total back to 0
        Details.QtnRight = 0 'This resets the variable question right back to 0
    End Sub

    Private Sub PQuizbtn_Click(sender As Object, e As EventArgs) Handles PQuizbtn.Click

        ucLoad = Me.Parent 'Sets ucLoad to the parent of main form which allows ucLoad to access AddUC
        ucLoad.addUC("ucPhysicsQuiz") 'Puts this string into the subroutine AddUC which determines which user control to load
        Me.Dispose() 'Gets rid of the user control
        GC.Collect() 'Gather all the remaining data left after closing the user control

    End Sub
End Class

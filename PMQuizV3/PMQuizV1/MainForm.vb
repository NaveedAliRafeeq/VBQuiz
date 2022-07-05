Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        addUC("ucLogin")
        'Places the User Control Login when the mainform loads
    End Sub

    'Sub routine which takes in user controls, and makes a choice on which uc to load
    Public Sub addUC(ByVal ucChoice As String)
        Dim newUC As UserControl 'variable newUC that adds new user control
        newUC = New ucLogin 'Assigns a User Control to newUC so the variable isn't empty

        Select Case ucChoice
            Case Is = "ucLogin"
                newUC = New ucLogin 'Loads the user control ucLogin
            Case Is = "ucMainMenu"
                newUC = New ucMainMenu 'Loads the user control ucMainMenu
            Case Is = "ucCreateAcc"
                newUC = New CreateAccBtn 'Loads the user control ucCreateAcc
            Case Is = "ucAbout"
                newUC = New ucAbout 'Loads the user control ucAbout
            Case Is = "ucMathsQuiz"
                newUC = New ucMathsQuiz 'Loads the user control ucMathsQuiz
            Case Is = "ucPhysicsQuiz"
                newUC = New ucPhysicsQuiz 'Loads the user control ucPhysicsQuiz
            Case Is = "ucMathsFeedback"
                newUC = New ucMathsFeedback 'Loads the user control ucMathsFeedback
            Case Is = "ucPhysicsFeedback"
                newUC = New ucPhysicsFeedback 'Loads the user control ucPhysicsFeedback
            Case Is = "ucAdminMainMenu"
                newUC = New ucAdminMainMenu 'Loads the user control ucAdminMainMenu
            Case Is = "ucLeaderBoards"
                newUC = New ucLeaderBoards 'Loads the user control ucLeaderBoards
            Case Is = "ucEditQuestions"
                newUC = New ucEditQuestions 'Loads the user control ucEditQuestions
        End Select
        Me.Controls.Add(newUC) 'Adds the desired User Control

    End Sub

    Public Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click

        'This IF statement asks the user whether they are sure if they want to leave 
        If MsgBox("Are you sure you want to exit the program? ", MsgBoxStyle.YesNo, "Exit") = MsgBoxResult.Yes Then
            End 'This button closes the whole program
        End If

    End Sub
End Class

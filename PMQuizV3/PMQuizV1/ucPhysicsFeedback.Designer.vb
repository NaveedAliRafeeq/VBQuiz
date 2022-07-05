<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPhysicsFeedback
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.TitleLbl = New System.Windows.Forms.Label()
        Me.STtlLbl = New System.Windows.Forms.Label()
        Me.LeadBtn = New System.Windows.Forms.Button()
        Me.GrdLbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.QtnRLbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FBackLbl = New System.Windows.Forms.Label()
        Me.LstScore = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FeedBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BackBtn
        '
        Me.BackBtn.BackColor = System.Drawing.Color.Transparent
        Me.BackBtn.FlatAppearance.BorderSize = 2
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackBtn.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BackBtn.Location = New System.Drawing.Point(12, 12)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(200, 35)
        Me.BackBtn.TabIndex = 34
        Me.BackBtn.Text = "Back To Main Menu"
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'TitleLbl
        '
        Me.TitleLbl.AutoSize = True
        Me.TitleLbl.BackColor = System.Drawing.Color.Transparent
        Me.TitleLbl.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLbl.ForeColor = System.Drawing.Color.Black
        Me.TitleLbl.Location = New System.Drawing.Point(393, 12)
        Me.TitleLbl.Name = "TitleLbl"
        Me.TitleLbl.Size = New System.Drawing.Size(324, 79)
        Me.TitleLbl.TabIndex = 46
        Me.TitleLbl.Text = "Physics Quiz"
        '
        'STtlLbl
        '
        Me.STtlLbl.AutoSize = True
        Me.STtlLbl.BackColor = System.Drawing.Color.Transparent
        Me.STtlLbl.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STtlLbl.ForeColor = System.Drawing.Color.Black
        Me.STtlLbl.Location = New System.Drawing.Point(467, 107)
        Me.STtlLbl.Name = "STtlLbl"
        Me.STtlLbl.Size = New System.Drawing.Size(183, 57)
        Me.STtlLbl.TabIndex = 47
        Me.STtlLbl.Text = "Feedback"
        '
        'LeadBtn
        '
        Me.LeadBtn.BackColor = System.Drawing.Color.Transparent
        Me.LeadBtn.FlatAppearance.BorderSize = 2
        Me.LeadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LeadBtn.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LeadBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LeadBtn.Location = New System.Drawing.Point(415, 530)
        Me.LeadBtn.Name = "LeadBtn"
        Me.LeadBtn.Size = New System.Drawing.Size(302, 77)
        Me.LeadBtn.TabIndex = 48
        Me.LeadBtn.Text = "Leader Boards"
        Me.LeadBtn.UseVisualStyleBackColor = False
        '
        'GrdLbl
        '
        Me.GrdLbl.AutoSize = True
        Me.GrdLbl.BackColor = System.Drawing.Color.Transparent
        Me.GrdLbl.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrdLbl.ForeColor = System.Drawing.Color.Black
        Me.GrdLbl.Location = New System.Drawing.Point(682, 275)
        Me.GrdLbl.Name = "GrdLbl"
        Me.GrdLbl.Size = New System.Drawing.Size(74, 79)
        Me.GrdLbl.TabIndex = 53
        Me.GrdLbl.Text = "A"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(546, 373)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 79)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "/ 20"
        '
        'QtnRLbl
        '
        Me.QtnRLbl.AutoSize = True
        Me.QtnRLbl.BackColor = System.Drawing.Color.Transparent
        Me.QtnRLbl.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtnRLbl.ForeColor = System.Drawing.Color.Black
        Me.QtnRLbl.Location = New System.Drawing.Point(472, 373)
        Me.QtnRLbl.Name = "QtnRLbl"
        Me.QtnRLbl.Size = New System.Drawing.Size(90, 79)
        Me.QtnRLbl.TabIndex = 52
        Me.QtnRLbl.Text = "10"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 39.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(376, 286)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(320, 64)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "You got a grade"
        '
        'FBackLbl
        '
        Me.FBackLbl.AutoSize = True
        Me.FBackLbl.BackColor = System.Drawing.Color.Transparent
        Me.FBackLbl.Font = New System.Drawing.Font("Monotype Corsiva", 39.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FBackLbl.ForeColor = System.Drawing.Color.Black
        Me.FBackLbl.Location = New System.Drawing.Point(426, 208)
        Me.FBackLbl.Name = "FBackLbl"
        Me.FBackLbl.Size = New System.Drawing.Size(270, 64)
        Me.FBackLbl.TabIndex = 49
        Me.FBackLbl.Text = "Physics Quiz"
        '
        'LstScore
        '
        Me.LstScore.BackColor = System.Drawing.Color.White
        Me.LstScore.BackgroundImage = Global.PMQuizV1.My.Resources.Resources.RedBG2
        Me.LstScore.BackgroundImageTiled = True
        Me.LstScore.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.LstScore.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstScore.ForeColor = System.Drawing.Color.Black
        Me.LstScore.Location = New System.Drawing.Point(372, 177)
        Me.LstScore.Name = "LstScore"
        Me.LstScore.Size = New System.Drawing.Size(376, 308)
        Me.LstScore.TabIndex = 55
        Me.LstScore.UseCompatibleStateImageBehavior = False
        Me.LstScore.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "User Name"
        Me.ColumnHeader1.Width = 173
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Most Recent Score"
        Me.ColumnHeader2.Width = 197
        '
        'FeedBtn
        '
        Me.FeedBtn.BackColor = System.Drawing.Color.Transparent
        Me.FeedBtn.FlatAppearance.BorderSize = 2
        Me.FeedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FeedBtn.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FeedBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FeedBtn.Location = New System.Drawing.Point(458, 530)
        Me.FeedBtn.Name = "FeedBtn"
        Me.FeedBtn.Size = New System.Drawing.Size(224, 77)
        Me.FeedBtn.TabIndex = 56
        Me.FeedBtn.Text = "FeedBack"
        Me.FeedBtn.UseVisualStyleBackColor = False
        '
        'ucPhysicsFeedback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PMQuizV1.My.Resources.Resources.PBackground
        Me.Controls.Add(Me.FeedBtn)
        Me.Controls.Add(Me.LstScore)
        Me.Controls.Add(Me.GrdLbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.QtnRLbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FBackLbl)
        Me.Controls.Add(Me.LeadBtn)
        Me.Controls.Add(Me.STtlLbl)
        Me.Controls.Add(Me.TitleLbl)
        Me.Controls.Add(Me.BackBtn)
        Me.Name = "ucPhysicsFeedback"
        Me.Size = New System.Drawing.Size(1120, 628)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackBtn As Button
    Friend WithEvents TitleLbl As Label
    Friend WithEvents STtlLbl As Label
    Friend WithEvents LeadBtn As Button
    Friend WithEvents GrdLbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents QtnRLbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FBackLbl As Label
    Friend WithEvents LstScore As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents FeedBtn As Button
End Class

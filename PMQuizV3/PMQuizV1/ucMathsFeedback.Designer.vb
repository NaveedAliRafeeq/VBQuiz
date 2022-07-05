<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucMathsFeedback
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TitleLbl = New System.Windows.Forms.Label()
        Me.STtlLbl = New System.Windows.Forms.Label()
        Me.LeadBtn = New System.Windows.Forms.Button()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.LstScore = New System.Windows.Forms.ListView()
        Me.ColUsrNme = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColScore = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FBackLbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.QtnRLbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GrdLbl = New System.Windows.Forms.Label()
        Me.FeedBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TitleLbl
        '
        Me.TitleLbl.AutoSize = True
        Me.TitleLbl.BackColor = System.Drawing.Color.Transparent
        Me.TitleLbl.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLbl.ForeColor = System.Drawing.Color.Black
        Me.TitleLbl.Location = New System.Drawing.Point(401, 19)
        Me.TitleLbl.Name = "TitleLbl"
        Me.TitleLbl.Size = New System.Drawing.Size(307, 79)
        Me.TitleLbl.TabIndex = 34
        Me.TitleLbl.Text = "Maths Quiz"
        '
        'STtlLbl
        '
        Me.STtlLbl.AutoSize = True
        Me.STtlLbl.BackColor = System.Drawing.Color.Transparent
        Me.STtlLbl.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STtlLbl.ForeColor = System.Drawing.Color.Black
        Me.STtlLbl.Location = New System.Drawing.Point(480, 98)
        Me.STtlLbl.Name = "STtlLbl"
        Me.STtlLbl.Size = New System.Drawing.Size(144, 45)
        Me.STtlLbl.TabIndex = 35
        Me.STtlLbl.Text = "Feedback"
        '
        'LeadBtn
        '
        Me.LeadBtn.BackColor = System.Drawing.Color.Transparent
        Me.LeadBtn.FlatAppearance.BorderSize = 2
        Me.LeadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LeadBtn.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LeadBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LeadBtn.Location = New System.Drawing.Point(415, 473)
        Me.LeadBtn.Name = "LeadBtn"
        Me.LeadBtn.Size = New System.Drawing.Size(302, 77)
        Me.LeadBtn.TabIndex = 43
        Me.LeadBtn.Text = "Leader Boards"
        Me.LeadBtn.UseVisualStyleBackColor = False
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
        Me.BackBtn.TabIndex = 44
        Me.BackBtn.Text = "Back To Main Menu"
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'LstScore
        '
        Me.LstScore.BackColor = System.Drawing.Color.White
        Me.LstScore.BackgroundImage = Global.PMQuizV1.My.Resources.Resources.MathsBG
        Me.LstScore.BackgroundImageTiled = True
        Me.LstScore.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColUsrNme, Me.ColScore})
        Me.LstScore.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstScore.ForeColor = System.Drawing.Color.Black
        Me.LstScore.Location = New System.Drawing.Point(359, 169)
        Me.LstScore.Name = "LstScore"
        Me.LstScore.Size = New System.Drawing.Size(411, 274)
        Me.LstScore.TabIndex = 45
        Me.LstScore.UseCompatibleStateImageBehavior = False
        Me.LstScore.View = System.Windows.Forms.View.Details
        '
        'ColUsrNme
        '
        Me.ColUsrNme.Text = "User Name"
        Me.ColUsrNme.Width = 173
        '
        'ColScore
        '
        Me.ColScore.Text = "Most Recent Score"
        Me.ColScore.Width = 197
        '
        'FBackLbl
        '
        Me.FBackLbl.AutoSize = True
        Me.FBackLbl.BackColor = System.Drawing.Color.Transparent
        Me.FBackLbl.Font = New System.Drawing.Font("Monotype Corsiva", 39.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FBackLbl.ForeColor = System.Drawing.Color.Black
        Me.FBackLbl.Location = New System.Drawing.Point(432, 178)
        Me.FBackLbl.Name = "FBackLbl"
        Me.FBackLbl.Size = New System.Drawing.Size(256, 64)
        Me.FBackLbl.TabIndex = 36
        Me.FBackLbl.Text = "Maths Quiz"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 39.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(367, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(320, 64)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "You got a grade"
        '
        'QtnRLbl
        '
        Me.QtnRLbl.AutoSize = True
        Me.QtnRLbl.BackColor = System.Drawing.Color.Transparent
        Me.QtnRLbl.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtnRLbl.ForeColor = System.Drawing.Color.Black
        Me.QtnRLbl.Location = New System.Drawing.Point(463, 345)
        Me.QtnRLbl.Name = "QtnRLbl"
        Me.QtnRLbl.Size = New System.Drawing.Size(90, 79)
        Me.QtnRLbl.TabIndex = 40
        Me.QtnRLbl.Text = "10"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(537, 345)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 79)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "/ 20"
        '
        'GrdLbl
        '
        Me.GrdLbl.AutoSize = True
        Me.GrdLbl.BackColor = System.Drawing.Color.Transparent
        Me.GrdLbl.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrdLbl.ForeColor = System.Drawing.Color.Black
        Me.GrdLbl.Location = New System.Drawing.Point(673, 247)
        Me.GrdLbl.Name = "GrdLbl"
        Me.GrdLbl.Size = New System.Drawing.Size(74, 79)
        Me.GrdLbl.TabIndex = 41
        Me.GrdLbl.Text = "A"
        '
        'FeedBtn
        '
        Me.FeedBtn.BackColor = System.Drawing.Color.Transparent
        Me.FeedBtn.FlatAppearance.BorderSize = 2
        Me.FeedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FeedBtn.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FeedBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FeedBtn.Location = New System.Drawing.Point(453, 473)
        Me.FeedBtn.Name = "FeedBtn"
        Me.FeedBtn.Size = New System.Drawing.Size(224, 77)
        Me.FeedBtn.TabIndex = 46
        Me.FeedBtn.Text = "FeedBack"
        Me.FeedBtn.UseVisualStyleBackColor = False
        '
        'ucMathsFeedback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImage = Global.PMQuizV1.My.Resources.Resources.MathsBG
        Me.Controls.Add(Me.FeedBtn)
        Me.Controls.Add(Me.GrdLbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LstScore)
        Me.Controls.Add(Me.QtnRLbl)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FBackLbl)
        Me.Controls.Add(Me.LeadBtn)
        Me.Controls.Add(Me.STtlLbl)
        Me.Controls.Add(Me.TitleLbl)
        Me.Name = "ucMathsFeedback"
        Me.Size = New System.Drawing.Size(1120, 628)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleLbl As Label
    Friend WithEvents STtlLbl As Label
    Friend WithEvents LeadBtn As Button
    Friend WithEvents BackBtn As Button
    Friend WithEvents LstScore As ListView
    Friend WithEvents FBackLbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents QtnRLbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GrdLbl As Label
    Friend WithEvents ColUsrNme As ColumnHeader
    Friend WithEvents ColScore As ColumnHeader
    Friend WithEvents FeedBtn As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucLeaderBoards
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
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.TitleLbl = New System.Windows.Forms.Label()
        Me.SubTtlLbl = New System.Windows.Forms.Label()
        Me.PLstScore = New System.Windows.Forms.ListView()
        Me.ColUsrNme = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColScore = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MLstScore = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BackBtn
        '
        Me.BackBtn.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackBtn.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BackBtn.Location = New System.Drawing.Point(12, 12)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(207, 35)
        Me.BackBtn.TabIndex = 36
        Me.BackBtn.Text = "Back To Admin Menu"
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'TitleLbl
        '
        Me.TitleLbl.AutoSize = True
        Me.TitleLbl.BackColor = System.Drawing.Color.Transparent
        Me.TitleLbl.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TitleLbl.Location = New System.Drawing.Point(261, 30)
        Me.TitleLbl.Name = "TitleLbl"
        Me.TitleLbl.Size = New System.Drawing.Size(598, 79)
        Me.TitleLbl.TabIndex = 37
        Me.TitleLbl.Text = "Physics And Maths Quiz"
        '
        'SubTtlLbl
        '
        Me.SubTtlLbl.AutoSize = True
        Me.SubTtlLbl.BackColor = System.Drawing.Color.Transparent
        Me.SubTtlLbl.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubTtlLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SubTtlLbl.Location = New System.Drawing.Point(439, 122)
        Me.SubTtlLbl.Name = "SubTtlLbl"
        Me.SubTtlLbl.Size = New System.Drawing.Size(269, 57)
        Me.SubTtlLbl.TabIndex = 38
        Me.SubTtlLbl.Text = "Leader Boards"
        '
        'PLstScore
        '
        Me.PLstScore.BackColor = System.Drawing.Color.White
        Me.PLstScore.BackgroundImage = Global.PMQuizV1.My.Resources.Resources.Picture22
        Me.PLstScore.BackgroundImageTiled = True
        Me.PLstScore.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColUsrNme, Me.ColScore})
        Me.PLstScore.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PLstScore.ForeColor = System.Drawing.Color.Black
        Me.PLstScore.Location = New System.Drawing.Point(614, 275)
        Me.PLstScore.Name = "PLstScore"
        Me.PLstScore.Size = New System.Drawing.Size(411, 274)
        Me.PLstScore.TabIndex = 46
        Me.PLstScore.UseCompatibleStateImageBehavior = False
        Me.PLstScore.View = System.Windows.Forms.View.Details
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
        'MLstScore
        '
        Me.MLstScore.BackColor = System.Drawing.Color.White
        Me.MLstScore.BackgroundImage = Global.PMQuizV1.My.Resources.Resources.Picture22
        Me.MLstScore.BackgroundImageTiled = True
        Me.MLstScore.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.MLstScore.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MLstScore.ForeColor = System.Drawing.Color.Black
        Me.MLstScore.Location = New System.Drawing.Point(113, 275)
        Me.MLstScore.Name = "MLstScore"
        Me.MLstScore.Size = New System.Drawing.Size(411, 274)
        Me.MLstScore.TabIndex = 47
        Me.MLstScore.UseCompatibleStateImageBehavior = False
        Me.MLstScore.View = System.Windows.Forms.View.Details
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(128, 203)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 57)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Maths Leader Board"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(625, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(389, 57)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Physics Leader Board"
        '
        'ucLeaderBoards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PMQuizV1.My.Resources.Resources.Picture22
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MLstScore)
        Me.Controls.Add(Me.PLstScore)
        Me.Controls.Add(Me.SubTtlLbl)
        Me.Controls.Add(Me.TitleLbl)
        Me.Controls.Add(Me.BackBtn)
        Me.Name = "ucLeaderBoards"
        Me.Size = New System.Drawing.Size(1120, 628)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackBtn As Button
    Friend WithEvents TitleLbl As Label
    Friend WithEvents SubTtlLbl As Label
    Friend WithEvents PLstScore As ListView
    Friend WithEvents ColUsrNme As ColumnHeader
    Friend WithEvents ColScore As ColumnHeader
    Friend WithEvents MLstScore As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPhysicsQuiz
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
        Me.QNumLbl = New System.Windows.Forms.Label()
        Me.TitleLbl = New System.Windows.Forms.Label()
        Me.QtnNumLbl = New System.Windows.Forms.Label()
        Me.QTotalLbl = New System.Windows.Forms.Label()
        Me.RBtn3 = New System.Windows.Forms.RadioButton()
        Me.RBtn4 = New System.Windows.Forms.RadioButton()
        Me.RBtn2 = New System.Windows.Forms.RadioButton()
        Me.Rbtn1 = New System.Windows.Forms.RadioButton()
        Me.QtnLbl = New System.Windows.Forms.Label()
        Me.AnsBtn = New System.Windows.Forms.Button()
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
        Me.BackBtn.TabIndex = 33
        Me.BackBtn.Text = "Back To Main Menu"
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'QNumLbl
        '
        Me.QNumLbl.AutoSize = True
        Me.QNumLbl.BackColor = System.Drawing.Color.Transparent
        Me.QNumLbl.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QNumLbl.ForeColor = System.Drawing.Color.Black
        Me.QNumLbl.Location = New System.Drawing.Point(734, 37)
        Me.QNumLbl.Name = "QNumLbl"
        Me.QNumLbl.Size = New System.Drawing.Size(36, 45)
        Me.QNumLbl.TabIndex = 48
        Me.QNumLbl.Text = "1"
        '
        'TitleLbl
        '
        Me.TitleLbl.AutoSize = True
        Me.TitleLbl.BackColor = System.Drawing.Color.Transparent
        Me.TitleLbl.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLbl.ForeColor = System.Drawing.Color.Black
        Me.TitleLbl.Location = New System.Drawing.Point(239, 12)
        Me.TitleLbl.Name = "TitleLbl"
        Me.TitleLbl.Size = New System.Drawing.Size(324, 79)
        Me.TitleLbl.TabIndex = 45
        Me.TitleLbl.Text = "Physics Quiz"
        '
        'QtnNumLbl
        '
        Me.QtnNumLbl.AutoSize = True
        Me.QtnNumLbl.BackColor = System.Drawing.Color.Transparent
        Me.QtnNumLbl.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtnNumLbl.ForeColor = System.Drawing.Color.Black
        Me.QtnNumLbl.Location = New System.Drawing.Point(588, 37)
        Me.QtnNumLbl.Name = "QtnNumLbl"
        Me.QtnNumLbl.Size = New System.Drawing.Size(155, 45)
        Me.QtnNumLbl.TabIndex = 46
        Me.QtnNumLbl.Text = "Question: "
        '
        'QTotalLbl
        '
        Me.QTotalLbl.AutoSize = True
        Me.QTotalLbl.BackColor = System.Drawing.Color.Transparent
        Me.QTotalLbl.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QTotalLbl.ForeColor = System.Drawing.Color.Black
        Me.QTotalLbl.Location = New System.Drawing.Point(776, 37)
        Me.QTotalLbl.Name = "QTotalLbl"
        Me.QTotalLbl.Size = New System.Drawing.Size(73, 45)
        Me.QTotalLbl.TabIndex = 47
        Me.QTotalLbl.Text = "/ 20"
        '
        'RBtn3
        '
        Me.RBtn3.AutoSize = True
        Me.RBtn3.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtn3.Location = New System.Drawing.Point(195, 340)
        Me.RBtn3.Name = "RBtn3"
        Me.RBtn3.Size = New System.Drawing.Size(198, 43)
        Me.RBtn3.TabIndex = 52
        Me.RBtn3.TabStop = True
        Me.RBtn3.Text = "RadioButton3"
        Me.RBtn3.UseVisualStyleBackColor = True
        '
        'RBtn4
        '
        Me.RBtn4.AutoSize = True
        Me.RBtn4.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtn4.Location = New System.Drawing.Point(195, 412)
        Me.RBtn4.Name = "RBtn4"
        Me.RBtn4.Size = New System.Drawing.Size(198, 43)
        Me.RBtn4.TabIndex = 53
        Me.RBtn4.TabStop = True
        Me.RBtn4.Text = "RadioButton4"
        Me.RBtn4.UseVisualStyleBackColor = True
        '
        'RBtn2
        '
        Me.RBtn2.AutoSize = True
        Me.RBtn2.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtn2.Location = New System.Drawing.Point(195, 268)
        Me.RBtn2.Name = "RBtn2"
        Me.RBtn2.Size = New System.Drawing.Size(198, 43)
        Me.RBtn2.TabIndex = 51
        Me.RBtn2.TabStop = True
        Me.RBtn2.Text = "RadioButton2"
        Me.RBtn2.UseVisualStyleBackColor = True
        '
        'Rbtn1
        '
        Me.Rbtn1.AutoSize = True
        Me.Rbtn1.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbtn1.Location = New System.Drawing.Point(195, 196)
        Me.Rbtn1.Name = "Rbtn1"
        Me.Rbtn1.Size = New System.Drawing.Size(198, 43)
        Me.Rbtn1.TabIndex = 50
        Me.Rbtn1.TabStop = True
        Me.Rbtn1.Text = "RadioButton1"
        Me.Rbtn1.UseVisualStyleBackColor = True
        '
        'QtnLbl
        '
        Me.QtnLbl.AutoSize = True
        Me.QtnLbl.BackColor = System.Drawing.Color.Transparent
        Me.QtnLbl.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtnLbl.ForeColor = System.Drawing.Color.Black
        Me.QtnLbl.Location = New System.Drawing.Point(149, 117)
        Me.QtnLbl.Name = "QtnLbl"
        Me.QtnLbl.Size = New System.Drawing.Size(155, 45)
        Me.QtnLbl.TabIndex = 49
        Me.QtnLbl.Text = "Question: "
        Me.QtnLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AnsBtn
        '
        Me.AnsBtn.BackColor = System.Drawing.Color.Transparent
        Me.AnsBtn.FlatAppearance.BorderSize = 2
        Me.AnsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AnsBtn.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnsBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AnsBtn.Location = New System.Drawing.Point(475, 533)
        Me.AnsBtn.Name = "AnsBtn"
        Me.AnsBtn.Size = New System.Drawing.Size(175, 77)
        Me.AnsBtn.TabIndex = 54
        Me.AnsBtn.Text = "Answer"
        Me.AnsBtn.UseVisualStyleBackColor = False
        '
        'ucPhysicsQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImage = Global.PMQuizV1.My.Resources.Resources.PBackground
        Me.Controls.Add(Me.AnsBtn)
        Me.Controls.Add(Me.RBtn3)
        Me.Controls.Add(Me.RBtn4)
        Me.Controls.Add(Me.RBtn2)
        Me.Controls.Add(Me.Rbtn1)
        Me.Controls.Add(Me.QtnLbl)
        Me.Controls.Add(Me.QNumLbl)
        Me.Controls.Add(Me.QTotalLbl)
        Me.Controls.Add(Me.QtnNumLbl)
        Me.Controls.Add(Me.TitleLbl)
        Me.Controls.Add(Me.BackBtn)
        Me.Name = "ucPhysicsQuiz"
        Me.Size = New System.Drawing.Size(1120, 628)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackBtn As Button
    Friend WithEvents QNumLbl As Label
    Friend WithEvents TitleLbl As Label
    Friend WithEvents QtnNumLbl As Label
    Friend WithEvents QTotalLbl As Label
    Friend WithEvents RBtn3 As RadioButton
    Friend WithEvents RBtn4 As RadioButton
    Friend WithEvents RBtn2 As RadioButton
    Friend WithEvents Rbtn1 As RadioButton
    Friend WithEvents QtnLbl As Label
    Friend WithEvents AnsBtn As Button
End Class

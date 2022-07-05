<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucMainMenu
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
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.MQuizbtn = New System.Windows.Forms.Button()
        Me.PQuizbtn = New System.Windows.Forms.Button()
        Me.Aboutbtn = New System.Windows.Forms.Button()
        Me.SubTtlLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TitleLbl
        '
        Me.TitleLbl.AutoSize = True
        Me.TitleLbl.BackColor = System.Drawing.Color.Transparent
        Me.TitleLbl.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TitleLbl.Location = New System.Drawing.Point(245, 19)
        Me.TitleLbl.Name = "TitleLbl"
        Me.TitleLbl.Size = New System.Drawing.Size(598, 79)
        Me.TitleLbl.TabIndex = 19
        Me.TitleLbl.Text = "Physics And Maths Quiz"
        '
        'BackBtn
        '
        Me.BackBtn.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackBtn.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BackBtn.Location = New System.Drawing.Point(12, 19)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(146, 35)
        Me.BackBtn.TabIndex = 31
        Me.BackBtn.Text = "Back To Login"
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'MQuizbtn
        '
        Me.MQuizbtn.BackColor = System.Drawing.Color.Transparent
        Me.MQuizbtn.BackgroundImage = Global.PMQuizV1.My.Resources.Resources.BgSmall
        Me.MQuizbtn.FlatAppearance.BorderSize = 2
        Me.MQuizbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MQuizbtn.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MQuizbtn.ForeColor = System.Drawing.Color.Black
        Me.MQuizbtn.Location = New System.Drawing.Point(127, 250)
        Me.MQuizbtn.Name = "MQuizbtn"
        Me.MQuizbtn.Size = New System.Drawing.Size(369, 169)
        Me.MQuizbtn.TabIndex = 32
        Me.MQuizbtn.Text = "Maths Quiz"
        Me.MQuizbtn.UseVisualStyleBackColor = False
        '
        'PQuizbtn
        '
        Me.PQuizbtn.BackColor = System.Drawing.Color.Transparent
        Me.PQuizbtn.BackgroundImage = Global.PMQuizV1.My.Resources.Resources.BgSmall
        Me.PQuizbtn.FlatAppearance.BorderSize = 2
        Me.PQuizbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PQuizbtn.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PQuizbtn.ForeColor = System.Drawing.Color.Black
        Me.PQuizbtn.Location = New System.Drawing.Point(598, 250)
        Me.PQuizbtn.Name = "PQuizbtn"
        Me.PQuizbtn.Size = New System.Drawing.Size(369, 169)
        Me.PQuizbtn.TabIndex = 33
        Me.PQuizbtn.Text = "Physics Quiz"
        Me.PQuizbtn.UseVisualStyleBackColor = False
        '
        'Aboutbtn
        '
        Me.Aboutbtn.BackColor = System.Drawing.Color.Transparent
        Me.Aboutbtn.BackgroundImage = Global.PMQuizV1.My.Resources.Resources.BgSmall
        Me.Aboutbtn.FlatAppearance.BorderSize = 2
        Me.Aboutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Aboutbtn.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aboutbtn.ForeColor = System.Drawing.Color.Black
        Me.Aboutbtn.Location = New System.Drawing.Point(923, 525)
        Me.Aboutbtn.Name = "Aboutbtn"
        Me.Aboutbtn.Size = New System.Drawing.Size(178, 83)
        Me.Aboutbtn.TabIndex = 34
        Me.Aboutbtn.Text = "About"
        Me.Aboutbtn.UseVisualStyleBackColor = False
        '
        'SubTtlLbl
        '
        Me.SubTtlLbl.AutoSize = True
        Me.SubTtlLbl.BackColor = System.Drawing.Color.Transparent
        Me.SubTtlLbl.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubTtlLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SubTtlLbl.Location = New System.Drawing.Point(429, 98)
        Me.SubTtlLbl.Name = "SubTtlLbl"
        Me.SubTtlLbl.Size = New System.Drawing.Size(230, 57)
        Me.SubTtlLbl.TabIndex = 35
        Me.SubTtlLbl.Text = "Main Menu"
        '
        'ucMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PMQuizV1.My.Resources.Resources.Picture22
        Me.Controls.Add(Me.SubTtlLbl)
        Me.Controls.Add(Me.Aboutbtn)
        Me.Controls.Add(Me.PQuizbtn)
        Me.Controls.Add(Me.MQuizbtn)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.TitleLbl)
        Me.Name = "ucMainMenu"
        Me.Size = New System.Drawing.Size(1120, 628)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleLbl As Label
    Friend WithEvents BackBtn As Button
    Friend WithEvents MQuizbtn As Button
    Friend WithEvents PQuizbtn As Button
    Friend WithEvents Aboutbtn As Button
    Friend WithEvents SubTtlLbl As Label
End Class

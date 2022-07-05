<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAccBtn
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
        Me.TitleLbl = New System.Windows.Forms.Label()
        Me.LoginLbl = New System.Windows.Forms.Label()
        Me.PassLbl = New System.Windows.Forms.Label()
        Me.UsrLbl = New System.Windows.Forms.Label()
        Me.NPassTxt = New System.Windows.Forms.TextBox()
        Me.NUsrNmeTxt = New System.Windows.Forms.TextBox()
        Me.Pass2Lbl = New System.Windows.Forms.Label()
        Me.NPass2Txt = New System.Windows.Forms.TextBox()
        Me.TIDLbl = New System.Windows.Forms.Label()
        Me.TIDTxt = New System.Windows.Forms.TextBox()
        Me.NewAccBtn = New System.Windows.Forms.Button()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TitleLbl
        '
        Me.TitleLbl.AutoSize = True
        Me.TitleLbl.BackColor = System.Drawing.Color.Transparent
        Me.TitleLbl.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TitleLbl.Location = New System.Drawing.Point(245, 68)
        Me.TitleLbl.Name = "TitleLbl"
        Me.TitleLbl.Size = New System.Drawing.Size(598, 79)
        Me.TitleLbl.TabIndex = 19
        Me.TitleLbl.Text = "Physics And Maths Quiz"
        '
        'LoginLbl
        '
        Me.LoginLbl.AutoSize = True
        Me.LoginLbl.BackColor = System.Drawing.Color.Transparent
        Me.LoginLbl.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LoginLbl.Location = New System.Drawing.Point(486, 147)
        Me.LoginLbl.Name = "LoginLbl"
        Me.LoginLbl.Size = New System.Drawing.Size(125, 57)
        Me.LoginLbl.TabIndex = 20
        Me.LoginLbl.Text = "Login"
        '
        'PassLbl
        '
        Me.PassLbl.AutoSize = True
        Me.PassLbl.BackColor = System.Drawing.Color.Transparent
        Me.PassLbl.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PassLbl.Location = New System.Drawing.Point(183, 315)
        Me.PassLbl.Name = "PassLbl"
        Me.PassLbl.Size = New System.Drawing.Size(194, 36)
        Me.PassLbl.TabIndex = 24
        Me.PassLbl.Text = "Create Password:"
        '
        'UsrLbl
        '
        Me.UsrLbl.AutoSize = True
        Me.UsrLbl.BackColor = System.Drawing.Color.Transparent
        Me.UsrLbl.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsrLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.UsrLbl.Location = New System.Drawing.Point(253, 233)
        Me.UsrLbl.Name = "UsrLbl"
        Me.UsrLbl.Size = New System.Drawing.Size(124, 36)
        Me.UsrLbl.TabIndex = 23
        Me.UsrLbl.Text = "Username:"
        '
        'NPassTxt
        '
        Me.NPassTxt.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NPassTxt.Location = New System.Drawing.Point(430, 317)
        Me.NPassTxt.Name = "NPassTxt"
        Me.NPassTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NPassTxt.Size = New System.Drawing.Size(251, 34)
        Me.NPassTxt.TabIndex = 22
        '
        'NUsrNmeTxt
        '
        Me.NUsrNmeTxt.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NUsrNmeTxt.Location = New System.Drawing.Point(430, 235)
        Me.NUsrNmeTxt.Name = "NUsrNmeTxt"
        Me.NUsrNmeTxt.Size = New System.Drawing.Size(251, 34)
        Me.NUsrNmeTxt.TabIndex = 21
        '
        'Pass2Lbl
        '
        Me.Pass2Lbl.AutoSize = True
        Me.Pass2Lbl.BackColor = System.Drawing.Color.Transparent
        Me.Pass2Lbl.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pass2Lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Pass2Lbl.Location = New System.Drawing.Point(166, 405)
        Me.Pass2Lbl.Name = "Pass2Lbl"
        Me.Pass2Lbl.Size = New System.Drawing.Size(211, 36)
        Me.Pass2Lbl.TabIndex = 25
        Me.Pass2Lbl.Text = "Confirm Password:"
        '
        'NPass2Txt
        '
        Me.NPass2Txt.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NPass2Txt.Location = New System.Drawing.Point(430, 407)
        Me.NPass2Txt.Name = "NPass2Txt"
        Me.NPass2Txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NPass2Txt.Size = New System.Drawing.Size(251, 34)
        Me.NPass2Txt.TabIndex = 26
        '
        'TIDLbl
        '
        Me.TIDLbl.AutoSize = True
        Me.TIDLbl.BackColor = System.Drawing.Color.Transparent
        Me.TIDLbl.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIDLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TIDLbl.Location = New System.Drawing.Point(238, 493)
        Me.TIDLbl.Name = "TIDLbl"
        Me.TIDLbl.Size = New System.Drawing.Size(139, 36)
        Me.TIDLbl.TabIndex = 27
        Me.TIDLbl.Text = "Teacher ID:"
        '
        'TIDTxt
        '
        Me.TIDTxt.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIDTxt.Location = New System.Drawing.Point(430, 493)
        Me.TIDTxt.Name = "TIDTxt"
        Me.TIDTxt.Size = New System.Drawing.Size(251, 34)
        Me.TIDTxt.TabIndex = 28
        '
        'NewAccBtn
        '
        Me.NewAccBtn.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.NewAccBtn.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.NewAccBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewAccBtn.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewAccBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NewAccBtn.Location = New System.Drawing.Point(430, 553)
        Me.NewAccBtn.Name = "NewAccBtn"
        Me.NewAccBtn.Size = New System.Drawing.Size(251, 50)
        Me.NewAccBtn.TabIndex = 29
        Me.NewAccBtn.Text = "Create Account"
        Me.NewAccBtn.UseVisualStyleBackColor = False
        '
        'BackBtn
        '
        Me.BackBtn.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackBtn.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BackBtn.Location = New System.Drawing.Point(10, 12)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(88, 35)
        Me.BackBtn.TabIndex = 30
        Me.BackBtn.Text = "Login"
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'CreateAccBtn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.NewAccBtn)
        Me.Controls.Add(Me.TIDTxt)
        Me.Controls.Add(Me.TIDLbl)
        Me.Controls.Add(Me.NPass2Txt)
        Me.Controls.Add(Me.Pass2Lbl)
        Me.Controls.Add(Me.PassLbl)
        Me.Controls.Add(Me.UsrLbl)
        Me.Controls.Add(Me.NPassTxt)
        Me.Controls.Add(Me.NUsrNmeTxt)
        Me.Controls.Add(Me.LoginLbl)
        Me.Controls.Add(Me.TitleLbl)
        Me.Name = "CreateAccBtn"
        Me.Size = New System.Drawing.Size(1120, 628)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleLbl As Label
    Friend WithEvents LoginLbl As Label
    Friend WithEvents PassLbl As Label
    Friend WithEvents UsrLbl As Label
    Friend WithEvents NPassTxt As TextBox
    Friend WithEvents NUsrNmeTxt As TextBox
    Friend WithEvents Pass2Lbl As Label
    Friend WithEvents NPass2Txt As TextBox
    Friend WithEvents TIDLbl As Label
    Friend WithEvents TIDTxt As TextBox
    Friend WithEvents NewAccBtn As Button
    Friend WithEvents BackBtn As Button
End Class

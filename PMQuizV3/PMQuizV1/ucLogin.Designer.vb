<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucLogin
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
        Me.LoginLbl = New System.Windows.Forms.Label()
        Me.PassLbl = New System.Windows.Forms.Label()
        Me.UsrLbl = New System.Windows.Forms.Label()
        Me.PassTxt = New System.Windows.Forms.TextBox()
        Me.UsrNmeTxt = New System.Windows.Forms.TextBox()
        Me.NewAccBtn = New System.Windows.Forms.Button()
        Me.LoginBtn = New System.Windows.Forms.Button()
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
        Me.TitleLbl.TabIndex = 18
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
        Me.LoginLbl.TabIndex = 17
        Me.LoginLbl.Text = "Login"
        '
        'PassLbl
        '
        Me.PassLbl.AutoSize = True
        Me.PassLbl.BackColor = System.Drawing.Color.Transparent
        Me.PassLbl.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PassLbl.Location = New System.Drawing.Point(253, 324)
        Me.PassLbl.Name = "PassLbl"
        Me.PassLbl.Size = New System.Drawing.Size(123, 36)
        Me.PassLbl.TabIndex = 16
        Me.PassLbl.Text = "Password:"
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
        Me.UsrLbl.TabIndex = 15
        Me.UsrLbl.Text = "Username:"
        '
        'PassTxt
        '
        Me.PassTxt.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassTxt.Location = New System.Drawing.Point(430, 326)
        Me.PassTxt.Name = "PassTxt"
        Me.PassTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassTxt.Size = New System.Drawing.Size(251, 34)
        Me.PassTxt.TabIndex = 14
        '
        'UsrNmeTxt
        '
        Me.UsrNmeTxt.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsrNmeTxt.Location = New System.Drawing.Point(430, 235)
        Me.UsrNmeTxt.Name = "UsrNmeTxt"
        Me.UsrNmeTxt.Size = New System.Drawing.Size(251, 34)
        Me.UsrNmeTxt.TabIndex = 13
        '
        'NewAccBtn
        '
        Me.NewAccBtn.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.NewAccBtn.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.NewAccBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewAccBtn.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewAccBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NewAccBtn.Location = New System.Drawing.Point(430, 501)
        Me.NewAccBtn.Name = "NewAccBtn"
        Me.NewAccBtn.Size = New System.Drawing.Size(251, 50)
        Me.NewAccBtn.TabIndex = 12
        Me.NewAccBtn.Text = "Create New Account"
        Me.NewAccBtn.UseVisualStyleBackColor = False
        '
        'LoginBtn
        '
        Me.LoginBtn.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginBtn.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LoginBtn.Location = New System.Drawing.Point(470, 414)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(172, 50)
        Me.LoginBtn.TabIndex = 11
        Me.LoginBtn.Text = "Login"
        Me.LoginBtn.UseVisualStyleBackColor = False
        '
        'ucLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.TitleLbl)
        Me.Controls.Add(Me.LoginLbl)
        Me.Controls.Add(Me.PassLbl)
        Me.Controls.Add(Me.UsrLbl)
        Me.Controls.Add(Me.PassTxt)
        Me.Controls.Add(Me.UsrNmeTxt)
        Me.Controls.Add(Me.NewAccBtn)
        Me.Controls.Add(Me.LoginBtn)
        Me.Name = "ucLogin"
        Me.Size = New System.Drawing.Size(1120, 628)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleLbl As Label
    Friend WithEvents LoginLbl As Label
    Friend WithEvents PassLbl As Label
    Friend WithEvents UsrLbl As Label
    Friend WithEvents PassTxt As TextBox
    Friend WithEvents UsrNmeTxt As TextBox
    Friend WithEvents NewAccBtn As Button
    Friend WithEvents LoginBtn As Button
End Class

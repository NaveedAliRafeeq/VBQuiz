<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucAdminMainMenu
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
        Me.SubTtlLbl = New System.Windows.Forms.Label()
        Me.Leadbtn = New System.Windows.Forms.Button()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
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
        Me.TitleLbl.TabIndex = 20
        Me.TitleLbl.Text = "Physics And Maths Quiz"
        '
        'SubTtlLbl
        '
        Me.SubTtlLbl.AutoSize = True
        Me.SubTtlLbl.BackColor = System.Drawing.Color.Transparent
        Me.SubTtlLbl.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubTtlLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SubTtlLbl.Location = New System.Drawing.Point(388, 122)
        Me.SubTtlLbl.Name = "SubTtlLbl"
        Me.SubTtlLbl.Size = New System.Drawing.Size(356, 57)
        Me.SubTtlLbl.TabIndex = 21
        Me.SubTtlLbl.Text = "Admin Main Menu"
        '
        'Leadbtn
        '
        Me.Leadbtn.BackColor = System.Drawing.Color.Transparent
        Me.Leadbtn.BackgroundImage = Global.PMQuizV1.My.Resources.Resources.BgSmall
        Me.Leadbtn.FlatAppearance.BorderSize = 2
        Me.Leadbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Leadbtn.Font = New System.Drawing.Font("Monotype Corsiva", 39.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Leadbtn.ForeColor = System.Drawing.Color.Black
        Me.Leadbtn.Location = New System.Drawing.Point(116, 259)
        Me.Leadbtn.Name = "Leadbtn"
        Me.Leadbtn.Size = New System.Drawing.Size(369, 169)
        Me.Leadbtn.TabIndex = 33
        Me.Leadbtn.Text = "Leader Boards"
        Me.Leadbtn.UseVisualStyleBackColor = False
        '
        'EditBtn
        '
        Me.EditBtn.BackColor = System.Drawing.Color.Transparent
        Me.EditBtn.BackgroundImage = Global.PMQuizV1.My.Resources.Resources.BgSmall
        Me.EditBtn.FlatAppearance.BorderSize = 2
        Me.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditBtn.Font = New System.Drawing.Font("Monotype Corsiva", 39.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBtn.ForeColor = System.Drawing.Color.Black
        Me.EditBtn.Location = New System.Drawing.Point(632, 259)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(369, 169)
        Me.EditBtn.TabIndex = 34
        Me.EditBtn.Text = "Edit Page"
        Me.EditBtn.UseVisualStyleBackColor = False
        '
        'BackBtn
        '
        Me.BackBtn.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackBtn.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BackBtn.Location = New System.Drawing.Point(12, 12)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(146, 35)
        Me.BackBtn.TabIndex = 35
        Me.BackBtn.Text = "Back To Login"
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'ucAdminMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PMQuizV1.My.Resources.Resources.Picture22
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.Leadbtn)
        Me.Controls.Add(Me.SubTtlLbl)
        Me.Controls.Add(Me.TitleLbl)
        Me.Name = "ucAdminMainMenu"
        Me.Size = New System.Drawing.Size(1120, 628)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleLbl As Label
    Friend WithEvents SubTtlLbl As Label
    Friend WithEvents Leadbtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents BackBtn As Button
End Class

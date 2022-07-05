<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucEditQuestions
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
        Me.SubTtlLbl = New System.Windows.Forms.Label()
        Me.UserLst = New System.Windows.Forms.ListView()
        Me.ColUser = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColPass = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.DeleteUserBtn = New System.Windows.Forms.Button()
        Me.MQtnLst = New System.Windows.Forms.ListView()
        Me.ColQ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColA1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColA2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColA3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColA4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Qtntxt = New System.Windows.Forms.TextBox()
        Me.A1txt = New System.Windows.Forms.TextBox()
        Me.A2txt = New System.Windows.Forms.TextBox()
        Me.A3txt = New System.Windows.Forms.TextBox()
        Me.A4txt = New System.Windows.Forms.TextBox()
        Me.UsrLstBtn = New System.Windows.Forms.Button()
        Me.MQtnbtn = New System.Windows.Forms.Button()
        Me.PQtnbtn = New System.Windows.Forms.Button()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.QtnLbl = New System.Windows.Forms.Label()
        Me.A1Lbl = New System.Windows.Forms.Label()
        Me.A2Lbl = New System.Windows.Forms.Label()
        Me.A3Lbl = New System.Windows.Forms.Label()
        Me.A4Lbl = New System.Windows.Forms.Label()
        Me.MRefreshBtn = New System.Windows.Forms.Button()
        Me.MQtnDeleteBtn = New System.Windows.Forms.Button()
        Me.MQtnAddBtn = New System.Windows.Forms.Button()
        Me.PQtnLst = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PQtnDeleteBtn = New System.Windows.Forms.Button()
        Me.PQtnAddBtn = New System.Windows.Forms.Button()
        Me.PRefreshBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TitleLbl
        '
        Me.TitleLbl.AutoSize = True
        Me.TitleLbl.BackColor = System.Drawing.Color.Transparent
        Me.TitleLbl.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TitleLbl.Location = New System.Drawing.Point(263, 27)
        Me.TitleLbl.Name = "TitleLbl"
        Me.TitleLbl.Size = New System.Drawing.Size(598, 79)
        Me.TitleLbl.TabIndex = 38
        Me.TitleLbl.Text = "Physics And Maths Quiz"
        '
        'SubTtlLbl
        '
        Me.SubTtlLbl.AutoSize = True
        Me.SubTtlLbl.BackColor = System.Drawing.Color.Transparent
        Me.SubTtlLbl.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubTtlLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SubTtlLbl.Location = New System.Drawing.Point(456, 109)
        Me.SubTtlLbl.Name = "SubTtlLbl"
        Me.SubTtlLbl.Size = New System.Drawing.Size(195, 57)
        Me.SubTtlLbl.TabIndex = 39
        Me.SubTtlLbl.Text = "Edit Page"
        '
        'UserLst
        '
        Me.UserLst.BackColor = System.Drawing.Color.White
        Me.UserLst.BackgroundImage = Global.PMQuizV1.My.Resources.Resources.Picture22
        Me.UserLst.BackgroundImageTiled = True
        Me.UserLst.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColUser, Me.ColPass})
        Me.UserLst.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserLst.ForeColor = System.Drawing.Color.Black
        Me.UserLst.FullRowSelect = True
        Me.UserLst.Location = New System.Drawing.Point(369, 193)
        Me.UserLst.Name = "UserLst"
        Me.UserLst.Size = New System.Drawing.Size(379, 274)
        Me.UserLst.TabIndex = 48
        Me.UserLst.UseCompatibleStateImageBehavior = False
        Me.UserLst.View = System.Windows.Forms.View.Details
        '
        'ColUser
        '
        Me.ColUser.Text = "User Name"
        Me.ColUser.Width = 173
        '
        'ColPass
        '
        Me.ColPass.Text = "Password"
        Me.ColPass.Width = 197
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
        Me.BackBtn.TabIndex = 49
        Me.BackBtn.Text = "Back To Admin Menu"
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'DeleteUserBtn
        '
        Me.DeleteUserBtn.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.DeleteUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteUserBtn.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteUserBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DeleteUserBtn.Location = New System.Drawing.Point(466, 510)
        Me.DeleteUserBtn.Name = "DeleteUserBtn"
        Me.DeleteUserBtn.Size = New System.Drawing.Size(207, 50)
        Me.DeleteUserBtn.TabIndex = 50
        Me.DeleteUserBtn.Text = "Delete User"
        Me.DeleteUserBtn.UseVisualStyleBackColor = False
        '
        'MQtnLst
        '
        Me.MQtnLst.BackColor = System.Drawing.Color.White
        Me.MQtnLst.BackgroundImage = Global.PMQuizV1.My.Resources.Resources.Picture22
        Me.MQtnLst.BackgroundImageTiled = True
        Me.MQtnLst.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColQ, Me.ColA1, Me.ColA2, Me.ColA3, Me.ColA4})
        Me.MQtnLst.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MQtnLst.ForeColor = System.Drawing.Color.Black
        Me.MQtnLst.FullRowSelect = True
        Me.MQtnLst.Location = New System.Drawing.Point(29, 109)
        Me.MQtnLst.Name = "MQtnLst"
        Me.MQtnLst.Size = New System.Drawing.Size(1065, 369)
        Me.MQtnLst.TabIndex = 51
        Me.MQtnLst.UseCompatibleStateImageBehavior = False
        Me.MQtnLst.View = System.Windows.Forms.View.Details
        '
        'ColQ
        '
        Me.ColQ.Text = "Question"
        Me.ColQ.Width = 451
        '
        'ColA1
        '
        Me.ColA1.Text = "Correct Ans"
        Me.ColA1.Width = 158
        '
        'ColA2
        '
        Me.ColA2.Text = "Wrong Ans"
        Me.ColA2.Width = 148
        '
        'ColA3
        '
        Me.ColA3.Text = "Wrong Ans"
        Me.ColA3.Width = 143
        '
        'ColA4
        '
        Me.ColA4.Text = "Wrong Ans"
        Me.ColA4.Width = 147
        '
        'Qtntxt
        '
        Me.Qtntxt.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qtntxt.Location = New System.Drawing.Point(124, 506)
        Me.Qtntxt.Name = "Qtntxt"
        Me.Qtntxt.Size = New System.Drawing.Size(514, 34)
        Me.Qtntxt.TabIndex = 52
        '
        'A1txt
        '
        Me.A1txt.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A1txt.Location = New System.Drawing.Point(826, 506)
        Me.A1txt.Name = "A1txt"
        Me.A1txt.Size = New System.Drawing.Size(213, 34)
        Me.A1txt.TabIndex = 53
        '
        'A2txt
        '
        Me.A2txt.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A2txt.Location = New System.Drawing.Point(150, 566)
        Me.A2txt.Name = "A2txt"
        Me.A2txt.Size = New System.Drawing.Size(213, 34)
        Me.A2txt.TabIndex = 54
        '
        'A3txt
        '
        Me.A3txt.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A3txt.Location = New System.Drawing.Point(514, 568)
        Me.A3txt.Name = "A3txt"
        Me.A3txt.Size = New System.Drawing.Size(213, 34)
        Me.A3txt.TabIndex = 55
        '
        'A4txt
        '
        Me.A4txt.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A4txt.Location = New System.Drawing.Point(887, 568)
        Me.A4txt.Name = "A4txt"
        Me.A4txt.Size = New System.Drawing.Size(213, 34)
        Me.A4txt.TabIndex = 56
        '
        'UsrLstBtn
        '
        Me.UsrLstBtn.BackColor = System.Drawing.Color.Transparent
        Me.UsrLstBtn.BackgroundImage = Global.PMQuizV1.My.Resources.Resources.BgSmall
        Me.UsrLstBtn.FlatAppearance.BorderSize = 2
        Me.UsrLstBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UsrLstBtn.Font = New System.Drawing.Font("Monotype Corsiva", 39.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsrLstBtn.ForeColor = System.Drawing.Color.Black
        Me.UsrLstBtn.Location = New System.Drawing.Point(118, 287)
        Me.UsrLstBtn.Name = "UsrLstBtn"
        Me.UsrLstBtn.Size = New System.Drawing.Size(369, 169)
        Me.UsrLstBtn.TabIndex = 57
        Me.UsrLstBtn.Text = "Delete Users"
        Me.UsrLstBtn.UseVisualStyleBackColor = False
        '
        'MQtnbtn
        '
        Me.MQtnbtn.BackColor = System.Drawing.Color.Transparent
        Me.MQtnbtn.BackgroundImage = Global.PMQuizV1.My.Resources.Resources.BgSmall
        Me.MQtnbtn.FlatAppearance.BorderSize = 2
        Me.MQtnbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MQtnbtn.Font = New System.Drawing.Font("Monotype Corsiva", 39.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MQtnbtn.ForeColor = System.Drawing.Color.Black
        Me.MQtnbtn.Location = New System.Drawing.Point(594, 204)
        Me.MQtnbtn.Name = "MQtnbtn"
        Me.MQtnbtn.Size = New System.Drawing.Size(369, 169)
        Me.MQtnbtn.TabIndex = 58
        Me.MQtnbtn.Text = "Edit Maths Questions"
        Me.MQtnbtn.UseVisualStyleBackColor = False
        '
        'PQtnbtn
        '
        Me.PQtnbtn.BackColor = System.Drawing.Color.Transparent
        Me.PQtnbtn.BackgroundImage = Global.PMQuizV1.My.Resources.Resources.BgSmall
        Me.PQtnbtn.FlatAppearance.BorderSize = 2
        Me.PQtnbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PQtnbtn.Font = New System.Drawing.Font("Monotype Corsiva", 39.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PQtnbtn.ForeColor = System.Drawing.Color.Black
        Me.PQtnbtn.Location = New System.Drawing.Point(594, 373)
        Me.PQtnbtn.Name = "PQtnbtn"
        Me.PQtnbtn.Size = New System.Drawing.Size(369, 169)
        Me.PQtnbtn.TabIndex = 59
        Me.PQtnbtn.Text = "Edit Physics Questions"
        Me.PQtnbtn.UseVisualStyleBackColor = False
        '
        'EditBtn
        '
        Me.EditBtn.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditBtn.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EditBtn.Location = New System.Drawing.Point(12, 12)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(207, 35)
        Me.EditBtn.TabIndex = 60
        Me.EditBtn.Text = "Back To Edit Page"
        Me.EditBtn.UseVisualStyleBackColor = False
        '
        'QtnLbl
        '
        Me.QtnLbl.AutoSize = True
        Me.QtnLbl.BackColor = System.Drawing.Color.Transparent
        Me.QtnLbl.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtnLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.QtnLbl.Location = New System.Drawing.Point(6, 506)
        Me.QtnLbl.Name = "QtnLbl"
        Me.QtnLbl.Size = New System.Drawing.Size(112, 36)
        Me.QtnLbl.TabIndex = 61
        Me.QtnLbl.Text = "Question:"
        '
        'A1Lbl
        '
        Me.A1Lbl.AutoSize = True
        Me.A1Lbl.BackColor = System.Drawing.Color.Transparent
        Me.A1Lbl.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A1Lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.A1Lbl.Location = New System.Drawing.Point(662, 504)
        Me.A1Lbl.Name = "A1Lbl"
        Me.A1Lbl.Size = New System.Drawing.Size(142, 36)
        Me.A1Lbl.TabIndex = 62
        Me.A1Lbl.Text = "Correct Ans:"
        '
        'A2Lbl
        '
        Me.A2Lbl.AutoSize = True
        Me.A2Lbl.BackColor = System.Drawing.Color.Transparent
        Me.A2Lbl.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A2Lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.A2Lbl.Location = New System.Drawing.Point(5, 566)
        Me.A2Lbl.Name = "A2Lbl"
        Me.A2Lbl.Size = New System.Drawing.Size(139, 36)
        Me.A2Lbl.TabIndex = 63
        Me.A2Lbl.Text = "Wrong Ans:"
        '
        'A3Lbl
        '
        Me.A3Lbl.AutoSize = True
        Me.A3Lbl.BackColor = System.Drawing.Color.Transparent
        Me.A3Lbl.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A3Lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.A3Lbl.Location = New System.Drawing.Point(369, 566)
        Me.A3Lbl.Name = "A3Lbl"
        Me.A3Lbl.Size = New System.Drawing.Size(139, 36)
        Me.A3Lbl.TabIndex = 64
        Me.A3Lbl.Text = "Wrong Ans:"
        '
        'A4Lbl
        '
        Me.A4Lbl.AutoSize = True
        Me.A4Lbl.BackColor = System.Drawing.Color.Transparent
        Me.A4Lbl.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A4Lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.A4Lbl.Location = New System.Drawing.Point(742, 568)
        Me.A4Lbl.Name = "A4Lbl"
        Me.A4Lbl.Size = New System.Drawing.Size(139, 36)
        Me.A4Lbl.TabIndex = 65
        Me.A4Lbl.Text = "Wrong Ans:"
        '
        'MRefreshBtn
        '
        Me.MRefreshBtn.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.MRefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MRefreshBtn.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MRefreshBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MRefreshBtn.Location = New System.Drawing.Point(949, 56)
        Me.MRefreshBtn.Name = "MRefreshBtn"
        Me.MRefreshBtn.Size = New System.Drawing.Size(116, 47)
        Me.MRefreshBtn.TabIndex = 66
        Me.MRefreshBtn.Text = "Update"
        Me.MRefreshBtn.UseVisualStyleBackColor = False
        '
        'MQtnDeleteBtn
        '
        Me.MQtnDeleteBtn.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.MQtnDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MQtnDeleteBtn.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MQtnDeleteBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MQtnDeleteBtn.Location = New System.Drawing.Point(668, 56)
        Me.MQtnDeleteBtn.Name = "MQtnDeleteBtn"
        Me.MQtnDeleteBtn.Size = New System.Drawing.Size(116, 47)
        Me.MQtnDeleteBtn.TabIndex = 67
        Me.MQtnDeleteBtn.Text = "Delete"
        Me.MQtnDeleteBtn.UseVisualStyleBackColor = False
        '
        'MQtnAddBtn
        '
        Me.MQtnAddBtn.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.MQtnAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MQtnAddBtn.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MQtnAddBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MQtnAddBtn.Location = New System.Drawing.Point(807, 56)
        Me.MQtnAddBtn.Name = "MQtnAddBtn"
        Me.MQtnAddBtn.Size = New System.Drawing.Size(116, 47)
        Me.MQtnAddBtn.TabIndex = 68
        Me.MQtnAddBtn.Text = "Add"
        Me.MQtnAddBtn.UseVisualStyleBackColor = False
        '
        'PQtnLst
        '
        Me.PQtnLst.BackColor = System.Drawing.Color.White
        Me.PQtnLst.BackgroundImage = Global.PMQuizV1.My.Resources.Resources.Picture22
        Me.PQtnLst.BackgroundImageTiled = True
        Me.PQtnLst.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.PQtnLst.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PQtnLst.ForeColor = System.Drawing.Color.Black
        Me.PQtnLst.FullRowSelect = True
        Me.PQtnLst.Location = New System.Drawing.Point(29, 109)
        Me.PQtnLst.Name = "PQtnLst"
        Me.PQtnLst.Size = New System.Drawing.Size(1065, 369)
        Me.PQtnLst.TabIndex = 69
        Me.PQtnLst.UseCompatibleStateImageBehavior = False
        Me.PQtnLst.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Question"
        Me.ColumnHeader1.Width = 451
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Correct Ans"
        Me.ColumnHeader2.Width = 158
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Wrong Ans"
        Me.ColumnHeader3.Width = 148
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Wrong Ans"
        Me.ColumnHeader4.Width = 143
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Wrong Ans"
        Me.ColumnHeader5.Width = 147
        '
        'PQtnDeleteBtn
        '
        Me.PQtnDeleteBtn.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.PQtnDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PQtnDeleteBtn.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PQtnDeleteBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PQtnDeleteBtn.Location = New System.Drawing.Point(668, 56)
        Me.PQtnDeleteBtn.Name = "PQtnDeleteBtn"
        Me.PQtnDeleteBtn.Size = New System.Drawing.Size(116, 47)
        Me.PQtnDeleteBtn.TabIndex = 70
        Me.PQtnDeleteBtn.Text = "Delete"
        Me.PQtnDeleteBtn.UseVisualStyleBackColor = False
        '
        'PQtnAddBtn
        '
        Me.PQtnAddBtn.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.PQtnAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PQtnAddBtn.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PQtnAddBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PQtnAddBtn.Location = New System.Drawing.Point(807, 56)
        Me.PQtnAddBtn.Name = "PQtnAddBtn"
        Me.PQtnAddBtn.Size = New System.Drawing.Size(116, 47)
        Me.PQtnAddBtn.TabIndex = 71
        Me.PQtnAddBtn.Text = "Add"
        Me.PQtnAddBtn.UseVisualStyleBackColor = False
        '
        'PRefreshBtn
        '
        Me.PRefreshBtn.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.PRefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PRefreshBtn.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRefreshBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PRefreshBtn.Location = New System.Drawing.Point(949, 56)
        Me.PRefreshBtn.Name = "PRefreshBtn"
        Me.PRefreshBtn.Size = New System.Drawing.Size(116, 47)
        Me.PRefreshBtn.TabIndex = 72
        Me.PRefreshBtn.Text = "Update"
        Me.PRefreshBtn.UseVisualStyleBackColor = False
        '
        'ucEditQuestions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PMQuizV1.My.Resources.Resources.Picture22
        Me.Controls.Add(Me.PRefreshBtn)
        Me.Controls.Add(Me.PQtnAddBtn)
        Me.Controls.Add(Me.PQtnDeleteBtn)
        Me.Controls.Add(Me.PQtnLst)
        Me.Controls.Add(Me.MQtnAddBtn)
        Me.Controls.Add(Me.MQtnDeleteBtn)
        Me.Controls.Add(Me.MRefreshBtn)
        Me.Controls.Add(Me.A4Lbl)
        Me.Controls.Add(Me.A3Lbl)
        Me.Controls.Add(Me.A2Lbl)
        Me.Controls.Add(Me.A1Lbl)
        Me.Controls.Add(Me.QtnLbl)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.PQtnbtn)
        Me.Controls.Add(Me.MQtnbtn)
        Me.Controls.Add(Me.UsrLstBtn)
        Me.Controls.Add(Me.A4txt)
        Me.Controls.Add(Me.A3txt)
        Me.Controls.Add(Me.A2txt)
        Me.Controls.Add(Me.A1txt)
        Me.Controls.Add(Me.Qtntxt)
        Me.Controls.Add(Me.MQtnLst)
        Me.Controls.Add(Me.DeleteUserBtn)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.UserLst)
        Me.Controls.Add(Me.SubTtlLbl)
        Me.Controls.Add(Me.TitleLbl)
        Me.Name = "ucEditQuestions"
        Me.Size = New System.Drawing.Size(1120, 628)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleLbl As Label
    Friend WithEvents SubTtlLbl As Label
    Friend WithEvents UserLst As ListView
    Friend WithEvents ColUser As ColumnHeader
    Friend WithEvents ColPass As ColumnHeader
    Friend WithEvents BackBtn As Button
    Friend WithEvents DeleteUserBtn As Button
    Friend WithEvents MQtnLst As ListView
    Friend WithEvents ColQ As ColumnHeader
    Friend WithEvents ColA1 As ColumnHeader
    Friend WithEvents ColA2 As ColumnHeader
    Friend WithEvents ColA3 As ColumnHeader
    Friend WithEvents ColA4 As ColumnHeader
    Friend WithEvents Qtntxt As TextBox
    Friend WithEvents A1txt As TextBox
    Friend WithEvents A2txt As TextBox
    Friend WithEvents A3txt As TextBox
    Friend WithEvents A4txt As TextBox
    Friend WithEvents UsrLstBtn As Button
    Friend WithEvents MQtnbtn As Button
    Friend WithEvents PQtnbtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents QtnLbl As Label
    Friend WithEvents A1Lbl As Label
    Friend WithEvents A2Lbl As Label
    Friend WithEvents A3Lbl As Label
    Friend WithEvents A4Lbl As Label
    Friend WithEvents MRefreshBtn As Button
    Friend WithEvents MQtnDeleteBtn As Button
    Friend WithEvents MQtnAddBtn As Button
    Friend WithEvents PQtnLst As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents PQtnDeleteBtn As Button
    Friend WithEvents PQtnAddBtn As Button
    Friend WithEvents PRefreshBtn As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.BtnEnd = New System.Windows.Forms.Button()
        Me.GroupAccount = New System.Windows.Forms.GroupBox()
        Me.Typeemail = New System.Windows.Forms.ComboBox()
        Me.ListPass = New System.Windows.Forms.ListBox()
        Me.Listemail = New System.Windows.Forms.ListBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextPass = New System.Windows.Forms.TextBox()
        Me.Textemail = New System.Windows.Forms.TextBox()
        Me.GroupInfo = New System.Windows.Forms.GroupBox()
        Me.SpeedNet = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextID = New System.Windows.Forms.TextBox()
        Me.BtnClsConsole = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListConsole = New System.Windows.Forms.ListBox()
        Me.Facebook = New System.Windows.Forms.WebBrowser()
        Me.BtnAbout = New System.Windows.Forms.Button()
        Me.GroupAccount.SuspendLayout()
        Me.GroupInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnStart
        '
        Me.BtnStart.Location = New System.Drawing.Point(13, 430)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(75, 23)
        Me.BtnStart.TabIndex = 0
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'BtnEnd
        '
        Me.BtnEnd.Location = New System.Drawing.Point(219, 430)
        Me.BtnEnd.Name = "BtnEnd"
        Me.BtnEnd.Size = New System.Drawing.Size(75, 23)
        Me.BtnEnd.TabIndex = 1
        Me.BtnEnd.Text = "Close"
        Me.BtnEnd.UseVisualStyleBackColor = True
        '
        'GroupAccount
        '
        Me.GroupAccount.Controls.Add(Me.Typeemail)
        Me.GroupAccount.Controls.Add(Me.ListPass)
        Me.GroupAccount.Controls.Add(Me.Listemail)
        Me.GroupAccount.Controls.Add(Me.BtnDelete)
        Me.GroupAccount.Controls.Add(Me.BtnAdd)
        Me.GroupAccount.Controls.Add(Me.Label2)
        Me.GroupAccount.Controls.Add(Me.Label1)
        Me.GroupAccount.Controls.Add(Me.TextPass)
        Me.GroupAccount.Controls.Add(Me.Textemail)
        Me.GroupAccount.Location = New System.Drawing.Point(13, 12)
        Me.GroupAccount.Name = "GroupAccount"
        Me.GroupAccount.Size = New System.Drawing.Size(281, 220)
        Me.GroupAccount.TabIndex = 2
        Me.GroupAccount.TabStop = False
        Me.GroupAccount.Text = "Add Account"
        '
        'Typeemail
        '
        Me.Typeemail.FormattingEnabled = True
        Me.Typeemail.Location = New System.Drawing.Point(218, 18)
        Me.Typeemail.Name = "Typeemail"
        Me.Typeemail.Size = New System.Drawing.Size(60, 21)
        Me.Typeemail.TabIndex = 8
        Me.Typeemail.Text = "@gmail.com"
        '
        'ListPass
        '
        Me.ListPass.FormattingEnabled = True
        Me.ListPass.Location = New System.Drawing.Point(142, 101)
        Me.ListPass.Name = "ListPass"
        Me.ListPass.Size = New System.Drawing.Size(130, 95)
        Me.ListPass.TabIndex = 7
        '
        'Listemail
        '
        Me.Listemail.FormattingEnabled = True
        Me.Listemail.Location = New System.Drawing.Point(6, 101)
        Me.Listemail.Name = "Listemail"
        Me.Listemail.Size = New System.Drawing.Size(130, 95)
        Me.Listemail.TabIndex = 6
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(200, 72)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 5
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(61, 72)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 4
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Pass"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "e-mail"
        '
        'TextPass
        '
        Me.TextPass.Location = New System.Drawing.Point(61, 45)
        Me.TextPass.Name = "TextPass"
        Me.TextPass.Size = New System.Drawing.Size(215, 20)
        Me.TextPass.TabIndex = 1
        '
        'Textemail
        '
        Me.Textemail.Location = New System.Drawing.Point(61, 19)
        Me.Textemail.Name = "Textemail"
        Me.Textemail.Size = New System.Drawing.Size(151, 20)
        Me.Textemail.TabIndex = 0
        '
        'GroupInfo
        '
        Me.GroupInfo.Controls.Add(Me.SpeedNet)
        Me.GroupInfo.Controls.Add(Me.Label5)
        Me.GroupInfo.Controls.Add(Me.Label4)
        Me.GroupInfo.Controls.Add(Me.TextID)
        Me.GroupInfo.Controls.Add(Me.BtnClsConsole)
        Me.GroupInfo.Controls.Add(Me.Label3)
        Me.GroupInfo.Controls.Add(Me.ListConsole)
        Me.GroupInfo.Location = New System.Drawing.Point(13, 239)
        Me.GroupInfo.Name = "GroupInfo"
        Me.GroupInfo.Size = New System.Drawing.Size(281, 185)
        Me.GroupInfo.TabIndex = 3
        Me.GroupInfo.TabStop = False
        Me.GroupInfo.Text = "Info"
        '
        'SpeedNet
        '
        Me.SpeedNet.FormattingEnabled = True
        Me.SpeedNet.Location = New System.Drawing.Point(100, 158)
        Me.SpeedNet.Name = "SpeedNet"
        Me.SpeedNet.Size = New System.Drawing.Size(100, 21)
        Me.SpeedNet.TabIndex = 9
        Me.SpeedNet.Text = "Middle"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Speed Network :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ID Victim"
        '
        'TextID
        '
        Me.TextID.Location = New System.Drawing.Point(61, 19)
        Me.TextID.Name = "TextID"
        Me.TextID.Size = New System.Drawing.Size(215, 20)
        Me.TextID.TabIndex = 4
        '
        'BtnClsConsole
        '
        Me.BtnClsConsole.Location = New System.Drawing.Point(206, 156)
        Me.BtnClsConsole.Name = "BtnClsConsole"
        Me.BtnClsConsole.Size = New System.Drawing.Size(75, 23)
        Me.BtnClsConsole.TabIndex = 2
        Me.BtnClsConsole.Text = "Cls Console"
        Me.BtnClsConsole.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Console :"
        '
        'ListConsole
        '
        Me.ListConsole.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListConsole.FormattingEnabled = True
        Me.ListConsole.ItemHeight = 19
        Me.ListConsole.Location = New System.Drawing.Point(61, 45)
        Me.ListConsole.Name = "ListConsole"
        Me.ListConsole.ScrollAlwaysVisible = True
        Me.ListConsole.Size = New System.Drawing.Size(214, 99)
        Me.ListConsole.TabIndex = 0
        '
        'Facebook
        '
        Me.Facebook.Location = New System.Drawing.Point(300, 12)
        Me.Facebook.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Facebook.Name = "Facebook"
        Me.Facebook.Size = New System.Drawing.Size(627, 441)
        Me.Facebook.TabIndex = 4
        Me.Facebook.Tag = "Facebook"
        '
        'BtnAbout
        '
        Me.BtnAbout.Location = New System.Drawing.Point(138, 430)
        Me.BtnAbout.Name = "BtnAbout"
        Me.BtnAbout.Size = New System.Drawing.Size(75, 23)
        Me.BtnAbout.TabIndex = 5
        Me.BtnAbout.Text = "About"
        Me.BtnAbout.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 457)
        Me.Controls.Add(Me.BtnAbout)
        Me.Controls.Add(Me.Facebook)
        Me.Controls.Add(Me.GroupInfo)
        Me.Controls.Add(Me.GroupAccount)
        Me.Controls.Add(Me.BtnEnd)
        Me.Controls.Add(Me.BtnStart)
        Me.Name = "Main"
        Me.Text = "Facebook Reporter 1.0"
        Me.GroupAccount.ResumeLayout(False)
        Me.GroupAccount.PerformLayout()
        Me.GroupInfo.ResumeLayout(False)
        Me.GroupInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnStart As System.Windows.Forms.Button
    Friend WithEvents BtnEnd As System.Windows.Forms.Button
    Friend WithEvents GroupAccount As System.Windows.Forms.GroupBox
    Friend WithEvents Listemail As System.Windows.Forms.ListBox
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextPass As System.Windows.Forms.TextBox
    Friend WithEvents Textemail As System.Windows.Forms.TextBox
    Friend WithEvents GroupInfo As System.Windows.Forms.GroupBox
    Friend WithEvents Facebook As System.Windows.Forms.WebBrowser
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ListConsole As System.Windows.Forms.ListBox
    Friend WithEvents BtnClsConsole As System.Windows.Forms.Button
    Friend WithEvents ListPass As System.Windows.Forms.ListBox
    Friend WithEvents Typeemail As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SpeedNet As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAbout As System.Windows.Forms.Button

End Class

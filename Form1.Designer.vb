<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.txtBox = New System.Windows.Forms.TextBox()
        Me.lBxWeapons = New System.Windows.Forms.ListBox()
        Me.lblWeaponType = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbEnemyName = New System.Windows.Forms.Label()
        Me.btnFight = New System.Windows.Forms.Button()
        Me.txtBxPlayer1Hlth = New System.Windows.Forms.TextBox()
        Me.txtBoxPlayer2Hlth = New System.Windows.Forms.TextBox()
        Me.lblPlyer1Health = New System.Windows.Forms.Label()
        Me.lblPlyer2Health = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.btnDog = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPlayerName
        '
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.Location = New System.Drawing.Point(26, 22)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(67, 13)
        Me.lblPlayerName.TabIndex = 0
        Me.lblPlayerName.Text = "Player Name"
        '
        'txtBox
        '
        Me.txtBox.Location = New System.Drawing.Point(12, 38)
        Me.txtBox.Name = "txtBox"
        Me.txtBox.Size = New System.Drawing.Size(87, 20)
        Me.txtBox.TabIndex = 1
        '
        'lBxWeapons
        '
        Me.lBxWeapons.FormattingEnabled = True
        Me.lBxWeapons.Items.AddRange(New Object() {"ShotGun", "Sword", "Ninja Star", "Wizard Staff"})
        Me.lBxWeapons.Location = New System.Drawing.Point(14, 95)
        Me.lBxWeapons.Name = "lBxWeapons"
        Me.lBxWeapons.Size = New System.Drawing.Size(84, 69)
        Me.lBxWeapons.TabIndex = 2
        '
        'lblWeaponType
        '
        Me.lblWeaponType.AutoSize = True
        Me.lblWeaponType.Location = New System.Drawing.Point(26, 79)
        Me.lblWeaponType.Name = "lblWeaponType"
        Me.lblWeaponType.Size = New System.Drawing.Size(48, 13)
        Me.lblWeaponType.TabIndex = 3
        Me.lblWeaponType.Text = "Weapon"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(280, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Weapon"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"ShotGun", "Sword", "Ninja Star", "Wizard Staff"})
        Me.ListBox1.Location = New System.Drawing.Point(268, 95)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(84, 69)
        Me.ListBox1.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(266, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(87, 20)
        Me.TextBox1.TabIndex = 5
        '
        'lbEnemyName
        '
        Me.lbEnemyName.AutoSize = True
        Me.lbEnemyName.Location = New System.Drawing.Point(280, 22)
        Me.lbEnemyName.Name = "lbEnemyName"
        Me.lbEnemyName.Size = New System.Drawing.Size(70, 13)
        Me.lbEnemyName.TabIndex = 4
        Me.lbEnemyName.Text = "Enemy Name"
        '
        'btnFight
        '
        Me.btnFight.Location = New System.Drawing.Point(133, 239)
        Me.btnFight.Name = "btnFight"
        Me.btnFight.Size = New System.Drawing.Size(73, 31)
        Me.btnFight.TabIndex = 8
        Me.btnFight.Text = "Fight!"
        Me.btnFight.UseVisualStyleBackColor = True
        '
        'txtBxPlayer1Hlth
        '
        Me.txtBxPlayer1Hlth.Location = New System.Drawing.Point(15, 183)
        Me.txtBxPlayer1Hlth.Name = "txtBxPlayer1Hlth"
        Me.txtBxPlayer1Hlth.Size = New System.Drawing.Size(83, 20)
        Me.txtBxPlayer1Hlth.TabIndex = 9
        '
        'txtBoxPlayer2Hlth
        '
        Me.txtBoxPlayer2Hlth.Location = New System.Drawing.Point(270, 183)
        Me.txtBoxPlayer2Hlth.Name = "txtBoxPlayer2Hlth"
        Me.txtBoxPlayer2Hlth.Size = New System.Drawing.Size(83, 20)
        Me.txtBoxPlayer2Hlth.TabIndex = 10
        '
        'lblPlyer1Health
        '
        Me.lblPlyer1Health.AutoSize = True
        Me.lblPlyer1Health.Location = New System.Drawing.Point(26, 220)
        Me.lblPlyer1Health.Name = "lblPlyer1Health"
        Me.lblPlyer1Health.Size = New System.Drawing.Size(39, 13)
        Me.lblPlyer1Health.TabIndex = 11
        Me.lblPlyer1Health.Text = "Label2"
        '
        'lblPlyer2Health
        '
        Me.lblPlyer2Health.AutoSize = True
        Me.lblPlyer2Health.Location = New System.Drawing.Point(289, 220)
        Me.lblPlyer2Health.Name = "lblPlyer2Health"
        Me.lblPlyer2Health.Size = New System.Drawing.Size(39, 13)
        Me.lblPlyer2Health.TabIndex = 12
        Me.lblPlyer2Health.Text = "Label2"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 247)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 13
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(266, 247)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar2.TabIndex = 14
        '
        'btnDog
        '
        Me.btnDog.Location = New System.Drawing.Point(133, 210)
        Me.btnDog.Name = "btnDog"
        Me.btnDog.Size = New System.Drawing.Size(75, 23)
        Me.btnDog.TabIndex = 15
        Me.btnDog.Text = "Dog"
        Me.btnDog.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 363)
        Me.Controls.Add(Me.btnDog)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lblPlyer2Health)
        Me.Controls.Add(Me.lblPlyer1Health)
        Me.Controls.Add(Me.txtBoxPlayer2Hlth)
        Me.Controls.Add(Me.txtBxPlayer1Hlth)
        Me.Controls.Add(Me.btnFight)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbEnemyName)
        Me.Controls.Add(Me.lblWeaponType)
        Me.Controls.Add(Me.lBxWeapons)
        Me.Controls.Add(Me.txtBox)
        Me.Controls.Add(Me.lblPlayerName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPlayerName As Label
    Friend WithEvents txtBox As TextBox
    Friend WithEvents lBxWeapons As ListBox
    Friend WithEvents lblWeaponType As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lbEnemyName As Label
    Friend WithEvents btnFight As Button
    Friend WithEvents txtBxPlayer1Hlth As TextBox
    Friend WithEvents txtBoxPlayer2Hlth As TextBox
    Friend WithEvents lblPlyer1Health As Label
    Friend WithEvents lblPlyer2Health As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents btnDog As Button
End Class

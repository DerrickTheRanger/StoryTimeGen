<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class battle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.btnFight = New System.Windows.Forms.Button()
        Me.lblPlyr2Hlth = New System.Windows.Forms.Label()
        Me.lblPlyr1Hlth = New System.Windows.Forms.Label()
        Me.btnPlyr1Stats = New System.Windows.Forms.Button()
        Me.btnPlyr2Stats = New System.Windows.Forms.Button()
        Me.Plyr1Weapon = New System.Windows.Forms.Button()
        Me.Plyr2Weapon = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.LblHlth = New System.Windows.Forms.Label()
        Me.LblEP = New System.Windows.Forms.Label()
        Me.lblPlyr1EP = New System.Windows.Forms.Label()
        Me.lblPlyr2EP = New System.Windows.Forms.Label()
        Me.LblPain = New System.Windows.Forms.Label()
        Me.pbrPlyr2P = New System.Windows.Forms.ProgressBar()
        Me.pbrPlyr1P = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'btnFight
        '
        Me.btnFight.Location = New System.Drawing.Point(89, 12)
        Me.btnFight.Name = "btnFight"
        Me.btnFight.Size = New System.Drawing.Size(73, 31)
        Me.btnFight.TabIndex = 8
        Me.btnFight.Text = "Fight!"
        Me.btnFight.UseVisualStyleBackColor = True
        '
        'lblPlyr2Hlth
        '
        Me.lblPlyr2Hlth.AutoSize = True
        Me.lblPlyr2Hlth.Location = New System.Drawing.Point(170, 76)
        Me.lblPlyr2Hlth.Name = "lblPlyr2Hlth"
        Me.lblPlyr2Hlth.Size = New System.Drawing.Size(73, 13)
        Me.lblPlyr2Hlth.TabIndex = 11
        Me.lblPlyr2Hlth.Text = "Player2Health"
        Me.lblPlyr2Hlth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPlyr1Hlth
        '
        Me.lblPlyr1Hlth.AutoSize = True
        Me.lblPlyr1Hlth.Location = New System.Drawing.Point(5, 76)
        Me.lblPlyr1Hlth.Name = "lblPlyr1Hlth"
        Me.lblPlyr1Hlth.Size = New System.Drawing.Size(71, 13)
        Me.lblPlyr1Hlth.TabIndex = 12
        Me.lblPlyr1Hlth.Text = "Player1health"
        Me.lblPlyr1Hlth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPlyr1Stats
        '
        Me.btnPlyr1Stats.Location = New System.Drawing.Point(8, 16)
        Me.btnPlyr1Stats.Name = "btnPlyr1Stats"
        Me.btnPlyr1Stats.Size = New System.Drawing.Size(75, 23)
        Me.btnPlyr1Stats.TabIndex = 35
        Me.btnPlyr1Stats.Text = "Player1"
        Me.btnPlyr1Stats.UseVisualStyleBackColor = True
        '
        'btnPlyr2Stats
        '
        Me.btnPlyr2Stats.Location = New System.Drawing.Point(168, 16)
        Me.btnPlyr2Stats.Name = "btnPlyr2Stats"
        Me.btnPlyr2Stats.Size = New System.Drawing.Size(75, 23)
        Me.btnPlyr2Stats.TabIndex = 36
        Me.btnPlyr2Stats.Text = "Player2"
        Me.btnPlyr2Stats.UseVisualStyleBackColor = True
        '
        'Plyr1Weapon
        '
        Me.Plyr1Weapon.Location = New System.Drawing.Point(8, 45)
        Me.Plyr1Weapon.Name = "Plyr1Weapon"
        Me.Plyr1Weapon.Size = New System.Drawing.Size(75, 23)
        Me.Plyr1Weapon.TabIndex = 40
        Me.Plyr1Weapon.Text = "Weapon"
        Me.Plyr1Weapon.UseVisualStyleBackColor = True
        '
        'Plyr2Weapon
        '
        Me.Plyr2Weapon.Location = New System.Drawing.Point(168, 45)
        Me.Plyr2Weapon.Name = "Plyr2Weapon"
        Me.Plyr2Weapon.Size = New System.Drawing.Size(75, 23)
        Me.Plyr2Weapon.TabIndex = 41
        Me.Plyr2Weapon.Text = "Weapon"
        Me.Plyr2Weapon.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(89, 49)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(73, 23)
        Me.btnReset.TabIndex = 42
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'LblHlth
        '
        Me.LblHlth.AutoSize = True
        Me.LblHlth.Location = New System.Drawing.Point(102, 75)
        Me.LblHlth.Name = "LblHlth"
        Me.LblHlth.Size = New System.Drawing.Size(38, 13)
        Me.LblHlth.TabIndex = 43
        Me.LblHlth.Text = "Health"
        Me.LblHlth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblEP
        '
        Me.LblEP.AutoSize = True
        Me.LblEP.Location = New System.Drawing.Point(112, 89)
        Me.LblEP.Name = "LblEP"
        Me.LblEP.Size = New System.Drawing.Size(21, 13)
        Me.LblEP.TabIndex = 46
        Me.LblEP.Text = "EP"
        Me.LblEP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlyr1EP
        '
        Me.lblPlyr1EP.AutoSize = True
        Me.lblPlyr1EP.Location = New System.Drawing.Point(5, 89)
        Me.lblPlyr1EP.Name = "lblPlyr1EP"
        Me.lblPlyr1EP.Size = New System.Drawing.Size(56, 13)
        Me.lblPlyr1EP.TabIndex = 45
        Me.lblPlyr1EP.Text = "Player1EP"
        Me.lblPlyr1EP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPlyr2EP
        '
        Me.lblPlyr2EP.AutoSize = True
        Me.lblPlyr2EP.Location = New System.Drawing.Point(170, 89)
        Me.lblPlyr2EP.Name = "lblPlyr2EP"
        Me.lblPlyr2EP.Size = New System.Drawing.Size(56, 13)
        Me.lblPlyr2EP.TabIndex = 44
        Me.lblPlyr2EP.Text = "Player2EP"
        Me.lblPlyr2EP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblPain
        '
        Me.LblPain.AutoSize = True
        Me.LblPain.Location = New System.Drawing.Point(112, 105)
        Me.LblPain.Name = "LblPain"
        Me.LblPain.Size = New System.Drawing.Size(28, 13)
        Me.LblPain.TabIndex = 49
        Me.LblPain.Text = "Pain"
        Me.LblPain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbrPlyr2P
        '
        Me.pbrPlyr2P.Location = New System.Drawing.Point(146, 105)
        Me.pbrPlyr2P.Name = "pbrPlyr2P"
        Me.pbrPlyr2P.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pbrPlyr2P.Size = New System.Drawing.Size(97, 23)
        Me.pbrPlyr2P.TabIndex = 50
        '
        'pbrPlyr1P
        '
        Me.pbrPlyr1P.Location = New System.Drawing.Point(8, 105)
        Me.pbrPlyr1P.Name = "pbrPlyr1P"
        Me.pbrPlyr1P.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pbrPlyr1P.Size = New System.Drawing.Size(97, 23)
        Me.pbrPlyr1P.TabIndex = 51
        '
        'battle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 135)
        Me.Controls.Add(Me.pbrPlyr1P)
        Me.Controls.Add(Me.pbrPlyr2P)
        Me.Controls.Add(Me.LblPain)
        Me.Controls.Add(Me.LblEP)
        Me.Controls.Add(Me.lblPlyr1EP)
        Me.Controls.Add(Me.lblPlyr2EP)
        Me.Controls.Add(Me.LblHlth)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Plyr2Weapon)
        Me.Controls.Add(Me.Plyr1Weapon)
        Me.Controls.Add(Me.btnPlyr2Stats)
        Me.Controls.Add(Me.btnPlyr1Stats)
        Me.Controls.Add(Me.lblPlyr1Hlth)
        Me.Controls.Add(Me.lblPlyr2Hlth)
        Me.Controls.Add(Me.btnFight)
        Me.Name = "battle"
        Me.Text = "battle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFight As Button
    Friend WithEvents lblPlyr2Hlth As Label
    Friend WithEvents lblPlyr1Hlth As Label
    Friend WithEvents btnPlyr2Stats As Button
    Friend WithEvents btnPlyr1Stats As Button
    Friend WithEvents Plyr1Weapon As Button
    Friend WithEvents Plyr2Weapon As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents LblHlth As Label
    Friend WithEvents LblEP As Label
    Friend WithEvents lblPlyr1EP As Label
    Friend WithEvents lblPlyr2EP As Label
    Friend WithEvents LblPain As Label
    Friend WithEvents pbrPlyr2P As ProgressBar
    Friend WithEvents pbrPlyr1P As ProgressBar
End Class

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
        Me.lblPlyer2Health = New System.Windows.Forms.Label()
        Me.lblPlyer1Health = New System.Windows.Forms.Label()
        Me.btnPlyr1Stats = New System.Windows.Forms.Button()
        Me.btnPlyr2Stats = New System.Windows.Forms.Button()
        Me.Plyr1Weapon = New System.Windows.Forms.Button()
        Me.Plyr2Weapon = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
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
        'lblPlyer2Health
        '
        Me.lblPlyer2Health.AutoSize = True
        Me.lblPlyer2Health.Location = New System.Drawing.Point(170, 76)
        Me.lblPlyer2Health.Name = "lblPlyer2Health"
        Me.lblPlyer2Health.Size = New System.Drawing.Size(73, 13)
        Me.lblPlyer2Health.TabIndex = 11
        Me.lblPlyer2Health.Text = "Player2Health"
        '
        'lblPlyer1Health
        '
        Me.lblPlyer1Health.AutoSize = True
        Me.lblPlyer1Health.Location = New System.Drawing.Point(5, 76)
        Me.lblPlyer1Health.Name = "lblPlyer1Health"
        Me.lblPlyer1Health.Size = New System.Drawing.Size(71, 13)
        Me.lblPlyer1Health.TabIndex = 12
        Me.lblPlyer1Health.Text = "Player1health"
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
        'battle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 97)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Plyr2Weapon)
        Me.Controls.Add(Me.Plyr1Weapon)
        Me.Controls.Add(Me.btnPlyr2Stats)
        Me.Controls.Add(Me.btnPlyr1Stats)
        Me.Controls.Add(Me.lblPlyer1Health)
        Me.Controls.Add(Me.lblPlyer2Health)
        Me.Controls.Add(Me.btnFight)
        Me.Name = "battle"
        Me.Text = "battle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFight As Button
    Friend WithEvents lblPlyer2Health As Label
    Friend WithEvents lblPlyer1Health As Label
    Friend WithEvents btnPlyr2Stats As Button
    Friend WithEvents btnPlyr1Stats As Button
    Friend WithEvents Plyr1Weapon As Button
    Friend WithEvents Plyr2Weapon As Button
    Friend WithEvents btnReset As Button
End Class

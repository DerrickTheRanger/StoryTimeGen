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
        Me.txtBxPlayer1Dmg = New System.Windows.Forms.TextBox()
        Me.txtBxPlayer2dmg = New System.Windows.Forms.TextBox()
        Me.lblDmg = New System.Windows.Forms.Label()
        Me.lblPlyer1Health = New System.Windows.Forms.Label()
        Me.btnPlyr1Stats = New System.Windows.Forms.Button()
        Me.btnPlyr2Stats = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnFight
        '
        Me.btnFight.Location = New System.Drawing.Point(96, 38)
        Me.btnFight.Name = "btnFight"
        Me.btnFight.Size = New System.Drawing.Size(73, 31)
        Me.btnFight.TabIndex = 8
        Me.btnFight.Text = "Fight!"
        Me.btnFight.UseVisualStyleBackColor = True
        '
        'lblPlyer2Health
        '
        Me.lblPlyer2Health.AutoSize = True
        Me.lblPlyer2Health.Location = New System.Drawing.Point(177, 79)
        Me.lblPlyer2Health.Name = "lblPlyer2Health"
        Me.lblPlyer2Health.Size = New System.Drawing.Size(73, 13)
        Me.lblPlyer2Health.TabIndex = 11
        Me.lblPlyer2Health.Text = "Player2Health"
        '
        'txtBxPlayer1Dmg
        '
        Me.txtBxPlayer1Dmg.Location = New System.Drawing.Point(12, 12)
        Me.txtBxPlayer1Dmg.Name = "txtBxPlayer1Dmg"
        Me.txtBxPlayer1Dmg.ReadOnly = True
        Me.txtBxPlayer1Dmg.Size = New System.Drawing.Size(100, 20)
        Me.txtBxPlayer1Dmg.TabIndex = 16
        '
        'txtBxPlayer2dmg
        '
        Me.txtBxPlayer2dmg.Location = New System.Drawing.Point(153, 12)
        Me.txtBxPlayer2dmg.Name = "txtBxPlayer2dmg"
        Me.txtBxPlayer2dmg.ReadOnly = True
        Me.txtBxPlayer2dmg.Size = New System.Drawing.Size(100, 20)
        Me.txtBxPlayer2dmg.TabIndex = 17
        '
        'lblDmg
        '
        Me.lblDmg.AutoSize = True
        Me.lblDmg.Location = New System.Drawing.Point(118, 15)
        Me.lblDmg.Name = "lblDmg"
        Me.lblDmg.Size = New System.Drawing.Size(29, 13)
        Me.lblDmg.TabIndex = 22
        Me.lblDmg.Text = "Dmg"
        '
        'lblPlyer1Health
        '
        Me.lblPlyer1Health.AutoSize = True
        Me.lblPlyer1Health.Location = New System.Drawing.Point(9, 79)
        Me.lblPlyer1Health.Name = "lblPlyer1Health"
        Me.lblPlyer1Health.Size = New System.Drawing.Size(71, 13)
        Me.lblPlyer1Health.TabIndex = 12
        Me.lblPlyer1Health.Text = "Player1health"
        '
        'btnPlyr1Stats
        '
        Me.btnPlyr1Stats.Location = New System.Drawing.Point(8, 42)
        Me.btnPlyr1Stats.Name = "btnPlyr1Stats"
        Me.btnPlyr1Stats.Size = New System.Drawing.Size(75, 23)
        Me.btnPlyr1Stats.TabIndex = 35
        Me.btnPlyr1Stats.Text = "Player1"
        Me.btnPlyr1Stats.UseVisualStyleBackColor = True
        '
        'btnPlyr2Stats
        '
        Me.btnPlyr2Stats.Location = New System.Drawing.Point(175, 42)
        Me.btnPlyr2Stats.Name = "btnPlyr2Stats"
        Me.btnPlyr2Stats.Size = New System.Drawing.Size(75, 23)
        Me.btnPlyr2Stats.TabIndex = 36
        Me.btnPlyr2Stats.Text = "Player2"
        Me.btnPlyr2Stats.UseVisualStyleBackColor = True
        '
        'battle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 104)
        Me.Controls.Add(Me.btnPlyr2Stats)
        Me.Controls.Add(Me.btnPlyr1Stats)
        Me.Controls.Add(Me.lblPlyer1Health)
        Me.Controls.Add(Me.lblDmg)
        Me.Controls.Add(Me.txtBxPlayer2dmg)
        Me.Controls.Add(Me.txtBxPlayer1Dmg)
        Me.Controls.Add(Me.lblPlyer2Health)
        Me.Controls.Add(Me.btnFight)
        Me.Name = "battle"
        Me.Text = "battle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFight As Button
    Friend WithEvents lblPlyer2Health As Label
    Friend WithEvents txtBxPlayer1Dmg As TextBox
    Friend WithEvents txtBxPlayer2dmg As TextBox
    Friend WithEvents lblDmg As Label
    Friend WithEvents lblPlyer1Health As Label
    Friend WithEvents btnPlyr2Stats As Button
    Friend WithEvents btnPlyr1Stats As Button
End Class

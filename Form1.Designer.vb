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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnFight = New System.Windows.Forms.Button()
        Me.txtBxPlayer2Hlth = New System.Windows.Forms.TextBox()
        Me.lblPlyer2Health = New System.Windows.Forms.Label()
        Me.txtBxPlayer1Dmg = New System.Windows.Forms.TextBox()
        Me.txtBxPlayer2dmg = New System.Windows.Forms.TextBox()
        Me.lblPlayer1name = New System.Windows.Forms.Label()
        Me.LbHlth = New System.Windows.Forms.Label()
        Me.lblDmg = New System.Windows.Forms.Label()
        Me.txtBxPlayer2Armor = New System.Windows.Forms.TextBox()
        Me.txtBxPlayer2Resilience = New System.Windows.Forms.TextBox()
        Me.txtBxPlayer2EP = New System.Windows.Forms.TextBox()
        Me.txtBxPlayer2PainLimit = New System.Windows.Forms.TextBox()
        Me.lblEP = New System.Windows.Forms.Label()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.LblResilience = New System.Windows.Forms.Label()
        Me.LblPainLimit = New System.Windows.Forms.Label()
        Me.lblPlyer1Health = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(286, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        '
        'btnFight
        '
        Me.btnFight.Location = New System.Drawing.Point(532, 624)
        Me.btnFight.Name = "btnFight"
        Me.btnFight.Size = New System.Drawing.Size(73, 31)
        Me.btnFight.TabIndex = 8
        Me.btnFight.Text = "Fight!"
        Me.btnFight.UseVisualStyleBackColor = True
        '
        'txtBxPlayer2Hlth
        '
        Me.txtBxPlayer2Hlth.Location = New System.Drawing.Point(286, 64)
        Me.txtBxPlayer2Hlth.Name = "txtBxPlayer2Hlth"
        Me.txtBxPlayer2Hlth.Size = New System.Drawing.Size(100, 20)
        Me.txtBxPlayer2Hlth.TabIndex = 10
        Me.txtBxPlayer2Hlth.Text = "50"
        '
        'lblPlyer2Health
        '
        Me.lblPlyer2Health.AutoSize = True
        Me.lblPlyer2Health.Location = New System.Drawing.Point(626, 559)
        Me.lblPlyer2Health.Name = "lblPlyer2Health"
        Me.lblPlyer2Health.Size = New System.Drawing.Size(73, 13)
        Me.lblPlyer2Health.TabIndex = 11
        Me.lblPlyer2Health.Text = "Player2Health"
        '
        'txtBxPlayer1Dmg
        '
        Me.txtBxPlayer1Dmg.Location = New System.Drawing.Point(557, 116)
        Me.txtBxPlayer1Dmg.Name = "txtBxPlayer1Dmg"
        Me.txtBxPlayer1Dmg.Size = New System.Drawing.Size(100, 20)
        Me.txtBxPlayer1Dmg.TabIndex = 16
        '
        'txtBxPlayer2dmg
        '
        Me.txtBxPlayer2dmg.Location = New System.Drawing.Point(758, 116)
        Me.txtBxPlayer2dmg.Name = "txtBxPlayer2dmg"
        Me.txtBxPlayer2dmg.Size = New System.Drawing.Size(100, 20)
        Me.txtBxPlayer2dmg.TabIndex = 17
        '
        'lblPlayer1name
        '
        Me.lblPlayer1name.AutoSize = True
        Me.lblPlayer1name.Location = New System.Drawing.Point(157, 38)
        Me.lblPlayer1name.Name = "lblPlayer1name"
        Me.lblPlayer1name.Size = New System.Drawing.Size(67, 13)
        Me.lblPlayer1name.TabIndex = 20
        Me.lblPlayer1name.Text = "Player Name"
        '
        'LbHlth
        '
        Me.LbHlth.AutoSize = True
        Me.LbHlth.Location = New System.Drawing.Point(157, 64)
        Me.LbHlth.Name = "LbHlth"
        Me.LbHlth.Size = New System.Drawing.Size(36, 13)
        Me.LbHlth.TabIndex = 21
        Me.LbHlth.Text = "health"
        '
        'lblDmg
        '
        Me.lblDmg.AutoSize = True
        Me.lblDmg.Location = New System.Drawing.Point(690, 123)
        Me.lblDmg.Name = "lblDmg"
        Me.lblDmg.Size = New System.Drawing.Size(29, 13)
        Me.lblDmg.TabIndex = 22
        Me.lblDmg.Text = "Dmg"
        '
        'txtBxPlayer2Armor
        '
        Me.txtBxPlayer2Armor.Location = New System.Drawing.Point(286, 116)
        Me.txtBxPlayer2Armor.Name = "txtBxPlayer2Armor"
        Me.txtBxPlayer2Armor.Size = New System.Drawing.Size(100, 20)
        Me.txtBxPlayer2Armor.TabIndex = 26
        Me.txtBxPlayer2Armor.Text = "50"
        '
        'txtBxPlayer2Resilience
        '
        Me.txtBxPlayer2Resilience.Location = New System.Drawing.Point(286, 142)
        Me.txtBxPlayer2Resilience.Name = "txtBxPlayer2Resilience"
        Me.txtBxPlayer2Resilience.Size = New System.Drawing.Size(100, 20)
        Me.txtBxPlayer2Resilience.TabIndex = 27
        Me.txtBxPlayer2Resilience.Text = "0"
        '
        'txtBxPlayer2EP
        '
        Me.txtBxPlayer2EP.Location = New System.Drawing.Point(286, 90)
        Me.txtBxPlayer2EP.Name = "txtBxPlayer2EP"
        Me.txtBxPlayer2EP.Size = New System.Drawing.Size(100, 20)
        Me.txtBxPlayer2EP.TabIndex = 28
        Me.txtBxPlayer2EP.Text = "100"
        '
        'txtBxPlayer2PainLimit
        '
        Me.txtBxPlayer2PainLimit.Location = New System.Drawing.Point(286, 168)
        Me.txtBxPlayer2PainLimit.Name = "txtBxPlayer2PainLimit"
        Me.txtBxPlayer2PainLimit.Size = New System.Drawing.Size(100, 20)
        Me.txtBxPlayer2PainLimit.TabIndex = 30
        Me.txtBxPlayer2PainLimit.Text = "100"
        '
        'lblEP
        '
        Me.lblEP.AutoSize = True
        Me.lblEP.Location = New System.Drawing.Point(157, 90)
        Me.lblEP.Name = "lblEP"
        Me.lblEP.Size = New System.Drawing.Size(21, 13)
        Me.lblEP.TabIndex = 31
        Me.lblEP.Text = "EP"
        '
        'Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Location = New System.Drawing.Point(157, 116)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(34, 13)
        Me.Lbl.TabIndex = 32
        Me.Lbl.Text = "Armor"
        '
        'LblResilience
        '
        Me.LblResilience.AutoSize = True
        Me.LblResilience.Location = New System.Drawing.Point(157, 145)
        Me.LblResilience.Name = "LblResilience"
        Me.LblResilience.Size = New System.Drawing.Size(56, 13)
        Me.LblResilience.TabIndex = 33
        Me.LblResilience.Text = "Resilience"
        '
        'LblPainLimit
        '
        Me.LblPainLimit.AutoSize = True
        Me.LblPainLimit.Location = New System.Drawing.Point(157, 168)
        Me.LblPainLimit.Name = "LblPainLimit"
        Me.LblPainLimit.Size = New System.Drawing.Size(49, 13)
        Me.LblPainLimit.TabIndex = 34
        Me.LblPainLimit.Text = "PainLimit"
        '
        'lblPlyer1Health
        '
        Me.lblPlyer1Health.AutoSize = True
        Me.lblPlyer1Health.Location = New System.Drawing.Point(448, 559)
        Me.lblPlyer1Health.Name = "lblPlyer1Health"
        Me.lblPlyer1Health.Size = New System.Drawing.Size(71, 13)
        Me.lblPlyer1Health.TabIndex = 12
        Me.lblPlyer1Health.Text = "Player1health"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 216)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'battle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 667)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblPlyer1Health)
        Me.Controls.Add(Me.LblPainLimit)
        Me.Controls.Add(Me.LblResilience)
        Me.Controls.Add(Me.Lbl)
        Me.Controls.Add(Me.lblEP)
        Me.Controls.Add(Me.txtBxPlayer2PainLimit)
        Me.Controls.Add(Me.txtBxPlayer2EP)
        Me.Controls.Add(Me.txtBxPlayer2Resilience)
        Me.Controls.Add(Me.txtBxPlayer2Armor)
        Me.Controls.Add(Me.lblDmg)
        Me.Controls.Add(Me.LbHlth)
        Me.Controls.Add(Me.lblPlayer1name)
        Me.Controls.Add(Me.txtBxPlayer2dmg)
        Me.Controls.Add(Me.txtBxPlayer1Dmg)
        Me.Controls.Add(Me.lblPlyer2Health)
        Me.Controls.Add(Me.txtBxPlayer2Hlth)
        Me.Controls.Add(Me.btnFight)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "battle"
        Me.Text = "battel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnFight As Button
    Friend WithEvents txtBxPlayer2Hlth As TextBox
    Friend WithEvents lblPlyer2Health As Label
    Friend WithEvents txtBxPlayer1Dmg As TextBox
    Friend WithEvents txtBxPlayer2dmg As TextBox
    Friend WithEvents lblPlayer1name As Label
    Friend WithEvents LbHlth As Label
    Friend WithEvents lblDmg As Label
    Friend WithEvents txtBxPlayer2Armor As TextBox
    Friend WithEvents txtBxPlayer2Resilience As TextBox
    Friend WithEvents txtBxPlayer2EP As TextBox
    Friend WithEvents txtBxPlayer2PainLimit As TextBox
    Friend WithEvents lblEP As Label
    Friend WithEvents Lbl As Label
    Friend WithEvents LblResilience As Label
    Friend WithEvents LblPainLimit As Label
    Friend WithEvents lblPlyer1Health As Label
    Friend WithEvents Button1 As Button
End Class

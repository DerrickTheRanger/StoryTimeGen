<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlyr2Stats
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
        Me.LblPainLimit = New System.Windows.Forms.Label()
        Me.LblResilience = New System.Windows.Forms.Label()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.lblEP = New System.Windows.Forms.Label()
        Me.txtBxPlayer2PainLimit = New System.Windows.Forms.TextBox()
        Me.txtBxPlayer2EP = New System.Windows.Forms.TextBox()
        Me.txtBxPlayer2Resilience = New System.Windows.Forms.TextBox()
        Me.txtBxPlayer2Armor = New System.Windows.Forms.TextBox()
        Me.LbHlth = New System.Windows.Forms.Label()
        Me.lblPlayer1name = New System.Windows.Forms.Label()
        Me.txtBxPlayer2Hlth = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblPainLimit
        '
        Me.LblPainLimit.AutoSize = True
        Me.LblPainLimit.Location = New System.Drawing.Point(118, 145)
        Me.LblPainLimit.Name = "LblPainLimit"
        Me.LblPainLimit.Size = New System.Drawing.Size(49, 13)
        Me.LblPainLimit.TabIndex = 46
        Me.LblPainLimit.Text = "PainLimit"
        '
        'LblResilience
        '
        Me.LblResilience.AutoSize = True
        Me.LblResilience.Location = New System.Drawing.Point(118, 122)
        Me.LblResilience.Name = "LblResilience"
        Me.LblResilience.Size = New System.Drawing.Size(56, 13)
        Me.LblResilience.TabIndex = 45
        Me.LblResilience.Text = "Resilience"
        '
        'Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Location = New System.Drawing.Point(118, 93)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(34, 13)
        Me.Lbl.TabIndex = 44
        Me.Lbl.Text = "Armor"
        '
        'lblEP
        '
        Me.lblEP.AutoSize = True
        Me.lblEP.Location = New System.Drawing.Point(118, 67)
        Me.lblEP.Name = "lblEP"
        Me.lblEP.Size = New System.Drawing.Size(21, 13)
        Me.lblEP.TabIndex = 43
        Me.lblEP.Text = "EP"
        '
        'txtBxPlayer2PainLimit
        '
        Me.txtBxPlayer2PainLimit.Location = New System.Drawing.Point(12, 142)
        Me.txtBxPlayer2PainLimit.Name = "txtBxPlayer2PainLimit"
        Me.txtBxPlayer2PainLimit.Size = New System.Drawing.Size(100, 20)
        Me.txtBxPlayer2PainLimit.TabIndex = 42
        Me.txtBxPlayer2PainLimit.Text = "100"
        '
        'txtBxPlayer2EP
        '
        Me.txtBxPlayer2EP.Location = New System.Drawing.Point(12, 64)
        Me.txtBxPlayer2EP.Name = "txtBxPlayer2EP"
        Me.txtBxPlayer2EP.Size = New System.Drawing.Size(100, 20)
        Me.txtBxPlayer2EP.TabIndex = 41
        Me.txtBxPlayer2EP.Text = "100"
        '
        'txtBxPlayer2Resilience
        '
        Me.txtBxPlayer2Resilience.Location = New System.Drawing.Point(12, 116)
        Me.txtBxPlayer2Resilience.Name = "txtBxPlayer2Resilience"
        Me.txtBxPlayer2Resilience.Size = New System.Drawing.Size(100, 20)
        Me.txtBxPlayer2Resilience.TabIndex = 40
        Me.txtBxPlayer2Resilience.Text = "0"
        '
        'txtBxPlayer2Armor
        '
        Me.txtBxPlayer2Armor.Location = New System.Drawing.Point(12, 90)
        Me.txtBxPlayer2Armor.Name = "txtBxPlayer2Armor"
        Me.txtBxPlayer2Armor.Size = New System.Drawing.Size(100, 20)
        Me.txtBxPlayer2Armor.TabIndex = 39
        Me.txtBxPlayer2Armor.Text = "50"
        '
        'LbHlth
        '
        Me.LbHlth.AutoSize = True
        Me.LbHlth.Location = New System.Drawing.Point(118, 41)
        Me.LbHlth.Name = "LbHlth"
        Me.LbHlth.Size = New System.Drawing.Size(36, 13)
        Me.LbHlth.TabIndex = 38
        Me.LbHlth.Text = "health"
        '
        'lblPlayer1name
        '
        Me.lblPlayer1name.AutoSize = True
        Me.lblPlayer1name.Location = New System.Drawing.Point(118, 15)
        Me.lblPlayer1name.Name = "lblPlayer1name"
        Me.lblPlayer1name.Size = New System.Drawing.Size(67, 13)
        Me.lblPlayer1name.TabIndex = 37
        Me.lblPlayer1name.Text = "Player Name"
        '
        'txtBxPlayer2Hlth
        '
        Me.txtBxPlayer2Hlth.Location = New System.Drawing.Point(12, 38)
        Me.txtBxPlayer2Hlth.Name = "txtBxPlayer2Hlth"
        Me.txtBxPlayer2Hlth.Size = New System.Drawing.Size(100, 20)
        Me.txtBxPlayer2Hlth.TabIndex = 36
        Me.txtBxPlayer2Hlth.Text = "50"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 35
        '
        'frmPlyr2Stats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 450)
        Me.Controls.Add(Me.LblPainLimit)
        Me.Controls.Add(Me.LblResilience)
        Me.Controls.Add(Me.Lbl)
        Me.Controls.Add(Me.lblEP)
        Me.Controls.Add(Me.txtBxPlayer2PainLimit)
        Me.Controls.Add(Me.txtBxPlayer2EP)
        Me.Controls.Add(Me.txtBxPlayer2Resilience)
        Me.Controls.Add(Me.txtBxPlayer2Armor)
        Me.Controls.Add(Me.LbHlth)
        Me.Controls.Add(Me.lblPlayer1name)
        Me.Controls.Add(Me.txtBxPlayer2Hlth)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "frmPlyr2Stats"
        Me.Text = "Player2Stats"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblPainLimit As Label
    Friend WithEvents LblResilience As Label
    Friend WithEvents Lbl As Label
    Friend WithEvents lblEP As Label
    Friend WithEvents txtBxPlayer2PainLimit As TextBox
    Friend WithEvents txtBxPlayer2EP As TextBox
    Friend WithEvents txtBxPlayer2Resilience As TextBox
    Friend WithEvents txtBxPlayer2Armor As TextBox
    Friend WithEvents LbHlth As Label
    Friend WithEvents lblPlayer1name As Label
    Friend WithEvents txtBxPlayer2Hlth As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class

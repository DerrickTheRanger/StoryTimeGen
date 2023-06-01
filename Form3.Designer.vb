<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlyr1Stats
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
        Me.txtBxPlayer1PainLimit = New System.Windows.Forms.TextBox()
        Me.txtBxPlayer1Resilience = New System.Windows.Forms.TextBox()
        Me.txtBxPlayer1Armor = New System.Windows.Forms.TextBox()
        Me.txtBxPlayer1EP = New System.Windows.Forms.TextBox()
        Me.LbHlth = New System.Windows.Forms.Label()
        Me.lblPlayer1name = New System.Windows.Forms.Label()
        Me.txtBxplyr1name = New System.Windows.Forms.TextBox()
        Me.txtBxPlayer1Hlth = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblPainLimit
        '
        Me.LblPainLimit.AutoSize = True
        Me.LblPainLimit.Location = New System.Drawing.Point(163, 142)
        Me.LblPainLimit.Name = "LblPainLimit"
        Me.LblPainLimit.Size = New System.Drawing.Size(49, 13)
        Me.LblPainLimit.TabIndex = 46
        Me.LblPainLimit.Text = "PainLimit"
        '
        'LblResilience
        '
        Me.LblResilience.AutoSize = True
        Me.LblResilience.Location = New System.Drawing.Point(163, 119)
        Me.LblResilience.Name = "LblResilience"
        Me.LblResilience.Size = New System.Drawing.Size(56, 13)
        Me.LblResilience.TabIndex = 45
        Me.LblResilience.Text = "Resilience"
        '
        'Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Location = New System.Drawing.Point(163, 90)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(34, 13)
        Me.Lbl.TabIndex = 44
        Me.Lbl.Text = "Armor"
        '
        'lblEP
        '
        Me.lblEP.AutoSize = True
        Me.lblEP.Location = New System.Drawing.Point(163, 64)
        Me.lblEP.Name = "lblEP"
        Me.lblEP.Size = New System.Drawing.Size(21, 13)
        Me.lblEP.TabIndex = 43
        Me.lblEP.Text = "EP"
        '
        'txtBxPlayer1PainLimit
        '
        Me.txtBxPlayer1PainLimit.Location = New System.Drawing.Point(12, 142)
        Me.txtBxPlayer1PainLimit.Name = "txtBxPlayer1PainLimit"
        Me.txtBxPlayer1PainLimit.Size = New System.Drawing.Size(100, 20)
        Me.txtBxPlayer1PainLimit.TabIndex = 42
        Me.txtBxPlayer1PainLimit.Text = "100"
        '
        'txtBxPlayer1Resilience
        '
        Me.txtBxPlayer1Resilience.Location = New System.Drawing.Point(12, 116)
        Me.txtBxPlayer1Resilience.Name = "txtBxPlayer1Resilience"
        Me.txtBxPlayer1Resilience.Size = New System.Drawing.Size(100, 20)
        Me.txtBxPlayer1Resilience.TabIndex = 41
        Me.txtBxPlayer1Resilience.Text = "0"
        '
        'txtBxPlayer1Armor
        '
        Me.txtBxPlayer1Armor.Location = New System.Drawing.Point(12, 90)
        Me.txtBxPlayer1Armor.Name = "txtBxPlayer1Armor"
        Me.txtBxPlayer1Armor.Size = New System.Drawing.Size(100, 20)
        Me.txtBxPlayer1Armor.TabIndex = 40
        Me.txtBxPlayer1Armor.Text = "50"
        '
        'txtBxPlayer1EP
        '
        Me.txtBxPlayer1EP.Location = New System.Drawing.Point(12, 64)
        Me.txtBxPlayer1EP.Name = "txtBxPlayer1EP"
        Me.txtBxPlayer1EP.Size = New System.Drawing.Size(100, 20)
        Me.txtBxPlayer1EP.TabIndex = 39
        Me.txtBxPlayer1EP.Text = "100"
        '
        'LbHlth
        '
        Me.LbHlth.AutoSize = True
        Me.LbHlth.Location = New System.Drawing.Point(163, 38)
        Me.LbHlth.Name = "LbHlth"
        Me.LbHlth.Size = New System.Drawing.Size(36, 13)
        Me.LbHlth.TabIndex = 38
        Me.LbHlth.Text = "health"
        '
        'lblPlayer1name
        '
        Me.lblPlayer1name.AutoSize = True
        Me.lblPlayer1name.Location = New System.Drawing.Point(163, 12)
        Me.lblPlayer1name.Name = "lblPlayer1name"
        Me.lblPlayer1name.Size = New System.Drawing.Size(67, 13)
        Me.lblPlayer1name.TabIndex = 37
        Me.lblPlayer1name.Text = "Player Name"
        '
        'txtBxplyr1name
        '
        Me.txtBxplyr1name.Location = New System.Drawing.Point(12, 12)
        Me.txtBxplyr1name.Name = "txtBxplyr1name"
        Me.txtBxplyr1name.Size = New System.Drawing.Size(100, 20)
        Me.txtBxplyr1name.TabIndex = 36
        '
        'txtBxPlayer1Hlth
        '
        Me.txtBxPlayer1Hlth.Location = New System.Drawing.Point(12, 38)
        Me.txtBxPlayer1Hlth.Name = "txtBxPlayer1Hlth"
        Me.txtBxPlayer1Hlth.Size = New System.Drawing.Size(100, 20)
        Me.txtBxPlayer1Hlth.TabIndex = 35
        Me.txtBxPlayer1Hlth.Text = "50"
        '
        'frmPlyr1Stats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 450)
        Me.Controls.Add(Me.LblPainLimit)
        Me.Controls.Add(Me.LblResilience)
        Me.Controls.Add(Me.Lbl)
        Me.Controls.Add(Me.lblEP)
        Me.Controls.Add(Me.txtBxPlayer1PainLimit)
        Me.Controls.Add(Me.txtBxPlayer1Resilience)
        Me.Controls.Add(Me.txtBxPlayer1Armor)
        Me.Controls.Add(Me.txtBxPlayer1EP)
        Me.Controls.Add(Me.LbHlth)
        Me.Controls.Add(Me.lblPlayer1name)
        Me.Controls.Add(Me.txtBxplyr1name)
        Me.Controls.Add(Me.txtBxPlayer1Hlth)
        Me.Name = "frmPlyr1Stats"
        Me.Text = "Player1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblPainLimit As Label
    Friend WithEvents LblResilience As Label
    Friend WithEvents Lbl As Label
    Friend WithEvents lblEP As Label
    Friend WithEvents txtBxPlayer1PainLimit As TextBox
    Friend WithEvents txtBxPlayer1Resilience As TextBox
    Friend WithEvents txtBxPlayer1Armor As TextBox
    Friend WithEvents txtBxPlayer1EP As TextBox
    Friend WithEvents LbHlth As Label
    Friend WithEvents lblPlayer1name As Label
    Friend WithEvents txtBxplyr1name As TextBox
    Friend WithEvents txtBxPlayer1Hlth As TextBox
End Class

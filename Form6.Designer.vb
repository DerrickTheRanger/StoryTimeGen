<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActionPlyr1
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
        Me.gopbxOffense = New System.Windows.Forms.GroupBox()
        Me.rbtnStrike = New System.Windows.Forms.RadioButton()
        Me.gopbxOffense.SuspendLayout()
        Me.SuspendLayout()
        '
        'gopbxOffense
        '
        Me.gopbxOffense.Controls.Add(Me.rbtnStrike)
        Me.gopbxOffense.Location = New System.Drawing.Point(12, 12)
        Me.gopbxOffense.Name = "gopbxOffense"
        Me.gopbxOffense.Size = New System.Drawing.Size(88, 177)
        Me.gopbxOffense.TabIndex = 0
        Me.gopbxOffense.TabStop = False
        Me.gopbxOffense.Text = "Offense"
        '
        'rbtnStrike
        '
        Me.rbtnStrike.AutoSize = True
        Me.rbtnStrike.Location = New System.Drawing.Point(6, 19)
        Me.rbtnStrike.Name = "rbtnStrike"
        Me.rbtnStrike.Size = New System.Drawing.Size(52, 17)
        Me.rbtnStrike.TabIndex = 0
        Me.rbtnStrike.TabStop = True
        Me.rbtnStrike.Text = "Strike"
        Me.rbtnStrike.UseVisualStyleBackColor = True
        '
        'frmActionPlyr1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 202)
        Me.Controls.Add(Me.gopbxOffense)
        Me.Name = "frmActionPlyr1"
        Me.Text = "Form6"
        Me.gopbxOffense.ResumeLayout(False)
        Me.gopbxOffense.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gopbxOffense As GroupBox
    Friend WithEvents rbtnStrike As RadioButton
End Class

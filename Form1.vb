Public Class battle



    Private Sub btnFight_Click(sender As Object, e As EventArgs) Handles btnFight.Click

        Dim OneHealth As Double
        OneHealth = frmPlyr1Stats.txtBxPlayer1Hlth.Text
        Dim OneEP As Double
        OneEP = frmPlyr1Stats.txtBxPlayer1EP.Text
        Dim OneArmor As Double
        OneArmor = frmPlyr1Stats.txtBxPlayer1Armor.Text
        Dim OneResilience As Double
        OneResilience = frmPlyr1Stats.txtBxPlayer1Resilience.Text
        Dim OnePainLimit As Double
        OnePainLimit = frmPlyr1Stats.txtBxPlayer1PainLimit.Text
        Dim OneDmg As Double
        OneDmg = txtBxPlayer1Dmg.Text

        'Player One Active Stats

        Dim TwoHealth As Double
        TwoHealth = txtBxPlayer2Hlth.Text
        Dim TwoEP As Double
        TwoEP = txtBxPlayer2EP.Text
        Dim TwoArmor As Double
        TwoArmor = txtBxPlayer2Armor.Text
        Dim TwoResilience As Double
        TwoResilience = txtBxPlayer2Resilience.Text
        Dim TwoPainLimit As Double
        TwoPainLimit = txtBxPlayer2PainLimit.Text
        Dim TwoDmg As Double
        TwoDmg = txtBxPlayer2dmg.Text

        'Player Two Active Stats
        Dim WinnerOne As Boolean
        'win thing


        Dim PlayerOneResault As Double
        Dim PlayerTwoResault As Double
        PlayerOneResault = OneHealth - TwoDmg
        PlayerTwoResault = TwoHealth - OneDmg

        If PlayerOneResault > PlayerTwoResault Then
            WinnerOne = True
        End If

        If WinnerOne = True Then
            MsgBox("Player One Wins!")
        ElseIf WinnerOne = False Then
            MsgBox("Player Two Wins!")
        End If

        lblPlyer2Health.Text = PlayerOneResault
        lblPlyer1Health.Text = PlayerTwoResault


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmPlyr1Stats.Show()

    End Sub
End Class

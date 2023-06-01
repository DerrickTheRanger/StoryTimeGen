Public Class battle
    'Player One Form1 Global Values
    Dim OneDmg As Double = 100 'Leave it set's a default

    'Player Two Form1 Global Values
    Dim TwoDmg As Double = 100 'Leave it set's a default




    'Runs at start of form
    Private Sub Start() Handles Me.Activated
        txtBxPlayer1Dmg.Text = OneDmg

        txtBxPlayer2dmg.Text = TwoDmg
    End Sub

    Private Sub btnFight_Click(sender As Object, e As EventArgs) Handles btnFight.Click



        'Player One Active Stats
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




        'Player One Stats
        Dim OneStr As Double
        OneStr = frmPlyr1Stats.txtbxPlyr1Str.Text
        Dim Onepow As Double
        Onepow = frmPlyr1Stats.txtbxPlyr1Pow.Text
        Dim OneEnd As Double
        OneEnd = frmPlyr1Stats.txtbxPlyr1End.Text
        Dim OneVit As Double
        OneVit = frmPlyr1Stats.txtbxPlyr1Vit.Text
        Dim OneAgi As Double
        OneAgi = frmPlyr1Stats.txtbxPlyr1Agi.Text
        Dim OneDex As Double
        OneDex = frmPlyr1Stats.txtbxPlyr1Dxt.Text
        Dim OneInt As Double
        OneInt = frmPlyr1Stats.txtbxPlyr1Int.Text
        Dim OneCha As Double
        OneCha = frmPlyr1Stats.txtbxPlyr1Cha.Text

        OneDmg = OneStr + Onepow + OneEnd + OneVit + OneAgi + OneDex + OneInt + OneCha

        ' OneDmg = txtBxPlayer1Dmg.Text

        'Player Two Active Stats
        Dim TwoHealth As Double
        TwoHealth = frmPlyr2Stats.txtBxPlayer2Hlth.Text
        Dim TwoEP As Double
        TwoEP = frmPlyr2Stats.txtBxPlayer2EP.Text
        Dim TwoArmor As Double
        TwoArmor = frmPlyr2Stats.txtBxPlayer2Armor.Text
        Dim TwoResilience As Double
        TwoResilience = frmPlyr2Stats.txtBxPlayer2Resilience.Text
        Dim TwoPainLimit As Double
        TwoPainLimit = frmPlyr2Stats.txtBxPlayer2PainLimit.Text




        'Player Two Stats
        Dim TwoStr As Double
        TwoStr = frmPlyr2Stats.txtbxPlyr2Str.Text
        Dim Twopow As Double
        Twopow = frmPlyr2Stats.txtbxPlyr2Pow.Text
        Dim TwoEnd As Double
        TwoEnd = frmPlyr2Stats.txtbxPlyr2End.Text
        Dim TwoVit As Double
        TwoVit = frmPlyr2Stats.txtbxPlyr2Vit.Text
        Dim TwoAgi As Double
        TwoAgi = frmPlyr2Stats.txtbxPlyr2Agi.Text
        Dim TwoDex As Double
        TwoDex = frmPlyr2Stats.txtbxPlyr2Dxt.Text
        Dim TwoInt As Double
        TwoInt = frmPlyr2Stats.txtbxPlyr2Int.Text
        Dim TwoCha As Double
        TwoCha = frmPlyr2Stats.txtbxPlyr2Cha.Text

        TwoDmg = TwoStr + Twopow + TwoEnd + TwoVit + TwoAgi + TwoDex + TwoInt + TwoCha


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

        lblPlyer1Health.Text = PlayerOneResault
        lblPlyer2Health.Text = PlayerTwoResault


    End Sub

    Private Sub btnPlyr1Stats_Click(sender As Object, e As EventArgs) Handles btnPlyr1Stats.Click
        frmPlyr1Stats.Show()

    End Sub

    Private Sub btnPlyr2Stats_Click(sender As Object, e As EventArgs) Handles btnPlyr2Stats.Click
        frmPlyr2Stats.Show()

    End Sub


End Class

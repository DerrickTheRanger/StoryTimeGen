Public Class Form1

    Dim Dont As Double = 5



    Private Sub btnFight_Click(sender As Object, e As EventArgs) Handles btnFight.Click
        Dim Onehealth As Double
        Dim PlayerOneResault As Double
        Dim Twohealth As Double
        Dim PlayerTwoResault As Double
        Dim WinnerOne As Boolean
        Onehealth = txtBxPlayer1Hlth.Text
        Twohealth = txtBoxPlayer2Hlth.Text

        PlayerOneResault = Onehealth - Twohealth
        PlayerTwoResault = Twohealth - Onehealth

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

        Meow()

    End Sub

    Private Sub Meow()
        Dont = 500
        MsgBox("Poop")
    End Sub

    Private Sub ResetVars()
        Dont = 5
    End Sub
End Class

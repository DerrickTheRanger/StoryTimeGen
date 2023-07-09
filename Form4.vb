Public Class FrmPlyr1Wpn
    Private Sub FrmPlyr1Wpn_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim HeadLength As Double
        HeadLength = txtBxPlyr1WpnHL.Text
        Dim HiltLength As Double
        HiltLength = txtBxPlyr1WpnHtL.Text
        Dim Hold As Double
        Hold = txtBxPlyr1WpnH.Text
        Dim HeadMass As Double
        HeadMass = txtBxPlyr1WpnHM.Text
        Dim HiltMass As Double
        HiltMass = txtBxPlyr1WpnHtM.Text
        Dim Balince As Double
        Balince = txtBxPlyr1WpnB.Text
        Dim BaseCost As Double
        BaseCost = txtBxPlyr1WpnBC.Text
        Dim Pain As Double
        Pain = txtBxPlyr1WpnP.Text
        Dim Dmg As Double
        Dmg = ((HeadLength + HiltLength - Hold) * HeadMass) * (Balince * 2 * 3)
        txtBxPlyr1WpnD.Text = Dmg


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCalculateDmg.Click

        Dim HeadLength As Double
        HeadLength = txtBxPlyr1WpnHL.Text
        Dim HiltLength As Double
        HiltLength = txtBxPlyr1WpnHtL.Text
        Dim Hold As Double
        Hold = txtBxPlyr1WpnH.Text
        Dim HeadMass As Double
        HeadMass = txtBxPlyr1WpnHM.Text
        Dim HiltMass As Double
        HiltMass = txtBxPlyr1WpnHtM.Text
        Dim Balince As Double
        Balince = txtBxPlyr1WpnB.Text
        Dim BaseCost As Double
        BaseCost = txtBxPlyr1WpnBC.Text
        Dim Pain As Double
        Pain = txtBxPlyr1WpnP.Text
        Dim Dmg As Double
        Dmg = ((HeadLength + HiltLength - Hold) * HeadMass) * (Balince * 2 * 3)
        txtBxPlyr1WpnD.Text = Dmg

    End Sub
End Class
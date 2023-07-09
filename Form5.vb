Public Class FrmPlyr2Wpn

    Private Sub FrmPlyr2Wpn_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim HeadLength As Double
        HeadLength = txtBxPlyr2WpnHL.Text
        Dim HiltLength As Double
        HiltLength = txtBxPlyr2WpnHtL.Text
        Dim Hold As Double
        Hold = txtBxPlyr2WpnH.Text
        Dim HeadMass As Double
        HeadMass = txtBxPlyr2WpnHM.Text
        Dim HiltMass As Double
        HiltMass = txtBxPlyr2WpnHtM.Text
        Dim Balince As Double
        Balince = txtBxPlyr2WpnB.Text
        Dim BaseCost As Double
        BaseCost = txtBxPlyr2WpnBC.Text
        Dim Pain As Double
        Pain = txtBxPlyr2WpnP.Text
        Dim Dmg As Double
        Dmg = ((HeadLength + HiltLength - Hold) * HeadMass) * (Balince * 2 * 3)
        txtBxPlyr2WpnD.Text = Dmg


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCalculateDmg.Click

        Dim HeadLength As Double
        HeadLength = txtBxPlyr2WpnHL.Text
        Dim HiltLength As Double
        HiltLength = txtBxPlyr2WpnHtL.Text
        Dim Hold As Double
        Hold = txtBxPlyr2WpnH.Text
        Dim HeadMass As Double
        HeadMass = txtBxPlyr2WpnHM.Text
        Dim HiltMass As Double
        HiltMass = txtBxPlyr2WpnHtM.Text
        Dim Balince As Double
        Balince = txtBxPlyr2WpnB.Text
        Dim BaseCost As Double
        BaseCost = txtBxPlyr2WpnBC.Text
        Dim Pain As Double
        Pain = txtBxPlyr2WpnP.Text
        Dim Dmg As Double
        Dmg = ((HeadLength + HiltLength - Hold) * HeadMass) * (Balince * 2 * 3)
        txtBxPlyr2WpnD.Text = Dmg

    End Sub
End Class
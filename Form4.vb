Public Class FrmPlyr1Wpn
    Private Sub FrmPlyr1Wpn_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim HeadLength As Double
        HeadLength = txtBxPlyr1WpnHL.Text
        Dim HiltLength As Double
        HiltLength = txtBxPlyr1WpnHtL.Text
        Dim Hold As Double
        Hold = txtBxPlyr1WpnH.Text
        Dim WeaponMass As Double
        WeaponMass = txtBxPlyr1WpnWM.Text
        Dim BaseCost As Double
        BaseCost = txtBxPlyr1WpnBC.Text
        Dim Pain As Double
        Pain = txtBxPlyr1WpnP.Text
        Dim Dmg As Double
        Dmg = (HeadLength + HiltLength - Hold) * WeaponMass
        txtBxPlyr1WpnD.Text = Dmg


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCalculateDmg.Click

        Dim HeadLength As Double
        HeadLength = txtBxPlyr1WpnHL.Text
        Dim HiltLength As Double
        HiltLength = txtBxPlyr1WpnHtL.Text
        Dim Hold As Double
        Hold = txtBxPlyr1WpnH.Text
        Dim WeaponMass As Double
        WeaponMass = txtBxPlyr1WpnWM.Text
        Dim BaseCost As Double
        BaseCost = txtBxPlyr1WpnBC.Text
        Dim Pain As Double
        Pain = txtBxPlyr1WpnP.Text
        Dim Dmg As Double
        Dmg = (HeadLength + HiltLength - Hold) * WeaponMass
        txtBxPlyr1WpnD.Text = Dmg

    End Sub

End Class
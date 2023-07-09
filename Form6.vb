Public Class frmActionPlyr1

    Dim Strike As Boolean

    Private Sub rbtnStrike_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnStrike.CheckedChanged

        If Strike = False Then
            Strike = True
        ElseIf Strike = True Then
            Strike = False
        End If

    End Sub
End Class
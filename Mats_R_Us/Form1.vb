'Joshua Pickenpaugh
'"Mats-R-Us" calculator, September 19th, 2016

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the app:
        Me.Close()

    End Sub

    Private Function TypeOfMat(ByVal decT As Decimal) As Decimal

        Const decSTANDARD As Decimal = 99.0
        Const decDELUXE As Decimal = 129.0
        Const decPREMIUM As Decimal = 179.0

        If rdoStandard.Checked Then
            decT = decSTANDARD
        ElseIf rdoDeluxe.Checked Then
            decT = decDELUXE
        ElseIf rdoPremium.Checked Then
            decT = decPREMIUM
        End If

        Return decT

    End Function

    Private Function ColorOfMat(ByVal decT As Decimal) As Decimal

        Const decBLUE As Decimal = 2.0
        Const decRED As Decimal = 10.0
        Const decPINK As Decimal = 15.0

        If rdoBlue.Checked Then
            decT = decT + decBLUE
        ElseIf rdoRed.Checked Then
            decT = decT + decRED
        ElseIf rdoPink.Checked Then
            decT = decT + decPINK
        End If

        Return decT

    End Function

    Private Function IsFoldable(ByVal decT As Decimal) As Decimal

        Const decFOLDABLE As Decimal = 25.0

        If chkFoldable.Checked Then
            decT = decT + decFOLDABLE
        End If

        Return decT

    End Function


    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Dim decTotal As Decimal

        'Calculates "Type":
        decTotal = TypeOfMat(decTotal)

        'Adds "Color"
        decTotal = ColorOfMat(decTotal)

        'Add optional "Foldable"
        decTotal = IsFoldable(decTotal)

        lblTotal.Text = decTotal.ToString("C2")

    End Sub

    Private Sub rdoStandard_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdoStandard.CheckedChanged

        'Clears the label:
        lblTotal.Text = ""

    End Sub

    Private Sub rdoDeluxe_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdoDeluxe.CheckedChanged

        'Clears the label:
        lblTotal.Text = ""

    End Sub

    Private Sub rdoPremium_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdoPremium.CheckedChanged

        'Clears the label:
        lblTotal.Text = ""

    End Sub

    Private Sub rdoBlue_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdoBlue.CheckedChanged

        'Clears the label:
        lblTotal.Text = ""

    End Sub

    Private Sub rdoRed_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdoRed.CheckedChanged
        'Clears the label:
        lblTotal.Text = ""

    End Sub

    Private Sub rdoPink_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdoPink.CheckedChanged

        'Clears the label:
        lblTotal.Text = ""

    End Sub

    Private Sub chkFoldable_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkFoldable.CheckedChanged

        'Clears the label:
        lblTotal.Text = ""

    End Sub


End Class

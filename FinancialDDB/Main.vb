﻿'Joshua Pickenpaugh
'November 5th, 2016
'Deprication Calculator

Public Class Main

    Dim dblAssetCost As Double = 0
    Dim dblSalvageValue As Double = 0
    Dim dblUsefulLife As Double = 0
    Dim strHeading As String = "Year     Deprication"
    Dim dblDep As Double = 0

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the app:
        Me.Close()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        dblAssetCost = txtAssetCost.Text
        dblSalvageValue = txtSalvageValue.Text
        Double.TryParse(lstUsefulLife.SelectedItem.ToString, dblUsefulLife)

        'Heading for the text box:
        txtSchedule.Text = strHeading & ControlChars.NewLine

        'Code modified from http://stackoverflow.com/questions/5613924/financial-ddb-function-vb-net
        For Intterm As Integer = 1 To dblUsefulLife
            dblDep = Financial.DDB(dblAssetCost, dblSalvageValue, dblUsefulLife, Intterm)
            txtSchedule.Text = txtSchedule.Text & ControlChars.NewLine & Intterm.ToString & "            " _
                & dblDep.ToString("c2")

        Next

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Populates the list box with score numbers:
        For intUsefulYear As Double = 3 To 20 Step 1
            lstUsefulLife.Items.Add(intUsefulYear.ToString("N0"))
        Next intUsefulYear

        'Selects number 0 onload:
        lstUsefulLife.SelectedItem = "3"

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clears the text boxes, lables, and variables:
        txtAssetCost.Text = String.Empty
        txtSalvageValue.Text = String.Empty
        txtSchedule.Text = String.Empty

        dblAssetCost = 0
        dblSalvageValue = 0
        dblUsefulLife = 0
        dblDep = 0

        'Resets focus in the list box:
        lstUsefulLife.SelectedItem = "3"

    End Sub
End Class

'Joshua Pickenpaugh
'November 5th, 2016
'Deprication Calculator

Public Class Main

    Dim dblAssetCost As Double = 0
    Dim dblSalvageValue As Double = 0
    Dim dblUsefulLife As Double = 0


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the app:
        Me.Close()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        dblAssetCost = txtAssetCost.Text
        dblSalvageValue = txtSalvageValue.Text
        Double.TryParse(lstUsefulLife.SelectedItem.ToString, dblUsefulLife)





    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Populates the list box with score numbers:
        For intUsefulYear As Double = 3 To 20 Step 1
            lstUsefulLife.Items.Add(intUsefulYear.ToString("N0"))
        Next intUsefulYear

        'Selects number 0 onload:
        lstUsefulLife.SelectedItem = "3"

    End Sub
End Class

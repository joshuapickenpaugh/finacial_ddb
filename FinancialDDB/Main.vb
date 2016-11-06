'Joshua Pickenpaugh
'November 5th, 2016
'Deprication Calculator

Public Class Main
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the app:
        Me.Close()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Financial.DDB()

    End Sub
End Class

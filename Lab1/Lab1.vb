Option Strict On
Public Class frmLab1
    'ARRAY/STATEMENTS
    Dim arrayUnits(6) As Integer
    Dim indexIncrement As Integer
    Dim totUnits As Integer
    Dim avgUnits As Double
    Const maxIncrement As Integer = 7
    Const minValue As Integer = 0
    Const maxValue As Integer = 1000

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Ends application
        Application.Exit()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'STATEMENTS
        Dim inputInt As Integer

        'Checks if there is input within the textbox
        If (Len(txtInput.Text) = 0) Then
            btnEnter.Enabled = False
            'Disables Enter button if textbox is empty
        Else
            'Checks if input is an integer
            If (Integer.TryParse(txtInput.Text, inputInt)) Then

                'Checks if imput is  within range
                If (inputInt <= maxValue And inputInt >= minValue) = True Then

                    lblResult.ForeColor = Color.Black 'Changes Results label to black forecolour post error
                    lblResult.Text = ""

                    'Converts input into integer and stores it into the array
                    arrayUnits(indexIncrement) = Convert.ToInt32(txtInput.Text)
                    txtAllUnits.Text += arrayUnits(indexIncrement) & vbCrLf
                    indexIncrement += 1 'Incrementer

                    'Initiates calculation once 7 days of units have been filled in
                    If (indexIncrement = maxIncrement) Then
                        btnEnter.Enabled = False
                        For indexIncrement = 0 To maxIncrement - 1
                            totUnits += arrayUnits(indexIncrement)
                            'Totals all units
                        Next
                        avgUnits = totUnits / (maxIncrement)
                        'Calculates Average Units
                        lblResult.Text = "Average per day: " & avgUnits.ToString("n2") '.ToString("n2") rounds to 2 decimal places
                    End If
                    txtInput.Text = ""
                    lblDays.Text = "Day: " & indexIncrement + 1
                    'Day incrementer

                    If (indexIncrement = maxIncrement) Then
                        lblDays.Text = "Day: " 'Sets Days to none during calculation
                        txtInput.Enabled = False
                        'Disables Enter once all 7 days have been entered
                    End If
                Else
                    'Produces Error message for bad range
                    lblResult.ForeColor = Color.Red
                    lblResult.Text = "Bad input, please input a value between 0 and 1000"
                    txtInput.Text = ""
                End If
            Else
                'Produces Error message for bad inputs
                lblResult.ForeColor = Color.Red
                lblResult.Text = "Bad input, please input an Integer"
                txtInput.Text = ""
            End If
        End If

    End Sub

    Private Sub txtAllUnits_TextChanged(sender As Object, e As EventArgs) Handles txtAllUnits.TextChanged

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Resets the array
        For incrementReset As Integer = 0 To maxIncrement - 1
            arrayUnits(incrementReset) = 0
        Next

        'Clears/Resets all text
        txtInput.Text = ""
        txtAllUnits.Text = ""
        lblResult.Text = ""
        lblDays.Text = "Day: 1"

        'Enables specific controls post disabling
        btnEnter.Enabled = True
        txtInput.Enabled = True

        'Resets variables to 0
        indexIncrement = 0
        totUnits = 0
        avgUnits = 0

        'Shifts focus back to the input control
        txtInput.Focus()
    End Sub

    Private Sub lblDays_Click(sender As Object, e As EventArgs) Handles lblDays.Click

    End Sub
End Class

' Shaiyur Dooken - 151 757 - BSc IT
' Programming 511
' Question One - Wallpaper App
Public Class Form1
    ' These global variables are used for the calculation of the wallpaper rolls later on
    Dim intLength As Integer
    Dim intWidth As Integer
    Dim intHeight As Integer
    Dim dblCoverage As Integer
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the entire application
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Adds the required values to the relevant comboboxes
        For intStart As Integer = 10 To 35
            cmbHeight.Items.Add(intStart)

            cmbWidth.Items.Add(intStart)

            cmbLength.Items.Add(intStart)
        Next intStart

        ' Adds the required values to the combobox for Roll Coverage
        For dblStart As Double = 40 To 50 Step 0.5
            cmbRollCoverage.Items.Add(dblStart)
        Next dblStart

        btnCalculate.Enabled = False

        ' Disables Maximise button on title bar and prevents the user from resizing the window borders
        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub

    Private Sub cmbLength_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLength.SelectedIndexChanged
        ' Clears the text entry for the amount of rolls
        txtSingle.Clear()
    End Sub

    Private Sub cmbWidth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbWidth.SelectedIndexChanged
        ' Clears the text entry for the amount of rolls
        txtSingle.Clear()
    End Sub

    Private Sub cmbHeight_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHeight.SelectedIndexChanged
        ' Clears the text entry for the amount of rolls
        txtSingle.Clear()
    End Sub

    Private Sub cmbRollCoverage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRollCoverage.SelectedIndexChanged
        ' Clears the text entry for the amount of rolls
        txtSingle.Clear()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Calls a function to calculate and return the number of rolls, then output it
        txtSingle.Text = CalculateRolls(intLength, intWidth, intHeight, dblCoverage)

        ' Disables the calculate button, to prevent the application from being exploited or broken...
        btnCalculate.Enabled = False
    End Sub

    Private Function CalculateRolls(intLen As Integer, intWid As Integer, intHei As Integer, dblCov As Double) As Integer
        ' Formula: TSA = (l * h * 2 + w * h * 2) / cov (l = length, w = width, h = height, cov = roll coverage)
        Dim intTSA As Integer = Math.Ceiling((intLen * intHei * 2 + intWid * intHei * 2) / dblCov)

        Return intTSA
    End Function

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        ' Stores users selections from the comboboxes into the global variables
        intLength = cmbLength.SelectedItem
        intWidth = cmbWidth.SelectedItem
        intHeight = cmbHeight.SelectedItem
        dblCoverage = cmbRollCoverage.SelectedItem

        If intLength <= 0 Or intWidth <= 0 Or intHeight <= 0 Or dblCoverage <= 0 Then

            MsgBox("Please select a value from the combo box and ensure that you did not" &
                    " type a value in...")
        Else
            btnCalculate.Enabled = True
        End If
    End Sub
End Class

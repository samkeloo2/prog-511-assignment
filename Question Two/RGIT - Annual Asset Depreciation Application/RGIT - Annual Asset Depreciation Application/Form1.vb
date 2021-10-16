' Shaiyur Dooken - 151 757
' Programming 511
' Question Two: Annual Asset Depreciation Application
Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes the entire application
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Adds values to the UsefulLife combobox as specified by the question
        For intStart As Integer = 3 To 20
            cmbUsefulLife.Items.Add(intStart)
        Next intStart

        ' Prevents the user from maximising the application and resizing the window borders
        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Try
            Dim dblCost As Double = txtAsset.Text
            Dim dblSalvage As Double = txtSalvage.Text
            Dim intUseful As Integer = cmbUsefulLife.Text

            ' Clears the list boxes before displaying the values
            lstDouble.Items.Clear()
            lstSum.Items.Clear()

            ' Heading for the Double Declining Balance listbox
            lstDouble.Items.Add("Year:" & vbTab & "Depreciation:")

            ' Calculates the depreciation for each month using the Double Declining Balance method
            For I As Integer = 1 To 5
                lstDouble.Items.Add(I & vbTab & Financial.DDB(dblCost, dblSalvage, intUseful, I).ToString("C2"))
            Next I

            ' Heading for Sum of the Year Digits method
            lstSum.Items.Add("Year:" & vbTab & "Depreciation:")

            ' Calculates the depreciation for each month using the Sum of the Year Digits method
            For I As Integer = 1 To 5
                lstSum.Items.Add(I & vbTab & Financial.SYD(dblCost, dblSalvage, intUseful, I).ToString("C2"))
            Next I
        Catch ex As Exception
            MsgBox("There may be an issue with your input, as an exception was raised." &
                   " Please try again.")
        End Try
    End Sub
End Class

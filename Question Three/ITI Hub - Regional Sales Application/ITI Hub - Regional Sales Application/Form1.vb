' Shaiyur Dooken - 151 757
' Programming 511 - Question Three
' ITI Hub : Regional Sales
Public Class Form1
    'Global Variables:
    Dim intRows As Integer = 5
    Dim intColumns As Integer = 3
    Dim nl As String = vbNewLine

    ' Creates a global 6x3 2D Array to store the regional sales:
    Dim intArraySales(intRows, intColumns) As Integer
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes the entire application
        Me.Close()
    End Sub

    Private Sub btnEnterSales_Click(sender As Object, e As EventArgs) Handles btnEnterSales.Click
        Dim strRegion As String = ""

        ' Automatically generate contributions based on the assignment booklet.
        If chkGenerateAuto.Checked Then
            AutomaticArray()
        Else
            Try
                ' Allows the user to enter the region's sales manually. If there's an error,
                ' the application will automatically revert to the hardcoded array.
                For intMonth As Integer = 0 To intRows
                    For intRegion As Integer = 1 To intColumns
                        If intRegion = 1 Then
                            strRegion = "Kwa-Zulu-Natal"
                        ElseIf intRegion = 2 Then
                            strRegion = "Gauteng"
                        Else
                            strRegion = "Western Cape"
                        End If

                        intArraySales(intMonth, intRegion) = InputBox("Enter the sales for " & strRegion &
                                                                      " , Month " & intMonth + 1 & ":",
                                                                      "Notice:", "0")
                    Next intRegion
                Next intMonth

            Catch ex As Exception
                MsgBox("We've detected an exception being raised. Reverting to hard-coded array...")
                AutomaticArray()
            End Try

        End If

        rtbOutput.AppendText("The array containing the regional sales has been generated successfully..." & nl)

        btnDisplay.Enabled = True
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim intKZN As Integer = 0
        Dim intGau As Integer = 0
        Dim intWC As Integer = 0
        Dim intSum As Integer = 0

        rtbOutput.Clear()

        rtbOutput.SelectionTabs = {50, 200, 300, 450}

        rtbOutput.AppendText("Month:" & vbTab & "Kwa-Zulu-Natal Sales:" & vbTab & "Gauteng Sales:" &
                             vbTab & "Western Cape Sales:" & nl)
        rtbOutput.AppendText(nl)

        'Use this for output:
        For intMonth As Integer = 0 To intRows
            rtbOutput.AppendText(intMonth + 1 & vbTab)

            For intRegion As Integer = 1 To intColumns
                rtbOutput.AppendText(intArraySales(intMonth, intRegion).ToString("C0") & vbTab)

                If intRegion = 1 Then
                    intKZN += intArraySales(intMonth, intRegion)
                ElseIf intRegion = 2 Then
                    intGau += intArraySales(intMonth, intRegion)
                Else
                    intWC += intArraySales(intMonth, intRegion)
                End If
            Next intRegion

            rtbOutput.AppendText(nl)
        Next intMonth

        intSum = intKZN + intGau + intWC

        rtbOutput.AppendText(nl & "The total amount that ITI Hub made in all 3 regions is: " &
                             intSum.ToString("C0") & nl)

        rtbOutput.AppendText(nl & "Kwa-Zulu-Natal has contributed " & Math.Round(((intKZN / intSum) * 100), 0) & "% " &
                             " to the total." & nl)
        rtbOutput.AppendText("Gauteng has contributed " & Math.Round((intGau / intSum) * 100, 0) & " %" &
                             " to the total." & nl)
        rtbOutput.AppendText("Western Cape has contributed " & Math.Round((intWC / intSum) * 100, 0) & " %" &
                             " to the total." & nl)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Disables Display button until the array has been successfully generated
        btnDisplay.Enabled = False

        ' Automatically checks the automatic array generation for convenience
        chkGenerateAuto.Checked = True

        ' Disables maximize box in the title bar and prevents user from resizing the window border
        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle

        ' Stretches the image to occupy the entire Picture Box
        picLogo.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub AutomaticArray()
        intArraySales(0, 1) = 12000
        intArraySales(1, 1) = 190000
        intArraySales(2, 1) = 175000
        intArraySales(3, 1) = 188000
        intArraySales(4, 1) = 125000
        intArraySales(5, 1) = 163000

        intArraySales(0, 2) = 90000
        intArraySales(1, 2) = 85000
        intArraySales(2, 2) = 80000
        intArraySales(3, 2) = 83000
        intArraySales(4, 2) = 87000
        intArraySales(5, 2) = 80000

        intArraySales(0, 3) = 65000
        intArraySales(1, 3) = 64000
        intArraySales(2, 3) = 71000
        intArraySales(3, 3) = 67000
        intArraySales(4, 3) = 65000
        intArraySales(5, 3) = 64000
    End Sub
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbLength = New System.Windows.Forms.ComboBox()
        Me.cmbWidth = New System.Windows.Forms.ComboBox()
        Me.cmbHeight = New System.Windows.Forms.ComboBox()
        Me.cmbRollCoverage = New System.Windows.Forms.ComboBox()
        Me.txtSingle = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnVerify = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Length (feet):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Width (feet):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Height (feet):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Roll Coverage (sqrFt):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 304)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Single Roll:"
        '
        'cmbLength
        '
        Me.cmbLength.FormattingEnabled = True
        Me.cmbLength.Location = New System.Drawing.Point(195, 9)
        Me.cmbLength.Name = "cmbLength"
        Me.cmbLength.Size = New System.Drawing.Size(136, 24)
        Me.cmbLength.TabIndex = 5
        '
        'cmbWidth
        '
        Me.cmbWidth.FormattingEnabled = True
        Me.cmbWidth.Location = New System.Drawing.Point(194, 75)
        Me.cmbWidth.Name = "cmbWidth"
        Me.cmbWidth.Size = New System.Drawing.Size(136, 24)
        Me.cmbWidth.TabIndex = 6
        '
        'cmbHeight
        '
        Me.cmbHeight.FormattingEnabled = True
        Me.cmbHeight.Location = New System.Drawing.Point(195, 148)
        Me.cmbHeight.Name = "cmbHeight"
        Me.cmbHeight.Size = New System.Drawing.Size(136, 24)
        Me.cmbHeight.TabIndex = 7
        '
        'cmbRollCoverage
        '
        Me.cmbRollCoverage.FormattingEnabled = True
        Me.cmbRollCoverage.Location = New System.Drawing.Point(195, 228)
        Me.cmbRollCoverage.Name = "cmbRollCoverage"
        Me.cmbRollCoverage.Size = New System.Drawing.Size(136, 24)
        Me.cmbRollCoverage.TabIndex = 8
        '
        'txtSingle
        '
        Me.txtSingle.Location = New System.Drawing.Point(194, 299)
        Me.txtSingle.Name = "txtSingle"
        Me.txtSingle.Size = New System.Drawing.Size(137, 22)
        Me.txtSingle.TabIndex = 9
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(126, 361)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(101, 27)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(246, 361)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 27)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnVerify
        '
        Me.btnVerify.Location = New System.Drawing.Point(17, 361)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(88, 27)
        Me.btnVerify.TabIndex = 12
        Me.btnVerify.Text = "&Verify"
        Me.btnVerify.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 396)
        Me.Controls.Add(Me.btnVerify)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtSingle)
        Me.Controls.Add(Me.cmbRollCoverage)
        Me.Controls.Add(Me.cmbHeight)
        Me.Controls.Add(Me.cmbWidth)
        Me.Controls.Add(Me.cmbLength)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Wallpaper App:"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbLength As ComboBox
    Friend WithEvents cmbWidth As ComboBox
    Friend WithEvents cmbHeight As ComboBox
    Friend WithEvents cmbRollCoverage As ComboBox
    Friend WithEvents txtSingle As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnE[xit As Button
    Friend WithEvents btnVerify As Button
End Class

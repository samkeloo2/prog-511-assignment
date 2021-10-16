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
        Me.txtAsset = New System.Windows.Forms.TextBox()
        Me.txtSalvage = New System.Windows.Forms.TextBox()
        Me.cmbUsefulLife = New System.Windows.Forms.ComboBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstSum = New System.Windows.Forms.ListBox()
        Me.lstDouble = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Asset Cost:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Salvage Value:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Useful Life:"
        '
        'txtAsset
        '
        Me.txtAsset.Location = New System.Drawing.Point(142, 13)
        Me.txtAsset.Name = "txtAsset"
        Me.txtAsset.Size = New System.Drawing.Size(199, 22)
        Me.txtAsset.TabIndex = 3
        '
        'txtSalvage
        '
        Me.txtSalvage.Location = New System.Drawing.Point(142, 89)
        Me.txtSalvage.Name = "txtSalvage"
        Me.txtSalvage.Size = New System.Drawing.Size(199, 22)
        Me.txtSalvage.TabIndex = 4
        '
        'cmbUsefulLife
        '
        Me.cmbUsefulLife.FormattingEnabled = True
        Me.cmbUsefulLife.Location = New System.Drawing.Point(142, 168)
        Me.cmbUsefulLife.Name = "cmbUsefulLife"
        Me.cmbUsefulLife.Size = New System.Drawing.Size(199, 24)
        Me.cmbUsefulLife.TabIndex = 5
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(18, 231)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(169, 57)
        Me.btnDisplay.TabIndex = 6
        Me.btnDisplay.Text = "&Display Depreciation Schedules"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(199, 231)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(142, 57)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstSum)
        Me.GroupBox1.Controls.Add(Me.lstDouble)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(375, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(594, 275)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Depreciation Schedules:"
        '
        'lstSum
        '
        Me.lstSum.FormattingEnabled = True
        Me.lstSum.ItemHeight = 16
        Me.lstSum.Location = New System.Drawing.Point(320, 76)
        Me.lstSum.Name = "lstSum"
        Me.lstSum.Size = New System.Drawing.Size(257, 180)
        Me.lstSum.TabIndex = 3
        '
        'lstDouble
        '
        Me.lstDouble.FormattingEnabled = True
        Me.lstDouble.ItemHeight = 16
        Me.lstDouble.Location = New System.Drawing.Point(15, 76)
        Me.lstDouble.Name = "lstDouble"
        Me.lstDouble.Size = New System.Drawing.Size(257, 180)
        Me.lstDouble.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(317, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(213, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Sum-of-the-year's balances:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Double-Declining balances:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 303)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.cmbUsefulLife)
        Me.Controls.Add(Me.txtSalvage)
        Me.Controls.Add(Me.txtAsset)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "RGIT : Annual Asset Depreciation Application"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAsset As TextBox
    Friend WithEvents txtSalvage As TextBox
    Friend WithEvents cmbUsefulLife As ComboBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lstSum As ListBox
    Friend WithEvents lstDouble As ListBox
End Class

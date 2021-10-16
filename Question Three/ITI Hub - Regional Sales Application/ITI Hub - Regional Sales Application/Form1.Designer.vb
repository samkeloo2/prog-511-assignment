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
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.rtbOutput = New System.Windows.Forms.RichTextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnEnterSales = New System.Windows.Forms.Button()
        Me.chkGenerateAuto = New System.Windows.Forms.CheckBox()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLogo
        '
        Me.picLogo.Image = Global.WindowsApplication1.My.Resources.Resources.itiLogo
        Me.picLogo.Location = New System.Drawing.Point(13, 13)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(205, 204)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'rtbOutput
        '
        Me.rtbOutput.Location = New System.Drawing.Point(240, 12)
        Me.rtbOutput.Name = "rtbOutput"
        Me.rtbOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtbOutput.Size = New System.Drawing.Size(823, 371)
        Me.rtbOutput.TabIndex = 1
        Me.rtbOutput.Text = ""
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(12, 306)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(205, 31)
        Me.btnDisplay.TabIndex = 2
        Me.btnDisplay.Text = "&Display Sales"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(13, 353)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(205, 30)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnEnterSales
        '
        Me.btnEnterSales.Location = New System.Drawing.Point(13, 223)
        Me.btnEnterSales.Name = "btnEnterSales"
        Me.btnEnterSales.Size = New System.Drawing.Size(205, 31)
        Me.btnEnterSales.TabIndex = 4
        Me.btnEnterSales.Text = "&Enter Sales"
        Me.btnEnterSales.UseVisualStyleBackColor = True
        '
        'chkGenerateAuto
        '
        Me.chkGenerateAuto.AutoSize = True
        Me.chkGenerateAuto.Location = New System.Drawing.Point(13, 270)
        Me.chkGenerateAuto.Name = "chkGenerateAuto"
        Me.chkGenerateAuto.Size = New System.Drawing.Size(213, 21)
        Me.chkGenerateAuto.TabIndex = 5
        Me.chkGenerateAuto.Text = "Generate sales automatically"
        Me.chkGenerateAuto.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 395)
        Me.Controls.Add(Me.chkGenerateAuto)
        Me.Controls.Add(Me.btnEnterSales)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.rtbOutput)
        Me.Controls.Add(Me.picLogo)
        Me.Name = "Form1"
        Me.Text = "ITI Hub : Regional Sales"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents rtbOutput As RichTextBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnEnterSales As Button
    Friend WithEvents chkGenerateAuto As CheckBox
End Class

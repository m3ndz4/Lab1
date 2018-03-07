<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab1
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
        Me.lblUnitInput = New System.Windows.Forms.Label()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtAllUnits = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblUnitInput
        '
        Me.lblUnitInput.AutoSize = True
        Me.lblUnitInput.Location = New System.Drawing.Point(18, 20)
        Me.lblUnitInput.Name = "lblUnitInput"
        Me.lblUnitInput.Size = New System.Drawing.Size(44, 17)
        Me.lblUnitInput.TabIndex = 0
        Me.lblUnitInput.Text = "Units:"
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.Location = New System.Drawing.Point(301, 20)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(49, 17)
        Me.lblDays.TabIndex = 1
        Me.lblDays.Text = "Day: 1"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(18, 199)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(332, 23)
        Me.lblResult.TabIndex = 2
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(68, 17)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(227, 22)
        Me.txtInput.TabIndex = 1
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(17, 225)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 34)
        Me.btnEnter.TabIndex = 3
        Me.btnEnter.Text = "&Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(98, 226)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 33)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(179, 226)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 33)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtAllUnits
        '
        Me.txtAllUnits.Location = New System.Drawing.Point(17, 45)
        Me.txtAllUnits.Multiline = True
        Me.txtAllUnits.Name = "txtAllUnits"
        Me.txtAllUnits.ReadOnly = True
        Me.txtAllUnits.Size = New System.Drawing.Size(333, 151)
        Me.txtAllUnits.TabIndex = 6
        '
        'frmLab1
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(371, 271)
        Me.Controls.Add(Me.txtAllUnits)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.lblUnitInput)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLab1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUnitInput As Label
    Friend WithEvents lblDays As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtAllUnits As TextBox
End Class

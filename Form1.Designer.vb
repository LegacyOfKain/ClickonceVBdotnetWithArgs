<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LabelValuePassed = New System.Windows.Forms.Label()
        Me.LabelUrlPassed = New System.Windows.Forms.Label()
        Me.LabelQueryString = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelValuePassed
        '
        Me.LabelValuePassed.AutoSize = True
        Me.LabelValuePassed.Location = New System.Drawing.Point(106, 165)
        Me.LabelValuePassed.Name = "LabelValuePassed"
        Me.LabelValuePassed.Size = New System.Drawing.Size(107, 20)
        Me.LabelValuePassed.TabIndex = 0
        Me.LabelValuePassed.Text = "Value Passed"
        '
        'LabelUrlPassed
        '
        Me.LabelUrlPassed.AutoSize = True
        Me.LabelUrlPassed.Location = New System.Drawing.Point(106, 249)
        Me.LabelUrlPassed.Name = "LabelUrlPassed"
        Me.LabelUrlPassed.Size = New System.Drawing.Size(86, 20)
        Me.LabelUrlPassed.TabIndex = 1
        Me.LabelUrlPassed.Text = "Url Passed"
        '
        'LabelQueryString
        '
        Me.LabelQueryString.AutoSize = True
        Me.LabelQueryString.Location = New System.Drawing.Point(106, 90)
        Me.LabelQueryString.Name = "LabelQueryString"
        Me.LabelQueryString.Size = New System.Drawing.Size(97, 20)
        Me.LabelQueryString.TabIndex = 2
        Me.LabelQueryString.Text = "Query String"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LabelQueryString)
        Me.Controls.Add(Me.LabelUrlPassed)
        Me.Controls.Add(Me.LabelValuePassed)
        Me.Name = "Form1"
        Me.Text = "ClickOnceVBwithArgsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelValuePassed As Label
    Friend WithEvents LabelUrlPassed As Label
    Friend WithEvents LabelQueryString As Label
End Class

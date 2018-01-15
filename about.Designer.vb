<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class about
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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.appver_lbl = New System.Windows.Forms.Label()
        Me.Title_lbl = New System.Windows.Forms.Label()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(39, 81)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox1.Size = New System.Drawing.Size(240, 68)
        Me.RichTextBox1.TabIndex = 6
        Me.RichTextBox1.Text = "FS auto lights is a virutal first officer that  controls the lights of the aircra" & _
            "ft based on time of day and turns on/off landing lights as required"
        '
        'appver_lbl
        '
        Me.appver_lbl.AutoSize = True
        Me.appver_lbl.Location = New System.Drawing.Point(120, 59)
        Me.appver_lbl.Name = "appver_lbl"
        Me.appver_lbl.Size = New System.Drawing.Size(39, 13)
        Me.appver_lbl.TabIndex = 8
        Me.appver_lbl.Text = "Label1"
        '
        'Title_lbl
        '
        Me.Title_lbl.AutoSize = True
        Me.Title_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title_lbl.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Title_lbl.Location = New System.Drawing.Point(61, 19)
        Me.Title_lbl.Name = "Title_lbl"
        Me.Title_lbl.Size = New System.Drawing.Size(150, 31)
        Me.Title_lbl.TabIndex = 7
        Me.Title_lbl.Text = "Auto Lights"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Location = New System.Drawing.Point(40, 172)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox2.Size = New System.Drawing.Size(240, 62)
        Me.RichTextBox2.TabIndex = 9
        Me.RichTextBox2.Text = "Created By PVA2349 - Jeremy Stevens " & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "any question or problems please e-mail me a" & _
            "t nitestryker@gmail.com "
        '
        'about
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.appver_lbl)
        Me.Controls.Add(Me.Title_lbl)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "about"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "about"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents appver_lbl As System.Windows.Forms.Label
    Friend WithEvents Title_lbl As System.Windows.Forms.Label
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
End Class

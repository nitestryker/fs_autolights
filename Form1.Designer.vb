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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.quit_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.fsStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ConnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisconnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.autoLights_chkbox = New System.Windows.Forms.CheckBox()
        Me.cablbl = New System.Windows.Forms.Label()
        Me.logolbl = New System.Windows.Forms.Label()
        Me.winglbl = New System.Windows.Forms.Label()
        Me.reclbl = New System.Windows.Forms.Label()
        Me.inslbl = New System.Windows.Forms.Label()
        Me.strblbl = New System.Windows.Forms.Label()
        Me.taxilbl = New System.Windows.Forms.Label()
        Me.lndlbl = New System.Windows.Forms.Label()
        Me.beaclbl = New System.Windows.Forms.Label()
        Me.navlbl = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.autoLightsTimer = New System.Windows.Forms.Timer(Me.components)
        Me.fsTimer = New System.Windows.Forms.Timer(Me.components)
        Me.fscon = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(248, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.quit_menu})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'quit_menu
        '
        Me.quit_menu.Name = "quit_menu"
        Me.quit_menu.Size = New System.Drawing.Size(105, 22)
        Me.quit_menu.Text = "Quit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fsStatus, Me.ToolStripDropDownButton1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 235)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(248, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'fsStatus
        '
        Me.fsStatus.Name = "fsStatus"
        Me.fsStatus.Size = New System.Drawing.Size(79, 17)
        Me.fsStatus.Text = "Not Connected"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectToolStripMenuItem, Me.DisconnectToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'ConnectToolStripMenuItem
        '
        Me.ConnectToolStripMenuItem.Name = "ConnectToolStripMenuItem"
        Me.ConnectToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ConnectToolStripMenuItem.Text = "Connect"
        '
        'DisconnectToolStripMenuItem
        '
        Me.DisconnectToolStripMenuItem.Name = "DisconnectToolStripMenuItem"
        Me.DisconnectToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.DisconnectToolStripMenuItem.Text = "Disconnect"
        '
        'autoLights_chkbox
        '
        Me.autoLights_chkbox.AutoSize = True
        Me.autoLights_chkbox.Location = New System.Drawing.Point(81, 38)
        Me.autoLights_chkbox.Name = "autoLights_chkbox"
        Me.autoLights_chkbox.Size = New System.Drawing.Size(105, 17)
        Me.autoLights_chkbox.TabIndex = 2
        Me.autoLights_chkbox.Text = "Enable / Disable"
        Me.autoLights_chkbox.UseVisualStyleBackColor = True
        '
        'cablbl
        '
        Me.cablbl.AutoSize = True
        Me.cablbl.Location = New System.Drawing.Point(216, 204)
        Me.cablbl.Name = "cablbl"
        Me.cablbl.Size = New System.Drawing.Size(27, 13)
        Me.cablbl.TabIndex = 90
        Me.cablbl.Text = "N/A"
        '
        'logolbl
        '
        Me.logolbl.AutoSize = True
        Me.logolbl.Location = New System.Drawing.Point(216, 178)
        Me.logolbl.Name = "logolbl"
        Me.logolbl.Size = New System.Drawing.Size(27, 13)
        Me.logolbl.TabIndex = 89
        Me.logolbl.Text = "N/A"
        '
        'winglbl
        '
        Me.winglbl.AutoSize = True
        Me.winglbl.Location = New System.Drawing.Point(216, 157)
        Me.winglbl.Name = "winglbl"
        Me.winglbl.Size = New System.Drawing.Size(27, 13)
        Me.winglbl.TabIndex = 88
        Me.winglbl.Text = "N/A"
        '
        'reclbl
        '
        Me.reclbl.AutoSize = True
        Me.reclbl.Location = New System.Drawing.Point(216, 133)
        Me.reclbl.Name = "reclbl"
        Me.reclbl.Size = New System.Drawing.Size(27, 13)
        Me.reclbl.TabIndex = 87
        Me.reclbl.Text = "N/A"
        '
        'inslbl
        '
        Me.inslbl.AutoSize = True
        Me.inslbl.Location = New System.Drawing.Point(216, 104)
        Me.inslbl.Name = "inslbl"
        Me.inslbl.Size = New System.Drawing.Size(27, 13)
        Me.inslbl.TabIndex = 86
        Me.inslbl.Text = "N/A"
        '
        'strblbl
        '
        Me.strblbl.AutoSize = True
        Me.strblbl.Location = New System.Drawing.Point(92, 206)
        Me.strblbl.Name = "strblbl"
        Me.strblbl.Size = New System.Drawing.Size(27, 13)
        Me.strblbl.TabIndex = 85
        Me.strblbl.Text = "N/A"
        '
        'taxilbl
        '
        Me.taxilbl.AutoSize = True
        Me.taxilbl.Location = New System.Drawing.Point(92, 178)
        Me.taxilbl.Name = "taxilbl"
        Me.taxilbl.Size = New System.Drawing.Size(27, 13)
        Me.taxilbl.TabIndex = 84
        Me.taxilbl.Text = "N/A"
        '
        'lndlbl
        '
        Me.lndlbl.AutoSize = True
        Me.lndlbl.Location = New System.Drawing.Point(92, 155)
        Me.lndlbl.Name = "lndlbl"
        Me.lndlbl.Size = New System.Drawing.Size(27, 13)
        Me.lndlbl.TabIndex = 83
        Me.lndlbl.Text = "N/A"
        '
        'beaclbl
        '
        Me.beaclbl.AutoSize = True
        Me.beaclbl.Location = New System.Drawing.Point(92, 131)
        Me.beaclbl.Name = "beaclbl"
        Me.beaclbl.Size = New System.Drawing.Size(27, 13)
        Me.beaclbl.TabIndex = 82
        Me.beaclbl.Text = "N/A"
        '
        'navlbl
        '
        Me.navlbl.AutoSize = True
        Me.navlbl.Location = New System.Drawing.Point(92, 107)
        Me.navlbl.Name = "navlbl"
        Me.navlbl.Size = New System.Drawing.Size(27, 13)
        Me.navlbl.TabIndex = 81
        Me.navlbl.Text = "N/A"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(128, 204)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 15)
        Me.Label10.TabIndex = 80
        Me.Label10.Text = "Cabin"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(128, 180)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 15)
        Me.Label11.TabIndex = 79
        Me.Label11.Text = "Logo"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(128, 155)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 15)
        Me.Label12.TabIndex = 78
        Me.Label12.Text = "Wing"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(128, 131)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 15)
        Me.Label13.TabIndex = 77
        Me.Label13.Text = "Recognition"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(128, 103)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 15)
        Me.Label14.TabIndex = 76
        Me.Label14.Text = "Instruments"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 204)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 15)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "Strobes:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 178)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 15)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Taxi:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 15)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Landing:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 15)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Beacon:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 15)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Navigation:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(76, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 15)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Lights Status"
        '
        'autoLightsTimer
        '
        '
        'fsTimer
        '
        '
        'fscon
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(248, 257)
        Me.Controls.Add(Me.cablbl)
        Me.Controls.Add(Me.logolbl)
        Me.Controls.Add(Me.winglbl)
        Me.Controls.Add(Me.reclbl)
        Me.Controls.Add(Me.inslbl)
        Me.Controls.Add(Me.strblbl)
        Me.Controls.Add(Me.taxilbl)
        Me.Controls.Add(Me.lndlbl)
        Me.Controls.Add(Me.beaclbl)
        Me.Controls.Add(Me.navlbl)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.autoLights_chkbox)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "FS Auto Lights"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents quit_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents fsStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents autoLights_chkbox As System.Windows.Forms.CheckBox
    Friend WithEvents cablbl As System.Windows.Forms.Label
    Friend WithEvents logolbl As System.Windows.Forms.Label
    Friend WithEvents winglbl As System.Windows.Forms.Label
    Friend WithEvents reclbl As System.Windows.Forms.Label
    Friend WithEvents inslbl As System.Windows.Forms.Label
    Friend WithEvents strblbl As System.Windows.Forms.Label
    Friend WithEvents taxilbl As System.Windows.Forms.Label
    Friend WithEvents lndlbl As System.Windows.Forms.Label
    Friend WithEvents beaclbl As System.Windows.Forms.Label
    Friend WithEvents navlbl As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents autoLightsTimer As System.Windows.Forms.Timer
    Friend WithEvents fsTimer As System.Windows.Forms.Timer
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ConnectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisconnectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fscon As System.Windows.Forms.Timer

End Class

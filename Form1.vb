Imports FSUIPC
Imports FS_AUTO_LIGHTS.utilities.classes
Imports FS_AUTO_LIGHTS.messages
Imports FS_AUTO_LIGHTS.utilities


Public Class Form1

    Private altfeet As Integer
    Private altitudeGroundFeet As Integer
    Private altitudeFlightFeet As Integer
    Private altitudeAGLFeet As Integer
    Private constatus As Boolean
    Private altcheck As Boolean
    Private fsxcon As Boolean
    'fs offsets 
    Dim lights As Offset(Of BitArray) = New FSUIPC.Offset(Of BitArray)(&HD0C, 2)
    Dim altitudeFlight = New FSUIPC.Offset(Of Integer)(&H574)
    Dim altitudeGround = New FSUIPC.Offset(Of Short)(&HB4C)
    Dim textdis As Offset(Of Short) = New FSUIPC.Offset(Of Short)(&H32FA, -1) ' how long the message is displayed 
    Dim message As Offset(Of String) = New FSUIPC.Offset(Of String)(&H3380, 128) ' the acutal message showing in flight sim 
    Dim timeofday = New FSUIPC.Offset(Of Byte)(&H115E) 'time of day flag
    Dim IAS = New FSUIPC.Offset(Of Integer)(700)
    Dim speedIAS = New FSUIPC.Offset(Of Integer)(&H2B8) ' true airspeeed
    Dim groundorair As Offset(Of Short) = New FSUIPC.Offset(Of Short)(&H366)

    Private Enum LightType
        Navigation
        Beacon
        Landing
        Taxi
        Strobes
        Instruments
        Recognition
        Wing
        Logo
        Cabin
    End Enum

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        altcheck = 0
        Try
            FSUIPCConnection.Open()
            fsStatus.BackColor = Color.Green
            fsStatus.Text = "Connected"
            fsTimer.Start()
            constatus = True
        Catch ex As Exception
            Dim exstring As String
            exstring = Convert.ToString(ex)
            constatus = False
            IOmanager.LogDebugEvents(ex.ToString())
            MessageManager.WarningMessage("Flight Simulator is not running")
        End Try

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Hide()
        about.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles autoLights_chkbox.CheckedChanged

        If autoLights_chkbox.Checked = True Then '
            message.Value = "Auto Lights Enabled"
            textdis.Value = "5"
            autoLightsTimer.Start()
        End If
        If autoLights_chkbox.Checked = False Then
            message.Value = "Auto Lights Disabled"
            textdis.Value = "5"
            autoLightsTimer.Stop()
            altcheck = 0
        End If
    End Sub
    Private Sub fsTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fsTimer.Tick
        Me.altitudeGroundFeet = Convert.ToInt32((CDbl(Me.altitudeGround.Value) * 3.28084))
        Me.altitudeFlightFeet = Convert.ToInt32((CDbl(Me.altitudeFlight.Value) * 3.28084))
        Me.altitudeAGLFeet = (Me.altitudeFlightFeet - Me.altitudeGroundFeet)
        Dim IAS As String
        IAS = Me.speedIAS.Value / &H80

        ' set the Lights Status
        Dim navcheck As Boolean
        Dim beccheck As Boolean
        Dim lancheck As Boolean
        Dim taxicheck As Boolean
        Dim strbcheck As Boolean
        Dim inscheck As Boolean
        Dim reccheck As Boolean
        Dim wngcheck As Boolean
        Dim logcheck As Boolean
        Dim cbncheck As Boolean
        navcheck = lights.Value(LightType.Navigation)
        beccheck = lights.Value(LightType.Beacon)
        lancheck = lights.Value(LightType.Landing)
        taxicheck = lights.Value(LightType.Taxi)
        strbcheck = lights.Value(LightType.Strobes)
        inscheck = lights.Value(LightType.Instruments)
        reccheck = lights.Value(LightType.Recognition)
        wngcheck = lights.Value(LightType.Wing)
        logcheck = lights.Value(LightType.Logo)
        cbncheck = lights.Value(LightType.Cabin)

        ' check Nav Lights 
        If navcheck = True Then
            navlbl.ForeColor = Color.Black
            navlbl.Text = "On"
        Else
            navlbl.ForeColor = Color.Red
            navlbl.Text = "Off"
        End If

        ' check Beacon lights
        If beccheck = True Then
            beaclbl.ForeColor = Color.Black
            beaclbl.Text = "On"
        Else
            beaclbl.ForeColor = Color.Red
            beaclbl.Text = "Off"
        End If

        ' Check landing Lights 
        If lancheck = True Then
            lndlbl.ForeColor = Color.Black
            lndlbl.Text = "On"
        Else
            lndlbl.ForeColor = Color.Red
            lndlbl.Text = "Off"
        End If

        ' Check Taxi Lights 
        If taxicheck = True Then
            taxilbl.ForeColor = Color.Black
            taxilbl.Text = "On"
        Else
            taxilbl.ForeColor = Color.Red
            taxilbl.Text = "Off"
        End If

        ' Check strobe Lights 
        If strbcheck = True Then
            strblbl.ForeColor = Color.Black
            strblbl.Text = "On"
        Else
            strblbl.ForeColor = Color.Red
            strblbl.Text = "Off"
        End If


        ' Check instruments Lights 
        If inscheck = True Then
            inslbl.ForeColor = Color.Black
            inslbl.Text = "On"
        Else
            inslbl.ForeColor = Color.Red
            inslbl.Text = "Off"
        End If


        ' Check Recognition Lights 
        If reccheck = True Then
            reclbl.ForeColor = Color.Black
            reclbl.Text = "On"
        Else
            reclbl.ForeColor = Color.Red
            reclbl.Text = "Off"
        End If

        ' Check Wing Lights 
        If wngcheck = True Then
            winglbl.ForeColor = Color.Black
            winglbl.Text = "On"
        Else
            winglbl.ForeColor = Color.Red
            winglbl.Text = "Off"
        End If

        ' Check logoLights 
        If logcheck = True Then
            logolbl.ForeColor = Color.Black
            logolbl.Text = "On"
        Else
            logolbl.ForeColor = Color.Red
            logolbl.Text = "Off"
        End If

        ' Check Cabin Lights 
        If cbncheck = True Then
            cablbl.ForeColor = Color.Black
            cablbl.Text = "On"
        Else
            cablbl.ForeColor = Color.Red
            cablbl.Text = "Off"
        End If

        altfeet = Convert.ToInt32((CDbl(Me.altitudeFlight.Value) * 3.28084))

    End Sub
    Private Sub autoLightsTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles autoLightsTimer.Tick
      
        Try


            FSUIPCConnection.Process()
            ' if its dark turn these lights on 
            If Not timeofday.value = 1 Then
                lights.Value(LightType.Cabin) = 1
                lights.Value(LightType.Instruments) = 1
                lights.Value(LightType.Logo) = 1
            Else
                lights.Value(LightType.Taxi) = 0
                lights.Value(LightType.Cabin) = 0
                lights.Value(LightType.Instruments) = 0
                lights.Value(LightType.Logo) = 0
            End If

            ' if on the ground at night turn on taxi lights 
            If timeofday.value = 1 And groundorair.Value = 1 Then
                lights.Value(LightType.Taxi) = 1
            End If

            ' turn off taxi lights once airborune 
            If timeofday.value = 1 And groundorair.Value = 0 Then
                lights.Value(LightType.Taxi) = 0
            End If

            'navigation lights
            If lights.Value(LightType.Navigation) = 0 Then
                lights.Value(LightType.Navigation) = 1
            End If
            ' beacon lights
            If lights.Value(LightType.Beacon) = 0 Then
                lights.Value(LightType.Beacon) = 1
            End If

            ' Strobe Lights
            If lights.Value(LightType.Strobes) = 0 Then
                lights.Value(LightType.Strobes) = 1
            End If

            ' Recognition Lights
            If lights.Value(LightType.Recognition) = 0 Then
                lights.Value(LightType.Recognition) = 1
            End If

            ' Wing Lights 
            If lights.Value(LightType.Wing) = 0 Then
                lights.Value(LightType.Wing) = 1
            End If



            ' Landing lights on Below 10k'
                altfeet = Convert.ToInt32((CDbl(Me.altitudeFlight.Value) * 3.28084))
                If altfeet < 10000 Then
                    If lights.Value(LightType.Landing) = 0 Then
                        lights.Value(LightType.Landing) = 1
                        lndlbl.Text = "On"
                        message.Value = "Landing Lights On"
                        textdis.Value = "5"
                        altcheck = 0
                    End If
            End If



            If altcheck < 1 Then
                'landing lights off Above 10k 
                If altfeet > 10000 Then
                    lights.Value(LightType.Landing) = 0
                    lndlbl.Text = "Off"
                    message.Value = "Landing Lights OFF"
                    textdis.Value = 1
                    altcheck = 1
                End If
            End If
            ' catch exeptions sent to debug file
        Catch ex As Exception
            autoLightsTimer.Stop()
            Dim exstring As String
            exstring = Convert.ToString(ex)
            IOmanager.LogDebugEvents(ex.ToString())
        End Try

        If altfeet > 10250 Then
            message.Value = ""
            textdis.Value = 1
        End If
    End Sub

    Private Sub connect_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            FSUIPCConnection.Open()
            fsStatus.BackColor = Color.Green
            fsStatus.Text = "Connected"
        Catch ex As Exception
            Dim exstring As String
            exstring = Convert.ToString(ex)
            IOmanager.LogDebugEvents(ex.ToString())
            MessageManager.WarningMessage("Could not connect to flight simulator, please try again")
        End Try
    End Sub

  

    Private Sub quit_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quit_menu.Click
        Application.Exit()
    End Sub

    Private Sub ConnectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnectToolStripMenuItem.Click
        FSUIPCConnection.Open()
    End Sub

    Private Sub DisconnectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisconnectToolStripMenuItem.Click
        fsStatus.BackColor = Color.Red
        fsStatus.Text = "Disconnected"
    End Sub

    Private Sub fscon_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fscon.Tick
120:

        Try
            FSUIPCConnection.Open()
        Catch ex As Exception
            fsxcon = 0
            GoTo 120
        End Try
    End Sub
End Class

Imports FSUIPC
Imports System
Imports System.Media
Imports System.Windows.Forms

Namespace messages
    Friend Class MessageManager
        Public Shared Sub ErrorMessage(ByVal message As String)
            MessageBox.Show(message, "FA", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)
        End Sub

        Public Shared Sub InformationMessage(ByVal message As String)
            MessageBox.Show(message, "FA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        End Sub

        Public Shared Sub MessageBeep()
            SystemSounds.Asterisk.Play()
        End Sub

        Public Shared Sub QuestionMessage(ByVal message As String)
            MessageBox.Show(message, "FA", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        End Sub

        Public Shared Sub ShowFSMessage(ByVal Message As String, ByVal Delay As Integer)
            Dim FSWriteMessage As Offset(Of String) = New Offset(Of String)("Message", 13184, 127)
            Dim DelayMessage As Offset(Of Integer) = New Offset(Of Integer)("Message", 13050)
            FSWriteMessage.Value = Message
            DelayMessage.Value = Delay
            FSUIPCConnection.Process("Message")
            FSUIPCConnection.DeleteGroup("Message")
        End Sub

        Public Shared Sub WarningBeep()
            SystemSounds.Beep.Play()
        End Sub

        Public Shared Sub WarningMessage(ByVal message As String)
            MessageBox.Show(message, "FS Auto Lights", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Sub

        Public Shared Function YesorNoMessage(ByVal f As String) As Boolean
            Dim result As DialogResult = MessageBox.Show(f, "FA", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Dim trueorfalse As Boolean = False
            If (result = DialogResult.Yes) Then
                trueorfalse = True
            End If
            Return trueorfalse
        End Function
    End Class
End Namespace
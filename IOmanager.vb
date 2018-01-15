Imports FSUIPC
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.IO
Imports System.Media
Imports System.Reflection
Imports System.Text

Namespace utilities.classes
    Friend Class IOmanager
        Public Shared Function GetMainDirectory() As String
            Return Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)
        End Function
        Public Shared Sub LogDebugEvents(ByVal message As String)
            Dim dir As String = IOmanager.GetMainDirectory()
            Using sw As StreamWriter = File.AppendText(String.Concat(dir, "\Debug.txt"))
                Dim now() As Object = {DateTime.Now, "/t", message, Environment.NewLine}
                sw.WriteLine(String.Concat(now))
            End Using
        End Sub
    End Class
End Namespace

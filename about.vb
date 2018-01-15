Public Class about

    Private Sub about_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub about_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        appver_lbl.Text = "Version " + Application.ProductVersion

    End Sub
End Class
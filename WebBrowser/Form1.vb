Public Class Form1

    Dim HomePage = "http://google.com"
    Dim FoundersGit = "http://github.com"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate(HomePage)
        TextBox1.Text = WebBrowser1.Url.ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.GoBack()
        TextBox1.Text = WebBrowser1.Url.ToString
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebBrowser1.GoForward()
        TextBox1.Text = WebBrowser1.Url.ToString
    End Sub
End Class

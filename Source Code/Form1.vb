Imports System.Threading
Public Class Form1
    Dim txt As String
    Dim timer As Integer = 5
    Dim splkys() As String = {"{", "}", "(", ")", "[", "]", "^", "+", "%"}
    Dim splno = splkys.GetUpperBound(0)
    Private Function autocorrect(text As String)
        For i As Integer = 0 To splno
            text = Replace(text, splkys(i), "{" & splkys(i) & "}")
        Next i
        Return text
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Paste.Click
        txt = My.Computer.Clipboard.GetText()
        txt = autocorrect(txt)
        If Won.Checked = True Then
            MessageBox.Show("you have " + CStr(timer) + " seconds to place your cursor after clicking ok", "SkillRack Bypass")
        End If
        Me.WindowState = FormWindowState.Minimized
        Thread.Sleep(timer * 1000)
        SendKeys.SendWait(txt)
        Wbox.Visible = True
    End Sub

    Private Sub sbutton_Click(sender As Object, e As EventArgs) Handles sbutton.Click
        tcanvas.Text = timer
        Options.Visible = True
        sbutton.Visible = False
        KeyCanvas.Text = Join(splkys, " ")
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://www.ultim8-vineeth.blogspot.in")
    End Sub

    Private Sub s_accept_Click_1(sender As Object, e As EventArgs) Handles s_accept.Click
        timer = tcanvas.Text
        Options.Visible = False
        sbutton.Visible = True
        MessageBox.Show("Prefereces Updated", "SkillRack Bypass")
    End Sub
End Class

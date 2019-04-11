Public Class Form1
    Dim EEgg As Boolean = False

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("유효하지 않은 길이입니다. 숫자를 입력하세요.", MsgBoxStyle.Critical, "안내")
            TextBox1.Text = 10
        ElseIf Convert.ToDecimal(TextBox1.Text) >= 65536 Or Convert.ToDecimal(TextBox1.Text) <= 0 Then
            MsgBox("유효하지 않은 길이입니다. 1에서 65535 사이로 입력하세요.", MsgBoxStyle.Critical, "안내")
            TextBox1.Text = 10
        ElseIf ComboBox1.Text = "" Then
            MsgBox("생성할 규칙 배열을 지정해 주세요." & vbCrLf & "규칙은 목록에서 생성하거나 직접 만들 수 있습니다.", MsgBoxStyle.Critical, "안내")
            ComboBox1.Text = "0123456789"
        Else
            Dim chars As String = ComboBox1.Text
            Dim password As String = ""
            Dim r As New Random()
            Dim i As Integer
            ToolStripStatusLabel1.Text = "생성 중입니다."
            ToolStripProgressBar1.Maximum = TextBox1.Text
            For i = 1 To TextBox1.Text
                password += chars.Substring(r.Next(chars.Length), 1)
                ToolStripProgressBar1.Value = i
            Next
            TextBox2.Text = password
            ToolStripStatusLabel1.Text = "생성 완료"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox2.Text = System.Guid.NewGuid.ToString
        ToolStripStatusLabel1.Text = "UUID 생성 완료"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Computer.Clipboard.SetText(TextBox2.Text)
        ToolStripStatusLabel1.Text = "복사했습니다."
    End Sub

    Private Sub ToolStripStatusLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel2.Click
        If EEgg = False Then
            EEgg = True
            Process.Start("https://twitter.com/libertin_ko")
            ComboBox1.Items.Add("흐히후므무냥냐냣먀먕먓야아앙")
            ToolStripStatusLabel1.Text = "NEVER STOP, KEEP GOING."
            TextBox2.Text = "First Release : 2017-10-26" & vbCrLf & "Last Updated : 2019-04-11"
        Else
            MsgBox("이스터 에그가 이미 활성화되어 있습니다." & vbCrLf & "생성 규칙 목록을 확인해보세요!", MsgBoxStyle.Information, "안내")
        End If
    End Sub
End Class

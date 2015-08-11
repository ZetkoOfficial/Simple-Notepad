Public Class Form1
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

    End Sub

    Private Sub CreditsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreditsToolStripMenuItem.Click
        MsgBox("Made by: Zetko")
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)

        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim index As Integer
        Dim temp As String = RichTextBox1.Text
        RichTextBox1.Text = ""
        RichTextBox1.Text = temp
        While index < RichTextBox1.Text.LastIndexOf(TextBox1.Text)
            RichTextBox1.Find(TextBox1.Text, index, RichTextBox1.TextLength, RichTextBoxFinds.None)
            RichTextBox1.SelectionBackColor = Color.Red
            index = RichTextBox1.Text.IndexOf(TextBox1.Text, index) + 1
        End While
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim file As System.IO.StreamWriter
        SaveFileDialog1.ShowDialog()
        file = My.Computer.FileSystem.OpenTextFileWriter(SaveFileDialog1.FileName + ".txt", False)
        file.Write(RichTextBox1.Text)
        file.Close()
    End Sub
End Class

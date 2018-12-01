Public Class Form1
    Dim alpha As String = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz~!@#$%^&*()_+-=[{;:}]'|\<,>.?/*-"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If CheckBox1.Checked = True Then
            TextBox1.PasswordChar = String.Empty
        Else
            CheckBox1.Checked = False
            TextBox1.PasswordChar = "*"
        End If

        Dim count = 0
        TextBox1.Text = ""
        Dim beta As New Random
        Dim gama = ""

        If TextBox2.Text = "" Then
            MessageBox.Show("Please Set the Password Length", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            While count <= TextBox2.Text - 1
                gama = beta.Next(0, alpha.Length)
                TextBox1.Text = TextBox1.Text + alpha(gama)
                count = count + 1
            End While
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text <> String.Empty Then
            Clipboard.SetText(TextBox1.Text)
            Label3.Visible = False
            Timer1.Start()
            Timer2.Start()
            Timer2.Interval = 2000

        Else
            Clipboard.Clear()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label3.Visible = True
        Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Label3.Visible = False
        Timer2.Stop()
    End Sub
End Class

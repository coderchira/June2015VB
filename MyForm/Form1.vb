Public Class Form1

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        MsgBox("Button is clicked")
        ListBox1.Items.Add(txtBx.Text)
    End Sub

    Private Sub txtBx_TextChanged(sender As Object, e As EventArgs) Handles txtBx.TextChanged
        txtBx.ForeColor = Color.Red
        txtBx.BackColor = Color.Azure
        btnSubmit.Enabled = True
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        MsgBox("Form is clicked")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("The form is loaded!")
        btnSubmit.Enabled = False
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class

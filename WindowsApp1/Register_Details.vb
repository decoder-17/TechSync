Imports MySql.Data.MySqlClient

Public Class Register_Details
    Dim MysqlConn As MySqlConnection
    Dim cmd As MySqlCommand

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Entry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.None
        WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        username.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub




    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Selection.Show()

    End Sub
End Class
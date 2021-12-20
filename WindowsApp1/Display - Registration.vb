Imports MySql.Data.MySqlClient

Public Class Display___Journals
    Dim MysqlConn As MySqlConnection
    Dim cmd As MySqlCommand

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        End

    End Sub


    Private Sub Display___Journals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.None
        WindowState = FormWindowState.Maximized

    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Selection.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class
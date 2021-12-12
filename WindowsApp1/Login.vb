Imports System.Data.SqlClient

Public Class username
    Public reader As SqlDataReader


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.None
        WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connStr As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TechSync;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        Dim connection As New SqlConnection(connStr)
        Dim cmd As New SqlCommand("select *from Login where username='" + User.Text.Trim + "' and password='" + password.Text.Trim + "'", connection)
        connection.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        If (dr.Read = True) Then
            MessageBox.Show("Logged in successfully.")
            Me.Hide()
            Selection.Show()
        Else
            MessageBox.Show("Please Try Again.")
        End If
        connection.Close()
        User.Clear()
        password.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        User.Clear()
        password.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        AboutUs.Show()
    End Sub
End Class

Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class username
    Public reader As SqlDataReader

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.None
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'The connection string pinpoints the location of the database being used to. for connecting to it.
        Dim connStr As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TechSync;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        Dim connection As New SqlConnection(connStr)
        'The query which takes input from the textboxes and then checks the same with the data stored in the database.
        Dim cmd As New SqlCommand("select *from Login where username='" + User.Text.Trim + "' and password='" + password.Text.Trim + "'", connection)
        'Try, catch, and finally to resolve any error it encounters.
        Try
            'The connection opens, and the query is executed.
            connection.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If (dr.Read = True) Then
                MessageBox.Show("Logged in successfully.", "Login Status", MessageBoxButtons.OK)
                Me.Hide()
                Selection.Show()
            Else
                MessageBox.Show("Please check your credentials.", "Login Status", MessageBoxButtons.OKCancel)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
            User.Clear()
            password.Clear()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        User.Clear()
        password.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        AboutUs.Show()
    End Sub

    Private Sub User_TextChanged(sender As Object, e As EventArgs) Handles User.TextChanged
        If Not Regex.Match(User.Text, "^[0-9a-z]*$", RegexOptions.IgnoreCase).Success Then
            MsgBox("Please enter your username correctly.")
            User.Clear()
            User.Focus()
        End If
    End Sub

    Private Sub password_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged
        If Not Regex.Match(password.Text, "^[0-9a-z]*$", RegexOptions.IgnoreCase).Success Then
            MsgBox("Please enter your password correctly.")
            password.Clear()
            password.Focus()
        End If
    End Sub
End Class

Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Register_Details

    Private Sub Entry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.None
        WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        username.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Selection.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connStr As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TechSync;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        Dim connection As New SqlConnection(connStr)
        If String.IsNullOrWhiteSpace(TextBox1.Text) Or String.IsNullOrWhiteSpace(TextBox2.Text) Or String.IsNullOrWhiteSpace(TextBox3.Text) Or String.IsNullOrWhiteSpace(TextBox4.Text) Or String.IsNullOrWhiteSpace(TextBox5.Text) Then
            MessageBox.Show("All the fields are mandatory. Please all the details.")
        Else
            connection.Open()
            Dim cmd As New SqlCommand("Insert into Register([PID],[PName],[ContactNo],[College],[Department]) values ('" & TextBox1.Text.Trim & "' ,'" & TextBox2.Text.Trim & "','" & TextBox5.Text.Trim & "','" & TextBox4.Text.Trim & "','" & TextBox3.Text.Trim & "')", connection)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            MessageBox.Show("Data has been saved successfully.")
            Me.Close()
            Register.Show()
            connection.Close()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Not Regex.Match(TextBox1.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then
            MsgBox("Please enter number assigned to you.")
            TextBox1.Clear()
            TextBox1.Focus()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If Not Regex.Match(TextBox2.Text, "^[a-z ]*$", RegexOptions.IgnoreCase).Success Then
            MsgBox("Please enter your name.(Numbers and special characters are not allowed)")
            TextBox2.Clear()
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If Not Regex.Match(TextBox3.Text, "^[a-z ]*$", RegexOptions.IgnoreCase).Success Then
            MsgBox("Please enter your name.(Numbers and special characters are not allowed)")
            TextBox3.Clear()
            TextBox3.Focus()
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If Not Regex.Match(TextBox4.Text, "^[a-z ]*$", RegexOptions.IgnoreCase).Success Then
            MsgBox("Please enter your name.(Numbers and special characters are not allowed)")
            TextBox4.Clear()
            TextBox4.Focus()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub cno_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If Not Regex.Match(TextBox5.Text, "^[0-9]{1,10}$").Success Then
            MsgBox("Please enter your valid contact number.")
            TextBox5.Clear()
            TextBox5.Focus()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub
End Class
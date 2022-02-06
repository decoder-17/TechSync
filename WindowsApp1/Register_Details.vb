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
        If String.IsNullOrWhiteSpace(TextBox2.Text) Or String.IsNullOrWhiteSpace(TextBox3.Text) Or String.IsNullOrWhiteSpace(TextBox4.Text) Or String.IsNullOrWhiteSpace(TextBox5.Text) Then
            MessageBox.Show("All the fields are mandatory. Please all the details.")
        ElseIf TextBox5.TextLength < 10 Then
            MessageBox.Show("Please enter your valid contact number.", "Participant's Contact Number")
            TextBox5.Clear()
            TextBox5.Focus()
        Else
            Try
                connection.Open()
                Dim cmd As New SqlCommand("Insert into Register([PName],[ContactNo],[College],[Department]) values ('" & TextBox2.Text.Trim & "','" & TextBox5.Text.Trim & "','" & TextBox4.Text.Trim & "','" & TextBox3.Text.Trim & "')", connection)
                Dim dr As SqlDataReader = cmd.ExecuteReader()
                MessageBox.Show("Data has been saved successfully.")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                Me.Close()
                Register.Show()
                connection.Close()
            End Try
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If Not Regex.Match(TextBox2.Text, "^[a-z ]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter your name.(Numbers and special characters are not allowed)", "Participant's Name")
            TextBox2.Clear()
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If Not Regex.Match(TextBox3.Text, "^[a-z ]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter your Department.(Numbers and special characters are not allowed)", "Department Name")
            TextBox3.Clear()
            TextBox3.Focus()
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

        If Not Regex.Match(TextBox4.Text, "^[a-z ]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter College your name.(Numbers and special characters are not allowed)", "College Name")
            TextBox4.Clear()
                TextBox4.Focus()
            End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub cno_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

        If Not Regex.Match(TextBox5.Text, "^[0-9]{1,10}$").Success Then
            MessageBox.Show("Please enter your valid contact number.", "Participant's Contact Number")
            TextBox5.Clear()
                TextBox5.Focus()
            End If

    End Sub
End Class
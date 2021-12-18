Imports System.Data.SqlClient

Public Class Register_Details

    Private Sub Entry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.None
        WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        username.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Selection.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connStr As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TechSync;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        Dim connection As New SqlConnection(connStr)
        connection.Open()
        Dim cmd As New SqlCommand("Insert into Register([PID],[PName],[College],[Department]) OUTPUT Inserted.PID values ('" & TextBox1.Text.Trim & "' ,'" & TextBox2.Text.Trim & "','" & TextBox4.Text.Trim & "','" & TextBox3.Text.Trim & "')", connection)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        MessageBox.Show("Data has been saved successfully.")
        Me.Hide()
        Register.Show()
        connection.Close()
    End Sub
End Class
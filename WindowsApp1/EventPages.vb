Imports System.Data.SqlClient
Public Class EventPages
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Selection.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        Register_Details.Show()
    End Sub

    Private Sub EventPages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.None
        WindowState = FormWindowState.Maximized
        Dim connStr As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TechSync;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        Dim connection As New SqlConnection(connStr)
        Try
            connection.Open()
            Dim cmd As New SqlCommand("Select count*", connection)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            MessageBox.Show("Congratulations, you've successfully completed your registration process.", "Registration Status", MessageBoxButtons.OK)
            Me.Close()
            Selection.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
End Class
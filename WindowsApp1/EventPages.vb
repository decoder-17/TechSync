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
        Dim i As Integer = 6
        Dim connStr As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TechSync;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        Dim connection As New SqlConnection(connStr)
        While (i > 0)
            Try
                connection.Open()
                Dim cmd As New SqlCommand("Select count(*) from Events where GOC IS NOT NULL", connection)
                Label1.Text = Convert.ToInt32(cmd.ExecuteScalar)
                Me.Close()
                Selection.Show()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connection.Close()
            End Try
            i -= 1
        End While
    End Sub
End Class
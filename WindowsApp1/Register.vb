Imports System.Data.SqlClient
Public Class Register

    Private Sub Journals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.None
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.Hide()
        Selection.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connStr As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TechSync;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        Dim connection As New SqlConnection(connStr)
        connection.Open()
        Dim cmd As New SqlCommand("Insert into Register([TN],[TK],[SC],[GC],[WW],[CH],[GX]) values ('" + "')", connection)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        MessageBox.Show("Data has been saved successfully.")
        connection.Close()
    End Sub
End Class
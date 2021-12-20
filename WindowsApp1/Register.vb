Imports System.Data.SqlClient
Public Class Register

    Private Sub Journals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.None
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.Close()
        Selection.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connStr As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TechSync;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        Dim connection As New SqlConnection(connStr)
        Dim colName As String = ""
        Dim colValue As String = ""
        'Dim pid As Integer
        connection.Open()
        If (CheckedListBox1.GetItemChecked(0)) Then
            colName = "GC"
            colValue = "1"
        ElseIf (CheckedListBox1.GetItemChecked(1)) Then

        End If
        Dim cmd As New SqlCommand("SELECT SCOPE_IDENTITY()", connection)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        Dim inp As New SqlCommand("Insert into Register('" + colName + "') values ('" + colValue + "')", connection)
        inp.ExecuteReader()
        MessageBox.Show("Data has been saved successfully.", "Registration Status", MessageBoxButtons.OK)
        connection.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        End
    End Sub
End Class
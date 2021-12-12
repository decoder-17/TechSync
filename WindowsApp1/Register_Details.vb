Imports System.Data.SqlClient

Public Class Register_Details

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Entry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.None
        WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        username.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub




    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Selection.Show()

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connStr As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TechSync;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        Dim connection As New SqlConnection(connStr)
        Dim cmd As New SqlCommand("Insert into Login([pid],[pname],[college],[department],[paymentstatus],[tn],[tk],[sc],[gc],[ww],[ch],[gx]) values('" & TextBox1.Text.Trim & "' ,'" & TextBox2.Text.Trim & "'", connection)
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
    End Sub
End Class
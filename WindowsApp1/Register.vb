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
        Dim amt As Integer = 0
        connection.Open()
        If (CheckedListBox1.GetItemChecked(0)) Then
            colName = "[GOC],"
            colValue = "1"
            amt = 200
        ElseIf (CheckedListBox1.GetItemChecked(1)) Then
            colName &= "[SC],"
            colValue &= "1,"
            amt += 500
        ElseIf (CheckedListBox1.GetItemChecked(2)) Then
            colName &= "[CH],"
            colValue &= "1,"
            amt += 200
        ElseIf (CheckedListBox1.GetItemChecked(3)) Then
            colName &= "[WW],"
            colValue &= "1,"
            amt += 200
        ElseIf (CheckedListBox1.GetItemChecked(4)) Then
            colName &= "[TK],"
            colValue &= "1,"
            amt += 200
        ElseIf (CheckedListBox1.GetItemChecked(5)) Then
            colName &= "[TN],"
            colValue &= "1,"
            amt += 500
        ElseIf (CheckedListBox1.GetItemChecked(6)) Then
            colName &= "[GX]"
            colValue &= "1"
            amt += 200
        End If
        Dim cmd As New SqlCommand("Insert into Events([PID],'" + colName + "') values ('" + TextBox2.Text.Trim + "','" + colValue + "')", connection)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        MessageBox.Show("Data has been saved successfully.", "Registration Status", MessageBoxButtons.OK)
        fees.Text = amt.ToString
        connection.Close()
        colName = ""
        colValue = ""
        amt = 0
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim connStr As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TechSync;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        Dim connection As New SqlConnection(connStr)
        connection.Open()
        If (RadioButton1.Checked.Equals(True)) Then

        End If
        Dim cmd As New SqlCommand("Insert into Payment([PID],'" + colName + "') values ('" + TextBox2.Text.Trim + "','" + colValue + "')", connection)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        MessageBox.Show("Data has been saved successfully.", "Registration Status", MessageBoxButtons.OK)
        fees.Text = amt.ToString
        connection.Close()

    End Sub
End Class
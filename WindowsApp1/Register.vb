Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Register
    Dim pid, amt As Integer
    Private Sub Journals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.None
        WindowState = FormWindowState.Maximized
        Dim connStr As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TechSync;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        Dim connection As New SqlConnection(connStr)
        Try
            connection.Open()
            Dim cmd As New SqlCommand("select * from Register", connection)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            While (dr.Read())
                TextBox2.Text = dr.GetValue(0)
            End While
            pid = TextBox2.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try
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
        Dim i, c, pos, len As Integer
        If (CheckedListBox1.GetItemChecked(0)) Then
            colName = "[GOC],"
            colValue = "1,"
            amt = 200
        End If
        If (CheckedListBox1.GetItemChecked(1)) Then
            colName &= "[SC],"
            colValue &= "1,"
            amt += 500
        End If
        If (CheckedListBox1.GetItemChecked(2)) Then
            colName &= "[CH],"
            colValue &= "1,"
            amt += 200
        End If
        If (CheckedListBox1.GetItemChecked(3)) Then
            colName &= "[WW],"
            colValue &= "1,"
            amt += 200
        End If
        If (CheckedListBox1.GetItemChecked(4)) Then
            colName &= "[TK],"
            colValue &= "1,"
            amt += 200
        End If
        If (CheckedListBox1.GetItemChecked(5)) Then
            colName &= "[TN],"
            colValue &= "1,"
            amt += 500
        End If
        If (CheckedListBox1.GetItemChecked(6)) Then
            colName &= "[GX],"
            colValue &= "1,"
            amt += 200
        End If
        c = 0
        For i = 0 To (CheckedListBox1.Items.Count - 1)
            If CheckedListBox1.GetItemChecked(i) = True Then
                c += 1
            End If
        Next
        pos = colName.LastIndexOf(",")
        len = colName.Length
        colName = colName.Remove(pos, 1)
        pos = colValue.LastIndexOf(",")
        len = colValue.Length
        colValue = colValue.Remove(pos, 1)
        If (c = 0) Then
            MessageBox.Show("Please select an event before you submit.", "Event Selection")
        Else
            Try
                connection.Open()
                Dim cmd As New SqlCommand("Insert into Events([PID]," + colName.Trim + ") values (" + TextBox2.Text.Trim + "," + colValue.Trim + ")", connection)
                Dim dr As SqlDataReader = cmd.ExecuteReader()
                MessageBox.Show("Data has been saved successfully.", "Registration Status", MessageBoxButtons.OK)
                fees.Text = amt.ToString("C")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connection.Close()

            End Try
        End If
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
        Try
            connection.Open()
            If Not Regex.Match(TextBox3.Text, "^[a-z ][0-9]*$", RegexOptions.IgnoreCase).Success Then
                Dim cmd As New SqlCommand("Insert into Payment([PID],[Amount],[TransactionID],[RegistrationStatus]) values (" + TextBox2.Text.Trim + "," + amt + "," + TextBox3.Text.Trim + "," + 1 + ")", connection)
                Dim dr As SqlDataReader = cmd.ExecuteReader()
                MessageBox.Show("Congratulations, you've successfully completed your registration process.", "Registration Status", MessageBoxButtons.OK)
            Else
                MessageBox.Show("Payment is pending, please complete your payment to be participate against the elites.", "Registration Status", MessageBoxButtons.OK)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try


    End Sub
End Class
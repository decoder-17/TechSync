Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Display

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        username.Show()

    End Sub

    Private Sub Display_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.None
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dept.Clear()
        pname.Clear()
        cname.Clear()
        cno.Clear()
        pid.Clear()
        eventDisplay.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim connStr As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TechSync;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        Dim connection As New SqlConnection(connStr)
        Try
            Dim cmd As New SqlCommand("select *from Register where pid='" + pid.Text.Trim + "'", connection)
            connection.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If (dr.Read = False) Then
                MessageBox.Show("Participant doesn't exist, please enter the ID correctly.")
            Else
                pname.Text = dr.GetString(1)
                cno.Text = dr.GetInt64(2)
                cname.Text = dr.GetString(3)
                dept.Text = dr.GetString(4)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Selection.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim connStr As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TechSync;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        Dim connection As New SqlConnection(connStr)
        Dim eventList() As String = {"Game of Code", "Sparrow's Chest", "Capturing Hues", "Web Weaver", "Techknack", "Technova", "Game X"}
        Dim eventSelected As String = ""
        Dim pos, len As Integer
        Try
            connection.Open()
            Dim cmd As New SqlCommand("select *from Events where pid='" + pid.Text.Trim + "'", connection)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If (dr.Read = False) Then
                MessageBox.Show("Participant didn't register for any event, please register first.")
            Else
                For i As Integer = 1 To 6
                    If (dr.GetValue(i).Equals(True)) Then
                        eventSelected &= eventList(i - 1)
                        eventSelected &= ", "
                    End If
                Next
                pos = eventSelected.LastIndexOf(",")
                len = eventSelected.Length
                eventSelected = eventSelected.Remove(pos, 2)
                eventSelected &= "."
                eventDisplay.Text = eventSelected
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub pid_TextChanged(sender As Object, e As EventArgs) Handles pid.TextChanged
        If Not Regex.Match(pid.Text.Trim, "^[0-9]{1,10}$").Success Then
            MessageBox.Show("Please enter your valid Participant ID.", "Participant's ID")
            pid.Clear()
            pid.Focus()
        End If
    End Sub
End Class
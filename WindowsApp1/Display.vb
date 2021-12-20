Imports MySql.Data.MySqlClient
Public Class Display
    Dim MysqlConn As MySqlConnection
    Dim cmd As MySqlCommand

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        username.Show()

    End Sub

    Private Sub Display_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FormBorderStyle = FormBorderStyle.None
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MysqlConn = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;password=2611;database=themyth"
        }
        Dim READER As MySqlDataReader



        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "select name, eid, doj, qualification from entry where eid ='" & TextBox1.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            READER = cmd.ExecuteReader
            READER.Read()
            TextBox5.Text = READER("Name").ToString()
            TextBox1.Text = READER("EID").ToString()
            TextBox6.Text = READER("DoJ").ToString()
            TextBox7.Text = READER("Qualification").ToString()
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

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
        Me.Close()
        Display___Journals.Show()

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
Imports System.Data
Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Registrations
    Private Sub Registrations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.None
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim connStr As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TechSync;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        Dim connection As New SqlConnection(connStr)
        Dim ds As New DataSet
        Dim i, j As Integer
        Dim exAp As Excel.Application
        Dim exWB As Excel.Workbook
        Dim exWS As Excel.Worksheet
        Dim misVal As Object = System.Reflection.Missing.Value

        exAp = New Excel.Application
        exWB = exAp.Workbooks.Add(misVal)
        exWS = exWB.Sheets("Sheet1")
        Try
            Dim query As String = "Select * from Register"
            connection.Open()
            Dim sda As New SqlDataAdapter(query, connection)
            sda.Fill(ds)
            For i = 0 To ds.Tables(0).Columns.Count - 1
                exWS.Cells(1, i) = ds.Tables(0).Columns(i).ColumnName
            Next
            For i = 0 To ds.Tables(0).Rows.Count - 1
                For j = 0 To ds.Tables(0).Columns.Count - 1
                    exWS.Cells(i + 2, j + 1) = ds.Tables(0).Rows(i).Item(j)
                Next
            Next
            exWS.SaveAs("E:\Presidency College\Final Year Project\Resources\ExportData.xlsx")
            MessageBox.Show("Exported successfully.", "Export")
            path.Text = "The file has successfully been exported to E:\Presidency College\Final Year Project\Resources\ExportData.xlsx"
            Me.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            exWB.Close()
            exAp.Quit()
            releaseObject(exAp)
            releaseObject(exWB)
            releaseObject(exWS)
            connection.Close()

        End Try
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
            MessageBox.Show(ex.Message)
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        username.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Selection.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim filename As String = "E:\Presidency College\Final Year Project\Resources\ExportData.xlsx"

        If System.IO.File.Exists(filename) = True Then
            Process.Start(filename)
        Else
            MessageBox.Show("The file doesn't exist.")
        End If
    End Sub
End Class
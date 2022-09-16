Imports System.Data.SqlClient
Public Class Basket
    Dim Con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=bakkal;Integrated Security=True")

    Private Sub Basket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Con.Open()
        Dim query = "select * from basket"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        BillDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Obj = New Billing
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Con.Open()
            Dim query = "truncate table basket"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Sepet Temizlendi")
            Con.Close()
            Con.Open()
            Dim query2 = "select * from basket"
            Dim cmd2 = New SqlCommand(query2, Con)
            Dim adapter As SqlDataAdapter
            adapter = New SqlDataAdapter(cmd2)
            Dim builder As New SqlCommandBuilder(adapter)
            Dim ds As DataSet
            ds = New DataSet
            adapter.Fill(ds)
            BillDGV.DataSource = ds.Tables(0)
            Con.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class
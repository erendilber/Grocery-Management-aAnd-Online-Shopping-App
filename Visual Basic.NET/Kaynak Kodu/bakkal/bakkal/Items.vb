Imports System.Data.SqlClient

Public Class Items
    Dim Con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=bakkal;Integrated Security=True")
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ItemNameTb.Text = "" Or QtyTb.Text = "" Or CatCb.SelectedIndex = -1 Or PriceTb.Text = "" Then
            MsgBox("Eksik Bilgi")
        Else
            Try
                Con.Open()
                Dim query = "insert into ItemTbl values('" & ItemNameTb.Text & "', '" & QtyTb.Text & "', '" & PriceTb.Text & "', '" & CatCb.SelectedItem.ToString() & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Ürün Kaydedildi")
                Con.Close()
                DisplayItem()
                Clear()
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub Clear()
        ItemNameTb.Text = ""
        QtyTb.Text = ""
        PriceTb.Text = ""
        CatCb.SelectedIndex = 0

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Clear()

    End Sub

    Private Sub Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayItem()
    End Sub

    Private Sub DisplayItem()
        Con.Open()
        Dim query = "select * from ItemTbl"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub FilterByCat()
        Con.Open()
        Dim query = "select * from ItemTbl where ItCat='" & ComboBox1.SelectedItem.ToString() & "'"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Dim key = 0
    Private Sub ItemDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDGV.CellMouseClick
        Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
        ItemNameTb.Text = row.Cells(1).Value.ToString
        QtyTb.Text = row.Cells(2).Value.ToString
        PriceTb.Text = row.Cells(3).Value.ToString
        CatCb.SelectedItem = row.Cells(4).Value.ToString
        If ItemNameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If key = 0 Then
            MsgBox("Bir ürün seçin")
        Else
            Try
                Con.Open()
                Dim query = "delete from ItemTbl where ItId=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Ürün silindi")
                Con.Close()
                DisplayItem()
                Clear()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ItemNameTb.Text = "" Or QtyTb.Text = "" Or CatCb.SelectedIndex = -1 Or PriceTb.Text = "" Then
            MsgBox("Eksik Bilgi")
        Else
            Try
                Con.Open()
                Dim query = "update ItemTbl set ItName='" & ItemNameTb.Text & "', ItQty=" & QtyTb.Text & ", ItPrice=" & PriceTb.Text & ", ItCat='" & CatCb.SelectedItem.ToString() & "' where ItId=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Ürün düzenlendi")
                Con.Close()
                DisplayItem()
                Clear()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        FilterByCat()
    End Sub
End Class
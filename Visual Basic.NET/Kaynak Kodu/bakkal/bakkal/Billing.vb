Imports System.Data.SqlClient
Public Class Billing
    Dim i = 0, GrdTotal = 0
    Private Sub Reset()
        ItNameTb.Text = ""
        PriceTb.Text = ""
        QtyTb.Text = ""
        'TotalLbl.Text = "Total"
        key = 0
        Stock = 0
    End Sub

    Private Sub AddBill()
        Try
            Con.Open()
            Dim query = "insert into BillTbl values('" & ClientTb.Text & "','" & GrdTotal & "', '" & DateTime.Today.Date & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Fatura Kaydedildi")
            Con.Close()
            TotalLbl.Text = "Total"
            BillDGV.Rows.Clear()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub UpdateItem()
        Dim newqty = Stock - Convert.ToInt32(QtyTb.Text)
        Try
            Con.Open()
            Dim query = "update ItemTbl set ItQty=" & newqty & " where ItId=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Ürün güncellendi")
            Con.Close()
            DisplayItem()
        Catch ex As Exception

        End Try
    End Sub


    Dim Con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=bakkal;Integrated Security=True")
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()

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
    Private Sub Billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayItem()
    End Sub
    Dim key = 0, Stock = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Reset()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ClientTb.Text = "" Then
            MsgBox("Müşteri Adı giriniz")
        Else
            PrintPreviewDialog1.Show()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Obj = New Login
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Con.Open()
            Dim toplam = Convert.ToInt32(QtyTb.Text) * Convert.ToInt32(PriceTb.Text)
            Dim query = "insert into basket values('" & ItNameTb.Text & "'," & toplam & ")"

            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Sepete Eklendi")
            Con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim Obj = New Basket
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font1 As New Font("arial", 32, FontStyle.Regular)
        Dim font2 As New Font("arial", 16, FontStyle.Regular)
        Dim font3 As New Font("arial", 24, FontStyle.Regular)
        Dim bm As New Bitmap(Me.BillDGV.Width, Me.BillDGV.Height)
        BillDGV.DrawToBitmap(bm, New Rectangle(30, 30, Me.BillDGV.Width, Me.BillDGV.Height))
        e.Graphics.DrawImage(bm, 80, 200)
        e.Graphics.DrawString("FATURA", font1, Brushes.Red, 320, 100)
        e.Graphics.DrawString("Müşteri:" & ClientTb.Text, font3, Brushes.Black, 100, 1000)
        e.Graphics.DrawString("ONLINE ALIŞVERİŞ - Mutlu Günler Diler", font3, Brushes.Crimson, 100, 1100)

    End Sub

    Private Sub PrintPreviewDialog1_Load_1(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If PriceTb.Text = "" Or QtyTb.Text = "" Then
            MsgBox("Adet giriniz")
        ElseIf ItNameTb.Text = "" Then
            MsgBox("Ürün seçin")
        Else
            Dim rnum As Integer = BillDGV.Rows.Add()
            i = i + 1
            Dim total = Convert.ToInt32(QtyTb.Text) * Convert.ToInt32(PriceTb.Text)
            BillDGV.Rows.Item(rnum).Cells("Column1").Value = i
            BillDGV.Rows.Item(rnum).Cells("Column2").Value = ItNameTb.Text
            BillDGV.Rows.Item(rnum).Cells("Column3").Value = PriceTb.Text
            BillDGV.Rows.Item(rnum).Cells("Column4").Value = QtyTb.Text
            BillDGV.Rows.Item(rnum).Cells("Column5").Value = total
            GrdTotal = GrdTotal + total
            Dim tot As String
            tot = "Toplam : " + Convert.ToString(GrdTotal)
            TotalLbl.Text = tot
            UpdateItem()
            DisplayItem()
        End If
    End Sub

    Private Sub ItemDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDGV.CellMouseClick
        Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
        ItNameTb.Text = row.Cells(1).Value.ToString
        PriceTb.Text = row.Cells(3).Value.ToString
        If ItNameTb.Text = "" Then
            key = 0
        Else
            Stock = Convert.ToInt32(row.Cells(2).Value.ToString)
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub
End Class
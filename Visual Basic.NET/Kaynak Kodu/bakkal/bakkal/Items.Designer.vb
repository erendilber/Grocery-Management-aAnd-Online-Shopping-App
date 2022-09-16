<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Items
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Items))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ItemNameTb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CatCb = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PriceTb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.QtyTb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ItemDGV = New System.Windows.Forms.DataGridView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.ItemDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 32.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(305, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(381, 52)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ONLINE ALIŞVERİŞ"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Orchid
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(955, 100)
        Me.Panel1.TabIndex = 7
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(920, -2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 41)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Orchid
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(101, 78)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 45)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Kaydet"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ItemNameTb
        '
        Me.ItemNameTb.Location = New System.Drawing.Point(159, 41)
        Me.ItemNameTb.Name = "ItemNameTb"
        Me.ItemNameTb.Size = New System.Drawing.Size(152, 20)
        Me.ItemNameTb.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Orchid
        Me.Label4.Location = New System.Drawing.Point(191, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 22)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Ürün Adı"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.CatCb)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.PriceTb)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.QtyTb)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.ItemNameTb)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(12, 155)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(917, 145)
        Me.Panel2.TabIndex = 23
        '
        'CatCb
        '
        Me.CatCb.FormattingEnabled = True
        Me.CatCb.Items.AddRange(New Object() {"BALIK", "MEYVE", "SEBZE", "ET"})
        Me.CatCb.Location = New System.Drawing.Point(633, 39)
        Me.CatCb.Name = "CatCb"
        Me.CatCb.Size = New System.Drawing.Size(152, 21)
        Me.CatCb.TabIndex = 32
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Orchid
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(680, 78)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(149, 45)
        Me.Button4.TabIndex = 31
        Me.Button4.Text = "Temizle"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Orchid
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(487, 78)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 45)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Sil"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Orchid
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(294, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 45)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Düzenle"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Orchid
        Me.Label5.Location = New System.Drawing.Point(666, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 22)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Kategori"
        '
        'PriceTb
        '
        Me.PriceTb.Location = New System.Drawing.Point(475, 40)
        Me.PriceTb.Name = "PriceTb"
        Me.PriceTb.Size = New System.Drawing.Size(152, 20)
        Me.PriceTb.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Orchid
        Me.Label3.Location = New System.Drawing.Point(525, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 22)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Fiyat"
        '
        'QtyTb
        '
        Me.QtyTb.Location = New System.Drawing.Point(317, 41)
        Me.QtyTb.Name = "QtyTb"
        Me.QtyTb.Size = New System.Drawing.Size(152, 20)
        Me.QtyTb.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Orchid
        Me.Label1.Location = New System.Drawing.Point(365, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 22)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Adet"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Orchid
        Me.Label6.Location = New System.Drawing.Point(411, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 22)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "ÜRÜN YÖNETİMİ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Orchid
        Me.Label7.Location = New System.Drawing.Point(465, 315)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 22)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "STOK"
        '
        'ItemDGV
        '
        Me.ItemDGV.BackgroundColor = System.Drawing.Color.White
        Me.ItemDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemDGV.Location = New System.Drawing.Point(12, 384)
        Me.ItemDGV.Name = "ItemDGV"
        Me.ItemDGV.Size = New System.Drawing.Size(917, 264)
        Me.ItemDGV.TabIndex = 35
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"BALIK", "MEYVE", "SEBZE", "ET"})
        Me.ComboBox1.Location = New System.Drawing.Point(411, 348)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(152, 21)
        Me.ComboBox1.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Orchid
        Me.Label8.Location = New System.Drawing.Point(190, 348)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(215, 22)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Kategoriye göre filtrele"
        '
        'Items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(955, 660)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ItemDGV)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Items"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Items"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ItemDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents ItemNameTb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CatCb As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents PriceTb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents QtyTb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ItemDGV As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label8 As Label
End Class

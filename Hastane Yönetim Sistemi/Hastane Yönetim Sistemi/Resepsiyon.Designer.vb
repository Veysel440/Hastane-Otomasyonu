<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Resepsiyon
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Resepsiyon))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ResepidTb = New System.Windows.Forms.MaskedTextBox()
        Me.ResepAdıTb = New System.Windows.Forms.MaskedTextBox()
        Me.ReseptelTb = New System.Windows.Forms.MaskedTextBox()
        Me.ResepşifreTb = New System.Windows.Forms.MaskedTextBox()
        Me.ResepadresTb = New System.Windows.Forms.MaskedTextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ResepsiyonDGV = New System.Windows.Forms.DataGridView()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.ResepsiyonDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(128, 451)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button4.ForeColor = System.Drawing.Color.Crimson
        Me.Button4.Location = New System.Drawing.Point(0, 198)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(125, 29)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Tedaviler"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.Crimson
        Me.Button2.Location = New System.Drawing.Point(0, 163)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 29)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Doktorlar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.Crimson
        Me.Button1.Location = New System.Drawing.Point(0, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Hastalar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(128, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(714, 28)
        Me.Panel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(687, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(366, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 30)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Resepsiyon Sistemi"
        '
        'ResepidTb
        '
        Me.ResepidTb.BackColor = System.Drawing.Color.White
        Me.ResepidTb.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ResepidTb.ForeColor = System.Drawing.SystemColors.Highlight
        Me.ResepidTb.Location = New System.Drawing.Point(134, 119)
        Me.ResepidTb.Name = "ResepidTb"
        Me.ResepidTb.Size = New System.Drawing.Size(145, 25)
        Me.ResepidTb.TabIndex = 4
        Me.ResepidTb.Text = "Resepsiyon İD"
        '
        'ResepAdıTb
        '
        Me.ResepAdıTb.BackColor = System.Drawing.Color.White
        Me.ResepAdıTb.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ResepAdıTb.ForeColor = System.Drawing.SystemColors.Highlight
        Me.ResepAdıTb.Location = New System.Drawing.Point(134, 154)
        Me.ResepAdıTb.Name = "ResepAdıTb"
        Me.ResepAdıTb.Size = New System.Drawing.Size(145, 25)
        Me.ResepAdıTb.TabIndex = 5
        Me.ResepAdıTb.Text = "Resepsiyon Adı"
        '
        'ReseptelTb
        '
        Me.ReseptelTb.BackColor = System.Drawing.Color.White
        Me.ReseptelTb.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ReseptelTb.ForeColor = System.Drawing.SystemColors.Highlight
        Me.ReseptelTb.Location = New System.Drawing.Point(134, 224)
        Me.ReseptelTb.Name = "ReseptelTb"
        Me.ReseptelTb.Size = New System.Drawing.Size(145, 25)
        Me.ReseptelTb.TabIndex = 6
        Me.ReseptelTb.Text = "Telefon"
        '
        'ResepşifreTb
        '
        Me.ResepşifreTb.BackColor = System.Drawing.Color.White
        Me.ResepşifreTb.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ResepşifreTb.ForeColor = System.Drawing.SystemColors.Highlight
        Me.ResepşifreTb.Location = New System.Drawing.Point(134, 189)
        Me.ResepşifreTb.Name = "ResepşifreTb"
        Me.ResepşifreTb.Size = New System.Drawing.Size(145, 25)
        Me.ResepşifreTb.TabIndex = 7
        Me.ResepşifreTb.Text = "Şifre"
        '
        'ResepadresTb
        '
        Me.ResepadresTb.BackColor = System.Drawing.Color.White
        Me.ResepadresTb.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ResepadresTb.ForeColor = System.Drawing.SystemColors.Highlight
        Me.ResepadresTb.Location = New System.Drawing.Point(134, 259)
        Me.ResepadresTb.Name = "ResepadresTb"
        Me.ResepadresTb.Size = New System.Drawing.Size(145, 25)
        Me.ResepadresTb.TabIndex = 8
        Me.ResepadresTb.Text = "Adres"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(206, 298)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(66, 39)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Sil"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(134, 298)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(66, 39)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "Ekle"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(278, 298)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(76, 39)
        Me.Button7.TabIndex = 11
        Me.Button7.Text = "Düzenle"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'ResepsiyonDGV
        '
        Me.ResepsiyonDGV.BackgroundColor = System.Drawing.Color.White
        Me.ResepsiyonDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ResepsiyonDGV.GridColor = System.Drawing.Color.White
        Me.ResepsiyonDGV.Location = New System.Drawing.Point(409, 91)
        Me.ResepsiyonDGV.Name = "ResepsiyonDGV"
        Me.ResepsiyonDGV.RowTemplate.Height = 25
        Me.ResepsiyonDGV.Size = New System.Drawing.Size(411, 340)
        Me.ResepsiyonDGV.TabIndex = 12
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(206, 343)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(66, 39)
        Me.Button5.TabIndex = 35
        Me.Button5.Text = "Çıkış"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Resepsiyon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 451)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.ResepsiyonDGV)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ResepadresTb)
        Me.Controls.Add(Me.ResepşifreTb)
        Me.Controls.Add(Me.ReseptelTb)
        Me.Controls.Add(Me.ResepAdıTb)
        Me.Controls.Add(Me.ResepidTb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Resepsiyon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resepsiyon"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ResepsiyonDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ResepidTb As MaskedTextBox
    Friend WithEvents ResepAdıTb As MaskedTextBox
    Friend WithEvents ReseptelTb As MaskedTextBox
    Friend WithEvents ResepşifreTb As MaskedTextBox
    Friend WithEvents ResepadresTb As MaskedTextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ResepsiyonDGV As DataGridView
    Friend WithEvents Button5 As Button
End Class

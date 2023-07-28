<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoktorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DoktorForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DokşifreTb = New System.Windows.Forms.MaskedTextBox()
        Me.DokDeneyimTb = New System.Windows.Forms.MaskedTextBox()
        Me.DokuzmanTb = New System.Windows.Forms.MaskedTextBox()
        Me.DokAdıTb = New System.Windows.Forms.MaskedTextBox()
        Me.DokidTb = New System.Windows.Forms.MaskedTextBox()
        Me.DoktorDGV = New System.Windows.Forms.DataGridView()
        Me.DokcinsiteCb = New System.Windows.Forms.ComboBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DoktorDGV, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(128, 470)
        Me.Panel1.TabIndex = 1
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
        Me.Button2.Text = "Resepsiyon"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(351, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 30)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Doktor Sistemi"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(128, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(695, 28)
        Me.Panel2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(653, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 30)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "X"
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
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(274, 358)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(74, 39)
        Me.Button7.TabIndex = 19
        Me.Button7.Text = "Düzenle"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(130, 358)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(66, 39)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "Ekle"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(202, 358)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(66, 39)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Sil"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'DokşifreTb
        '
        Me.DokşifreTb.BackColor = System.Drawing.Color.White
        Me.DokşifreTb.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DokşifreTb.ForeColor = System.Drawing.SystemColors.Highlight
        Me.DokşifreTb.Location = New System.Drawing.Point(134, 314)
        Me.DokşifreTb.Name = "DokşifreTb"
        Me.DokşifreTb.Size = New System.Drawing.Size(145, 25)
        Me.DokşifreTb.TabIndex = 16
        Me.DokşifreTb.Text = "Şifre"
        '
        'DokDeneyimTb
        '
        Me.DokDeneyimTb.BackColor = System.Drawing.Color.White
        Me.DokDeneyimTb.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DokDeneyimTb.ForeColor = System.Drawing.SystemColors.Highlight
        Me.DokDeneyimTb.Location = New System.Drawing.Point(134, 198)
        Me.DokDeneyimTb.Name = "DokDeneyimTb"
        Me.DokDeneyimTb.Size = New System.Drawing.Size(145, 25)
        Me.DokDeneyimTb.TabIndex = 15
        Me.DokDeneyimTb.Text = "Deneyim"
        '
        'DokuzmanTb
        '
        Me.DokuzmanTb.BackColor = System.Drawing.Color.White
        Me.DokuzmanTb.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DokuzmanTb.ForeColor = System.Drawing.SystemColors.Highlight
        Me.DokuzmanTb.Location = New System.Drawing.Point(134, 279)
        Me.DokuzmanTb.Name = "DokuzmanTb"
        Me.DokuzmanTb.Size = New System.Drawing.Size(145, 25)
        Me.DokuzmanTb.TabIndex = 14
        Me.DokuzmanTb.Text = "Uzmalık Dalı"
        '
        'DokAdıTb
        '
        Me.DokAdıTb.BackColor = System.Drawing.Color.White
        Me.DokAdıTb.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DokAdıTb.ForeColor = System.Drawing.SystemColors.Highlight
        Me.DokAdıTb.Location = New System.Drawing.Point(134, 163)
        Me.DokAdıTb.Name = "DokAdıTb"
        Me.DokAdıTb.Size = New System.Drawing.Size(145, 25)
        Me.DokAdıTb.TabIndex = 13
        Me.DokAdıTb.Text = "Doktor Adı"
        '
        'DokidTb
        '
        Me.DokidTb.BackColor = System.Drawing.Color.White
        Me.DokidTb.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DokidTb.ForeColor = System.Drawing.SystemColors.Highlight
        Me.DokidTb.Location = New System.Drawing.Point(134, 128)
        Me.DokidTb.Name = "DokidTb"
        Me.DokidTb.Size = New System.Drawing.Size(145, 25)
        Me.DokidTb.TabIndex = 12
        Me.DokidTb.Text = "Doktor İD"
        '
        'DoktorDGV
        '
        Me.DoktorDGV.BackgroundColor = System.Drawing.Color.White
        Me.DoktorDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DoktorDGV.GridColor = System.Drawing.Color.White
        Me.DoktorDGV.Location = New System.Drawing.Point(377, 85)
        Me.DoktorDGV.Name = "DoktorDGV"
        Me.DoktorDGV.RowTemplate.Height = 25
        Me.DoktorDGV.Size = New System.Drawing.Size(422, 340)
        Me.DoktorDGV.TabIndex = 20
        '
        'DokcinsiteCb
        '
        Me.DokcinsiteCb.BackColor = System.Drawing.Color.White
        Me.DokcinsiteCb.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DokcinsiteCb.ForeColor = System.Drawing.SystemColors.Highlight
        Me.DokcinsiteCb.FormattingEnabled = True
        Me.DokcinsiteCb.Items.AddRange(New Object() {"Erkek", "Kadın"})
        Me.DokcinsiteCb.Location = New System.Drawing.Point(134, 234)
        Me.DokcinsiteCb.Name = "DokcinsiteCb"
        Me.DokcinsiteCb.Size = New System.Drawing.Size(145, 29)
        Me.DokcinsiteCb.TabIndex = 21
        Me.DokcinsiteCb.Text = "Cinsiyet"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(202, 403)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(66, 39)
        Me.Button5.TabIndex = 35
        Me.Button5.Text = "Çıkış"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'DoktorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 470)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.DokcinsiteCb)
        Me.Controls.Add(Me.DoktorDGV)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DokşifreTb)
        Me.Controls.Add(Me.DokDeneyimTb)
        Me.Controls.Add(Me.DokuzmanTb)
        Me.Controls.Add(Me.DokAdıTb)
        Me.Controls.Add(Me.DokidTb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DoktorForm"
        Me.Text = "DoktorForm"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DoktorDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DokşifreTb As MaskedTextBox
    Friend WithEvents DokDeneyimTb As MaskedTextBox
    Friend WithEvents DokuzmanTb As MaskedTextBox
    Friend WithEvents DokAdıTb As MaskedTextBox
    Friend WithEvents DokidTb As MaskedTextBox
    Friend WithEvents DoktorDGV As DataGridView
    Friend WithEvents DokcinsiteCb As ComboBox
    Friend WithEvents Button5 As Button
End Class

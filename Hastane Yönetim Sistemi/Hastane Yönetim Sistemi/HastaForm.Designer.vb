<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HastaForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HastaForm))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.HasCinsiyetCb = New System.Windows.Forms.ComboBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.HasYaşTb = New System.Windows.Forms.MaskedTextBox()
        Me.HasBüyükTb = New System.Windows.Forms.MaskedTextBox()
        Me.HasAdıTb = New System.Windows.Forms.MaskedTextBox()
        Me.HasIDTb = New System.Windows.Forms.MaskedTextBox()
        Me.HastaDGV = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HasKanCb = New System.Windows.Forms.ComboBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HastaDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(128, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(672, 28)
        Me.Panel2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(645, -2)
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
        Me.Panel1.Size = New System.Drawing.Size(128, 450)
        Me.Panel1.TabIndex = 4
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
        Me.Button1.Text = "Doktor"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HasCinsiyetCb
        '
        Me.HasCinsiyetCb.BackColor = System.Drawing.Color.White
        Me.HasCinsiyetCb.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HasCinsiyetCb.ForeColor = System.Drawing.SystemColors.Highlight
        Me.HasCinsiyetCb.FormattingEnabled = True
        Me.HasCinsiyetCb.Items.AddRange(New Object() {"Erkek", "Kadın"})
        Me.HasCinsiyetCb.Location = New System.Drawing.Point(134, 208)
        Me.HasCinsiyetCb.Name = "HasCinsiyetCb"
        Me.HasCinsiyetCb.Size = New System.Drawing.Size(145, 29)
        Me.HasCinsiyetCb.TabIndex = 30
        Me.HasCinsiyetCb.Text = "Cinsiyet"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(278, 320)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(74, 39)
        Me.Button7.TabIndex = 29
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
        Me.Button6.Location = New System.Drawing.Point(134, 320)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(66, 39)
        Me.Button6.TabIndex = 28
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
        Me.Button3.Location = New System.Drawing.Point(206, 320)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(66, 39)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Sil"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'HasYaşTb
        '
        Me.HasYaşTb.BackColor = System.Drawing.Color.White
        Me.HasYaşTb.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.HasYaşTb.ForeColor = System.Drawing.SystemColors.Highlight
        Me.HasYaşTb.Location = New System.Drawing.Point(134, 172)
        Me.HasYaşTb.Name = "HasYaşTb"
        Me.HasYaşTb.Size = New System.Drawing.Size(145, 25)
        Me.HasYaşTb.TabIndex = 25
        Me.HasYaşTb.Text = "Yaş"
        '
        'HasBüyükTb
        '
        Me.HasBüyükTb.BackColor = System.Drawing.Color.White
        Me.HasBüyükTb.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.HasBüyükTb.ForeColor = System.Drawing.SystemColors.Highlight
        Me.HasBüyükTb.Location = New System.Drawing.Point(134, 278)
        Me.HasBüyükTb.Name = "HasBüyükTb"
        Me.HasBüyükTb.Size = New System.Drawing.Size(145, 25)
        Me.HasBüyükTb.TabIndex = 24
        Me.HasBüyükTb.Text = "Büyük hastalık"
        '
        'HasAdıTb
        '
        Me.HasAdıTb.BackColor = System.Drawing.Color.White
        Me.HasAdıTb.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.HasAdıTb.ForeColor = System.Drawing.SystemColors.Highlight
        Me.HasAdıTb.Location = New System.Drawing.Point(134, 137)
        Me.HasAdıTb.Name = "HasAdıTb"
        Me.HasAdıTb.Size = New System.Drawing.Size(145, 25)
        Me.HasAdıTb.TabIndex = 23
        Me.HasAdıTb.Text = "Hasta Adı"
        '
        'HasIDTb
        '
        Me.HasIDTb.BackColor = System.Drawing.Color.White
        Me.HasIDTb.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.HasIDTb.ForeColor = System.Drawing.SystemColors.Highlight
        Me.HasIDTb.Location = New System.Drawing.Point(134, 102)
        Me.HasIDTb.Name = "HasIDTb"
        Me.HasIDTb.Size = New System.Drawing.Size(145, 25)
        Me.HasIDTb.TabIndex = 22
        Me.HasIDTb.Text = "Hasta İD"
        '
        'HastaDGV
        '
        Me.HastaDGV.BackgroundColor = System.Drawing.Color.White
        Me.HastaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HastaDGV.GridColor = System.Drawing.Color.White
        Me.HastaDGV.Location = New System.Drawing.Point(361, 79)
        Me.HastaDGV.Name = "HastaDGV"
        Me.HastaDGV.RowTemplate.Height = 25
        Me.HastaDGV.Size = New System.Drawing.Size(422, 340)
        Me.HastaDGV.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(340, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 30)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Hasta Sistemi"
        '
        'HasKanCb
        '
        Me.HasKanCb.BackColor = System.Drawing.Color.White
        Me.HasKanCb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HasKanCb.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HasKanCb.ForeColor = System.Drawing.SystemColors.Highlight
        Me.HasKanCb.FormattingEnabled = True
        Me.HasKanCb.Items.AddRange(New Object() {"A+", "B+", "0+", "AB+", "A-", "B-", "0-", "AB-"})
        Me.HasKanCb.Location = New System.Drawing.Point(134, 243)
        Me.HasKanCb.Name = "HasKanCb"
        Me.HasKanCb.Size = New System.Drawing.Size(145, 29)
        Me.HasKanCb.TabIndex = 33
        Me.HasKanCb.Text = "Kan Grubu"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(206, 365)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(66, 39)
        Me.Button5.TabIndex = 34
        Me.Button5.Text = "Çıkış"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'HastaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.HasKanCb)
        Me.Controls.Add(Me.HastaDGV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HasCinsiyetCb)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.HasYaşTb)
        Me.Controls.Add(Me.HasBüyükTb)
        Me.Controls.Add(Me.HasAdıTb)
        Me.Controls.Add(Me.HasIDTb)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HastaForm"
        Me.Text = "HastaForm"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HastaDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents HasCinsiyetCb As ComboBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents HasYaşTb As MaskedTextBox
    Friend WithEvents HasBüyükTb As MaskedTextBox
    Friend WithEvents HasAdıTb As MaskedTextBox
    Friend WithEvents HasIDTb As MaskedTextBox
    Friend WithEvents HastaDGV As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents HasKanCb As ComboBox
    Friend WithEvents Button5 As Button
End Class

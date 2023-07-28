<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TeşhisForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TeşhisForm))
        Me.HasIdCb = New System.Windows.Forms.ComboBox()
        Me.TeşhisDGV = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SempTb = New System.Windows.Forms.MaskedTextBox()
        Me.İlaçTb = New System.Windows.Forms.MaskedTextBox()
        Me.HasAdıTb = New System.Windows.Forms.MaskedTextBox()
        Me.TeşhişID = New System.Windows.Forms.MaskedTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TeşTb = New System.Windows.Forms.MaskedTextBox()
        Me.TedaviCb = New System.Windows.Forms.ComboBox()
        Me.ÜcretTb = New System.Windows.Forms.MaskedTextBox()
        CType(Me.TeşhisDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HasIdCb
        '
        Me.HasIdCb.BackColor = System.Drawing.Color.White
        Me.HasIdCb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HasIdCb.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HasIdCb.ForeColor = System.Drawing.SystemColors.Highlight
        Me.HasIdCb.FormattingEnabled = True
        Me.HasIdCb.Items.AddRange(New Object() {"Erkek", "Kadın"})
        Me.HasIdCb.Location = New System.Drawing.Point(138, 126)
        Me.HasIdCb.Name = "HasIdCb"
        Me.HasIdCb.Size = New System.Drawing.Size(159, 29)
        Me.HasIdCb.TabIndex = 44
        Me.HasIdCb.Text = "Hasta İD"
        '
        'TeşhisDGV
        '
        Me.TeşhisDGV.BackgroundColor = System.Drawing.Color.White
        Me.TeşhisDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TeşhisDGV.GridColor = System.Drawing.Color.White
        Me.TeşhisDGV.Location = New System.Drawing.Point(360, 78)
        Me.TeşhisDGV.Name = "TeşhisDGV"
        Me.TeşhisDGV.RowTemplate.Height = 25
        Me.TeşhisDGV.Size = New System.Drawing.Size(428, 347)
        Me.TeşhisDGV.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(389, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 30)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Teşhisler"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(280, 364)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(74, 39)
        Me.Button7.TabIndex = 40
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
        Me.Button6.Location = New System.Drawing.Point(136, 364)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(66, 39)
        Me.Button6.TabIndex = 39
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
        Me.Button3.Location = New System.Drawing.Point(208, 364)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(66, 39)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "Sil"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'SempTb
        '
        Me.SempTb.BackColor = System.Drawing.Color.White
        Me.SempTb.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SempTb.ForeColor = System.Drawing.SystemColors.Highlight
        Me.SempTb.Location = New System.Drawing.Point(138, 223)
        Me.SempTb.Name = "SempTb"
        Me.SempTb.Size = New System.Drawing.Size(159, 25)
        Me.SempTb.TabIndex = 37
        Me.SempTb.Text = "Semptomlar"
        '
        'İlaçTb
        '
        Me.İlaçTb.BackColor = System.Drawing.Color.White
        Me.İlaçTb.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.İlaçTb.ForeColor = System.Drawing.SystemColors.Highlight
        Me.İlaçTb.Location = New System.Drawing.Point(138, 285)
        Me.İlaçTb.Name = "İlaçTb"
        Me.İlaçTb.Size = New System.Drawing.Size(159, 25)
        Me.İlaçTb.TabIndex = 36
        Me.İlaçTb.Text = "İlaçlar"
        '
        'HasAdıTb
        '
        Me.HasAdıTb.BackColor = System.Drawing.Color.White
        Me.HasAdıTb.Enabled = False
        Me.HasAdıTb.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.HasAdıTb.ForeColor = System.Drawing.SystemColors.Highlight
        Me.HasAdıTb.Location = New System.Drawing.Point(138, 192)
        Me.HasAdıTb.Name = "HasAdıTb"
        Me.HasAdıTb.Size = New System.Drawing.Size(159, 25)
        Me.HasAdıTb.TabIndex = 35
        Me.HasAdıTb.Text = "Hasta Adı"
        '
        'TeşhişID
        '
        Me.TeşhişID.BackColor = System.Drawing.Color.White
        Me.TeşhişID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TeşhişID.ForeColor = System.Drawing.SystemColors.Highlight
        Me.TeşhişID.Location = New System.Drawing.Point(138, 95)
        Me.TeşhişID.Name = "TeşhişID"
        Me.TeşhişID.Size = New System.Drawing.Size(163, 25)
        Me.TeşhişID.TabIndex = 34
        Me.TeşhişID.Text = "Teşhis İD"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(128, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(677, 28)
        Me.Panel2.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(650, 0)
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
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(128, 475)
        Me.Panel1.TabIndex = 45
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
        'TeşTb
        '
        Me.TeşTb.BackColor = System.Drawing.Color.White
        Me.TeşTb.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TeşTb.ForeColor = System.Drawing.SystemColors.Highlight
        Me.TeşTb.Location = New System.Drawing.Point(138, 254)
        Me.TeşTb.Name = "TeşTb"
        Me.TeşTb.Size = New System.Drawing.Size(159, 25)
        Me.TeşTb.TabIndex = 47
        Me.TeşTb.Text = "Teşhis"
        '
        'TedaviCb
        '
        Me.TedaviCb.BackColor = System.Drawing.Color.White
        Me.TedaviCb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TedaviCb.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TedaviCb.ForeColor = System.Drawing.SystemColors.Highlight
        Me.TedaviCb.FormattingEnabled = True
        Me.TedaviCb.Items.AddRange(New Object() {"Erkek", "Kadın"})
        Me.TedaviCb.Location = New System.Drawing.Point(138, 161)
        Me.TedaviCb.Name = "TedaviCb"
        Me.TedaviCb.Size = New System.Drawing.Size(159, 29)
        Me.TedaviCb.TabIndex = 49
        Me.TedaviCb.Text = "Hasta"
        '
        'ÜcretTb
        '
        Me.ÜcretTb.BackColor = System.Drawing.Color.White
        Me.ÜcretTb.Enabled = False
        Me.ÜcretTb.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ÜcretTb.ForeColor = System.Drawing.SystemColors.Highlight
        Me.ÜcretTb.Location = New System.Drawing.Point(138, 320)
        Me.ÜcretTb.Name = "ÜcretTb"
        Me.ÜcretTb.Size = New System.Drawing.Size(159, 25)
        Me.ÜcretTb.TabIndex = 50
        Me.ÜcretTb.Text = "Ücret"
        '
        'TeşhisForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 475)
        Me.Controls.Add(Me.ÜcretTb)
        Me.Controls.Add(Me.TedaviCb)
        Me.Controls.Add(Me.TeşTb)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.HasIdCb)
        Me.Controls.Add(Me.TeşhisDGV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.SempTb)
        Me.Controls.Add(Me.İlaçTb)
        Me.Controls.Add(Me.HasAdıTb)
        Me.Controls.Add(Me.TeşhişID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TeşhisForm"
        Me.Text = "TeşhisForm"
        CType(Me.TeşhisDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HasIdCb As ComboBox
    Friend WithEvents TeşhisDGV As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents SempTb As MaskedTextBox
    Friend WithEvents İlaçTb As MaskedTextBox
    Friend WithEvents HasAdıTb As MaskedTextBox
    Friend WithEvents TeşhişID As MaskedTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TeşTb As MaskedTextBox
    Friend WithEvents TedaviCb As ComboBox
    Friend WithEvents ÜcretTb As MaskedTextBox
End Class

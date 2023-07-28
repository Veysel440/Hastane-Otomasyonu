<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.KullanıcıTb = New System.Windows.Forms.MaskedTextBox()
        Me.ŞifreTb = New System.Windows.Forms.MaskedTextBox()
        Me.RolCb = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(293, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(270, 370)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(36, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 32)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Merkez Hastane"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(293, 70)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(34, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Hastane yönetim sistemi"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(49, 257)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 39)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Giriş"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'KullanıcıTb
        '
        Me.KullanıcıTb.BackColor = System.Drawing.Color.White
        Me.KullanıcıTb.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.KullanıcıTb.ForeColor = System.Drawing.SystemColors.Highlight
        Me.KullanıcıTb.Location = New System.Drawing.Point(49, 152)
        Me.KullanıcıTb.Name = "KullanıcıTb"
        Me.KullanıcıTb.Size = New System.Drawing.Size(145, 29)
        Me.KullanıcıTb.TabIndex = 3
        Me.KullanıcıTb.Text = "Kullanıcı Adı"
        '
        'ŞifreTb
        '
        Me.ŞifreTb.BackColor = System.Drawing.Color.White
        Me.ŞifreTb.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ŞifreTb.ForeColor = System.Drawing.SystemColors.Highlight
        Me.ŞifreTb.Location = New System.Drawing.Point(49, 202)
        Me.ŞifreTb.Name = "ŞifreTb"
        Me.ŞifreTb.Size = New System.Drawing.Size(145, 29)
        Me.ŞifreTb.TabIndex = 4
        Me.ŞifreTb.Text = "Şifre"
        '
        'RolCb
        '
        Me.RolCb.BackColor = System.Drawing.Color.White
        Me.RolCb.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RolCb.ForeColor = System.Drawing.SystemColors.Highlight
        Me.RolCb.FormattingEnabled = True
        Me.RolCb.Items.AddRange(New Object() {"Resepsiyon", "Doktor"})
        Me.RolCb.Location = New System.Drawing.Point(49, 99)
        Me.RolCb.Name = "RolCb"
        Me.RolCb.Size = New System.Drawing.Size(145, 29)
        Me.RolCb.TabIndex = 5
        Me.RolCb.Text = "Rol Seçin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(97, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Temizle"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 370)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RolCb)
        Me.Controls.Add(Me.ŞifreTb)
        Me.Controls.Add(Me.KullanıcıTb)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents KullanıcıTb As MaskedTextBox
    Friend WithEvents ŞifreTb As MaskedTextBox
    Friend WithEvents RolCb As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class

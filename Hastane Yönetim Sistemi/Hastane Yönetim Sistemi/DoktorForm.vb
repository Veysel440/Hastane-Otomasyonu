Imports System.Data.SqlClient
Public Class DoktorForm
    Dim Con As New SqlConnection("Data Source=DESKTOP-EUFH0D7;Initial Catalog=HastaneDB;Integrated Security=True")

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Con.Open()
        Dim query As String
        query = "insert into DoktorTbl values(" & DokidTb.Text & "," & DokAdıTb.Text & "," & DokDeneyimTb.Text & "," & DokcinsiteCb.SelectedItem.ToString & "," & DokuzmanTb.Text & "," & DokşifreTb.Text & ")"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Doktor Başarılı ekledi")
        Con.Close()
        populate()
    End Sub
    Public Sub populate()
        Con.Open()
        Dim sql = "select * from DoktorTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DoktorDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub DoktorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If DokidTb.Text = "" Then
            MsgBox("Doktor id girin")
        Else
            Con.Open()
            Dim query As String
            query = "delete from DoktorTbl where Dokid = " & DokidTb.Text&""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("Doktor başarıyla silindi")
            populate()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If DokidTb.Text = "" Or DokAdıTb.Text = "" Or DokşifreTb.Text = "" Or DokuzmanTb.Text = "" Then
            MsgBox("eksik bilgi")
        Else
            Con.Open()
            Dim cmd As New SqlCommand("update DoktorTbl set DoktorAdı='" & DokAdıTb.Text&"',Dokuzman ='"&DokuzmanTb.Text&"',Dokcinsiyet ='"&DokcinsiyetCb.selecteditem.ToString &"',Dokşifre='"&Dokşifre.Text&"'Dokuzman='"&DokuzmanTb.Text&"' where Dokid="&DokidTb.Text&"", Con)
            cmd.ExecuteNonQuery()
            MsgBox("Doktor başarıyla güncellendi")
            Con.Close()
            populate()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Hasta = New HastaForm
        Hasta.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Resepsiyon = New Resepsiyon
        Resepsiyon.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim tedavi = New TedaviForm
        tedavi.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Application.Exit()
    End Sub
End Class
Imports System.Data.SqlClient
Public Class Resepsiyon
    Dim Con As New SqlConnection("Data Source=DESKTOP-EUFH0D7;Initial Catalog=HastaneDB;Integrated Security=True")
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Con.Open()
        Dim query As String
        query = "insert into ResepsiyonTbl values(" & ResepidTb.Text & "," & ResepAdıTb.Text & "," & ResepşifreTb.Text & "," & ReseptelTb.Text & "," & ResepadresTb.Text & ")"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Resepsiyon Başarılı ekledi")
        Con.Close()
        populate()
    End Sub
    Public Sub populate()
        Con.Open()
        Dim sql = "select * from ResepsiyonTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ResepsiyonDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Resepsiyon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ResepidTb.Text = "" Then
            MsgBox("Resepsiyon id girin")
        Else
            Con.Open()
            Dim query As String
            query = "delete from ResepsiyonTbl where Resepid = " & ResepidTb.Text&""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("Resepsiyon başarıyla silindi")
            populate()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If ResepidTb.Text = "" Or ResepAdıTb.Text = "" Or ResepşifreTb.Text = "" Or ReseptelTb.Text = "" Or ResepadresTb.Text Then
            MsgBox("eksik bilgi")
        Else
            Con.Open()
            Dim cmd As New SqlCommand("update ResepsiyonTbl set ResepAdı='" & ResepAdıTb.Text&"',Şifre ='"&ResepşifreTb.Text&"',Telefon ='"&ReseptelTb.Text&"',Adres='"&ResepadresTb.Text&"'where Resepid="&ResepidTb.Text&"", Con)
            cmd.ExecuteNonQuery()
            MsgBox("Resepsiyon başarıyla güncellendi")
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
        Dim Doktor = New DoktorForm
        Doktor.Show()
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
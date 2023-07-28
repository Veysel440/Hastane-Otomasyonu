Imports System.Data.SqlClient
Public Class TedaviForm
    Dim Con As New SqlConnection("Data Source=DESKTOP-EUFH0D7;Initial Catalog=HastaneDB;Integrated Security=True")
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Con.Open()
        Dim query As String
        query = "insert into TedaviTbl values(" & TedidTb.Text & "," & TedtanımTb.Text & "," & TedfiyatTb.Text & ")"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Tedaviyi Başarıyla ekledi")
        Con.Close()
        populate()
    End Sub
    Public Sub populate()
        Con.Open()
        Dim sql = "select * from TedaviTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        TedDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub TedaviForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TedidTb.Text = "" Then
            MsgBox("Tedavi id girin")
        Else
            Con.Open()
            Dim query As String
            query = "delete from TedaviTbl where Tedid = " & TedidTb.Text&""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("Tedavi başarıyla silindi")
            populate()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TedidTb.Text = "" Or TedtanımTb.Text = "" Or TedfiyatTb.Text = "" Then
            MsgBox("eksik bilgi")
        Else
            Con.Open()
            Dim cmd As New SqlCommand("update TedaviTbl set Tedtanımı=" & TedtanımTb.Text&",Tedfiyat ="&TedfiyatTb.Text&",where Dokid="&TedidTb.Text&"", Con)
            cmd.ExecuteNonQuery()
            MsgBox("Tedavi başarıyla güncellendi")
            Con.Close()
            populate()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Doktor = New DoktorForm
        Doktor.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Resepsiyon = New Resepsiyon
        Resepsiyon.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Hasta = New HastaForm
        Hasta.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Application.Exit()
    End Sub
End Class
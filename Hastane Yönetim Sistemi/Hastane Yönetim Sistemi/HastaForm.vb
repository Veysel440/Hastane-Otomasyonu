Imports System.Data.SqlClient
Public Class HastaForm
    Dim Con As New SqlConnection("Data Source=DESKTOP-EUFH0D7;Initial Catalog=HastaneDB;Integrated Security=True")
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Con.Open()
        Dim query As String
        query = "insert into HasTbl values(" & HasIDTb.Text & "," & HasAdıTb.Text & "," & HasYaşTb.Text & "," & HasCinsiyetCb.SelectedItem.ToString & "," & HasKanCb.SelectedItem.ToString & "," & HasBüyükTb.Text & ",)"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Hasta Başarılı ekledi")
        Con.Close()
        populate()
    End Sub
    Public Sub populate()
        Con.Open()
        Dim sql = "select * from HastaTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        HastaDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub HastaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If HasIDTb.Text = "" Then
            MsgBox("Hasta id girin")
        Else
            Con.Open()
            Dim query As String
            query = "delete from HastaTbl where HasID = " & HasIDTb.Text&""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("Hasta başarıyla silindi")
            populate()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If HasIDTb.Text = "" Or HasAdıTb.Text = "" Or HasYaşTb.Text = "" Or HasBüyükTb.Text = "" Then
            MsgBox("eksik bilgi")
        Else
            Con.Open()
            Dim cmd As New SqlCommand("update HastaTbl set HastaAdı='" & HasAdıTb.Text&"',HastaYaş ='"&HASYaşTb.Text&"',HasCinsiyet ='"&HASCinsiyetCb.selecteditem.ToString &"',"&HASKanCb.selecteditem.ToString &"'HasBüyük='"&HASBüyük.Text&" where HasID="&HASIDTb.Text&"", Con)
            cmd.ExecuteNonQuery()
            MsgBox("Hasta başarıyla güncellendi")
            Con.Close()
            populate()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Application.Exit()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Doktor = New DoktorForm
        Doktor.Show()
        Me.Hide()
    End Sub
End Class
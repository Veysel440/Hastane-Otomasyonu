Imports System.Data.SqlClient
Public Class Form1
    Dim Con As New SqlConnection("Data Source=DESKTOP-EUFH0D7;Initial Catalog=HastaneDB;Integrated Security=True")
    Dim cmd As SqlCommand

    Private Sub Logresepsiyon()
        If KullanıcıTb.Text = "" Then
            MsgBox("Resepsiyon listesini gir")
        ElseIf ŞifreTb.Text = "" Then
            MsgBox("şifreyi giriniz")
        Else
            Con.Open()
            Dim query = " select * from ResepsiyonTbl where Resepadı='" & KullanıcıTb.Text& "' and Şifre='"&ŞifreTb.Text& "'"
            cmd = New SqlCommand(query, Con)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("hatalı kullanıcı adı ve şifre ")
            Else
                Dim Hasta = New HastaForm
                Hasta.Show()
                Me.Hide()
            End If
            Con.Close()
        End If
    End Sub
    Private Sub LogDoktor()
        If KullanıcıTb.Text = "" Then
            MsgBox("Doktor listesini gir")
        ElseIf ŞifreTb.Text = "" Then
            MsgBox("şifreyi giriniz")
        Else
            Con.Open()
            Dim query = " select * from DoktorTbl where Dokadı='" & KullanıcıTb.Text& "' and Şifre='"&ŞifreTb.Text& "'"
            cmd = New SqlCommand(query, Con)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("hatalı Doktor adı ve şifre ")
            Else
                Dim Teşhis = New TeşhisForm
                Teşhis.Show()
                Me.Hide()
            End If
            Con.Close()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RolCb.SelectedItem.ToString() = "Resepsiyon" Then
            logResepsiyon()
        ElseIf RolCb.SelectedItem.ToString() = "Doktor" Then
            logDoktor()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class

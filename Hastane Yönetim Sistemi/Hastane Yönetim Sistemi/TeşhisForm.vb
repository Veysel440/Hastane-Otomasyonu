Imports System.Data.SqlClient
Public Class TeşhisForm
    Dim Con As New SqlConnection("Data Source=DESKTOP-EUFH0D7;Initial Catalog=HastaneDB;Integrated Security=True")
    Private Sub FillHastaCombo()
        Con.Open()
        Dim cmd As New SqlCommand("select * from HastaTbl", Con)
        Dim adapter As SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        HasIdCb.DataSource = Tbl
        HasIdCb.DisplayMember = "HasId"
        HasIdCb.ValueMember = "HasId"
        Con.Close()
    End Sub
    Private Sub FilltedaviCombo()
        Con.Open()
        Dim cmd As New SqlCommand("select * from TedaviTbl", Con)
        Dim adapter As SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        TedaviCb.DataSource = Tbl
        TedaviCb.DisplayMember = "Tedavi"
        TedaviCb.ValueMember = "Tedavi"
        Con.Close()
    End Sub
    Dim Ücret As Integer
    Dim Tedavi As String

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Ücret = 0
        If ÜcretTb.Text = "Ücret" Then
            Ücret = 500
            Tedavi = "Hiç"
        Else
            Ücret = 500 + Convert.ToInt32(ÜcretTb.Text)
            Tedavi = TedaviCb.SelectedValue.ToString
        End If
        Con.Open()
        Dim query As String
        query = "insert into TeşhişTbl values(" & TeşTb.Text & "," & HasAdıTb.Text & "," & İlaçTb.Text & "," & HasIdCb.SelectedValue.ToString & "," & Tedavi & "" & SempTb.Text & "," & Ücret & ")"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Teşhiş Başarılı ekledi")
        Con.Close()
        populate()
    End Sub
    Public Sub populate()
        Con.Open()
        Dim sql = "select * from TeşhişTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        TeşhisDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub TeşhisForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillHastaCombo()
        FilltedaviCombo()
        populate()
    End Sub

    Private Sub HasIdCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles HasIdCb.SelectionChangeCommitted
        Con.Open()
        Dim query = "select * from HastaTbl  where HasID=" & HasIdCb.SelectedValue.ToString() & ""
        Dim cmd As New SqlCommand(query, Con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader
        While reader.Read
            HasAdıTb.Text = reader(1)
        End While
        Con.Close()
    End Sub

    Private Sub TedaviCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles TedaviCb.SelectionChangeCommitted
        Con.Open()
        Dim query = "select * from TedaviTbl  where Tedavi=" & TedaviCb.SelectedValue.ToString() & ""
        Dim cmd As New SqlCommand(query, Con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader
        While reader.Read
            ÜcretTb.Text = reader(2)
        End While
        Con.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TeşhişID.Text = "" Then
            MsgBox("Teşhis id girin")
        Else
            Con.Open()
            Dim query As String
            query = "delete from TeşhisTbl where Teşid = " & TeşhişID.Text&""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("Teşhis başarıyla silindi")
            populate()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        
        If TeşhişID.Text = "" Or SempTb.Text = "" Or İlaçTb.Text = "" Or TeşTb.Text = "" Then
            MsgBox("eksik bilgi")
        Else
            Con.Open()
            Dim cmd As New SqlCommand("update TeşhisTbl set HasID='" & HasIdCb.SelectedValue.ToString() & "',HasAdı ='"&HASAdıTb.Text&"',Semptomlar ='",& SemptomlarTb.Text & "',İlaçlar ='",& İlaçlarTb.Text&"',Teşhis='"&TeşhisTb.Text&"',Tedavi='" & TedaviIdCb.SelectedValue.ToString() &"',Ücret="& ücret &" "where Teşid="&TeşidTb.Text&"", Con)
            cmd.ExecuteNonQuery()
            MsgBox("Teşhis başarıyla güncellendi")
          Con.Close()
        End If
    End Sub
End Class
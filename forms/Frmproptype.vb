Imports System.Data.SqlClient
Imports System.Data

Public Class Frmproptype
    Dim sett As New My.MySettings
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection
    Dim dt As New DataTable
    Dim dr, drcmd As SqlDataReader
    Dim da As New SqlDataAdapter

    Private Sub Frmproptype_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection(sett.Database1ConnectionString1)
        con.Open()



        'filldata()
        'con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True")

    End Sub

    Private Sub Btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnnew.Click
        Try
            If Btnnew.Text = "New" Then
                cmd.Connection = con
                'con.Open()
                cmd = New SqlCommand("select MAX(prop_type_id) from prop_type", con)
                If cmd.ExecuteScalar.Equals(DBNull.Value) Then
                    Tbproptypeid.Text = 1
                Else
                    Tbproptypeid.Text = cmd.ExecuteScalar + 1
                End If
                'con.Close()
                disable()
                Tbproptype.Select()
                Btnnew.Enabled = True
                Btnnew.Text = "save"
            ElseIf Check() Then
                cmd = New SqlCommand("INSERT INTO prop_type (prop_type_id, prop_type) VALUES(@prop_type_id,@prop_type)", con)
                cmd.Parameters.AddWithValue("@prop_type_id", Integer.Parse(Tbproptypeid.Text))
                cmd.Parameters.AddWithValue("@prop_type", (Tbproptype.Text))
                'con.Open()
                cmd.ExecuteNonQuery()
                MsgBox("record inserted...", , "prop type master")
                'con.Close()
                clear()
                Enable()
                Btnnew.Text = "New"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub clear()
        Tbproptypeid.Clear()
        Tbproptype.Clear()
    End Sub
    Public Sub disable()
        Btncancel.Visible = True
        Btnexit.Visible = False
        Btnupdate.Enabled = False
        Btndelete.Enabled = False
        Btnnew.Enabled = False
    End Sub
    Public Sub enable()
        Btncancel.Visible = True
        Btnexit.Visible = True
        Btnupdate.Enabled = False
        Btndelete.Enabled = False
        Btnnew.Enabled = True

    End Sub
    Function check() As Boolean
        If Tbproptypeid.TextLength > 0 And Tbproptype.TextLength > 0 Then
            Return True
        Else
            MsgBox("insert all fields", MsgBoxStyle.Information, "fill field")
            Return False

        End If
    End Function
    Sub filldata()

        Dim cmd As New SqlCommand
        'con.Open()
        cmd.CommandText = "select * from prop_type"
        cmd.Connection = con
        Dim dr As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(dr)
        DGVproptype.DataSource = dt
        DGVproptype.DataSource = dt

    End Sub

    Private Sub Btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnexit.Click
        Me.Close()

    End Sub

    Private Sub Btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncancel.Click
        clear()
        enable()
        Btnnew.Text = "New"

    End Sub

    Private Sub Btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndelete.Click
        Try
            Dim res As Integer = MsgBox("do you want to delete this record?", MsgBoxStyle.YesNo, "Record delete")
            If res = MsgBoxResult.Yes Then
                cmd = New SqlCommand("DELETE FROM prop_type WHERE(prop_type_id = @prop_type_id", con)
                cmd.Parameters.AddWithValue("@prop_type_id", Integer.Parse(Tbproptypeid.Text))
                'con.Open()
                Try
                    cmd.ExecuteNonQuery()

                Catch ex As Exception
                    MsgBox("you can not delete this record")

                End Try
                'con.close()
                enable()
                clear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnupdate.Click
        Try
            Dim res As Integer = MsgBox("do you want to update this record?", MsgBoxStyle.YesNo, "Record updtated")
            If res = MsgBoxResult.Yes And check() Then
                cmd = New SqlCommand("UPDATE prop_type SET prop_type_id = @prop_type_id, prop_type = @prop_type WHERE (prop_type_id = @prop_type_id)", con)
                cmd.Parameters.AddWithValue("@prop_type_id", Integer.Parse(Tbproptypeid.Text))
                cmd.Parameters.AddWithValue("@prop_type", (Tbproptypeid.Text))
                'con.open()
                cmd.ExecuteNonQuery()
                MsgBox("record updated successfully", "prop_type")
                'con.close()
                clear()
                enable()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
       


    End Sub

    Private Sub Btndisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndisplay.Click
        filldata()

    End Sub

    Private Sub DGVproptype_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVproptype.CellContentClick
        Btnnew.Enabled = False
        Btndelete.Enabled = True
        Btnupdate.Enabled = True
        Tbproptypeid.ReadOnly = True
        Tbproptype.ReadOnly = True

    End Sub

    Private Sub DGVproptype_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVproptype.SelectionChanged
        Dim r As New DataGridViewRow
        If Not r Is Nothing Then
            Tbproptypeid.Text = r.Cells(0).Value
            Tbproptype.Text = r.Cells(1).Value
            Btnnew.Enabled = False
            Btnupdate.Enabled = True
            Btndelete.Enabled = True
            Btncancel.Enabled = True
            Btncancel.Enabled = True
            Btnexit.Enabled = True

        End If
    End Sub
End Class
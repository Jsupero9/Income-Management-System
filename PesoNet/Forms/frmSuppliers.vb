
Imports MySql.Data.MySqlClient
Public Class frmSuppliers
    
    Public Structure MyRecord
        Dim RecNo As Long
        Public ID As Long
        Public Title As String
    End Structure

    Dim TableName As String
    Dim Arr() As MyRecord
    Dim SelID As Long

    Private Sub DisplayRecord(ID As Long)
        Dim cmd As New MySqlCommand, dt As New DataTable, sql As String
        sql = "Select Supplier.* from Supplier where Supplier.ID = " & ID
        If GotData(sql, cmd, dt) Then
            txtName.Text = dt.Rows(0)("Name")
            txtContactPerson.Text = dt.Rows(0)("ContactPerson")
            txtAdrs.Text = dt.Rows(0)("Adrs")
            txtContactNo.Text = dt.Rows(0)("ContactNumbers")
        End If
        DisposeObject(cmd, dt)
    End Sub

    Private Sub LoadList()
        Try
            Dim cmd As New MySqlCommand, dt As New DataTable, sql As String
            lv.VirtualListSize = 0
            Clear()
            sql = "Select Supplier.ID, Supplier.Name from Supplier where Supplier.Name like @Name order by Supplier.Name ASC"
            cmd.Parameters.Add("@Name", MySqlDbType.String).Value = IIf(chk.Checked, "%", "") & txtF.Text.Replace("*", "%").ToString & "%"

            If GotData(sql, cmd, dt) Then
                Dim I As Integer
                For I = 0 To dt.Rows.Count - 1
                    ReDim Preserve Arr(I)
                    Arr(I).RecNo = I + 1
                    Arr(I).ID = dt.Rows(I)("ID")
                    Arr(I).Title = dt.Rows(I)("Name")
                Next I

            End If

            lv.VirtualListSize = dt.Rows.Count
            lv.VirtualMode = True
            DisposeObject(cmd, dt)

        Catch
        End Try
        btnDel.Enabled = lv.Items.Count > 0
        btnEdit.Enabled = lv.Items.Count > 0


    End Sub

    Private Sub lv_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lv.ItemSelectionChanged
        SelID = e.Item.Tag
        DisplayRecord(SelID)
    End Sub

    Private Sub lv_RetrieveVirtualItem(sender As Object, e As RetrieveVirtualItemEventArgs) Handles lv.RetrieveVirtualItem
        lv.Items.Clear()
        Dim lvi As New ListViewItem(Arr(e.ItemIndex).RecNo.ToString("00"))
        Dim lvsName As New ListViewItem.ListViewSubItem
        lvi.Tag = Arr(e.ItemIndex).ID
        lvsName.Text = Arr(e.ItemIndex).Title
        lvi.SubItems.Add(lvsName)
        e.Item = lvi

    End Sub

    Private Sub txtF_Click(sender As Object, e As EventArgs) Handles txtF.Click
        txtF.SelectAll()
    End Sub

    Private Sub txtF_GotFocus(sender As Object, e As EventArgs) Handles txtF.GotFocus
        txtF.SelectAll()
    End Sub

    Private Sub txtF_TextChanged(sender As Object, e As EventArgs) Handles txtF.TextChanged
        lv.VirtualListSize = 0
        LoadList()
    End Sub

    Private Sub chk_CheckedChanged(sender As Object, e As EventArgs) Handles chk.CheckedChanged
        lv.VirtualListSize = 0
        LoadList()
    End Sub

    Private Sub frmRefrence_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtF.Focus()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        frmSupplierEdit.LoadRecord(SelID)
        frmSupplierEdit.ShowDialog()
        LoadList()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmSupplierEdit.AddRecord()
        frmSupplierEdit.ShowDialog()
        LoadList()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click

        If IsLocked(SelID) Then
            MsgBox("Sorry, Supplier record is locked due to other table using in it", MsgBoxStyle.Exclamation, "Unable to remove")
            Exit Sub
        End If

        If MsgBox("Ready to selected record, proceed?", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Confirmation") = MsgBoxResult.No Then Exit Sub
        Dim sql As String, IsDel As Boolean
        sql = " Delete From Supplier Where ID = " & SelID
        IsDel = IsMySQL(sql)
        If IsDel Then LoadList()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Clear()
        txtName.Clear()
        txtContactPerson.Clear()
        txtAdrs.Clear()
        txtContactNo.Clear()
    End Sub

    Private Function IsLocked(ID As Long) As Boolean
        Dim cmd As New MySqlCommand, dt As New DataTable, sql As String, retVal As Boolean
        sql = "SELECT recieving.ID FROM supplier INNER JOIN recieving ON (supplier.ID = recieving.SupplierID) WHERE recieving.ID = " & ID
        retVal = GotData(sql, cmd, dt)
        DisposeObject(cmd, dt)
        Return retVal
    End Function


End Class

Imports MySql.Data.MySqlClient
Public Class frmTitles
    Public Enum TypeOfReferenceTable
        totUnit = 1
        totBrand = 2
        totReceipt = 3
    End Enum

    Public Structure MyRecord
        Dim RecNo As Long
        Public ID As Long
        Public Title As String
    End Structure

    Dim TableName As String
    Dim Arr() As MyRecord
    Dim SelID As Long
    Dim SelectedTable As TypeOfReferenceTable

    Public Sub Initiate(tot As TypeOfReferenceTable)

        If tot = TypeOfReferenceTable.totUnit Then TableName = "Unit "
        If tot = TypeOfReferenceTable.totBrand Then TableName = "Brand "
        If tot = TypeOfReferenceTable.totReceipt Then TableName = "Receipt "

        lv.Columns(1).Text = TableName & " Title"
        Me.Text = "Reference: " & TableName
        SelectedTable = tot
    End Sub

    Private Sub LoadList()
        Try
            Dim cmd As New MySqlCommand, dt As New DataTable, sql As String
            lv.VirtualListSize = 0
           
            sql = "Select " & TableName.Trim & ".* from " & TableName.Trim & " where " & TableName.Trim & ".Title like @Title order by " & TableName.Trim & ".Title ASC"
            cmd.Parameters.Add("@Title", MySqlDbType.String).Value = IIf(chk.Checked, "%", "") & txtF.Text.Replace("*", "%").ToString & "%"

            If GotData(sql, cmd, dt) Then
                Dim I As Integer
                For I = 0 To dt.Rows.Count - 1
                    ReDim Preserve Arr(I)
                    Arr(I).RecNo = I + 1
                    Arr(I).ID = dt.Rows(I)("ID")
                    Arr(I).Title = dt.Rows(I)("Title")
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
    End Sub

    Private Sub lv_RetrieveVirtualItem(sender As Object, e As RetrieveVirtualItemEventArgs) Handles lv.RetrieveVirtualItem
        lv.Items.Clear()
        Dim lvi As New ListViewItem(Arr(e.ItemIndex).RecNo.ToString("00"))
        Dim lvsClient As New ListViewItem.ListViewSubItem
        lvi.Tag = Arr(e.ItemIndex).ID
        lvsClient.Text = Arr(e.ItemIndex).Title
        lvi.SubItems.Add(lvsClient)
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
        frmTitlesEdit.LoadRecord(SelID, SelectedTable)
        frmTitlesEdit.ShowDialog()
        LoadList()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmTitlesEdit.AddRecord(SelectedTable)
        frmTitlesEdit.ShowDialog()
        LoadList()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click

        If IsLocked(SelID) Then
            MsgBox("Sorry, " & TableName.Trim & " record is locked due to other table using in it", MsgBoxStyle.Exclamation, "Unable to remove")
            Exit Sub
        End If

        If MsgBox("Ready to selected record, proceed?", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Confirmation") = MsgBoxResult.No Then Exit Sub
        Dim sql As String, IsDel As Boolean
        sql = " Delete From " & TableName & " Where ID = " & SelID
        IsDel = IsMySQL(sql)
        If IsDel Then LoadList()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Function IsLocked(ID As Long) As Boolean
        Dim cmd As New MySqlCommand, dt As New DataTable, sql As String, retVal As Boolean
        sql = "SELECT  itemrecieved.BrandID FROM   itemrecieved   INNER JOIN brand ON (itemrecieved.BrandID = brand.ID) WHERE   brand.ID = " & ID
        If SelectedTable = TypeOfReferenceTable.totUnit Then
            sql = "SELECT  itemrecieved.UnitID FROM itemrecieved INNER JOIN Unit ON (itemrecieved.UnitID = Unit.ID) WHERE  Unit.ID = " & ID
        End If
        retVal = GotData(sql, cmd, dt)
        DisposeObject(cmd, dt)
        Return retVal
    End Function

End Class
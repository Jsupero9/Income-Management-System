 

Imports MySql.Data.MySqlClient
Public Class frmSearchSupplier

    Public Structure MyRecord
        Dim RecNo As Long
        Public ID As Long
        Public Title As String
    End Structure

    Dim TableName As String
    Dim Arr() As MyRecord
    Dim SelID As Long

    Private Sub LoadList()
        Try
            Dim cmd As New MySqlCommand, dt As New DataTable, sql As String
            lv.VirtualListSize = 0

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
        btnOK.Enabled = lv.Items.Count > 0
    End Sub

    Private Sub lv_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lv.ItemSelectionChanged
        SelID = e.Item.Tag
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
 
    Private Sub chk_CheckedChanged(sender As Object, e As EventArgs) Handles chk.CheckedChanged
        LoadList()
    End Sub

    Private Sub frmRefrence_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        txtF.Focus()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmSupplierEdit.AddRecord(True)
        frmSupplierEdit.ShowDialog()
        If SearchID > 0 Then Me.Close()
    End Sub
 
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
 
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        SearchID = SelID
        Me.Close()
    End Sub

    Private Sub frmSearchSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SearchID = 0
    End Sub

    Private Sub txtF_TextChanged(sender As Object, e As EventArgs) Handles txtF.TextChanged
        LoadList()
    End Sub
End Class
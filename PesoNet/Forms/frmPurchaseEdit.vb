

Imports MySql.Data.MySqlClient

Public Class frmPurchaseEdit

    Dim RecordID As Long, SelID As Long
 
    Private Sub GetSupplier()
        frmSearchSupplier.ShowDialog()
        DisplaySupplier(SearchID)
    End Sub

    Private Sub DisplaySupplier(ID As Long)
        If SearchID = 0 Then Exit Sub
        Dim cmd As New MySqlCommand, dt As New DataTable, sql As String
        sql = "Select Supplier.* from Supplier where Supplier.ID = " & ID
        ClearSupplier()
        If GotData(sql, cmd, dt) Then
            txtName.Text = dt.Rows(0)("Name")
            txtName.Tag = dt.Rows(0)("ID")
            txtContactPerson.Text = dt.Rows(0)("ContactPerson")
            txtAdrs.Text = dt.Rows(0)("Adrs")
            txtNumbers.Text = dt.Rows(0)("ContactNumbers")
        End If
        DisposeObject(cmd, dt)
    End Sub

    Private Sub ClearSupplier()
        txtName.Clear()
        txtName.Tag = 0
        txtContactPerson.Clear()
        txtAdrs.Clear()
        txtNumbers.Clear()
        SelID = 0
    End Sub

    Private Sub frmPurchaseEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String

        sql = "Select Receipt.* from Receipt order by Receipt.Title ASC"
        PapulateComboBox(cboReceipt, sql)

        sql = "SELECT DISTINCT recieving.ReceivedBy FROM  recieving order by  recieving.ReceivedBy ASC"
        PapulateComboBox(cboReceiver, sql)
        CheckButtons()
    End Sub


    Public Sub AddRecord()
        RecordID = 0
        ClearSupplier()
    End Sub

    Public Sub LoadRecord(ID As Long)
        RecordID = ID
        ClearSupplier()
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        GetSupplier()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        If Not RecordIsSaved() Then Exit Sub

    End Sub


    Private Function RecordIsSaved() As Boolean
        Dim cmd As New MySqlCommand, IsSaved As Boolean
        Dim sqlSet As String, sql As String

        sqlSet = " SupplierID = @SupplierID, Petsa = @Petsa, FormType = @FormType, FormSerial = @FormSerial, Remarks = @Remarks, ReceivedBy = @ReceivedBy "
        sql = "INSERT INTO recieving SET " & sqlSet

        If RecordID > 0 Then sql = "UPDATE recieving SET " & sqlSet & " WHERE id = " & RecordID

        If Not IsNumeric(txtSerial.Text) Then txtSerial.Text = "0"
        cmd.Parameters.Add("@SupplierID", MySqlDbType.Int64).Value = btnSupplier.Tag
        cmd.Parameters.Add("@Petsa", MySqlDbType.Date).Value = dtDate.Value
        cmd.Parameters.Add("@FormType", MySqlDbType.Text).Value = cboReceipt.Text.ToString
        cmd.Parameters.Add("@FormSerial", MySqlDbType.Int64).Value = txtSerial.Text.ToString
        cmd.Parameters.Add("@Remarks", MySqlDbType.Int64).Value = txtNote.Text.ToString
        cmd.Parameters.Add("@ReceivedBy", MySqlDbType.Int64).Value = cboReceiver.Text.ToString

        IsSaved = IsMySQL(sql)

        If IsSaved Then
            If RecordID = 0 Then RecordID = NewID()
            SaveItems(RecordID)
        Else
            MsgBox("Failed to saved receiving entry", vbExclamation, "Information")
        End If
        Return IsSaved
    End Function


    Private Function NewID() As Long
        Dim cmd As New MySqlCommand, MyID As Long
        Dim sqlSet As String, sql As String, dt As DataTable

        sqlSet = " SupplierID = @SupplierID AND Petsa = @Petsa  AND FormType = @FormType AND FormSerial = @FormSerial AND ReceivedBy = @ReceivedBy "
        sql = "SELECT ID FROM recieving WHERE " & sqlSet & " ORDER BY ID DESC LIMIT 1"

        cmd.Parameters.Add("@SupplierID", MySqlDbType.Int64).Value = btnSupplier.Tag
        cmd.Parameters.Add("@Petsa", MySqlDbType.Date).Value = dtDate.Value
        cmd.Parameters.Add("@FormType", MySqlDbType.Text).Value = cboReceipt.Text.ToString
        cmd.Parameters.Add("@FormSerial", MySqlDbType.Int64).Value = txtSerial.Text.ToString
        cmd.Parameters.Add("@ReceivedBy", MySqlDbType.Int64).Value = cboReceiver.Text.ToString

        If GotData(sql, cmd, dt) Then
            MyID = dt.Rows(0)("ID")
        End If
        Return MyID
    End Function

    Private Sub SaveItems(MasterID As Long)
        Dim I As Integer, ItemID As Long
        Dim cmd As New MySqlCommand
        Dim sqlSet As String, sql As String
        Call IsMySQL("delete * from itemrecieved where MasterID = " & MasterID)
        For I = 1 To lv.Items.Count

            sqlSet = " MasterID = @MasterID, UnitID = @UnitID, BrandID = @BrandID, Model = @Model, Capacity = @Capacity, Specs = @Specs "
            If ItemID > 0 Then sqlSet = sqlSet & ", ID = " & ItemID

            sql = "INSERT INTO recieving SET " & sqlSet

            cmd.Parameters.Add("@MasterID", MySqlDbType.Int64).Value = MasterID
            cmd.Parameters.Add("@UnitID", MySqlDbType.Date).Value = dtDate.Value
            cmd.Parameters.Add("@BrandID", MySqlDbType.Text).Value = cboReceipt.Text.ToString
            cmd.Parameters.Add("@Model", MySqlDbType.Int64).Value = txtSerial.Text.ToString
            cmd.Parameters.Add("@Capacity", MySqlDbType.Int64).Value = txtNote.Text.ToString
            cmd.Parameters.Add("@Specs", MySqlDbType.Int64).Value = cboReceiver.Text.ToString

            IsMySQL(sql)
        Next
    End Sub

    Private Sub btnAI_Click(sender As Object, e As EventArgs) Handles btnAI.Click
        frmItemEdit.AddRecord()
        frmItemEdit.ShowDialog()
        If Not ItemEdit.IsActionSave Then Exit Sub

        Dim li As ListViewItem
        li = lv.Items.Add((lv.Items.Count + 1).ToString())
        li.Tag = ItemEdit.ID

        li.SubItems.Add(ItemEdit.Unit).Tag = ItemEdit.UnitID
        li.SubItems.Add(ItemEdit.Brand).Tag = ItemEdit.BrandID
        li.SubItems.Add(ItemEdit.Model)
        li.SubItems.Add(ItemEdit.Capacity)
        li.SubItems.Add(ItemEdit.Specs)
        CheckButtons()
    End Sub

    Private Sub btnEI_Click(sender As Object, e As EventArgs) Handles btnEI.Click
        If lv.Items.Count = 0 Then Exit Sub
        With ItemEdit
            .ID = lv.SelectedItems(0).Tag
            .Unit = lv.SelectedItems(0).SubItems(1).Text
            .UnitID = lv.SelectedItems(0).SubItems(1).Tag

            .Brand = lv.SelectedItems(0).SubItems(2).Text
            .BrandID = lv.SelectedItems(0).SubItems(2).Tag

            .Model = lv.SelectedItems(0).SubItems(3).Text
            .Capacity = lv.SelectedItems(0).SubItems(4).Text
            .Specs = lv.SelectedItems(0).SubItems(5).Text
        End With

            frmItemEdit.LoadItems(SelID)
            frmItemEdit.ShowDialog()
            If Not ItemEdit.IsActionSave Then Exit Sub

        lv.Items(lv.SelectedItems(0).Index).SubItems(1).Text = ItemEdit.Unit
        lv.Items(lv.SelectedItems(0).Index).SubItems(1).Tag = ItemEdit.UnitID

        lv.Items(lv.SelectedItems(0).Index).SubItems(2).Text = ItemEdit.Brand
        lv.Items(lv.SelectedItems(0).Index).SubItems(2).Tag = ItemEdit.BrandID

        lv.Items(lv.SelectedItems(0).Index).SubItems(3).Text = ItemEdit.Model
        lv.Items(lv.SelectedItems(0).Index).SubItems(4).Text = ItemEdit.Capacity
        lv.Items(lv.SelectedItems(0).Index).SubItems(5).Text = ItemEdit.Specs

        CheckButtons()
    End Sub

    Private Sub lv_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lv.ItemSelectionChanged
        SelID = e.Item.Tag
    End Sub

    Private Sub CheckButtons()
        btnCI.Enabled = lv.Items.Count > 0
        btnEI.Enabled = btnCI.Enabled
        btnDI.Enabled = btnCI.Enabled
    End Sub

    Private Sub btnDI_Click(sender As Object, e As EventArgs) Handles btnDI.Click
        CheckButtons()
    End Sub
End Class
Public Class frmItemEdit

    Dim RecordID As Long

    Private Sub ItemEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String

        sql = "Select `Unit`.* from `Unit` order by `Unit`.Title ASC"
        PapulateComboBox(cboUnit, sql)

        sql = "SELECT Brand.* FROM  Brand order by Brand.Title ASC"
        PapulateComboBox(cboBrand, sql)

        ItemEdit.IsActionSave = False
    End Sub

    Public Sub LoadItems(ItemID As Long)
        If ItemID = 0 Then
            RecordID = 0
            LoadFromVariables()
            Exit Sub
        End If

        RecordID = ItemID
    End Sub

    Private Sub LoadFromVariables()
        txtCap.Text = ItemEdit.Capacity
        txtSpecs.Text = ItemEdit.Specs
        txtModel.Text = ItemEdit.Model
        cboBrand.SelectedValue = ItemEdit.BrandID
        cboUnit.SelectedValue = ItemEdit.UnitID

        cboBrand.Text = ItemEdit.Brand
        cboUnit.Text = ItemEdit.Unit

    End Sub

    Public Sub AddRecord()
        RecordID = 0
        txtCap.Clear()
        txtSpecs.Clear()
        txtModel.Clear()
        cboBrand.SelectedIndex = -1
        cboUnit.SelectedIndex = -1
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        With ItemEdit
            .ID = Me.RecordID
            .Brand = cboBrand.Text
            .BrandID = cboBrand.SelectedValue
            .Capacity = txtCap.Text
            .Model = txtModel.Text
            .Specs = txtSpecs.Text
            .Unit = cboUnit.Text
            .UnitID = cboUnit.SelectedValue
            .IsActionSave = True
        End With
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class
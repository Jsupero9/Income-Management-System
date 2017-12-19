
Imports MySql.Data.MySqlClient

Public Class frmPurchases

    'Private Sub btnSupplier_Click(sender As Object, e As EventArgs)
    '    frmSearchSupplier.ShowDialog()
    '    DisplaySupplier(SearchID)
    'End Sub

    Private Sub GetSupplier()
        frmSearchSupplier.ShowDialog()
        DisplaySupplier(SearchID)
    End Sub

    Private Sub DisplaySupplier(ID As Long)
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
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmPurchaseEdit.AddRecord()
        frmPurchaseEdit.ShowDialog()
    End Sub
End Class
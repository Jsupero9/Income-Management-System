
Imports MySql.Data.MySqlClient

Public Class frmSupplierEdit

    Dim RecordID As Long, _WithSearch As Boolean

    Public Sub LoadRecord(ID As Long)
        Dim cmd As New MySqlCommand, dt As New DataTable, sql As String

        RecordID = ID
        sql = "Select Supplier.* from Supplier where Supplier.ID = " & ID
        If GotData(sql, cmd, dt) Then
            txtName.Text = dt.Rows(0)("Name")
            txtContactPerson.Text = dt.Rows(0)("ContactPerson")
            txtAdrs.Text = dt.Rows(0)("Adrs")
            txtContactNo.Text = dt.Rows(0)("ContactNumbers")
        End If
        DisposeObject(cmd, dt)
    End Sub

    Public Sub AddRecord(Optional WithSearch As Boolean = False)
        RecordID = 0
        txtName.Clear()
        txtContactPerson.Clear()
        txtAdrs.Clear()
        txtContactNo.Clear()
        _WithSearch = WithSearch
    End Sub

    Private Sub SaveRecord()
        Dim cmd As New MySqlCommand, sql As String, IsSave As Boolean
        sql = " INSERT INTO Supplier SET Name = @Name, ContactPerson = @ContactPerson, Adrs = @Adrs, ContactNumbers = @ContactNumbers "
        If RecordID > 0 Then sql = " UPDATE Supplier SET Name = @Name, ContactPerson = @ContactPerson, Adrs = @Adrs, ContactNumbers = @ContactNumbers WHERE ID = " & RecordID

        cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = txtName.Text.ToString
        cmd.Parameters.Add("@ContactPerson", MySqlDbType.VarChar).Value = txtContactPerson.Text.ToString
        cmd.Parameters.Add("@Adrs", MySqlDbType.VarChar).Value = txtAdrs.Text.ToString
        cmd.Parameters.Add("@ContactNumbers", MySqlDbType.VarChar).Value = txtContactNo.Text.ToString

        IsSave = IsMySQL(sql, cmd)
        cmd.Dispose()
        If IsSave Then
            If _WithSearch Then SearchID = myNewID()
            Me.Close()
        End If

    End Sub

    Private Function myNewID() As Long
        Dim cmd As New MySqlCommand, dt As New DataTable, sql As String, retVaL As Boolean

        sql = " SELECT ID FROM Supplier WHERE Name = @Name AND ContactPerson = @ContactPerson AND Adrs = @Adrs AND ContactNumbers = @ContactNumbers "
        cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = txtName.Text.ToString
        cmd.Parameters.Add("@ContactPerson", MySqlDbType.VarChar).Value = txtContactPerson.Text.ToString
        cmd.Parameters.Add("@Adrs", MySqlDbType.VarChar).Value = txtAdrs.Text.ToString
        cmd.Parameters.Add("@ContactNumbers", MySqlDbType.VarChar).Value = txtContactNo.Text.ToString

        If GotData(sql, cmd, dt) Then
            retVaL = dt.Rows(0)("id")
        End If
        DisposeObject(cmd, dt)
        Return retVaL
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveRecord()
    End Sub

    Private Sub frmReferenceEdit_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
     
End Class
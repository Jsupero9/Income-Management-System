
Imports MySql.Data.MySqlClient

Public Class frmTitlesEdit

    Public Enum TypeOfReferenceTable
        totUnit = 1
        totBrand = 2
        totReceipt = 3

    End Enum

    Dim TableName As String, RecordID As Long

    Public Sub LoadRecord(ID As Long, tot As TypeOfReferenceTable)

        RecordID = ID
        SetTable(tot)
        lbl.Text = TableName & "Title"

        Dim cmd As New MySqlCommand, dt As New DataTable, sql As String

        sql = "Select " & TableName.Trim & ".* from " & TableName.Trim & " where " & TableName.Trim & ".ID =  " & ID
        If GotData(sql, cmd, dt) Then
            txt.Text = dt.Rows(0)("Title")
        End If

        DisposeObject(cmd, dt)

    End Sub

    Public Sub AddRecord(tot As TypeOfReferenceTable)
        RecordID = 0
        SetTable(tot)
        txt.Text = ""
    End Sub

    Private Sub SetTable(tot As TypeOfReferenceTable)
        If tot = TypeOfReferenceTable.totUnit Then TableName = "Unit "
        If tot = TypeOfReferenceTable.totBrand Then TableName = "Brand "
        If tot = TypeOfReferenceTable.totReceipt Then TableName = "Receipt "
    End Sub


    Private Sub SaveRecord()

        Dim cmd As New MySqlCommand, sql As String, IsSave As Boolean
        sql = " INSERT INTO " & TableName & " SET Title  = @Title "
        If RecordID > 0 Then sql = " UPDATE " & TableName & " SET Title  = @Title  WHERE ID = " & RecordID

        cmd.Parameters.Add("@Title", MySqlDbType.VarChar).Value = txt.Text.ToString

        IsSave = IsMySQL(sql, cmd)
        cmd.Dispose()
        If IsSave Then Me.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveRecord()
    End Sub

    Private Sub frmReferenceEdit_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmTitlesEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
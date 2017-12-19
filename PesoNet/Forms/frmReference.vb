Public Class frmRefrence
    Public Enum TypeOfReferenceTable
        totUnit = 1
        totBrand = 2
    End Enum

    Dim TableName As String

    Public Sub Initiate(tot As TypeOfReferenceTable)


        If tot = TypeOfReferenceTable.totUnit Then TableName = "Unit "
        If tot = TypeOfReferenceTable.totBrand Then TableName = "Brand "

        lv.Columns(1).Text = TableName & " Name"
        Me.Text = "Reference: " & TableName

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class
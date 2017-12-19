Public Class frmMain
 
    Private Sub StationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StationToolStripMenuItem.Click
        frmStation.MdiParent = Me
        frmStation.Show()
        frmStation.Focus()
    End Sub

    Private Sub UnitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnitToolStripMenuItem.Click
        Dim f As New frmTitles
        f.Initiate(frmTitles.TypeOfReferenceTable.totUnit)
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub BrandToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrandToolStripMenuItem.Click
        Dim f As New frmTitles
        f.Initiate(frmTitles.TypeOfReferenceTable.totBrand)
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub PurchasingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchasingToolStripMenuItem.Click
        frmPurchases.MdiParent = Me
        frmPurchases.Show()
    End Sub

    Private Sub ConnectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectionToolStripMenuItem.Click
        frmConnection.ShowDialog()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadConnection()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        frmSuppliers.Show()
    End Sub

    Private Sub ReceiptsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceiptsToolStripMenuItem.Click
        Dim f As New frmTitles
        f.Initiate(frmTitles.TypeOfReferenceTable.totReceipt)
        f.MdiParent = Me
        f.Show()
    End Sub
End Class

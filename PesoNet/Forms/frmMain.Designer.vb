<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuMain = New System.Windows.Forms.MenuStrip()
        Me.SecurityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceiptsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchasingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InquiryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuMain
        '
        Me.MenuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SecurityToolStripMenuItem, Me.RecordsToolStripMenuItem, Me.InquiryToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuMain.Location = New System.Drawing.Point(0, 0)
        Me.MenuMain.Name = "MenuMain"
        Me.MenuMain.Size = New System.Drawing.Size(579, 24)
        Me.MenuMain.TabIndex = 1
        Me.MenuMain.Text = "MenuStrip1"
        '
        'SecurityToolStripMenuItem
        '
        Me.SecurityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.HideToolStripMenuItem, Me.AdministrationToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.SecurityToolStripMenuItem.Name = "SecurityToolStripMenuItem"
        Me.SecurityToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SecurityToolStripMenuItem.Text = "&Security"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.LoginToolStripMenuItem.Text = "&Login"
        '
        'HideToolStripMenuItem
        '
        Me.HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        Me.HideToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.HideToolStripMenuItem.Text = "&Hide"
        '
        'AdministrationToolStripMenuItem
        '
        Me.AdministrationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserManagerToolStripMenuItem, Me.ConfigurationsToolStripMenuItem, Me.ConnectionToolStripMenuItem})
        Me.AdministrationToolStripMenuItem.Name = "AdministrationToolStripMenuItem"
        Me.AdministrationToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.AdministrationToolStripMenuItem.Text = "&Administration"
        '
        'UserManagerToolStripMenuItem
        '
        Me.UserManagerToolStripMenuItem.Name = "UserManagerToolStripMenuItem"
        Me.UserManagerToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.UserManagerToolStripMenuItem.Text = "&User Manager"
        '
        'ConfigurationsToolStripMenuItem
        '
        Me.ConfigurationsToolStripMenuItem.Name = "ConfigurationsToolStripMenuItem"
        Me.ConfigurationsToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ConfigurationsToolStripMenuItem.Text = "&Configurations"
        '
        'ConnectionToolStripMenuItem
        '
        Me.ConnectionToolStripMenuItem.Name = "ConnectionToolStripMenuItem"
        Me.ConnectionToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ConnectionToolStripMenuItem.Text = "&Connection"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(150, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'RecordsToolStripMenuItem
        '
        Me.RecordsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReferencesToolStripMenuItem, Me.PurchasingToolStripMenuItem, Me.StationToolStripMenuItem})
        Me.RecordsToolStripMenuItem.Name = "RecordsToolStripMenuItem"
        Me.RecordsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.RecordsToolStripMenuItem.Text = "&Records"
        '
        'ReferencesToolStripMenuItem
        '
        Me.ReferencesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UnitToolStripMenuItem, Me.BrandToolStripMenuItem, Me.ReceiptsToolStripMenuItem, Me.ToolStripMenuItem2, Me.SupplierToolStripMenuItem})
        Me.ReferencesToolStripMenuItem.Name = "ReferencesToolStripMenuItem"
        Me.ReferencesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReferencesToolStripMenuItem.Text = "&References"
        '
        'UnitToolStripMenuItem
        '
        Me.UnitToolStripMenuItem.Name = "UnitToolStripMenuItem"
        Me.UnitToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.UnitToolStripMenuItem.Text = "&Unit"
        '
        'BrandToolStripMenuItem
        '
        Me.BrandToolStripMenuItem.Name = "BrandToolStripMenuItem"
        Me.BrandToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.BrandToolStripMenuItem.Text = "&Brand"
        '
        'ReceiptsToolStripMenuItem
        '
        Me.ReceiptsToolStripMenuItem.Name = "ReceiptsToolStripMenuItem"
        Me.ReceiptsToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ReceiptsToolStripMenuItem.Text = "Receipts"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(115, 6)
        '
        'SupplierToolStripMenuItem
        '
        Me.SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        Me.SupplierToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.SupplierToolStripMenuItem.Text = "&Supplier"
        '
        'PurchasingToolStripMenuItem
        '
        Me.PurchasingToolStripMenuItem.Name = "PurchasingToolStripMenuItem"
        Me.PurchasingToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PurchasingToolStripMenuItem.Text = "&Purchasing"
        '
        'StationToolStripMenuItem
        '
        Me.StationToolStripMenuItem.Name = "StationToolStripMenuItem"
        Me.StationToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StationToolStripMenuItem.Text = "&Station"
        '
        'InquiryToolStripMenuItem
        '
        Me.InquiryToolStripMenuItem.Name = "InquiryToolStripMenuItem"
        Me.InquiryToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.InquiryToolStripMenuItem.Text = "&Inquiry"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "&Reports"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 344)
        Me.Controls.Add(Me.MenuMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuMain
        Me.Name = "frmMain"
        Me.Text = "Peso.Net Monitoring System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuMain.ResumeLayout(False)
        Me.MenuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents SecurityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserManagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigurationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReferencesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InquiryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrandToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchasingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConnectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReceiptsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator

End Class

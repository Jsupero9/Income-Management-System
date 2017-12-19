<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStationEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStationEdit))
        Me.btnDelParts = New System.Windows.Forms.Button()
        Me.btnEditParts = New System.Windows.Forms.Button()
        Me.btnAddParts = New System.Windows.Forms.Button()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'btnDelParts
        '
        Me.btnDelParts.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelParts.Image = CType(resources.GetObject("btnDelParts.Image"), System.Drawing.Image)
        Me.btnDelParts.Location = New System.Drawing.Point(792, 346)
        Me.btnDelParts.Name = "btnDelParts"
        Me.btnDelParts.Size = New System.Drawing.Size(33, 25)
        Me.btnDelParts.TabIndex = 23
        Me.btnDelParts.UseVisualStyleBackColor = True
        '
        'btnEditParts
        '
        Me.btnEditParts.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditParts.Image = CType(resources.GetObject("btnEditParts.Image"), System.Drawing.Image)
        Me.btnEditParts.Location = New System.Drawing.Point(753, 346)
        Me.btnEditParts.Name = "btnEditParts"
        Me.btnEditParts.Size = New System.Drawing.Size(33, 25)
        Me.btnEditParts.TabIndex = 22
        Me.btnEditParts.UseVisualStyleBackColor = True
        '
        'btnAddParts
        '
        Me.btnAddParts.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddParts.Image = CType(resources.GetObject("btnAddParts.Image"), System.Drawing.Image)
        Me.btnAddParts.Location = New System.Drawing.Point(714, 346)
        Me.btnAddParts.Name = "btnAddParts"
        Me.btnAddParts.Size = New System.Drawing.Size(33, 25)
        Me.btnAddParts.TabIndex = 21
        Me.btnAddParts.UseVisualStyleBackColor = True
        '
        'ListView2
        '
        Me.ListView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView2.Cursor = System.Windows.Forms.Cursors.Default
        Me.ListView2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HideSelection = False
        Me.ListView2.HoverSelection = True
        Me.ListView2.Location = New System.Drawing.Point(12, 118)
        Me.ListView2.MultiSelect = False
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Scrollable = False
        Me.ListView2.Size = New System.Drawing.Size(812, 222)
        Me.ListView2.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView2.TabIndex = 20
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = " #"
        Me.ColumnHeader1.Width = 25
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Parts"
        Me.ColumnHeader2.Width = 104
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Brand"
        Me.ColumnHeader3.Width = 105
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Model"
        Me.ColumnHeader4.Width = 113
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Capacity"
        Me.ColumnHeader5.Width = 82
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Specs"
        Me.ColumnHeader6.Width = 363
        '
        'frmStationEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 383)
        Me.Controls.Add(Me.btnDelParts)
        Me.Controls.Add(Me.btnEditParts)
        Me.Controls.Add(Me.btnAddParts)
        Me.Controls.Add(Me.ListView2)
        Me.Name = "frmStationEdit"
        Me.Text = "Edit Station"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDelParts As System.Windows.Forms.Button
    Friend WithEvents btnEditParts As System.Windows.Forms.Button
    Friend WithEvents btnAddParts As System.Windows.Forms.Button
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchaseEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPurchaseEdit))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSupplier = New System.Windows.Forms.Button()
        Me.txtNumbers = New System.Windows.Forms.TextBox()
        Me.txtContactPerson = New System.Windows.Forms.TextBox()
        Me.txtAdrs = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCI = New System.Windows.Forms.Button()
        Me.btnDI = New System.Windows.Forms.Button()
        Me.btnEI = New System.Windows.Forms.Button()
        Me.btnAI = New System.Windows.Forms.Button()
        Me.dtDate = New System.Windows.Forms.DateTimePicker()
        Me.cboReceiver = New System.Windows.Forms.ComboBox()
        Me.cboReceipt = New System.Windows.Forms.ComboBox()
        Me.lv = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSerial = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSupplier)
        Me.GroupBox2.Controls.Add(Me.txtNumbers)
        Me.GroupBox2.Controls.Add(Me.txtContactPerson)
        Me.GroupBox2.Controls.Add(Me.txtAdrs)
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(848, 95)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Supplier"
        '
        'btnSupplier
        '
        Me.btnSupplier.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSupplier.Image = CType(resources.GetObject("btnSupplier.Image"), System.Drawing.Image)
        Me.btnSupplier.Location = New System.Drawing.Point(457, 16)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(33, 25)
        Me.btnSupplier.TabIndex = 50
        Me.btnSupplier.UseVisualStyleBackColor = True
        '
        'txtNumbers
        '
        Me.txtNumbers.Enabled = False
        Me.txtNumbers.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumbers.Location = New System.Drawing.Point(496, 47)
        Me.txtNumbers.Multiline = True
        Me.txtNumbers.Name = "txtNumbers"
        Me.txtNumbers.ReadOnly = True
        Me.txtNumbers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNumbers.Size = New System.Drawing.Size(337, 37)
        Me.txtNumbers.TabIndex = 28
        '
        'txtContactPerson
        '
        Me.txtContactPerson.Enabled = False
        Me.txtContactPerson.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactPerson.Location = New System.Drawing.Point(496, 19)
        Me.txtContactPerson.Name = "txtContactPerson"
        Me.txtContactPerson.ReadOnly = True
        Me.txtContactPerson.Size = New System.Drawing.Size(337, 22)
        Me.txtContactPerson.TabIndex = 27
        '
        'txtAdrs
        '
        Me.txtAdrs.Enabled = False
        Me.txtAdrs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdrs.Location = New System.Drawing.Point(13, 47)
        Me.txtAdrs.Multiline = True
        Me.txtAdrs.Name = "txtAdrs"
        Me.txtAdrs.ReadOnly = True
        Me.txtAdrs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAdrs.Size = New System.Drawing.Size(477, 37)
        Me.txtAdrs.TabIndex = 26
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(13, 19)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(438, 22)
        Me.txtName.TabIndex = 25
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCI)
        Me.GroupBox1.Controls.Add(Me.btnDI)
        Me.GroupBox1.Controls.Add(Me.btnEI)
        Me.GroupBox1.Controls.Add(Me.btnAI)
        Me.GroupBox1.Controls.Add(Me.dtDate)
        Me.GroupBox1.Controls.Add(Me.cboReceiver)
        Me.GroupBox1.Controls.Add(Me.cboReceipt)
        Me.GroupBox1.Controls.Add(Me.lv)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtSerial)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNote)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(848, 426)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supplier"
        '
        'btnCI
        '
        Me.btnCI.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCI.Enabled = False
        Me.btnCI.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCI.ForeColor = System.Drawing.Color.Blue
        Me.btnCI.Image = CType(resources.GetObject("btnCI.Image"), System.Drawing.Image)
        Me.btnCI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCI.Location = New System.Drawing.Point(206, 390)
        Me.btnCI.Name = "btnCI"
        Me.btnCI.Size = New System.Drawing.Size(61, 25)
        Me.btnCI.TabIndex = 57
        Me.btnCI.Text = "Clear"
        Me.btnCI.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCI.UseVisualStyleBackColor = True
        '
        'btnDI
        '
        Me.btnDI.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDI.Enabled = False
        Me.btnDI.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDI.ForeColor = System.Drawing.Color.Blue
        Me.btnDI.Image = CType(resources.GetObject("btnDI.Image"), System.Drawing.Image)
        Me.btnDI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDI.Location = New System.Drawing.Point(135, 390)
        Me.btnDI.Name = "btnDI"
        Me.btnDI.Size = New System.Drawing.Size(65, 25)
        Me.btnDI.TabIndex = 56
        Me.btnDI.Text = "Remove"
        Me.btnDI.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDI.UseVisualStyleBackColor = True
        '
        'btnEI
        '
        Me.btnEI.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEI.Enabled = False
        Me.btnEI.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEI.ForeColor = System.Drawing.Color.Blue
        Me.btnEI.Image = CType(resources.GetObject("btnEI.Image"), System.Drawing.Image)
        Me.btnEI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEI.Location = New System.Drawing.Point(76, 390)
        Me.btnEI.Name = "btnEI"
        Me.btnEI.Size = New System.Drawing.Size(53, 25)
        Me.btnEI.TabIndex = 55
        Me.btnEI.Text = "Edit"
        Me.btnEI.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEI.UseVisualStyleBackColor = True
        '
        'btnAI
        '
        Me.btnAI.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAI.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAI.ForeColor = System.Drawing.Color.Blue
        Me.btnAI.Image = CType(resources.GetObject("btnAI.Image"), System.Drawing.Image)
        Me.btnAI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAI.Location = New System.Drawing.Point(13, 390)
        Me.btnAI.Name = "btnAI"
        Me.btnAI.Size = New System.Drawing.Size(57, 25)
        Me.btnAI.TabIndex = 54
        Me.btnAI.Text = "Add"
        Me.btnAI.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAI.UseVisualStyleBackColor = True
        '
        'dtDate
        '
        Me.dtDate.Location = New System.Drawing.Point(332, 44)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(186, 22)
        Me.dtDate.TabIndex = 53
        '
        'cboReceiver
        '
        Me.cboReceiver.FormattingEnabled = True
        Me.cboReceiver.Location = New System.Drawing.Point(524, 44)
        Me.cboReceiver.Name = "cboReceiver"
        Me.cboReceiver.Size = New System.Drawing.Size(309, 21)
        Me.cboReceiver.TabIndex = 52
        '
        'cboReceipt
        '
        Me.cboReceipt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReceipt.FormattingEnabled = True
        Me.cboReceipt.Location = New System.Drawing.Point(13, 44)
        Me.cboReceipt.Name = "cboReceipt"
        Me.cboReceipt.Size = New System.Drawing.Size(196, 21)
        Me.cboReceipt.TabIndex = 51
        '
        'lv
        '
        Me.lv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lv.Cursor = System.Windows.Forms.Cursors.Default
        Me.lv.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv.FullRowSelect = True
        Me.lv.GridLines = True
        Me.lv.HideSelection = False
        Me.lv.HoverSelection = True
        Me.lv.Location = New System.Drawing.Point(13, 132)
        Me.lv.MultiSelect = False
        Me.lv.Name = "lv"
        Me.lv.Scrollable = False
        Me.lv.Size = New System.Drawing.Size(820, 251)
        Me.lv.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lv.TabIndex = 38
        Me.lv.UseCompatibleStateImageBehavior = False
        Me.lv.View = System.Windows.Forms.View.Details
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "&Remarks"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(521, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "&Received By"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(331, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "&Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(212, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "&Serial Number"
        '
        'txtSerial
        '
        Me.txtSerial.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerial.Location = New System.Drawing.Point(215, 44)
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Size = New System.Drawing.Size(113, 22)
        Me.txtSerial.TabIndex = 32
        Me.txtSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "&Type of Receipt"
        '
        'txtNote
        '
        Me.txtNote.Enabled = False
        Me.txtNote.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNote.Location = New System.Drawing.Point(59, 77)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNote.Size = New System.Drawing.Size(774, 44)
        Me.txtNote.TabIndex = 30
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(827, 544)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(33, 25)
        Me.btnCancel.TabIndex = 52
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(788, 544)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(33, 25)
        Me.btnSave.TabIndex = 51
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmPurchaseEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 580)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPurchaseEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Edit"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumbers As System.Windows.Forms.TextBox
    Friend WithEvents txtContactPerson As System.Windows.Forms.TextBox
    Friend WithEvents txtAdrs As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSerial As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents cboReceiver As System.Windows.Forms.ComboBox
    Friend WithEvents cboReceipt As System.Windows.Forms.ComboBox
    Friend WithEvents dtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSupplier As System.Windows.Forms.Button
    Friend WithEvents btnAI As System.Windows.Forms.Button
    Friend WithEvents btnDI As System.Windows.Forms.Button
    Friend WithEvents btnEI As System.Windows.Forms.Button
    Friend WithEvents btnCI As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class

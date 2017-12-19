<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConnection))
        Me.btnS = New System.Windows.Forms.Button()
        Me.btnX = New System.Windows.Forms.Button()
        Me.txtDB = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtHost = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPW = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnS
        '
        Me.btnS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnS.ForeColor = System.Drawing.Color.Blue
        Me.btnS.Image = CType(resources.GetObject("btnS.Image"), System.Drawing.Image)
        Me.btnS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnS.Location = New System.Drawing.Point(265, 105)
        Me.btnS.Name = "btnS"
        Me.btnS.Size = New System.Drawing.Size(58, 28)
        Me.btnS.TabIndex = 125
        Me.btnS.Text = "&Save"
        Me.btnS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnS.UseVisualStyleBackColor = True
        '
        'btnX
        '
        Me.btnX.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnX.ForeColor = System.Drawing.Color.Blue
        Me.btnX.Image = CType(resources.GetObject("btnX.Image"), System.Drawing.Image)
        Me.btnX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnX.Location = New System.Drawing.Point(329, 105)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(54, 28)
        Me.btnX.TabIndex = 124
        Me.btnX.Text = "E&xit"
        Me.btnX.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnX.UseVisualStyleBackColor = True
        '
        'txtDB
        '
        Me.txtDB.BackColor = System.Drawing.Color.White
        Me.txtDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDB.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDB.ForeColor = System.Drawing.Color.Black
        Me.txtDB.Location = New System.Drawing.Point(12, 111)
        Me.txtDB.Name = "txtDB"
        Me.txtDB.Size = New System.Drawing.Size(206, 20)
        Me.txtDB.TabIndex = 123
        Me.txtDB.Tag = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(9, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 14)
        Me.Label10.TabIndex = 122
        Me.Label10.Text = "Database"
        '
        'txtHost
        '
        Me.txtHost.BackColor = System.Drawing.Color.White
        Me.txtHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHost.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHost.ForeColor = System.Drawing.Color.Black
        Me.txtHost.Location = New System.Drawing.Point(240, 71)
        Me.txtHost.Name = "txtHost"
        Me.txtHost.Size = New System.Drawing.Size(143, 20)
        Me.txtHost.TabIndex = 121
        Me.txtHost.Tag = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(236, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 14)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "Host"
        '
        'txtPort
        '
        Me.txtPort.BackColor = System.Drawing.Color.White
        Me.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPort.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPort.ForeColor = System.Drawing.Color.Black
        Me.txtPort.Location = New System.Drawing.Point(240, 25)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(142, 20)
        Me.txtPort.TabIndex = 119
        Me.txtPort.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(236, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 14)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "Port"
        '
        'txtPW
        '
        Me.txtPW.BackColor = System.Drawing.Color.White
        Me.txtPW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPW.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPW.ForeColor = System.Drawing.Color.Black
        Me.txtPW.Location = New System.Drawing.Point(12, 71)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(120)
        Me.txtPW.Size = New System.Drawing.Size(206, 20)
        Me.txtPW.TabIndex = 117
        Me.txtPW.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 14)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Password"
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.White
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUser.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.Color.Black
        Me.txtUser.Location = New System.Drawing.Point(12, 25)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(206, 20)
        Me.txtUser.TabIndex = 115
        Me.txtUser.Tag = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(8, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 14)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = "User"
        '
        'frmConnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 144)
        Me.Controls.Add(Me.btnS)
        Me.Controls.Add(Me.btnX)
        Me.Controls.Add(Me.txtDB)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtHost)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPW)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label7)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConnection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnS As System.Windows.Forms.Button
    Friend WithEvents btnX As System.Windows.Forms.Button
    Friend WithEvents txtDB As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtHost As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPW As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class

Option Explicit On


Imports MySql.Data.MySqlClient

Module modMain
    Public SearchID As Long

    Public Structure ItemDetails
        Public ID As Long
        Public Unit As String
        Public UnitID As Long
        Public Brand As String
        Public BrandID As Long
        Public Model As String
        Public Capacity As String
        Public Specs As String
        Public IsActionSave As Boolean
    End Structure

    Public ItemEdit As ItemDetails

    Public Sub PapulateComboBox(cbo As ComboBox, sql As String)
        Try
            Dim cmd As New MySqlCommand
            Dim ds As New DataSet()
            Dim ad As New MySqlDataAdapter()

            cbo.DataSource = Nothing
            cbo.Items.Clear()

            If InitCommand(cmd, sql) Then
                ad.SelectCommand = cmd
                ad.Fill(ds)
                ad.Dispose()
                cbo.Sorted = True
                cbo.DataSource = ds.Tables(0)
                cbo.ValueMember = "ID"
                cbo.DisplayMember = "Title"
            End If
            DisposeObject(cmd)
        Catch ex As Exception
            MsgBox("Failed to papulate combobox" & vbCrLf & "Reason: " & ex.InnerException.Message, MsgBoxStyle.Exclamation, "Information")
        End Try
    End Sub



End Module

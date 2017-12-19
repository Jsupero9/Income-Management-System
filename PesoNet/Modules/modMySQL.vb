Option Strict On

Imports MySql.Data.MySqlClient

Module ModMySQL

    Public cn As New MySqlConnection

    Structure ConnectionSettings
        Public Server As String
        Public Ports As Integer
        Public UserName As String
        Public UserPassCode As String
        Public DatabaseName As String
    End Structure

    Public Structure SystemSettings
        Public conn As ConnectionSettings
    End Structure

    Public sets As SystemSettings

    Public Sub ReadConnection()

        If GetSetting("Connection", "Config", "User", "").ToString.Length = 0 Then
            frmConnection.ShowDialog()
            If GetSetting("Connection", "Config", "User", "").ToString.Length = 0 Then
                MsgBox("Sorry, database connection is required", vbExclamation, "Information")
                End
            End If
        End If


        With sets.conn
            .Server = GetSetting("Connection", "Config", "Host", "127.0.0.1")
            .Ports = 3306
            If IsNumeric(GetSetting("Connection", "Config", "Port", "3306")) Then .Ports = CInt(GetSetting("Connection", "Config", "Port", "3306"))
            .UserName = GetSetting("Connection", "Config", "User", "root")
            .UserPassCode = GetSetting("Connection", "Config", "PassKey", "root")
            .DatabaseName = GetSetting("Connection", "Config", "DB", "MicroFin")
        End With

    End Sub

    Public Function IsLiveConn() As Boolean
        Dim retval As Boolean = False
        Try
            If (cn.State <> ConnectionState.Open) Then
                cn.ConnectionString = "server=" & sets.conn.Server & ";UserID=" & sets.conn.UserName & ";Password=" & sets.conn.UserPassCode & ";Port=" & sets.conn.Ports & ";Database=" & sets.conn.DatabaseName
                If sets.conn.UserPassCode.Length = 0 Then cn.ConnectionString = "server=" & sets.conn.Server & ";UserID=" & sets.conn.UserName & ";Port=" & sets.conn.Ports & ";Database=" & sets.conn.DatabaseName
            End If

            If (cn.State = ConnectionState.Broken) Then cn.Close()
            If (cn.State <> ConnectionState.Open) Then cn.Open()

            'If (cn.State <> ConnectionState.Open) Then cn.Close()
            'cn.Open()
            retval = cn.State = ConnectionState.Open
        Catch ex As MySqlException
            MsgBox(ex.Message & " Naa Didi", vbExclamation, "Information")
            cn.Dispose()
        End Try

        Return retval
    End Function

    Public Function GotData(sql As String, cmd As MySqlCommand, ByRef dt As DataTable) As Boolean
        Dim RetVal As Boolean = False
        If Not IsLiveConn() Then Return False

        Try
            If InitCommand(cmd, sql) Then
                Using sda As New MySqlDataAdapter(cmd)
                    sda.Fill(dt)
                    RetVal = dt.Rows.Count > 0
                End Using
            End If

        Catch ex As Exception

        End Try
        Return RetVal
    End Function

    Public Function FillUpData(sql As String, ByRef cmd As MySqlCommand) As Boolean
        Dim RetVal As Boolean = False
        If Not IsLiveConn() Then Return False

        Try
            RetVal = InitCommand(cmd, sql)
        Catch ex As Exception
            cn.Dispose()
        End Try

        Return RetVal
    End Function

    Public Function InitCommand(ByRef cmd As MySqlCommand, sql As String) As Boolean
        If Not IsLiveConn() Then Return False
        Dim RetVal As Boolean = False
        Try
            cmd.Connection = cn
            cmd.CommandText = sql
            cmd.CommandType = CommandType.Text
            cmd.Prepare()
            RetVal = True
        Catch ex As Exception
        End Try
        Return RetVal
    End Function

    Public Function IsMySQL(sql As String, Optional cmd As MySqlCommand = Nothing) As Boolean
        Dim RetVal As Boolean = False

        If Not IsLiveConn() Then Return False

        Dim mCmd As New MySqlCommand
        If IsNothing(cmd) Then cmd = mCmd

        Try
            cmd.Connection = cn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            cmd.Prepare()
            cmd.ExecuteNonQuery()
            RetVal = True
        Catch ex As MySqlException
            Dim msg As String = ex.InnerException.Message & vbCrLf & vbCrLf & "On MySQL Command:" & vbCrLf & sql
            MsgBox(msg, vbExclamation, "Information")
        End Try
        Return RetVal
    End Function

    Public Sub DisposeObject(ByRef cmd As MySqlCommand, Optional ByRef dt As DataTable = Nothing)
        If Not IsNothing(dt) Then
            dt.Dispose()
            dt = Nothing
        End If

        cmd.Dispose()
        cmd = Nothing
    End Sub


End Module

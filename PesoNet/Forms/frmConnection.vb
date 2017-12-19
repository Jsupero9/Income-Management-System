
Imports MySql.Data.MySqlClient
Public Class frmConnection

    Private Sub frmConn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Text = GetSetting("Connection", "Config", "User", "root")
        txtPW.Text = GetSetting("Connection", "Config", "PassKey", "root")
        txtPort.Text = GetSetting("Connection", "Config", "Port", "3306")
        txtHost.Text = GetSetting("Connection", "Config", "Host", "127.0.0.1")
        txtDB.Text = GetSetting("Connection", "Config", "DB", "test")
    End Sub

    Private Sub CheckConnection()
        Dim c As New MySqlConnection

        Dim retval As Boolean = False
        Try
            If c.State = ConnectionState.Open Then c.Close()
            If c.State <> ConnectionState.Open Then
                c.ConnectionString = "server=" & txtHost.Text & ";UserID=" & txtUser.Text & ";Password=" & txtPW.Text & ";Port=" & txtPort.Text & ";Database=" & txtDB.Text
                If txtPW.Text.Length = 0 Then
                    c.ConnectionString = "server=" & txtHost.Text & ";UserID=" & txtUser.Text & ";Port=" & txtPort.Text & ";Database=" & txtDB.Text
                End If
            End If

            If (c.State = ConnectionState.Broken) Then c.Close()
            If (c.State = ConnectionState.Closed) Then c.Open()
            retval = c.State = ConnectionState.Open
        Catch
            retval = False
        End Try

        If retval Then
            c.Close()
            SaveSetting("Connection", "Config", "User", txtUser.Text)
            SaveSetting("Connection", "Config", "PassKey", txtPW.Text)
            SaveSetting("Connection", "Config", "Port", txtPort.Text)
            SaveSetting("Connection", "Config", "Host", txtHost.Text)
            SaveSetting("Connection", "Config", "DB", txtDB.Text)
        End If

        If Not retval Then
            MsgBox("Error in configuration", vbCritical, "Information")
        Else
            MsgBox("Succesfully configured", vbInformation, "Information")
        End If

        c.Dispose()
    End Sub

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        CheckConnection()
    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        End
    End Sub
End Class
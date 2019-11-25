
Imports System.Configuration
Imports System.Runtime.CompilerServices
Imports WindowsApp1.Classes

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim backupTime = TimeSpan.Parse(ConfigurationManager.AppSettings("BackupTime"))
        Console.WriteLine($"TimeSpan.Parse: {backupTime}")

        Dim testModeGeneric1 = AppConfiguration.BackupTime
        Console.WriteLine($"GetConfigSetting: {testModeGeneric1}")

        Try
            Dim testModeGeneric2 = AppConfiguration.ConfigSetting(Of TimeSpan)("BackupTime")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Dim anotherTest = AppConfiguration.ConvertOrDefault(Of TimeSpan)(ConfigurationManager.AppSettings("BackupTime"))
        Console.WriteLine(anotherTest)

        Console.WriteLine(AppConfiguration.ConvertOrDefault(Of Date)(ConfigurationManager.AppSettings("AlertDate1")) = Date.MinValue)

    End Sub
End Class

<Extension()>
Public Module DataReaderExtensions
    Public Function GetValue(Of T)(value As Object) As T
        If value.Equals(DBNull.Value) Then
            ' Value is null, determine the return type for a default
            If GetType(T) Is GetType(String) Then
                Return CType(CType("", Object), T)
            Else
                ' If it's anything else just return nothing
                Return Nothing
            End If
        Else
            ' Cast the value into the correct return type
            Return CType(value, T)
        End If
    End Function
End Module
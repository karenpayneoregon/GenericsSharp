Imports System.ComponentModel
Imports System.Configuration

Namespace Classes
    Public Class AppConfiguration
        Public Shared Function ConfigSetting(Of T)(settingName As String) As T
            Dim value As Object = ConfigurationManager.AppSettings(settingName)
            Return DirectCast(Convert.ChangeType(value, GetType(T)), T)
        End Function

        Public Shared Function ParseGeneric(Of T)(stringValue As String) As T
            Return DirectCast(TypeDescriptor.GetConverter(GetType(T)).ConvertFromString(stringValue), T)
        End Function
        Public Shared Function GetConfigSetting(Of T)(stringValue As String) As T
            Return ParseGeneric(Of T)(ConfigurationManager.AppSettings(stringValue))
        End Function

        Public Shared Function ConvertOrDefault(Of T)(input As String) As T
            Try
                Dim converter = TypeDescriptor.GetConverter(GetType(T))
                Return DirectCast(converter.ConvertFromString(input), T)
            Catch e1 As Exception
                Return Nothing
            End Try
        End Function

        Public Shared ReadOnly Property TestMode() As Boolean
            Get
                Return ConfigSetting(Of Boolean)("TestMode")
            End Get
        End Property
        Public Shared ReadOnly Property TestMode1() As Boolean
            Get
                Return GetConfigSetting(Of Boolean)("TestMode")
            End Get
        End Property
        Public Shared ReadOnly Property BackupTime() As TimeSpan
            Get
                Return GetConfigSetting(Of TimeSpan)("BackupTime")
            End Get
        End Property

        Public Shared ReadOnly Property DatabaseServer() As String
            Get
                Return ConfigurationManager.AppSettings("DatabaseServer")
            End Get
        End Property
    End Class
End Namespace
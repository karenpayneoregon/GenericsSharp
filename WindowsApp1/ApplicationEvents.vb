Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    Partial Friend Class MyApplication
        Public ReadOnly Property CommandLineArguments As String()
            Get
                Dim arguments = Environment.
                        GetCommandLineArgs.
                        ToList().
                        Select(Function(argument) argument.ToUpper()).
                        ToList()

                arguments.RemoveAt(0)

                Return arguments.ToArray()

            End Get
        End Property
        ''' <summary>
        ''' Used to get command argument count
        ''' </summary>
        ''' <returns>Count of command arguments sent on startup of application</returns>
        Public ReadOnly Property HasCommandLineArguments As Boolean
            Get
                Return CommandLineArguments.Length = 1
            End Get
        End Property

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) ' Handles Me.Startup

            If HasCommandLineArguments Then
                If Not CommandLineArguments.FirstOrDefault().ToLower().EndsWith(".vb") Then
                    e.Cancel = True
                End If
            End If
        End Sub
    End Class
End Namespace

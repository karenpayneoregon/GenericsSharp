
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Add(New Object() {234.99})
        DataGridView1.Rows.Add(New Object() {34.99})
        DataGridView1.Rows.Add(New Object() {23.99})


        If My.Application.HasCommandLineArguments Then
            For Each ca As String In My.Application.CommandLineArguments
                ListBox1.Items.Add(ca)
            Next

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub ResultsButton_Click(sender As Object, e As EventArgs) Handles ResultsButton.Click

        Dim column1Max = Controls.OfType(Of TextBox).
                Where(Function(tb) tb.Name.StartsWith("Column1")).
                Select(Function(tb)
                           Dim result As Decimal = 0
                           If Decimal.TryParse(tb.Text, result) Then
                               Return result
                           Else
                               Return 0
                           End If
                       End Function).Max()

        Total1TextBox.Text = column1Max.ToString()

        Dim column2Max = Controls.OfType(Of TextBox).
                Where(Function(tb) tb.Name.StartsWith("Column2")).
                Select(Function(tb)
                           Dim result As Decimal = 0
                           If Decimal.TryParse(tb.Text, result) Then
                               Return result
                           Else
                               Return 0
                           End If
                       End Function).Max()

        Total2TextBox.Text = column2Max.ToString()

        Dim Column3Max = Controls.OfType(Of TextBox).
                Where(Function(tb) tb.Name.StartsWith("Column3")).
                Select(Function(tb)
                           Dim result As Decimal = 0
                           If Decimal.TryParse(tb.Text, result) Then
                               Return result
                           Else
                               Return 0
                           End If
                       End Function).Max()

        Total3TextBox.Text = column2Max.ToString()

        Dim Column4Max = Controls.OfType(Of TextBox).
                Where(Function(tb) tb.Name.StartsWith("Column4")).
                Select(Function(tb)
                           Dim result As Decimal = 0
                           If Decimal.TryParse(tb.Text, result) Then
                               Return result
                           Else
                               Return 0
                           End If
                       End Function).Max()

        Total4TextBox.Text = column2Max.ToString()

        Dim column5Max = Controls.OfType(Of TextBox).
                Where(Function(tb) tb.Name.StartsWith("Column5")).
                Select(Function(tb)
                           Dim result As Decimal = 0
                           If Decimal.TryParse(tb.Text, result) Then
                               Return result
                           Else
                               Return 0
                           End If
                       End Function).Max()

        Total5TextBox.Text = column2Max.ToString()

        '
        ' Can be placed into TextBox controls
        '
        Dim sums = Controls.OfType(Of TextBox).
                Where(Function(tb) tb.Name.StartsWith("Column")).
                Select(Function(tb) CDec(tb.Text)).Sum().
                ToString()

        Dim max = Controls.OfType(Of TextBox).
                Where(Function(tb) tb.Name.StartsWith("Column")).
                Select(Function(tb) CDec(tb.Text)).
                Max().
                ToString()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Total1TextBox.Text = DataGridView1.
            Rows.
            Cast(Of DataGridViewRow).
            Max(Function(row)
                    Dim result As Decimal = 0
                    If Decimal.TryParse(CStr(row.Cells(0).Value), result) Then
                        Return result
                    Else
                        Return 0
                    End If
                End Function).ToString()
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
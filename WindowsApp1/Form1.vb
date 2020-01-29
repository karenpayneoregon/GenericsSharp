
Imports System.ComponentModel
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Text.RegularExpressions
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        Dim line = "[""Mahmud"",""karen"",""mike"",""Mahmud"""

        For Each m As Match In Regex.Matches(line, "(?<="")[\w]+(?!="")")
            Console.WriteLine(m.Value)
        Next




    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click



        Dim line = "[""Mahmud"",""karen"",""mike"",""Махмуд"""
        Dim regex As New Regex("""(.*?)""")

        Dim match = regex.Matches(line).Cast(Of Match).
                FirstOrDefault(Function(item) item.Groups(1).Value = "Mahmud")

        If match IsNot Nothing Then
            Console.WriteLine("Found")
        Else
            Console.WriteLine("Not found")
        End If


        'For Each match As Match In matches
        '    Console.WriteLine(match.Groups(1))
        'Next

        '
        '


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        '
        ' These value would come from the database table
        '
        Dim accountList As New List(Of String) From {
                "COA-1000-001",
                "COA-1000-002",
                "COA-1000-003",
                "COA-1000-005"}

        Dim partList = accountList.
                Select(
                    Function(item)
                        Dim parts = item.Split("-"c)
                        Dim part1 = parts(0)
                        Dim part2 = CInt(parts(1))
                        Dim part3 = CInt(parts(2))
                        Return New CoaItem With {
                          .Part1 = part1,
                          .Part2 = part2,
                          .Part3 = part3
                        }
                    End Function).ToList()

        Dim missingNumber = partList.NextValue()

        If missingNumber > 0 Then
            Console.WriteLine($"COA-1000-{missingNumber.ToString("D3")}")
        Else
            Console.WriteLine("No missing items in sequence")
        End If

    End Sub

    Private ItemList As List(Of Item) = New List(Of Item)

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click


        ItemList.Add(New Item() With {
                        .Name = "Test1",
                        .Font = New Font("Arial", 10, FontStyle.Bold),
                        .X = 10,
                        .Y = 9})
        ItemList.Add(New Item() With {
                        .Name = "Test2",
                        .Font = New Font("Times New Roman", 16, FontStyle.Regular),
                        .X = 10,
                        .Y = 9})


        Dim test = ItemList(1).Font

        Dim ListUsers = New List(Of String)(File.ReadAllLines("list.txt"))
        Dim results = ListUsers.Select(Function(line, index) New With {
                                          .Line = line,
                                          .Index = index + 1}).
                Where(Function(item) item.Line.Contains("ID"))

        For Each line In results
            Console.WriteLine($"{line.Index} - {line.Line}")
        Next

    End Sub
    Function CheckId(enumerator As IEnumerator) As Boolean

        If enumerator.Current.ToString().Contains("ID") Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
Public Class Item
    Public Property Name() As String
    Public Property Font() As Font
    Public Property X() As Integer
    Public Property Y() As Integer

    Public Overrides Function ToString() As String
        Return Name
    End Function
End Class
Public Class CoaItem
    Public Property Part1() As String
    Public Property Part2() As Integer
    Public Property Part3() As Integer

    Public Overrides Function ToString() As String
        Return $"{Part1}-{Part2}-{Part3}"
    End Function
End Class
Public Module Extensions
    ''' <summary>
    ''' Look for missing value for Part3 if any.
    ''' If no missing value 0 is returned, otherwise
    ''' the missing number in the sequence 
    ''' </summary>
    ''' <param name="list"></param>
    ''' <returns></returns>
    <Extension>
    Public Function NextValue(list As List(Of CoaItem)) As Integer
        Return list.Select(Function(item) item.Part3).ToList().FindMissing().FirstOrDefault()
    End Function
    ''' <summary>
    ''' Finds the missing numbers in a list.
    ''' </summary>
    ''' <param name="list">List of numbers</param>
    ''' <returns>Missing numbers</returns>
    <Extension>
    Public Function FindMissing(list As List(Of Integer)) As IEnumerable(Of Integer)

        list.Sort()

        Dim firstNumber = list.First()
        Dim lastNumber = list.Last()
        Dim range = Enumerable.Range(firstNumber, lastNumber - firstNumber)
        Dim missingNumbers = range.Except(list)

        Return missingNumbers

    End Function
End Module
Public Module ControlExtensions
    <Extension>
    Public Sub InvokeIfRequired(Of T As ISynchronizeInvoke)(control As T, action As Action(Of T))
        If control.InvokeRequired Then
            control.Invoke(New Action(Sub() action(control)), Nothing)
        Else
            action(control)
        End If
    End Sub
End Module

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
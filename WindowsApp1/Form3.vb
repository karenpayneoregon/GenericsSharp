Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class Form3
    Private bindingSource As New BindingSource

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim nextId = CType(bindingSource.DataSource,
                           List(Of SampleItem)).Max(Function(item) item.Id) + 1

        bindingSource.Insert(CInt(NumericUpDown1.Value) + 1,
                             New SampleItem() With {
                                .Id = nextId,
                                .Value1 = "Just inserted",
                                .Value2 = "A"})

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim items = New List(Of SampleItem) From {
                New SampleItem() With {.Id = 0, .Value1 = "One", .Value2 = "M"},
                New SampleItem() With {.Id = 1, .Value1 = "Two", .Value2 = "M"},
                New SampleItem() With {.Id = 2, .Value1 = "Three", .Value2 = "X"},
                New SampleItem() With {.Id = 3, .Value1 = "Four", .Value2 = "T"}
                }

        bindingSource.DataSource = items
        ListBox1.DataSource = bindingSource
        NumericUpDown1.Maximum = bindingSource.Count - 1

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim currentItem = CType(bindingSource.Current, SampleItem)
        MessageBox.Show($"Current id {currentItem.Id}")
    End Sub
End Class
''' <summary>
''' This should be in a separate file
''' </summary>
Public Class SampleItem
    Implements INotifyPropertyChanged
    Private _value1 As String
    Private _value2 As String
    Public Property Id() As Integer
    Public Property Value1() As String
        Get
            Return _value1
        End Get
        Set(ByVal value As String)
            If Not (value = _value1) Then
                _value1 = value
                NotifyPropertyChanged()
            End If
        End Set
    End Property

    Public Property Value2() As String
        Get
            Return _value2
        End Get
        Set(ByVal value As String)
            If Not (value = _value2) Then
                _value2 = value
                NotifyPropertyChanged()
            End If
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Value1
    End Function

    Public Event PropertyChanged As PropertyChangedEventHandler _
        Implements INotifyPropertyChanged.PropertyChanged

    Private Sub NotifyPropertyChanged(<CallerMemberName()>
    Optional ByVal propertyName As String = Nothing)

        RaiseEvent PropertyChanged(Me,
            New PropertyChangedEventArgs(propertyName))

    End Sub
End Class
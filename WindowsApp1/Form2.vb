Imports System.Data.OleDb

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitleListBox.DisplayMember = "TABLE_NAME"
        CategoryComboBox.DataSource = DatabaseContainer.List()
    End Sub
    Private ActiveDataConn As OleDbConnection
    Private Sub CategoryComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles CategoryComboBox.SelectedIndexChanged

        Dim databaseToUse = CType(CategoryComboBox.SelectedItem, DatabaseItem).Path

        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=M:\My Documents\My Resepte\" & databaseToUse
        'ActiveDataConn = connString
        TitleListBox.DataSource = Nothing

        Using myConn As OleDbConnection = New OleDbConnection(connString)
            myConn.Open()
            Dim dtNames As DataTable = myConn.GetSchema("Tables", New String() {Nothing, Nothing, Nothing, "TABLE"})
            TitleListBox.DataSource = dtNames
            '
            ' Try this as is then if it works try commenting this line out, see if it works
            ' still as it's also set in Form Load
            '
            TitleListBox.DisplayMember = "TABLE_NAME"

        End Using

    End Sub
End Class
Public Class DatabaseItem
    Public Property DisplayName() As String
    Public Property Path() As String
    Public Overrides Function ToString() As String
        Return DisplayName
    End Function
End Class
Public Module DatabaseContainer
    Public Function List() As List(Of DatabaseItem)
        Dim results = New List(Of DatabaseItem)
        results.Add(New DatabaseItem() With {
                       .DisplayName = "Smaaklik Tuisgemaakte Drankies",
                       .Path = "M:\My Documents\My Resepte\Beverages.accdb"})
        results.Add(New DatabaseItem() With {
                       .DisplayName = "Voorgeregte & Ander Ligte Eetes",
                       .Path = "M:\My Documents\My Resepte\Starters.accdb"})
        results.Add(New DatabaseItem() With {
                       .DisplayName = "Hoofgeregte",
                       .Path = "M:\My Documents\My Resepte\MainDishes.accdb"})
        results.Add(New DatabaseItem() With {
                       .DisplayName = "Watertand Nageregte & Poedings",
                       .Path = "M:\My Documents\My Resepte\Desserts.accdb"})
        results.Add(New DatabaseItem() With {
                       .DisplayName = "Kraakvars Slaai Resepte",
                       .Path = "M:\My Documents\My Resepte\Salads.accdb"})
        results.Add(New DatabaseItem() With {
                       .DisplayName = "Souse & Marinades",
                       .Path = "M:\My Documents\My Resepte\Sauces.accdb"})
        results.Add(New DatabaseItem() With {
                       .DisplayName = "Geurige Tuisgebak",
                       .Path = "M:\My Documents\My Resepte\Baked.accdb"})
        results.Add(New DatabaseItem() With {
                       .DisplayName = "Gebottelde & Ingelegde Lekerneie",
                       .Path = "M:\My Documents\My Resepte\Bottled.accdb"})
        results.Add(New DatabaseItem() With {
                       .DisplayName = "Wenke & Boererate vir in en om die Huis",
                       .Path = "M:\My Documents\My Resepte\Hints.accdb"})
        Return results
    End Function
End Module
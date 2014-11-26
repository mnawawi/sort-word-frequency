
Imports System.Windows.Forms.ListViewItem
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.OleDb




Public Class MainForm
  Dim MyRange As Excel.Range
  Dim xlApp As New Excel.Application
  Dim xlWorkBook As Excel.Workbook
  Dim xlWorkSheet As Excel.Worksheet
  Dim id As String
  Dim row As Integer
  Dim dtable As New DataTable("word")
  Dim sortColumn As Integer = -1
  Private WordCounts As CountWords = New CountWords


  Private Sub CountBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CountBtn.Click


    Dim connshut As System.Data.OleDb.OleDbConnection
    connshut = New System.Data.OleDb.OleDbConnection
    connshut.ConnectionString = My.Settings.wordcharConnectionString
    Dim cmd As New OleDb.OleDbCommand

    'Try
    'connshut.Open()
    'cmd.Connection = connshut
    'cmd.CommandText = "insert into word(Name,Frequency) values(@a,@b,@c);"
    'cmd.Parameters.AddWithValue("@a", OutputList)
    'cmd.Parameters.AddWithValue("@b", OutputList)
    'cmd.Parameters.AddWithValue("@d", id)
    'cmd.ExecuteNonQuery()
    'connshut.Close()
    'MsgBox("Word count update")
    'user()
    'Catch ex As Exception
    'MsgBox("Failed to save data.Please try again.")
    'End Try


    Label2.Text = InputBox.Text.Length

    OutputList.Items.Clear()

    Dim ret As Dictionary(Of String, Integer) = Me.WordCounts.WordCount(InputBox.Text + " ")

    For Each item As String In ret.Keys


      'listview
      Dim litem As ListViewItem = New ListViewItem

      'keep item in listview
      litem.Text = item


      Dim csitem As ListViewSubItem = New ListViewSubItem(litem, ret.Item(item).ToString())

      litem.SubItems.Add(csitem)
      OutputList.Items.Add(litem)

      Word.Width = -1
      Freq.Width = -1

    Next

  End Sub


  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    InputBox.Text = ""
    OutputList.Items.Clear()
    Label2.Text = ""
  End Sub

  Private Sub InputBox_TextChanged(sender As Object, e As EventArgs) Handles InputBox.TextChanged
    Timer1.Enabled = True
  End Sub


  'Public Sub user()

  'dtable.Clear()
  'Dim cnnect As System.Data.OleDb.OleDbConnection
  'Dim dtadapter As OleDb.OleDbDataAdapter
  'cnnect = New System.Data.OleDb.OleDbConnection
  'cnnect.ConnectionString = My.Settings.wordcharConnectionString
  ' cnnect.Open()
  ' dtadapter = New OleDb.OleDbDataAdapter("SELECT * FROM word", cnnect)
  'dtadapter.Fill(dtable)
  'cnnect.Close()
  'DataGridView1.DataSource = dtable
  'DataGridView1.Columns(0).Visible = False
  'End Sub




  Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


    If System.IO.File.Exists(TextBox1.Text) Then
      MessageBox.Show("File exist")

    ElseIf TextBox1.Text = "" Then
      MessageBox.Show("Enter your save directory")
    Else
      Dim myWriter As New IO.StreamWriter(TextBox1.Text)
      myWriter.WriteLine("Word" & "," & "Freq")
      For Each myItem As ListViewItem In OutputList.Items

        myWriter.WriteLine(myItem.Text & "," & myItem.SubItems(1).Text)

      Next
      MessageBox.Show("File Save" + " " + TextBox1.Text)
      myWriter.Close()


    End If


  End Sub



  Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
   

    If TextBox1.Text = "" Then
      MessageBox.Show("Enter your directory")



    ElseIf System.IO.File.Exists(TextBox1.Text) = True Then

      Process.Start(TextBox1.Text)
      tableView.Items.Clear()
      Dim myCoolFileLines() As String = IO.File.ReadAllLines(TextBox1.Text)
      For Each line As String In myCoolFileLines
        Dim lineArray() As String = line.Split(",")
        Dim newItem As New ListViewItem(lineArray(0))
        newItem.SubItems.Add(lineArray(1))

        tableView.Items.Add(newItem)
      Next

    Else
      MessageBox.Show("No directory found")
    End If

  End Sub



  Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    TextBox1.Text = "D:\"
    ' OutputList.Sorting = SortOrder.Descending
    Button5.Enabled = False
  End Sub



  Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    OpenFileDialog1.ShowDialog()
    Label4.Text = OpenFileDialog1.FileName

  End Sub




  Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    xlWorkBook = xlApp.Workbooks.Open(Label4.Text)

    xlWorkSheet = xlWorkBook.Sheets(1)


    xlApp.Visible = True

    With xlWorkSheet
      .Columns(1).TextToColumns( _
      Destination:=.Cells(1, 1), _
      DataType:=Excel.XlTextParsingType.xlDelimited, _
      TextQualifier:=Excel.XlTextQualifier.xlTextQualifierDoubleQuote, _
      ConsecutiveDelimiter:=False, _
      TAB:=False, _
      Semicolon:=False, _
      Comma:=True, _
      Space:=False, _
      Other:=False, _
      TrailingMinusNumbers:=False)

    End With
  End Sub

  Private Sub OutputList_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles OutputList.ColumnClick

    If e.Column <> sortColumn Then
      ' Set the sort column to the new column.
      sortColumn = e.Column
      ' Set the sort order to ascending by default.
      OutputList.Sorting = SortOrder.Ascending
    Else
      ' Determine what the last sort order was and change it.
      If OutputList.Sorting = SortOrder.Ascending Then
        OutputList.Sorting = SortOrder.Descending
      Else
        OutputList.Sorting = SortOrder.Ascending
      End If
    End If
    ' Call the sort method to manually sort.
    OutputList.Sort()
    ' Set the ListViewItemSorter property to a new ListViewItemComparer
    ' object.
    OutputList.ListViewItemSorter = New ListViewItemComparer(e.Column, _
                                                     OutputList.Sorting)
  End Sub


  Private Sub Label4_TextChanged(sender As Object, e As EventArgs) Handles Label4.TextChanged
    Button5.Enabled = True
  End Sub
End Class



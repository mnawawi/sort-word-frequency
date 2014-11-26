
Class CountWords
  Public Function WordCount(ByVal str As String) As Dictionary(Of String, Integer)


    Dim ret As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)

    Dim word As String = ""
    Dim add As Boolean = True
    Dim ch As Char

    str = str.ToLower
    For index As Integer = 0 To str.Length - 1 Step index + 1
      ch = str(index)
      If Char.IsLetter(ch) Then
        add = True
        word += ch
      ElseIf add And word.Length Then

        If Not ret.ContainsKey(word) Then
          ret(word) = 1
        Else
          ret(word) += 1
        End If
        word = ""
      End If
    Next

    Return ret
  End Function

End Class

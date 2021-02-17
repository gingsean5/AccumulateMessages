'Sean Gingerich
'RCET 0265
'Spring 2021
'Accumulate Messages Function
'https://github.com/gingsean5/AccumulateMessagesFunction
Module MessagingService

    Sub Main()
        Console.WriteLine(UserMessages("its banana time ", False))
        Console.WriteLine(UserMessages("and chocolate cake", False))
        Console.WriteLine(UserMessages("", False))
        Console.WriteLine(UserMessages("rewind time", True))
        Console.WriteLine(UserMessages("rewind time", False))
        Console.WriteLine(UserMessages("", True))
        Console.WriteLine(UserMessages("Why won't this push to github", False))


        Console.Read()
    End Sub

    Function UserMessages(newMessage As String, clear As Boolean) As String
        Static messages As String
        messages &= newMessage
        If clear = True Then
            messages = ""
        End If
        Return messages
    End Function

End Module

Module Program
    Sub Main(args As String())

        Console.Title = "UNIX TIME SECOND TOOL"
        Do

            System.Threading.Thread.Sleep(1000)
            Console.Clear()
            Console.WriteLine("Unix Time :", (DateTimeOffset.Now.ToUnixTimeSeconds()))
            Console.WriteLine(DateTimeOffset.Now.ToUnixTimeSeconds())
        Loop
    End Sub
End Module

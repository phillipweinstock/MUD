Module Mud

    Friend Class playerClass
        Public Username As String = Nothing
        Public age As Integer = Nothing
        Public Familyname As String = Nothing
        Public valid As Boolean = False
        ' Public methods'
        'Private a As Object


        Public Sub Newname(ByVal firstname As String, ByVal lastname As String)
            Me.Username = firstname
            Me.Familyname = lastname
            Console.WriteLine("Your Name in the Multiverse is " & Username & " You have just been born into the " & Familyname & " Household")
            Console.WriteLine("You now exist")
            Me.age = 0

        End Sub
    End Class
#Region "Decision Tree Implementation"
    Class DecisionAsGraph
        Public Property Title As String
        Public Property Description As String
        Public Property Decisions As New List(Of DecisionAsGraph)
    End Class
#End Region
#Region "Story Class"

    Dim livingroom = New DecisionAsGraph With
           {
        .Title = "Living room",
        .Description = ""}
#End Region
    Sub StartMainLogic()
        Console.WriteLine("welcome to the Multiverse")
        Console.WriteLine("Please Type Newname into the console")
        Console.WriteLine(" type Help if Required")
        Dim running As Boolean = True
        Dim player As New playerClass
        Do While running = True
            Console.WriteLine()

            Select Case Console.ReadLine().ToLower
#Region "New-NAME COMMAND"
                Case "newname", "new name"

                    If player.valid = False Then 'Stops people changing their name in the multiverse For reasons i'll will explain later in this document.
Nn:  'Goto statment ________________________________________________________________________________________________
                        Console.Write("Please Enter Your New Name:  ")
                        Dim firstname As String = Console.ReadLine
                        Console.Write("Please now enter your Family Name: ")
                        Dim lastname As String = Console.ReadLine
                        Call player.Newname(firstname, lastname)
                        Dim lockname = "no"
                        Dim BooleanCheck = 1
                        Do While lockname = "no"
                            Do While BooleanCheck
                                Console.Write("Do you wish to lock your name in? Yes/No: ")
                                lockname = Console.ReadLine().ToLower
                                Select Case lockname
                                    Case "no", "n"
                                        GoTo Nn
                   '-------------------------------GOTO-Nn-------------------------------
                                    Case "yes", "y"
                                        If firstname = Nothing Or lastname = Nothing Then
                                            Console.WriteLine("Your name contains Null characters , you have to type it again!")
                                            GoTo Nn
                                            '-------------GOTO-Nn----------------------
                                        End If
                                        BooleanCheck = 0
                                        player.valid = True
                                    Case Else
                                        Console.WriteLine("Please Type Y(es)/(No)!")
                                End Select
                            Loop
                        Loop
                        Console.WriteLine("Feel Free to type Generate Adventure")
                    Else Console.WriteLine("You Cannot Change Your Name")
                    End If


#End Region
                Case "help"
                    Console.WriteLine("the only valid command's before the adventure begins is: Help, Generate Adventure, Newname")

#Region "DEBUG PLAYER USERNAME"
                Case "debug player username", "debugplayerusername", "debug-player-username"
                    Try
                        If player.Username = Nothing Then
                            Console.WriteLine("Player.Username NOT DEFINED")

                        Else
                            Console.WriteLine(player.Username)
                            Console.WriteLine("The command ran")
                        End If
                    Catch ex As NullReferenceException
                    End Try
#End Region
#Region "Age debug"
                Case "age", "a g e", "days without a dad"
                    Try
                        If player.age = Nothing Then
                            Console.WriteLine("Player.age NOT DEFINED")

                        Else
                            Console.WriteLine(player.age)
                            Console.WriteLine("The command ran")
                        End If
                    Catch ex As NullReferenceException
                    End Try

#End Region

                Case Else
                    Console.WriteLine("please type a valid command")
            End Select
        Loop


    End Sub
    Sub Main()
        StartMainLogic()

    End Sub

End Module

'Baden Brenner
'RCET0265
'Spring 2023
'Better Calculator
'https://github.com/bbre1666/BetterCalculator.git

Option Compare Text

Imports System
Imports System.Globalization
Imports System.Runtime.InteropServices

Module Program
    Sub Main(args As String())

        'assign varables 
        Dim firstnumber As Integer
        Dim secindnumber As Integer
        Dim number1 As Boolean = False
        Dim number2 As Boolean = False
        Dim leave As Boolean = False
        Dim userimput As String
        Dim choice As Boolean = False
        Dim operation As Integer




        Do Until leave = True
            Console.WriteLine("Please enter two numbers. Enter Q at any time to quit.")
            'assign firstnumber 
            Do Until number1 = True
                Console.WriteLine("Choose a Number")
                Try
                    userimput = Console.ReadLine()
                    firstnumber = CInt(userimput)
                    Console.WriteLine("you entered" & " " & firstnumber)
                    number1 = True

                Catch
                    If userimput = "Q" Then
                        number1 = True
                        leave = True
                    Else
                        Console.WriteLine("you entered" & " " & userimput & " " & "please enter a whole number")
                        number1 = False
                    End If
                End Try
            Loop
            'assign secondnumber 
            Do Until number2 = True
                Console.WriteLine("Choose a Number")
                Try
                    userimput = Console.ReadLine()
                    secindnumber = CInt(userimput)
                    Console.WriteLine("you entered" & " " & secindnumber)
                    number2 = True

                Catch
                    If userimput = "Q" Then
                        number2 = True
                        leave = True
                    Else
                        Console.WriteLine("you entered" & " " & userimput & " " & "please enter a whole number")
                        number2 = False
                    End If
                End Try
            Loop
            'operation module
            If leave = False Then
                Do Until choice = True
                    Console.WriteLine("Choose one of the following options:")
                    Console.WriteLine("1.Add")
                    Console.WriteLine("2.Subtract")
                    Console.WriteLine("3.Multiply")
                    Console.WriteLine("4.Divide")
                    Try
                        userimput = Console.ReadLine()
                        operation = CInt(userimput)
                        'add operation 
                        If operation = 1 Then
                            Console.WriteLine("You entered" & operation)
                            Console.WriteLine(firstnumber & "+" & secindnumber & "=" & firstnumber + secindnumber)
                            choice = True

                            'subtract operation
                        ElseIf operation = 2 Then
                            Console.WriteLine("You entered" & operation)
                            Console.WriteLine(firstnumber & "-" & secindnumber & "=" & firstnumber - secindnumber)
                            choice = True

                            'Multiply operation
                        ElseIf operation = 3 Then
                            Console.WriteLine("You entered" & operation)
                            Console.WriteLine(firstnumber & "*" & secindnumber & "=" & firstnumber * secindnumber)
                            choice = True

                            'Divide operation
                        ElseIf operation = 4 Then
                            Console.WriteLine("You entered" & operation)
                            Console.WriteLine(firstnumber & "/" & secindnumber & "=" & firstnumber / secindnumber)
                            choice = True

                        ElseIf userimput = "Q" Then
                            choice = True
                            leave = True

                            'cetch operation
                        Else
                            Console.WriteLine("you chose" & " " & operation & " " & "the is not an oprion try again")
                        End If
                    Catch ex As Exception
                        If userimput = "Q" Then
                            choice = True
                            leave = True
                        End If

                    End Try
                Loop
                'set states back to false 
                number1 = False
                number2 = False
                choice = False


            End If


        Loop
        Console.WriteLine("you entered Q see you later")
        Console.WriteLine("press enter to close")
    End Sub
End Module

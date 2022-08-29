Imports System
Module Program

    Dim ano As Integer
    Dim esc As Boolean
    Sub Pare()

        Console.WriteLine("Digite outro ano para repetir o processo")

    End Sub
    Sub Main()

        Console.WriteLine("Digite um ano:")

        Do
            Try

                ano = Console.ReadLine()

                If ano >= 2023 Then

                    If ano Mod 400 = 0 Or ano Mod 4 = 0 And ano Mod 100 <> 0 Then

                        Console.WriteLine($"O ano {ano} vai ser Bissexto")
                        Pare()

                    Else
                        Console.WriteLine($"O ano {ano} não vai ser Bissexto")
                        Pare()

                    End If

                End If

                If ano <= 2021 Then


                    If ano Mod 400 = 0 Or ano Mod 4 = 0 And ano Mod 100 <> 0 Then

                        Console.WriteLine($"O ano {ano} foi Bissexto")
                        Pare()

                    Else
                        Console.WriteLine($"O ano {ano} não foi Bissexto")
                        Pare()

                    End If

                End If

                If ano = 2022 Then

                    If ano Mod 400 = 0 Or ano Mod 4 = 0 And ano Mod 100 <> 0 Then

                        Console.WriteLine("Estamos em um ano Bissexto")
                        Pare()

                    Else
                        Console.WriteLine("Estamos em um ano não Bissexto")
                        Pare()

                    End If

                End If

            Catch

                Console.WriteLine("Digite apenas números")

            End Try
        Loop



    End Sub

End Module

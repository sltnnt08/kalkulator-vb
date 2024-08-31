Imports System.IO
Imports System.Net.Cache
Imports System.Security.Cryptography

Module Module1
    Dim r1, r2 As Double
    Dim luas1, luas2, keliling As Double

    Sub HitungKelilingLingkaran()
        keliling = 3.14 * (2 * r1)
    End Sub
    Function HitungLuasLingkaran()
        Return 3.14 * r1 * 3
    End Function

    Function HitungLuasLingkaran2() As Double
        Return 3.14 * r2 * 3
    End Function



    Sub Main(args As String())

        Dim req As String
        Dim div, sisa As Double
        Dim plus, min, times As Integer


        Console.Write("Jari-jari lingkaran 1: ")
            r1 = Console.ReadLine()
            Console.Write("Jari-jari lingkaran 2: ")
            r2 = Console.ReadLine()

            Console.WriteLine("============================================")

            Console.WriteLine("Hasil Perhitungan: ")

            HitungKelilingLingkaran()
            Console.WriteLine("Keliling lingkaran 1: " & keliling)

            luas1 = HitungLuasLingkaran()
            Console.WriteLine("Luas lingkaran 1: " & luas1)

            luas2 = HitungLuasLingkaran2()
            Console.WriteLine("Luas lingkaran 2: " & luas2)

            Console.WriteLine("============================================")

            Console.Write("Masukkan operasi perhitungan (tambah/kurang/kali/bagi/sisa): ")
            req = Console.ReadLine()
            If req = "plus" Or req = "+" Or req = "tambah" Then
                plus = luas1 + luas2
                Console.WriteLine("Hasil dari penjumlahan dua luas lingkaran: " & plus)
            ElseIf req = "min" Or req = "-" Or req = "kurang" Then
                min = luas1 - luas2
                Console.WriteLine("Hasil dari pengurangan dua luas lingkaran: " & min)
            ElseIf req = "times" Or req = "kali" Or req = "*" Then
                times = luas1 * luas2
                Console.WriteLine("Hasil dari perkalian dua luas lingkaran: " & times)
            ElseIf req = "div" Or req = "bagi" Or req = ":" Then
                div = luas1 / luas2
                Console.WriteLine("Hasil dari pembagian dua luas lingkaran: " & div)
            ElseIf req = "sisa" Or req = "mod" Or req = "/" Then
                sisa = luas1 \ luas2
                Console.WriteLine("Hasil sisa dari pembagian dua luas lingkaran: " & sisa)
            End If

        Console.ReadKey()
    End Sub
End Module

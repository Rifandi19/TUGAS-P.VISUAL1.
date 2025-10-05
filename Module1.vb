Module Module1
    Sub Main()
        ' === Input Data ===
        Console.Write("Masukkan Nama: ")
        Dim nama As String = Console.ReadLine()

        Console.Write("Masukkan Program Studi: ")
        Dim prodi As String = Console.ReadLine()

        Console.Write("Masukkan Nama Kampus: ")
        Dim kampus As String = Console.ReadLine()

        Console.Write("Masukkan Hobi: ")
        Dim hobi As String = Console.ReadLine()

        ' === Output Biodata ===
        Console.WriteLine()
        Console.WriteLine("Halo, nama saya adalah " & nama)
        Console.WriteLine("Saya kuliah pada jurusan " & prodi & " di " & kampus)
        Console.WriteLine("Saya memiliki hobi " & hobi)

        ' Agar console tidak langsung tertutup
        Console.WriteLine()
        Console.WriteLine("Tekan SPASI untuk keluar...")
        Console.ReadLine()
    End Sub
End Module

using System;
using modul4_103022300062;

class Program
{

    static void Main()
    {
        //SOAL 1
        String input = Console.ReadLine();

        Enum.TryParse(input, true, out KodeProduk.Produk produk);
        {
            String kodeProduk = KodeProduk.getKodeProduk(produk);
            Console.WriteLine($"Kode Produk {produk}: {kodeProduk}"); 

        }
    }
}
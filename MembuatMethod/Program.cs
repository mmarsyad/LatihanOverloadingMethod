using System;

namespace MembuatMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int hasil;

            Calculator calculator = new Calculator();

            hasil = calculator.Penjumlah(10, 2);
            CetakHasil("Hasil penjumlah :" + hasil);

            hasil = calculator.Penjumlah(10, 2, 3);
            CetakHasil("Hasil penjumlah :" + hasil);

            hasil = calculator.Pengurang(7, 2);
            CetakHasil("Hasil penjumlah :" + hasil);

            hasil = calculator.Perkalian(5, 2);
            CetakHasil("Hasil penjumlah :" + hasil);
        }

        static void CetakHasil(string hasil)
        {
            Console.WriteLine(hasil);
        }
    }
}

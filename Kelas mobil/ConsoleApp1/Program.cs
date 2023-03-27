using System;

namespace MobilApp
{
    class Mobil
    {
        // Properti mobil
        public string Warna { get; set; }
        public int JumlahPintu { get; set; }
        public string Merek { get; set; }
        public string Model { get; set; }
        public int TahunKeluaran { get; set; }

        // Method mobil
        public void HitungKecepatan(int jarak, int waktu)
        {
            double kecepatan = (double)jarak / waktu;
            Console.WriteLine($"Kecepatan mobil adalah {kecepatan} km/jam");
        }

        public void Klakson()
        {
            Console.WriteLine("Ngokk! Nggok!");
        }

        public void TampilInfo()
        {
            Console.WriteLine($"Merek Mobil      : {Merek} \n");
            Console.WriteLine($"Dengan model     : {Model} \n");
            Console.WriteLine($"Variasi warna    : {Warna} \n");
            Console.WriteLine($"Jumlah Pintu     : {JumlahPintu} pintu\n");
            Console.WriteLine($"Keluaran tahun   : {TahunKeluaran} \n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mobil mobil = new Mobil();

            // Set properti mobil
            mobil.Warna = "Putih";
            mobil.JumlahPintu = 4;
            mobil.Merek = "Kijang";
            mobil.Model = "Innova";
            mobil.TahunKeluaran = 2015;

            // Panggil method mobil
            mobil.TampilInfo();
            mobil.Klakson();
            mobil.HitungKecepatan(160, 2);

            Console.ReadKey();
        }
    }
}
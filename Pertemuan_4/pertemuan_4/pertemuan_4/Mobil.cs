using System;

namespace pertemuan_4
{
    public class Mobil
    {
        private string _warna;
        private int _jumlahPintu;
        private string _merek;
        private string _model;
        private int _tahunKeluar;
        private int _kecepatanMobil;
        private string _suaraMobil;

        public string Warna { get => _warna; set => _warna = value; }
        public int JumlahPintu { get => _jumlahPintu; set => _jumlahPintu = value; }
        public string Merek { get => _merek; set => _merek = value; }
        public string Model { get => _model; set => _model = value; }
        public int TahunKeluar { get => _tahunKeluar; set => _tahunKeluar = value; }
        public int KecepatanMobil { get => _kecepatanMobil; set => _kecepatanMobil = value; }
        public string SuaraMobil { get => _suaraMobil; set => _suaraMobil = value; }

        public void Gas(int kecepatan)
        {
            this.KecepatanMobil = kecepatan;
            Console.WriteLine("Mobil {0} berjalan dengan kecepatan {1}", Model, kecepatan);
        }

        public void Klakson(string suara)
        {
            this.SuaraMobil = suara;
            Console.WriteLine("{0}", suara);
        }

        public void TampilkanInfo()
        {
            Console.WriteLine("Mobil saya berwana {0}, merek {1} model {2} keluaran tahun {3} dengan jumlah pintu sebanyak {4}", Warna, Merek, Model, TahunKeluar, JumlahPintu);
        }

    }
}


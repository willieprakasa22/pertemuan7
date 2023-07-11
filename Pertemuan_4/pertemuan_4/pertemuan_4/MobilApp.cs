 using System;
namespace pertemuan_4
{
	public class MobilApp
	{
            static public void Main(String[] args)
            {
                Mobil mobil1 = new Mobil();
                mobil1.Warna = "silver";
                mobil1.JumlahPintu = 2;
                mobil1.Merek = "Ferrari";
                mobil1.Model = "mobil balap";
                mobil1.TahunKeluar = 2010;
           
                mobil1.Gas(300);
                mobil1.Klakson("Bibbb Bibbbbb");
                mobil1.TampilkanInfo();
            

                Console.WriteLine("\n");
                Console.WriteLine("===================");

                Mobil mobil2 = new Mobil();
                mobil2.Warna = "Red";
                mobil2.JumlahPintu = 2;
                mobil2.Merek = "Lamborgini";
                mobil2.Model = "mobil balap";
                mobil2.TahunKeluar = 2012;

                mobil2.Gas(200);
                mobil2.Klakson("Buubb Buubb");
                mobil2.TampilkanInfo();


                Console.ReadKey();


            }
        }
    }







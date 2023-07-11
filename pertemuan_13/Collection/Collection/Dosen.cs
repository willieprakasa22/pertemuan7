using System;
using System.Collections.Generic;
namespace Collection
{
	public class Dosen
	{
		public string Nik { get; set; }
		public string NamaDosen { get; set; }
	}

	public class Mahasiswa
	{
		public string Nim { get; set; }
		public string NamaMahasiswa { get; set; }
	}


    public class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "1234";
            mhs1.NamaMahasiswa = "Erik";

            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "1235";
            mhs2.NamaMahasiswa = "Wely";

            Dosen dosen1 = new Dosen();
            dosen1.Nik = "0043";
            dosen1.NamaDosen = "Jhono";

            Dosen dosen2 = new Dosen();
            dosen2.Nik = "0044";
            dosen2.NamaDosen = "Budi";


            //buat object list untuk Mahasiswa dan Dosen serta menambahkannya ke elemen list
            List<Mahasiswa> listMhs = new List<Mahasiswa>();
            listMhs.Add(mhs1);
            listMhs.Add(mhs2);

            List<Dosen> listDosen = new List<Dosen>();
            listDosen.Add(dosen1);
            listDosen.Add(dosen2);


            //melakukan itersi elemet list mahasiswa dan dosen
            Console.WriteLine("Nim    Nama");
            Console.WriteLine("===========");
            foreach (var mhs in listMhs)
            {
                Console.Write($"{mhs.Nim}   ");
                Console.WriteLine(mhs.NamaMahasiswa);
            }


            Console.WriteLine();
            Console.WriteLine("Nik    Nama");
            Console.WriteLine("===========");
            foreach (var dosen in listDosen)
            {
                Console.Write($"{dosen.Nik}   ");
                Console.WriteLine(dosen.NamaDosen);
            }


            Console.ReadLine();
        }
    }

}


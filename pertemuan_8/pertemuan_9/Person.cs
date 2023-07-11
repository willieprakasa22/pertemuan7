using System;
namespace pertemuan_9
{
	public class Person
	{
		

        public string Name { get; set; } 
        public int Age { get; set; }

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public void infoPerson()
		{
			Console.WriteLine("Nama saya {0}, dan umur saya {1}", Name, Age);
		}
    }


	public class Karyawan : Person
	{
		public string idKaryawan { get; set; }
        public string subjek { get; set; }

        public Karyawan(string Name, int Age) : base(Name, Age)
        {
            

        }

        public void infoPerson(string subjek, string idKaryawan)
        {
            this.idKaryawan = idKaryawan;
			this.subjek = subjek;
            Console.WriteLine("saya disini sebagai {0}", this.subjek);
            Console.WriteLine("Dengan id karyawan {0}", this.idKaryawan);
        }
    }
}


using pertemuan_9;

internal class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person("Willie", 19);
        person.infoPerson();
        

        Karyawan karyawan = new Karyawan("Sukoci", 22);
        karyawan.infoPerson();
        karyawan.infoPerson("pegawai", "22.11.4841");

        Console.ReadLine();
    }
}
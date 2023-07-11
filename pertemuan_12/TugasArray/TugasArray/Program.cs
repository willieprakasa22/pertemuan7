internal class Program
{
    public static void Main(string[] args)
    {
        TugasAray[] mhs = new TugasAray[3];
        mhs[0] = new TugasAray(1234, "Erik", 75);
        mhs[1] = new TugasAray(1235, "Wely", 80);
        mhs[2] = new TugasAray(1236, "Sony", 95);

        Console.WriteLine("No. Nim   Nama   Nilai");
        Console.WriteLine("======================");

        for (int i = 0; i < mhs.Length; i++)
        {
            Console.Write(i + 1);
            Console.Write(" ");
            Console.Write(mhs[i].Nim);
            Console.Write("   ");
            Console.Write(mhs[i].Name);
            Console.Write("   ");
            Console.WriteLine(mhs[i].Nilai);

        }

        Console.WriteLine();
        Console.ReadLine();

    }


    class TugasAray
    {
        public int Nim { get; set; }
        public string Name { get; set; }
        public int Nilai { get; set; }

        public TugasAray(int nim, string name, int nilai)
        {
            this.Nim = nim;
            this.Name = name;
            this.Nilai = nilai;
        }
    }
}
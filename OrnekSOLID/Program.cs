using System;

namespace OrnekSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            IVeriTabanı veriTabanı = new SqlDatabase();
            veriTabanı.SözcükEkle("Leonardo");
            veriTabanı.SözcükEkle("Ahmet");
            veriTabanı.SözcükEkle("Bilal");
            Console.WriteLine(veriTabanı.Arama("Leon"));
            Console.ReadLine();

        }
    }
}

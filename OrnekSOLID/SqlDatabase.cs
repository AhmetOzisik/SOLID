using System;
using System.Collections.Generic;
using System.Text;

namespace OrnekSOLID
{
    public class SqlDatabase : IVeriTabanı
    {
        private List<string> sözcüklist = new List<string>();
        public string Arama(string kelime)
        {
            foreach (var sözcük in sözcüklist)
            {
                if (sözcük.Contains(kelime))
                {
                    return sözcük;
                }
            }
            return "";
        }

        public void SözcükEkle(string sözcük)
        {
            if (sözcüklist.Count <= 20)
            {
                sözcüklist.Add(sözcük);
                Console.WriteLine(sözcük + " " + "isimli kelime sql veritabanınakaydedildi.");
            }
           
        }
    }
}

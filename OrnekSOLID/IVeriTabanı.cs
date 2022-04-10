using System;
using System.Collections.Generic;
using System.Text;

namespace OrnekSOLID
{
     public interface IVeriTabanı
    {
        string Arama(string kelime);
        void SözcükEkle(string sözcük);
    }
}

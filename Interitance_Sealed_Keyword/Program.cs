using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interitance_Sealed_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri  musteri = new Musteri();

            musteri.personel_id = 1;
            musteri.personel_ismi = "Pınar";
            musteri.personel_soyismi = "Altınkaya";
            musteri.personel_maas = 5000;

            musteri.personelBilgileri();

            Console.ReadLine();
        }
    }
}

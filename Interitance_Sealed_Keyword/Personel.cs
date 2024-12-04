using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interitance_Sealed_Keyword
{
    public class Personel  // public den sonra sealed yazsaydım musteri sınıfı miras alamazdı
    {
        public int personel_id {  get; set; }
        public string personel_ismi { get; set; }
        public string personel_soyismi { get; set; }    
        public int personel_maas {  get; set; }

        public void personelBilgileri()
        {
            Console.WriteLine("Personel id : " + personel_id);
            Console.WriteLine("Personel ismi : " + personel_ismi);
            Console.WriteLine("Personel soyisim : " + personel_soyismi);
            Console.WriteLine("Personel Maaş : " + personel_maas);

        }




    }
}

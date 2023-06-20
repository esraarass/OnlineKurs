using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineKurs
{
    public class Uye
    {
        public Guid ID { get; set; }
        public  Egitmen Egitmen {get;set;}
        public Kurs Kurs { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        



    }

    public class Kurs
    {
        public Guid ID { get; set; }

        public Sertifika Sertifika {get; set; }
        public string Ad { get; set; }
        public DateTime BaslangıcTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public string EgitmenAdi { get; set; }



    }

    public class Egitmen
    {
        public Guid ID { get; set; }

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Mail { get; set; }
        public string Cinsiyet { get; set; }



    }

    public class Sertifika
    {
        public Guid ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime VerilisTarihi { get; set; }
        



    }
}

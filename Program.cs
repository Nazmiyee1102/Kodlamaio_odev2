using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace Kodlamaio_odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Degiskenler();

            Vatandas vatandas = new Vatandas();

            SelamVer(isim: "Engin");
            SelamVer(isim: "Ahmet");
            SelamVer(isim: "Ayşe");
            SelamVer();

            int sonuc = Topla(6,58);

            //diziler(arrays)
            //string ogrenci1 = "Engin";
            //string ogrenci2 = "Kerem";
            //string ogrenci3 = "Berkay";

            //string[] ogrenciler = new string[3];
            //ogrenciler[0] = "Engin";
            //ogrenciler[1] = "Kerem";
            //ogrenciler[2] = "Berkay";
            
            //ogrenciler = new string[4];
            //ogrenciler[3] = "İlker";
            //for (int i = 0; i < ogrenciler.Length; i++)
            //{
            //    Console.WriteLine(ogrenciler[i]);
            //}

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            Person person1 = new Person();
            person1.FirstName = "ENGİN";
            person1.LastName = "DEMMİROĞ";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentity = 49240836994;


            Person person2 = new Person();
            person2.FirstName = "Murat";

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);//Adana

            //string arka planda referans tip olarak çalışır.

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add("Adana 1");
            foreach (var sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);







            Console.ReadLine();
        }

        static void SelamVer(string isim="isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + sonuc);
            return sonuc;
        }

        private static void Degiskenler()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Merhaba");

            string mesaj = "Selam";
            Console.WriteLine(mesaj);

            double tutar = 100000;
            Console.WriteLine(tutar * 1.18);

            //int sayi = 100;

            //bool girisYapmisMi = false;

            //string ad = "Engin";
            //string soyad = "Demiroğ";
            //int dogumYili = 1985;
            //long tcNo = 12345678910;
        }
    }

   
    public class Vatandas
    {
        public string Ad { get; set; }//pascal case kelimelerin ilk harfleri büyük
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}

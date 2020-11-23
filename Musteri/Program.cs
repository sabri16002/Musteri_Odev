using System;

namespace Musteri
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Musteri mus = new Musteri();
            Console.Write("Merhabalar Öğrenci iseniz 1'e değilseniz 2'ye basın :  ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                mus.ogrenci();
            }
            else if (a == 2)
            {
                mus.normal();
            }
        }
        class Musteri
        {
            string Ad, soyad,meslek; 
            int ogrno, yas, maas;
            public void ogrenci()
            {
                Console.Write("Adınızı Giriniz: ");
                Ad = Convert.ToString(Console.ReadLine());
                Console.Write("Soyadınızı Giriniz: ");
                soyad = Convert.ToString(Console.ReadLine());
                Console.Write("Öğrenci Numaranızı Girin: ");
                ogrno = Convert.ToInt32(Console.ReadLine());
                Console.Write("Yaşınız Girin: ");
                yas = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("\nAdınız: " + Ad + "\nSoyadınız: " + soyad + "\nÖğrenci Numaranız: " + ogrno + "\nYaşınız: " + yas);
            }
            public void normal()
            {
                Console.Write("Adınızı Giriniz: ");
                Ad = Convert.ToString(Console.ReadLine());
                Console.Write("Soyadınızı Giriniz: ");
                soyad = Convert.ToString(Console.ReadLine());
                Console.Write("Mesleğiniz Girin: ");
                meslek = Convert.ToString(Console.ReadLine());
                Console.Write("Yaşınız Girin: ");
                yas = Convert.ToInt32(Console.ReadLine());
                Console.Write("Maaşınız Girin: ");
                maas = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("\nAdınız: " + Ad + "\nSoyadınız: " + soyad + "\nMesleğiniz: " + meslek + "\nYaşınız: " + yas + "\nMaaşınız: " + maas);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)

        
        {
            #region Temel Dizi Bilgileri
            //DeğişkenTürü[] DiziAdı =new DeğişkenTürü[ElemanSayısı]

            // Dizide değer atanmayan index'in default değeri 0'dır.

            // string[] cities = {"Adana","Bitlis","Muğla"} ;
            #endregion

            #region Dizi Methodlar

            // Length -> Dizinin uzunluğu

            // Sort -> Büyükten küçüğe sıralama

            // Reverse -> Tamamen diziyi tersten sıralama

            // IndexOf -> Dizideki index'i bulur 
            // int index = Array.IndexOf(diziIsmi,"içindeBulunanEleman")

            // Max(),Min() -> Dizinin en büyük ve en küçük elemanalarını getirir.

            #endregion

            #region Kullanıcıdan Değer Alma

            // $ sembolü ile fade içerisinde parametresel ifadeler kullanabiliriz.

            string[] cities = new string[5];

            for (int i = 0; i < cities.Length; i++) 
            {
                Console.Write($"Lütfen {i + 1}. Şehri Giriniz");
                cities[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("---------------")

            for (int i = 0; i < cities.Length; i++) 
            {
                Console.WriteLine(cities[i]);
            }

            #endregion



            Console.Read();

        }
    }
}

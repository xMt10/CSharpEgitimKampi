using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Methods

            // () => methodlar mor renkte bir küp alırlar
            //Geriye Değer Döndürmeyen Metotlar
            //Customer --> Listele,ekle,sil,güncelle

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Ibrahim Kayalı")
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();

            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar
            //void CustomerCard(string name,string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);

            //}

            //CustomerCard("Ahmet", "Yıldırım");

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string StudentCard()
            //{
            //    string name = "Mahmut";
            //    string surname = "Turpçu";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = countryName + " " + capital + " " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke adı");
            //x = Console.ReadLine();

            //Console.Write("Başkent");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengi");
            //z= Console.ReadLine();

            //CountryCard(x, y, z);   

            #endregion

            string ExamResult(string student,int exam1,int exam2)
            {
                int result = (exam1 + exam2) / 2;

                if(result >= 50)
                {
                    return student + " isimli öğrenci sınıfı geçti. Ortalama: " + result;
                    
                }
                else
                {
                    return student +" isimli öğrenci sınıfı geçemedi. Ortalama: " + result;
                }
            }

            Console.WriteLine(ExamResult("Ali", 50, 60));
            Console.WriteLine(ExamResult("Ayşe", 20, 40));



            Console.Read();
        }
    }
}

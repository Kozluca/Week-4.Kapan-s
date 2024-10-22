using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Week_4.Kapanıs.BringProductName;

namespace Week_4.Kapanıs
{
    internal class Program
    {
        static void Main(string[] args)
        {
        başla:
            Console.WriteLine("Telefon Üretmek için 1'e  Bilgisayar üretmek için 2'ye basın.");
            int number = Convert.ToInt32(Console.ReadLine()); // kullanıcıdan bir 1 yada 2 olarak bir sayı aldık ve number a atadık
            if (number == 1)    // number 1 e eşitse çalışacak şartı yazdık
            {
                BaseMakine Phone = new Phone("samsung", "47852", "2025 Üretimi", DateTime.Now, "android"); // BaseMakine sınıfından Phone adında nesne türettik
                Phone.Display();   // Telefonun ortak özellikleri yazdırdık
                Phone.PhoneExtra();// Telefonun ekstra özellikleri yazdırdık
                Phone.ProductName(); // Telefonun adını yazdırdık

            }
            else if (number == 2) // number 2 ye eşitse çalışacak şartı yazdık
            {
                BaseMakine Laptop = new Laptop("Acer", "123547HG5", "Harika Laptop", DateTime.Now, "Windows", "Var", 3); // BaseMakine sınıfından Laptop adında nesne türettik
                Laptop.Display();                  // Laptopun ortak özellikleri yazdırdık
                Laptop.LaptopExtra();               // Laptopun ekstra özellikleri yazdırdık
                Laptop.ProductName();               // Laptopun adını yazdırdık
            }

            Console.WriteLine("Ürün Başarı ile üretildi.   Başka bir ürün üretmek ister misiniz?");
            string answer = Console.ReadLine();
            answer = answer.ToLower();
            if (answer == "evet")
                goto başla;  // cevap evet ise en basa gitmeyi sağladık.

            else if (answer == "hayır")
                Console.WriteLine("İyi Günler ..........");

            Console.ReadKey();


        }
    }
}

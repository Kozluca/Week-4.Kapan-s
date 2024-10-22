using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4.Kapanıs
{

    public abstract class BringProductName  // abstract sınıfı tanımladık
    {
        public abstract void ProductName();

        public class BaseMakine : BringProductName  // BaseMakine sınıfı Yukarıdaki sınıftan miras aldı
        {
            public override void ProductName()
            { }

            public string Name { get; set; }             // BaseMakine sınıfındaki propertyleri belirledik.
            public string SerialNumber { get; set; }
            public string Explanation { get; set; }
            public DateTime ProductTime = DateTime.Now;
            public string OperatingSystem { get; set; }
            public string TrLicence { get; set; }
            public string Bluetooth { get; set; }
            public int usb { get; set; }
            public void Display()  // BaseMakine sınıfından Ekran Cıktısı alacağımız method
            {
                Console.WriteLine("Ürünün adı: " + Name);
                Console.WriteLine("Ürünün seri numarası: " + SerialNumber);
                Console.WriteLine("Ürünün Açıklaması: " + Explanation);
                Console.WriteLine("Ürünün üretim tarihi: " + DateTime.Now);
                Console.WriteLine("Ürünün İşletim sistemi: " + OperatingSystem);
            }
            public virtual void PhoneExtra()   // Phone için virtual methoedu kullandık 
            { }
            public virtual void LaptopExtra()  // Laptop için  virtual methoedu kullandık 
            { }
        }
        public class Phone : BaseMakine // Phone sınıfı tanımladık ve BaseMakineden Miras aldık
        {
            public Phone(string name, string serialnumber, string explanation, DateTime productTime, string operationSystem)
            {
                Name = name;                        // Phone sınıfında propertiler belirlendi
                SerialNumber = serialnumber;
                Explanation = explanation;
                ProductTime = productTime;
                OperatingSystem = operationSystem;

            }
            public override void PhoneExtra()         // Phone sınıfında override (ezme) yaptık
            {
                Console.WriteLine("Ürünün TR Lisansı vardır.");
            }
            public override void ProductName()        // Phone sınıfında override (ezme) yaptık (abstract sınıfından)
            {
                Console.WriteLine("TELEFON ADI ............Benim Telefon");
            }

        }
        public class Laptop : BaseMakine // BaseMakine sınıfından miras alıp Laptop Sınıf oluşturduk
        {
            public Laptop(string name, string serialnumber, string explanation, DateTime productTime, string operationSystem, string bluetooth, int usb)
            {
                Name = name;                            // Propertyleri belirledik.
                SerialNumber = serialnumber;
                Explanation = explanation;
                ProductTime = productTime;
                OperatingSystem = operationSystem;
                Bluetooth = bluetooth;
                Usb = usb;
            }
            public int Usb        //Encapsulation yaptık
            {
                get
                { return usb; }
                set
                {
                    if (value != 2 && value != 4)
                    {
                        usb = -1;
                    }
                    else
                        usb = value;
                }
            }
            public override void LaptopExtra()        // Laptop sınıfında override (ezme) yaptık
            {
                Console.WriteLine("Ürünün Bluetoothu vardır");
                Console.WriteLine("Ürünün Usb sayısı: " + usb);
            }
            public override void ProductName()          // Laptop sınıfında override (ezme) yaptık (abstract sınıfından)
            {
                Console.WriteLine("LAPTOP ADI ................ Benim Laptop");
            }
        }
    }


}

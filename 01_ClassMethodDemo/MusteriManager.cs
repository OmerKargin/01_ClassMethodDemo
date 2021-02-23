using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ClassMethodDemo
{
    class MusteriManager
    {
        public void ADD(Musteri musteri)
        {
            Console.WriteLine("\n Id No: " + musteri.Id + " \n Adı: " + musteri.FirstName + " \n Soyadı: " + musteri.LastName + " \n  Cinsiyet : " +musteri.Gender + " \n TcNo: "  );
            Console.WriteLine("ID:{0} nolu Müşteri eklendi",musteri.Id);
        }

        public void Update(Musteri musteri)
        {
            Console.WriteLine("\n Id No: " + musteri.Id + " \n Adı: " + musteri.FirstName + " \n Soyadı: " + musteri.LastName + " \n  Cinsiyet : " + musteri.Gender + " \n TcNo: " + musteri.IdentityNo);

            Console.WriteLine("ID:{0} nolu Müşteri Güncellendi", musteri.Id);
        }

        public void Delete(Musteri musteri)
            
        {
            Console.WriteLine("\n Id No: " + musteri.Id + " \n Adı: " + musteri.FirstName + " \n Soyadı: " + musteri.LastName + " \n  Cinsiyet : " +musteri.Gender + " \n TcNo: " + musteri.IdentityNo);
            Console.WriteLine("ID:{0} nolu Müşteri silindi", musteri.Id);
        }
           
            
        public void Lİst(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                    
            Console.WriteLine("\n Id No: " + musteri.Id + " \n Adı: " + musteri.FirstName + " \n Soyadı: " + musteri.LastName + " \n  Cinsiyet : " +musteri.Gender + " \n TcNo: " +musteri.IdentityNo  );
            }
            Console.WriteLine("Müşteriler Listelendi");
        }

    }
       
    
}

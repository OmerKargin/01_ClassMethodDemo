using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.FirstName = "Omer";
            musteri1.LastName = "Kargın";
            musteri1.IdentityNo = "31212433315";
            musteri1.Gender = "Male";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.FirstName = "Ali";
            musteri2.LastName = "Veli";
            musteri2.IdentityNo = "1214526627";
            musteri2.Gender = "Male";

            Musteri musteri3 = new Musteri();
            musteri1.Id = 3;
            musteri1.FirstName = "Ayşe";
            musteri1.LastName = "Fatma";
            musteri1.IdentityNo = "31212421314";
            musteri1.Gender = "Female";

            Musteri[] must = new Musteri [] { musteri1, musteri2, musteri3 };

            MusteriManager must2 = new MusteriManager();

            must2.ADD(musteri1);
            Console.WriteLine("******************************************************************");
            must2.Delete(musteri2);
            Console.WriteLine("******************************************************************");
            must2.Update(musteri3);
            Console.WriteLine("******************************************************************");
            must2.Lİst(must);

            Console.ReadKey();
        }

    }/*Projeniz şunu yapacak.

    1- Bir bankada müşteri takibi yapmak istiyorsunuz.
    2- Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz. (Id, Ad, Soyad....)
    3- MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak Musteri ekleme, listeleme, silme gibi metotları simule ediniz.
    */
}

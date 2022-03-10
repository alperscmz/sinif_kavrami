using System;
namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[]args)
        {
          Calisan calisan1=new Calisan();
          calisan1.Ad="alper";
          calisan1.Soyad="saçmaözü";
          calisan1.No=123456;
          calisan1.departman="mühendis ofisi";

          calisan1.CalisanBilgileri();

        Console.WriteLine("******************");

          Calisan calisan2=new Calisan();
          calisan2.Ad="ali";
          calisan2.Soyad="veli";
          calisan2.No=4950;
          calisan2.departman="satın alma";

          calisan2.CalisanBilgileri();
        }
        class Calisan
        {
            public string Ad;
            public string Soyad;
            public int No;
            public string departman;

            public void CalisanBilgileri()
            {
                Console.WriteLine("Çalışan adı:{0}",Ad);
                Console.WriteLine("Çalışan soyadı:{0}",Soyad);
                Console.WriteLine("Çalışan numarası:{0}",No);
                Console.WriteLine("Çalışan departmanı:{0}",departman);

            }
        }
    }
}

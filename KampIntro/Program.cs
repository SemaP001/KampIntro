using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolanBugun = 7.55;


            if (dolarDun>dolanBugun)
            {
                Console.WriteLine("Azalış Butonu");

            }
            else if (dolarDun<dolanBugun)
            {
                Console.WriteLine("Artış Butonu");

            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }



            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu" );
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            
            
            Console.WriteLine(kategoriEtiketi);



        }
    }
}

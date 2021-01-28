using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kursu";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "python";
            string kurs5 = "C++";
            
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kursu", "Programlamaya başlangıç için temel kurs",
                "Java","python","C++"};
             
            

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu-footer");
        }
    }
}

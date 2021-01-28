﻿using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdı = "C++";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOranı = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOranı = 64;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOranı = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdı = "C++";
            kurs4.Egitmen = "Murat Kurtboğan";
            kurs4.IzlenmeOranı = 100;

            //Console.WriteLine(kurs1.KursAdı + " : " + kurs1.Egitmen);


            Kurs[] kurslar = new Kurs [] { kurs1, kurs2,kurs3,kurs4};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdı + " : " + kurs.Egitmen);
            }
            
            //Console.WriteLine("Hello World!");
        }
    }
    class Kurs
    {
        public string KursAdı { get; set; }
        public string Egitmen { get; set; }
        public int  IzlenmeOranı { get; set; }
    }
    
}

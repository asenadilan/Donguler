using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirme kampı";
            string kurs2 ="Yazılım başlangıç kursu ";
            string kurs3 = "java";

            string[] kurslar = new string[] { "Yazılım geliştirme kampı" , "Yazılım başlangıç kursu", "java"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

        }
    }
}

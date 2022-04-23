using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç Kursu", "Java" };

            for (int i = 0;  i < kurslar.Length; i++)
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

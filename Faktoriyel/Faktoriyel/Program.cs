using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktoriyel
{
    class Program
    {
        static void Main(string[] args)
        {
            baslangic:
            Console.Clear();
            int sayi;
            double sonuc = 1;
            SetConsoleDefault();
            Console.WriteLine("Girilen sayının faktöriyeli for döngüsü ile hesaplayan programdır.");


            soru:
            SetConsoleQuestion();
            Console.Write("Faktöriyeli hesaplanacak sayıyı giriniz: ");
            string readLine = Console.ReadLine();
            bool donusum = Int32.TryParse(readLine, out sayi);
            if (!donusum)
            {
                SetConsoleError();
                Console.WriteLine("Girilen değer sayı değildir. Lütfen bir sayı giriniz.");
                goto soru;
            }

            if (sayi <= 0)
            {
                SetConsoleError();
                Console.WriteLine($"Girilen sayı ({sayi}) 1'e eşit veya 1'den büyük olmak zorunda.");
                goto soru;
            }

            for (int i = 1; i <= sayi; i++)
            {
                sonuc *= i;
            }

            SetConsoleAnswer();
            Console.WriteLine($"Girilen sayının ({sayi}) hesaplanan faktöriyel değeri: {sonuc}");
            
            SetConsoleQuestion();
            Console.WriteLine("Başka sayıyı hesaplamak için (E/e) tuşuna basınız.");
            if (String.Equals(Console.ReadLine(), "E", StringComparison.CurrentCultureIgnoreCase))
            {
                goto baslangic;
            }
        }

        private static void SetConsoleError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void SetConsoleQuestion()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        static void SetConsoleAnswer()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
        }

         static  void SetConsoleDefault()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

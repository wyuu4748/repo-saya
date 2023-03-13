using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Äplikasi Calculator";
            //float a = 10; //deklarasi variabel a, dg nilai awal 10;
            //float b = 6; //deklarasi variabel a, dg nilai awal 10;

            int b, c;
            Console.WriteLine("Pilih menu kalkulator: ");
            Console.WriteLine("\n\n 1. Penambahan");
            Console.WriteLine("\n\n 1. Pengurangan");
            Console.WriteLine("\n\n 1. Perkalian");
            Console.WriteLine("\n\n 1. Pembagian");
            Console.Write("Input nomor menu [1..4]= ");
            int a = int.Parse(Console.ReadLine());

            int pilih = a;
            switch(pilih)
            {
                case 1:
                    Console.Write("Masukan nilai 1: ");
                    int b = int.Parse(Console.ReadLine);
                    Console.WriteLine("Hasil Penambahan " + c + " + " + d + " = " + Penambahan(a, b));
                    break;
                case 2:
                    Console.WriteLine("Hasil Pengurangan {0} - {1} = {2} ", a, b, Pengurangan(a, b)); 
                    break;
                case 3:
                    Console.WriteLine("Hasil Pengurangan {0} * {1} = {2} ", a, b, Perkalian(a, b));
                    break;
                case 4:
                    Console.WriteLine("Hasil Pengurangan {0} / {1} = {2} ", a, b, Pembagian(a, b));
                    break;
            }
            Console.ReadLine;
          
         
        }
        static float Penambahan(float a, float b)
        {
            return a + b;
        }
        static float Pengurangan(float a, float b)
        {
            return a - b;
        }
        static float Perkalian(float a, float b)
        {
            return a * b;
        }
        static float Pembagian(float a, float b)
        {
            return a / b;
        }
    }
}

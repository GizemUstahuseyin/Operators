using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._13_Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            int A=20, B = 10;
            
            ////Aritmatik operatörler
            Console.WriteLine(A + B); //topla
            Console.WriteLine(A - B); //çıkar
            Console.WriteLine(A * B); //çarp
            Console.WriteLine(A / B); //böl
            Console.WriteLine(A % B); //mod al

            //ilişkisel operatörler
            Console.WriteLine(A < B); //küçük mü
            Console.WriteLine(A > B); //büyük mü
            Console.WriteLine(A <= B); //küçük eşit mi
            Console.WriteLine(A >= B); //büyük eşit mi
            Console.WriteLine(A == B); //eşit mi
            Console.WriteLine(A != B); //eşit değil mi

            //Koşul Operatörleri
            Console.WriteLine(A < B || B>5); //A B'DEN BÜYÜK MÜ BÜYÜKSE B 5'TEN BÜYÜK MÜ, VEYA KOŞULU
            Console.WriteLine(A > B && A>5); //A B'DEN BÜYÜK MÜ VE A 5TEN BÜYÜK MÜ, VE KOŞULU
            
            Console.ReadKey();
        }
    }
}

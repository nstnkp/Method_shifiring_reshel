using ConsoleApp42;
using System;
using System.Collections;
using System.Linq;


namespace ConsoleApp42
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Шифрование по методу Ришелье");
            Console.Write("Введите сообщение: ");
            Shifr sh = new Shifr();
            sh.Shif();

        }
    }
}

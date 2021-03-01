using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[100];
            Console.WriteLine("Escriba nombres: ");
            for (int i = 0; i < 100; i++)
            {
                names[i] = Console.ReadLine();
                if (names[i] == "") break;
            }
            Console.WriteLine("Nombres: ");
            for(int k = 0; k < names.Length; k++)
            {
                if (names[k] == "") { break; }
                else { Console.WriteLine($"\t{names[k]}"); }
            }
        }
    }
}

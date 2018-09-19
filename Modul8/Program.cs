using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul8
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Введите размер массива: ");
            bool isParsed = int.TryParse(Console.ReadLine(), out size);
            if (!isParsed)
            {
                Console.WriteLine("Ошибка!");
            }
            else
            {
                Array array = new Array(size);
                //Console.WriteLine("\n");

                for (int i = 0; i < size; i++)
                {
                    array[i] = i;
                    Console.WriteLine(i + " = " + array[i]);
                }
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую границу массива: ");
            int firstLimit;
            while (!int.TryParse(Console.ReadLine(), out firstLimit))
            {
                Console.Clear();
                Console.Write("Введите первую границу массива: ");
            }

            Console.Write("Введите вторую границу массива: ");
            int secondLimit;
            while (!int.TryParse(Console.ReadLine(), out secondLimit))
            {
                Console.Clear();
                Console.Write("Введите вторую границу массива: ");
            }

            RangeOfArray array = new RangeOfArray(firstLimit, secondLimit);
            Random random = new Random();

            const int MIN_VALUE = 0;
            const int MAX_VALUE = 500;

            if (firstLimit < secondLimit)
            {
                for (int i = firstLimit; i < secondLimit; i++)
                {
                    array[i] = random.Next(MIN_VALUE, MAX_VALUE);
                    Console.Write("{0}\t", array[i]);
                }
            }
            else
            {
                for (int i = secondLimit; i < firstLimit; i++)
                {
                    array[i] = random.Next(MIN_VALUE, MAX_VALUE);
                    Console.Write("{0}\t", array[i]);
                }
            }
            Console.WriteLine();

            int index;
            while (true)
            {
                try
                {
                    Console.Write("Введите индекс элемента массива: ");
                    while (!int.TryParse(Console.ReadLine(), out index))
                    {
                        Console.Clear();

                        if (firstLimit < secondLimit)
                        {
                            for (int i = firstLimit; i < secondLimit; i++)
                            {
                                Console.Write("{0}\t", array[i]);
                            }
                        }
                        else
                        {
                            for (int i = secondLimit; i < firstLimit; i++)
                            {
                                Console.Write("{0}\t", array[i]);
                            }
                        }
                        Console.WriteLine();
                        Console.Write("Введите индекс элемента массива: ");
                    }
                    Console.WriteLine();

                    Console.WriteLine("Элемент массива с индексом {0} равен {1}", index, array[index]);
                }
                catch (IndexOutOfRangeException exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}

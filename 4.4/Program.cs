using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int m;
            Random rnd = new Random();
            while (true)
            {
                Console.WriteLine("Существует камера хранения с количеством ячеек N. ");
                Console.Write("Введите N: ");
                n = int.Parse(Console.ReadLine());
                int[] cellArray = new int[n];
                for (int x = 0; x < cellArray.Length; x++)
                {
                    cellArray[x] = rnd.Next(0, 11);
                    Console.Write(cellArray[x] + " ");
                }
                Console.WriteLine("\nПо ячейкам распределены вещи массой до 10 кг. Возможны пустые ячейки.");
                Console.WriteLine("Общая масса: " + cellArray.Sum() + "\n");
                Console.Write("Нужно изъять вещи из каждой M кратной ячейки.\nВведите М: ");
                m = int.Parse(Console.ReadLine());
                int extract = 0;
                for (int x = 1; x < cellArray.Length; x++)
                {

                    if (x % (m - 1) == 0)
                    {
                        cellArray[x] = 0;
                    }
                }
                Console.WriteLine("Оставшаяся масса: " + cellArray.Sum());
                Console.WriteLine();
            }
            Console.WriteLine("End");
            Console.ReadKey();
        }
    }
}

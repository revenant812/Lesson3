using System;

namespace Lesson3Work1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вывод элементов двумерного массива (одинаковой размерности в двух измерениях) по диагоналям.");
            Console.Write("Введите первый параметр массива: ");
            string m = Console.ReadLine();
            Console.Write("Введите второй параметр массива: ");
            string n = Console.ReadLine();
           
            if (string.IsNullOrEmpty(m) || string.IsNullOrEmpty(n))
            {
                Console.WriteLine("Вы не ввели параметр массива.");
            }
            else
            {
                int result1;
                int result2;
                bool isSuccess1 = int.TryParse(m, out result1);
                bool isSuccess2 = int.TryParse(n, out result2);
                if(isSuccess1 && isSuccess2)
                {
                    int m1 = Convert.ToInt32(m);
                    int n1 = Convert.ToInt32(n);
                    if (m1 == n1)
                    {
                        int[,] array = new int[m1, n1];
                        Random rnd = new Random();

                        Console.WriteLine("Вывод по диагонали с верхнего левого угла");
                        for (int x = 0; x < array.GetLength(0); x++)
                        {
                            for (int y = 0; y < array.GetLength(1); y++)
                            {
                                array[x, y] = rnd.Next(1, 8);

                                if (x == y)
                                {
                                    Console.WriteLine(array[x, y]);
                                }

                            }

                        }

                        Console.WriteLine("Вывод по диагонали с верхнего правого угла");
                        for (int x = 0; x < array.GetLength(0); x++)
                        {
                            for (int y = 0; y < array.GetLength(1); y++)
                            {
                                if (y == (array.GetLength(1) - x - 1))
                                {
                                    Console.WriteLine(array[x, y]);
                                }
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("Введите два одинаковых значения.");
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели строку. Введите цифровое значение.");
                }                
            }
            
                      
            /*
            Console.WriteLine(array[0, 0]);
            Console.WriteLine(array[0, 1]);
            Console.WriteLine(array[0, 2]);
            Console.WriteLine(array[0, 3]);
            Console.WriteLine(array[1, 0]);
            Console.WriteLine(array[1, 1]);
            Console.WriteLine(array[1, 2]);
            Console.WriteLine(array[1, 3]);
            Console.WriteLine(array[2, 0]);
            Console.WriteLine(array[2, 1]);
            Console.WriteLine(array[2, 2]);
            Console.WriteLine(array[2, 3]);
            Console.WriteLine(array[3, 0]);
            Console.WriteLine(array[3, 1]);
            Console.WriteLine(array[3, 2]);
            Console.WriteLine(array[3, 3]);
            */
        }
    }
}

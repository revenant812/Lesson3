using System;

namespace Lesson3Work4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа рисует два четырехпалубных корабля (один горизонтальный и один вертикальный).");
            Console.Write("Введите расположение первого корабля (горизонтального) по оси X (начальная точка): ");
            string coord1 = Console.ReadLine();
            int x = Convert.ToInt32(coord1);
            
            if(x > 6) //крайняя точка когда корабль влезает в массив 10x10
            {
                Console.WriteLine("Значение вне диапозона.");
                return;
            }
            
            Console.Write("Введите расположение первого корабля (горизонтального) по оси Y (начальная точка): ");
            string coord2 = Console.ReadLine();
            int y = Convert.ToInt32(coord2);
            
            if (y > 9)
            {
                Console.WriteLine("Значение вне диапозона.");
                return;
            }
            
            Console.Write("Введите расположение первого корабля (вертикального) по оси X (начальная точка): ");
            string coord3 = Console.ReadLine();
            int z = Convert.ToInt32(coord3);
            
            if (z > 9)
            {
                Console.WriteLine("Значение вне диапозона.");
                return;
            }
            Console.Write("Введите расположение первого корабля (вертикального) по оси Y (начальная точка): ");
            string coord4 = Console.ReadLine();
            int i = Convert.ToInt32(coord4);
             
            if (i > 6) //крайняя точка когда корабль влезает в массив 10x10
            {
                Console.WriteLine("Значение вне диапозона.");
                return;
            }

            char[,] array = new char[10, 10]; //создание массива 10x10 
            
            for (int m = 0; m < 10; m++)
            {
                Console.WriteLine();
                for (int n = 0; n < 10; n++)
                {
                    if (n >= x && n < (x + 4) && m == y)     //рисунок горизонтального корабля
                    {
                        array[m, n] = 'X';                    
                        Console.Write($"{array[m, n]}  ");
                    }
                    
                    else if (n == z && m >= i && m < (i + 4)) //рисунок вертикального корабля
                    {
                        array[m, n] = 'X';
                        Console.Write($"{array[m, n]}  ");
                    }
                    else
                    {
                        array[m, n] = 'O';  //Заполнение массива символами O
                        Console.Write($"{array[m, n]}  ");
                    }
                    
                }
            }                                                                             
            Console.WriteLine();
        }        
    }
}

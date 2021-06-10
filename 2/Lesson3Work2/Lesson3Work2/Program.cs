using System;

namespace Lesson3Work2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя контакта с заглавной буквы: ");
            string name = Console.ReadLine();
            //Console.WriteLine(name);
            bool status = false;
            string[,] array = new string[5, 2]
            {
                {
                    "Дмитрий",
                    "ivanov@test.net"
                },
                {
                    "Сергей",
                    "petrov@test.net"
                },
                {
                    "Иван",
                    "egorov@test.net"
                },
                {
                    "Егор",
                    "sidorov@test.net"
                },
                {
                    "Максим",
                    "filippov@test.net"
                }
            };

            //Console.WriteLine($"{array[4, 0]}");

            for(int i = 0; i < 5; i++)
            {                              
                if (array[i, 0] == name)
                {
                    string email = array[i, 1];
                    Console.WriteLine($"{name} присутствует в контактах и его email {email}");
                    status = true;
                    break;
                }       
                 
            }
            if(status != true)
            {
                Console.WriteLine($"{name} отсутствует в контактах");
            }
        }
    }
}

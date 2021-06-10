using System;

namespace Lesson3Work3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите любое слово: ");
            string str = Console.ReadLine();
            char[] CharArr = str.ToCharArray();
            //Console.WriteLine($"{CharArr[1]}");
            //Console.WriteLine(str[1]);
            char[] newArrChar = new char[CharArr.Length];
            for(int i = 0; i < CharArr.Length; i++)
            {
                newArrChar[i] = CharArr[(CharArr.Length - i - 1)];
            }
            Console.WriteLine(new string(newArrChar));

        }
    }
}

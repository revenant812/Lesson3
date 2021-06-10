using System;

namespace Lesson3Work5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку номер один: ");
            string str1 = Console.ReadLine();
            Console.Write("Введите строку номер два: ");
            string str2 = Console.ReadLine();
            string str3 = MaxSubStr(str1, str2);
            Console.WriteLine(str3);


            string MaxSubStr(string str1, string str2)
            {
                string result = string.Empty;
                string result1 = string.Empty;

                int count = 0;
                int count1 = 0;
                int count2 = 0;
                int count3 = 0;
                int count5 = 0;
                int count6 = 0;
                int count7 = 0;

                //Определение размера массива первой строки
                for (int y = 0; y < str1.Length; y++)
                {
                    for (int i = y; i < str1.Length; i++)
                    {
                        count = count + 1;
                        result = result + str1[i];                     
                    }
                    result = string.Empty;
                }

                //Создание массива всех вариантов первой строки
                string[] ArrayStr = new string[count];

                //Заполнение массива первой строки всеми комбинациями 
                for (int y = 0; y < str1.Length; y++)
                {
                    for (int i = y; i < str1.Length; i++)
                    {
                        result = result + str1[i];
                        ArrayStr[count1] = result;
                        count1 = count1 + 1;                        
                    }                    
                    result = string.Empty;
                }

                //Определение размера массива второй строки
                for (int y = 0; y < str2.Length; y++)
                {
                    for (int i = y; i < str2.Length; i++)
                    {
                        count2 = count2 + 1;
                        result1 = result1 + str2[i];
                    }
                    result1 = string.Empty;
                }

                //Создание массива всех вариантов второй строки
                string[] ArrayStr1 = new string[count2];

                //Заполнение массива второй строки всеми комбинациями 
                for (int y = 0; y < str2.Length; y++)
                {
                    for (int i = y; i < str2.Length; i++)
                    {
                        result1 = result1 + str2[i];
                        ArrayStr1[count3] = result1;
                        //Console.WriteLine(ArrayStr1[count3]);
                        count3 = count3 + 1;
                    }
                    result1 = string.Empty;
                }

                //нахождение количества совпадений в строках
                foreach (string f in ArrayStr)
                {
                    foreach (string a in ArrayStr1)
                    {
                        if (f == a)
                        {
                            int len = f.Length;
                            count5 = count5 + 1;                            
                        }
                    }
                }
                
                //Определение максимальной длины совпадений и заполнение массива
                int[] CountLen = new int[count5];
                foreach (string f in ArrayStr)
                {
                    foreach (string a in ArrayStr1)
                    {
                        if (f == a)
                        {
                            int len = f.Length;
                            CountLen[count6] = len;
                            count6 = count6 + 1;
                        }
                    }
                }

                //Заполнение массива общими элементами
                string[] CountString = new string[count5];
                foreach (string f in ArrayStr)
                {
                    foreach (string a in ArrayStr1)
                    {
                        if (f == a)
                        {
                            CountString[count7] = f;                            
                            count7 = count7 + 1;
                        }
                    }
                }                
                //Определение числа максимального количества совпадений и поиск индекса этого числа
                int maxValue = CountLen[0];
                for (int i = 0; i < CountLen.Length; i++)
                {
                    if (CountLen[i] > maxValue)
                    {
                        maxValue = CountLen[i];
                    }
                }
                int indexMax = Array.IndexOf(CountLen, maxValue);
                string otvet = CountString[indexMax];
                return otvet;
            }
        }   
         
        
    }
}

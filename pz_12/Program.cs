using System;

namespace pz_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //вариант 26
            string[][] test = new string[2][]; // создание массива для строк 
            Console.WriteLine("Введите первую строку: ");
            string a = Console.ReadLine();
            Console.WriteLine("Введите вторую строку: ");
            string b = Console.ReadLine();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(); // пустая строка для разделения
            test[0] = a.Split(" "); // разделение на подстроки первой строчки
            test[1] = b.Split(" "); // разделение на подстроки второй строчки
            for (int i = 0; i < test[0].Length; i++) // цикл для перебора массива строк
            {
                for (int d = 0; d < test[1].Length; d++)
                {
                    if (test[0][i] == test[1][d]) // проверка на равенство подстрок
                    {
                        b = b.Replace(test[1][d], ""); // замена повторяющегося слова на пустоту
                    }
                }
            }
            Console.WriteLine(b);
        }
    }
}

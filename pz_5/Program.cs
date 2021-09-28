using System;
using System.Threading;

namespace pz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Смирнов Иван 2пк2, вариант 26
            // 1 задание
            Console.WriteLine("Первое задание. Диапазон от 10 до 50, шаг равен 6.");
            Thread.Sleep(200);
            int i;
            for (i = 10; i <= 50; i=i+6)
            {
                Console.WriteLine($"Сейчас число равно = {i}");
                Thread.Sleep(200);
            }
            Console.WriteLine();
            // 2 задание
            Thread.Sleep(200);
            Console.WriteLine("Второе задание. Вывести 6 символов после 'м' включительно.");
            char a='м';
            for (int i1=0;i1<=6;i1++)
            {
                Console.Write($"{a} "); // сделал так ,чтобы был пробел между символами
                a++;
                Thread.Sleep(200);
            }
            Console.WriteLine();
            // 3 задание
            Console.WriteLine();
            Thread.Sleep(200);
            Console.WriteLine("Третье задание. Вывести 8 решеточек в 10 строчках.");
            for (int i2=0;i2<10;i2++)
            {
                for (int i3 = 0; i3 < 8; i3++)
                {
                    Console.Write('#');
                    Thread.Sleep(50);
                }
                Console.WriteLine();
            }
            Thread.Sleep(200);
            Console.WriteLine();
            // 4 задание
            Console.WriteLine("Четвёртое задание. Вывести числа из диапазона от 0 до 100 кратные 20.");
            for (int i4 = 0; i4 <= 100; i4++)
            {
                var c = i4 % 20;
                if (c == 0)
                {
                    Console.WriteLine(i4);
                    Thread.Sleep(200);
                }
            }
            Console.WriteLine();
            // 5 задание
            Console.WriteLine("Пятое задание. Довести разницу между двумя переменными до 10.");
            int j = 40;
            for (int i5 = 0; i5 < j + 10; i5++)
            {
                Console.WriteLine(i5 + " " + j);
                j--;
                Thread.Sleep(200);
            }
            Console.WriteLine();
            Console.WriteLine("Конец.");
        }
    }
}

using System;

namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); // создание класса рандом
            int[] A = new int[20]; // создание массива для будущего его заполнения
            for (int i =0; i < A.Length; i++) // цикл для заполнения массива рандомом
            {
                A[i] = rnd.Next(100); // ограничение рандомных чисел для массива до 100
                double result = (Math.Pow(A[i], 2)) / 2; // формула ваша
                Console.WriteLine($"При значении массива {(A[i])} = по формуле {result}"); // ну по сообщению консоли всё понятно
                // не понял как делать сортировку просто Sort все массивы в нули делает
            }
        }
    }
}

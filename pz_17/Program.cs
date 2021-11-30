using System;

namespace pz_17
{
    class Program
    {
        // Вариант 26
        static void Main(string[] args)
        {
            Console.WriteLine("Вводите трехзначные числа, разделяйте их пробелом: "); // ну всё понятно по надписи то
            string[] str = Console.ReadLine().Split(' '); // счёт строки и разделение её на цифры с помощью пробела!
            int[] nums = new int[str.Length]; // длина массива строки = длина массива из цифорок
            for (int i = 0; i < str.Length; i++) // цикл на заполнение массива с клавы
            {
                nums[i] = int.Parse(str[i]); // преобразование введённой строки для массива в значение для другого массива
            }
            Param(nums); // использование параметра снизу который

        }
        static int[] Param(int[] nums)
        {
            int[] count = new int[nums.Length]; // массив для суммы цифр числа
            for (int i = 0; i < nums.Length; i++) // цикл на прохождение по массиву
            {
                count[i] += nums[i] % 10 + (nums[i] % 100) / 10 + nums[i] / 100; // разделение числа на цифры и перемножение
                Console.WriteLine(count[i]); // вывод элемента массива то есть суммы цифр числа
            }
            return count; // возврат этого массива
        }
    }
}

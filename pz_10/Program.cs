using System;

namespace pz_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // массив создание
            string[][] A = new string[5][];
            string[] B = new string[5];
            string[] C = new string[5];
            string[] D = new string[5];
            Random rnd = new Random(); // рандом

            for (int i = 0; i < 5; i++) // цикл на рандом
            {

                A[i] = new string[rnd.Next(7, 15)]; // рандом
                Console.WriteLine("Введите любой символ"); //вывод
                int iter = 0;

                try
                {
                    char F = Convert.ToChar(Console.ReadLine());
                    int G = 0;
                    int E = 0;


                    for (int j = 0; j < A[i].Length; j++) //цикл на заполнение массива
                    {
                        //Строка получает первый символ из ввода пользователя
                        A[i][j] = Convert.ToString(F); // конвертирование в тип массива

                        //Заполнение строки рандомным количеством рандомных символов
                        for (int k = 0; k < rnd.Next(1, 10); k++)
                        {
                            char ch = Convert.ToChar(rnd.Next(1, 1000)); // рандом
                            A[i][j] += Convert.ToString(ch); // конвертирование в тип массива
                        }

                        //Определение строки максимального размера кодировки символов
                        int H = Max_str(A[i][j]);
                        if (G < H)
                        {
                            G = H;
                            C[i] = A[i][j];
                        }

                        //Определение строки с большим количеством символов
                        if (E < A[i][j].Length)
                        {
                            E = A[i][j].Length;
                            D[i] = A[i][j];
                            iter = j;
                        }

                        Console.Write(A[i][j] + "   ");

                    }
                    B[i] = A[i][A[i].Length - 1];

                }
                catch (System.FormatException e)
                {
                    Console.WriteLine(e.Message); // вывод сообщения
                }
                // выводы сообщений
                Console.WriteLine(); // пустота для красоты
                Console.WriteLine("Последний элемент:  " + B[i]);
                Console.WriteLine("Максимальный элемент:  " + C[i]);
                Console.WriteLine("Максимальная длина элемента:  " + D[i]);

                //меняем значеня
                string temp = A[i][0];
                A[i][0] = A[i][iter];
                A[i][iter] = temp;

                Console.WriteLine("Измененный массив:"); // вывод
                for (int j = 0; j < A[i].Length; j++)
                    Console.Write(A[i][j] + "   ");
                Console.WriteLine();

            }
        }

        public static int Max_str(string str)
        {
            int J = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                J += ch;
            }

            return J;
        }

    }
}
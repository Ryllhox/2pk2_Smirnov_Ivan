using System;

namespace pz_2_011
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Смирнов Иван 2пк2.\nВариант 12.\nНапишите программу, в которой через указатель реализуется подсчет количества спецсимволов в строке, введенной пользователем.\n");
            Console.WriteLine("Введите ваше слово:");
            string text = Console.ReadLine(); // ввод с клавиатуры ваших символов
            int symb = 0; // получается переменная которая для подсчёта кол-ва спец.символов
            unsafe // небезопасный код включаем действуем т.к. используем указатели и всё такое ну по лекции
            {
                fixed (char* c = text) // фиксируем указатель на переменной ура находим адрес
                {
                    for (int i = 0; i < text.Length; i++) // ну просто цикл на проходку по длине слова введённого
                    {
                        if (!Char.IsDigit(c[i]) && !Char.IsLetter(c[i])) // спец символы не относятся к обычным символам юникода ну по идее вот поэтому такая логика
                        {
                            symb++; // накидывает плюс 1 к общему числу спец.символов да
                        }
                    }
                }
            }
            Console.WriteLine(symb); // вывод в общем количество финальное итоговое наших нашего количества спец символов
        }
    }
}
﻿using System;

namespace pz_2_011
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Смирнов Иван 2пк2.\nВариант 12.\nНапишите программу, в которой через указатель реализуется подсчет количества спецсимволов в строке, введенной пользователем.\n");
            Console.WriteLine("Введите ваше слово:");
            string a = Console.ReadLine(); // ввод с клавиатуры ваших символов
            int b = 0; // получается переменная которая для подсчёта кол-ва спец.символов
            unsafe // небезопасный код включаем действуем
            {
                fixed (char* c = a) // фиксируем указатель ура
                {
                    for (int i = 0; i < a.Length; i++) // ну просто цикл на проходку по длине слова введённого
                    {
                        if (!Char.IsLetter(c[i]) && !Char.IsDigit(c[i])) // спец символы не относятся к обычным символам юникода ну по идее вот поэтому такая логика
                        {
                            b++; // накидывает плюс 1 к общему числу спец.символов да
                        }
                    }
                }
            }
            Console.WriteLine(b);
        }
    }
}
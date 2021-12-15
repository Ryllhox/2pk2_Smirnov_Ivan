using System;
using System.IO;
using System.Text.RegularExpressions;

namespace pz_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1:");
            string txt = "10-54-99;21-31-77;277-34-70;54-21-11"; // ну текст над которым манипуляции набор цифр точнее
            string[] ot = Regex.Split(txt, ";"); // разделение этой строки на массив разделённый знаком ;
            for (int i = 0; i < ot.Length; i++) // цикл
            {
                if (Regex.IsMatch(ot[i], @"\d{2}(-\d\d){2}") && ot[i].Length < 9) // 
                {
                    Match[] ogt = { Regex.Match(ot[i], @"\d{2}"), Regex.Match(ot[i], @"(-\d\d){2}") }; 
                    ot[i] = Regex.Replace(ot[i], ogt[0].ToString(), ogt[0].ToString() + "0"); // добавление нолика 
                    Console.WriteLine(ot[i]);
                }
                else Console.WriteLine(ot[i]); // вывод 
            }

            Console.WriteLine("Задание 2");
            string txt1 = "telephone_faxometr"; // текст над которым манипуляции будут как в примере
            Console.WriteLine("Старый текст " + txt1); // вывод до манипуляций
            txt1 = Regex.Replace(txt1, "tel|tel:", ""); // заменяет часть слова на ничто
            txt1 = Regex.Replace(txt1, "fax:|fax", ""); // заменяет эту часть слова на ничто
            Console.WriteLine("Новый текст " + txt1); // вывод нового текста

            Console.WriteLine("Задание 3");
            string result = ""; // пока пусто
            string[] n3 = File.ReadAllLines("C:\\Users\\NERne\\source\\repos\\2pk2_Smirnov_Ivan\\3.txt"); // ссылка на файл на моём компьютере
            for (int i = 0; i < n3.Length; i++) // цикл
            {
                if (Regex.IsMatch(n3[i], @"[1-31]-[1-12]-\d") || Regex.IsMatch(n3[i], @"[0-23]-[0-60]") || Regex.IsMatch(n3[i], @"[0-23]:[0-60]") || Regex.IsMatch(n3[i], @"\d{1,}")) result += n3[i] + "\n"; // проверка на одно из условий по заданию
            }
            Console.WriteLine(result); // вывод 

            Console.WriteLine("Задание 4");
            string[] n4 = File.ReadAllLines("C:\\Users\\NERne\\source\\repos\\2pk2_Smirnov_Ivan\\connects.log.txt"); // ссылка на файл на моём компьютере
            for (int i = 0; i < n4.Length; i++) // цикл
            {
                string ip = "";
                string date = "";
                ip += Regex.Match(n4[i], @"\d{1,}\.\d{1,}\.\d{1,}\.\d{1,}"); // определение цифр как айпи
                Console.WriteLine("IP:" + ip); // вывод "ip"
                date += Regex.Match(n4[i], @"29/[A-Z][a-z][a-z]/\d{4}"); Console.WriteLine("Date:" + date); // тоже самое только даты
            }
        }
    }
}
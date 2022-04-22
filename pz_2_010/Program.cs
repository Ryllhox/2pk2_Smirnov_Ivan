using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_2_010
    // Смирнов, Пустовалов, 8 вариант
{    struct NOTE
    {
        public string NAME;
        public long TELE;
        public string BDAY;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            NOTE[] BLOCKNOTE = new NOTE[2];
            for (int i = 0; i < BLOCKNOTE.Length; i++)
            {
                Console.WriteLine($"ЧЕЛОВЕК {i + 1} \n");
                Console.Write("Введите имя и фамилию: ");
                BLOCKNOTE[i].NAME = Console.ReadLine();
                Console.Write("Введите номер телефона: ");
                BLOCKNOTE[i].TELE = long.Parse(Console.ReadLine());
                Console.Write("Введите число дня рождения: ");
                BLOCKNOTE[i].BDAY = Console.ReadLine();
                Console.WriteLine("\n");
            }
            Console.WriteLine("введи крч ты понял");
            string name = Console.ReadLine();
            for (int i = 0; i < BLOCKNOTE.Length; i++)
            {
                if (name == BLOCKNOTE[i].NAME)
                {
                    Console.WriteLine($"Имя: {BLOCKNOTE[i].NAME}");
                    Console.WriteLine($"Номер телефона: {BLOCKNOTE[i].TELE}");
                    Console.WriteLine($"Дата рождения: {BLOCKNOTE[i].BDAY}");
                }
            }
            Console.ReadLine();
        }
    }
}
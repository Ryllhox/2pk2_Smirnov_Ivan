using System;

namespace pz_2_009
{
    // вариант 6 Смирнов
    public delegate void Delegate(); // наш делегат, хотел назвать его Афонасий , но слишком много буквы заняло бы

    class Human // это класс который и послужит основой для объектов наших
    {
        public string name; // да он простой а какой нужен хватит и этого
    }

    class Visitors // класс посетителей тут цикл будет да
    {
        public event Delegate onCount; // ооо а это событие ну по заданию значится
        public void Count()
        {
            Console.WriteLine("Введите сейчас число объектов сколько хотите заполнить");
            int n = int.Parse(Console.ReadLine()); // считывает ваше число и создаёт такой массив ну на такое количество
            Human[] NH = new Human[n]; // NH = new human, массивчик на объекты поситетелей
            for (int i=0;i<n;i++)
            {
                NH[i] = new Human(); // что-то начинается
                Console.WriteLine("Введите имя");
                NH[i].name = Console.ReadLine(); // теперь алгоритм понимает чё от него хотят и кидает то что ввели в имя объекта из класса
                if (n>=30) // ну честно немного забыл или не знаю про класс-контроллёр как его тут реализовать так что частично хотя бы так ну сделал 
                {
                    Console.WriteLine("Место не резиновое");
                    break; // ну наверное класс контролёр не просто так нужен и он бы ломал тут всё поэтому сломает эта штуковина
                }
                Console.WriteLine(i); // число приколюх созданных выводить то надо
            }    
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Visitors visit = new Visitors();
            visit.Count();
        }
    }
}

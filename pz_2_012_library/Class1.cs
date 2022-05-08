using System;

namespace pz_2_012_library
{
    class Day // класс "День"
    {
        public string DayName; // это если нужно словом название дня
        public byte NumberName; // если нужно просто число-дата
        public Day()
        {

        }
        public Day(string DayName)
        {
            this.DayName = DayName;
        }
        public Day(byte NumberName)
        {
            this.NumberName = NumberName;
        }
    }
    class Class // класс "Класс"
    {
        public string ClassName; // слово-название "класса", подразумеваю, что тут вводится, например, "Девятый".
        public byte ClassNumber; // число-номер "класса", подразумеваю, что тут вводится, например, "9".
        public Class()
        {

        }
        public Class(string ClassName)
        {
            this.ClassName = ClassName;
        }
        public Class(byte ClassNumber)
        {
            this.ClassNumber = ClassNumber;
        }
    }
    class Lesson // класс "Урок"
    {
        public string LessonQuantity; // слово-количество уроков, например, "Шесть".
        public byte LessonLot; // число-количество уроков, например, "6".
        public Lesson()
        {

        }
        public Lesson(string LessonQuantity)
        {
            this.LessonQuantity = LessonQuantity;
        }
        public Lesson(byte LessonLot)
        {
            this.LessonLot = LessonLot;
        }
    }
    class Conclusion // класс "Заключетльный", в котором хранится методы с перегрузкой
    {
        public void Output(string day, string clas, string lesson) // Метод принимает под каждый конструктор класса и выводит его, ну, тут каждый метод вручную писал конечно
        {
            Day obj = new Day(day);
            Class obj1 = new Class(clas);
            Lesson obj2 = new Lesson(lesson);
            Console.WriteLine(obj.DayName, obj1.ClassName, obj2.LessonQuantity);
        }
        public void Output(string day, string clas, byte lesson)
        {
            Day obj = new Day(day);
            Class obj1 = new Class(clas);
            Lesson obj2 = new Lesson(lesson);
            Console.WriteLine(obj.DayName, obj1.ClassName, obj2.LessonLot);
        }
        public void Output(string day, byte clas, string lesson)
        {
            Day obj = new Day(day);
            Class obj1 = new Class(clas);
            Lesson obj2 = new Lesson(lesson);
            Console.WriteLine(obj.DayName, obj1.ClassNumber, obj2.LessonQuantity);
        }
        public void Output(string day, byte clas, byte lesson)
        {
            Day obj = new Day(day);
            Class obj1 = new Class(clas);
            Lesson obj2 = new Lesson(lesson);
            Console.WriteLine(obj.DayName, obj1.ClassNumber, obj2.LessonLot);
        }

        // продолжать расписывать методы под каждую вариацию классов уже тяжко
    }
}

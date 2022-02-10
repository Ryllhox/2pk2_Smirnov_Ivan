using System;

namespace pz_2_003
{
    // Смирнов Иван 2пк2 вариант 5 (26)
    class Address
    {
        public string country; // ну здесь я создал поля из задания
        public string city;
        public string street;
        public int house;
        public int flat;

        public Address() // теперь идут конструкторы с разными наборами предустановок 
        {
            // пустой конструктор, выводит сообщение это, чтобы разъяснить ситуацию
            Console.WriteLine("Пусто. Если вы ищите человека, это означает, что он бездомный, возможно.\nЕсли вы ищите организацию, возможно, её не существует физически.");
        }
        public Address(string co, string ci, string st)
        { 
            // конструктор только со строковым типом переменных, без цифорок , то есть
            country = co;
            city = ci;
            street = st;
        }
        public Address(int ho, int fl)
        {
            // конструктор с числовым типом переменных, без буковок , то есть
            house = ho;
            flat = fl;
        }
        public Address(string st, int ho)
        {
            // констуктор стартер-пак, есть и улица, и номер дома, но больше ничего не известно
            street = st;
            house = ho;
        }
        public Address(string co, string ci, string st, int ho, int fl)
        {
            // конструктор полный пакет, здесь всё, что душа пожелает, точнее, задание, куда же без него
            country = co;
            city = ci;
            street = st;
            house = ho;
            flat = fl;
        }
        public void GetAddress()
        {
            // это метод, который выводит полный адрес объекта
            Console.WriteLine($"Страна: {country}\nГород: {city}\nУлица: {street}\nДом: {house}\nКвартира: {flat}\n");
        }
        static void Main(string[] args)
        {
            Address address1 = new Address(); // ну это объект на тест пустого конструктора
            address1.GetAddress();
            Address address2 = new Address("Россия", "Оренбург", "Чкалова"); // это объект на тест строкового конструктора
            address2.GetAddress();
            Address address3 = new Address(9, 2); // объект на тест числового конструктора
            address3.GetAddress();
            Address address4 = new Address("Чкалова", 9); // тест стартер-пак конструктора
            address4.GetAddress();
            Address address5 = new Address("Россия", "Оренбург", "Чкалова", 9, 2); // тест конструктора в полном обмундировании
            address5.GetAddress();
        }
    }
}

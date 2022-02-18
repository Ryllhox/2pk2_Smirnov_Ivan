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
        static int Counter; // подсчёт объектов
        static int Parity; // это для чётности домов
        public Address() // теперь идут конструкторы с разными наборами предустановок 
        {
            // пустой конструктор, выводит сообщение это, чтобы разъяснить ситуацию
            Console.WriteLine("Пусто. Если вы ищите человека, это означает, что он бездомный, возможно.\nЕсли вы ищите организацию, возможно, её не существует физически.");
            Counter++; // счёт
        }
        public Address(string co, string ci, string st)
        {
            // конструктор только со строковым типом переменных, без цифорок , то есть
            country = co;
            city = ci;
            street = st;
            Counter++; // счёт
        }
        public Address(int ho, int fl)
        {
            // конструктор с числовым типом переменных, без буковок , то есть
            house = ho;
            flat = fl;
            Counter++; // счёт
            if (house % 2 == 0) Parity++; // чётность
        }
        public Address(string st, int ho)
        {
            // констуктор стартер-пак, есть и улица, и номер дома, но больше ничего не известно
            street = st;
            house = ho;
            Counter++; // счёт
            if (house % 2 == 0) Parity++; // чётность
        }
        public Address(string co, string ci, string st, int ho, int fl)
        {
            // конструктор полный пакет, здесь всё, что душа пожелает, точнее, задание, куда же без него
            country = co;
            city = ci;
            street = st;
            house = ho;
            flat = fl;
            Counter++; // счёт
            if (house % 2 == 0) Parity++; // чётность
        }
        public virtual void GetAddress()
        {
            // это метод, который выводит полный адрес объекта
            Console.WriteLine($"Страна: {country}\nГород: {city}\nУлица: {street}\nДом: {house}\nКвартира: {flat}\n");
        }
        public static int GetCounter() // метод на подсчёт объектов
        {
            return Counter;
        }
        public static int GetParity() // метод на чётность (делимость на 2)
        {
            return Parity;
        }        
    }
    class RemoteAddress:Address
    {
        string reason; // ну стринг ризон строчка причина 
        public string Reason // это конструктор ризон то есть причина как требуется в задании
        {
            get => reason;
            set => reason = "Отсутствует один из главных определителей адреса - Улица и/или Дом";
        }
        public RemoteAddress(string co, string ci, string st, string rea)
        {
            country = co;
            city = ci;
            street = st;
            Reason = rea;
        }
        public RemoteAddress(int ho, int fl, string rea)
        {
            house = ho;
            flat = fl;
            Reason = rea;
        }
        public RemoteAddress(string co, int fl, string rea)
        {
            country = co;
            flat = fl;
            Reason = rea;
        }
        public override void GetAddress() // переопределяю метод
        {
            base.GetAddress();
            Console.Write($" {Reason}"); // и причину вывожу да вот
        }
    }
    class Programm
    {
        static void Main(string[] args) // метод мейн самый главный крутым себя возомнил он
        {
            Address address1 = new Address(); // ну это объект на тест пустого конструктора
            address1.GetAddress();
            Address address2 = new Address("Россия", "Оренбург", "Чкалова"); // это объект на тест строкового конструктора
            address2.GetAddress();
            Address address3 = new Address(8, 2); // объект на тест числового конструктора
            address3.GetAddress();
            Address address4 = new Address("Чкалова", 9); // тест стартер-пак конструктора
            address4.GetAddress();
            Address address5 = new Address("Россия", "Оренбург", "Чкалова", 9, 2); // тест конструктора в полном обмундировании
            address5.GetAddress();
            Console.WriteLine($"Всего объектов: {Address.GetCounter()}" + $"\nВсего четных домов: {Address.GetParity()}"); // вывод метода

            Console.WriteLine(); // пустая строчка разделяю

            RemoteAddress remoteaddress1 = new RemoteAddress("Россия", "Оренбург", "Чкалова", "Typical"); // ну тут объекты эти в дочернем классе
            remoteaddress1.GetAddress();
            RemoteAddress remoteaddress2 = new RemoteAddress(9, 10, "Как обычно");
            remoteaddress2.GetAddress();
            RemoteAddress remoteaddress3 = new RemoteAddress("Россия", 9, "Ну что ещё");
            remoteaddress3.GetAddress();

            // короче всё сломалось в выводе как бы нормально , но каша Х_Х
        }
    }
}

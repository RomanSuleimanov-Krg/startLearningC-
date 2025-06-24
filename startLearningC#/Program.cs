using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startLearningC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Выводит текст в ковывчках, в консоль
            Console.WriteLine("Hello World!!!");

            //Основные типы данных int | float | char | string | bool

            //Типы данных:
            //Целочисленные:
            //byte b;
            //sbyte sb;
            //short s;
            //ushort us;
            //int i;
            //uint ui;
            //long l;
            //ulong ul;
            //Числа с плавающей точкой:
            //float f;
            //double d;
            //Символьные типы данных:
            //char c;
            //Строковый тип:
            //string str;
            //Логический тип:
            //bool bl;

            //Инициализация переменной age
            //int age;
            //age = 27;
            //Console.WriteLine(age);

            //Работа с консолью
            string name;
            name = Console.ReadLine();
            Console.WriteLine(name);

            //Закрепление изученного
            //int health;
            //int armor;
            //int damage;

            //Console.Write("Введите кол-во здоровья: ");
            //health = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите кол-во брони: ");
            //armor = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите кол-во дамага: ");
            //damage = Convert.ToInt32(Console.ReadLine());

            //health = health - (damage - armor);

            //Console.WriteLine(health);

            //_______________________________________________

            //int food;
            //int money;
            //int foodUnitPrice;

            //foodUnitPrice = 10;

            //Console.WriteLine($"Еда по {foodUnitPrice} монет");
            //Console.Write("Сколько у вас голды?");
            //money = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Сколько вам нужно еда?");
            //food = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"У вас теперь {food} еды и осталось {money - foodUnitPrice * food}");

            //Логический оператор If
            int age;
            int needAge = 18;
            age = 15;
            if (age >= needAge)
            {
                Console.WriteLine("Всё норм");
            }

            else
            {
                Console.WriteLine("Ты слишком молод");
            }
        }
    }
}

﻿using System;
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
            //string name;
            //name = Console.ReadLine();
            //Console.WriteLine(name);

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
            //int age;
            //int needAge = 18;
            //age = 15;
            //if (age >= needAge)
            //{
            //    Console.WriteLine("Всё норм");
            //}

            //else
            //{
            //    Console.WriteLine("Ты слишком молод");
            //}

            //Логические операторы И и ИЛИ
            //И = &&

            //ИЛИ = ||

            //int money = 200;
            //int level = 5;

            //if (money >= 500 || level > 9)
            //{
            //    Console.WriteLine("Ты принят в гильдию!!!");
            //}
            //else
            //{
            //    Console.WriteLine("Вы слишком слабы для нашей гильдии!!!");
            //}

            //string dayOfWeek;
            //dayOfWeek = Console.ReadLine();

            //switch (dayOfWeek)
            //{
            //    case "понедельник":
            //        Console.WriteLine("go to the cinema");
            //        break;
            //    case "вторник":
            //        Console.WriteLine("Go out");
            //        break;
            //    default:
            //        {
            //            Console.WriteLine("Ошибочка!");
            //            break;
            //        }
            //}

            //Условные операторы на примере

            //string password;
            //string userInput;

            //password = "123qwe";
            //userInput = Console.ReadLine();

            //if (userInput == password)
            //{
            //    Console.WriteLine("Пароль верный");
            //}
            //else
            //{
            //    Console.WriteLine("Неверный пароль");
            //}

            //Обменник валюты со switch

            //float rubInWallet, usdInWallet;
            //string desiredOperation;
            //float rubToUsd = 64, usdToRub = 66;
            //float exchangeCurrency;

            //Console.Write("Сколько у вас рублей на балансе? : ");
            //rubInWallet = Convert.ToSingle(Console.ReadLine());
            //Console.Write("Сколько у вас долларов на балансе? : ");
            //usdInWallet = Convert.ToSingle(Console.ReadLine());

            //Console.WriteLine("Выберите необходимую операцию: ");
            //Console.WriteLine("1 - Рубли на доллары");
            //Console.WriteLine("2 - Доллары на рубли");
            //Console.Write("Ваш выбор: ");
            //desiredOperation = Console.ReadLine();

            //switch (desiredOperation)
            //{
            //    case "1":
            //        Console.WriteLine("Обмен рублей на доллары");
            //        Console.WriteLine("Сколько вы хотите обменять?");
            //        exchangeCurrency = Convert.ToSingle(Console.ReadLine());
            //        if (rubInWallet > exchangeCurrency)
            //        {
            //            rubInWallet -= exchangeCurrency;
            //            usdInWallet += exchangeCurrency / rubToUsd;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Низя брат");
            //        }
            //        break;
                
            //    case "2":
            //        Console.WriteLine("Обмен долларов на рубли");
            //        Console.Write("Сколько вы хотите обменять?: ");
            //        exchangeCurrency = Convert.ToSingle(Console.ReadLine());
            //        if (usdInWallet >= exchangeCurrency)
            //        {
            //            usdInWallet -= exchangeCurrency;
            //            rubInWallet += exchangeCurrency * usdToRub;
            //        }

            //        else
            //        {
            //            Console.WriteLine("Низя брат");
            //        }
            //            break;
            //    default:
            //        Console.WriteLine("Ошибка бро");
            //        break;
                    
            //}
            //Console.WriteLine($"Ваш баланс: {rubInWallet} рублей и {usdInWallet} долларов.");
        }
    }
}



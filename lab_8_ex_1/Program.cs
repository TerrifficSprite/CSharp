using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using MyLibrary;

namespace lab_8_ex_1
{
    class Program
    {
        static Methods lib = new Methods();
        private static List<Delivery> getFromFile(string path)
        {
            List<Delivery> deliveries = new List<Delivery>();
            StreamReader reader;
            try
            {
                reader = File.OpenText(path);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] temp = line.Split(", ");
                    Delivery d = new Delivery(temp[0], temp[1], int.Parse(temp[2]),
                        int.Parse(temp[3]), int.Parse(temp[4]));
                    deliveries.Add(d);
                }
                reader.Close();
                return deliveries;
            }
            catch (Exception)
            {
            }
            return deliveries;
        }

        private static void writeToDatabase(string path, List<Delivery> deliveries)
        {
            StreamWriter streamWriter;
            streamWriter = File.CreateText(path + "database.txt");
            foreach (Delivery d in deliveries)
            {
                streamWriter.WriteLine(d);
            }
            streamWriter.Close();
        }
        private static Delivery EditByNum(Delivery delivery)
        {
            int localNum = lib.NumFromKeyboard("Яке поле хочете редагувати?\n" +
                                               "Назва - 1\n" +
                                               "Адреса - 2\n" +
                                               "Кiлькiсть спiвробiтникiв - 3\n" +
                                               "Кiлькiсть заказiв в день - 4\n" +
                                               "Середня зарплата - 5\n" +
                                               "Вийти - 6\n");
            Console.Write("Введiть нове значення: ");
            switch (localNum)
            {
                case 1:
                    delivery.Name = Console.ReadLine(); break;
                case 2:
                    delivery.Address = Console.ReadLine(); break;
                case 3:
                    delivery.Employees = lib.NumFromKeyboard(""); break;
                case 4: 
                    delivery.DeliversInDay = lib.NumFromKeyboard(""); break;
                case 5: 
                    delivery.AverageSalary = lib.NumFromKeyboard(""); break;
                case 6: break;
            }
            return delivery;
        }

        static void Main(string[] args)
        {
            bool breakFlag = false;
            List<Delivery> deliveries = new List<Delivery>();
            string path = "D:\\Coding\\C#\\ConsoleAppCSharp\\TSPP\\lab_8_ex_1\\";
            StreamReader streamReader = null;
            StreamWriter streamWriter = null;
            while (true)
            {
                // bool enterNew = false;
                Console.WriteLine("-------------------------------------------\n" +
                                  "\tМеню\n" +
                                  "Додати запис - 1\n" +
                                  "Редагувати запис - 2\n" +
                                  "Видалити запис - 3\n" +
                                  "Вiдсортувати й вивести записи - 4\n" +
                                  "Вийти - 5");
                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    int a;
                    Console.WriteLine("-------------------------------------------");
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Введiть назву служби доставки: ");
                            string name = Console.ReadLine();
                            Console.Write($"Введiть адресу служби доставки {name}: ");
                            string address = Console.ReadLine();
                            int employees =
                                lib.NumFromKeyboard($"Введiть кiлькiсть працiвникiв служби доставки {name}: ");
                            int deliversInDay =
                                lib.NumFromKeyboard($"Скiльки заказiв в день робить служба доставки {name}: ");
                            int averageSalary =
                                lib.NumFromKeyboard($"Середня зарплата в службi доставки {name}: ");
                            streamWriter = File.AppendText(path + "database.txt");
                            Delivery tempDelivery = new Delivery(name, address, employees, deliversInDay, averageSalary);
                            streamWriter.WriteLine(tempDelivery);
                            deliveries.Add(tempDelivery);
                            streamWriter.Close();
                            break;
                        case 2:
                            deliveries = getFromFile(path + "database.txt");
                            Console.WriteLine("Який запис хочете редагувати?");
                            a = 1;
                            for (int i = 0; i < deliveries.Count; i++)
                            {
                                a++;
                                Delivery d = deliveries[i];
                                Console.WriteLine($"{i+1} - {d.Name}, адреса: {d.Address}, кiлькiсть спiвробiтникiв: {d.Employees}," +
                                $" кiлькiсть заказiв в день: {d.DeliversInDay}, середня зарплата: {d.AverageSalary}");
                            }
                            Console.WriteLine($"{a} - Вийти");
                            int editChoice = lib.NumFromKeyboard("");
                            if(editChoice == a)
                                break;
                            deliveries[editChoice-1] = EditByNum(deliveries[editChoice-1]);
                            writeToDatabase(path, deliveries);
                            break;
                        case 3:
                            Console.WriteLine("Виберiть запис який хочете видалити");
                            a = 1;
                            deliveries = getFromFile(path + "database.txt");
                            for (int i = 0; i < deliveries.Count; i++)
                            {
                                a++;
                                Delivery d = deliveries[i];
                                Console.WriteLine($"{i+1} - {d.Name}, адреса: {d.Address}, кiлькiсть спiвробiтникiв: {d.Employees}," +
                                                  $" кiлькiсть заказiв в день: {d.DeliversInDay}, середня зарплата: {d.AverageSalary}");
                            }
                            Console.WriteLine($"{a} - Вийти");
                            int deleteChoice = lib.NumFromKeyboard("");
                            if(deleteChoice == a)
                                break;
                            deliveries.Remove(deliveries[deleteChoice - 1]);
                            writeToDatabase(path, deliveries);
                            Console.WriteLine("Запис успiшно видалено!");
                            break;
                        case 4:
                            deliveries = getFromFile(path + "database.txt");
                            int sort = lib.NumFromKeyboard("Як хочете сортувати список?\n" +
                                                           "Кiлькiсть спiвробiтникiв - 1\n" +
                                                           "Kiлькiсть заказiв в день - 2\n" +
                                                           "Середня зарплата - 3\n" +
                                                           "Назад - 4\n");
                            switch (sort)
                            {
                                case 1: 
                                    deliveries.Sort(new Delivery.SortByEmployees()); break;
                                case 2: 
                                    deliveries.Sort(new Delivery.SortByDeliversInDay()); break;
                                case 3:
                                    deliveries.Sort(new Delivery.SortByAverageSalary()); break;
                                default:
                                    continue;
                            }
                            for (int i = 0; i < deliveries.Count; i++)
                            {
                                Delivery d = deliveries[i];
                                Console.WriteLine($"{d.Name}, адреса: {d.Address}, кiлькiсть спiвробiтникiв: {d.Employees}," +
                                                  $" кiлькiсть заказiв в день: {d.DeliversInDay}, середня зарплата: {d.AverageSalary}");
                            }
                            break;
                        case 5:
                            breakFlag = true;
                            break;
                        default:
                            continue;
                    }
                    if(breakFlag)
                        break;
                }
                catch (Exception)
                {
                    Console.WriteLine("*****\nВведенi невiрнi данi!\n*****");
                    if(streamWriter != null)
                    streamWriter.Close();
                }
            }
        }
    }
}
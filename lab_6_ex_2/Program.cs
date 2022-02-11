using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using MyLibrary;

namespace lab_6_ex_2
{
    class Program
    {
        private static Methods lib = new Methods();

        static void Main(string[] args)
        {
            bool breakFlag = false;
            ArrayList exhibitonDays = new ArrayList();
            string path = "D:\\Coding\\C#\\ConsoleAppCSharp\\TSPP\\lab_5_ex_1\\database.txt";
            StreamWriter streamWriter = null;
            IIndividual exhibition = new Exhibition();
            while (true)
            {
                Console.WriteLine("-------------------------------------------\n" +
                                  "\tМеню\n" +
                                  "Додати запис - 1\n" +
                                  "Редагувати запис - 2\n" +
                                  "Видалити запис - 3\n" +
                                  "Вивести записи - 4\n" +
                                  "Результати iндивiдуального завдання - 5\n" +
                                  "Вийти - 6");
                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    int a;
                    Console.WriteLine("-------------------------------------------");
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Введiть назву виставки: ");
                            string name = Console.ReadLine();
                            Console.Write($"Введiть прiвище художника виставки {name}: ");
                            string artistName = Console.ReadLine();
                            Console.Write($"В який день буде проводитись виставка {name}? ");
                            string day = Console.ReadLine();
                            int visitersCount =
                                lib.NumFromKeyboard($"Введiть кiлькiсть вiдвiдувачiв виставки {name}: ");
                            Console.Write("Введiть коментар до виставки: ");
                            string comment = Console.ReadLine();
                            exhibitonDays = exhibition.ReadFromFile(path);
                            ExhibitionDay exhibitionDay = new ExhibitionDay(name, artistName, day, visitersCount, comment);
                            exhibitonDays.Add(exhibitionDay);
                            exhibition.WriteToDatabase(path, exhibitonDays);
                            break;
                        case 2:
                            exhibitonDays = exhibition.ReadFromFile(path);
                            Console.WriteLine("Який запис хочете редагувати?");
                            a = 1;
                            for (int i = 0; i < exhibitonDays.Count; i++)
                            {
                                a++;
                                ExhibitionDay d = (ExhibitionDay) exhibitonDays[i];
                                Console.WriteLine($"{i+1} - {d.ExhibitionName}, Художник: {d.ArtistLastname}, день: {d.Day}," +
                                $" кiлькiсть вiдвiдувачiв: {d.VisitersCount}, коментар: {d.Comment}");
                            }
                            Console.WriteLine($"{a} - Вийти");
                            int editChoice = lib.NumFromKeyboard("");
                            if(editChoice == a)
                                break;
                            exhibitonDays[editChoice-1] = exhibition.EditByNum((ExhibitionDay) exhibitonDays[editChoice-1]);
                            exhibition.WriteToDatabase(path, exhibitonDays);
                            break;
                        case 3:
                            Console.WriteLine("Виберiть запис який хочете видалити");
                            a = 1;
                            exhibitonDays = exhibition.ReadFromFile(path);
                            for (int i = 0; i < exhibitonDays.Count; i++)
                            {
                                a++;
                                ExhibitionDay d = (ExhibitionDay) exhibitonDays[i];
                                Console.WriteLine($"{i+1} - {d.ExhibitionName}, Художник: {d.ArtistLastname}, день: {d.Day}," +
                                                  $" кiлькiсть вiдвiдувачiв: {d.VisitersCount}, коментар: {d.Comment}");
                            }
                            Console.WriteLine($"{a} - Вийти");
                            int deleteChoice = lib.NumFromKeyboard("");
                            if(deleteChoice == a)
                                break;
                            exhibitonDays.Remove(exhibitonDays[deleteChoice - 1]);
                            exhibition.WriteToDatabase(path, exhibitonDays);
                            Console.WriteLine("Запис успiшно видалено!");
                            break;
                        case 4:
                            exhibitonDays = exhibition.ReadFromFile(path);
                            foreach (ExhibitionDay e in exhibitonDays)
                            {
                                Console.WriteLine($"{e.ExhibitionName}, Художник: {e.ArtistLastname}, день: {e.Day}," +
                                                  $" кiлькiсть вiдвiдувачiв: {e.VisitersCount}, коментар: {e.Comment}");
                            }
                            break;
                        case 5:
                            switch (lib.NumFromKeyboard("\tЩе одне меню\n" +
                                                        "Сумарна кiлькiсть вiдвiдувачiв - 1\n" +
                                                        "День з найменшою кiлькiстю вiдвiдувачiв - 2\n" +
                                                        "Коментарi по певному слову - 3\n" +
                                                        "Вийти - 4\n"))
                            {
                                case 1:
                                    exhibitonDays = exhibition.ReadFromFile(path);
                                    Console.WriteLine($"Сумарна кiлькiсть вiдвiдувачiв: {exhibition.AllVisiters(exhibitonDays)}");
                                    break;
                                case 2:
                                    exhibitonDays = exhibition.ReadFromFile(path);
                                    Console.WriteLine("День з найменшою кiлькiстю вiдвiдувачiв: " +
                                                      $"{exhibition.FindMinVisitersDay(exhibitonDays)}");
                                    break;
                                case 3:
                                    exhibitonDays = exhibition.ReadFromFile(path);
                                    Console.Write("Введiть ключове слово: ");
                                    string keyword = Console.ReadLine();
                                    List<ExhibitionDay> temp = exhibition.CommentsByKeyword(keyword, exhibitonDays);
                                    
                                    Console.WriteLine("Коментарi в яких присутнє слово " + keyword);
                                    foreach (ExhibitionDay e in temp)
                                        Console.WriteLine($"{e.ExhibitionName}, Художник: {e.ArtistLastname}, день: {e.Day}," +
                                                          $" кiлькiсть вiдвiдувачiв: {e.VisitersCount}, коментар: {e.Comment}");
                                    break;
                                case 4:
                                    break;
                                default:
                                    continue;
                            }

                            break;
                        case 6:
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
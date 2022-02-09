using System;
using System.Collections;
using System.Diagnostics;
using MyLibrary;

namespace lab_7_ex_1
{
    class Program
    {
        private static Methods lib = new Methods();
        static void Main(string[] args)
        {
            Organization[] organizationList =
            {
                new Organization("Органiзацiя 1", 20, 70.2f, 2000),
                new Organization("Органiзацiя 2", 5, 30.4f, 1900),
                new Organization("Органiзацiя 3", 8, 75.2f, 200),
                new Organization("Органiзацiя 4", 23, 40.7f, 800),
                new Organization("Органiзацiя 5", 6, 34.2f, 3100),
                new Organization("Органiзацiя 6", 54, 39.4f, 1400),
                new Organization("Органiзацiя 7", 7, 12.4f, 1700),
                new Organization("Органiзацiя 8", 34, 77.2f, 800),
                new Organization("Органiзацiя 9", 12, 79.3f, 1000),
                new Organization("Органiзацiя 10", 33, 48.2f, 4100),
            };
            Organisations organisations = new Organisations(organizationList);
            while (true)
            {
                bool enterNew = false;
                Console.WriteLine("-------------------------------------------\n" +
                                  "\t\tМеню\n" +
                                  "Вiдсортувати за кiлькiстю спiвробiтникiв - 1\n" +
                                  "Вiдсортувати за рейтингом успiшностi - 2\n" +
                                  "Додати нову органiзацiю - 3\n" +
                                  "Вийти - 4");
                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    Console.WriteLine("-------------------------------------------");
                    if (choice == 1)
                    {
                        Array.Sort(organisations.Organization);
                        foreach (Organization organization in organisations)
                        {
                            Console.WriteLine($"Кiлькiсть спiвробiтникiв в органiзацiї \"{organization.Name}\": {organization.Employees}");
                        }
                    }
                    else if (choice == 2)
                    {
                        Array.Sort(organisations.Organization, new Organisations.SortBySuccessRate());
                        foreach (Organization organization in organisations)
                        {
                            Console.WriteLine($"Успiшнiсть органiзацiї \"{organization.Name}\": {organization.SuccessRate}%");
                        }
                    }
                    else if (choice == 3)
                    {
                        Organization newOrganisation = new Organization();
                        try
                        {
                            Console.Write("Введiть назву нової органiзацiї: ");
                            newOrganisation.Name = Console.ReadLine();
                            newOrganisation.Employees = lib.NumFromKeyboard(
                                $"Введiть кiлькiсть спiвробiтникiв органiзацiї {newOrganisation.Name}: ");
                            Console.Write($"Введiть рейтинг успiшностi органiзацiї {newOrganisation.Name}: ");
                            newOrganisation.SuccessRate = Convert.ToSingle(Console.ReadLine());
                            newOrganisation.AverageSalary =
                                lib.NumFromKeyboard($"Введiть середню зарплату органiзацiї {newOrganisation.Name}: ");
                            Console.WriteLine("Органiзацiя успiшно добавлена!");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine("Органiзацiя не добавлена!");
                            continue;
                        }
                        Organization[] organizationTemp = new Organization[organisations.Organization.Length + 1];
                        for (int i = 0; i < organisations.Organization.Length; i++)
                        {
                            organizationTemp[i] = organisations.Organization[i];
                        }
                        organizationTemp[organizationTemp.Length - 1] = newOrganisation;
                        organisations.Organization = organizationTemp;
                    }
                    else if(choice == 4)
                        break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("*****\nВводити можна тiльки числа!\n*****");
                    continue;
                }
                /*** Початок програми ***/
                /*** Кінець програми ***/
            }
        }
    }
}
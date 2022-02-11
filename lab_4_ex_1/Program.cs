using System;
using MyLibrary;
namespace lab_4_ex_1
{
    public class Program
    {
        private static Methods lib = new Methods();
        private static void SortAndPrint(Enterprise[] enterprises)
        {
            Console.WriteLine("Вiдсортований масив: ");
            Array.Sort(enterprises);
            foreach (Enterprise enterprise in enterprises)
            {
                Console.WriteLine("Мiсяць: {0},  \tплан: {1}, фактичний випуск: {2}, вiдсоток виконання плану: {3}%",
                    enterprise.Month, enterprise.Plan, enterprise.Fact, enterprise.PercentDone);
            }
        }
        private static Enterprise[] AddNew(Enterprise[] enterprises)
        {
            Console.Write("Введiть мiсяць випуску продукцiї: ");
            string month = Console.ReadLine();
            bool exist = false;
            for (int i = 0; i < enterprises.Length; i++)
            {
                Enterprise enterprise = enterprises[i];
                if (month == enterprise.Month)
                {
                    exist = true;
                    enterprise.Plan = lib.NumFromKeyboard("Введiть план випуску продукцiї: ");
                    enterprise.Fact = lib.NumFromKeyboard("Введiть фактичний випуск продукцiї: ");
                    enterprise.CalculatePercentDone();
                    enterprises[i] = enterprise;
                    Console.WriteLine("Данi успiшно оновленi!");
                    break;
                }
            }
            try
            {
                if (!exist)
                    throw new Exception("Такого мiсяця не iснує!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return enterprises;
        }
        private static void PrintMinAndMax(Enterprise[] enterprises)
        {
            Array.Sort(enterprises);
            Console.WriteLine("Мiсяць з найменшим вiдсотком виконаного плану: {0} - {1}%", 
                enterprises[0].Month, enterprises[0].PercentDone);
            Console.WriteLine("Мiсяць з найбiльшим вiдсотком виконаного плану: {0} - {1}%", 
                enterprises[11].Month, enterprises[11].PercentDone);
        }
        static void Main(string[] args)
        {
            Enterprise[] enterprises = {
                new Enterprise("Сiчень", 1, 8),
                new Enterprise("Лютий", 4, 2),
                new Enterprise("Березень", 5, 5),
                new Enterprise("Квiтень", 2, 5),
                new Enterprise("Травень", 1, 6),
                new Enterprise("Червень", 3, 2),
                new Enterprise("Липень", 1, 6),
                new Enterprise("Серпень", 7, 8),
                new Enterprise("Вересень", 1, 6),
                new Enterprise("Жовтень", 4, 9),
                new Enterprise("Листопад", 2, 3),
                new Enterprise("Грудень", 7, 12)
            };
            while (true)
            {
                bool enterNew = false;
                Console.WriteLine("-------------------------------------------\n" +
                                  "Оновити данi, чи працювати з iснуючими?\n" +
                                  "Оновити - 1\n" +
                                  "Працювати з iснуючими - 2\n" +
                                  "Вийти - 3");
                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                        enterNew = true;
                    else if(choice == 3)
                        break;
                    else if(choice != 2)
                        continue;
                    Console.WriteLine("-------------------------------------------");
                }
                catch (FormatException)
                {
                    Console.WriteLine("*****\nВводити можна тiльки числа!\n*****");
                    continue;
                }
                /*** Початок програми ***/
                if (enterNew)
                    enterprises = AddNew(enterprises);
                else
                {
                    SortAndPrint(enterprises);
                    PrintMinAndMax(enterprises);
                }
                /*** Кінець програми ***/
            }
        }
    }
}
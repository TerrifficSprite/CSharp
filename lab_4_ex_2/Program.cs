using System;

namespace lab_4_ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                bool enterNew = false;
                Console.WriteLine("-------------------------------------------\n" +
                                  "Ввести новi данi, чи працювати з iснуючими?\n" +
                                  "Ввести новi - 1\n" +
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
                
                /*** Кінець програми ***/
            }
        }
    }
}
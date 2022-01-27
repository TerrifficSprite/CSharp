using System;

namespace lab_2_ex1
{
    public class Program
    {
        public static string getStudentByLastname(String lastname)
        {
            switch (lastname)
            {
                case "Беліч":
                    return "Олександр";
                
                case "Григоращук":
                    return "Олександр";
                
                case "Ісопеску":
                   return "Михайло";
                
                case "Кожокар":
                 return   "Діана";
                
                case "Няйко":
                  return  "Андрій";
                
                case "Пепін":
                   return "Євгеній";
                
                case "Софроній":
                   return "Михайло";
                
                case "Топало":
                  return  "Василь";
                
                default:
                    return "Такого прiзвища у нашiй групi немає";
            }
        }
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("------------------------------------------\n" +
                                  "Перейти до обчислень чи вийти з програми?\n" +
                                  "Перейти до обчислень - 1\n" +
                                  "Вийти - 2");
                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 2)
                        break;
                    else if(choice != 1)
                        continue;
                    Console.WriteLine("------------------------------------------");
                }
                catch (FormatException e)
                {
                    Console.WriteLine("*****\nВводити можна тiльки числа!\n*****");
                    continue;
                }
                /*** Початок програми ***/
                Console.Write("Введiть прiзвище: ");
                getStudentByLastname(Console.ReadLine());
                /*** Кінець програми ***/
            }
        }
    }
}
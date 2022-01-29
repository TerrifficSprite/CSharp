using System;
namespace lab_2_ex1
{
    public class Program
    {
        public static string getStudentByLastname(String lastname)
        {
            switch (lastname)
            {
                case "Белiч":
                    return "Олександр";
                case "Григоращук":
                    return "Олександр";
                case "Iсопеску":
                   return "Михайло";
                case "Кожокар":
                 return   "Дiана";
                case "Няйко":
                  return  "Андрiй";
                case "Пепiн":
                   return "Євгенiй";
                case "Софронiй":
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
                Console.WriteLine(getStudentByLastname(Console.ReadLine()));
                /*** Кінець програми ***/
            }
        }
    }
}
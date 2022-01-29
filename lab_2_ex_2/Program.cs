using System;
namespace lab_2_ex_2
{
    public class Program
    {
        public static void CalculateWhileMethod(int min, int max, float step)
        {
            float cur = min;
            while (cur <= max)
            {
                Console.WriteLine(cur + "\t" + Math.Round(CalculateY(cur), 3));
                cur += step;
                cur = (float) Math.Round(cur, 3);
            }

            Console.WriteLine("Виконано циклом While");
        }
        public static void CalculateDoWhileMethod(int min, int max, float step)
        {
            float cur = min;
            do
            {
                Console.WriteLine(cur + "\t" + Math.Round(CalculateY(cur), 3));
                cur += step;
                cur = (float) Math.Round(cur, 3);
            } while (cur <= max);
            Console.WriteLine("Виконано циклом Do-While");
        }
        public static float CalculateY(float x)
        {
            return (float) Math.Round(
                Math.Pow(Math.E, Math.Sqrt(2 * x)) * (x * x), 3);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                bool whileChoice;
                Console.WriteLine("------------------------------------------\n" +
                                  "Обчислити циклом while, do-while чи вийти з програми?\n" +
                                  "while - 1\n" +
                                  "do-while - 2\n" +
                                  "Вийти - 3");
                
                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                        whileChoice = true;
                    else if (choice == 2)
                        whileChoice = false;
                    else if(choice == 3)
                        break;
                    else
                        continue;
                    Console.WriteLine("------------------------------------------");
                }
                catch (FormatException e)
                {
                    Console.WriteLine("*****\nВводити можна тiльки числа!\n*****");
                    continue;
                }
                /*** Початок програми ***/
                Console.WriteLine("Результати обчислення функцiї y=e^(sqrt(2x))*x^2 \n" +
                                  "на промiжку [3, 6] з кроком 0.05");
                Console.WriteLine("x\ty=e^(sqrt(2x))*x^2\n" +
                                  "----\t------------------");
                if(whileChoice)
                    CalculateWhileMethod(3, 6, (float) 0.05);
                else
                    CalculateDoWhileMethod(3, 6, (float) 0.05);
                /*** Кінець програми ***/
            }
        }
    }
}
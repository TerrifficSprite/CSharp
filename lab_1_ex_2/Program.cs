using System;
using System.Diagnostics;

namespace ex_2
{
    public class Program
    {
        // Довжина по відрізка по точкам
        public static float lengthByDotes(int x1, int y1, int x2, int y2)
        {
            return (float) Math.Sqrt(Math.Abs(Math.Pow(x2 - x1, 2) + 
                                              Math.Pow(y2 - y1, 2)));
        }

        // Получити точку з клавіатури
        public static int getDot(string which)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введiть точку " + which);
                    return int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("*****\nВводити можна тiльки числа!\n*****");
                }
            }
            
        }

        public static float perimeter(float AB, float BC, float AC)
        {
            return AB + BC + AC;
        }

        public static float square(float AB, float BC, float AC)
        {
            float p = (AB + BC + AC) / 2;
            return (float) Math.Sqrt(p * (p - AB) * (p - BC) * (p - AC));
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(lengthByDotes(1, 2, 3, 4));

            int[] a = {1, 2, 3, 4};
            Console.WriteLine(a.ToString());
            
            while (true)
            {
                Console.WriteLine("------------------------------------------" +
                                  "Перейти до обчислень чи вийти з програми?\n" +
                                  "Перейти до обчислень - 1\n" +
                                  "Вийти - 2\n" +
                                  "------------------------------------------");
                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 2)
                        break;
                    else if(choice != 1)
                        continue;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("*****\nВводити можна тiльки числа!\n*****\n");
                }

                // Получити точки
                int x1 = getDot("Ax");
                int y1 = getDot("Ay");
                int x2 = getDot("Bx");
                int y2 = getDot("By");
                int x3 = getDot("Cx");
                int y3 = getDot("Cy");

                float AB = lengthByDotes(x1, y1, x2, y2);
                float BC = lengthByDotes(x2, y2, x3, y3);
                float AC = lengthByDotes(x1, y1, x3, y3);

                float P = perimeter(AB, BC, AC);
                float S = square(AB, BC, AC);
                Console.WriteLine("Площа: " + S + "\nПериметр: " + P);
            }
        }
    }
}
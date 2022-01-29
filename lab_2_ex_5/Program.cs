using System;
using MyLibrary;

namespace lab_2_ex_5
{
    public class Program
    {
        private static Methods lib = new Methods();
        private static Random random = new Random();
        private const int Min = -100;
        private const int Max = 100;

        private static void print_arr(int[,] array, int m, int n)
        {
            Console.WriteLine("Готовий масив: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(j == 0)
                        Console.Write("[");
                    if (j == n - 1)
                    {
                        int temp = array[i, j];
                        if(temp.ToString().Length == 1)
                            Console.Write("  " + temp);
                        else if(temp.ToString().Length == 2)
                            Console.Write(" " + temp);
                        else 
                            Console.Write(temp);
                    }
                        
                    else
                        Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine("]");
            }
        }
        public static int[,] GetFromKeyboard(int m, int n)
        {
            int[,] array = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = lib.NumFromKeyboard("Введiть елемент [" + i + ", " + j + "]: ");
                }
                Console.WriteLine();
            }
            return array;
        }
        public static int[,] GetByRandom(int m, int n)
        {
            int[,] array = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(-100, 100);
                }
            }
            return array;
        }

        public static int GetElByCoords(int[,] arr, int x, int y)
        {
                    return arr[y-1, x-1];
        }
        public static string GetMaxOfTwo(int a, int b)
        {
            if (a > b)
                return "A(" + a + ") > B(" + b + ")";
            else if (b > a)
                return "A(" + a + ") < B(" + b + ")";
            else
                return "A(" + a + ") = B(" + b + ")";
        }
        
        static void Main(string[] args)
        {
            while (true)
            {
                bool keyboardChoice;
                Console.WriteLine("------------------------------------------\n" +
                                  "Перейти до обчислень чи вийти з програми?\n" +
                                  "Перейти до обчислень методом вводу з клавiатури - 1\n" +
                                  "Перейти до обчислень методом випадкових чисел - 2\n" +
                                  "Вийти - 3");
                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                        keyboardChoice = true;
                    else if (choice == 2)
                        keyboardChoice = false;
                    else if(choice == 3)
                        break;
                    else
                        continue;
                    Console.WriteLine("------------------------------------------");
                }
                catch (FormatException)
                {
                    Console.WriteLine("*****\nВводити можна тiльки числа!\n*****");
                    continue;
                }
                /*** Початок програми ***/
                ArrayLength:
                    int n = lib.NumFromKeyboard("Введiть довжину масиву: ");
                    int m = lib.NumFromKeyboard("Введiть висоту масиву: ");
                    if (n <= 0 || m <= 0)
                    {
                        Console.WriteLine("Довжина та висота не може бути меншою за 1");
                        goto ArrayLength;
                    }
                    
                    int[,] array = keyboardChoice ? GetFromKeyboard(m, n) : GetByRandom(m, n);
                    print_arr(array, m, n);
                    int a, b;
                    A:
                        try
                        {
                            a = GetElByCoords(array, 
                                lib.NumFromKeyboard("Введiть координату х точки A: "),
                                lib.NumFromKeyboard("Введiть координату y точки A: "));
                        }
                        catch(IndexOutOfRangeException)
                        {
                            Console.WriteLine("*****\nЕлемента з такими координатами не iснує!\n*****");
                            goto A;
                        }
                    B:    
                        try
                        {
                            b = GetElByCoords(array, 
                                lib.NumFromKeyboard("Введiть координату х точки B: "),
                                lib.NumFromKeyboard("Введiть координату y точки B: "));
                        }
                        catch
                        {
                            Console.WriteLine("*****\nЕлемента з такими координатами не iснує!\n*****");
                            goto B;
                        }
                        Console.WriteLine(GetMaxOfTwo(a, b));
                    
                    /*** Кінець програми ***/
            }
        }
    }
}
using System;
using MyLibrary;

namespace lab_2_ex_3
{
    public class Program
    {
        private static Methods lib = new Methods();
        private static Random random = new Random();
        private const int Min = -100;
        private const int Max = 100;
        
        public static int[] GetNumbersFromKeyboard(int length)
        {
            int[] numbers = new int[length];
            for (int i = 0; i < length; i++)
            {
                numbers[i] = lib.NumFromKeyboard("Введiть " + (i + 1) + " елемент масиву: ");
            }

            return numbers;
        }

        public static int[] GetRandomNumbers(int length)
        {
            int[] numbers = new int[length];
            for (int i = 0; i < length; i++)
            {
                numbers[i] = random.Next(Min, Max);
            }
            return numbers;
        }

        public static int SumBeetweenNegativeNums(int[] array)
        {
            int indexFirst = -1, indexSecond = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    if (indexFirst == -1)
                        indexFirst = i;
                    else
                    {
                        indexSecond = i;
                        break;
                    }
                }
            }

            if (indexFirst == -1)
            {
                Console.WriteLine("В масивi немає вiд'ємних елементiв!");
                return -2;
            }else if (indexSecond == -1)
            {
                Console.WriteLine("Вiд'ємний елемент тiльки один");
                return -1;
            }
            
            int sum = 0;
            for (int i = indexFirst+1; i < indexSecond; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        public static int GetMinNum(int[] array)
        {
            int min = array[0];
            foreach (int i in array)
            {
                if (i < min)
                    min = i;
            }

            return min;
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
                catch (FormatException e)
                {
                    Console.WriteLine("*****\nВводити можна тiльки числа!\n*****");
                    continue;
                }
                /*** Початок програми ***/
                ArrayLength:
                    int n = lib.NumFromKeyboard("Введiть довжину масиву: ");
                    if (n <= 0)
                    {
                        Console.WriteLine("Довжина не може бути меншою за 1");
                        goto ArrayLength;
                    }
                        
                    
                int[] array = keyboardChoice ? GetNumbersFromKeyboard(n) : GetRandomNumbers(n);
                Console.WriteLine("Готовий масив: [{0}]", string.Join(", ", array));
                Console.WriteLine("Мiнiмальний елемент масиву: " + GetMinNum(array));
                int sum = SumBeetweenNegativeNums(array);
                if(sum != -1 && sum != -2)
                    Console.WriteLine("Сума елементiв розташованих мiж першим i другим\n" +
                                  "вiд'ємними елементами: " + SumBeetweenNegativeNums(array));
                /*** Кінець програми ***/
            }
        }
    }
}
using System;
using System.Collections;
using System.IO;
using System.Text;

namespace lab_3_ex_3
{
    public class Program
    {
        public static char[] vowels = {'A', 'E', 'I', 'O', 'U', 'А', 'Е', 'Є', 'И', 'І', 'Ї', 'О', 'У', 'Ю', 'Я'};
        public static void DeleteWords(StreamReader reader, StreamWriter writer)
        {
            StringBuilder builder = new StringBuilder();
            string full_text = reader.ReadToEnd();
            Console.WriteLine("Початковий текст: " + full_text);
            string[] array = full_text.Split(" ");
            foreach (string word in array)
            {
                bool delete = false;
                int length = word.Length;
                if (length > 1)
                {
                    foreach (char vowel in vowels)
                    {
                        if (word.ToUpper()[length-2] == vowel)
                            delete = true;
                    }
                }
                if (!delete)
                    builder.Append(word + " ");
            }

            Console.WriteLine("Вiредагований текст: " + builder);
            writer.Write(builder.ToString());
            writer.Close();
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
                catch (FormatException)
                {
                    Console.WriteLine("*****\nВводити можна тiльки числа!\n*****");
                    continue;
                }
                /*** Початок програми ***/
                try
                {
                    string path = "D:\\Coding\\C#\\ConsoleAppCSharp\\TSPP\\lab_3_ex_3\\";
                    StreamReader streamReader = File.OpenText(path + "input.txt");
                    StreamWriter streamWriter = File.CreateText(path + "output.txt");
                    DeleteWords(streamReader, streamWriter);
                }
                catch (Exception)
                {
                    Console.WriteLine("Вказаного файлу не iснує!");
                    break;
                }
                /*** Кінець програми ***/
            }
        }
    }
}
using System;
using System.Collections;
using System.IO;
using System.Net.Mime;
using MyLibrary;

namespace lab_3_ex_2
{
    public class Program
    {
        public static Methods lib = new Methods();

        public static ArrayList TenWords(StreamReader reader)
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                string temp = reader.ReadLine();
                if (temp.Trim().ToLower()[0] == 's')
                    list.Add(temp.Trim());
            }
            return list;
        }
        
        public static ArrayList UnknownWords(StreamReader reader)
        {
            ArrayList list = new ArrayList();
            string temp;
            while((temp = reader.ReadLine()) != null)
            {
                if (temp.Trim().ToLower()[0] == 's')
                    list.Add(temp.Trim());
            }
            return list;
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
                    string path = "D:\\Coding\\C#\\ConsoleAppCSharp\\TSPP\\lab_3_ex_2\\";
                    StreamReader stream = File.OpenText(path + "file.txt");
                    StreamReader stream_ten = File.OpenText(path + "file_ten.txt");
                    Console.WriteLine("Виконання функцiї, якiй вiдомо що в файлi записано 10 слiв: ");
                    lib.PrintArrayList(TenWords(stream_ten));
                    Console.WriteLine("Виконання функцiї, якiй невiдомий розмiр файлу: ");
                    lib.PrintArrayList(UnknownWords(stream));
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
using System;
using System.Collections;
using System.IO;
using MyLibrary;
namespace lab_4_ex_2
{
    class Program
    {
        public static ArrayList ReadFromFile(string path)
        {
            ArrayList days = new ArrayList();
            string line;
            StreamReader reader = File.OpenText(path);
            while ((line = reader.ReadLine()) != null)
            {
                string[] s = line.Split(new string[]
                {
                    "Прiзвище: ", ", Iм'я: ", ", Поштова адреса: ", ", Номер телефону: ", ", Електронна пошта: "
                },5 , StringSplitOptions.RemoveEmptyEntries);
                days.Add(new Notebook(s[0], s[1], s[2], int.Parse(s[3]), s[4]));
            }
            reader.Close();
            return days;
        }
       
        public static Notebook EditByNum(Notebook notebook)
        {
            Methods lib = new Methods();
            int localNum = lib.NumFromKeyboard("Яке поле хочете редагувати?\n" +
                                               "Прiвище - 1\n" +
                                               "Iм'я - 2\n" +
                                               "Поштова адреса - 3\n" +
                                               "Номер телефону - 4\n" +
                                               "Електронна пошта - 5\n" +
                                               "Вийти - 6\n");
            Console.Write("Введiть нове значення: ");
            switch (localNum)
            {
                case 1:
                    notebook.Lastname = Console.ReadLine(); break;
                case 2:
                    notebook.Firstname = Console.ReadLine(); break;
                case 3:
                    notebook.PostAdress = Console.ReadLine(); break;
                case 4: 
                    notebook.PhoneNumber = lib.NumFromKeyboard(""); break;
                case 5: 
                    notebook.Email = Console.ReadLine(); break;
                case 6: break;
            }
            return notebook;
        }
        public static void WriteToDatabase(string path, ArrayList notebooks)
        {
            StreamWriter streamWriter;
            streamWriter = File.CreateText(path);
            foreach (Notebook n in notebooks)
            {
                streamWriter.WriteLine(n);
            }
            streamWriter.Close();
        }
        
        static void Main(string[] args)
        {
            string path = "D:\\Coding\\C#\\ConsoleAppCSharp\\TSPP\\lab_4_ex_2\\database.txt";
            Methods lib = new Methods();
            
            ArrayList notebooks = new ArrayList(new Notebook[]{});
            while (true)
            {
                bool enterNew = false;
                Console.WriteLine("-------------------------------------------\n" +
                                  "\tМеню\n" +
                                  "Додати запис - 1\n" +
                                  "Редагувати запис - 2\n" +
                                  "Видалити запис - 3\n" +
                                  "Вивести записи - 4\n" +
                                  "Пошук за електронною поштою - 5\n" +
                                  "Вийти - 6");
                try
                {
                    bool breakFlag = false;
                    int a;
                    int choice = int.Parse(Console.ReadLine());
                    Console.WriteLine("-------------------------------------------");
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Прiзвище: ");
                            string lastname = Console.ReadLine();
                            Console.Write("Iм'я: ");
                            string firstname = Console.ReadLine();
                            Console.Write("Поштова адреса: ");
                            string postAdress = Console.ReadLine();
                            int phoneNumber =
                                lib.NumFromKeyboard($"Номер телефону: ");
                            Console.Write("Електронна адреса: ");
                            string email = Console.ReadLine();
                            notebooks = ReadFromFile(path);
                            Notebook notebook = new Notebook(lastname, firstname, postAdress, phoneNumber, email);
                            notebooks.Add(notebook);
                            WriteToDatabase(path, notebooks);
                            break;
                        case 2:
                            notebooks = ReadFromFile(path);
                            Console.WriteLine("Який запис хочете редагувати?");
                            a = 1;
                            for (int i = 0; i < notebooks.Count; i++)
                            {
                                a++;
                                Notebook n = (Notebook) notebooks[i];
                                Console.WriteLine($"{i+1} - {n.Lastname} {n.Firstname}, поштова адреса: {n.PostAdress}," +
                                $" номер телефону: {n.PhoneNumber}, електронна адреса: {n.Email}");
                            }
                            Console.WriteLine($"{a} - Вийти");
                            int editChoice = lib.NumFromKeyboard("");
                            if(editChoice == a)
                                break;
                            notebooks[editChoice-1] = EditByNum((Notebook) notebooks[editChoice-1]);
                            WriteToDatabase(path, notebooks);
                            break;
                        case 3:
                            Console.WriteLine("Виберiть запис який хочете видалити");
                            a = 1;
                            notebooks = ReadFromFile(path);
                            for (int i = 0; i < notebooks.Count; i++)
                            {
                                a++;
                                Notebook n = (Notebook) notebooks[i];
                                Console.WriteLine($"{i+1} - {n.Lastname} {n.Firstname}, поштова адреса: {n.PostAdress}," +
                                                  $" номер телефону: {n.PhoneNumber}, електронна адреса: {n.Email}");
                            }
                            Console.WriteLine($"{a} - Вийти");
                            int deleteChoice = lib.NumFromKeyboard("");
                            if(deleteChoice == a)
                                break;
                            notebooks.Remove(notebooks[deleteChoice - 1]);
                            WriteToDatabase(path, notebooks);
                            Console.WriteLine("Запис успiшно видалено!");
                            break;
                        case 4:
                            notebooks = ReadFromFile(path);
                            notebooks.Sort();
                            foreach (Notebook n in notebooks)
                            {
                                Console.WriteLine($"{n.Lastname} {n.Firstname}, поштова адреса: {n.PostAdress}," +
                                                  $" номер телефону: {n.PhoneNumber}, електронна адреса: {n.Email}");
                            }
                            break;
                        case 5:
                            Console.Write("Введiть електронну пошту: ");
                            string localEmail = Console.ReadLine();
                            foreach (Notebook n in notebooks)
                            {
                                if (n.Email.Contains(localEmail))
                                {
                                    Console.WriteLine(n);
                                    break;
                                }
                            }
                            break;
                        case 6:
                            breakFlag = true;
                            break;
                        default:
                            continue;
                    }
                    if(breakFlag)
                        break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("*****\nВводити можна тiльки числа!\n*****");
                }
            }
        }
    }
}
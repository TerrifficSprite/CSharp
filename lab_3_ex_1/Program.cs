using System;
using System.Collections;
using MyLibrary;
namespace lab_3_ex_1
{
    public class Program
    {
        public static char[] vowels = {'A', 'E', 'I', 'O', 'U', 'А', 'Е', 'Є', 'И', 'І', 'Ї', 'О', 'У', 'Ю', 'Я'};
        public static char[] consonants = 
        {
            'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Z',
            'Б', 'В', 'Г', 'Ґ', 'Д', 'Ж', '3', 'Й', 'К', 'Л', 'М', 'Н', 'П', 'Р', 'С', 'Т', 'Ф', 'X', 'Ц', 'Ч', 'Ш', 'Щ'
        };
        private static Methods lib = new Methods();
        public static int CountVowelWords(string text)
        {
            int vowelsCount = 0;
            string[] new_str = text.Split(new Char[]{',', '.', ';', ':', ' ', '-'});
            // Console.WriteLine("Готовий масив: [{0}]", string.Join(", ", new_str));
            foreach (string word in new_str)
            {
                foreach (char letter in vowels)
                {
                    try
                    {
                        char l = word.Trim().ToString().ToUpper()[0];
                        if (l == letter)
                        {
                            vowelsCount++;
                            break;
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            return vowelsCount;
        }
        public static ArrayList PrintConsonantsWords(string text)
        {
            ArrayList arrayList = new ArrayList();
            string[] new_text = text.Split(new Char[]{',', '.', ';', ':', ' '});
            foreach (string word in new_text)
            {
                int consonantCount = 0;
                char[] temp = word.ToCharArray();
                foreach (char letter in temp)
                {
                    foreach (char consonant in consonants)
                    {
                        char mine = letter.ToString().ToUpper()[0];
                        if (consonant == mine)
                        {
                            consonantCount++;
                            break;
                        }
                    }
                }
                if (consonantCount % 2 != 0)
                    arrayList.Add(word.Trim());
            }
            return arrayList;
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
                Console.Write("Введiть рядок: ");
                string text = Console.ReadLine();
                Console.WriteLine("Кiлькiсть слiв, якi починаються з голосної: " + CountVowelWords(text));
                ArrayList list = PrintConsonantsWords(text);
                if (list.Count != 0)
                    Console.Write("Слова в яких непарна кiлькiсть приголосних букв: ");
                else
                    Console.WriteLine("В текстi немає слiв з непарною кiлькiстю приголосних букв!");
                lib.PrintArrayList(list);
                /*** Кінець програми ***/
            }
        }
    }
}
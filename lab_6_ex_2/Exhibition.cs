using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using MyLibrary;

namespace lab_6_ex_2
{
    public class Exhibition : IIndividual
    {
        private string exhibitionName;
        private string artistLastname;

        public Exhibition()
        {
            
        }

        public Exhibition(string exhibitionName, string artistLastname)
        {
            this.exhibitionName = exhibitionName;
            this.artistLastname = artistLastname;
        }
        // Кінець конструктори
        
        public ArrayList ReadFromFile(string path)
        {
            ArrayList days = new ArrayList();
            string line;
            StreamReader reader = File.OpenText(path);
            while ((line = reader.ReadLine()) != null)
            {
                string[] s = line.Split(new string[]
                {
                    "Виставка: ", ", Художник: ", ", День: ", ", Кiлькiсть вiдвiдувачiв: ", ", Коментар: "
                },5 , StringSplitOptions.RemoveEmptyEntries);
                days.Add(new ExhibitionDay(s[0], s[1], s[2], int.Parse(s[3]), s[4]));
            }
            reader.Close();
            return days;
        }
        
        public ExhibitionDay EditByNum(ExhibitionDay exhibitionDay)
        {
            Methods lib = new Methods();
            int localNum = lib.NumFromKeyboard("Яке поле хочете редагувати?\n" +
                                               "Назва виставки - 1\n" +
                                               "Прiзвище художника - 2\n" +
                                               "День виставки - 3\n" +
                                               "Кiлькiсть вiдвiдувачiв - 4\n" +
                                               "Коментар - 5\n" +
                                               "Вийти - 6\n");
            Console.Write("Введiть нове значення: ");
            switch (localNum)
            {
                case 1:
                    exhibitionDay.ExhibitionName = Console.ReadLine(); break;
                case 2:
                    exhibitionDay.ArtistLastname = Console.ReadLine(); break;
                case 3:
                    exhibitionDay.Day = Console.ReadLine(); break;
                case 4: 
                    exhibitionDay.VisitersCount = lib.NumFromKeyboard(""); break;
                case 5: 
                    exhibitionDay.Comment = Console.ReadLine(); break;
                case 6: break;
            }
            return exhibitionDay;
        }
        
        public void WriteToDatabase(string path, ArrayList exhibitionDays)
        {
            StreamWriter streamWriter;
            streamWriter = File.CreateText(path);
            foreach (ExhibitionDay d in exhibitionDays)
            {
                streamWriter.WriteLine(d);
            }
            streamWriter.Close();
        }

        public List<ExhibitionDay> CommentsByKeyword(string keyword, ArrayList exhibitionDays)
         {
             List<ExhibitionDay> comments = new List<ExhibitionDay>();
             foreach (ExhibitionDay day in exhibitionDays)
             {
                 if (day.Comment.ToLower().Contains(keyword.ToLower()))
                     comments.Add(day);
             }

             return comments;
         }

        public ExhibitionDay FindMinVisitersDay(ArrayList exhibitionDays)
        {
            ExhibitionDay counter = (ExhibitionDay)exhibitionDays[0];
            foreach (ExhibitionDay exhibitionDay in exhibitionDays)
            {
                if (exhibitionDay.VisitersCount < counter.VisitersCount)
                    counter = exhibitionDay;
            }
            return counter;
        }

        public int AllVisiters(ArrayList exhibitionDays)
        {
            int counter = 0;
            foreach (ExhibitionDay exhibitionDay in exhibitionDays)
                counter += exhibitionDay.VisitersCount;
            return counter;
        }
        
        public string ExhibitionName
        {
            get => exhibitionName;
            set => exhibitionName = value;
        }

        public string ArtistLastname
        {
            get => artistLastname;
            set => artistLastname = value;
        }
    }
}
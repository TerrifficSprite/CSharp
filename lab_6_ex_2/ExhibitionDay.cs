using System;

namespace lab_6_ex_2
{
    public class ExhibitionDay : Exhibition
    {
        private string day;
        private int visitersCount;
        private string comment;

        public ExhibitionDay()
        {
        }

        public ExhibitionDay(string exhibitionName, string artistLastname, 
            string day, int visitersCount, string comment) : base(exhibitionName, artistLastname)
        {
            Day = day;
            VisitersCount = visitersCount;
            Comment = comment;
        }
        
        public string Day
        {
            get => day;
            set
            {
                if (value != "Понедiлок" && value != "Вiвторок" && value != "Середа" &&
                    value != "Четвер" && value != "П'ятниця" && value != "Субота" &&
                    value != "Недiля")
                        throw new Exception("Такого дня тижня не iснує!");
                day = value;
            }
        }

        public int VisitersCount
        {
            get => visitersCount;
            set => visitersCount = value;
        }

        public string Comment
        {
            get => comment;
            set => comment = value;
        }

        public override string ToString()
        {
            return $"Виставка: {ExhibitionName}, Художник: {ArtistLastname}, " +
                   $"День: {Day}, Кiлькiсть вiдвiдувачiв: {VisitersCount}, Коментар: {Comment}";
        }
    }
}
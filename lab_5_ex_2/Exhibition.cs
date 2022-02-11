namespace lab_5_ex_2
{
    public abstract class Exhibition
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
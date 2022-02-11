using System.Collections;

namespace lab_6_ex_2;

public interface IIndividual
{
    public List<ExhibitionDay> CommentsByKeyword(string keyword, ArrayList exhibitionDays);
    
    public int AllVisiters(ArrayList exhibitionDays);

    public ExhibitionDay FindMinVisitersDay(ArrayList exhibitionDays);
    
    public ArrayList ReadFromFile(string path);

    public ExhibitionDay EditByNum(ExhibitionDay exhibitionDay);

    public void WriteToDatabase(string path, ArrayList exhibitionDays);
}
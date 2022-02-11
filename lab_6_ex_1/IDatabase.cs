using System.Collections;

namespace lab_6_ex_1;

public interface IDatabase
{
    public ArrayList ReadFromFile(string path);

    public Notebook EditByNum(Notebook notebook);

    public void WriteToDatabase(string path, ArrayList notebooks);
}
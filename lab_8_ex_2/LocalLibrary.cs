using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8_ex_2
{
    class LocalLibrary
    {
        public List<Delivery> getFromFile(string path)
        {
            List<Delivery> deliveries = new List<Delivery>();
            StreamReader reader;
            try
            {
                reader = File.OpenText(path);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] temp = line.Split(", ");
                    Delivery d = new Delivery(temp[0], temp[1], int.Parse(temp[2]),
                        int.Parse(temp[3]), int.Parse(temp[4]));
                    deliveries.Add(d);
                }
                reader.Close();
                return deliveries;
            }
            catch (Exception)
            {
            }
            return deliveries;
        }

        public void writeToDatabase(string path, List<Delivery> deliveries)
        {
            StreamWriter streamWriter;
            streamWriter = File.CreateText(path);
            foreach (Delivery d in deliveries)
            {
                streamWriter.WriteLine(d);
            }
            streamWriter.Close();
        }
    }
}

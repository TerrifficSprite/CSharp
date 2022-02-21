using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_8_ex_2
{
    public partial class PrintForm : Form
    {

        private static List<Delivery> getFromFile(string path)
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

        string path = "D:\\Coding\\C#\\ConsoleAppCSharp\\TSPP\\lab_8_ex_2\\database.txt";
        public PrintForm()
        {
            InitializeComponent();
            List<Delivery> deliveries = getFromFile(path);
            dataGridView1.Rows.Clear();
            for (int i = 0; i < deliveries.Count; i++)
            {
                Delivery d = deliveries[i];
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = d.Name;
                dataGridView1.Rows[i].Cells[1].Value = d.Address;
                dataGridView1.Rows[i].Cells[2].Value = d.Employees;
                dataGridView1.Rows[i].Cells[3].Value = d.DeliversInDay;
                dataGridView1.Rows[i].Cells[4].Value = d.AverageSalary;
            }
        }
    }
}

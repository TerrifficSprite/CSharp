using MyLibrary;
using System;
using System.Collections;
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
    public partial class DeleteForm : Form
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

        private static void writeToDatabase(string path, List<Delivery> deliveries)
        {
            StreamWriter streamWriter;
            streamWriter = File.CreateText(path);
            foreach (Delivery d in deliveries)
            {
                streamWriter.WriteLine(d);
            }
            streamWriter.Close();
        }

        string path = "D:\\Coding\\C#\\ConsoleAppCSharp\\TSPP\\lab_8_ex_2\\database.txt";
        Methods lib = new Methods();

        public DeleteForm()
        {
            InitializeComponent();
            label1.Hide();
            List<Delivery> deliveries = getFromFile(path);
            initDataGridView(deliveries);
        }

        private void initDataGridView(List<Delivery> deliveries)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < deliveries.Count; i++)
            {
                Delivery d = deliveries[i];
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Selected = false;
                dataGridView1.Rows[i].Cells[1].Value = d.Name;
                dataGridView1.Rows[i].Cells[2].Value = d.Address;
                dataGridView1.Rows[i].Cells[3].Value = d.Employees;
                dataGridView1.Rows[i].Cells[4].Value = d.DeliversInDay;
                dataGridView1.Rows[i].Cells[5].Value = d.AverageSalary;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Delivery> deliveries = getFromFile(path);
            ArrayList rows = new ArrayList();
            for(int i = 0; i < dataGridView1.RowCount; i++)
            {
                try
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "True")
                        rows.Add(i);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
            }
            rows.Reverse();
            for (int j = 0; j < rows.Count; j++)
            {
                try
                {
                    int i = (int) rows[j];
                    Delivery d = new Delivery();
                    d.Name = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    d.Address = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    d.Employees = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    d.DeliversInDay = int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    d.AverageSalary = int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                    deliveries.RemoveAt(i);
                    writeToDatabase(path, deliveries);
                    initDataGridView(deliveries);
                    label1.Show();
                }catch
                {
                    initDataGridView(deliveries);
                    break;
                }
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary;

namespace lab_8_ex_2
{
    public partial class EditForm : Form
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

        public EditForm()
        { 
            InitializeComponent();
            label1.Hide();
            List<Delivery> deliveries = getFromFile(path);
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

        private void button1_Click(object sender, EventArgs e)
        {
            List<Delivery> deliveries = new List<Delivery>();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                Delivery d = new Delivery();
                d.Name = dataGridView1.Rows[i].Cells[0].Value.ToString();
                d.Address = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    try {
                        d.Employees = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                        d.DeliversInDay = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                        d.AverageSalary = int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                        deliveries.Add(d);
                                        }
                catch (NullReferenceException ex)
                {
                    label1.Text = "Поля не можуть бути пустими!";
                    label1.Show();
                    break;
                }
                catch(FormatException ex)
                {
                    label1.Text = "Неможливо конвертувати значення в число!";
                    label1.Show();
                    break;
                }
            }
            writeToDatabase(path, deliveries);
            label1.Text = "Дані успішно оновлені!";
            label1.ForeColor = Color.Green;
            label1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

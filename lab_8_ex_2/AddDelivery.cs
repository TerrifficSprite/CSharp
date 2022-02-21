using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_8_ex_2
{
    public partial class AddDelivery : Form
    {
        string path = "D:\\Coding\\C#\\ConsoleAppCSharp\\TSPP\\lab_8_ex_2\\database.txt";

        public AddDelivery()
        {
            InitializeComponent();
            this.label2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LocalLibrary library = new LocalLibrary();
            List<Delivery> deliveries = library.getFromFile(path);
            string name = this.name.Text;
            string address = this.address.Text;
            try
            {
                int employees = int.Parse(this.employees.Text);
                int delivers = int.Parse(this.delivers.Text);
                int salary = int.Parse(this.salary.Text);
                deliveries.Add(new Delivery(name, address, employees, delivers, salary));
                library.writeToDatabase(path, deliveries);
                label2.Text = "Запис успішно добавлено!";
                label2.ForeColor = Color.Green;
                label2.Hide();
                label2.Show();
                this.name.Text = "";
                this.address.Text = "";
                this.employees.Text = "";
                this.delivers.Text = "";
                this.salary.Text = "";
            }
            catch
            {
                label2.Text = "Введені невірні дані!";
                label2.ForeColor = Color.Red;
                label2.Hide();
                label2.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

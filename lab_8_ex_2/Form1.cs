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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Додати запис
        private void button1_Click(object sender, EventArgs e)
        {
            AddDelivery newDelivery = new AddDelivery();
            newDelivery.Show();
        }

        // Редагувати запис
        private void button2_Click(object sender, EventArgs e)
        {
            EditForm form = new EditForm();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteForm form = new DeleteForm();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PrintForm form = new PrintForm();
            form.Show();
        }
    }
}

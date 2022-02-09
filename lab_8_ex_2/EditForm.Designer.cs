
namespace lab_8_ex_2
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Employees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliversInDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check,
            this.Employees,
            this.Name,
            this.Address,
            this.DeliversInDay,
            this.AverageSalary});
            this.dataGridView1.Location = new System.Drawing.Point(2, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(692, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Check
            // 
            this.Check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Check.HeaderText = "Вибір";
            this.Check.Name = "Check";
            this.Check.Width = 44;
            // 
            // Employees
            // 
            this.Employees.HeaderText = "Кількість співробітників";
            this.Employees.Name = "Employees";
            this.Employees.ReadOnly = true;
            this.Employees.Width = 95;
            // 
            // Name
            // 
            this.Name.HeaderText = "Назва";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Адреса";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 150;
            // 
            // DeliversInDay
            // 
            this.DeliversInDay.HeaderText = "Закази в день";
            this.DeliversInDay.Name = "DeliversInDay";
            this.DeliversInDay.ReadOnly = true;
            this.DeliversInDay.Width = 70;
            // 
            // AverageSalary
            // 
            this.AverageSalary.HeaderText = "Середня зарплата";
            this.AverageSalary.Name = "AverageSalary";
            this.AverageSalary.ReadOnly = true;
            this.AverageSalary.Width = 70;
            // 
            // EditForm
            // 
            this.ClientSize = new System.Drawing.Size(706, 261);
            this.Controls.Add(this.dataGridView1);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employees;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliversInDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageSalary;
    }
}
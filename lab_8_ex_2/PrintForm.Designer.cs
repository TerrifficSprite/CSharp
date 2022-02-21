
namespace lab_8_ex_2
{
    partial class PrintForm
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
            this.NameA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliversInDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameA,
            this.Address,
            this.Employees,
            this.DeliversInDay,
            this.AverageSalary});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(573, 318);
            this.dataGridView1.TabIndex = 1;
            // 
            // NameA
            // 
            this.NameA.HeaderText = "Назва";
            this.NameA.Name = "NameA";
            this.NameA.Width = 105;
            // 
            // Address
            // 
            this.Address.HeaderText = "Адреса";
            this.Address.Name = "Address";
            this.Address.Width = 130;
            // 
            // Employees
            // 
            this.Employees.HeaderText = "Кількість співробітників";
            this.Employees.Name = "Employees";
            this.Employees.Width = 120;
            // 
            // DeliversInDay
            // 
            this.DeliversInDay.HeaderText = "Закази в день";
            this.DeliversInDay.Name = "DeliversInDay";
            this.DeliversInDay.Width = 85;
            // 
            // AverageSalary
            // 
            this.AverageSalary.HeaderText = "Середня зарплата";
            this.AverageSalary.Name = "AverageSalary";
            this.AverageSalary.Width = 90;
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 319);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PrintForm";
            this.Text = "PrintForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employees;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliversInDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageSalary;
    }
}
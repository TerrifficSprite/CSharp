﻿
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
            this.NameA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliversInDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dataGridView1.Location = new System.Drawing.Point(2, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(573, 318);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.Address.Width = 160;
            // 
            // Employees
            // 
            this.Employees.HeaderText = "Кількість співробітників";
            this.Employees.Name = "Employees";
            this.Employees.Width = 105;
            // 
            // DeliversInDay
            // 
            this.DeliversInDay.HeaderText = "Закази в день";
            this.DeliversInDay.Name = "DeliversInDay";
            this.DeliversInDay.Width = 80;
            // 
            // AverageSalary
            // 
            this.AverageSalary.HeaderText = "Середня зарплата";
            this.AverageSalary.Name = "AverageSalary";
            this.AverageSalary.Width = 80;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(576, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Змінити дані";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(-2, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditForm
            // 
            this.ClientSize = new System.Drawing.Size(576, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "EditForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Редагувати записи";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employees;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliversInDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageSalary;
    }
}
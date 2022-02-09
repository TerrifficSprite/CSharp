
namespace lab_8_ex_2
{
    partial class AddDelivery
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
            this.name = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.employees = new System.Windows.Forms.TextBox();
            this.delivers = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(12, 44);
            this.name.Name = "name";
            this.name.PlaceholderText = "Назва нової служби доставки";
            this.name.Size = new System.Drawing.Size(528, 23);
            this.name.TabIndex = 0;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(12, 73);
            this.address.Name = "address";
            this.address.PlaceholderText = "Адреса";
            this.address.Size = new System.Drawing.Size(528, 23);
            this.address.TabIndex = 1;
            // 
            // employees
            // 
            this.employees.Location = new System.Drawing.Point(12, 102);
            this.employees.Name = "employees";
            this.employees.PlaceholderText = "Кількість співробітників";
            this.employees.Size = new System.Drawing.Size(528, 23);
            this.employees.TabIndex = 2;
            // 
            // delivers
            // 
            this.delivers.Location = new System.Drawing.Point(12, 131);
            this.delivers.Name = "delivers";
            this.delivers.PlaceholderText = "Кількість заказів в день";
            this.delivers.Size = new System.Drawing.Size(528, 23);
            this.delivers.TabIndex = 3;
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(12, 160);
            this.salary.Name = "salary";
            this.salary.PlaceholderText = "Середня зарплата";
            this.salary.Size = new System.Drawing.Size(528, 23);
            this.salary.TabIndex = 4;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(12, 202);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(528, 24);
            this.add.TabIndex = 5;
            this.add.Text = "Додати";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введіть дані нового запису:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("HP Simplified", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(528, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введені невірні дані!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 386);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.delivers);
            this.Controls.Add(this.employees);
            this.Controls.Add(this.address);
            this.Controls.Add(this.name);
            this.Name = "AddDelivery";
            this.Text = "AddDelivery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox employees;
        private System.Windows.Forms.TextBox delivers;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo
{
    public partial class FormExpensesAndIncome : Form
    {
        private ListBox expensesListBox;
        private Label label1;
        private Label label2;
        private ListBox income;
        private Label label3;
        private ListBox expenses;
        private Label label4;
        private ListBox incomeListBox;

        public FormExpensesAndIncome()
        {
            InitializeComponent();
        }

        private void FormExpensesAndIncome_Load(object sender, EventArgs e)
        {
            // Загрузка доходов и расходов
            LoadExpensesAndIncome();
        }

        private void LoadExpensesAndIncome()
        {
            //Загрузка доходов
            incomeListBox.Items.Clear();
            foreach (var ticket in _ticket)
            {
                incomeListBox.Items.Add($"Билет {ticket.Type} - {ticket.Price} руб.");
            }

            //Загрузка расходов
            expensesListBox.Items.Clear();
            foreach (var employee in employee)
            {
                expensesListBox.Items.Add($"Зарплата {employee.Name} - {employee.Salary} руб.");
            }
            foreach (var animal in _animals)
            {
                expensesListBox.Items.Add($"Содержание {animal.Name} - {animal.MaintenanceCost} руб.");
            }
        }

        private void addIncomeButton_Click(object sender, EventArgs e)
        {
            // Добавление дохода
            if (incomeListBox.Text != "")
            {
                incomeListBox.Items.Add(incomeListBox.Text);
                incomeListBox.Text = "";
            }
        }

        private void addExpensesButton_Click(object sender, EventArgs e)
        {
            // Добавление расхода
            if (expensesListBox.Text != "")
            {
                expensesListBox.Items.Add(expensesListBox.Text);
                expensesListBox.Text = "";
            }
        }

            private void InitializeComponent()
            {
            this.income = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.expenses = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // income
            // 
            this.income.FormattingEnabled = true;
            this.income.Location = new System.Drawing.Point(12, 37);
            this.income.Name = "income";
            this.income.Size = new System.Drawing.Size(120, 95);
            this.income.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "список доходов";
            // 
            // expenses
            // 
            this.expenses.FormattingEnabled = true;
            this.expenses.Location = new System.Drawing.Point(138, 37);
            this.expenses.Name = "expenses";
            this.expenses.Size = new System.Drawing.Size(120, 95);
            this.expenses.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "список расходов";
            // 
            // FormExpensesAndIncome
            // 
            this.ClientSize = new System.Drawing.Size(662, 332);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.expenses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.income);
            this.Name = "FormExpensesAndIncome";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

            }
        
    }
}

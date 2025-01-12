﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo
{
    public partial class EmployeeEdit : Form
    {
        private Employee _emoloyee;

        public Employee EditEmployee
        {
            get { return _emoloyee; }
            set
            {
                _emoloyee = value;
                if (value == null)
                    return;
                nameTextBox.Text = value.Name;
                ageMaskedTextBox.Text = value.Age.ToString();
                positionTextBox.Text = value.Position;
                salaryTextBox.Text = value.Salary.ToString();
            }
        }

        public EmployeeEdit()
        {
            InitializeComponent();
        }

        //кнопка accept, проверяет значение возраста
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Введите имя");
                nameTextBox.Focus();
                return;
            }

            decimal salary;
            int value;
            if (int.TryParse(ageMaskedTextBox.Text, out value))
            {
                if (value < 16 || value > 85)
                {
                    MessageBox.Show("Введите значение от 16 до 85");
                    ageMaskedTextBox.Focus();
                    return;
                }
            }

            if (!decimal.TryParse(salaryTextBox.Text, out salary))
            {
                MessageBox.Show("Введите корректное значение зарплаты");
                salaryTextBox.Focus();
                return;
            }

            this.DialogResult = DialogResult.OK;

            _emoloyee = new Employee(nameTextBox.Text,
                int.Parse(ageMaskedTextBox.Text),
                positionTextBox.Text,
                decimal.Parse(salaryTextBox.Text));
        }
    }
}

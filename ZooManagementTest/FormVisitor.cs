﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo
{
    public partial class FormVisitor : Form
    {
        private Visitor _visiter;

        public Visitor Visitor
        {
            get { return _visiter; }
            set { _visiter = value; }
        }

        public FormVisitor()
        {
            InitializeComponent();
            StartComponent();
        }

        private void StartComponent()
        {
            dateTimePicker1.Value = DateTime.Now;
            genderComboBox.DataSource = Enum.GetValues(typeof(Gender));
            countriesComboBox.DataSource = Enum.GetValues(typeof(Countries));
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(ageMaskedTextBox.Text, out value))
            {
                
            }

            if (string.IsNullOrEmpty(ageMaskedTextBox.Text))
            {
                MessageBox.Show("Не указан возраст");
                ageMaskedTextBox.Focus();
                return;
            }

            this.DialogResult = DialogResult.OK;
            _visiter = new Visitor(nameTextBox.Text, int.Parse(ageMaskedTextBox.Text),
               (Gender)Enum.Parse(typeof(Gender), genderComboBox.SelectedItem.ToString()),
               (Countries)Enum.Parse(typeof(Countries), countriesComboBox.SelectedItem.ToString()), dateTimePicker1.Value);
        }
    }
}

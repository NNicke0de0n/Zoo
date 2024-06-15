using System;
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
            ticketComboBox.DataSource = Enum.GetValues(typeof(TypeOfTicket));
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ageMaskedTextBox.Text))
            {
                MessageBox.Show("Не указан возраст");
                ageMaskedTextBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(basePriceTextBox.Text))
            {
                MessageBox.Show("Не указана стоимость билета");
                basePriceTextBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(priceMaskedTextBox.Text) ||
                int.Parse(ageMaskedTextBox.Text) >= 18 && ticketComboBox.SelectedItem.ToString() == nameof(TypeOfTicket.Childish))
            {
                MessageBox.Show("Уточните тип билета");
                priceMaskedTextBox.Focus();
                return;
            }

            this.DialogResult = DialogResult.OK;
            _visiter = new Visitor(nameTextBox.Text, int.Parse(ageMaskedTextBox.Text),
               (Gender)Enum.Parse(typeof(Gender), genderComboBox.SelectedItem.ToString()),
               (Countries)Enum.Parse(typeof(Countries), countriesComboBox.SelectedItem.ToString()), dateTimePicker1.Value,
               decimal.Parse(priceMaskedTextBox.Text));
        }

        private void ticketComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ticketComboBox.SelectedItem.ToString())
            {
                case nameof(TypeOfTicket.Basic):
                    priceMaskedTextBox.Text = basePriceTextBox.Text;
                    break;
                case nameof(TypeOfTicket.Childish):
                    if ((int.Parse(ageMaskedTextBox.Text) <= 7))
                    {
                        priceMaskedTextBox.Text = "0";
                    }
                    if (int.Parse(ageMaskedTextBox.Text) > 7 && int.Parse(ageMaskedTextBox.Text) < 18)
                    {
                        priceMaskedTextBox.Text = (decimal.Parse(basePriceTextBox.Text) * (decimal)0.5).ToString();
                    }
                    break;

            }
        }
    }
}

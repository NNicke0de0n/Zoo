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
    public partial class FormVisiter : Form
    {
        Visitor _visiter;
        public FormVisiter()
        {
            InitializeComponent();
        }

        private void StartComponent()
        {
            dateTimePicker1.Value = DateTime.Now;
            genderComboBox.DataSource = Enum.GetValues(typeof(Gender));

        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            _visiter = new Visitor(nameTextBox.Text, int.Parse(maskedTextBox1.Text), (Gender)Enum.Parse(typeof(Gender), genderComboBox.SelectedItem.ToString()), countryTextBox.Text, dateTimePicker1.Value);
        }
    }
}

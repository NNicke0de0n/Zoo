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
        public FormVisiter()
        {
            InitializeComponent();
        }

        private void StartComponent()
        {
            dateTimePicker1.Value = DateTime.Now;
            genderComboBox.DataSource = Enum.GetValues(typeof(Gender));
        }
    }
}

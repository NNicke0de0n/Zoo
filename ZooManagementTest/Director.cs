using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo
{
    public partial class Director : Form
    {
        Animal _animal;
        Employee _employee;
        Visitor _visitor;
        List<Visitor> _visitors = new List<Visitor>();
        List<Animal> _animals = new List<Animal>();
        List<Employee> _employees = new List<Employee>();

        public Director()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (choiceComboBox.SelectedItem != null)
            {
                if (choiceComboBox.Text == nameof(Employee))
                {
                    AddEmployee();
                }
                else if (choiceComboBox.Text == nameof(Visitor))
                {
                    AddVisiter();
                }
                else
                {
                    AddAnimal();
                }
            }
        }

        void AddEmployee()
        {
            EmployeeEdit employeeEdit = new EmployeeEdit();
            this.Hide();
            employeeEdit.ShowDialog();
            this.Show();
            if (employeeEdit.DialogResult == DialogResult.OK)
            {
                _employee = employeeEdit.EditEmployee;
                _employees.Add(_employee);
                employeeListBox.Items.Add(ShowInList(_employee));
            }
        }

        private void AddAnimal()
        {
            AnimalEdit animalEdit = new AnimalEdit();
            this.Hide();
            animalEdit.ShowDialog();
            this.Show();
            if (animalEdit.DialogResult == DialogResult.OK)
            {
                _animal = animalEdit.EditAnimal;
                _animals.Add(_animal);
                animalListBox.Items.Add(ShowInList(_animal));
            }
        }

        private void removeAnimal_Click(object sender, EventArgs e)
        {
            if (animalListBox.SelectedItem != null)
            {
                _animals.RemoveAt(animalListBox.SelectedIndex);
                animalListBox.Items.RemoveAt(animalListBox.SelectedIndex);
            }
        }

        private void editAnimal_Click(object sender, EventArgs e)
        {
            if (animalListBox.SelectedItem == null)
                return;
            AnimalEdit animalEdit = new AnimalEdit();
            animalEdit.EditAnimal = _animals[animalListBox.SelectedIndex];
            this.Hide();
            DialogResult result = animalEdit.ShowDialog();
            this.Show();
            if (result == DialogResult.OK)
            {
                _animals[animalListBox.SelectedIndex] = animalEdit.EditAnimal;
                animalListBox.Items[animalListBox.SelectedIndex] = ShowInList(_animals[animalListBox.SelectedIndex]);
            }
        }

        public string ShowInList(Animal animal)
        {
            return ($"{animal.Name} {animal.AnimalType}");
        }

        public string ShowInList(Employee employee)
        {
            return ($"{employee.Name} {employee.Position}");
        }

        private void editEmployeeButton_Click(object sender, EventArgs e)
        {
            if (employeeListBox.SelectedItem == null)
                return;
            EmployeeEdit employeeEdit = new EmployeeEdit();
            employeeEdit.EditEmployee = _employees[employeeListBox.SelectedIndex];
            this.Hide();
            employeeEdit.ShowDialog();
            this.Show();
            if (employeeEdit.DialogResult == DialogResult.OK)
            {
                _employees[employeeListBox.SelectedIndex] = employeeEdit.EditEmployee;
                employeeListBox.Items[employeeListBox.SelectedIndex] = ShowInList(_employees[employeeListBox.SelectedIndex]);
            }
        }

        private void removeEmployeeButton_Click(object sender, EventArgs e)
        {
            if (employeeListBox.SelectedItem != null)
            {
                _employees.RemoveAt(employeeListBox.SelectedIndex);
                employeeListBox.Items.RemoveAt(employeeListBox.SelectedIndex);
            }
        }


        private void AddVisiter()
        {
            FormVisitor formVisiter = new FormVisitor();
            this.Hide();
            formVisiter.ShowDialog();
            this.Show();
            if (formVisiter.DialogResult == DialogResult.OK)
            {
                _visitors.Add(formVisiter.Visitor);
                RefreshVisitorsList();
            }
        }

        private void RefreshVisitorsList()
        {
            if (_visitors.Count == 0)
                return;
            vistorsListBox.Items.Clear();
            foreach (var visitor in _visitors)
            {
                vistorsListBox.Items.Add(visitor.ToString());
            }
        }

        private void showAllVisitorsButton_Click(object sender, EventArgs e)
        {
            RefreshVisitorsList();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            canvas.DrawRectangle(Pens.White, 38, 63, 163, 95);
            canvas.FillRectangle(Brushes.GreenYellow, 38, 63, 163, 95);
            canvas.DrawRectangle(Pens.White, 70, 110, 50, 40);
            canvas.FillRectangle(Brushes.White, 70, 110, 50, 40);
            canvas.DrawRectangle(Pens.White, 120, 70, 50, 40);
            canvas.FillRectangle(Brushes.White, 120, 70, 50, 40);

            Pen pen = new Pen(Color.YellowGreen, 2);
            int centerX = 120;
            int centerY = 110;
            int radius = 100;
            Point[] polygonPoints = new Point[6];
            double angle = Math.PI / 2;
            double angleStep = 2 * Math.PI / 6;
            for (int i = 0; i < 6; i++)
            {
                int x = centerX + (int)(radius * Math.Cos(angle));
                int y = centerY + (int)(radius * Math.Sin(angle));
                polygonPoints[i] = new Point(x, y);
                angle += angleStep;
            }
            canvas.DrawPolygon(pen, polygonPoints);

            Pen pen2 = new Pen(Color.White, 2);
            Point point1 = new Point(130, 100);
            Point point2 = new Point(140, 80);
            Point point3 = new Point(160, 90);
            Point[] trianglePoints = { point1, point2, point3 };
            canvas.DrawPolygon(pen2, trianglePoints);

            SolidBrush greenBrush = new SolidBrush(Color.LightSkyBlue);
            canvas.FillPolygon(greenBrush, trianglePoints);

            Point point4 = new Point(110, 120);
            Point point5 = new Point(85, 135);
            Point point6 = new Point(100, 145);
            Point[] trianglePoints2 = { point4, point5, point6 };
            canvas.DrawPolygon(pen2, trianglePoints2);

            SolidBrush blueBrush2 = new SolidBrush(Color.Violet);
            canvas.FillPolygon(blueBrush2, trianglePoints2);
        }

    }
}

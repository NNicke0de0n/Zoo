using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo
{
    public partial class Director : Form
    {
        private List<Animal> _animals = new List<Animal>();
        private List<Employee> _employees = new List<Employee>();
        private List<Visitor> _visitors = new List<Visitor>();

        public Director()
        {
            InitializeComponent();
            LoadLists();
            this.Paint += Form1_Paint;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (choiceComboBox.SelectedItem != null)
            {
                switch (choiceComboBox.SelectedItem.ToString())
                {
                    case nameof(Employee):
                        AddEmployee();
                        break;
                    case nameof(Visitor):
                        AddVisitor();
                        break;
                    case nameof(Animal):
                        AddAnimal();
                        break;
                }
            }
        }

        private void AddEmployee()
        {
            var employeeEdit = new EmployeeEdit();
            this.Hide();
            employeeEdit.ShowDialog();
            this.Show();
            if (employeeEdit.DialogResult == DialogResult.OK)
            {
                var employee = employeeEdit.EditEmployee;
                _employees.Add(employee);
                RefreshList(_employees.Cast<Object>().ToList(), employeeListBox);
            }
        }

        private void AddAnimal()
        {
            var animalEdit = new AnimalEdit();
            this.Hide();
            animalEdit.ShowDialog();
            this.Show();
            if (animalEdit.DialogResult == DialogResult.OK)
            {
                var animal = animalEdit.EditAnimal;
                _animals.Add(animal);
                animalListBox.Items.Add(ShowInList(animal));
            }
        }

        private void AddVisitor()
        {
            var formVisiter = new FormVisitor();
            this.Hide();
            formVisiter.ShowDialog();
            this.Show();
            if (formVisiter.DialogResult == DialogResult.OK)
            {
                var visitor = formVisiter.Visitor;
                _visitors.Add(visitor);
                RefreshList(_visitors.Cast<Object>().ToList(), vistorsListBox);
            }
        }

        private void RefreshList(List<object> fromList, ListBox inListBox)
        {
            inListBox.Items.Clear();
            foreach (var obj in fromList)
            {
                inListBox.Items.Add(obj.ToString());
            }
        }

        private string ShowInList(object obj)
        {
            if (obj is Animal animal)
            {
                return $"{animal.Name} {animal.AnimalType} {animal.Sex}";
            }
            
            else
            {
                return obj.ToString();
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
            var animalEdit = new AnimalEdit();
            animalEdit.EditAnimal = _animals[animalListBox.SelectedIndex];
            this.Hide();
            animalEdit.ShowDialog();
            this.Show();
            if (animalEdit.DialogResult == DialogResult.OK)
            {
                _animals[animalListBox.SelectedIndex] = animalEdit.EditAnimal;
                animalListBox.Items[animalListBox.SelectedIndex] = ShowInList(_animals[animalListBox.SelectedIndex]);
            }
        }

        private void editEmployeeButton_Click(object sender, EventArgs e)
        {
            if (employeeListBox.SelectedItem == null)
                return;
            var employeeEdit = new EmployeeEdit();
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

        private void SaveLists(object sender, EventArgs e)
        {
            using (var fs = new FileStream("lists.bin", FileMode.Create))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(fs, _animals);
                formatter.Serialize(fs, _employees);
                formatter.Serialize(fs, _visitors);
            }
        }

        private void LoadLists()
        {
            if (File.Exists("lists.bin"))
            {
                using (var fs = new FileStream("lists.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    _animals = (List<Animal>)formatter.Deserialize(fs);
                    _employees = (List<Employee>)formatter.Deserialize(fs);
                    _visitors = (List<Visitor>)formatter.Deserialize(fs);
                    animalListBox.Items.Clear();
                    foreach (var animal in _animals)
                    {
                        animalListBox.Items.Add(ShowInList(animal));
                    }
                    employeeListBox.Items.Clear();
                    foreach (var employee in _employees)
                    {
                        employeeListBox.Items.Add(ShowInList(employee));
                    }
                    vistorsListBox.Items.Clear();
                    foreach (var visitor in _visitors)
                    {
                        vistorsListBox.Items.Add(visitor.ToString());
                    }
                }
            }
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

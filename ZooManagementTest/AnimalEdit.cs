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
    public partial class AnimalEdit : Form
    {
        Animal _animal;

        public Animal EditAnimal
        {
            get { return _animal; }
            set
            {
                _animal = value;
                if (value == null)
                    return;
                nameTextBox.Text = value.Name;
                descriptionsTextBox.Text = value.Description;
                genderComboBox.Text = value.Sex;
                foodTypeTextBox.Text = value.EatType;
            }
        }

        public AnimalEdit()
        {
            InitializeComponent();
            FillComboBox(genderComboBox, typeof(Gender));
        }

        //отображает потребляемый корм в зависимости от выбранного животного
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode treeNode = e.Node;

            if (treeNode.Parent == null)
            {
                return;
            }

            classAnimalTextBox.Text = treeNode.Parent.Text;
            descriptionsTextBox.Text = treeNode.ToolTipText;

            switch (treeNode.Parent.Name)
            {
                case nameof(AnimalType.Bird):
                    foodTypeTextBox.Text = "Злаки, производные" +
                        " растительного происхождения, экстракты белков растительного происхождения, масла и жиры, фрукты (6,5%)," +
                        " минеральные вещества,сахара (мед 1%), семена, сорбит";
                    break;
                case nameof(AnimalType.Cats):
                    foodTypeTextBox.Text = "Рацион, состоящий" +
                        " из тушек кормовых животных с костями и внутренностями";
                    break;
                case nameof(AnimalType.Dogs):
                    foodTypeTextBox.Text = "Рацион, состоящий" +
                        " из тушек кормовых животных с костями и внутренностями";
                    break;
                case nameof(AnimalType.Bearish):
                    foodTypeTextBox.Text = "Комбинированое питание, рыба, травы, ягоды, растительность";
                    break;
                case nameof(AnimalType.Mustelidae):
                    foodTypeTextBox.Text = "Основной рацион - рыба, моллюски, рачки, лягушки и тд.";
                    break;
                case nameof(AnimalType.Primates):
                    foodTypeTextBox.Text = "Всеядны, их рацион разнообразен и может включать орехи, фрукты, семена, яйца, насекомых, ящериц и многое другое.";
                    break;
                case nameof(AnimalType.Insect):
                    foodTypeTextBox.Text = "Meat";
                    break;
                case nameof(AnimalType.Fish):
                case nameof(AnimalType.Crustaceans):
                    foodTypeTextBox.Text = "Рыбная мука, водоросли и пр.";
                    break;
                case nameof(AnimalType.Reptile):
                    foodTypeTextBox.Text = "Различные кормовые насекомые, грызуны, водоросли, рыба, зерновые культуры";
                    break;
                case nameof(AnimalType.Amphibian):
                    foodTypeTextBox.Text = "Различные кормовые насекомые, водоросли, рыба, зерновые культуры";
                    break;
                case nameof(AnimalType.Arahnid):
                    foodTypeTextBox.Text = "Кормовые насекомые";
                    break;
                default:
                    foodTypeTextBox.Text = "Корм пока не определён, обратить к источинкам в интернете";
                    break;
            }
        }

        private void FillComboBox(ComboBox comboBox, Type type)
        {
            comboBox.DataSource = Enum.GetValues(type);
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(classAnimalTextBox.Text))
            {
                MessageBox.Show("Не установлен класс животного, проверьте корректность выбора");
                classAnimalTextBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Присвойте животному кличку");
                nameTextBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(descriptionsTextBox.Text))
            {
                MessageBox.Show("Выберите животное");
                nameTextBox.Focus();
                return;
            }

            this.DialogResult = DialogResult.OK;
            _animal = new Animal(nameTextBox.Text, descriptionsTextBox.Text, classAnimalTextBox.Text, foodTypeTextBox.Text, genderComboBox.Text);
        }
    }
}

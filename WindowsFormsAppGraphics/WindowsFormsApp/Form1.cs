using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics; // this.CreateGraphics();
            canvas.DrawRectangle(Pens.Red, 10, 10, 200, 100);

            Pen p1 = new Pen(Color.FromArgb(100, 170, 220));
            p1.Width = 6;
            canvas.DrawEllipse(p1, 10, 10, 200, 100);

            canvas.FillRectangle(Brushes.Green, 220, 10, 200,100);

            SolidBrush br1 = new SolidBrush(Color.FromArgb(10,200,50));
            canvas.FillEllipse(br1, 220, 120, 200, 100);

            // Кисточки: 
            // Сплошная SolidBrush
            // Трафаретная HatchBrush
            // Градиентная LinearGradientBrush
            // Текстурная кисть TextureBrush
            HatchBrush br2 = new HatchBrush(
                HatchStyle.Sphere,
                Color.White, Color.Red);
            canvas.FillEllipse(br2, 10,120,200,100);

            LinearGradientBrush br3 = new LinearGradientBrush(
                new Point(10, 240),
                new Point(10, 340),
                Color.Red, Color.Blue
                );
            canvas.FillRectangle(br3, 10, 240, 200, 100);


            TextureBrush br4 = new TextureBrush(
                Properties.Resources.wood
                );
            canvas.FillEllipse (br4, 10, 400, 200, 100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

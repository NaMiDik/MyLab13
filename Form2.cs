using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLab13_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) { }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double squareSide = double.Parse(txtSquareSide.Text);
                double circleRadius = double.Parse(txtCircleRadius.Text);

                IShape square = new Square(squareSide);
                IShape circle = new Circle(circleRadius);

                double squareArea = square.GetArea();
                double circleArea = circle.GetArea();

                lblSquareArea.Text = $"{squareArea}";
                lblCircleArea.Text = $"{circleArea}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть коректні числові значення.", "Помилка вводу", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

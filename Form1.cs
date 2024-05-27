using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLab13_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double squareSide = double.Parse(txtSquareSide.Text);
                double circleRadius = double.Parse(txtCircleRadius.Text);

                Shape square = new Square(squareSide);
                Shape circle = new Circle(circleRadius);

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
        private void Form1_Load(object sender, EventArgs e){}
    }
}

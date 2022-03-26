using System;
using System.Windows.Forms;

namespace metodyNumeryczne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void obliczanieButton_Click(object sender, EventArgs e)
        {
            double[,] tablica = new double[4, 5];
            tablica[0, 0] = Convert.ToDouble(textBox1.Text);
            tablica[0, 1] = Convert.ToDouble(textBox2.Text);
            tablica[0, 2] = Convert.ToDouble(textBox3.Text);
            tablica[0, 3] = Convert.ToDouble(textBox4.Text);
            tablica[0, 4] = Convert.ToDouble(textBox5.Text);
            tablica[1, 0] = Convert.ToDouble(textBox6.Text);
            tablica[1, 1] = Convert.ToDouble(textBox7.Text);
            tablica[1, 2] = Convert.ToDouble(textBox8.Text);
            tablica[1, 3] = Convert.ToDouble(textBox9.Text);
            tablica[1, 4] = Convert.ToDouble(textBox10.Text);
            tablica[2, 0] = Convert.ToDouble(textBox11.Text);
            tablica[2, 1] = Convert.ToDouble(textBox12.Text);
            tablica[2, 2] = Convert.ToDouble(textBox13.Text);
            tablica[2, 3] = Convert.ToDouble(textBox14.Text);
            tablica[2, 4] = Convert.ToDouble(textBox15.Text);
            tablica[3, 0] = Convert.ToDouble(textBox16.Text);
            tablica[3, 1] = Convert.ToDouble(textBox17.Text);
            tablica[3, 2] = Convert.ToDouble(textBox18.Text);
            tablica[3, 3] = Convert.ToDouble(textBox19.Text);
            tablica[3, 4] = Convert.ToDouble(textBox20.Text);
            //
            double[] first = new double[3];
            for (int i = 0; i < first.Length; i++)
            {
                first[i] = tablica[i + 1, 0] / tablica[0, 0];
            }
            //
            for (int i = 1; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    tablica[i, j] = tablica[i, j] - tablica[0, j] * first[i - 1];
                }
            }
            //
            double[] second = new double[2];
            for (int i = 0; i < second.Length; i++)
            {
                second[i] = tablica[i + 2, 1] / tablica[1, 1];
            }
            //
            for (int i = 2; i < tablica.GetLength(0); i++)
            {
                for (int j = 1; j < tablica.GetLength(1); j++)
                {
                    tablica[i, j] = tablica[i, j] - tablica[1, j] * second[i - 2];
                }
            }
            //
            double third = tablica[3, 2] / tablica[2, 2];
            //
            for (int i = 3; i < tablica.GetLength(0); i++)
            {
                for (int j = 2; j < tablica.GetLength(1); j++)
                {
                    tablica[i, j] = tablica[i, j] - tablica[2, j] * third;
                }
            }
            //
            firstLine.Text = $"({tablica[0, 0]})*x_1 + ({tablica[0, 1]})*x_2 + ({tablica[0, 2]})*x_3 + ({tablica[0, 3]})*x_4 = {tablica[0, 4]}";
            secondLine.Text = $"({tablica[1, 0]})*x_1 + ({tablica[1, 1]})*x_2 + ({tablica[1, 2]})*x_3 + ({tablica[1, 3]})*x_4 = {tablica[1, 4]}";
            thirdLine.Text = $"({tablica[2, 0]})*x_1 + ({tablica[2, 1]})*x_2 + ({tablica[2, 2]})*x_3 + ({tablica[2, 3]})*x_4 = {tablica[2, 4]}";
            forthLine.Text = $"({tablica[3, 0]})*x_1 + ({tablica[3, 1]})*x_2 + ({tablica[3, 2]})*x_3 + ({tablica[3, 3]})*x_4 = {tablica[3, 4]}";
            double x_4 = tablica[3,4] / tablica[3,3];
            double x_3 = (tablica[2,4] - tablica[2,3] * x_4) / tablica[2,2];
            double x_2 = (tablica[1,4] - tablica[1,3] * x_4 - tablica[1,2] * x_3) / tablica[1, 1];
            double x_1 = (tablica[0, 4] - tablica[0, 3] * x_4 - tablica[0, 2] * x_3 - tablica[0, 1] * x_2) / tablica[0, 0];
            final_result.Text = $"x_1     {x_1:0.0000}\nx_2:    {x_2:0.0000}\nx_3:    {x_3:0.0000}\nx_4:    {x_4:0.0000}";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            firstLine.Text = "";
            secondLine.Text = "";
            thirdLine.Text = "";
            forthLine.Text = "";
            final_result.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

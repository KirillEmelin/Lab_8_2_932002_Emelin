using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace emelin_lab_8_2
{
    public partial class Form1 : Form
    {
        private readonly Random _random = new Random();
        private const int ProbCount = 8;
        private readonly double[] _prob = { 0.1, 0.15, 0.09, 0.17, 0.15, 0.21, 0.05, 0.22 };
        private readonly string[] _pred = { "YES", "NO", "NO DOUBT ABOUT IT",
            "ABSOLUTELY ", "THE STARS SAY NO", "SO IT SHALL BE", "UNLIKELY", "INDICATIONS SAY YES" };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();

            double temp = 0, sum = 0;

            for (int i = 0; i < ProbCount; i++)
            {
                sum += _prob[i];
                temp = _random.NextDouble();
                if (temp < sum)
                {
                    textBox2.Text = _pred[i];
                    break;
                }
            }
        }
    }
}

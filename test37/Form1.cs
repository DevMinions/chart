using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace test37
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Random rnd = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    chart1.Series[0].Points.Add(rnd.Next(0,101));
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 1; i < 5; i++) {
                Chart myChart = (Chart)tableLayoutPanel1.Controls.Find("chart"+i,true)[0];
                if (myChart.Series[0].Points.Count >= 10)
                {
                    myChart.Series[0].Points.RemoveAt(0);
                }
                Random rnd = new Random();
                int rndNum = rnd.Next(0, 101);
                DataPoint dataPoint = new DataPoint();
                dataPoint.YValues = new double[] { rndNum };
                dataPoint.Label = rndNum.ToString();
                myChart.Series[0].Points.Add(dataPoint);
            }
        }
    }
}

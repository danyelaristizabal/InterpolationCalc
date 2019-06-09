using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolinomialInterpolationCalculator
{
    public partial class CalcInterface : Form
    {
        public List<double> Xs { get; set; }
        public List<double> Ys { get; set; } 
        public CalcInterface()
        {
            InitializeComponent();
            YTxtB.KeyUp += YTxtB_KeyUp;
            XTxtB.KeyUp += XTxtB_KeyUp;
            Xs = new List<double>();
            Ys = new List<double>(); 
        }

        private void YTxtB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (YTxtB.Text != string.Empty && XTxtB.Text != string.Empty)
                {
                    Ys.Add(Convert.ToDouble(YTxtB.Text));
                    Xs.Add(Convert.ToDouble(XTxtB.Text));
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    MessageBox.Show("Error please add cordinate in x as in y");
                }
                YTxtB.Clear();
                XTxtB.Clear();
                e.Handled = true;
            }
        }
        private void XTxtB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (YTxtB.Text != string.Empty && XTxtB.Text != string.Empty)
                {
                    Ys.Add(Convert.ToDouble(YTxtB.Text));
                    Xs.Add(Convert.ToDouble(XTxtB.Text));
                }
                else
                {
                    MessageBox.Show("Error please add cordinate in x as in y"); 
                }

                YTxtB.Clear();
                XTxtB.Clear();
                e.Handled = true;
            }
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            var polfinder = new PolynomialFinder();
            Resultlbl.Text =  polfinder.FindPolynom(Xs, Ys); 
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (YTxtB.Text != string.Empty && XTxtB.Text != string.Empty)
            {
                Ys.Add(Convert.ToDouble(YTxtB.Text));
                Xs.Add(Convert.ToDouble(XTxtB.Text));
                System.Threading.Thread.Sleep(1000);
            }
            else
            {
                MessageBox.Show("Error please add cordinate in x as in y");
            }
            YTxtB.Clear();
            XTxtB.Clear();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Xs.Clear();
            Ys.Clear(); 
            YTxtB.Clear();
            XTxtB.Clear();
            Resultlbl.Text = "Result"; 

        }
    }
}

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
            Xs = new List<double>();
            Ys = new List<double>(); 
        }
        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            var polfinder = new PolynomialFinder();
            try
            {
                Resultlbl.Text = polfinder.FindPolynom(Xs, Ys);

            }
            catch (Exception)
            {

                MessageBox.Show("Incorrect cordinates, please check your cordinates"); 
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (YTxtB.Text != string.Empty && XTxtB.Text != string.Empty)
                {
                    Ys.Add(Convert.ToDouble(YTxtB.Text));
                    Xs.Add(Convert.ToDouble(XTxtB.Text));
                }
                else
                {
                    MessageBox.Show("In order to save please add cordinate in X textbox also in Y textbox ");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error adding the cordinates, please insert in correct format.         Example 1.2 => 1,2"); 
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
            Resultlbl.Text = ""; 

        }

        private void CalcInterface_Load(object sender, EventArgs e)
        {

        }
    }
}

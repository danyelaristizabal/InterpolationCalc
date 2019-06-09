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
        public CalcInterface()
        {
            InitializeComponent();
            YTxtB.KeyUp += YTxtB_KeyUp;
            XTxtB.KeyUp += XTxtB_KeyUp;
        }

        private void YTxtB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                YTxtB.Clear();
                XTxtB.Clear();
                e.Handled = true;
            }
        }

        private void XTxtB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                YTxtB.Clear();
                XTxtB.Clear();
                e.Handled = true;
            }
        }
    }
}

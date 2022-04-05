using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP01_202873
{
    public partial class FrmInicial : Form
    {
        public FrmInicial()
        {
            InitializeComponent();
        }

        private void LblDelta_Click_1(object sender, EventArgs e)
        {

        }

        private void LblControl_Click(object sender, EventArgs e)
        {

        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalc_Click_1(object sender, EventArgs e)
        {
            double R1;
            double R2;
            double R3;

            double R4;
            double R5;
            double R6;

            R1 = double.Parse(TxtR1.Text);
            R2 = double.Parse(TxtR2.Text);
            R3 = double.Parse(TxtR3.Text);

            R4 = R1 * R2 / (R1 + R2 + R3);
            R5 = R2 * R3 / (R1 + R2 + R3);
            R6 = R3 * R1 / (R1 + R2 + R3);

            TxtYR4.Text = R4.ToString();
            TxtYR5.Text = R5.ToString();
            TxtYR6.Text = R6.ToString();
        }

        private void BtnLimpar_Click_1(object sender, EventArgs e)
        {
            TxtR1.Text = "";
            TxtR2.Text = "";
            TxtR3.Text = "";
            TxtYR4.Text = "";
            TxtYR5.Text = "";
            TxtYR6.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_9_Assignment2
{
    public partial class AssignmentForm : Form
    {
        public AssignmentForm()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            lblPlus.Visible = true;
            lblMinus.Visible = false;
            lblTimes.Visible = false;
            lblDivi.Visible = false;
            lblPlus.Text = "8 + 5 = " + (8 + 5);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            lblMinus.Visible = true;
            lblTimes.Visible = false;
            lblDivi.Visible = false;
            lblPlus.Visible = false;
            lblMinus.Text = "8 - 5 = " + (8 - 5);
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            lblTimes.Visible = true;
            lblDivi.Visible = false;
            lblPlus.Visible = false;
            lblMinus.Visible = false;
            lblTimes.Text = "8 × 5 = " + (8 * 5);
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            lblDivi.Visible = true;
            lblPlus.Visible = false;
            lblMinus.Visible = false;
            lblTimes.Visible = false;
            lblDivi.Text = "8 ÷ 5 = " + (8 / 5);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            
            Close();
        }

    }
}

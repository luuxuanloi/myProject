using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace github
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(so1.Text) &&
                !string.IsNullOrWhiteSpace(so2.Text))
            {
                int a = int.Parse(so1.Text);
                int b = int.Parse(so2.Text);
                Calculation cal = new Calculation(a, b);
                lblKQ.Text = cal.execute("+").ToString();
            }
        }


        private void btnTru_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(so1.Text) &&
                !string.IsNullOrWhiteSpace(so2.Text))
            {
                int a = int.Parse(so1.Text);
                int b = int.Parse(so2.Text);
                Calculation cal = new Calculation(a, b);
                lblKQ.Text = cal.execute("-").ToString();
            }
        }


        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(so1.Text) &&
                !string.IsNullOrWhiteSpace(so2.Text))
            {
                int a = int.Parse(so1.Text);
                int b = int.Parse(so2.Text);
                Calculation cal = new Calculation(a, b);
                lblKQ.Text = cal.execute("*").ToString();
            }
        }



        private void btnChia_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(so1.Text) &&
                !string.IsNullOrWhiteSpace(so2.Text))
            {
                int a = int.Parse(so1.Text);
                int b = int.Parse(so2.Text);
                Calculation cal = new Calculation(a, b);
                lblKQ.Text = cal.execute("/").ToString();
            }
        }
    }
}

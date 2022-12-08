using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tinhTongHieuTichThuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tinhTong_Click(object sender, EventArgs e)
        {
            double a = double.Parse(soA.Text);
            double b = double.Parse(soB.Text);
            double tong = a + b;
            tongAB.Text = tong + "";
        }

        private void tinhHieu_Click(object sender, EventArgs e)
        {
            double a = double.Parse(soA.Text);
            double b = double.Parse(soB.Text);
            double hieu = a - b;
            hieuAB.Text = hieu + "";
        }

        private void tinhTich_Click(object sender, EventArgs e)
        {
            double a = double.Parse(soA.Text);
            double b = double.Parse(soB.Text);
            double tich = a * b;
            tichAB.Text = tich + "";
        }

        private void tinhThuong_Click(object sender, EventArgs e)
        {
            double a = double.Parse(soA.Text);
            double b = double.Parse(soB.Text);
            double thuong = a / b;
            thuongAB.Text = thuong + "";
        }
    }
}
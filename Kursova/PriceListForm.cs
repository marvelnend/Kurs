using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova.models
{
    public partial class PriceListForm : Form
    {
        public PriceList priceList;
        public PriceListForm()
        {
            InitializeComponent();
        }

        public void UpdateForm()
        {
            Label a = (Label)Controls.Find("dA", true)[0];
            Label b = (Label)Controls.Find("dB", true)[0];
            Label p = (Label)Controls.Find("price", true)[0];
            Label n = (Label)Controls.Find("pices", true)[0];
            



            a.Text = priceList.dateTimeA.ToString();
            b.Text = priceList.dateTimeB.ToString();
            p.Text = priceList.price + "";
            n.Text = priceList.pass + "";
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductsApplication
{
    public partial class IncreasePrice : Form
    {
        public IncreasePrice()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            foreach (var item in Welcome.products)
            {
                item.CalPrice(txtProduct2.Text, int.Parse(txtincrease.Text), item);
            }
        }
    }
}

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
    public partial class allProduct : Form
    {
        public allProduct()
        {
            InitializeComponent();
        }

        private void allProduct_Load(object sender, EventArgs e)
        {
            lstProducts.Items.Add("NAME\t\tID\tPRICE");
            foreach (var item in Welcome.products)
            {
                lstProducts.Items.Add(item);
            }
        }
    }
}

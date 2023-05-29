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
    public partial class Welcome : Form
    {
        internal static List<Products> products = new List<Products>();
        public Welcome()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtProductName.Text == "" || txtProductID.Text == "")
            {
                MessageBox.Show("Product not added one more of the field are empty");
            }
            else
            {
                if (txtPrice.Text == "")
                {
                    txtPrice.Text = "0,00";
                    products.Add(new Products(txtProductName.Text, txtProductID.Text, Convert.ToDouble(txtPrice.Text)));
                }
                else
                {
                    products.Add(new Products(txtProductName.Text, txtProductID.Text, Convert.ToDouble(txtPrice.Text)));
                    MessageBox.Show($"The product {txtProductName.Text} has been added");
                    
                }

                
            }
            clearAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            IncreasePrice change = new IncreasePrice();
            change.ShowDialog();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            allProduct view = new allProduct();
            view.ShowDialog();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        public void clearAll()
        {
            txtProductID.Clear();
            txtProductName.Clear();
            txtPrice.Clear();
        }
    }
}

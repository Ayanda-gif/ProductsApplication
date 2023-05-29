using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsApplication
{
    class Products
    {
		private string name;

		protected internal string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string id;

		protected internal string ID
		{
			get { return id; }
			set { id = value; }
		}

		private double price;

		public double Price
		{
			get { return price; }
			set { price = value; }
		}

		public Products(string prodName,string prodID, double prodPrice)
		{
			this.Name = prodName;
			this.ID = prodID;
			this.Price = prodPrice;

		}

		public Products()
		{

		}

		protected internal void CalPrice(string productID, double increase,Products p)
		{
			if (productID == p.ID)
			{
				double oldPrice = p.Price;
				p.Price = (p.Price * increase / 100) + p.Price;
				System.Windows.Forms.MessageBox.Show($"The price product {p.Name} has been update from {oldPrice} to the {p.Price}");
			}
			
		}

		public override string ToString()
		{
			return $"{Name}\t{ID}\t{Price}";
		}

	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Parlor_Pricer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

		}
		double ExtraCheese, Pepperoni, Sausage, CanadianBacon, Pineapple, Mushrooms,
			BellPeppers, Onions, Olives, xyz;
		double tenInch, fourteenInch, eighteenInch;
		string price;

		private void btnSupreme_Click(object sender, EventArgs e)
		{
			ExtraCheese = Double.Parse(chkExtraCheese.Text);
			Pepperoni = Double.Parse(chkPepperoni.Text);
			Sausage = Double.Parse(chkSausage.Text);
			CanadianBacon = Double.Parse(chkCanadianBacon.Text);
			Pineapple = Double.Parse(chkPineapple.Text);
			Mushrooms = Double.Parse(chkMushroom.Text);
			BellPeppers = Double.Parse(chkBellPeppers.Text);
			Onions = Double.Parse(chkOnions.Text);
			Olives = Double.Parse(chkOlives.Text);

			if (radio10.Checked = true)
			{
				
			}

		}

		private void radio18_CheckedChanged(object sender, EventArgs e)
		{
			ExtraCheese = 3.35;
			Pepperoni = 4.85;
			Sausage = 4.95;
			CanadianBacon = 5.35;
			Pineapple = 3.15;
			Mushrooms = 1.95;
			BellPeppers = 1.35;
			Onions = 1.00;
			Olives = 0.90;
			eighteenInch = 14.50;
		}

		private void radio14_CheckedChanged(object sender, EventArgs e)
		{
			ExtraCheese = 2.15;
			Pepperoni = 3.00;
			Sausage = 3.20;
			CanadianBacon = 3.50;
			Pineapple = 1.70;
			Mushrooms = 1.15;
			BellPeppers = 0.85;
			Onions = 0.65;
			Olives = 0.55;
			fourteenInch = 9.75;
		}

		private void radio10_CheckedChanged(object sender, EventArgs e)
		{
			ExtraCheese = 1.10;
			Pepperoni = 1.75;
			Sausage = 1.85;
			CanadianBacon = 2.00;
			Pineapple = 0.95;
			Mushrooms = 0.65;
			BellPeppers = 0.45;
			Onions = 0.35;
			Olives = 0.30;
			tenInch = 5.25;
		}
	}
}

using System;
using System.Windows.Forms;

namespace Pizza_Parlor_Pricer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        double ExtraCheese,
            Pepperoni,
            Sausage,
            CanadianBacon,
            Pineapple,
            Mushrooms,
            BellPeppers,
            Onions,
            Olives,
            xyz;

        private double priceValue = 0;



        double tenInch, fourteenInch, eighteenInch;
        string price;



        private void setPrice()
        {
            string money = string.Format("{0:#.00}", Convert.ToDecimal(priceValue));
            lblPrice.Text = "Price: $" + money;
        }

        private void clearAll()
        {
            chkExtraCheese.Checked = false;
            chkPepperoni.Checked = false;
            chkSausage.Checked = false;
            chkCanadianBacon.Checked = false;
            chkPineapple.Checked = false;
            chkMushroom.Checked = false;
            chkBellPeppers.Checked = false;
            chkOnions.Checked = false;
            chkOlives.Checked = false;
            priceValue = 0;
            lblPrice.Text = "Price: $";
        }

        private void sizeCheck()
        {
            if (radio10.Checked == true)
            {
                priceValue = 0;
                if (chkExtraCheese.CheckState == CheckState.Checked)
                    priceValue += Pizza.Ten.ExtraCheese;
                if (chkPepperoni.CheckState == CheckState.Checked)
                    priceValue += Pizza.Ten.Pepperoni;
                if (chkSausage.CheckState == CheckState.Checked)
                    priceValue += Pizza.Ten.Sausage;
                if (chkCanadianBacon.CheckState == CheckState.Checked)
                    priceValue += Pizza.Ten.CanadianBacon;
                if (chkPineapple.CheckState == CheckState.Checked)
                    priceValue += Pizza.Ten.Pineapple;
                if (chkMushroom.CheckState == CheckState.Checked)
                    priceValue += Pizza.Ten.Mushrooms;
                if (chkBellPeppers.CheckState == CheckState.Checked)
                    priceValue += Pizza.Ten.BellPeppers;
                if (chkOnions.CheckState == CheckState.Checked)
                    priceValue += Pizza.Ten.Onions;
                if (chkOlives.CheckState == CheckState.Checked)
                    priceValue += Pizza.Ten.Olives;
                priceValue += Pizza.Ten.PizzaPie;
                setPrice();
            }
            if (radio14.Checked == true)
            {
                priceValue = 0;
                if (chkExtraCheese.CheckState == CheckState.Checked)
                    priceValue += Pizza.Fourteen.ExtraCheese;
                if (chkPepperoni.CheckState == CheckState.Checked)
                    priceValue += Pizza.Fourteen.Pepperoni;
                if (chkSausage.CheckState == CheckState.Checked)
                    priceValue += Pizza.Fourteen.Sausage;
                if (chkCanadianBacon.CheckState == CheckState.Checked)
                    priceValue += Pizza.Fourteen.CanadianBacon;
                if (chkPineapple.CheckState == CheckState.Checked)
                    priceValue += Pizza.Fourteen.Pineapple;
                if (chkMushroom.CheckState == CheckState.Checked)
                    priceValue += Pizza.Fourteen.Mushrooms;
                if (chkBellPeppers.CheckState == CheckState.Checked)
                    priceValue += Pizza.Fourteen.BellPeppers;
                if (chkOnions.CheckState == CheckState.Checked)
                    priceValue += Pizza.Fourteen.Onions;
                if (chkOlives.CheckState == CheckState.Checked)
                    priceValue += Pizza.Fourteen.Olives;
                priceValue += Pizza.Fourteen.PizzaPie;
                setPrice();

            }
            if (radio18.Checked == true)
            {
                priceValue = 0;
                if (chkExtraCheese.CheckState == CheckState.Checked)
                    priceValue += Pizza.Eighteen.ExtraCheese;
                if (chkPepperoni.CheckState == CheckState.Checked)
                    priceValue += Pizza.Eighteen.Pepperoni;
                if (chkSausage.CheckState == CheckState.Checked)
                    priceValue += Pizza.Eighteen.Sausage;
                if (chkCanadianBacon.CheckState == CheckState.Checked)
                    priceValue += Pizza.Eighteen.CanadianBacon;
                if (chkPineapple.CheckState == CheckState.Checked)
                    priceValue += Pizza.Eighteen.Pineapple;
                if (chkMushroom.CheckState == CheckState.Checked)
                    priceValue += Pizza.Eighteen.Mushrooms;
                if (chkBellPeppers.CheckState == CheckState.Checked)
                    priceValue += Pizza.Eighteen.BellPeppers;
                if (chkOnions.CheckState == CheckState.Checked)
                    priceValue += Pizza.Eighteen.Onions;
                if (chkOlives.CheckState == CheckState.Checked)
                    priceValue += Pizza.Eighteen.Olives;
                priceValue += Pizza.Eighteen.PizzaPie;
                setPrice();
            }
        }

        private void btnSupreme_Click(object sender, EventArgs e)
        {
            clearAll();

            chkPepperoni.Checked = true;
            chkSausage.Checked = true;
            chkCanadianBacon.Checked = true;
            chkMushroom.Checked = true;
            chkBellPeppers.Checked = true;
            chkOnions.Checked = true;
            chkOlives.Checked = true;

            sizeCheck();
        }

        private void btnPepperoniAndMushroom_Click(object sender, EventArgs e)
        {
            clearAll();

            chkPepperoni.Checked = true;
            chkMushroom.Checked = true;

            sizeCheck();
        }

        private void btnHawaiian_Click(object sender, EventArgs e)
        {
            clearAll();

            chkCanadianBacon.Checked = true;
            chkPineapple.Checked = true;

            sizeCheck();
        }

        private void btnVegetarian_Click(object sender, EventArgs e)
        {
            clearAll();

            chkMushroom.Checked = true;
            chkBellPeppers.Checked = true;
            chkOnions.Checked = true;
            chkOlives.Checked = true;

            sizeCheck();
        }


        private void radio18_CheckedChanged(object sender, EventArgs e)
        {
            sizeCheck();
        }

        private void radio14_CheckedChanged(object sender, EventArgs e)
        {
            sizeCheck();
        }

        private void radio10_CheckedChanged(object sender, EventArgs e)
        {
            sizeCheck();
        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            sizeCheck();
        }

        private void chkPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            sizeCheck();
        }

        private void chkSausage_CheckedChanged(object sender, EventArgs e)
        {
            sizeCheck();
        }

        private void chkCanadianBacon_CheckedChanged(object sender, EventArgs e)
        {
            sizeCheck();
        }

        private void chkPineapple_CheckedChanged(object sender, EventArgs e)
        {
            sizeCheck();
        }

        private void chkMushroom_CheckedChanged(object sender, EventArgs e)
        {
            sizeCheck();
        }

        private void chkBellPeppers_CheckedChanged(object sender, EventArgs e)
        {
            sizeCheck();
        }

        private void chkOnions_CheckedChanged(object sender, EventArgs e)
        {
            sizeCheck();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            sizeCheck();
        }

        public struct Pizza
        {


            public struct Ten
            {
                public const double ExtraCheese = 1.10,
                    Pepperoni = 1.75,
                    Sausage = 1.85,
                    CanadianBacon = 2.00,
                    Pineapple = 0.95,
                    Mushrooms = 0.65,
                    BellPeppers = 0.45,
                    Onions = 0.35,
                    Olives = 0.30,
                    PizzaPie = 5.25;
            }

            public struct Fourteen
            {
                public const double ExtraCheese = 2.15,
                    Pepperoni = 3.00,
                    Sausage = 3.20,
                    CanadianBacon = 3.50,
                    Pineapple = 1.70,
                    Mushrooms = 1.15,
                    BellPeppers = 0.85,
                    Onions = 0.65,
                    Olives = 0.55,
                    PizzaPie = 9.75;
            }

            public struct Eighteen
            {
                public const double ExtraCheese = 3.35,
                    Pepperoni = 4.85,
                    Sausage = 4.95,
                    CanadianBacon = 5.35,
                    Pineapple = 3.15,
                    Mushrooms = 1.95,
                    BellPeppers = 1.35,
                    Onions = 1.00,
                    Olives = 0.90,
                    PizzaPie = 14.50;
            }
        }
    }
}

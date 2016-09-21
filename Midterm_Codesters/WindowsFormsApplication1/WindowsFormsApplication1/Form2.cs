using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class Form2 : Form
    {
        


        private double Subtotal;
        private double Tax;
        private double Total;
        

        public Form2()
        {
            InitializeComponent();
        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double TaxRate = 0.06;
            double Coffee = 1.99;
            double Bagel = 1.50;
            double Donut = 0.99;
            double IcedCoffee = 2.50;
            double tea = 1.99;
            double Latte = 2.99;
            double HotChocolate = 2.50;
            double coffeeCake = 3.50;
            double fruit = 2.00;
            double brkfaStSand = 2.75;
            double smoothie = 4.00;
            double wrap = 5.00;

            if (chkCoffee.Checked)
            {
                Subtotal += Coffee;
                Tax += Coffee * 0.06;
                Total = Subtotal + Tax;
            }
            if (chkBagel.Checked)
            {
                Subtotal += Bagel;
                Tax += Bagel * 0.06;
                Total = Subtotal + Tax;
            }
            if (chkDonut.Checked)
            {
                Subtotal += Donut;
                Tax += Donut * 0.06;
                Total = Subtotal + Tax;
            }
            if (chkIcedCoffee.Checked)
            {
                Subtotal += IcedCoffee;
                Tax += IcedCoffee * 0.06;
                Total = Subtotal + Tax;
            }
            if (chkTea.Checked)
            {
                Subtotal += tea;
                Tax += tea * 0.06;
                Total = Subtotal + Tax;
            }
            if (chkLatte.Checked)
            {
                Subtotal += Latte;
                Tax += Latte * 0.06;
                Total = Subtotal + Tax;
            }
            if (chkHotChocolate.Checked)
            {
                Subtotal += HotChocolate;
                Tax += HotChocolate * 0.06;
                Total = Subtotal + Tax;
            }
            if (chkCoffeeCake.Checked)
            {
                Subtotal += coffeeCake;
                Tax += coffeeCake * 0.06;
                Total = Subtotal + Tax;
            }
            if (chkFruit.Checked)
            {
                Subtotal += fruit;
                Tax += fruit * 0.06;
                Total = Subtotal + Tax;
            }

            if (chkBfastSand.Checked)
            {
                Subtotal += brkfaStSand;
                Tax += brkfaStSand * 0.06;
                Total = Subtotal + Tax;
            }
            if (chkSmoothie.Checked)
            {
                Subtotal += smoothie;
                Tax += smoothie * 0.06;
                Total = Subtotal + Tax;
            }
            if (chkWrap.Checked)
            {
                Subtotal += wrap;
                Tax += wrap * 0.06;
                Total = Subtotal + Tax;
            }

            lblSubtotal.Text = Subtotal.ToString("c");
            lblTax.Text = Tax.ToString("c");
            lblTotal.Text = Total.ToString("c"); 
            
            }
        private void lblSubtotal_Click(object sender, EventArgs e)
        {

        }


        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            lblTotal.Text = string.Empty;
            lblSubtotal.Text = string.Empty;
            lblTax.Text = string.Empty;
            chkBagel.Checked = false;
            chkBfastSand.Checked = false;
            chkCoffee.Checked = false;
            chkCoffeeCake.Checked = false;
            chkDonut.Checked = false;
            chkFruit.Checked = false;
            chkHotChocolate.Checked = false;
            chkIcedCoffee.Checked = false;
            chkLatte.Checked = false;
            chkSmoothie.Checked = false;
            chkTea.Checked = false;
            chkWrap.Checked = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }

      

       
    }


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Cash_Register
{
    public partial class Form1 : Form
    {
        //globals
        //global Constants
        const double PIZZA_PRICE = 2.49; //price of Boneless Pizza
        const double FRIES_PRICE = 1.89; //price of Fries
        const double DRINK_PRICE = 0.99; //price of Drink
        const double TAX_RATE = 0.13;    //rate of Tax

        //global Int/Doubles
        int totalPizza, totalFries, totalDrinks;//variables to hold value from User Input
        double totalCost, totalTax, finalTotal, tendered, changeDue;//variables to do math things with ╰( ◕ ᗜ ◕ )╯

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //writing in labels (for GUI) 
            numberOfLabel.Text = "Number of Pizza's:\n \nNumber of Fries:\n \nNumber of Drinks:";
            totalsLabelWord.Text = "Sub Total\n \nTax\n \nTotal";
            changeLabelWord.Text = "Change Due:";

            //hiding things...
            totalsLabelWord.Visible = false;
            dividerLabel.Visible = false;
            calculateChangeLabel.Visible = false;
            tenderedLabel.Visible = false;
            tenderedAmountInput.Visible = false;
            changeLabelWord.Visible = false;
           //testing printReceiptButton.Visible = false; 
            newOrderButton.Visible = false;
            
        }

        private void calculateTotalsLabel_Click(object sender, EventArgs e)
        {
            try
            {
                //hiding error message
                errorLabel.Visible = false;

                //converting to Int16 to hold values from InputBox's
                totalPizza = Convert.ToInt16(pizzaAmountInput.Text);//holding value for Boneless Pizza
                totalFries = Convert.ToInt16(friesAmountInput.Text);//holding value for Fries
                totalDrinks = Convert.ToInt16(drinksAmountInput.Text);//holding value for Drinks

                //calculations
                totalCost = (totalPizza * PIZZA_PRICE) + (totalFries * FRIES_PRICE) + (totalDrinks * DRINK_PRICE);//multiplying values of options and adding them together
                totalTax = totalCost * TAX_RATE;//multipying the Sub Total by the Tax Rate
                finalTotal = totalCost + totalTax;//adding Sub Total and Tax to creat a final Cost

                //output
                totalsLabel.Text = totalCost.ToString("0.00") + "\n \n" + totalTax.ToString("0.00") + "\n \n" + finalTotal.ToString("0.00");//output totals

                //showing labels...
                totalsLabelWord.Visible = true;
                dividerLabel.Visible = true;
                calculateChangeLabel.Visible = true;
                tenderedLabel.Visible = true;
                tenderedAmountInput.Visible = true;
            }
            catch
            {
                totalsLabelWord.Visible = false;
                dividerLabel.Visible = false;
                calculateChangeLabel.Visible = false;
                tenderedLabel.Visible = false;
                tenderedAmountInput.Visible = false;
                printReceiptButton.Visible = false;
                newOrderButton.Visible = false;
                changeLabelWord.Visible = false;
                changeLabel.Visible = false;
                errorLabel.Visible = true;//"unhiding"
                totalsLabel.Text = "";//hiding totals from possible previous calculations
                errorLabel.Text = "You Must Enter A Valid Number, Try Again...";//outputs Error Message (if "Int16" is not recieved)
                return;
            }
            

        }

        private void calculateChangeLabel_Click(object sender, EventArgs e)
        {
            try
            {
                //hiding error message again
                changeErrorLabel.Visible = false;//hiding possible error label shown

                //converting to double to hold value of cash tendered
                tendered = Convert.ToDouble(tenderedAmountInput.Text);//holding value for cash given by customer

                //calculations
                changeDue = tendered - finalTotal;//calculating amount of change due to customer

                //output
                changeLabel.Text = changeDue.ToString("0.00");//outputing change due with 2 decimal places (eg. 1.25)

                //showing labels...
                changeLabelWord.Visible = true;
                printReceiptButton.Visible = true;
                changeLabel.Visible = true;
            }
            catch
            {
                changeErrorLabel.Visible = true;//"unhiding"
                changeLabel.Text = "";//hiding totals from possible previous calculations
                changeErrorLabel.Text = "You Must Enter A Valid\nNumber, Try Again...";//outputs Error Message (if "Int16" is not recieved)
                return;
            }
        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            var time = 400;
            //graphics
            Graphics rG = this.CreateGraphics();

            //brushes and fonts
            Pen borderPen = new Pen(Color.Salmon, 2);
            SolidBrush backBrush = new SolidBrush(Color.LightSalmon);
            SolidBrush whiteBrush = new SolidBrush(Color.White);

            Font receiptFont = new Font("Consolas", 10, FontStyle.Regular);
            SolidBrush receiptBrush = new SolidBrush(Color.Black);

            //drawing
            rG.FillRectangle(backBrush, 235, 65, 225, 430);
            rG.DrawRectangle(borderPen, 235, 65, 225, 430);
            Thread.Sleep(500);

            rG.FillRectangle(whiteBrush, 236, 66, 223, 24);
            rG.DrawString("Boneless Pizza", receiptFont, receiptBrush, 290, 66);
            Thread.Sleep(time);

            rG.FillRectangle(whiteBrush, 236, 90, 223, 24);
            Thread.Sleep(time);

            rG.FillRectangle(whiteBrush, 236, 114, 223, 24);
            rG.DrawString("Order Number 15", receiptFont, receiptBrush, 245, 114);
            Thread.Sleep(time);

            rG.FillRectangle(whiteBrush, 236, 138, 223, 24);
            rG.DrawString("October 15, 2017", receiptFont, receiptBrush, 245, 138);
            Thread.Sleep(time);
            rG.FillRectangle(whiteBrush, 236, 162, 223, 24);
            Thread.Sleep(time);

            rG.FillRectangle(whiteBrush, 236, 186, 223, 24);
            rG.DrawString("Boneless Pizza", receiptFont, receiptBrush, 245, 186);

            Thread.Sleep(time);

            rG.FillRectangle(whiteBrush, 236, 210, 223, 24);
            rG.DrawString("Fire Fries", receiptFont, receiptBrush, 245, 210);

            Thread.Sleep(time);

            rG.FillRectangle(whiteBrush, 236, 234, 223, 24);
            rG.DrawString("Drink(s)", receiptFont, receiptBrush, 245, 234);

            Thread.Sleep(time);

            rG.FillRectangle(whiteBrush, 236, 258, 223, 24);
            Thread.Sleep(time);

            rG.FillRectangle(whiteBrush, 236, 282, 223, 24);
            rG.DrawString("Subtotal", receiptFont, receiptBrush, 245, 282);

            Thread.Sleep(time);

            rG.FillRectangle(whiteBrush, 236, 306, 223, 24);
            rG.DrawString("Tax", receiptFont, receiptBrush, 245, 306);

            Thread.Sleep(time);

            rG.FillRectangle(whiteBrush, 236, 330, 223, 24);
            rG.DrawString("Total", receiptFont, receiptBrush, 245, 330);

            Thread.Sleep(time);

            rG.FillRectangle(whiteBrush, 236, 354, 223, 24);
            Thread.Sleep(time);

            rG.FillRectangle(whiteBrush, 236, 378, 223, 24);
            rG.DrawString("Tendered", receiptFont, receiptBrush, 245, 378);

            Thread.Sleep(time);

            rG.FillRectangle(whiteBrush, 236, 402, 223, 24);
            rG.DrawString("Change Due", receiptFont, receiptBrush, 245, 402);

            Thread.Sleep(time);

            rG.FillRectangle(whiteBrush, 236, 426, 223, 24);
            Thread.Sleep(time);

            rG.FillRectangle(whiteBrush, 236, 450, 223, 24);
            rG.DrawString("Have A Nice Day!", receiptFont, receiptBrush, 290, 450);
            Thread.Sleep(time);

            rG.FillRectangle(whiteBrush, 236, 474, 223, 20);

            //shwoing labels
            newOrderButton.Visible = true;
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            //


        }
    }
}

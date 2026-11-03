// Grading ID: R2404
// Due Date: March 28, 2024
// Program 3
// Description: When compiled, this code creates a form that calculates the shipping price based on the company chosen, discounts, and contract length


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Event handler that compiles code when the calculate button is clicked
        private void calcButton_Click(object sender, EventArgs e)
        {
            //Shipping Provider array
            string[] shippingProvider = { "USPS", "DHL", "FedEx", "UPS" }; //Array for shipping provider names
            double[] discountLookup = { 0.25, 0.20, 0.17, 0.15 }; //Array for the discounts applying to the shipping provider

            //Business array
            string[] businessName = { "John's Books", "Office Supplies", "J.B. Car Parts", "Gevalia Coffee", "Ceylon Tea", "My Footwear" }; //Array for business names
            double[] priceLookup = { 55000, 87880, 65000, 90000, 75500, 40550 }; //Array for business initial contract prices

            //Contract Length range array
            double[] minLength = { 0, 2, 5, 8 }; //Array for the low end of the contract length range
            double[] lengthDiscount = { 0, 5000, 10000, 15000 }; //Array for the discount based on the contract length

            //Declaring constants
            const int minYear = 0; //The minimum year that can be input is 0
            const int maxYear = 10; //The maximum year that can be input is 10

            //Declaring variables
            double initialPrice = 0; //Initial Contract Price
            double companyDiscount = 0; //Calculated discount based on the shipping provider chosen

            double finalPrice; //Final calculated shipping price
            int duration; //Contract length input by users
            string provider;

            //Bool variables
            bool providerFound = false; 
            bool businessFound = false;
            bool lengthFound = false;

            //If a shipping provider is chosen from the combo box
            if (providerCombo.SelectedIndex >= 0)
            {
                //If a business is chosen from the combo box
                if (businessCombo.SelectedIndex >= 0)
                {
                    //If the contract length that is input is a valid int, and the contract length is between 0 and 10
                    if (int.TryParse(lengthTxt.Text, out duration) && (duration >= minYear) && (duration <= maxYear))
                    {
                        double discount = 0;
                        //For loop to search for shipping provider
                        for (int x = 0; x < shippingProvider.Length && !providerFound; x++)
                        {
                            //If search is equal to the chosen shipping provider
                            if (shippingProvider[x] == providerCombo.Text)
                            {
                                providerFound = true; //Shipping provider is found
                                discount = discountLookup[x]; //Shipping provider discount is assigned to discount variable
                                provider = providerCombo.Text; //Chosen provider is assigned to chosen provider
                            }
                        }
                        //For loop to search for business
                        for (int x = 0; x < businessName.Length && !businessFound; x++)
                        {
                            //If business name search is equal to the business selected by the user
                            if (businessName[x] == businessCombo.Text)
                            {
                                businessFound = true; //Business name is found
                                initialPrice = priceLookup[x]; //Initial contract price for the chosen business is assigned to initialPrice

                            }
                        }
                        double contractDiscount = 0;
                        int index = minLength.Length - 1;
                        //While loop for range match
                        while (index >= 0 && !lengthFound)
                        {
                            if (duration >= minLength[index])
                            {
                                lengthFound = true;
                            }
                            else
                            {
                                --index;
                            }
                        }
                        //If length is found within a range
                        if (lengthFound)
                        {
                            contractDiscount = lengthDiscount[index]; //Contract length discount is assigned to contractDiscount
                        }

                        companyDiscount = initialPrice * discount;
                        finalPrice = initialPrice - companyDiscount - contractDiscount;

                        
                        //Output to labels
                        userProviderLbl.Text = $"{providerCombo.Text}";
                        userPriceLbl.Text = $"{initialPrice:C}"; 
                        userCompanyDiscountLbl.Text = $"{companyDiscount:C}"; 
                        userLengthLbl.Text = $"{contractDiscount:C}";
                        finalPriceLbl.Text = $"{finalPrice:C}";



                    }
                    //Message box that pops up if there the contract length that is input is invalid
                    else
                    {
                        MessageBox.Show("You Must Provide Valid Contract Years [0,10]");
                    }
                }
                //Message box that pops up if the user does not select a business
                else
                {
                    MessageBox.Show("You Must Select a Business.");
                }
            }
            //Message box that pops up if the user does not select a shipping provider
            else
            {
                MessageBox.Show("You Must Select a Provider.");
            }
        }
    }
}

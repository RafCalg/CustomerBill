using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomeBill1
{
    public partial class CalculateBill : Form
    {
        //declare BillTotal
        double billTotal;
        public bool validUsage;
        public bool validOffPeak;
        //Method to calculate residential bill
        private double residBill(double kwh)
        {
            double bill;
            bill = 6.0D + 0.052D * kwh;
            return bill;
        }
        //Method to calculate commercial bill
        private double commerBill(double kwh)
        {
            double bill;
            if (kwh <= 1000.0D)
            {
                bill = 60.0D;
            }
            else
            {
                bill = 60.0D + (kwh - 1000.0D) * 0.045D;
            }
            return bill;
        }

        //Method to calculate Industrial bill
        private double IndBill(double kwh, double kwhOff)
        {
            double billPeak;
            double billOffPeak;
            double bill;
            if (kwh <= 1000.0D && kwhOff <= 1000.0D)
            {
                billPeak = 76.0D;
                billOffPeak = 40.0D;
                bill = billPeak + billOffPeak;
                return bill;
            }
            else if (kwh > 1000 && kwhOff <= 1000.0D)
            {
                billPeak = 76.0D + (kwh - 1000.0D) * 0.065D;
                billOffPeak = 40.0D;
                bill = billPeak + billOffPeak;
                return bill;
            }
            else if (kwh > 1000 && kwhOff > 1000.0D)
            {
                billPeak = 76.0D + (kwh - 1000.0D) * 0.065D;
                billOffPeak = 40.0D + (kwhOff - 1000.0D) * 0.028D;
                bill = billPeak + billOffPeak;
                return bill;
            }
            else if (kwh <= 1000 && kwhOff > 1000.0D)
            {
                billPeak = 76.0D;
                billOffPeak = 40.0D + (kwhOff - 1000.0D) * 0.028D;
                bill = billPeak + billOffPeak;
                return bill;
            }
            else
            {
                MessageBox.Show("calculation failed");
                bill = -1;
                return bill;
            }

        }
        //Method to test validity of input usage kwh and offpeak kwh - They need to be whole positive numbers
        private bool inputTest(string input)
        {
            double validUsageInput;
            bool validInput;
            if (double.TryParse(input, out validUsageInput))
            {
                calculateButton.Enabled = true;
                validInput = true;
            }
            else if (input == "")
            {
                calculateButton.Enabled = false;
                validInput = false;
            }
            else
            {
                //haveValidInteger = false;
                calculateButton.Enabled = false;
                validInput = false;
                MessageBox.Show("Input needs to be a whole positive number");
            }
            return validInput;
        }

        public CalculateBill()
        {
            InitializeComponent();
        }

        //Calculate button operations
        private void calculateButton_Click(object sender, EventArgs e)
        {

            //string customerType = customerTypeBox.Text;

            double usage;
            double offPeak;
            switch (customerTypeComboBox.SelectedItem)
            {

                case "Residential":
                    if(validUsage == true)
                    {
                        usage= Convert.ToDouble(usageTextBox.Text);
                        billTotal = residBill(usage);
                        billTotalTextBox.Text = billTotal.ToString("c");
                    }
                    else
                    {
                        MessageBox.Show("Please input Usage Data");
                    }

                    break;
                case "Commercial":
                    if (validUsage == true)
                     {
                        usage = Convert.ToDouble(usageTextBox.Text);
                        billTotal = commerBill(usage);
                        billTotalTextBox.Text = billTotal.ToString("c");
                    }
                    else
                    {
                        MessageBox.Show("Please input Usage Data");
                    }
                    break;
                case "Industrial":
                    if (validUsage == true && validOffPeak == true)
                    {
                        offPeak = Convert.ToDouble(offPeakTextBox.Text);
                        usage = Convert.ToDouble(usageTextBox.Text);
                        billTotal = IndBill(usage, offPeak);
                        billTotalTextBox.Text = billTotal.ToString("c");
                    }
                    else
                    {
                        MessageBox.Show("Please input Peak AND off Peak Usage Data");
                    }

                    break;
            }
            
        }

        //Combo box selection of customer type and change to the form text box  display according to the selected type
        private void customerTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (customerTypeComboBox.SelectedItem)
            {
                case "Residential":
                    usageLabel.Text = "Usage kwh";
                    offPeakTextBox.Visible = false;
                    offPeakUsageLabel.Visible = false;
                    usageTextBox.Focus();
                    break;
                case "Commercial":
                    usageLabel.Text = "Usage kwh";
                    offPeakTextBox.Visible = false;
                    offPeakUsageLabel.Visible = false;
                    usageTextBox.Focus();
                    break;
                case "Industrial":
                    usageLabel.Text = "Peak Usage";
                    offPeakUsageLabel.Visible = true;
                    offPeakTextBox.Visible = true;
                    usageTextBox.Focus();
                    break;
            }
        }

        //"Clear All" Button - Clears all tet boxes, resets the form fields to the intial setup and reinitializes the customer type combo box
        private void button1_Click(object sender, EventArgs e)
        {
            usageLabel.Text = "Usage kwh";
            offPeakTextBox.Visible = false;
            offPeakUsageLabel.Visible = false;

            billTotalTextBox.Clear();
            offPeakTextBox.Clear();
            usageTextBox.Clear();
            customerTypeComboBox.SelectedIndex = -1;
            customerTypeComboBox.Focus();
        }

        //Exit button - Closes the form
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Usage Textbox event handling with call to the inputTest method to validate input
        private void usageTextBox_TextChanged(object sender, EventArgs e)
        {
            string input = usageTextBox.Text;
            validUsage = inputTest(input);
            
        }
        //Off Peak Textbox event handling with call to the inputTest method to validate input
        private void offPeakTextBox_TextChanged(object sender, EventArgs e)
        {
            string input = offPeakTextBox.Text;
            validOffPeak=inputTest(input);
         }
    }
    
}

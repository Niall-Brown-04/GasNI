using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace GasNI2
{
    public partial class Form1 : Form
    {
        // int MAX = 5;
        GasAccount[] gas = new GasAccount[5];
        int count = 0;


        public Form1()
        {
            InitializeComponent();

        }

            public void sortByBalance()
            {
                bool swap = true;
                while (swap == true)
                {
                    swap = false;
                    for (int position = 0; position < count - 1; position++)
                    {
                        if (gas[position].getBalance() > gas[position + 1].getBalance())
                        {
                            GasAccount temp = gas[position];
                            gas[position] = gas[position + 1];
                            gas[position + 1] = temp;
                            swap = true;
                        }//if
                    }//for
                }//while
            }//sortByBalance
             

             public void sortByRef()
             {
                bool swap = true;
                while (swap == true)
                {
                    swap = false;
                    for (int position = 0; position < count - 1; position++)
                    {
                        if (gas[position].getAccRefNo() > gas[position + 1].getAccRefNo())
                        {
                            GasAccount temp = gas[position];
                            gas[position] = gas[position + 1];
                            gas[position + 1] = temp;
                            swap = true;
                        }//if
                    }//for

                }//while
            }//sortByRef
             

            public void sortByName()
            {
                //list needed for a swap
                //gas
                //count
                //swap
                bool swap = true;
                while (swap == true)
                {
                    swap = false;
                    for (int position = 0; position < count - 1; position++) //first position to the second last position
                    {
                        if (gas[position].getName().CompareTo(gas[position + 1].getName()) > 0) //use "CompareTo() to sort non ints
                        {
                            //perform a swap
                            GasAccount temp = gas[position];//create a temp position to hold one account
                            gas[position] = gas[position + 1];//second account now = the first
                            gas[position + 1] = temp;         //put the temp position into the second
                            swap = true;


                        }//if
                    }//for
                }//while
            }//sortByName
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (count < 5)
            {
                //create a new gas account 
                GasAccount ga = new GasAccount(Convert.ToInt32(txtBoxAccRef.Text), txtBoxAccName.Text, txtBoxAccAddress.Text, Convert.ToDouble(txtBoxTotalUnitsUsed.Text));
                // MessageBox.Show("About to add a Gas Account at array position: " + count);
                gas[count] = ga;
                lstBoxCustomerAccounts.Items.Add(ga.getName());
                count++;

                //clear text boxes
                txtBoxAccRef.Text = "";
                txtBoxAccName.Text = "";
                txtBoxAccAddress.Text = "";
                txtBoxAccBalance.Text = "";
                txtBoxTotalUnitsUsed.Text = "";
                txtBoxUnitCost.Text = "";
            }
            else 
            {
                lblStatus.Text = "ALERT: System limit exceeded. Unable to create new Gas Account.";
            }
        }

        private void lstBoxCustomerAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstBoxCustomerAccounts.SelectedIndex;
            if(index < 0)
            {
                return;
            }

            txtBoxAccRef.Text = Convert.ToString(gas[index].getAccRefNo());
            txtBoxAccName.Text = gas[index].getName();
            txtBoxAccAddress.Text = gas[index].getAddress();
            txtBoxAccBalance.Text = Convert.ToString(gas[index].getBalance());
            txtBoxTotalUnitsUsed.Text = Convert.ToString(gas[index].getUnits());
            txtBoxUnitCost.Text = Convert.ToString(gas[index].getUnitCost());
        }

        private void btnRecordUnits_Click(object sender, EventArgs e)
        {
            if (lstBoxCustomerAccounts.SelectedIndex >= 0)
            {
                double units = Convert.ToDouble(txtBoxRecordUnits.Text);
                gas[lstBoxCustomerAccounts.SelectedIndex].recordUnits(units);

               
            }//if
            else
            {
                lblStatus.Text = "Please select an account from the list box";
            }//else
        }

        private void btnSort_Click(object sender, EventArgs e)
        {

            if (rdoByRef.Checked)
            {
                sortByRef();
                lblStatus.Text = "Sorted by account Reference";

                lstBoxCustomerAccounts.Items.Clear();

                for (int index = 0; index < count; index++)
                {
                    lstBoxCustomerAccounts.Items.Add(gas[index].getName());
                }
            }
            else if (rdoByBalance.Checked)
            {
                sortByBalance();
                lblStatus.Text = "Sorted by Balance";

                lstBoxCustomerAccounts.Items.Clear();

                for (int index = 0; index < count; index++)
                {
                    lstBoxCustomerAccounts.Items.Add(gas[index].getName());
                }
            }
            else
            {
                lblStatus.Text = "ERROR: Click radio button of your choice.";
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            int index = lstBoxCustomerAccounts.SelectedIndex;

            if(index <0)
            {
                lblStatus.Text = "Selected am account first";
                return;
            }

            for(int position = index; position < count-1; position++)
            {
                gas[position] = gas[position +1];  
            } //for

            gas[count -1] = null;
            count--;

            lstBoxCustomerAccounts.Items.RemoveAt(index);

            //re-display listbox
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (lstBoxCustomerAccounts.SelectedIndex >= 0)
            {
                // Get the selected GasAccount
                GasAccount selectedAccount = gas[lstBoxCustomerAccounts.SelectedIndex];

                // Get payment amount from text box
                if (double.TryParse(txtBoxPayment.Text, out double paymentAmount))
                {
                    // Attempt to make the payment
                    selectedAccount.deposit(paymentAmount);

                    // Update displayed account balance
                    DisplaySelectedAccountDetails();
                }
                else
                {
                    MessageBox.Show("Invalid payment amount. Please enter a valid number.");
                }
            }
            else
            {
                MessageBox.Show("Please select an account from the list.");
            }
        }
  
        

        private void DisplaySelectedAccountDetails()
        {
            int index = lstBoxCustomerAccounts.SelectedIndex;
            if (index >= 0)
            {
                // Update displayed balance for the selected account
                txtBoxAccBalance.Text = gas[index].getBalance().ToString("C");
            }
        }
    }
    }


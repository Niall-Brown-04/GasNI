using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasNI2
{
    internal class GasAccount
    {
        //fields
        private int intAccRefNo;
        private String strName, strAddress;
        private double dblBalance;
        private double dblUnits;
        private static double dblUnitCost = 0.02;

        //Constructor
        public GasAccount(int pNewAccRefNo, String pNewName, String pNewAddress, double pNewUnits)
        {
            this.intAccRefNo = pNewAccRefNo;
            this.strAddress = pNewAddress;
            this.strName = pNewName;
            this.dblUnits = pNewUnits;
            //balance is calculated using unit cost * units
            dblBalance = dblUnits * dblUnitCost;
        }

        public GasAccount(int pNewAccRefNo, String pNewName, String pNewAddress)
        {
            this.intAccRefNo = pNewAccRefNo;
            this.strName = pNewName;
            this.strAddress = pNewAddress;
            dblBalance = dblUnits * dblUnitCost;
            //GasAcc
        }

        public void deposit(double pDepositAmount)
        {
            dblBalance = dblBalance - pDepositAmount;
            //deposit
        }

        public string recordUnits(double pUnitsUsed)
        {

            // A method to record the units read from a meter reading. 
            // The meter reading, pUnitsUsed, value is passed into this method and is used to calculate the current cost,
            // which in turn will be added to current balance of a GasAccount object.
            if (pUnitsUsed > 0)
            {
                double currentCost = pUnitsUsed * dblUnitCost;
                dblBalance = dblBalance + currentCost;
                dblUnits = dblUnits + pUnitsUsed;
                return "Transaction Successful";
            }
            else
            {
                return "Transaction Unsuccessful";
            }
            //RecordUnits
        }

        //Getters
        public int getAccRefNo()
        {
            return intAccRefNo;
            //GetintAccRefNo
        }

        public string getName()
        {
            return strName;
            //GetName
        }

        public string getAddress()
        {
            return strAddress;
            //GetAddress
        }

        public double getBalance()
        {
            return dblBalance;
            //GetsBalance
        }

        public double getUnitCost()
        {
            return dblUnitCost;
            //GetsUnitCost
        }

        public double getUnits()
        {
            return dblUnits;
            //GetsUnits

        }

        public static void updateUnitCost(double pNewUnitCost)
        {
            dblUnitCost = pNewUnitCost;
        }
    }
}

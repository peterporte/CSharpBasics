using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;
using Convert = System.Convert;

namespace Section7
{
    public class Receipt
    {
        //Variables
        private int receiptNumber;
        private string dateOfPurchase;
        private int customerNumber;
        private string customerFirstName;
        private string customerLastName;
        private string customerPhoneNumber;
        private int itemNumber;
        private string description;
        private double unitPrice;
        private int quantity;
        private double totalPurchase;


        //Constructor
        public Receipt(int receiptNum, string date, int custNum, string custFirstName, string customerLastName, string customerPhone, int itemNum,
            string desc, double unitPrce, int qty)
        {
            ReceiptNumber = receiptNum;
            DateofPurchase = date;
            CustomerNumber = custNum;
            CustomerFirstName = custFirstName;
            CustomerLastName = customerLastName;
            CustomerPhoneNumber = customerPhone;
            ItemNumber = itemNum;
            Description = desc;
            UnitPrice = unitPrce;
            Quantity = qty;
        }


        //Accessors
        public int ReceiptNumber
        {
            get { return receiptNumber; }
            set
            {
                // returns default zero condition is not true
                if (value > 0)
                {
                    receiptNumber = value;
                }
                else
                {
                    Console.WriteLine("Recept number should be more than zero");
                }

            }
        }

        public string DateofPurchase
        {
            get; set; 

        }

        public int CustomerNumber
        {
            // returns default zero condition is not true
            get { return customerNumber; }
            set
            {
                if (value > 0)
                {
                    customerNumber = value;
                }
             
            } 

        }

        public string CustomerFirstName
        {
            get; set; 

        }

        public string CustomerLastName
        {
            get; set;

        }

        public string CustomerPhoneNumber
        {
            get; set; 

        }

        public int ItemNumber
        {
            get { return itemNumber; }
            set
            {
                if (value > 0 && value < 9999)
                {
                    itemNumber = value;
                }
                
            } 

        }

        public string Description
        {
            get; set; 

        }

        public double UnitPrice
        {
            get { return unitPrice; }
            set
            {
                if (value > 0 && value < 9999)
                {
                    unitPrice = value;
                }
              
  
            }

        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value > 0 && value < 9999)
                {
                    quantity = value;
                }
                
            }

        }


        //Methods
        public double TotalCost()
        {
            return UnitPrice * Quantity;
        }


        public override string ToString()
        {
            return "Customer: " + CustomerFirstName + CustomerLastName +
                   "\nPhone: " + CustomerPhoneNumber +
                   "\nTotal Purchases: " + TotalCost().ToString("C");
        }
             

    }
}

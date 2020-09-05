using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_4;


namespace Lab_6
{
    class Customer : PersonV2
    {
        private DateTime customerSince; //
        private double totalPurchases;
        //private bool discountMember;
        private int rewardsEarned;


        public DateTime CustomerSince
        {
            get
            {
                return customerSince;
            }

            set
            {

                //if validation library determined it was good set valeu
                if (ValidationLibrary.checktheFuture(value) == false)
                {
                    customerSince = value;
                }
                else
                {
                    Feedback += "\nINVALID: Error: Customer Since Date REQUIRED- Make sure to add past date-EX 2/10/2000";
                }
            }
        }




        //=================
        //public double TotalPurchases
        //{
           // get
           // {
               // return totalPurchases;
           // }
    
           // set
            //{
              //  if (value == Convert.ToDouble(""))
              //  {
             //       totalPurchases = value;
             //   }
                
                //if (totalPurchases = "")
                //{
                    //totalPurchases = value;
               // }
                //else
                //{
                    //Feedback += "\nINVALID: Error: Do not Leave Blank";
                //}
          //  }
     //   }

        //==============================
        
//==============================
public int RewardsEarned
        {
            get
            {
                return rewardsEarned;
            }

            set
            {
               
                if (ValidationLibrary.objectminimum(value,0) == true)
                {
                    rewardsEarned = value;
                }
                else
                {
                    Feedback += "\nINVALID: Error: Rewards value has to have a minimum amount of Zero or greater EX 56";
                }
            }
        }

      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class ValidationLibrary //begins the validation Library
    {
        //Protects code from including the poop name
        public static bool word_blocker(string temp)
        {
            //sets bool =  to true and if poop is found changes the value to false
            bool result = false;
            if (temp.ToUpper().Contains("poop".ToUpper())) 
            {
                result = true;
            }
            if (temp.ToUpper().Contains("homework".ToUpper()))
            {
                result = true;
            }
            if (temp.ToUpper().Contains("bad".ToUpper()))
            {
                result = true;
            }
            if (temp.ToUpper().Contains("evil".ToUpper()))
            {
                result = true;
            }
            return result;


        }
        //Checks to make sure atleast something was left added in
        public static bool IsFilledIn(string temp)
        {
            //sets bool value = to false and if value is greater then 1 it becomes true
            bool result = false;
            if (temp.Length > 0)
            {
                result = true;
            }

            return result;
        }

        //Checks there is a minimum length the same as fill but modified
        public static bool IsFilledmin(string temp, int minlen)
        {
            //Uses the same formula with a minimum however to secure minimum length is secure
            bool result = false;
            if (temp.Length >= minlen)
            {
                result = true;
            }
            return result;
        }


        //Same function but for double

        public static bool IsFilledmin(double temp, int minlen)
        {
            //Uses the same formula with a minimum however to secure minimum length is secure
            bool result = false;
            if (temp >= minlen)
            {
                result = true;
            }
            return result;
        }
        public static bool IsFilledIn_max(string temp, int max_length)
        {
            //secures user types in maximum length such as for phone numbers and zip codes in the usa
            bool result = false;
            if (temp.Length == max_length)
            {
                result = true;
            }
            return result;
        }

        public static bool Phone_checker(string temp) // A phone checker to secure typed in phone includes dashes seperating its values
        {
            bool blnResult = true;
            //Searches for -
            int Phone_divider = temp.IndexOf("-");
            int Next_Phone_Divider = temp.IndexOf("-", Phone_divider + 1); // searches for values index then adds 1 to it if its less the 2 it remains true 

            //Loks for position of last period

            if (Next_Phone_Divider >= 2 && temp.Length >= 12)
            {
                blnResult = false;
            }


            return blnResult;

        }

      
        public static bool ValidEmail(string temp) // searches for the @ symbol to secure correct email format is typed in
        {
            bool blnResult = true;
            //Searches for @
            int atLocation = temp.LastIndexOf("@");
            int periodlocation = temp.LastIndexOf(".");
            int length_spot = temp.Length -3; // validating location of period is atlest before some writing


            int index_atandped = atLocation + 3; //validating atleast a 2 word is between
            //Loks for position of last period
            
            if (temp.ToUpper().Contains("@".ToUpper()) && (periodlocation >= index_atandped) && (periodlocation <= length_spot) && (atLocation >=3))
            {
                blnResult = false;
            }
            

            return blnResult;

        }

        public static bool InstagramURL_valid(string temp) // searches for the @ symbol to secure correct email format is typed in
        {
            bool blnResult = true;
            //Searches for 



            
            if (temp.ToUpper().Contains("Instagram.com/".ToUpper()))
            {
                blnResult = false;
            }


            if (temp.Length <= 14)
            {

                blnResult = true;
            }
            return blnResult;

        }

        public static bool checktheFuture(DateTime temp)
        {
            bool blnResult;

            if (temp <= DateTime.Now)
            {
                blnResult = false;
            }
            else
            {
                blnResult = true;
            }

            return blnResult;
        }


        public static bool moneyminimum(double temp, double minimum_amount)
        {
            bool blnResult;

            if (temp >= minimum_amount)
            {
                blnResult = true;
            }
            else
            {
                blnResult = false;
            }

            return blnResult;
        }

        public static bool objectminimum(int temp, int minimum_amount)
        {
            bool blnResult;

            if (temp >= minimum_amount)
            {
                blnResult = true;
            }
            else
            {
                blnResult = false;
            }

            return blnResult;
        }










    }
}

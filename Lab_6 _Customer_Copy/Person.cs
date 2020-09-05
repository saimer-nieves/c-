using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_4;

namespace Lab_5_Midterm
{
    class Person
    {
        private string first_name;
        private string middle_name;
        private string last_name;
        private string street_1;
        private string street_2;
        private string city;
        private string state;
        private string zip_code;
        private string phone_number;
        private string email_address;
        

        private string feedback = "";

        //end of categories


        public string Feedback
        {
            get
            {
                return feedback;

            }
            set
            {
                if (value == "")
                {
                    feedback = "NO Middle Name";
                }

                else
                {
                    feedback = value;
                }
            }

        }

        public string First_name
        {
            get
            {
                return first_name;

            }
            set
            {
                if (ValidationLibrary.word_blocker(value) == true) //included library poop blocker to block the word poop
                {
                    feedback += "\nINVALID: Your first name contains bad words"; // addvises the user why its data was not inputed
                }

                else if ((ValidationLibrary.IsFilledIn(value) == true) && (ValidationLibrary.word_blocker(value) == false))
                {
                    first_name = value;
                }
                else
                {
                    feedback += "\nINVALID: first name REQUIRED- Please type in a valid First name"; // advises the user its date was not valid if left blank
                }
            }

        }

        public string Middle_name
        {
            get
            {
                return middle_name;

            }
            set
            {
                if (value == "")
                {
                    middle_name = "(No Middle Name/ or person left blank)";
                }
                if (ValidationLibrary.word_blocker(value) == true) //included library poop blocker to block the word poop
                {
                    feedback += "\nINVALID: Your middle name contains bad words"; // addvises the user why its data was not inputed
                }

                else
                {
                    middle_name = value;
                }
            }

        }

        public string Last_name
        {
            get
            {
                return last_name;

            }
            set
            {
                

                if (ValidationLibrary.word_blocker(value) == true) //included library poop blocker to block the word poop
                {
                    feedback += "\nINVALID: Your Last name contains bad words"; // addvises the user why its data was not inputed
                }

                else if ((ValidationLibrary.IsFilledIn(value) == true ) && (ValidationLibrary.word_blocker(value) == false))
                {
                    last_name = value;
                }
                else
                {
                    feedback += "\nINVALID: Last name REQUIRED- Please type in a valid Last name";
                }

            }

        }

        public string Street_1
        {
            get
            {
                return street_1;

            }
            set
            {
                if (ValidationLibrary.IsFilledIn(value) == true)
                {
                    street_1 = value;
                }

                else
                {
                    feedback += "\nINVALID: Street Address REQUIRED- Please type in a valid 1st Street Address";
                }


            }

        }

        public string Street_2
        {
            get
            {
                return street_2;

            }
            set
            {
                if (value == "")
                {
                    street_2 = value + "(No 2nd Street Address/ or person left blank)";
                }

                else
                {
                    street_2 = value;
                }

            }

        }

        public string City
        {
            get
            {
                return city;

            }
            set
            {
                if (ValidationLibrary.IsFilledIn(value) == true)
                {
                    city = value;
                }

                else
                {
                    feedback += "\nINVALID: City REQUIRED- Please type in a valid City";
                }


            }

        }

        public string State
        {
            get
            {
                return state;

            }
            set
            {

                if (ValidationLibrary.IsFilledIn_max(value, 2) == true)
                {
                    state = value;
                }

                else
                {
                    feedback += "\nINVALID: State Initials REQUIRED- Please type in a valid State Inital -> Example (New York => NY)";
                }

            }

        }

        public string Zip_code
        {
            get
            {
                return zip_code;

            }
            set

            {
                if ((ValidationLibrary.IsFilledIn(value) == true) && (ValidationLibrary.IsFilledIn_max(value, 5) == true))
                {
                    zip_code = value;
                }

               
                else
                {
                    feedback += "\nINVALID: Zip Code REQUIRED- EVERY ZIP CODE IS 5 NUMBERS (EXAMPLE = 02861)";
                }
            }

        }

        public string Phone_number
        {
            get
            {
                return phone_number;

            }
            set
            {

                if (ValidationLibrary.Phone_checker(value) == false)
                {
                    phone_number = value;
                }

                else
                {
                    feedback += "\nINVALID: Phone Number REQUIRED- make sure to include dashes and area code EX 401-777-7777";
                }



            }

        }

        public string Email_address
        {
            get
            {
                return email_address;

            }
            set
            {
                if (ValidationLibrary.ValidEmail(value) == false)
                {

                    email_address = value;
                }
                else
                {
                    feedback += "\nINVALID: Email Address REQUIRED- Please type in a valid Email -> FORMAT (EX:  GeorgerLucas@gmail.com)";
                }
            }

        }

        public Person()
        {
             first_name = "";
             middle_name = "";
             last_name = "";
             street_1 = "";
             street_2 = "";
             city = "";
             state = "";
             zip_code = "";
             phone_number = "";
             email_address = "";
        }
        
    }
}

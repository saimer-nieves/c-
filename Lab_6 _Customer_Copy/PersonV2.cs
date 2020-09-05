using Lab_5_Midterm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Lab_4;
using System.Data;
using System.Data.SqlClient;//SQL client allows to interact with the sql server more effienctly //oled universal data base server so it may not be using the most effeienct 
using System.Security.Principal;

namespace Lab_6
{
    class PersonV2 : Person
    {
        private string cell_phone;
        private string instagramURL;


        public string Cell_phone
        {
            get 
            {
                return cell_phone;
            }
            
            set 
            {
                //if validation library determined it was good set valeu
                if (ValidationLibrary.Phone_checker(value)== false)
                {
                    cell_phone = value;
                }
                else
                {
                    Feedback += "\nINVALID: Error: Cell Phone Number REQUIRED- make sure to include dashes and area code EX 401-777-7777";
                }
            }
        }

        public string InstagramURL
        {
            get
            {
                return instagramURL;
            }

            set
            {
                
                
                //if validation library determined it was good set valeu
               
                 
                 if(ValidationLibrary.InstagramURL_valid(value) == false)
                {
                    instagramURL = value;
                }
                else 
                { 

                    Feedback += "\nINVALID: Error: Instagram URL REQUIRED- make sure to include (Instagram.com/) infront of URL EX: Instagram.com/accountname";
                }
               

            }
        }

        public string AddARecord()
        {
            //Init string var
            string strResult = "";

            //Make a connection object
            SqlConnection Conn = new SqlConnection();

            //Initialize it's properties
            Conn.ConnectionString = @"Server=sql.neit.edu,4500;Database=SE245_SNieves;User Id=SE245_SNieves;Password=008008712;";     //Set the Who/What/Where of DB


            //*******************************************************************************************************
            // NEW
            //*******************************************************************************************************
            string strSQL = "INSERT INTO [SE245_SNieves].[dbo].[PersonV2_Table] (First_name, Middle_name, Last_name, Street_1, Street_2, City, State, Zip_code,Phone_number,Cell_phone, Email_address, InstagramURL) VALUES (@First_name, @Middle_name, @Last_name, @Street_1, @Street_2, @City, @State, @Zip_code,@Phone_number,@Cell_phone, @Email_address, @InstagramURL)";
            // Bark out our command
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;  //Commander knows what to say
            comm.Connection = Conn;     //Where's the phone?  Here it is

            //Fill in the paramters (Has to be created in same sequence as they are used in SQL Statement)
            comm.Parameters.AddWithValue("@First_name", First_name);
            comm.Parameters.AddWithValue("@Middle_name", Middle_name);
            comm.Parameters.AddWithValue("@Last_name", Last_name);
            comm.Parameters.AddWithValue("@Street_1", Street_1);
            comm.Parameters.AddWithValue("@Street_2", Street_2);
            comm.Parameters.AddWithValue("@City", City);
            comm.Parameters.AddWithValue("@State", State);
            comm.Parameters.AddWithValue("@Zip_code", Zip_code);
            comm.Parameters.AddWithValue("@Phone_number", Phone_number);
            comm.Parameters.AddWithValue("@Cell_phone", Cell_phone);
            comm.Parameters.AddWithValue("@Email_address", Email_address);
            comm.Parameters.AddWithValue("@InstagramURL", InstagramURL);


            //==============================barkng orders////////////////////////////////





            //attempt to connect to the server
            try
            {
                Conn.Open();                                        //Open connection to DB - Think of dialing a friend on phone
                int intRecs = comm.ExecuteNonQuery();
                strResult = $"SUCCESS: Inserted {intRecs} records.";       //Report that we made the connection and added a record
                Conn.Close();                                       //Hanging up after phone call
            }
            catch (Exception err)                                   //If we got here, there was a problem connecting to DB
            {
                strResult = "ERROR: " + err.Message;                //Set feedback to state there was an error & error info
            }
            finally
            {

            }



            //Return resulting feedback string
            return strResult;
        }

        public PersonV2()
        {
         cell_phone = "";
         instagramURL = "Instagram.com/";
        }
    }

        







    
}

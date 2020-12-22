using System;
using System.Collections.Generic;
using System.Text;

/*
 * Title:   Person User
 * Author:  Paul McKillop
 * Date:    November 2020
 * Purpose: INHERITED class from Person. User data
 */

namespace FlooringCalculator.Models
{
    public class PersonUser : Person
    {
        // -- Data member fields/properties
        public string MobileNumber { get; set; }
        public string ClientCompany { get; set; }

        private string username;

        public string Username
        {
            get => username;
            set => username = value;
        }

        private string password;

        public string Password
        {
            get => password;
            set => password = value;
        }


        /// <summary>
        /// Same as PersonAdmin
        /// Polymorphism used to derive data in context.
        /// </summary>
        /// <returns></returns>
        public override string GetDetails()
        {
            // -- this data comes from the Parent class method member
            string baseDetails = base.GetDetails();

            //  -- format the original found data and concatenate the data from the child class
            StringBuilder stringBuilder = new StringBuilder();
            var sb = stringBuilder;
            sb.Append(baseDetails).AppendLine();
            sb.Append("Mobile number: ").Append(MobileNumber).AppendLine();
            sb.Append("Company: ").Append(ClientCompany).AppendLine();

            // -- return the data
            return sb.ToString();

        }


        /// <summary>
        /// Development test and debug method
        /// </summary>
        /// <returns>PersonUser object</returns>
        public static PersonUser SampleUser()
        {
            var personUser = new PersonUser
            {
                PersonForename = "Mariam",
                PersonSurname = "Vance",
                username = "mvance0001",
                password = "hardcodedtestpassword"
            };


            return personUser;
        }
    }
}


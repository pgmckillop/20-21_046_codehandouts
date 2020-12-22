using System;
using System.Collections.Generic;
using System.Text;

/*
 * Title:   Login
 * Author:  Paul McKillop
 * Date:    November 2020
 * Purpose: Simulate accessing an authentication service
 */

namespace FlooringCalculator.Models
{
    public class Login
    {
        public static bool Validate(string username, string password)
        {
            var validity = false;

            var debugUsername = "mvance0001";
            var debugPassword = "hardcodedtestpassword";

            try
            {
                validity = (username == debugUsername) && (password == debugPassword);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }




            return validity;
        }
    }
}

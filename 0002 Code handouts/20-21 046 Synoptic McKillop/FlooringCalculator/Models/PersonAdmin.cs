using System;
using System.Collections.Generic;
using System.Text;

/*
 * Title:   PersonAdmin
 * Author:  Paul McKillop
 * Date:    November 2020
 * Purpose: INHERITED class from Person. Admin data
 */

namespace FlooringCalculator.Models
{
    public class PersonAdmin : Person
    {
        // -- data member
        public string Department { get; set; }

        /// <summary>
        /// Polymorphic method that will bubble up to the parent class if called
        /// when a person is initialised as an object.
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
            sb.Append("Works in: ").Append(Department);
            sb.AppendLine();

            // -- return the complete data
            return sb.ToString();
        }
    }
}

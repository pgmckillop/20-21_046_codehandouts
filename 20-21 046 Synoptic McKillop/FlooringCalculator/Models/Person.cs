using System;
using System.Collections.Generic;
using System.Text;

/*
 * Title:   Person
 * Author:  Paul McKillop
 * Date:    November 2020
 * Purpose: Holds base data about persons
 */

namespace FlooringCalculator.Models
{
    public class Person
    {
        // -- Data member fields
        private string personForename;

        public string PersonForename
        {
            get => personForename;
            set => personForename = value;
        }

        private string personSurname;

        public string PersonSurname
        {
            get => personSurname;
            set => personSurname = value;
        }

        /// <summary>
        /// Concatenation method
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public static string PersonWholeNameByForename(Person person)
        {
            return person.personForename + " " + person.personSurname;
        }

        /// <summary>
        /// Alternative using same data
        /// Concat in a different order
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public static string PersonWholeNameBySurname(Person person)
        {
            return person.personSurname + ", " + person.personForename;
        }

        /// <summary>
        /// Polymorphism demonstration
        /// The method here is designed to be 'overridden' in children classes
        /// </summary>
        /// <returns>string same as PersonWholeNameByForename</returns>
        public virtual string GetDetails()
        {
            StringBuilder stringBuilder = new StringBuilder();
            var sb = stringBuilder;
            sb.Append(personForename).Append(" ").Append(personSurname);

            return sb.ToString();
        }
    }
}

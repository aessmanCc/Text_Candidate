using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Canidates
{
    public static class Validator
    {
        private static string lineEnd = "\n";

        public static string LineEnd
        {
            get
            {
                return lineEnd;
            }
            set
            {
                lineEnd = value;
            }
        }

        //Check if string is present.
        public static string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg += name + " is a required field." + LineEnd;
            }
            return msg;
        }

        //Check if value is an integer.
        public static string IsInt32(string value, string name)
        {
            string msg = "";
            if (!long.TryParse(value, out _))
            {
                msg += name + " must be a valid integer value." + LineEnd;
            }
            return msg;
        }

        //Check if value is within specified range.
        public static string IsWithinRange(string value, string name, decimal min,
            decimal max)
        {
            string msg = "";
            if (Decimal.TryParse(value, out decimal number))
            {
                if (number < min || number > max)
                {
                    msg += name + " must be between " + min + " and " + max + "." + LineEnd;
                }
            }
            return msg;
        }

        public static string PhoneProvider(int value, string name)
        {
            string msg = "";
            if (value == -1)
            {
                msg = "You Must select a phone provider";
            }
            return msg;

        }

    }
}

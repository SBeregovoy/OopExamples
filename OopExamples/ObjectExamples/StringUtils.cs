using System;
using System.Collections.Generic;
using System.Text;

namespace OopExamples.ObjectExamples
{
    public static class StringUtils
    {
        /// <summary>
        /// Фамилия И. О.
        /// </summary>
        public static string ShortName(string lastname, string firstname, string middlename)
        {
            if (string.IsNullOrEmpty(lastname))
                return null;

            if (!string.IsNullOrEmpty(firstname) && !string.IsNullOrEmpty(middlename))
            {
                return string.Format("{0} {1}. {2}.", lastname, firstname.Substring(0, 1), middlename.Substring(0, 1));
            }
            if (!string.IsNullOrEmpty(firstname))
            {
                return string.Format("{0} {1}.", lastname, firstname.Substring(0, 1));
            }
            if (!string.IsNullOrEmpty(middlename))
            {
                return string.Format("{0} {1}.", lastname, middlename.Substring(0, 1));
            }
            return lastname;
        }

        /// <summary>
        /// Trim
        /// </summary>
        public static string TrimIfNotNull(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }

            return str.Trim();
        }

        /// <summary>
        /// Uppercase first character
        /// </summary>
        public static string FirstLetterToUpper(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }

            str = str.Trim();

            if (str.Length == 0)
            {
                return str;
            }

            if (str.Length == 1)
            {
                return str.ToUpper();
            }

            return char.ToUpper(str[0]) + str.Substring(1);
        }
    }
}

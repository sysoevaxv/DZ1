using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DemoPodgotovka
{
    public static class Email
    {
        public const string pattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";

        public static bool IsEmail (string email)
        {
            if (email != null) return Regex.IsMatch(email, pattern);
            else return false;
        }
    }
}

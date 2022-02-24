using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExtensionMethods
{
    public static class StringExtensionMethods
    {
        internal static string ReplaceFirstOccurrence(this string mainString, string pattern, string replace)
        {
            int pos = mainString.IndexOf(pattern);
            if (pos < 0)
            {
                return mainString;
            }
            return mainString.Substring(0, pos) + replace + mainString.Substring(pos + pattern.Length);
        }

    }
}

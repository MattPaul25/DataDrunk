using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataDrunk.Applications
{
    public static class StringUtils
    {
        public static string Left(string yourString, int PlaceMent)
        {
            return yourString.Substring(0, PlaceMent);
        }
        public static string Right(string yourString, int PlaceMent)
        {
            return yourString.Substring(PlaceMent, yourString.Length - PlaceMent);
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._DateModifier
{
    public class DateModifier
    {
        public double TimeSpan(string date1,string date2)
        {
            int[]d1Info= date1
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            DateTime d1 = new(d1Info[0], d1Info[1], d1Info[2]);
            int[] d2Info = date2
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            DateTime d2 = new(d2Info[0], d2Info[1], d2Info[2]);
            TimeSpan t = d1 - d2; 

            return Math.Abs(t.TotalDays);
        }
    }
}

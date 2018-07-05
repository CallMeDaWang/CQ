using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQ.Utils
{
    public class Common
    {
        public static String GetPercentResult(int a, int b)
        {
            String result = "{0}%";
            if (b == 0)
            {
                return result;
            }
            float c = (float)a / b;
            float x = (float)Math.Round((double)c, 4);
            return string.Format(result, x * 100);
        }
    }
}

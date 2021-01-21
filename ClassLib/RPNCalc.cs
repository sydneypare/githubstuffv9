using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class RPNCalc 
    {
        List<string> Calcstrings = new List<string>();




        public double calculate(string item)
        {
            double ret = 1.1;

            //confusion = 100%
            //plus ive run outta time sadly

            foreach (string s in Calcstrings)
            {
                Stack280L<string> stack = new ClassLib.Stack280L<string>();

               // if(s == operator)
            }




            return ret;
        }
    }
}

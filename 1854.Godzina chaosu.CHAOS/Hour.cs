using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1854.Godzina_chaosu.CHAOS
{
    public class Hour
    {
        public int hours { get; set; }
        public int minutes { get; set; }
        public bool isPalindromic()
        {
            StringBuilder sbtest = new StringBuilder();
            if(hours == 0)
            {
                sbtest.Append(minutes.ToString());
            }
            else
            {
                sbtest.Append(hours.ToString());
                if(minutes < 10)
                {
                    sbtest.Append("0" + minutes.ToString());
                }
                else
                {
                    sbtest.Append(minutes.ToString());
                }  
            }
            int length = sbtest.Length;

            for (int i = 0; i < length; i++)
            {
                if (sbtest[i] != sbtest[length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
        public void later()
        {
            if (minutes < 59)
            {
                ++minutes;
            }
            else
            {
                minutes = 0;
                if (hours < 23)
                {
                    ++hours;
                }
                else
                {
                    hours = 0;
                }

            }

        }
        public string toString(bool nice = false)
        {
            StringBuilder sb = new StringBuilder();
            if(hours.ToString().Length == 1)
            {
                sb.Append("0" +hours.ToString() +":");
            }
            else
            {
                sb.Append(hours.ToString() + ":");
            }
            if(minutes.ToString().Length == 1)
            {
                sb.Append("0" +minutes.ToString());
            }
            else
            {
                sb.Append(minutes.ToString());
            }
            return sb.ToString();
        }
    }
}

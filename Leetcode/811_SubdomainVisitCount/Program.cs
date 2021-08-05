using System.Linq;
using System.Collections.Generic;
using System;

namespace _811_SubdomainVisitCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", SubdomainVisits(new string[] { "9001 discuss.leetcode.com" })));
            Console.WriteLine(String.Join(" ", SubdomainVisits(new string[] { "900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org" })));
        }

        public static IList<string> SubdomainVisits(string[] cpdomains)
        {
            Dictionary<string, int> tmp = new Dictionary<string, int>();

            foreach (var domain in cpdomains)
            {
                string[] div = domain.Split();
                int c = int.Parse(div[0]);
                string[] w = div[1].Split('.');
                string dom = "";
                for (int i = w.Length - 1; i >= 0; i--)
                {
                    if (i != w.Length - 1)
                    {
                        dom = w[i] + "." + dom;
                    }
                    else
                    {
                        dom = w[i] + dom;
                    }

                    if (tmp.ContainsKey(dom))
                    {
                        tmp[dom] += c;
                    }
                    else
                    {
                        tmp[dom] = c;
                    }

                }
            }

            var res = new List<string>();

            foreach (var item in tmp)
            {
                res.Add(item.Value + " " + item.Key);
            }
            return res;
        }
    }
}






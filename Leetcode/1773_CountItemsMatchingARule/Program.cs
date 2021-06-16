using System;
using System.Collections.Generic;

namespace _1773_CountItemsMatchingARule
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountMatches(
                new List<IList<string>> {
                    new List<string> { "phone", "blue", "pixel" },
                    new List<string> { "computer", "silver", "lenovo" },
                    new List<string> {"phone","gold","iphone"}
                },
                "type",
                "phone"));
        }

        public static int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            int res = 0;
            int col = 0;
            switch (ruleKey)
            {
                case "type":
                    col = 0;
                    break;
                case "color":
                    col = 1;
                    break;
                case "name":
                    col = 2;
                    break;
            }

            foreach (var i in items)
            {
                if (i[col] == ruleValue)
                {
                    res++;
                }
            }

            return res;
        }
    }
}

using System;
using System.Text;

namespace StringTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            StringBuilder result = new StringBuilder();

            foreach (var item in input){
                if (item != 'a' && item!='i' && item != 'y' && item!='o' &&
                    item!='e' && item!='u'){
                    result.Append('.').Append(item);
                }
            }

            Console.WriteLine(result);
        }
    }
}

using System;

namespace PetyaAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine().ToLower();
            string second = Console.ReadLine().ToLower();

            string result = "0";
            for (int i = 0; i < first.Length; i++){
                if (first[i] > second[i]){
                    result = "1";
                    break;
                }
                if (first[i] < second[i]){
                    result = "-1";
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}

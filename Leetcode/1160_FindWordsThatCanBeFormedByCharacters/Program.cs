using System;
using System.Collections.Generic;

namespace _1160_FindWordsThatCanBeFormedByCharacters {
    class Program {
        static void Main (string[] args) {
            string[] words = new string[] {
                "cat",
                "bt",
                "hat",
                "tree"
            };

            Console.WriteLine (CountCharacters (words, "attach"));

            words = new string[] {
                "hello",
                "world",
                "leetcode"
            };
            Console.WriteLine (CountCharacters (words, "welldonehoneyr"));

            words = new string[] {
                "dyiclysmffuhibgfvapygkorkqllqlvokosagyelotobicwcmebnpznjbirzrzsrtzjxhsfpiwyfhzyonmuabtlwin",
                "ndqeyhhcquplmznwslewjzuyfgklssvkqxmqjpwhrshycmvrb",
                "ulrrbpspyudncdlbkxkrqpivfftrggemkpyjl",
                "boygirdlggnh",
                "xmqohbyqwagkjzpyawsydmdaattthmuvjbzwpyopyafphx",
                "nulvimegcsiwvhwuiyednoxpugfeimnnyeoczuzxgxbqjvegcxeqnjbwnbvowastqhojepisusvsidhqmszbrnynkyop",
                "hiefuovybkpgzygprmndrkyspoiyapdwkxebgsmodhzpx",
                "juldqdzeskpffaoqcyyxiqqowsalqumddcufhouhrskozhlmobiwzxnhdkidr",
                "lnnvsdcrvzfmrvurucrzlfyigcycffpiuoo",
                "oxgaskztzroxuntiwlfyufddl",
                "tfspedteabxatkaypitjfkhkkigdwdkctqbczcugripkgcyfezpuklfqfcsccboarbfbjfrkxp",
                "qnagrpfzlyrouolqquytwnwnsqnmuzphne",
                "eeilfdaookieawrrbvtnqfzcricvhpiv",
                "sisvsjzyrbdsjcwwygdnxcjhzhsxhpceqz",
                "yhouqhjevqxtecomahbwoptzlkyvjexhzcbccusbjjdgcfzlkoqwiwue",
                "hwxxighzvceaplsycajkhynkhzkwkouszwaiuzqcleyflqrxgjsvlegvupzqijbornbfwpefhxekgpuvgiyeudhncv",
                "cpwcjwgbcquirnsazumgjjcltitmeyfaudbnbqhflvecjsupjmgwfbjo",
                "teyygdmmyadppuopvqdodaczob",
                "qaeowuwqsqffvibrtxnjnzvzuuonrkwpysyxvkijemmpdmtnqxwekbpfzs",
                "qqxpxpmemkldghbmbyxpkwgkaykaerhmwwjonrhcsubchs"
            };
            Console.WriteLine (CountCharacters (words, "usdruypficfbpfbivlrhutcgvyjenlxzeovdyjtgvvfdjzcmikjraspdfp"));

        }

        public static int CountCharacters (string[] words, string chars) {
            Dictionary<char, int> word = new Dictionary<char, int> ();

            foreach (char c in chars) {
                //Console.WriteLine (c);
                if (word.ContainsKey (c)) {
                    word[c]++;
                } else {
                    word.Add (c, 1);
                }
            }
            int res = 0;
            foreach (string w in words) {
                bool e = true;
                Dictionary<char, int> t = new Dictionary<char, int> ();
                foreach (char c in w) {
                    //Console.Write (c);
                    if (!word.ContainsKey (c)) {
                        e = false;
                        break;
                    }

                    if (t.ContainsKey (c)) {
                        t[c]++;
                    } else {
                        t.Add (c, 1);
                    }

                    if ((word[c] - t[c]) < 0) {
                        e = false;
                        break;
                    }
                }
                if (e) {
                    //Console.WriteLine (e + " " + w.Length);
                    res += w.Length;
                }
            }
            return res;
        }
    }
}
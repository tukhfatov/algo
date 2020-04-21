using System;

namespace _804_UniqueMorseCodeWords {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Hello World!");
        }

        public static int UniqueMorseRepresentations (string[] words) {
            string[] morse = new string[] {
                ".-",
                "-...",
                "-.-.",
                "-..",
                ".",
                "..-.",
                "--.",
                "....",
                "..",
                ".---",
                "-.-",
                ".-..",
                "--",
                "-.",
                "---",
                ".--.",
                "--.-",
                ".-.",
                "...",
                "-",
                "..-",
                "...-",
                ".--",
                "-..-",
                "-.--",
                "--.."
            };

            HashSet<string> s = new HashSet<string> ();

            foreach (string word in words) {
                StringBuilder t = new StringBuilder ();
                foreach (char sym in word) {
                    t.Append (morse[sym - 'a']);
                }

                s.Add (t.ToString ());
            }

            return s.Count;
        }
    }
}
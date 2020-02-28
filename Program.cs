using System;
using System.Collections.Generic;

namespace ListIntro {
    class Program {
        static void Main (string[] args) {
            List<string> nssCohorts = new List<string> {
                "Cohort 36",
                "Cohort 37",
                "Cohort 38"
            };

            nssCohorts.Add ("Cohort 39");

            List<int> birthYears = new List<int> {
                1996,
                1992,
                1997,
                2001
            };

            birthYears.Add (1996);
            birthYears.Add (1989);
            birthYears.Add (1990);
            birthYears.Add (1978);

            foreach (string cohort in nssCohorts) {
                Console.WriteLine (cohort);
            };

            birthYears.Remove (1996);

            foreach (int year in birthYears) {
                Console.WriteLine (year);
                if (year == 1996) {
                    Console.WriteLine ("Holden was born🍰🎂");
                    Console.WriteLine ("Go Bulls🏀");

                }
            };

            // Dictionaries <key type, value type> 
            Dictionary<string, string> student = new Dictionary<string, string> ();

            student.Add ("Name", "Adam");
            student.Add ("Cohort", "Day 37");

            Dictionary<string, string> anotherStudent = new Dictionary<string, string> () { { "Name", "Brenda" }, { "Cohort", "Day 37" }
            };

            foreach (KeyValuePair<string, string> pair in student) {
                Console.WriteLine ($"The student's {pair.Key} is {pair.Value}");
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day3
{
    public class Bob
    {
        public string hey(string greeting)
        {
            string upperCaseGreeting = greeting.ToUpper();
            bool allSpaces = true;
            bool containsLetter = false;
            string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach(char c in greeting.ToCharArray())
            {
                if(c != ' ')
                {
                    allSpaces = false;
                }
                foreach (char letter in alphabet.ToCharArray())
                {
                    if(c.Equals(letter))
                    {
                        containsLetter = true;
                    }
                }
            }
            if(allSpaces)
            {
                return "Fine. Be that way!";
            }
            if (greeting == upperCaseGreeting && containsLetter)
            {
                return "Whoa, chill out!";
            }
            if (greeting.EndsWith("?"))
            {
                return "Sure.";
            }


            return "Whatever.";
        }
    }
}

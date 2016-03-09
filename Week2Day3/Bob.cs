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
            bool containsLetter = false;

            if (string.IsNullOrWhiteSpace(greeting))
            {
                return "Fine. Be that way!";
            }
            foreach (char letter in upperCaseGreeting)
            {
                if (letter >= 'A' && letter <= 'Z')
                {
                    containsLetter = true;
                    break;
                }
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

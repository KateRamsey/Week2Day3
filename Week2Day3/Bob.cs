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
            foreach(char c in greeting)
            {
                if(c != ' ')
                {
                    allSpaces = false;
                }
            }
            if(allSpaces)
            {
                return "Fine. Be that way!";
            }
            if(greeting == upperCaseGreeting)
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

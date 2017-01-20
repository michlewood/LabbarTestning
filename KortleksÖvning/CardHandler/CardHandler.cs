using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardHandlerlib
{
    public class CardHandler
    {
        public string SuitChecker(char input)
        {
            //return "Diamond";

            //if (input.Contains("d"))
            //    return "Diamond";
            //else
            //    return "Club";

            //if (input == 'd')
            //    return "Diamond";
            //else if (input == 'c')
            //    return "Club";
            //else if (input == 'h')
            //    return "Heart";
            //else return "Spade";

            //if (input == 'd')
            //    return "Diamond";
            //else if (input == 'c')
            //    return "Club";
            //else if (input == 'h')
            //    return "Heart";
            //else return "Spade";

            //if (input == 'd')
            //    return "Diamond";
            //else if (input == 'c')
            //    return "Club";
            //else if (input == 'h')
            //    return "Heart";
            //else if (input == 's')
            //    return "Spade";
            //else return "Invalid input";

            if (input == 'd' || input == 'D')
                return "Diamond";
            else if (input == 'c' || input == 'C')
                return "Club";
            else if (input == 'h' || input == 'H')
                return "Heart";
            else if (input == 's' || input == 'S')
                return "Spade";
            else return "Invalid input";
        }

        public string ValuesChecker(string input)
        {
            //return "2";

            if (input.Contains("10"))
                return "10";
            else if (input.Contains("9"))
                return "9";
            else if (input.Contains("8"))
                return "8";
            else if (input.Contains("7"))
                return "7";
            else if (input.Contains("6"))
                return "6";
            else if (input.Contains("5"))
                return "5";
            else if (input.Contains("4"))
                return "4";
            else if (input.Contains("3"))
                return "3";
            else if (input.Contains("2"))
                return "2";
            else if (input.Contains("1"))
                return "Ace";
            else if (input.ToUpper().Contains("J"))
                return "Jack";
            else if (input.ToUpper().Contains("Q"))
                return "Queen";
            else if (input.ToUpper().Contains("K"))
                return "King";
            else return "Invalid value";
        }
    }
}

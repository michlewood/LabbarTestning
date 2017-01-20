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
            else if (input == 's' ||input == 'S')
                return "Spade";
            else return "Invalid input";
        }
    }
}

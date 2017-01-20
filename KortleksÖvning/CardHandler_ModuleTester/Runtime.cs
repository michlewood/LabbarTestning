using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardHandlerlib;
using System.IO;

namespace CardHandler_ModuleTester
{
    class Runtime
    {
        public void Start()
        {
            CardHandler cardHandler = new CardHandler();
            string[] suits = { "h", "d", "s", "c" };
            string[] incorrectInputs = { " ","fdgrfdjol","1","j","10dddd"};
            string[] results = new string[4 * 14+incorrectInputs.Length+2];
            string input;
            string currentResults;
            for (int i = 0; i < suits.Length; i++)
            {

                for (int j = 1; j < 14; j++)
                {
                    if (j == 13)
                    {
                        input = string.Format("K{0}", suits[i]);
                        currentResults = input + " = ";
                        try
                        {
                            currentResults += cardHandler.CardChecker(input) + " = passed";
                        }
                        catch (Exception)
                        {
                            currentResults += " = failed";
                        }
                    }
                    else if (j == 12)
                    {
                        input = string.Format("Q{0}", suits[i]);
                        currentResults = input + " = ";
                        try
                        {
                            currentResults += cardHandler.CardChecker(input) + " = passed";
                        }
                        catch (Exception)
                        {
                            currentResults += " = failed";
                        }
                    }
                    else if (j == 11)
                    {
                        input = string.Format("J{0}", suits[i]);
                        currentResults = input + " = ";
                        try
                        {
                            currentResults += cardHandler.CardChecker(input) + " = passed";
                        }
                        catch (Exception)
                        {
                            currentResults += " = failed";
                        }
                    }
                    else
                    {
                        input = string.Format("{0}{1}", j, suits[i]);
                        currentResults = input + " = ";
                        try
                        {
                            currentResults += cardHandler.CardChecker(input) + " = passed";
                        }
                        catch (Exception)
                        {
                            currentResults += " = failed";
                        }
                    }
                    results[j + i * 14] = currentResults;
                }
            }
            results[4 * 14] = "";
            results[4 * 14+1] = "Results to fail";

            for (int i = 0; i < incorrectInputs.Length; i++)
            {
                results[4 * 14+i+2] = incorrectInputs[i];

                try
                {
                    results[4 * 14+i+2] += cardHandler.CardChecker(incorrectInputs[i]) + " = passed";
                }

                catch (Exception)
                {
                    results[4 * 14+i+2] += " = failed";
                } 
            }

            File.WriteAllLines(Environment.CurrentDirectory + @"\results.txt", results);
        }
    }
}

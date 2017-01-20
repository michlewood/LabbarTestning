using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandler
{
    public class Class1
    {
        private string file = String.Format("{0}{1}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"\övning5.txt");
        public Class1()
        {
            if (!File.Exists(file))
            {
                string[] content = { "Name:", "Addition:", "Subtraction:", "Multiplication:", "Division:" };
                File.WriteAllLines(file, content);
            }
        }

        public void Name(string firstName, string lastName)
        {
            //File.WriteAllText(file, "Michael Wood");
            WriteToFile(string.Format("Name: {0} {1}", firstName, lastName), 0);
        }

        private void WriteToFile(string input, int line)
        {
            string[] content = new string[5];
            content = File.ReadAllLines(file);
            content[line] = input;
            File.WriteAllLines(file, content);
        }

        public void Addition(int firstNumber, int secondNumber)
        {
            // File.WriteAllText(file, "Addition: 3 + 6 = 9, 1");

            // WriteToFile(Addition: 3 + 6 = 9);

            // WriteToFile(string.Format("Addition: {0} + {1} = {2}", firstNumber, secondNumber, firstNumber + secondNumber), 1);

            if (firstNumber >= 0 && secondNumber >= 0)
            {
                WriteToFile(string.Format("Addition: {0} + {1} = {2}", firstNumber, secondNumber, firstNumber + secondNumber), 1);
            }
        }

        public void Subtraction(int firstNumber, int secondNumber)
        {
            // WriteToFile(Subtraction: 8 - 3 = 5);

            // WriteToFile(string.Format("Subtraction: {0} - {1} = {2}", firstNumber, secondNumber, firstNumber - secondNumber), 2);

            if (firstNumber >= 0 && secondNumber >= 0)
            {
                WriteToFile(string.Format("Subtraction: {0} - {1} = {2}", firstNumber, secondNumber, firstNumber - secondNumber), 2);
            }
        }

        public void Multiplication(int firstNumber, int secondNumber)
        {
            //WriteToFile(string.Format("Multiplication: {0} * {1} = {2}", firstNumber, secondNumber, firstNumber * secondNumber), 3);

            if (firstNumber >= 0 && secondNumber >= 0)
            {
                WriteToFile(string.Format("Multiplication: {0} * {1} = {2}", firstNumber, secondNumber, firstNumber * secondNumber), 3);
            }
        }     

        public void Division(double firstNumber, double secondNumber)
        {
            //WriteToFile(string.Format("Division: {0} / {1} = {2}", firstNumber, secondNumber, firstNumber / secondNumber), 4);

            if (secondNumber != 0)
            {
                WriteToFile(string.Format("Division: {0} / {1} = {2}", firstNumber, secondNumber, firstNumber / secondNumber), 4);
            }
            else
                throw new ArgumentException("Cannot divide by zero");
        }

        public string[] GetFileContent()
        {
            return File.ReadAllLines(file); 
        }
    }
}

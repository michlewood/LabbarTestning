using FileHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning5
{
    class Runtime
    {
        Class1 class1 = new Class1();
        int firstNumber = 0, secondNumber = 0;
        public static int itemSelected = 0;
        bool enterPressed = true;
        string[] menuItems = { "Change Name", "Addition", "Subtraction", "Multiplication", "Division", "Exit" };

        public void Start()
        {
            //VariantOne();

            //VariantTwo();

            VariantThree();
        }

        private void VariantThree()
        {
            Console.CursorVisible = false;

            while (true)
            {
                if (enterPressed)
                {
                    Printor();
                    Console.WriteLine("---------");
                    Graphics.MenuGraphics();
                    enterPressed = false;
                }
                MenuControls_VariantThree();
            }
        }

        private void MenuControls_VariantThree()
        {
            var controls = Console.ReadKey(true).Key;
            switch (controls)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.DownArrow:

                    Console.SetCursorPosition(0, 6 + itemSelected);
                    Console.ResetColor();
                    Console.WriteLine(menuItems[itemSelected]);
                    if (controls == ConsoleKey.UpArrow)
                    {
                        itemSelected--;
                        if (itemSelected == -1) itemSelected = 5;
                    }
                    else
                    {
                        itemSelected++;
                        if (itemSelected > 5) itemSelected = 0;
                    }
                    ChangeColorOfNewlySelectedItem(itemSelected);
                    break;

                case ConsoleKey.Enter:
                    Console.Clear();
                    Console.CursorVisible = true;
                    enterPressed = true;

                    if (itemSelected == 0)
                        Nameor();
                    if (itemSelected == 1)
                        Addor();
                    if (itemSelected == 2)
                        Subtractor();
                    if (itemSelected == 3)
                        Multiplicator();
                    if (itemSelected == 4)
                        Divisor();
                    if (itemSelected == 5)
                        Environment.Exit(0);

                    Console.CursorVisible = false;
                    var content = class1.GetFileContent();
                    Console.WriteLine(content[itemSelected]);
                    Console.ReadKey(true);
                    Console.Clear();
                    break;
            }
        }

        private void ChangeColorOfNewlySelectedItem(int itemSelected)
        {
            Console.SetCursorPosition(0, 6 + itemSelected);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(menuItems[itemSelected]);
            Console.ResetColor();
        }

        private void VariantTwo()
        {
            Nameor();
            Console.CursorVisible = false;
            while (true)
            {
                Console.Clear();
                Menu();
            }
        }

        private void Menu()
        {
            Printor();
            Console.WriteLine("---------");
            Graphics.MenuGraphics();
            MenuControls();
        }

        private void MenuControls()
        {
            var control = Console.ReadKey(true).Key;
            switch (control)
            {
                case ConsoleKey.UpArrow:
                    itemSelected--;
                    if (itemSelected == -1) itemSelected = 5;
                    break;

                case ConsoleKey.DownArrow:
                    itemSelected++;
                    if (itemSelected > 5) itemSelected = 0;
                    break;
                case ConsoleKey.Enter:
                    Console.Clear();
                    Console.CursorVisible = true;
                    if (itemSelected == 0)
                    {
                        Nameor();
                    }
                    if (itemSelected == 1)
                    {
                        Addor();
                    }
                    if (itemSelected == 2)
                    {
                        Subtractor();
                    }
                    if (itemSelected == 3)
                    {
                        Multiplicator();
                    }
                    if (itemSelected == 4)
                    {
                        Divisor();
                    }
                    if (itemSelected == 5)
                    {
                        Environment.Exit(0);
                    }
                    Console.CursorVisible = false;
                    var content = class1.GetFileContent();
                    Console.WriteLine(content[itemSelected]);
                    Console.ReadKey(true);
                    break;
            }
        }

        private void VariantOne()
        {
            Nameor();
            Addor();
            Subtractor();
            Multiplicator();
            Divisor();
        }

        private void Nameor()
        {
            string firstName = "";
            while (firstName == "")
            {
                Console.WriteLine("Please enter Your First Name");
                firstName = Console.ReadLine();
            }

            string lastName = "";
            while (lastName == "")
            {
                Console.WriteLine("Please enter Your Last Name");
                lastName = Console.ReadLine();
            }

            class1.Name(firstName, lastName);
        }

        private void Addor()
        {
            numberGetter("Addition");
            class1.Addition(firstNumber, secondNumber);
        }

        private void Subtractor()
        {
            numberGetter("Subtraction");
            class1.Subtraction(firstNumber, secondNumber);
        }

        private void Multiplicator()
        {
            numberGetter("Multiplication");
            class1.Multiplication(firstNumber, secondNumber);
        }

        private void Divisor()
        {
            numberGetter("Division");
            class1.Division(firstNumber, secondNumber);
        }

        private void numberGetter(string OperatorName)
        {
            Console.WriteLine(OperatorName);

            bool isValid = false;

            while (!isValid || firstNumber == 0)
            {
                Console.WriteLine("Enter first number:");
                isValid = int.TryParse(Console.ReadLine(), out firstNumber);
                if (!isValid)
                {
                    Console.WriteLine("Please enter a number");
                }
                else if (firstNumber == 0)
                {
                    Console.WriteLine("Number cannot be zero");
                }
            }

            isValid = false;

            while (!isValid || secondNumber == 0)
            {
                Console.WriteLine("Enter second number:");
                isValid = int.TryParse(Console.ReadLine(), out secondNumber);
                if (!isValid)
                {
                    Console.WriteLine("Please enter a number");
                }

                else if (secondNumber == 0)
                {
                    Console.WriteLine("Number cannot be zero");
                }
            }
        }

        private void Printor()
        {
            var content = class1.GetFileContent();

            for (int i = 0; i < content.Length; i++)
            {
                Console.WriteLine(content[i]);
            }
        }
    }
}

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
        public static int ItemSelected { get; set; }
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
                    Console.SetCursorPosition(0, 6 + ItemSelected);
                    Console.ResetColor();
                    Console.WriteLine(menuItems[ItemSelected]);
                    if (controls == ConsoleKey.UpArrow)
                    {
                        ItemSelected--;
                        if (ItemSelected < 0) ItemSelected = 5;
                    }
                    else
                    {
                        ItemSelected++;
                        if (ItemSelected > 5) ItemSelected = 0;
                    }
                    ChangeColorOfNewlySelectedItem(ItemSelected);
                    break;

                case ConsoleKey.Enter:
                    Console.Clear();
                    Console.CursorVisible = true;
                    enterPressed = true;

                    if (ItemSelected == 0)
                        Nameor();
                    if (ItemSelected == 1)
                        Addor();
                    if (ItemSelected == 2)
                        Subtractor();
                    if (ItemSelected == 3)
                        Multiplicator();
                    if (ItemSelected == 4)
                        Divisor();
                    if (ItemSelected == 5)
                        Environment.Exit(0);

                    Console.CursorVisible = false;
                    var content = class1.GetFileContent();
                    Console.WriteLine(content[ItemSelected]);
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
                    ItemSelected--;
                    if (ItemSelected == -1) ItemSelected = 5;
                    break;

                case ConsoleKey.DownArrow:
                    ItemSelected++;
                    if (ItemSelected > 5) ItemSelected = 0;
                    break;
                case ConsoleKey.Enter:
                    Console.Clear();
                    Console.CursorVisible = true;
                    if (ItemSelected == 0)
                    {
                        Nameor();
                    }
                    if (ItemSelected == 1)
                    {
                        Addor();
                    }
                    if (ItemSelected == 2)
                    {
                        Subtractor();
                    }
                    if (ItemSelected == 3)
                    {
                        Multiplicator();
                    }
                    if (ItemSelected == 4)
                    {
                        Divisor();
                    }
                    if (ItemSelected == 5)
                    {
                        Environment.Exit(0);
                    }
                    Console.CursorVisible = false;
                    var content = class1.GetFileContent();
                    Console.WriteLine(content[ItemSelected]);
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

            firstNumber = CheckNumber("Enter first number:");
            secondNumber = CheckNumber("Enter second number:");
        }

        private int CheckNumber(string text)
        {
            int number = 0;
            var isValid = false;
            while (!isValid)
            {
                Console.WriteLine(text);
                isValid = int.TryParse(Console.ReadLine(), out number);
                if (!isValid)
                {
                    Console.WriteLine("Please enter a number");
                }

                else if (number == 0)
                {
                    Console.WriteLine("Number cannot be zero");
                    isValid = false;
                }
            }
            return number;
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

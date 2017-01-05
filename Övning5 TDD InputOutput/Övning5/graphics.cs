using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning5
{
    class Graphics
    {
        public static void MenuGraphics()
        {
            if (Runtime.itemSelected == 0)
                Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Change Name");
            Console.BackgroundColor = ConsoleColor.Black;
            if (Runtime.itemSelected == 1)
                Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Addition");
            Console.BackgroundColor = ConsoleColor.Black;
            if (Runtime.itemSelected == 2)
                Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Subtraction");
            Console.BackgroundColor = ConsoleColor.Black;
            if (Runtime.itemSelected == 3)
                Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Multiplication");
            Console.BackgroundColor = ConsoleColor.Black;
            if (Runtime.itemSelected == 4)
                Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Division");
            Console.BackgroundColor = ConsoleColor.Black;
            if (Runtime.itemSelected == 5)
                Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Show all");
            Console.BackgroundColor = ConsoleColor.Black;
            if (Runtime.itemSelected == 6)
                Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Exit");
            Console.BackgroundColor = ConsoleColor.Black;

        }
    }
}

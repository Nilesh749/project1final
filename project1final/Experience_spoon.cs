using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1final
{
    internal class Experience_spoon : Experiencemenulist
    {
        public void Menu()
        {
            var desc = new StringBuilder();
            desc.Append("Description : Internship\n");
            desc.Append("Duration    : 4 Months\n");
            desc.Append("Manager     : --\n");
            desc.Append("Field       : Development\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Spoon Consulting Mauritius");
            Console.ResetColor();
            Console.WriteLine(desc);
            Console.WriteLine();
            new Experiencemenu().Menu();
        }
    }
}

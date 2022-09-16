using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1final
{
    internal class Experience_ceridian : Experiencemenulist
    {
        public void Menu()
        {
            var desc = new StringBuilder();
            desc.Append("Description : Internship\n");
            desc.Append("Duration    : 3 Months\n");
            desc.Append("Manager     : Mr Abhishek Jagdambi\n");
            desc.Append("Field       : Automation\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ceridian Mauritius");
            Console.ResetColor();
            Console.WriteLine(desc);
            Console.WriteLine();
            new Experiencemenu().Menu();
        }
    }
}

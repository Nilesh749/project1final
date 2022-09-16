using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1final
{
    internal class CSyear1 : Educationmenus
    {
        public void Menu()
        {
            var modules = new StringBuilder();
            modules.Append("1.programmming\n");
            modules.Append("2.Database\n");
            var projects = new StringBuilder();
            projects.Append("Programming Projects\n");
            projects.Append("1.Programme to translate to English to Creole\n");
            projects.Append("Database Projects\n");
            projects.Append("1.Designing a Database from scratch\n");

            Console.WriteLine("*****************Computer Science Year 1****************");
            Console.WriteLine("***********Modules**************************************");
            Console.WriteLine(modules);
            Console.WriteLine("***********Projects*************************************");
            Console.WriteLine(projects);
            Console.WriteLine("******************Computer Science Year 1****************");
            Console.WriteLine();
            new Educationmenu().Menu();
        }
    }
}

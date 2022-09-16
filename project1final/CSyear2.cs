using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1final
{
    internal class CSyear2 : Educationmenus
    {
        public void Menu()
        {
            var modules = new StringBuilder();
            modules.Append("1.Web centric\n");
            modules.Append("2.Object Oriented Techniques\n");
            var projects = new StringBuilder();
            projects.Append("Web Centric Projects\n");
            projects.Append("1.Full Stack Design of a Website\n");
            projects.Append("Object Oriented Techniques Projects\n");
            projects.Append("1.Designing a User Interface\n");

            Console.WriteLine("****************Computer Science Year 2*****************");
            Console.WriteLine("***********Modules**************************************");
            Console.WriteLine(modules);
            Console.WriteLine("***********Projects*************************************");
            Console.WriteLine(projects);
            Console.WriteLine("****************Computer Science Year 2*****************");
            Console.WriteLine();
            new Educationmenu().Menu();
        }
    }
}

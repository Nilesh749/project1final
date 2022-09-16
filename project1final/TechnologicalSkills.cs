using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1final
{
    internal class TechnologicalSkills : Menus
    {
        public void Menu()
        {
            var skills = new StringBuilder();
            skills.AppendLine("1.Computer Literacy");
            skills.AppendLine("2.Database Management");
            skills.AppendLine("3.Website Development");
            skills.AppendLine("4.Project Management");
            skills.AppendLine("5.Cybersecurity");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("************** Technological Skills*****************");
            Console.ResetColor();
            Console.WriteLine(skills);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("**************Technological Skills*****************");
            Console.ResetColor();
            Console.WriteLine();
            new Mainmenu().Menu();
        }
    }
}

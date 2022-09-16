using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1final
{
    internal class SkillsMenu : Menus
    {
        public void Menu()
        {
            var skills = new StringBuilder();
            skills.AppendLine("1.Teamworking");
            skills.AppendLine("2.Communcation");
            skills.AppendLine("3.Time Management");
            skills.AppendLine("4.Active listening");
            skills.AppendLine("5.Creative Thinking");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("**************Skills*****************");
            Console.ResetColor();
            Console.WriteLine(skills);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("**************Skills*****************");
            Console.ResetColor();
            Console.WriteLine();
            new Mainmenu().Menu();
        }
    }
}

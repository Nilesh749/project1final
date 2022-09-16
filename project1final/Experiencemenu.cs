using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static project1final.Program;

namespace project1final
{
    internal class Experiencemenu  : Menus
    {
        
        public void Menu()
        {
            var menulist = new StringBuilder();
            menulist.Append("1.Ceridian Mauritius (2021)\n");
            menulist.Append("2.Spoon consulting Mauritius (2022)\n");
            menulist.Append("0.Go back\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("**************Experience Menu*****************");
            Console.ResetColor();
            Console.WriteLine(menulist);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("**************Experience Menu*****************");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Enter your choice");
            try
            {
                var Experiencechoices = (ExperienceChoice)Enum.Parse(typeof(ExperienceChoice), Console.ReadLine());
                Console.WriteLine();
                var Experiencechoicefactory = new ExperienceChoicefactory();
                var menu = Experiencechoicefactory.Getmenuperchoice(Experiencechoices);
                menu.Menu();
            }
            catch (System.ArgumentException)
            {
                new Experiencemenu().Menu();
            }
            catch (KeyNotFoundException)
            {
                new Experiencemenu().Menu();
            }


        }
    }
    
}

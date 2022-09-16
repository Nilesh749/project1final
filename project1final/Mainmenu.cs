using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static project1final.Program;

namespace project1final
{
    internal class Mainmenu : Educationmenus,Experiencemenulist
    {
        public void Menu()
        {
            var menulist = new StringBuilder();
            menulist.AppendLine("1.Experience / Job History");
            menulist.AppendLine("2.Education / Training");
            menulist.AppendLine("3.Skills");
            menulist.AppendLine("4.Technological Skills");
            menulist.AppendLine("5.Contact Details");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("**************Main Menu*****************");
            Console.ResetColor();
            Console.WriteLine(menulist);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("**************Main Menu*****************");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Enter your choice");
                try
                {
                    var choices = (Choice)Enum.Parse(typeof(Choice), Console.ReadLine());
                    Console.WriteLine();
                    var choicefactory = new choicefactory();
                    var menu = choicefactory.Getmenuperchoice(choices);
                    menu.Menu();
                }
                catch (System.ArgumentException)
                {
                    new Mainmenu().Menu();
            }
            catch (KeyNotFoundException)
            {
                new Mainmenu().Menu();
            }

            }
    }
}

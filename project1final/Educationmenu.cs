using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static project1final.Program;

namespace project1final
{
    internal class Educationmenu : Menus,Educationmenus
    {
       
        public void Menu()
        {
            var menulist = new StringBuilder();
            menulist.Append(" 1.Computer Science (Year 1)\n");
            menulist.Append(" 2.Computer Science (Year 2)\n");
            menulist.Append("-1.Additional Trainings\n");
            menulist.Append(" 0.Go back\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("**************University Of Mauritius*****************");
            Console.ResetColor();
            Console.Write(menulist);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("**************University Of Mauritius*****************");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Enter your choice");
            try
            {
                var Educationchoices = (EducationChoice)Enum.Parse(typeof(EducationChoice), Console.ReadLine());
                Console.WriteLine();
                var Educationchoicefactory = new EducationChoicefactory();
                var menu = Educationchoicefactory.Getmenuperchoice(Educationchoices);
                menu.Menu();
            }
            catch (System.ArgumentException)
            {
                new Educationmenu().Menu();
            }
            catch (KeyNotFoundException)
            {
                new Educationmenu().Menu();
            }

        }
    }
   
}

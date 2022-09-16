using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1final
{
    internal class Additional_trainings : Educationmenus
    {
        public void Menu()
        {
            var training = new StringBuilder();
            training.Append("Not yet attended");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("***********Additional Training*************************************");
            Console.ResetColor();
            Console.WriteLine(training);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("***********Additional Trainings************************************");
            Console.ResetColor();
            Console.WriteLine();
            new Educationmenu().Menu();
        }
    }
}

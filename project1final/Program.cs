using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static project1final.Program;

namespace project1final
{
    internal class Program
    {
        public enum Choice
        {
            Experiencemenu=1,
            Eductaionmenu=2,
            Skillsmenu=3,
            TechnologicalSkillsmenu=4,
            Contactmenu=5
        }

        public enum EducationChoice
        {
            csyr1 = 1,
            csyr2 = 2,
            Additional_trainings=-1,
            goback = 0

        }

        public enum ExperienceChoice
        {
            ceridian = 1,
            spoon = 2,
            goback = 0

        }
        static void Main(string[] args)
        {
            new Introduction();
            Console.WriteLine();
            new Mainmenu().Menu();
        }
    }
            
     
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1final
{
    internal class Introduction
    {
        public  Introduction()
        {
            var summary = new StringBuilder();
            summary.Append("I am an intellectually curious and self motivated computer science student\n");
            summary.Append("with passion for technology seeking a meaningful role to begin a career in\n");
            summary.Append("information technology and make a positive impact on customer experience .\n");
            summary.Append("Skilled at team working with willingness to travel and grow through personal\n");
            summary.AppendLine("and professional development");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Name");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Nilesh Dwarka");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Address");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Falcon Street Albion");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Professional Summary");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(summary);
            Console.ResetColor();
        }
    }
}

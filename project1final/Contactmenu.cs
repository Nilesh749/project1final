using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1final
{
    internal class Contactmenu : Menus
    {
        public  void Menu()
        {
            var contact = new StringBuilder();
            contact.Append("Phone : 58273171\n");
            contact.Append("Email : Nilesh.Dwarka@ceridian.com\n");

            Console.WriteLine("**************Contact Details*****************");
            Console.WriteLine(contact);
            Console.WriteLine("**************Contact Details*****************");
            Console.WriteLine();
            new Mainmenu().Menu();
        }
    }
}

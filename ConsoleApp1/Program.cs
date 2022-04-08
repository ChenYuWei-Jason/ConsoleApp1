using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;

            Console.WriteLine("Please inpur your name");
            string name = Console.ReadLine();

           MessageBox.Show("HELLO"+name);

            System.Windows.Forms.MessageBox.Show("HELLOHELLO"+name);
        }
    }
}

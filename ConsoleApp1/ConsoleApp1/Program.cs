using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    class Program 
    {
        static void Main(string[] args) 
        {
            int num1, num2, total;// we give two numbers and result data type 
            Console.WriteLine("Enter the first number: ");//We write the text that will appear on the screen.
            num1 =Convert.ToInt32(Console.ReadLine()); //read the text on the screen and convert it to an int value
            Console.WriteLine("Enter the second number: ");
            num2=Convert.ToInt32(Console.ReadLine());

            total=num1+ num2;//we give the action command to the result

            Console.WriteLine("Number total: " + total);

            Console.ReadLine();
        }
 
    }
}

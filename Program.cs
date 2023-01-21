using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   Create class Product → prod id, name, company & price
                 Assign values in the constructor
                 If price > 2000  give 15 % discount
                 If price < 2000  give 5 % discount
                 And display product details
                 reate two objects of product class & display the details
                                                                                */

            // creating Object 

            //create object of student class
            Student stud = new Student(1, "headphone", "boAt", 1900);
            stud.Discount();
            Console.WriteLine(stud.Display());



        }
    }
}

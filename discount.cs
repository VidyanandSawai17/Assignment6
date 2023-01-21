using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class Student // variables, constructor,method,property,indexer,event
    {
        // variables or data members
        private int id;
        private string name;
        private string company;
        private double price, discount;

        //constructor
        public Student()
        {
            id = 1;
            name = "Test";
            company = "xyz";
            price = 0;


        }
        public Student(int id, string name, string company, double price)
        {
            this.id = id; // this keyword points to the data member
            this.name = name;
            this.company = company;
            this.price = price;

        }
        public void Discount()
        {
            if (price > 2000)
            {
                discount = price * 0.15;
            }
            else if (price < 2000)
            {
                discount = price * 0.5;
            }
        }
        public string Display()
        {
            return $"\n ID : {id} \n Name : {name} \n Company : {company} \n Price = {price} rs  \n Discount = {discount} rs";
        }
    }
}

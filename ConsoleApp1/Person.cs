using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Company
{
    public string title = "Sun";
}

class Person
    {
        public string name;
        public int age;
        public Company company;

        public void sayMe()
        {
            Console.WriteLine($"My name is {name}, and age is {age}, company {company.title}");
        }

        public Person(string name = "musa", int age = 21)
        {
            Console.WriteLine("this is a constructor");
            this.name = name;
            this.age = age;
            company = new Company();
        }
        public void Deconstruct(out string nname, out int aage)
            {
                nname = name;
                aage = age;
            }

}

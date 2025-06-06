using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul
{
    public class Person
    {
        public string Name { get; set; } = "Noname";
        public string LastName { get; set; } = "Noname";
        public int Age { get; set; }
    
        public Person(string name,string lastName,int age)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Age = age; 
        }
        public Person() 
        {
            //name = "Noname";
            //lastName = "Noname";
            //age = 0;
        }

        public override bool Equals(object obj)
        {
            if(obj is Person other)
            {
                return GetHashCode() == other.GetHashCode();//ToString().Equals(other.ToString());
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        public override string ToString()
        {
            return $"Name: {Name}\nLast name: {LastName}\nAge: {Age}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Virtual_Pet
{
    class Pet //class
    {
        private string petName;
        private string happiness;
        private string bordom;
        private int age;

        public string greeting;

        public string Name//properties
        {
            get { return this.petName; }
            set { this.petName = value; }
        }

        public string Happiness
        {
            get { return this.happiness; }

        }

        public string Bordom
        {
            get { return this.bordom; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Pet() //constructor
        {
            age = 2;
            Name = "Felipe";
            greeting = "Hi, My name is Felipe, I am 2 years old.  Take care of me like your very own Pet";
        }
        public Pet(string petName, string happiness, string bordom, int age)
        {
            this.petName = petName;
            this.happiness = happiness;
            this.bordom = bordom;
            this.age = age;
        }
        public Pet
        
        /*{
         public void //tick
        {
            for (int i = 0; i < 10; i++)
            Console.Writeline();*/
         
        }   
    }  
}   

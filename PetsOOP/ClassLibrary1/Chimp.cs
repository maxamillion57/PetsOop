using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClassLibrary1
{
    public class Chimp : Pet
    {
        public Chimp(string name) : base(name)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine(Name + " hoots and hollers.");
        }

        public void PoopThrow()
        {
            Console.WriteLine(Name + " throws feces at you");
        }
    } 
}
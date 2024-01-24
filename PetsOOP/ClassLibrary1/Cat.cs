using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
	public class Cat : Pet
	{
		public Cat(string name) : base(name) 
		{
			
		}
		public override void MakeSound()
		{
			Console.WriteLine(Name + " meows at you.");
		}
		public void Climb()
		{
			Console.WriteLine(Name + " climbs the wall and shits on the floor");
		}
		public void Meet(Chimp newFriend)
		{
			Console.WriteLine(Name + " scratches at " + newFriend.Name);
		}
        public void Meet(Turtle newFriend)
        {
            Console.WriteLine(Name + " scratches at " + newFriend.Name);
        }
    }
}

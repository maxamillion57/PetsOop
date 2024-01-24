﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1

{  
        public abstract class Pet
        {
    public string Name { get; set; }
    //constructor
    public Pet(string name)
    {
        Name = name;
    }


    public abstract void MakeSound();

    public void ShowInfo()
    {
        Console.WriteLine("Pet Name: " + Name);
    }
}
        

    }

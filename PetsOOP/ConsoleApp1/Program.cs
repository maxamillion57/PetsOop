using ClassLibrary1;

string input = " ";

while (input != "4")
{
    Console.WriteLine("Welcome to the Pet Store");
    Console.WriteLine("1: Add a new pet");
    Console.WriteLine("2: List all Pets");
    Console.WriteLine("3: Have 2 pets meet");
    Console.WriteLine("4: Exit");
        input = Console.ReadLine();
        switch (input)
    {

        case "1":
            Console.WriteLine("What is the name of the new pet?");
            string petName = Console.ReadLine(); 
            Console.WriteLine("1: Add a new Cat");
            Console.WriteLine("2: Add a new Chimp");
            Console.WriteLine("3: Add a new Turtle");
            string input2  = Console.ReadLine();
            switch (input2)
            {
                case "1":
                    Cat newCat = new Cat(petName);
                    break;
                case "2":
                    Chimp newChimp = new Chimp(petName);
                    break;
                case "3":
                    Turtle newTurtle = new Turtle(petName);
                    break;
            }

            break;
        case "2":
            Console.WriteLine("The following pets are:" + input);
            break;
        case "3":
            break;
        case "4":
            break;
        default:
            break;
    }
}
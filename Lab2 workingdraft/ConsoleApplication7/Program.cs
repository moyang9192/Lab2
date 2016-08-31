using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Lab2
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Welcome! What is your name?");
            string yourName = (Console.ReadLine());

            Console.WriteLine("Would you like to play a game (enter “yes” or “no”):");

            string Game = Console.ReadLine();
            if (Game == "yes" || Game == "y" || Game == "Yes")

            {
                Console.WriteLine("Excellent! You are walking across a field and you encounter a fire-breathing dragon!");
                Console.WriteLine("What would you do? (enter \"face the beast\" or \"run away\") ");

                string fight = Console.ReadLine();

                if (fight == "face the beast")
                {
                    Console.WriteLine("You approach the dragon. You see that he has__heads. (enter “1” or “2” or “3”):");


                    string numberOfHead = Console.ReadLine();
                    int head = int.Parse(numberOfHead);

                    if (head == 1)
                    {
                        Console.WriteLine("No one has ever faced a 1 headed dragon before! Choose your weapon. (enter “slingshot” or “sword” or “bow and arrow”):");

                        string Weapon = Console.ReadLine();
                        switch (Weapon)
                        {
                            case "slingshot":
                            case "sword":
                            case "bow and arrow":
                                Console.WriteLine("Armed with your" + Weapon + "you approach the dragon. You can feel its fiery breath as you get closer. It stares at you with its__eyes. (enter “red” or “blue”):");

                                break;

                            default:
                                Console.WriteLine("That's not an option...");
                                break;

                        }

                        string eyeColor = Console.ReadLine();
                        if (eyeColor == "red" || eyeColor == "blue")
                        { Console.WriteLine("Oh thank goodness! " + eyeColor + "-eyed dragons are friendly. You pet it and become friends.\nYou name the dragon:"); 

                        string dragonName = Console.ReadLine();
                        Console.WriteLine(yourName + " and " + dragonName + " live happily ever after.");
                        Console.ReadLine();
                    }

                    else
                    { Console.WriteLine("Bad Choice!"); }

                        Console.ReadLine();


                    }
                    else if (head == 2)
                    {
                        Console.WriteLine("No one has ever faced a 2 headed dragon before! Choose your weapon. (enter “slingshot” or “sword” or “bow and arrow”):");

                        string Weapon = Console.ReadLine();
                        switch (Weapon)
                        {
                            case "slingshot":
                            case "sword":
                            case "bow and arrow":
                                Console.WriteLine("Armed with your" + Weapon + "you approach the dragon. You can feel its fiery breath as you get closer. It stares at you with its__eyes. (enter “red” or “blue”):");

                                break;

                            default:
                                Console.WriteLine("That's not an option...");
                                break;

                        }
                        
                        askEyeColor();
                        string dragonName = Console.ReadLine();
                        Console.WriteLine(yourName + " and " + dragonName + " live happily ever after.");
                        Console.ReadLine();

                    }
                    else
                    {
                        Console.WriteLine("No one has ever faced a 3 headed dragon before! Choose your weapon. (enter “slingshot” or “sword” or “bow and arrow”):");

                        string Weapon = Console.ReadLine();
                        switch (Weapon)
                        {
                            case "slingshot":
                            case "sword":
                            case "bow and arrow":
                                Console.WriteLine("Armed with your" + Weapon +
                                    "you approach the dragon. You can feel its fiery breath as you get closer. "
                                    + "It stares at you with its__eyes. (enter “red” or “blue”):");
                                break;

                            default:
                                Console.WriteLine("That's not an option...");
                                break;


                        }

                        askEyeColor();
                        string dragonName = Console.ReadLine();
                        Console.WriteLine(yourName + " and " + dragonName + " live happily ever after.");
                        Console.ReadLine();
                        

                    }




                }
                else
                {
                    Console.WriteLine("Run fast!!");

                }


            }

            else
            {
                Console.WriteLine("Goodbye");

            }
            Console.ReadLine();



        }

        static void askEyeColor()
        {
            string eyeColor = Console.ReadLine();
            if (eyeColor == "red" || eyeColor == "blue")
            {
                Console.WriteLine("Oh thank goodness! " + eyeColor + "-eyed dragons are friendly.You pet it and become friends.\nYou name the dragon:");
            }
            else
            { Console.WriteLine("Bad Choice!"); }


        }
    
       
    }

}


/*Welcome! What is your name? (enter your name):
Would you like to play a game? (enter “yes” or “no”):
Excellent! You are walking across a field and you encounter a fire-breathing dragon!
What would you do? (enter “face the beast” or “run away”):
You approach the dragon. You see that he has__heads. (enter “1” or “2” or “3”):
No one has ever faced a 3-eaded dragon before! Choose your weapon. (enter “slingshot” or “sword” or “bow and arrow”):
Armed with your bow and arrow you approach the dragon. You can feel its fiery breath as you get closer. It stares at you with its__eyes. (enter “red” or “blue”):
Oh thank goodness! Red-eyed dragons are friendly. You pet it and become friends.
Aisha and Toothless live happily ever after. 


bool condition = true;

if (condition)
{
    Console.WriteLine("The variable is set to true.");
}
else
{
    Console.WriteLine("The variable is set to false.");

    Console.Write("Enter a character: ");
char c = (char)Console.Read();
if (Char.IsLetter(c))
{
    if (Char.IsLower(c))

    tip: how to have quotes appear in the console? console.writeline("this is how to put \" in \")

    int caseSwitch = 1;
switch (caseSwitch)
{
    case 1:
        Console.WriteLine("Case 1");
        break;
    case 2:
        Console.WriteLine("Case 2");
        break;
    default:
        Console.WriteLine("Default case");
        break;
}

     string numberOfHeads = Console.ReadLine();
     int.Parse(numberOfHeads);


                    int headNumber = Console.Read();

    int caseSwitch = Console.Read();
                    switch (caseSwitch)
                    {
                        case 1:
                            Console.WriteLine("1");
                            break;
                        case 2:
                            Console.WriteLine("2");
                            break;
                        default:
                            Console.WriteLine("3");
                            break;

                    }

    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
        myMessage("hola ");
            string theSpecialText = DoSomething();
            Console.WriteLine(theSpecialText);
            Console.Read();
        }

            static void myMessage(string message) 
        {
                Console.WriteLine(message + "interesting");
                Console.WriteLine("double " + message + "stuff");
                Console.WriteLine("triple " + message + "hmmm");
            }

        static string DoSomething()
        {
            return "some thing in words";
        }

    }
}

    }

    

            string q4_eyeColor = Console.ReadLine();
            switch (q4_eyeColor)
            {
                case "red":
                case "blue":

                    Console.WriteLine("Oh thank goodness!" + q4_eyeColor  + "-eyed dragons are friendly.You pet it and become friends.");
                                break;

                default: 
                    Console.WriteLine (only red or blue)

      Console.WriteLine(yourName + " and " + dragonName + " live happily ever after.");
                Console.ReadLine();

            static void askHeadNumber()
        {
            string headNumber = Console.ReadLine();
            if (headNumber == "1" || headNumber == "2" || headNumber == "3")
            {
                Console.WriteLine("No one has ever faced a " + headNumber + " headed dragon before! Choose your weapon. (enter “slingshot” or “sword” or “bow and arrow”):");
            }
            else
            {
                Console.WriteLine("Pick 1, 2, or 3!");
            }
            
        }
        */


/*
    With Shelia's Method example:
    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Lab2
{
    class Program
    {
        static string yourName = "";
        static void Main(string[] args)

        {
            Console.WriteLine("Welcome! What is your name?");
             yourName = Console.ReadLine();

            Console.WriteLine("Would you like to play a game (enter “yes” or “no”):");

            string Game = Console.ReadLine();
            if (Game == "yes")

            {
                Console.WriteLine("Excellent! You are walking across a field and you encounter a fire-breathing dragon!");
                Console.WriteLine("What would you do? (enter \"face the beast\" or \"run away\") ");

                string fight = Console.ReadLine();
                if (fight == "face the beast")
                {
                    Console.WriteLine("You approach the dragon. You see that he has__heads. (enter “1” or “2” or “3”):");


                    string numberOfHead = Console.ReadLine();
                    int head = int.Parse(numberOfHead);

                    if (head == 1)
                    {
                        Console.WriteLine("No one has ever faced a 1 headed dragon before! Choose your weapon. (enter “slingshot” or “sword” or “bow and arrow”):");

                        string Weapon = Console.ReadLine();
                        switch (Weapon)
                        {
                            case "slingshot":
                            case "sword":
                            case "bow and arrow":
                                Console.WriteLine("Armed with your" + Weapon + "you approach the dragon. You can feel its fiery breath as you get closer. It stares at you with its__eyes. (enter “red” or “blue”):");

                                break;

                            default:
                                Console.WriteLine("That's not an option...");
                                break;

                        }

                        string eyeColor = Console.ReadLine();
                        if (eyeColor == "red" || eyeColor == "blue")
                        { Console.WriteLine("Oh thank goodness! " + eyeColor + "-eyed dragons are friendly.You pet it and become friends.\n You name the dragon:"); }
                        else
                        { Console.WriteLine("Bad Choice!"); }

                        Console.ReadLine();


                    }
                    else if (head == 2)
                    {
                        Console.WriteLine("No one has ever faced a 2 headed dragon before! Choose your weapon. (enter “slingshot” or “sword” or “bow and arrow”):");

                        string Weapon = Console.ReadLine();
                        switch (Weapon)
                        {
                            case "slingshot":
                            case "sword":
                            case "bow and arrow":
                                Console.WriteLine("Armed with your" + Weapon + "you approach the dragon. You can feel its fiery breath as you get closer. It stares at you with its__eyes. (enter “red” or “blue”):");

                                break;

                            default:
                                Console.WriteLine("That's not an option...");
                                break;

                        }

                        string dragonName = Console.ReadLine();
                        askEyeColor(dragonName);


                      }
                    else
                    {
                        Console.WriteLine("No one has ever faced a 3 headed dragon before! Choose your weapon. (enter “slingshot” or “sword” or “bow and arrow”):");

                        string Weapon = Console.ReadLine();
                        switch (Weapon)
                        {
                            case "slingshot":
                            case "sword":
                            case "bow and arrow":
                                Console.WriteLine("Armed with your" + Weapon +
                                    "you approach the dragon. You can feel its fiery breath as you get closer. "
                                    + "It stares at you with its__eyes. (enter “red” or “blue”):");
                                break;

                            default:
                                Console.WriteLine("That's not an option...");
                                break;


                        }
                        string dragonName = Console.ReadLine();
                        askEyeColor(dragonName);

                    }

                   
                    


                }
                else
                {
                    Console.WriteLine("Run fast!!");

                }


            }

            else
            {
                Console.WriteLine("Goodbye");

            }
            Console.ReadLine();



        }

        static void askEyeColor(string anything)
        {
            string eyeColor = Console.ReadLine();
            if (eyeColor == "red" || eyeColor == "blue")
            {
                Console.WriteLine("Oh thank goodness! " + eyeColor + "-eyed dragons are friendly.You pet it and become friends.\nYou name the dragon:");
            }
            
            else
            { Console.WriteLine("Bad Choice!"); }


            Console.WriteLine(yourName + " and " + anything + " live happily ever after.");
            Console.ReadLine();

        }
    }

}


/*Welcome! What is your name? (enter your name):
Would you like to play a game? (enter “yes” or “no”):
Excellent! You are walking across a field and you encounter a fire-breathing dragon!
What would you do? (enter “face the beast” or “run away”):
You approach the dragon. You see that he has__heads. (enter “1” or “2” or “3”):
No one has ever faced a 3-eaded dragon before! Choose your weapon. (enter “slingshot” or “sword” or “bow and arrow”):
Armed with your bow and arrow you approach the dragon. You can feel its fiery breath as you get closer. It stares at you with its__eyes. (enter “red” or “blue”):
Oh thank goodness! Red-eyed dragons are friendly. You pet it and become friends.
Aisha and Toothless live happily ever after. 


bool condition = true;

if (condition)
{
    Console.WriteLine("The variable is set to true.");
}
else
{
    Console.WriteLine("The variable is set to false.");

    Console.Write("Enter a character: ");
char c = (char)Console.Read();
if (Char.IsLetter(c))
{
    if (Char.IsLower(c))

    tip: how to have quotes appear in the console? console.writeline("this is how to put \" in \")

    int caseSwitch = 1;
switch (caseSwitch)
{
    case 1:
        Console.WriteLine("Case 1");
        break;
    case 2:
        Console.WriteLine("Case 2");
        break;
    default:
        Console.WriteLine("Default case");
        break;
}

     string numberOfHeads = Console.ReadLine();
     int.Parse(numberOfHeads);


                    int headNumber = Console.Read();

    int caseSwitch = Console.Read();
                    switch (caseSwitch)
                    {
                        case 1:
                            Console.WriteLine("1");
                            break;
                        case 2:
                            Console.WriteLine("2");
                            break;
                        default:
                            Console.WriteLine("3");
                            break;

                    }

    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
        myMessage("hola ");
            string theSpecialText = DoSomething();
            Console.WriteLine(theSpecialText);
            Console.Read();
        }

            static void myMessage(string message) 
        {
                Console.WriteLine(message + "interesting");
                Console.WriteLine("double " + message + "stuff");
                Console.WriteLine("triple " + message + "hmmm");
            }

        static string DoSomething()
        {
            return "some thing in words";
        }

    }
}

    }

    

            string q4_eyeColor = Console.ReadLine();
            switch (q4_eyeColor)
            {
                case "red":
                case "blue":

                    Console.WriteLine("Oh thank goodness!" + q4_eyeColor  + "-eyed dragons are friendly.You pet it and become friends.");
                                break;

                default: 
                    Console.WriteLine (only red or blue)


     Console.WriteLine(yourName + " and " + dragonName + " live happily ever after.");
                Console.ReadLine();

            static void askHeadNumber()
        {
            string headNumber = Console.ReadLine();
            if (headNumber == "1" || headNumber == "2" || headNumber == "3")
            {
                Console.WriteLine("No one has ever faced a " + headNumber + " headed dragon before! Choose your weapon. (enter “slingshot” or “sword” or “bow and arrow”):");
            }
            else
            {
                Console.WriteLine("Pick 1, 2, or 3!");
            }
            
        }

    */




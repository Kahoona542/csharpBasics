bool isRaining = true;
bool isGoingOutside = true;
//if (true/false value)
//{
//    Body of code, execute this code if above is true
//}
if (isRaining)
{
    System.Console.WriteLine("It's raining out!");
}

//Is raining AND is going outside
if (isRaining && isGoingOutside)
{
    Console.WriteLine("Better bring an umbrella!");
}

//Not raining OR not going outside
if (!isRaining || !isGoingOutside)
{
    Console.WriteLine("I do not need an umbrella.");
}

// Exclusively not raining ORgoing outside
if (isRaining ^ isGoingOutside)
{
    Console.WriteLine("I will only go outside if it is not raining.");
}

//If else example based on the one condition, isGoingOutside
if (isGoingOutside)
{
    Console.WriteLine("Make sure to dress for the weather!");
}
else
{
    Console.WriteLine("Sounds like a sweats kind of day.");
}
//IF ELSE IF Exercise
Console.WriteLine("How are you feeling today on a scale of 1-5");
string feelingRating = Console.ReadLine();

if(feelingRating == "5")
{
    Console.WriteLine("That's great to hear!");
}
else if (feelingRating == "4")
{
    Console.WriteLine("Good stuff");
}
else if (feelingRating == "3")
{
    Console.WriteLine("Hope things improve!");
}
else if (feelingRating == "2")
{
    Console.WriteLine("Oh. Sorry to hear that.");
}
else if (feelingRating == "1")
{
    Console.WriteLine("Big Oof");
}
else
{
    Console.WriteLine("Sorry, you did something wrong. Try again.");
}
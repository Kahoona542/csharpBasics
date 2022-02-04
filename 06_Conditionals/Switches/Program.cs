string name = Console.ReadLine();
switch (name)
{
    case "Pete":
    //Code that runs if the variable name has the value of "Pete"
    break;
    default:
    //Code that runs for every other possible value for name
    break;
}

Console.WriteLine("How are you feeling today on a scale 1-5?");
string feelingRating = Console.ReadLine();

switch(feelingRating)
{
    case "5": //Checks to see if feelingRating has the value of "5"
    Console.WriteLine("That's great to hear!"); //Runs if the above case matches
    break; //Ends the code that runs if the above case is met
    case "4":
    Console.WriteLine("Good Stuff!");
    break;
    case "3":
    Console.WriteLine("Hope things improve!");
    break;
    case "2":
    Console.WriteLine("Dang...That sucks.");
    break;
    case "1":
    Console.WriteLine("Big Oof");
    break;
    default: //This is only used if none of the other cases are matches
    Console.WriteLine("Sorry, you did something wrong.");
    break;
}

//-- Switch Expressions
string username = Console.ReadLine();
string greeting = username switch 
{
    "Pete" => "Hello Pete", //Value that returns if the variable name has the value of "Pete"
    _ => "Who are you?" //Return value for every other possible value for name
};

Console.WriteLine("How were you feeling yesterday on a scale 1-5?");
string ratingInput = Console.ReadLine();
int yesterdayRating = int.Parse(ratingInput);

string responce = yesterdayRating switch 
{
    1 => "Big Oof.",
    2 => "That sucks buddy.",
    3 => "meh",
    4 => "Cool Beans!",
    5 => "great, lets do something.",
    _ => "WTF BRO?!"
};
Console.WriteLine(responce);
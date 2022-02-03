bool isSnowing = true;
bool isGoingOutside = false;
//if(true/false value)
//{
//  body of the code, execute this code if above is true
//}
if(isSnowing)
{
    Console.WriteLine("It is snowing out!");
}

if(isSnowing && isGoingOutside)
{
    Console.WriteLine("Better where some snow boots!!!");
}
if(!isSnowing || !isGoingOutside)
{
    Console.WriteLine("I do not need any boots!!");
}
if(isSnowing ^ isGoingOutside)
{
    Console.WriteLine("I will only go outside once the snow stops!!!");
}


if(!isSnowing)
{
    Console.WriteLine("There is no need to shovel snow!");
}

else{
    Console.WriteLine("I guess i need to shovel the snow");
}

if(isSnowing)
{
    Console.WriteLine("I guess i have to go clear off the wife's car.");
}
else if(!isSnowing)
{
    Console.WriteLine("I don't have to clear off the cars!");
}
else{
    Console.WriteLine("I don't know what we are talking about");
    )
}
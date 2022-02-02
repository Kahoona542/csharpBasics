//--Bronze
//Integers
int numOne = 5;
int numTwo = 27;
//Strings
string name = "Robin";
string car = "Volvo";
//Booleans
bool jojoIsAmazing = true;
bool jojoSucks = false;
//Floats
float numUno = 1.7f;
float numDos = 2.14f;
//Doubles
double numUn = 3.5712d;
double numDeux = 7.1934d;
//Decimals
decimal numUnu = 5.0m;
decimal numDu = 7.14m;
//Unsigned Longs
ulong positiveYes;
ulong positiveNO;
//Tests
Console.WriteLine(jojoIsAmazing);
Console.WriteLine(car);


//--Silver
string firstName = "Robin";
string lastName = "Hancock";
string fullName = firstName + "" + lastName;

//--Gold
//https://docs.microsoft.com/en-us/dotnet/csharp/programing-guide/types/how-to-convert-a-string-to-a-number
string year = "2022";
int yearNumber = int.Parse(year);
Console.WriteLine(yearNumber);

int anotherNumber = Convert.ToInt32(year);
Console.WriteLine(anotherNumber);
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// This is a single-line comment

/* This is a multi-line comment
 * (Second line
 */

int myNum = 50;
string myName = "John";
int x = 5;
int y = 10;
Console.WriteLine(x + y);

int z = x + y;
Console.WriteLine(z);

int a = 5, b = 6, c = 50;
Console.WriteLine(a + b + c);

int myNumber = 9;
double myDoubleNum = 8.99;
char myLetter = 'A';
bool myBool = false;
string myText = "Hello World";

bool yay = true;
bool nay = false;

string greeting = "Hello";
Console.WriteLine(greeting);

int myInt = 10;
Console.WriteLine(Convert.ToString(myInt));

Console.WriteLine("Enter username:");
string userName = Console.ReadLine();
Console.WriteLine("Username is: " + userName);

Console.WriteLine("Think of a number:");
myNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your number is: " + myNum);

Console.WriteLine(10 * 5);
Console.WriteLine(10 / 5);
x++;
x += 5;
x = 5;
y = 10;

//prints the highest value of x and y
Console.WriteLine(Math.Max(x, y));
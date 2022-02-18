// See https://aka.ms/new-console-template for more information

// Example Variables

/*In C#, there are different types of variables (defined 
 * with different keywords), for example:
 * 
 * int - stores integers (whole numbers), without decimals, 
 *      such as 123 or -123
 * double - stores floating point numbers, with decimals, 
 *      such as 19.99 or -19.99
 * char - stores single characters, such as 'a' or 'B'.
 *      Char values are surrounded by single quotes
 * string - stores text, such as "Hello World". String values are
 *      surrounded by double quotes
 * bool - stores values with two states: true or false
 * */

// character information
string charName = "Amruh the Dragon";
string charRace = "Ifrit";
string charGender = "female";
string charAlignment = "Chaotic Neutral";
double charHeight = 5.8;
int charWeight = 152;
string charHairColor = "dark red";
string charEyeColor = "golden";
string charSkinColor = "dark charcoal";
int charAge = 27;

// Console Interaction
Console.WriteLine("My character in D&D is: " + charName +".");
Console.WriteLine(charName + " is a " + charGender + " " + charRace + ".");
Console.WriteLine("She likes to do what she wants to do no matter the consequences to others. Her allignment is " + charAlignment + ".");
Console.WriteLine("Her height is " + charHeight + " and her weight is " + charWeight + ".");
Console.WriteLine("She has a " + charHairColor + " hair color and stunning " + charEyeColor + " eyes. She also has " + charSkinColor + " skin color.");
Console.WriteLine("She's the ripe age of " + charAge + ".");
Console.WriteLine(charRace + "'s can live past the age of 108! They aren't considered adults until 60 so " + charName + " is considered to be very young for an " + charRace + ".");

//Console readers interactions
Console.WriteLine("What is your character's name?");
Console.WriteLine("Character Name:");
string yourCharName = Console.ReadLine();
Console.WriteLine("Nice to meet you " + yourCharName + "!");
Console.WriteLine("Tell me a little about yourself! What's your race?");
string yourCharRace = Console.ReadLine();
Console.WriteLine("What's your gender?");
string yourCharGender = Console.ReadLine();
Console.WriteLine("That's super interesting! So you are " + yourCharName + " and you are a " + yourCharGender + " " + yourCharRace + "."); 


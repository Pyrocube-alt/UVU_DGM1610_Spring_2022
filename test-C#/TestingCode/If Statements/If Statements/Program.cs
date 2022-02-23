// See https://aka.ms/new-console-template for more information


// If Statements

/* if (condition)
 * {
 *      block of code to be executed if teh condition is True
 * }
 * 
 */

int x = 20;
int y = 18;
if (x > y)
{
    Console.WriteLine("x is greater than y");
}

// else statement to specify a block of code to be executed if the conditon is false.

/* if (condition)
 * {
 *      block of code to be executed if the condition is True
 * }
 * 
 * else
 * {
 *      block of code to be executed if the condition is False
 * }
 */

int time = 22;
if (time < 18)
{
    Console.WriteLine("Good day.");
}

else
{
    Console.WriteLine("Good evening.");
}

// else if, false statement to specify a new condition if the first condition is.

/* if (condition1)
 * {
 *      block of code to be executed if condition1 is True
 * }
 * 
 * else if (condition2)
 * {
 *      block of code to be executed if the condition1 is false and condition2 is True
 * }
 * 
 * else 
 * {
 *      block of code to be executed if the condition1 is false and condition2 is False
 * }
 */

if (time < 10)
{
    Console.WriteLine("Good Morning.");
}
else if (time < 20)
{
    Console.WriteLine("Good day.");
}
else
{
    Console.WriteLine("Good Evening.");
}

/* There is also a short-hand if else, which is known as the ternary operator because 
 * it consists of three operands. It can be used to replace multiple lines of code with
 * a single line. It is often used to replace simple if else statements:
 * 
 * 
 * variable = (condition) ? expressionTrue : expressionFalse;
 */

string result = (time < 18) ? "Good day." : "Good evening.";
Console.WriteLine(result);
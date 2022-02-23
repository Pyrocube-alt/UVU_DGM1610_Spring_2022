// See https://aka.ms/new-console-template for more information


/* switch(expression)
 * {
 *  case x:
 *      code block
 *      break;
 *  case y:
 *      code block
 *      break;
 *  default:
 *      code block
 *      break;
 * }
 * 
 * How it works:
 *      switch- -The expression is evaluated once
 *              -The value of the expression is compared with the values of each case
 *              -If there is a match, the associated block of code is executed
 */


int day = 4;
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
}

/* break keyword, it breaks out of the switch block.
 * 
 * This will stop the execution of more code and case testing inside the block.
 * 
 * When a match is found, and the job is done, it's time for a break. There is no need 
 * for more testing.
 * 
 * A break can save a lot of execution time because it "ignores" the execution of all 
 * the rest of the code in the switch block.
 *
 *
 * default keyword, is optional and specifies some code to run if there is no case match:
 */

int today = 4;
switch (today)
{
    case 6:
        Console.WriteLine("Today is Saturday.");
        break;
    case 7:
        Console.WriteLine("Today is Sunday.");
        break;
    default:
        Console.WriteLine("Looking forward to the Weekend.");
        break;
}
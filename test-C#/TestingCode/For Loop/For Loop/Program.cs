

/* for while loop instead of loop
 * 
 * for (statement 1; statement 2; statement 3)
 * {
 *    // code block to be executed
 * }
 * 
 * 
 * statement 1 - is executed (one time) before the execution of the code block.
 * statement 2 - defines the condition for executing the code block.
 * statement 3 - is executed (every time) after the code block has been executed.
 * 
 * The example below will print the numbers 0 to 4:
 */

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

/*  EXAMPLE EXPLAINED   
 *  
 *  int i = 0  statement 1 sets a variable before the loop starts ().
 *  
 *  i < 5   statement 2 defines the condition for the loop to run (must be less than).
 *              true/false - if the conditon is ture the loop will start over again. If 
 *                           it is false the loop will end.
 *
 *  i++     statement 3 increases a value () each time the code block in the loop has been
 *              executed.
 *              
 *              
 *  ANOTHER EXAMPLE
 */

for (int a = 0; a < 10; a = a + 2)
{
    Console.WriteLine(a);
}


/* foreach loop - which is used exclusively to loop through elements in an array:
 * 
 * foreach (type variableName in arrayName)
 * {
 *      // code block to be executed
 * }
 * 
 *  
 * The following example outputs all elements in the cars array, using a loop:
 */

string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
foreach (string i in cars)
{
    Console.WriteLine(i);
}
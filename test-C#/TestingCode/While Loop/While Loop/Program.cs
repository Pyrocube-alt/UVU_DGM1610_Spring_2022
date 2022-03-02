// See https://aka.ms/new-console-template for more information


/* while (condition)
 * {
 *    //code block to be executed
 * }
 * 
 * In the example below, the code in the loop will run, over and over again, as long as a
 * variable (i) is less than 5:
 */

int i = 0;
while (i < 5)
{
    Console.WriteLine(i);
    i++;
}

/* Do not forget to increase the variable used in the condition, otherwise the
 * loop will never end!
 *
 *
 * do/while - while loop is a variant of the loop. This loop will execute the code
 * block once, before checking if the condition is true, then it will repeat the 
 * loop as long as the conditon is true.
 * 
 * do
 * {
 *      // code block to be executed
 * }
 * while (condition);
 * 
 * 
 * The example below uses a loop. The loop will always be executed at least once,
 * even if the condition is false, because the code block is executed before the 
 * condition is tested:
 */

int a = 0;
do
{
    Console.WriteLine(a);
    a++;
}
while (a < 5);


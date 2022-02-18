// See https://aka.ms/new-console-template for more information


//Example of Operations

/* Operators are used to perform operations on variables and values.
 *      '+' in the example below, we use the operator to add together two values:
 *     int x = 100 + 50;
 *     
 *     '+' Although the operator is often used to add together two values, lin in the
 *     example above, it can also be used to add together a variable and a value, or a 
 *     variable and another variable:
 *     
 *     Example:
 *     int sum1 = 100 + 50;      150 (100 + 50)
 *     int sum2 = sum1 + 250;    400 (150 + 250)
 *     int sum3 = sum2 + sum2;   800 (400 + 400)
 *     
 * Arithmetic operators are used to perform common mathematical operations:
 * 
 * Operator        Name                Description                              Example
 *      +        Addition            Adds together two vaules                   X + y
 *      -        Subtraction         Subtracts one value from another           x - y
 *      *        Multiplication      Multiples two vaules                       x * y
 *      /        Division            Divides one value by another               x / y
 *      %        Modulus             Returns the division remainder             x % y
 *      ++       Increment           Increases the value of a variable by 1     x++
 *      --       Decrement           Decreases the value of a variable by 1     x--
 *
 * 
 * Assignment operators are used to assign values to variables.
 * 
 * Operator      Example     Same as
 *      =         x = 5         x = 5
 *      +=        x += 3        x = x + 3
 *      -=        x -= 3        x = x - 3
 *      *=        x *= 3        x = x * 3
 *      /=        x /= 3        x = x / 3
 *      %=        x %= 3        x = x % 3
 *      &=        x &= 3        x = x & 3
 *      |=        x |= 3        x = x | 3
 *      ^=        x ^= 3        x = x ^ 3
 *      >>=       x >>= 3       x = x >> 3
 *      <<=       x <<= 3       x = x << 3
 *      
 * 
 * Comparison operators are used to compare two values:

    Operator    Name	                    Example	
    ==	        Equal to	                x == y	
    !=	        Not equal	                x != y	
    >	        Greater than	            x > y	
    <	        Less than	                x < y	
    >=	        Greater than or equal to	x >= y	
    <=	        Less than or equal to	    x <= y	


    Logical operators are used to determine the logic between variables or values:

Operator	Name	    Description	                                                    Example	
    && 	Logical and	    Returns true if both statements are true	                    x < 5 &&  x < 10	
    || 	Logical or	    Returns true if one of the statements is true	                x < 5 || x < 4	
    !	Logical not	    Reverse the result, returns false if the result is true	!       (x < 5 && x < 10)
*/

int x = 10;
int y = 5;
Console.WriteLine(x /= y);
Console.WriteLine(x += y);
Console.WriteLine(x++);
Console.WriteLine(x--);
Console.WriteLine(y & 7);
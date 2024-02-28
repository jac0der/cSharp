/*
    Implementation of the FIZZBUZZ program. Find details in the
    FIZZBUZZ_README.
    
    @datetime:: February 28, 2024 2:26 am (UTC-5)
    @author:: jac0der
*/

// declaring global divisor constant values to check for.
const int DIVISOR_3 = 3;
const int DIVISOR_5 = 5;

/*
    Function to determine if a divisor is a multiple of dividend.
    Used the modulo (%) operator to determine if divisor is a multiple
    of dividend. Modulo operator returns the remainder from a division,
    if zero (0) is returned, then divisor is a multiple of dividend.
    @inputs::
            dividend - number being divided
            divisor - number being check to see if it is a multiple
                      of dividend.
    @output:: Boolean - true if divisor is a multiple of dividend,
              otherwise, false.
*/
bool is_multiple(int dividend, int divisor)
{
    if ( (dividend % divisor) == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

/*
    Function to loop through numbers from 1 to 100,
    printing 
        - FizzBuzz if a number is both a multiple of 3 and 5
        - Fizz if a number is a multiple of 3
        - Buzz if a number is a multiple of 5
    
    @output:: void function - returns nothing.
*/
void fizz_buzz()
{
    // loop numbers from 1 to 100
    for(int i = 1; i <= 100; i++)
    {
         // check if i is both a multiple of 3 AND 5
        if (is_multiple(i, DIVISOR_3) && is_multiple(i, DIVISOR_5))
        {
            Console.Write("FizzBuzz ");
        }
        else if(is_multiple(i, DIVISOR_3)) // check if i is multiple of 3
        {
            Console.Write("Fizz ");
        }
        else if(is_multiple(i, DIVISOR_5)) // check if i is multiple of 5
        {
            Console.Write("Buzz ");
        }
        else
        {
            Console.Write(i.ToString() + " "); // no multiple found, print i
        }
    }
}

// call fizz_buzz() method
fizz_buzz();


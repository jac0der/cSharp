/*
    c# factorial implementation for positive 
    whole numbers.
    
    @datetime:: February 28, 2024 2:56 am (UTC-5)
    @author:: jac0der
*/


/***
    Function to get input number from user..
    @output:: number successfully cast from string input.
***/
long get_input()
{
    long number;
    do
    {
        try
        {
            Console.Write("Enter number: ");
            // accept number from user            
            number = Convert.ToInt64(Console.ReadLine());

            if(number < 0)
            {
                Console.WriteLine("Please provide a positive integer");
            }
            else
            {
                return number;
            }
        }
        catch(FormatException fe)
        {
            Console.WriteLine("Please provide a numeric input");
            Console.WriteLine(fe.Message);
        }       
    }
    while(true);   
}

/***
    Function to find the factorial of a number
    @input:: number to retrieve factorial for
    @output:: factorial of input number
***/
long factorial(long number)
{     
    // 1! is 1 so return 1 - base case met
    if(number == 1 || number == 0)
        return 1;

    // recursively call factorial on n - 1
    return number * factorial(number - 1);
}

/***
    function to perform the factorial of number
    if entered number is valid.
***/
void calculate_factorial()
{
    long user_input = get_input();

    if(user_input >= 0)
    {
        Console.WriteLine($"Factorial of {user_input} is: " + factorial(user_input));
    }
}

// call method to start the process
calculate_factorial();
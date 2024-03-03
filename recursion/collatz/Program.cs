/*
    c# collatz program implementation.
    
    @datetime:: March 02, 2024 3:45 am (UTC-5)
    @author:: jac0der
*/
using System;

/***
    function to get user number input cast to an integer.

    @input:: none
    @output"::int -> number to fint collatz of.
***/
int get_input()
{
    do
    {
        try
        {
            Console.WriteLine("Enter number: ");

            // get input from user and cast to integer
            int number = Convert.ToInt32(Console.ReadLine());

            switch(number)
            {
                case < 0:
                    Console.WriteLine("Enter a positive number.");
                    Console.WriteLine();
                    break;
                default:
                    return number;
            }
        }
        catch(FormatException fe)
        {
            Console.WriteLine("Invalid Input, enter a numeric value.");
            Console.WriteLine(fe.Message);
            Console.WriteLine();
        }
    }
    while(true);
}

/***
    function to return the collatz conjucture of a
    positive integer.
    Add 1 to each recursive call.

    @input::
        int::number -> integer to find collatz of.
    @output::
        int -> count of number of steps it takes to get from
               number to 1.
***/
int collatz(int number)
{
    if (number == 1)
    {
        return 0;
    }

    if(number % 2 == 0)
    {
        return 1 + collatz(number / 2);
    }
    else
    {
        return 1 + collatz((3 * number) + 1);
    }
}

/***
    function to start the process of finding
    the collatz coonjucture of a positive integer.

    @input:: none
    @output:: Print out of the collatz of an integer.
***/
void count_steps()
{
    int steps;

    try
    {
        // get user input number
        int number = get_input();

        steps = collatz(number);

        Console.Write($"Number of steps from {number} to 1: " + steps);
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

// call trigger method to start the process of finding collatz of number.
count_steps();




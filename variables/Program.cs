// See https://aka.ms/new-console-template for more information
/*
    Variables are simple place holders for data used within a 
    computer program. Specifically, a variable tells the 
    computer to reserve some location in memory to store 
    data of a certain type. The name of the variable is 
    then used to refer to this memory location where the 
    value is stored.

    C# null coalescing operator.
    Declaring variables describing a favorite song.
    
    @Modified Datetime:: March 03, 2024 12:26 pm (UTC-5)
    @author:: jac0der
*/
using variables.Models;

// creating a nullable type with the ? (question mark)
int? year = null;

Person? person = null;

/*
    The C# double question mark operator ?? is known as the null 
    coalescing operator.
    In a nutshell, the null coalescing operator is "if the first 
    value is null, use this other value."
    Null coalescing operator is a binary operator that takes two 
    operands: the first operand is an expression that can be null, 
    and the second operand is the value that I want to assign to 
    the expression variable (personValue) if it is not null.
*/
var personValue = person ?? new Person()
{
    First_name = "Jim",
    Last_name = "bo"
};

// print the value of the created person's firstname, once perosn object is null.
Console.WriteLine(personValue.First_name);


/*************************** Defining c# variables ****************************/


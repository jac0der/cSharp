/*
    esxploring c# exception handling.
    
    @datetime:: December 09, 2024 11:34 pm (UTC-5)
    @author:: jac0der
*/
using System;
using exceptionshandling.services;


Console.WriteLine("Enter the id of user to retrieve");

// since retrieving a user could cause an error, add a try catch around this code.
try
{
    int user_id = Convert.ToInt32(Console.ReadLine());

    var userService = new UserService();
    var user = userService.GetById(user_id);

    Console.WriteLine($"The user you selected is: {user.Name}");
}
catch(FormatException fe)
{
    Console.WriteLine(fe.Message);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}




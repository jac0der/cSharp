/*
    esxploring c# exception handling.
    
    @datetime:: December 09, 2024 11:34 pm (UTC-5)
    @author:: jac0der
*/
using System;
using System.Globalization;
using exceptionshandling.services;

var userService = new UserService();
 int user_id = 0;

Console.WriteLine("Enter the id of user to retrieve");

// since retrieving a user could cause an error, add a try catch around this code.
try
{
    user_id = Convert.ToInt32(Console.ReadLine());
    var user = userService.GetById(user_id);

    Console.WriteLine($"The user you selected is: {user.Name}");
}
catch(FormatException fe) // specific exception catch
{
    Console.WriteLine(fe.Message);
}
catch(InvalidUserIdException iue) when (user_id <= 0) // conditional exception catch
{
    Console.WriteLine("User id must be a positive number. " + iue.Message);
}
catch(InvalidUserIdException iue) when (user_id >= 1000) // conditional exception catch
{
    Console.WriteLine("User ID should be smaller than 1000. " + iue.Message);
}
catch(Exception ex) // generall catch all exception catch
{
    Console.WriteLine("An Unexpected Error has occurred.");
    Console.WriteLine(ex.Message);
}
finally // execute code whether or not an exception has occured.
{
    userService?.Clear();
}




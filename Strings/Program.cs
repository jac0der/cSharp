﻿/*
    Exploring string methods.
    
    @author:: jac0der
    @Modified Datetime:: March 03, 2024 12:26 pm (UTC-5)
*/


//** 1 => defining a string
string text = "KJDsdo";
string name = "jac0der";


//** 2 => length of a string (Length property of tdhe string object)
int strlen = text.Length;
Console.WriteLine(strlen);


//** 3 => ToUpper/ToLower case
Console.WriteLine("uppercased: " + name.ToUpper());
Console.WriteLine("lowercased: " + name.ToLower());


//** 4 => string concatenation
string firstname = "Jane", lastname = "Doe";  // declaring multiple variables in one line, different values.
string fullname = firstname + " " + lastname;
Console.WriteLine("fullname is: " + fullname);

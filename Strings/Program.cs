/*
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


//** 4 => string concatenation (+)
string firstname = "Jane", lastname = "Doe";  // declaring multiple variables in one line, different values.
string fullname = firstname + " " + lastname;
Console.WriteLine("fullname is: " + fullname);
// using the string.Concat() method
Console.WriteLine(string.Concat(firstname," ", lastname, " How are you", "?"));


//** 5 => string interpolation (another form of concatenation)
string food = "pizza";
string person = "John";
string message = $"{person}'s favorite food is {food}.";
Console.WriteLine(message);


//** 6 => accessing characters within a string
string country = "Jamaica";
Console.WriteLine(country[2]);  // m










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


//** 7 => IndexOf()/LastIndexOf() methods
int a_index = country.IndexOf('a');  // 1
Console.WriteLine(a_index);

// specify what index to start searching from
a_index = country.IndexOf('a', 2);  // 3
Console.WriteLine(a_index);

int a_lindex = country.LastIndexOf('a');  // 6
Console.WriteLine(a_lindex);


//** 8 => substring
string who = "John Doe";
int lnamepos = who.IndexOf('D');
string lname = who.Substring(lnamepos);
Console.WriteLine(lname);

string script = "here is an example sample text for substring testing";
Console.WriteLine(script.Substring(19));    // sample text for substring testing
Console.WriteLine(script.Substring(19, 6)); // sample


//** 9 => Contains, StartsWith, EndsWith
Console.WriteLine(script.Contains("example"));  // True
Console.WriteLine(script.Contains("board"));    // False

Console.WriteLine(who.StartsWith("John"));      // True
Console.WriteLine(who.EndsWith("John"));        // False


//** 10 => Remove, Insert
string welcome = "Welcome to Jamrock!";
Console.WriteLine(welcome.Remove(8));   // Welcome
Console.WriteLine(welcome.Remove(7,4)); // WelcomeJamrock!

// insert value into welcome string - starting at index after last index.
Console.WriteLine(welcome.Insert(welcome.Length, " The best country eva!"));


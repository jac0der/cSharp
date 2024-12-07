
/*
    Exploring typcasting in c#.

    @author:   jac0der
    @datetime: December 07, 2024 UTC-5
*/

// implicit type casting (automatic): converting a smaller type to a larger type size.


using System;

int intValue = 9;
double doubleValue = intValue; // automatic casting: int to double

Console.WriteLine(intValue);
Console.WriteLine(doubleValue);

// implicit conversion in an expression
double b = 12.45;
int x = 10;
b = b + x;              // x is implicitly converted to double first
Console.WriteLine(b);


// implicit conversion when compiler stores result to a variable
// y and t are integers, and integer devision produces integer result,
// which is implicitly converted and assigned to q.
int y = 20;
int t = 10;
double q;

q = y / t;
Console.WriteLine(q);

// without explicit casting on either e or f, the result is the
// integer result of 4 from the integer division.
// but with explicit cast specified (double), the result is 4.2.
int e = 21;
int f = 5;
double g = (double)e/f;
Console.WriteLine(g);


// explicit casting (manually): converting a larger type to a smaller type.
double cost = 9.78;
int value = (int)cost;      // manual casting: double to int
Console.WriteLine(cost);    // 9.78
Console.WriteLine(value);   // 9


// using the Convert class for type conversion
int velocity = 50;
float price = 7.2F;
double tax = 4.2;

Console.WriteLine(Convert.ToDouble(velocity));
Console.WriteLine(Convert.ToInt32(tax));
Console.WriteLine(Convert.ToString(price));
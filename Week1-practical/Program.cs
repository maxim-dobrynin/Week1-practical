/* Task 1 start
// initialise variables
int age;
int futureAge;
string name;

// Ask user for their name
Console.WriteLine("Please enter your name ");
name = Console.ReadLine();

// Ask user for their age
// Convert string to integer using explicit typecasting
Console.WriteLine("Please enter your age?");
age = Convert.ToInt32(Console.ReadLine());

// Calculate future age
futureAge = age + 5;

// Print final message
Console.WriteLine($"Hello {name}, you will be {futureAge} in 5 years.");

Task 1 end */



/* Task 2 start
 * 
// intitialise variables
int age;

// Ask user for their age
Console.WriteLine("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

if(age < 0)
{
    Console.WriteLine("Ivalid age, please enter a positive value.");
}
else if(age <= 12)
{
    Console.WriteLine("This person is a child.");
}
else if(age >= 13 && age <= 19)
{
    Console.WriteLine("This person is a teenager.");
}
else if(age > 110)
{
    Console.WriteLine("Invalid age, please enter a value below 110");
}
else
{
    Console.WriteLine("This person is an adult.");
}

 Task 2 end */


/* Task 3 start 
 * 
// Initialise variables
int number;

// Ask user for input of integer
Console.WriteLine("Please enter an integer: ");
number = Convert.ToInt32(Console.ReadLine());

// negative integer
if(number < 0)
{
    Console.WriteLine("This is a negative integer.");
}

// positive integer
else if(number > 0)
{
    Console.WriteLine("This is a positive integer.");
}

// if input is 0
else
{
    Console.WriteLine("This number is zero.");
}
Task 3 end */


/* Task 4 start
 * 
// Initialise variables
int year;

// Ask user for year input
Console.WriteLine("Please enter a year: ");
year = Convert.ToInt32(Console.ReadLine());

// Handle negative year input
if(year < 0)
{
    Console.WriteLine("Please enter a positive year.");
}

// Divisible by 4
// Not divisible by 100
// Or alternatively is also divisible by 400
else if((year % 4 == 0 && year % 100 != 0) || (year % 400 ==0));
{
    Console.WriteLine($"{year} is a leap year.");
}
Task 4 end */


/* Task 5 start
 * 
// initialise variables
int number;

// Ask user for input
Console.WriteLine("Please enter an integer: ");
number = Convert.ToInt32(Console.ReadLine());

// even number check
if(number %2 == 0)
{
    Console.WriteLine("This is an even number.");
}

// odd number check
else
{
    Console.WriteLine("This is an odd number.");
}
Task 5 end*/
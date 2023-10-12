/*
This exercise asks you to define a Method that reads a Value from its Field.

Create a Person Class
Give it a Field for their Name
Give it a Method named Greeting
It should print "Hello, I'm Marc!" (or whatever their name is) to the Console
Create an Array with 3 People
Let the Console User decide their names
Afterwards invoke Greeting on all People
*/

Person[] people = new Person [3]; 

for (var i = 0; i < people.Length; i++)
{
    people[i] = new Person();
}

Console.WriteLine("Name your first character:");
people[0].Name = Console.ReadLine();
Console.WriteLine("Name your second character:");
people[1].Name = Console.ReadLine();
Console.WriteLine("Name your third character:");
people[2].Name = Console.ReadLine();

for (var i = 0; i < people.Length; i++)
{
    people[i].Greeting();
}





    




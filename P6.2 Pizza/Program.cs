/*
Create a class named Pizza
It has a Field named Slices of Type int
Create a class named Person
It has a Field named Meal of Type Pizza
It has a Method named Eat that:
If Meal still has a Slice: It prints Name: Eating Pizza (x Slices Left). and reduces Slices by 1.
Otherwise: It prints Name: Pizza is Empty already :(
In your Program.cs:

Instantiate 3 People with different names (ask the User)
Instantiate a Pizza with 7 Slices and Assign it to all People
Let each Person eat Pizza 3 times.
*/

Pizza pizza1 = new Pizza();
pizza1.slices = 7;



Person[] people = new Person [3]; 

Console.WriteLine("Name your first character:");

for (var i = 0; i < people.Length; i++)
{
    people[i] = new Person();
}

for (var i = 0; i < people.Length; i++)
{
    people[i] = Console.ReadLine();
}


string p1 = Console.ReadLine();
Console.WriteLine("Name your second character:");
string p2 = Console.ReadLine();
Console.WriteLine("Name your third character:");
string p3 = Console.ReadLine();



people[0].Eat();
people[1].Eat();
people[2].Eat();


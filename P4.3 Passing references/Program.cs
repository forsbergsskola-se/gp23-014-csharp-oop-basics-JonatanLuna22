/*
Define a class named House
It has a Field named Owner which stores the name of the Owner
It has a Method named PrintOwner which prints "This house is owned by XX."
In your Program.cs:
Add a Function named Sell
It takes an Argument of Type House
It changes the Owner of that House to "Alex"
Instantiate your House and assign it to a variable
Invoke PrintOwner on the Variable
Invoke Sell and pass the Variable as an Argument
Invoke PrintOwner on the Variable
*/

House house1 = new House();

void Sell(House house)
{
  house1.Owner = "Alex";
}

house1.PrintOwner();
Sell(house1);
house1.PrintOwner();
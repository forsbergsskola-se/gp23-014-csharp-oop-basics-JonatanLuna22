/*
Create a class named Plant
Give it a Method named CanGrow that prints "I can grow." when invoked.
Create a class named Grain
Give it a Method named CanBeHarvested that prints "I can be harvested." when invoked.
Create a class named Wheat
Give it a Method named CanBeProcessedToBread that prints "I can be processed to bread." when invoked.
Make Grain inherit from Plant.
Make Wheat inherit from Grain.
Create instances of all three classes.
Invoke all possible Methods on all of these classes.
*/

Plant plant1 = new Plant();
Grain grain1 = new Grain();
Wheat wheat1 = new Wheat();

plant1.CanGrow();
Console.WriteLine();
grain1.CanGrow();
grain1.CanBeHarvested();
Console.WriteLine();
wheat1.CanGrow();
wheat1.CanBeHarvested();
wheat1.CanBeProcessedToBread();
/*
Define a class named Plant
Define a Field named isGrown which can store whether the Plant has grown into a tree.
Define a Method PrintStatus which prints either "Plant is a seed." or "Plant is a tree." depending on its status.
Define a Method Grow which prints "Plany is growing." and also changes the state of isGrown.
Instantiate Plant and assign it to a variable named plant.
Check the Status.
Make it Grow.
Check the Status.
Make it Grow.
Assign a new instance of class Plant to the same variable.
Check the Status.
*/

Plant plant1 = new Plant();
Plant plant2 = new Plant();

plant1.PrintStatus();
plant1.Grow();
plant1.PrintStatus();
plant1.Grow();
Console.WriteLine();
plant2.PrintStatus();


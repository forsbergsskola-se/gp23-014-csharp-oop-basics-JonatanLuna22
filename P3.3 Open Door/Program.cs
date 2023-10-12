/*
This exercise asks you to define a Method that changes a class Field.

Instructions
Create a House Class

It has a door that can be open or closed (bool)

It has a method OpenDoor that opens the door

It has a method CloseDoor that closes the door

Create two houses blueHouse and redHouse

Print for both houses whether the door is open (should be false and false)

Open the Door at blueHouse

Print for both houses whether the door is open (should be true and false)

Open the Door at redHouse

Print for both houses whether the door is open (should be true and true)
*/

House blueHouse = new House();
House redHouse = new House();

void print()
{
    Console.WriteLine($"The blue house is open {blueHouse.door}.");
    Console.WriteLine($"The red house is open {redHouse.door}.");
    Console.WriteLine();
}

print();
blueHouse.OpenDoor();
print();
redHouse.OpenDoor();
print();
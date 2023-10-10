/*
Create a Console Project named P2Fields
Design a Class that contain all information needed for the above player.
Assign the information to a new instance of said class.
Print all information of that class to the console.

Player A has 200 Gold, 110 Stone, 53 Wood. He is level 12 and has 123 Experience. 
He has an active VIP subscription, but PVP disabled. 
His display name is Marc and his e-mail address marc@zaku.de
*/

Player Marc = new Player();     

Console.WriteLine($"User name: {Marc.userName}.");
Console.WriteLine($"Email: {Marc.email}.");
Console.WriteLine();
Console.WriteLine($"Gold: {Marc.gold}.");
Console.WriteLine($"Stone: {Marc.stone}.");
Console.WriteLine($"Wood: {Marc.wood}.");
Console.WriteLine();
Console.WriteLine($"Level: {Marc.level}.");
Console.WriteLine($"Experience: {Marc.experience}.");
Console.WriteLine();
Console.WriteLine($"VIP: {Marc.VIP}.");
Console.WriteLine();
Console.WriteLine($"PVP: {Marc.PVP}.");


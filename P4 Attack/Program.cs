/*
Create a Console Project named P4Attack
Define a class named Player
Define a Field named Damage of Type int
Define a Method named Attack
It takes an Argument of Type Player named target
When executed, it increments the Field Damage of the target
Create a Player and assign it to Variable player1
Create a Player and assign it to Variable player2
Invoke Attack on player1 and pass in player2 as an argument
Print the Damage Field of player1 and player2 to the Console
Invoke Attack on player2 and pass in player1 as an argument
Print the Damage Field of player1 and player2 to the Console
Invoke Attack on player1 and pass in player1 as an argument
Print the Damage Field of player1 and player2 to the Console
Assign player1 to a new Variable player3
Have player2 attack player3
Print the Damage Field of player1, player2 and player3 to the Console
*/

Player player1 = new Player();
Player player2 = new Player();

player1.Attack(player2);
Console.WriteLine(player1.Damage);
Console.WriteLine(player2.Damage);
player2.Attack(player1);
Console.WriteLine(player1.Damage);
Console.WriteLine(player2.Damage);
player1.Attack(player1);
Console.WriteLine(player1.Damage);
Console.WriteLine(player2.Damage);

Player player3 = player1;

player2.Attack(player3);
Console.WriteLine(player1.Damage);
Console.WriteLine(player2.Damage);
Console.WriteLine(player3.Damage);
﻿/*
Create a Console Project named P3LevelUp
Define a class named Player
Define a Method named GrantExperience
It takes an argument that defines how much Experience the player is supposed to get.
It adds that experience to the Player's Experience.
Every time, the Player has 100 Experience or more, he levels up.
He keeps his extra experience.
He can theoretically level up multiple Levels at once.
Create an instance of class Player
Allow the user repeatedly to define, how much Experience he wants to grant the Player and use the GrantExperience Method to grant it.
*/

Console.WriteLine("How many experience do you grant?");
int input = int.Parse(Console.ReadLine());

Player player1 = new Player();
Player player2 = new Player();

player1.GrantExperience(input);
player2.GrantExperience(input);



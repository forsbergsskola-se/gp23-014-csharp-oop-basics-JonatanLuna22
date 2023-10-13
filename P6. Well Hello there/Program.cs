/*
Create a class named Lightsaber.
Create a class named ObiWan with one Field named Weapon (of Type Lightsaber).
Create an instance of the class ObiWan and assign it to a variable.
Print the variable itself to the Console.
Print the variable's field Lightsaber to the Console.
Assign a new instance of type Lightsaber to the variable's field Weapon.
Print the variable's field Lightsaber to the Console.
*/

ObiWan obiWan1 = new ObiWan();

Console.WriteLine(obiWan1);
Console.WriteLine(obiWan1.Weapon);

Lightsaber lightsaber1 = new Lightsaber();
lightsaber1 = obiWan1.Weapon;

Console.WriteLine(lightsaber1);
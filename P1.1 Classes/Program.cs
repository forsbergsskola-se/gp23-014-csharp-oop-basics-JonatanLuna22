/*
Create a Console Project named P1_1Classes
Create 3 Classes:
Person
Animal
Car
For each of these classes:
Create one new instance (object) of the class and assign it to a variable
Use Console.WriteLine and pass that instance (object) into the method
*/

Animal leon;
leon = new Animal();
Console.WriteLine(leon); // Aqui lo hago diferente para ver de donde viene, pero es lo mismo que car y person.

Car ferrari = new Car();
Console.WriteLine(ferrari);

Person rosi = new Person();
Console.WriteLine(rosi);

// Como lo entiendo ahora. Animal seria el tipo de variable. "leon" es el nombre que le estamos dando a una variable concreta.
// el valor de la variable la definiremos nosotros mas adelante dentro de la public class.
// int age = 32; Animal leon = no value. Es igual a cero porque no hemos asignado ningun valor a leon, solo lo creamos. 
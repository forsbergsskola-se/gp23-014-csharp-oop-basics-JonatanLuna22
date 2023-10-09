/*
Create a Console Project named P1People
Create a Class named Person
Create an array that contains 3 Person instances
Print each Person to the Console using Console.WriteLine
*/

Person[] person = new Person[3];

for (var i = 0; i < person.Length; i++)
{
    person[i] = new Person();
}

for (var i = 0; i < person.Length; i++)
{
    Console.WriteLine(person[i]);
}
